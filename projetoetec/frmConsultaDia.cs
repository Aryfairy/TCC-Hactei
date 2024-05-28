using System;
using System.Data;
using System.Windows.Forms;

namespace projetoetec
{
    public partial class frmConsultaDia : Form
    {
        // Definindo os horários de trabalho
        private readonly TimeSpan horaInicial = new TimeSpan(7, 30, 0);
        private readonly TimeSpan horaFinal = new TimeSpan(15, 30, 0);
        private readonly TimeSpan intervalo = new TimeSpan(0, 10, 0);

        private dal_SQLServerDBManager dbManager;

        public frmConsultaDia()
        {
            InitializeComponent();
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=etecja_reservas;Integrated Security=True";
            dbManager = new dal_SQLServerDBManager(connectionString);
            dbManager.AbrirConexao();
        }

        private void frmConsultaDia_Load(object sender, EventArgs e)
        {
            // Carregar os laboratórios no ComboBox
            CarregarLaboratorios();

            // Definir a data padrão como a data atual
            dtpData.Value = DateTime.Today;

            // Configurar o DataGridView
            ConfigurarDataGridView();

            // Atualizar o DataGridView ao carregar o formulário
            btnConsultar_Click(sender, e);
        }

        private void ConfigurarDataGridView()
        {
            // Adicionando as colunas ao DataGridView
            dgvReservasDia.ColumnCount = 4;
            dgvReservasDia.Columns[0].Name = "Horário";
            dgvReservasDia.Columns[1].Name = "Laboratório";
            dgvReservasDia.Columns[2].Name = "Professor";
            dgvReservasDia.Columns[3].Name = "Status";

            // Preenchendo os horários
            TimeSpan hora = horaInicial;
            while (hora <= horaFinal)
            {
                dgvReservasDia.Rows.Add(hora.ToString(@"hh\:mm"), "", "", "");
                hora = hora.Add(intervalo);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Limpa as informações atuais no DataGridView
            LimparDataGridView();

            // Obter o laboratório selecionado
            string laboratorioSelecionado = cboLaboratorio.Text.Split('-')[0].Trim();

            // Obter a data selecionada
            DateTime dataSelecionada = dtpData.Value.Date;

            // Consultar o banco de dados para obter as reservas do laboratório na data especificada
            DataTable reservas = ConsultarReservas(laboratorioSelecionado, dataSelecionada);

            // Atualizar o DataGridView com as informações das reservas
            AtualizarDataGridView(reservas);
        }

        private DataTable ConsultarReservas(string laboratorio, DateTime data)
        {
            DataTable reservas = new DataTable();

            try
            {
                // Consulta SQL para obter as reservas do laboratório na data especificada
                string comandoSQL = $"SELECT res_horainicial, res_horafinal, prof_nome, res_status FROM reserva " +
                                    $"INNER JOIN laboratorio ON reserva.lab_cod = laboratorio.lab_cod " +
                                    $"INNER JOIN professor ON reserva.prof_cod = professor.prof_cod " +
                                    $"WHERE lab_nome = '{laboratorio}' AND res_data = '{data:yyyy-MM-dd}'";

                reservas = dbManager.ConsultarDados(comandoSQL);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar as reservas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return reservas;
        }

        private void AtualizarDataGridView(DataTable reservas)
        {
            // Obter o laboratório selecionado
            string laboratorioSelecionado = cboLaboratorio.Text.Trim();


            foreach (DataRow reserva in reservas.Rows)
            {
                // Obter as informações da reserva
                TimeSpan horaInicial = (TimeSpan)reserva["res_horainicial"];
                TimeSpan horaFinal = (TimeSpan)reserva["res_horafinal"];
                string professor = (string)reserva["prof_nome"];
                string status = (string)reserva["res_status"];

                // Preencher as linhas correspondentes no DataGridView
                TimeSpan hora = horaInicial;
                while (hora <= horaFinal)
                {
                    DataGridViewRow row = EncontrarLinhaPorHora(hora);
                    if (row != null)
                    {
                        // Preencher a coluna "Professor" com o nome do professor selecionado
                        row.Cells[2].Value = professor;

                        // Preencher a coluna "Status" com o status da reserva
                        row.Cells[3].Value = "RESERVADO";
                    }
                    hora = hora.Add(intervalo);
                }
            }

            // Preencher as linhas que não têm reserva
            foreach (DataGridViewRow row in dgvReservasDia.Rows)
            {
                // Preencher a coluna "Sala" com o nome do laboratório selecionado
                row.Cells[1].Value = laboratorioSelecionado;

                // Preencher com "DISPONÍVEL" as linhas que não têm reserv
                if (string.IsNullOrEmpty(row.Cells[3].Value?.ToString()))
                {
                    row.Cells[3].Value = "DISPONÍVEL";
                }
                // Preencher com "———", na coluna professor nas linhas que não têm reserva
                if (string.IsNullOrEmpty(row.Cells[2].Value?.ToString()))
                {
                    row.Cells[2].Value = "———";
                }
            }
        }


        private DataGridViewRow EncontrarLinhaPorHora(TimeSpan hora)
        {
            foreach (DataGridViewRow row in dgvReservasDia.Rows)
            {
                TimeSpan horaGrid = TimeSpan.Parse((string)row.Cells[0].Value);
                if (horaGrid == hora)
                    return row;
            }
            return null;
        }

        private void LimparDataGridView()
        {
            foreach (DataGridViewRow row in dgvReservasDia.Rows)
            {
                row.Cells[1].Value = "";
                row.Cells[2].Value = "";
                row.Cells[3].Value = "";
            }
        }

        private void dgvReservasDia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvReservasDia.Rows[e.RowIndex];
                string status = row.Cells["Status"].Value?.ToString() ?? "";

                if (status == "DISPONÍVEL")
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen; ;
                }
                else if (status == "RESERVADO")
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Tomato; ;
                }
            }
        }

        //
        //
        //
        //combobox lab

        private void CarregarLaboratorios()
        {
            try
            {
                // Consulta SQL para selecionar o nome do laboratório e a sala, concatenando-os
                string comandoSQL = "SELECT CONCAT(lab_nome, ' - ', lab_sala, ' - ', lab_disc) AS nome_sala FROM laboratorio";

                // Chama o método para carregar o ComboBox
                dbManager.CarregarComboBox(cboLaboratorio, comandoSQL, "nome_sala");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os laboratórios: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Mudança de telas
        private void lnkReserva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReserva abrir = new frmReserva();
            abrir.Show();
            this.Close();
        }

        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro abrir = new frmCadastro();
            abrir.Show();
            this.Close();
        }

        private void lnkConsultaGeral_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConsultaGeral abrir = new frmConsultaGeral();
            abrir.Show();
            this.Close();
        }
    }
}
