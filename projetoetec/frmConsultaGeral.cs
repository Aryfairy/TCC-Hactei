using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetoetec
{
    public partial class frmConsultaGeral : Form
    {
        private dal_SQLServerDBManager dbManager;

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

            // Desabilitar o ComboBox de Reservas e definir texto padrão
            cboReservas.Enabled = false;
            cboReservas.Text = "Selecione um(a) professor(a) para ver suas reservas";
        }

        // Carregar ComboBox de Professores
        private void CarregarProfessores()
        {
            try
            {
                // Consulta SQL para selecionar o nome do professor e a disciplina, concatenando-os
                string comandoSQL = "SELECT CONCAT(prof_nome, ' - ', prof_disciplina) AS nome_disciplina FROM professor";

                // Carrega o ComboBox
                dbManager.CarregarComboBox(cboProfessor, comandoSQL, "nome_disciplina");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os professores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string professorSelecionado = cboProfessor.Text;
            if (string.IsNullOrEmpty(professorSelecionado))
            {
                MessageBox.Show("Por favor, selecione um professor antes de consultar suas reservas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Não há reservas para esse professor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboReservas.DataSource = null;
                    cboReservas.Enabled = false;
                    cboReservas.Text = "Nenhuma reserva disponível";
                }
                else
                {
                    DataTable reservas = dbManager.CarregarReservasPosteriores(professorSelecionado);
                    List<string> reservasFormatadas = new List<string>();
                    foreach (DataRow row in reservas.Rows)
                    {
                        string descricaoReserva = $"{((DateTime)row["res_data"]).ToString("dd/MM/yyyy")} - {row["lab_nome"]} - {row["lab_sala"]} - {row["lab_disc"]}";
                        reservasFormatadas.Add(descricaoReserva);
                    }

                    cboReservas.DataSource = reservasFormatadas;
                    cboReservas.Enabled = true;
                }
            }
            else
            {
                // Caso não haja professor selecionado, preencha as labels com "-"
                lblNomeProfSelected.Text = "—";
                lblDisciplinaProfSelected.Text = "—";
                lblEmailSelected.Text = "—";
                lblCelularSelected.Text = "—";
                lblReservasSelected.Text = "0";

                // Desabilitar e definir texto padrão para o ComboBox de Reservas
                cboReservas.DataSource = null;
                cboReservas.Enabled = false;
                cboReservas.Text = "Selecione um(a) professor(a) para ver suas reservas";
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
            if (phoneNumber.Length == 11) // Verifica se o número de celular tem 11 dígitos (incluindo o DDD)
            {
                return string.Format("({0}) {1}-{2}", phoneNumber.Substring(0, 2), phoneNumber.Substring(2, 5), phoneNumber.Substring(7, 4));
            }
            else
            {
                // Se o número de celular não tiver o formato esperado, retorna o número original
                return phoneNumber;
            }
        }

        private int ConsultarNumeroReservasPosteriores(string professor)
        {
            DateTime dataHoraAtual = DateTime.Now;
            string comandoSQL = "SELECT COUNT(*) FROM reserva WHERE prof_cod = (SELECT prof_cod FROM professor WHERE CONCAT(prof_nome, ' - ', prof_disciplina) = @Professor) AND res_data > @DataHoraAtual";
            SqlParameter[] parametros = { new SqlParameter("@Professor", professor), new SqlParameter("@DataHoraAtual", dataHoraAtual) };
            DataTable resultado = dbManager.ConsultarDados(comandoSQL, parametros);
            return resultado.Rows.Count > 0 ? Convert.ToInt32(resultado.Rows[0][0]) : 0;
        }

        private void cboReservas_Click(object sender, EventArgs e)
        {
            string professorSelecionado = cboProfessor.Text;
            if (!string.IsNullOrEmpty(professorSelecionado))
            {
                int numeroReservas = ConsultarNumeroReservasPosteriores(professorSelecionado);
                if (numeroReservas == 0)
                {
                    MessageBox.Show("Não há reservas para esse(a) professor(a).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataTable reservas = dbManager.CarregarReservasPosteriores(professorSelecionado);
                    List<string> reservasFormatadas = new List<string>();
                    foreach (DataRow row in reservas.Rows)
                    {
                        string descricaoReserva = $"{row["res_data"]} {row["res_horainicial"]} às {row["res_horafinal"]} - {row["lab_nome"]} - {row["lab_sala"]} - {row["lab_disc"]}";
                        reservasFormatadas.Add(descricaoReserva);
                    }
                    cboReservas.DataSource = reservasFormatadas;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um professor antes de consultar suas reservas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluirReserva_Click(object sender, EventArgs e)
        {
            int reservaSelecionada = cboReservas.SelectedIndex;
            if (reservaSelecionada != -1)
            {
                DialogResult result = MessageBox.Show($"Você realmente deseja excluir a reserva selecionada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ExcluirReserva(reservaSelecionada);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma reserva para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExcluirReserva(int index)
        {
            string professorSelecionado = cboProfessor.Text;
            DataTable reservas = dbManager.CarregarReservasPosteriores(professorSelecionado);
            if (index >= 0 && index < reservas.Rows.Count)
            {
                int reservaSelecionada = Convert.ToInt32(reservas.Rows[index]["res_cod"]);
                string comandoSQL = "DELETE FROM reserva WHERE res_cod = @Reserva";
                SqlParameter[] parametros = { new SqlParameter("@Reserva", reservaSelecionada) };
                dbManager.InserirDados(comandoSQL, parametros);
                MessageBox.Show("Reserva excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lnkConsultaDia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConsultaDia abrir = new frmConsultaDia();
            abrir.Show();
            this.Close();
        }

        private void lnkReserva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReserva abrir = new frmReserva();
            abrir.Show();
            this.Close();
        }

        private void lnkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro abrir = new frmCadastro();
            abrir.Show();
            this.Close();
        }

        private void frmConsultaGeral_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verifica se o motivo do fechamento é clicar no botão de fechar da janela
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Exibe uma caixa de diálogo de confirmação
                DialogResult result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Se o usuário confirmar a saída, fecha a conexão com o banco e encerra o programa
                if (result == DialogResult.Yes)
                {
                    // Fecha a conexão com o banco
                    // Encerra a aplicação
                    Application.Exit();
                }
                else
                {
                    // Cancela o fechamento da janela
                    e.Cancel = true;
                }
            }
        }

    }
}
