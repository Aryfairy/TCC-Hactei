using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace projetoetec
{
    public partial class frmConsultaGeral : Form
    {
        private dal_SQLServerDBManager dbManager;
        private string professorSelecionado;
        private bool isChangingForm = false; // Variável de membro para controle de mudança de formulário

        public frmConsultaGeral()
        {
            InitializeComponent();
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=etecja_reservas;Integrated Security=True";
            dbManager = new dal_SQLServerDBManager(connectionString);
            dbManager.AbrirConexao();
            this.FormClosing += new FormClosingEventHandler(frmConsultaGeral_FormClosing);
        }

        private void frmConsultaGeral_Load(object sender, EventArgs e)
        {
            CarregarProfessores();
            cboProfessor.SelectedIndex = -1;
            cboProfessor.Text = "Selecione um(a) professor(a)";

            // Associar o evento SelectedIndexChanged da combobox cboProfessor
            cboProfessor.SelectedIndexChanged += cboProfessor_SelectedIndexChanged;

            // Inicializar ListBoxes
            lbxAtuais.Items.Add("Selecione um(a) professor(a)");
            lbxExcluir.Items.Add("Selecione um(a) professor(a)");

            // Desabilitar botões e ListBoxes
            lbxAtuais.Enabled = false;
            lbxExcluir.Enabled = false;
            btnMoverDireita.Enabled = false;
            btnMoverEsquerda.Enabled = false;
            btnExcluirReserva.Enabled = false;
        }

        // Carregar ComboBox de Professores
        private void CarregarProfessores()
        {
            try
            {
                string comandoSQL = "SELECT CONCAT(prof_nome, ' - ', prof_disciplina) AS nome_disciplina FROM professor";
                dbManager.CarregarComboBox(cboProfessor, comandoSQL, "nome_disciplina");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os professores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            professorSelecionado = cboProfessor.SelectedItem as string;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Verifica se um professor foi selecionado
            string professorSelecionado = cboProfessor.Text;
            if (string.IsNullOrEmpty(professorSelecionado) || professorSelecionado == "Selecione um(a) professor(a)")
            {
                MessageBox.Show("Por favor, selecione um professor antes de consultar suas reservas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se um professor foi selecionado, prosseguir com a consulta
            DataTable dtProfessor = ConsultarDadosProfessor(professorSelecionado);
            if (dtProfessor != null && dtProfessor.Rows.Count > 0)
            {
                DataRow professorRow = dtProfessor.Rows[0];
                lblNomeProfSelected.Text = professorRow["prof_nome"] != DBNull.Value ? professorRow["prof_nome"].ToString() : "—";
                lblDisciplinaProfSelected.Text = professorRow["prof_disciplina"] != DBNull.Value ? professorRow["prof_disciplina"].ToString() : "—";
                lblEmailSelected.Text = professorRow["prof_email"] != DBNull.Value ? professorRow["prof_email"].ToString() : "—";
                lblCelularSelected.Text = professorRow["prof_celular"] != DBNull.Value ? FormatCellPhoneNumber(professorRow["prof_celular"].ToString()) : "—";
                int numeroReservas = ConsultarNumeroReservasPosteriores(professorSelecionado);
                lblReservasSelected.Text = numeroReservas.ToString();

                if (numeroReservas == 0)
                {
                    // Se não houver reservas para o professor, exibir a mensagem e desabilitar a ListBox lbxAtuais
                    lbxAtuais.Items.Clear();
                    lbxAtuais.Items.Add("Não há reservas para esse professor");
                    lbxAtuais.Enabled = false;

                    // Limpar a ListBox lbxExcluir
                    lbxExcluir.Items.Clear();
                    lbxExcluir.Enabled = false;
                }
                else
                {
                    DataTable reservas = dbManager.CarregarReservasPosteriores(professorSelecionado);
                    List<string> reservasFormatadas = new List<string>();
                    foreach (DataRow row in reservas.Rows)
                    {
                        string descricaoReserva = $"{((DateTime)row["res_data"]).ToString("dd/MM/yyyy")} - {((TimeSpan)row["res_horainicial"]).ToString(@"hh\:mm")} às {((TimeSpan)row["res_horafinal"]).ToString(@"hh\:mm")} - {row["lab_nome"]} - {row["lab_sala"]} - {row["lab_disc"]}";
                        reservasFormatadas.Add(descricaoReserva);
                    }

                    lbxAtuais.Items.Clear();
                    lbxAtuais.Items.AddRange(reservasFormatadas.ToArray());

                    // Habilitar a ListBox lbxAtuais
                    lbxAtuais.Enabled = true;

                    // Limpar a ListBox lbxExcluir
                    lbxExcluir.Items.Clear();
                    lbxExcluir.Enabled = true;
                }

                // Habilitar botões
                btnMoverDireita.Enabled = true;
                btnMoverEsquerda.Enabled = true;
                btnExcluirReserva.Enabled = true;
            }
            else
            {
                // Se não houver dados do professor, limpar os campos e desabilitar as ListBoxes e botões
                lblNomeProfSelected.Text = "—";
                lblDisciplinaProfSelected.Text = "—";
                lblEmailSelected.Text = "—";
                lblCelularSelected.Text = "—";
                lblReservasSelected.Text = "0";
                lbxAtuais.Items.Clear();
                lbxAtuais.Enabled = false;
                lbxExcluir.Items.Clear();
                lbxExcluir.Enabled = false;
                btnMoverDireita.Enabled = false;
                btnMoverEsquerda.Enabled = false;
                btnExcluirReserva.Enabled = false;
            }
        }

        private int ObterCodigoLaboratorio(string labNome, string labSala, string labDisc)
        {
            string comandoSQL = "SELECT lab_cod FROM laboratorio WHERE lab_nome = @Nome AND lab_disc = @Disciplina AND lab_sala = @Sala";
            SqlParameter[] parametros = {
                new SqlParameter("@Nome", labNome),
                new SqlParameter("@Disciplina", labDisc),
                new SqlParameter("@Sala", labSala)
            };
            DataTable resultado = dbManager.ConsultarDados(comandoSQL, parametros);
            return resultado.Rows.Count > 0 ? Convert.ToInt32(resultado.Rows[0][0]) : 0;
        }

        private int ObterCodigoProfessor(string nomeDisciplina)
        {
            string comandoSQL = "SELECT prof_cod FROM professor WHERE CONCAT(prof_nome, ' - ', prof_disciplina) = @NomeDisciplina";
            SqlParameter[] parametros = { new SqlParameter("@NomeDisciplina", nomeDisciplina) };
            DataTable resultado = dbManager.ConsultarDados(comandoSQL, parametros);
            return resultado.Rows.Count > 0 ? Convert.ToInt32(resultado.Rows[0][0]) : 0;
        }

        private DataTable ConsultarDadosProfessor(string professor)
        {
            string comandoSQL = "SELECT prof_nome, prof_disciplina, prof_email, prof_celular FROM professor WHERE CONCAT(prof_nome, ' - ', prof_disciplina) = @Professor";
            SqlParameter[] parametros = { new SqlParameter("@Professor", professor) };
            return dbManager.ConsultarDados(comandoSQL, parametros);
        }

        private string FormatCellPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length == 11)
            {
                return string.Format("({0}) {1}-{2}", phoneNumber.Substring(0, 2), phoneNumber.Substring(2, 5), phoneNumber.Substring(7, 4));
            }
            else
            {
                return phoneNumber;
            }
        }

        private int ConsultarNumeroReservasPosteriores(string professor)
        {
            DateTime dataHoraAtual = DateTime.Now.Date; // Ajuste para pegar apenas a data atual sem a hora
            string comandoSQL = "SELECT COUNT(*) FROM reserva WHERE prof_cod = (SELECT prof_cod FROM professor WHERE CONCAT(prof_nome, ' - ', prof_disciplina) = @Professor) AND res_data > @DataHoraAtual";
            SqlParameter[] parametros = { new SqlParameter("@Professor", professor), new SqlParameter("@DataHoraAtual", dataHoraAtual) };
            DataTable resultado = dbManager.ConsultarDados(comandoSQL, parametros);
            return resultado.Rows.Count > 0 ? Convert.ToInt32(resultado.Rows[0][0]) : 0;
        }

        private void btnMoverDireita_Click(object sender, EventArgs e)
        {
            List<string> itensSelecionados = new List<string>();
            foreach (var item in lbxAtuais.SelectedItems)
            {
                itensSelecionados.Add(item.ToString());
            }

            foreach (string item in itensSelecionados)
            {
                lbxAtuais.Items.Remove(item);
                lbxExcluir.Items.Add(item);
            }
        }

        private void btnMoverEsquerda_Click(object sender, EventArgs e)
        {
            List<string> itensSelecionados = new List<string>();
            foreach (var item in lbxExcluir.SelectedItems)
            {
                itensSelecionados.Add(item.ToString());
            }

            foreach (string item in itensSelecionados)
            {
                lbxExcluir.Items.Remove(item);
                lbxAtuais.Items.Add(item);
            }
        }

        private void ExcluirReserva(int labCod, int profCod, DateTime resData, TimeSpan resHoraInicial)
        {
            try
            {
                // Comando SQL para exclusão da reserva
                string comandoSQL = "DELETE FROM reserva WHERE lab_cod = @LabCod AND prof_cod = @ProfCod AND res_data = @ResData AND res_horainicial = @ResHoraInicial";

                // Parâmetros para o comando SQL
                SqlParameter[] parametros = {
            new SqlParameter("@LabCod", labCod),
            new SqlParameter("@ProfCod", profCod),
            new SqlParameter("@ResData", resData),
            new SqlParameter("@ResHoraInicial", resHoraInicial)
        };

                // Execução do comando SQL
                dbManager.InserirDados(comandoSQL, parametros);
            }
            catch (Exception ex)
            {
                // Mensagem de erro, caso ocorra uma exceção
                MessageBox.Show($"Erro ao excluir a reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnExcluirReserva_Click(object sender, EventArgs e)
        {
            if (lbxExcluir.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir as reservas selecionadas?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        foreach (var selectedItem in lbxExcluir.SelectedItems)
                        {
                            string reserva = selectedItem.ToString();
                            string[] detalhes = reserva.Split(new string[] { " - " }, StringSplitOptions.None);

                            // Depuração: Imprimir detalhes da reserva
                            Console.WriteLine("Detalhes da reserva:");
                            foreach (var detalhe in detalhes)
                            {
                                Console.WriteLine(detalhe);
                            }

                            // Verificar se o array de detalhes tem o tamanho correto
                            if (detalhes.Length <= 6)
                            {
                                string labNome = detalhes[3];
                                string labSala = detalhes[4];
                                string labDisc = detalhes[5];
                                DateTime resData = DateTime.ParseExact(detalhes[0], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                                TimeSpan resHoraInicial = TimeSpan.ParseExact(detalhes[1], @"hh\:mm", CultureInfo.InvariantCulture);

                                int labCod = ObterCodigoLaboratorio(labNome, labSala, labDisc);
                                int profCod = ObterCodigoProfessor(professorSelecionado);

                                ExcluirReserva(labCod, profCod, resData, resHoraInicial);
                            }
                            else
                            {
                                throw new Exception("Formato de reserva inválido.");
                            }
                        }


                        // Após excluir todas as reservas selecionadas, você pode atualizar a interface ou fazer qualquer outra ação necessária
                        btnConsultar_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir as reservas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma reserva selecionada para exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }






        //
        //
        //
        // Mudança de telas
        private void lnkConsultaDia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConsultaDia abrir = new frmConsultaDia();
            abrir.Show();
            this.Hide();
        }

        private void lnkReserva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReserva abrir = new frmReserva();
            abrir.Show();
            this.Hide();
        }

        private void lnkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro abrir = new frmCadastro();
            abrir.Show();
            this.Hide();
        }

        //
        //
        //
        //
        // Encerrando o programa
        private void frmConsultaGeral_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isChangingForm && e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }


    }
}



