using System;
using System.Data;
using System.Windows.Forms;

namespace projetoetec
{
    public partial class frmConsultaDia : Form
    {
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
            CarregarLaboratorios();
            dtpData.Value = DateTime.Today;
            ConfigurarDataGridView();
            btnConsultar_Click(sender, e);
        }

        private void ConfigurarDataGridView()
        {
            dgvReservasDia.ColumnCount = 4;
            dgvReservasDia.Columns[0].Name = "Horário";
            dgvReservasDia.Columns[1].Name = "Laboratório";
            dgvReservasDia.Columns[2].Name = "Professor";
            dgvReservasDia.Columns[3].Name = "Status";

            TimeSpan hora = horaInicial;
            while (hora <= horaFinal)
            {
                dgvReservasDia.Rows.Add(hora.ToString(@"hh\:mm"), "", "", "");
                hora = hora.Add(intervalo);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            LimparDataGridView();
            int labCodSelecionado = int.Parse(cboLaboratorio.SelectedValue.ToString());
            DateTime dataSelecionada = dtpData.Value.Date;
            DataTable reservas = ConsultarReservas(labCodSelecionado, dataSelecionada);
            AtualizarDataGridView(reservas);
        }

        private DataTable ConsultarReservas(int labCod, DateTime data)
        {
            DataTable reservas = new DataTable();
            try
            {
                string comandoSQL = $"SELECT res_horainicial, res_horafinal, prof_nome, res_status FROM reserva " +
                                    $"INNER JOIN laboratorio ON reserva.lab_cod = laboratorio.lab_cod " +
                                    $"INNER JOIN professor ON reserva.prof_cod = professor.prof_cod " +
                                    $"WHERE reserva.lab_cod = {labCod} AND res_data = '{data:yyyy-MM-dd}'";
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
            string laboratorioSelecionado = cboLaboratorio.Text.Trim();
            foreach (DataRow reserva in reservas.Rows)
            {
                TimeSpan horaInicial = (TimeSpan)reserva["res_horainicial"];
                TimeSpan horaFinal = (TimeSpan)reserva["res_horafinal"];
                string professor = (string)reserva["prof_nome"];
                string status = (string)reserva["res_status"];

                TimeSpan hora = horaInicial;
                while (hora <= horaFinal)
                {
                    DataGridViewRow row = EncontrarLinhaPorHora(hora);
                    if (row != null)
                    {
                        row.Cells[2].Value = professor;
                        row.Cells[3].Value = "RESERVADO";
                    }
                    hora = hora.Add(intervalo);
                }
            }
            foreach (DataGridViewRow row in dgvReservasDia.Rows)
            {
                row.Cells[1].Value = laboratorioSelecionado;
                if (string.IsNullOrEmpty(row.Cells[3].Value?.ToString()))
                {
                    row.Cells[3].Value = "DISPONÍVEL";
                }
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
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                }
                else if (status == "RESERVADO")
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Tomato;
                }
            }
        }

        private void CarregarLaboratorios()
        {
            try
            {
                string comandoSQL = "SELECT lab_cod, CONCAT(lab_nome, ' - ', lab_sala, ' - ', lab_disc) AS nome_sala FROM laboratorio";
                DataTable laboratorios = dbManager.ConsultarDados(comandoSQL);
                cboLaboratorio.DataSource = laboratorios;
                cboLaboratorio.DisplayMember = "nome_sala";
                cboLaboratorio.ValueMember = "lab_cod";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os laboratórios: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReservasDia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
    {
                DataGridViewRow row = dgvReservasDia.Rows[e.RowIndex];
                string horario = row.Cells[0].Value.ToString();
                string laboratorio = row.Cells[1].Value.ToString();
                string professor = row.Cells[2].Value.ToString();
                string status = row.Cells[3].Value.ToString();

                if (status == "RESERVADO" && professor != "———")
                {
                    DateTime dataSelecionada = dtpData.Value.Date;
                    TimeSpan horaClicada = TimeSpan.Parse(horario);

                    string comandoSQL = $"SELECT res_data, res_horainicial, res_horafinal, professor.prof_nome " +
                                        $"FROM reserva " +
                                        $"INNER JOIN professor ON reserva.prof_cod = professor.prof_cod " +
                                        $"INNER JOIN laboratorio ON reserva.lab_cod = laboratorio.lab_cod " +
                                        $"WHERE professor.prof_nome = '{professor}' " +
                                        $"AND laboratorio.lab_cod = (SELECT lab_cod FROM laboratorio WHERE CONCAT(lab_nome, ' - ', lab_sala, ' - ', lab_disc) = '{laboratorio}') " +
                                        $"AND '{horaClicada}' BETWEEN res_horainicial AND res_horafinal " +
                                        $"AND res_data = '{dataSelecionada:yyyy-MM-dd}'";

                    DataTable reservaDetalhes = dbManager.ConsultarDados(comandoSQL);

                    if (reservaDetalhes.Rows.Count > 0)
                    {
                        DataRow reserva = reservaDetalhes.Rows[0];
                        DateTime dataReserva = (DateTime)reserva["res_data"];
                        TimeSpan horaInicial = (TimeSpan)reserva["res_horainicial"];
                        TimeSpan horaFinal = (TimeSpan)reserva["res_horafinal"];
                        string nomeProfessor = (string)reserva["prof_nome"];

                        string mensagem = $"Essa reserva foi feita na data {dataReserva.ToShortDateString()}, das {horaInicial.ToString(@"hh\:mm")} até {horaFinal.ToString(@"hh\:mm")}, pelo professor {nomeProfessor}. \n\nGostaria de deletar essa reserva?";
                        DialogResult result = MessageBox.Show(mensagem, "Detalhes da Reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            DialogResult confirmResult = MessageBox.Show("Tem certeza que deseja deletar essa reserva?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (confirmResult == DialogResult.Yes)
                            {
                                string deleteSQL = $"DELETE FROM reserva " +
                                                   $"WHERE reserva.prof_cod = (SELECT prof_cod FROM professor WHERE prof_nome = '{professor}') " +
                                                   $"AND reserva.lab_cod = (SELECT lab_cod FROM laboratorio WHERE CONCAT(lab_nome, ' - ', lab_sala, ' - ', lab_disc) = '{laboratorio}') " +
                                                   $"AND res_horainicial = '{horaInicial}'";


                                try
                                {
                                    dbManager.InserirDados(deleteSQL);
                                    MessageBox.Show("Reserva deletada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    btnConsultar_Click(sender, e);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Erro ao deletar a reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
        }

        // Mudança de telas
        private void lnkReserva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReserva abrir = new frmReserva();
            abrir.Show();
            this.Hide();
        }

        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro abrir = new frmCadastro();
            abrir.Show();
            this.Hide();
        }

        private void lnkConsultaGeral_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConsultaGeral abrir = new frmConsultaGeral();
            abrir.Show();
            this.Hide();
        }
    }
}
