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
        private bool isChangingForm = false;

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
            cboProfessor.SelectedIndexChanged += cboProfessor_SelectedIndexChanged;
            lbxAtuais.Items.Add("Selecione um(a) professor(a)");
            lbxExcluir.Items.Add("Selecione um(a) professor(a)");
            lbxAtuais.Enabled = false;
            lbxExcluir.Enabled = false;
            btnMoverDireita.Enabled = false;
            btnMoverEsquerda.Enabled = false;
            btnExcluirReserva.Enabled = false;
        }

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
            professorSelecionado = cboProfessor.Text;

            // Verifica se o item selecionado é um professor válido
            if (cboProfessor.SelectedItem == null || cboProfessor.SelectedIndex == -1 || cboProfessor.SelectedItem.ToString() == "Selecione um(a) professor(a)")
            {
                MessageBox.Show("Por favor, selecione um professor válido antes de consultar suas reservas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                    lbxAtuais.Items.Clear();
                    lbxAtuais.Items.Add("Não há reservas para esse professor");
                    lbxAtuais.Enabled = false;
                    lbxExcluir.Items.Clear();
                    lbxExcluir.Enabled = false;
                }
                else
                {
                    CarregarReservasAtuais(professorSelecionado);
                }

                btnMoverDireita.Enabled = true;
                btnMoverEsquerda.Enabled = true;
                btnExcluirReserva.Enabled = true;
            }
            else
            {
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

        private void CarregarReservasAtuais(string professor)
        {
            lbxAtuais.Items.Clear();
            lbxAtuais.Enabled = true;
            lbxExcluir.Items.Clear();
            lbxExcluir.Enabled = true;

            DataTable reservas = dbManager.CarregarReservasPosteriores(professor);

            // Ordenar o DataTable pelo campo res_data
            reservas.DefaultView.Sort = "res_data ASC";
            reservas = reservas.DefaultView.ToTable();

            foreach (DataRow row in reservas.Rows)
            {
                DateTime dataReserva = Convert.ToDateTime(row["res_data"]);
                string reserva = $"{dataReserva:dd/MM/yyyy} - {row["res_horainicial"]:hh\\:mm} até {row["res_horafinal"]:hh\\:mm} ({row["lab_nome"]} - {row["lab_sala"]})";
                lbxAtuais.Items.Add(reserva);
            }
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
            DateTime dataHoraAtual = DateTime.Now.Date;
            string comandoSQL = "SELECT COUNT(*) FROM reserva WHERE prof_cod = (SELECT prof_cod FROM professor WHERE CONCAT(prof_nome, ' - ', prof_disciplina) = @Professor) AND res_data > @DataHoraAtual";
            SqlParameter[] parametros = { new SqlParameter("@Professor", professor), new SqlParameter("@DataHoraAtual", dataHoraAtual) };
            DataTable resultado = dbManager.ConsultarDados(comandoSQL, parametros);
            return resultado.Rows.Count > 0 ? Convert.ToInt32(resultado.Rows[0][0]) : 0;
        }

        private void btnMoverDireita_Click(object sender, EventArgs e)
        {
            List<int> indicesSelecionados = new List<int>();
            foreach (int index in lbxAtuais.SelectedIndices)
            {
                indicesSelecionados.Add(index);
            }

            // Armazenar os itens selecionados em uma lista para manter a seleção após o movimento
            List<string> itensSelecionados = new List<string>();
            foreach (int index in indicesSelecionados)
            {
                itensSelecionados.Add(lbxAtuais.Items[index].ToString());
            }

            // Remover os itens selecionados da lista lbxAtuais e adicionar na lista lbxExcluir
            foreach (string item in itensSelecionados)
            {
                lbxAtuais.Items.Remove(item);
                lbxExcluir.Items.Add(item);
            }

            // Reorganizar lbxExcluir por data
            ReorganizarListaPorData(lbxExcluir);

            // Selecionar os itens movidos na lista lbxExcluir
            foreach (string item in itensSelecionados)
            {
                lbxExcluir.SetSelected(lbxExcluir.Items.IndexOf(item), true);
            }
        }

        private void btnMoverEsquerda_Click(object sender, EventArgs e)
        {
            List<int> indicesSelecionados = new List<int>();
            foreach (int index in lbxExcluir.SelectedIndices)
            {
                indicesSelecionados.Add(index);
            }

            // Armazenar os itens selecionados em uma lista para manter a seleção após o movimento
            List<string> itensSelecionados = new List<string>();
            foreach (int index in indicesSelecionados)
            {
                itensSelecionados.Add(lbxExcluir.Items[index].ToString());
            }

            // Remover os itens selecionados da lista lbxExcluir e adicionar na lista lbxAtuais
            foreach (string item in itensSelecionados)
            {
                lbxExcluir.Items.Remove(item);
                lbxAtuais.Items.Add(item);
            }

            // Reorganizar lbxAtuais por data
            ReorganizarListaPorData(lbxAtuais);

            // Selecionar os itens movidos na lista lbxAtuais
            foreach (string item in itensSelecionados)
            {
                lbxAtuais.SetSelected(lbxAtuais.Items.IndexOf(item), true);
            }
        }

        private void ReorganizarListaPorData(ListBox listBox)
        {
            // Converter os itens da ListBox para uma lista de strings
            List<string> items = new List<string>();
            foreach (var item in listBox.Items)
            {
                items.Add(item.ToString());
            }

            // Ordenar os itens por data
            items.Sort((x, y) =>
            {
                DateTime dataX = ExtrairDataReserva(x);
                DateTime dataY = ExtrairDataReserva(y);
                return DateTime.Compare(dataX, dataY);
            });

            // Limpar a ListBox e adicionar os itens ordenados de volta
            listBox.Items.Clear();
            listBox.Items.AddRange(items.ToArray());
        }

        private DateTime ExtrairDataReserva(string reserva)
        {
            // Extrair a data da reserva no formato "dd/MM/yyyy"
            string[] partes = reserva.Split(new string[] { " - " }, StringSplitOptions.None);
            string dataReserva = partes[0];
            return DateTime.ParseExact(dataReserva, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }




        private void btnExcluirReserva_Click(object sender, EventArgs e)
        {
            if (lbxExcluir.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir as reservas selecionadas?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    List<string> itensSelecionados = new List<string>();
                    foreach (var item in lbxExcluir.SelectedItems)
                    {
                        itensSelecionados.Add(item.ToString());
                    }

                    foreach (string item in itensSelecionados)
                    {
                        // Extrair a data e o horário inicial da reserva
                        string[] partes = item.Split(' ');
                        string data = partes[0];
                        string horarioInicial = partes[2];

                        // Deletar a reserva do banco de dados
                        ExcluirReserva(professorSelecionado, data, horarioInicial);

                        // Remover o item das ListBoxes
                        lbxExcluir.Items.Remove(item);
                    }

                    MessageBox.Show("Reservas excluídas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma reserva para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExcluirReserva(string professor, string data, string horarioInicial)
        {
            string comandoSQL = "DELETE FROM reserva WHERE prof_cod = (SELECT prof_cod FROM professor WHERE CONCAT(prof_nome, ' - ', prof_disciplina) = @Professor) AND res_data = @Data AND res_horainicial = @HorarioInicial";
            SqlParameter[] parametros = {
                new SqlParameter("@Professor", professor),
                new SqlParameter("@Data", DateTime.Parse(data)),
                new SqlParameter("@HorarioInicial", TimeSpan.Parse(horarioInicial))
            };
            dbManager.InserirDados(comandoSQL, parametros);
        }


        //
        //
        //
        //
        //Mudança de telas
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
        //encerramento

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
