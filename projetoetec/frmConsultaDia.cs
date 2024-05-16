using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetoetec
{
    public partial class frmConsultaDia : Form
    {
        private dal_SQLServerDBManager dbManager;

        public frmConsultaDia()
        {
            InitializeComponent();
            string connectionString = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=etecja_reservas;Integrated Security=True";
            dbManager = new dal_SQLServerDBManager(connectionString);
            dbManager.AbrirConexao();
        }

        private void frmConsultaDia_Load(object sender, EventArgs e)
        {
            CarregarLaboratorios();
            cboLaboratorio.SelectedIndex = -1;
            cboLaboratorio.Text = "Selecione um laboratório";
        }

        // Carrega comboBox do lab
        private void CarregarLaboratorios()
        {
            try
            {
                // Consulta SQL para selecionar o nome do laboratório e a sala, concatenando-os
                string comandoSQL = "SELECT CONCAT(lab_nome, ' - ', lab_sala) AS nome_sala FROM laboratorio";

                // Chama o método para carregar o ComboBox
                dbManager.CarregarComboBox(cboLaboratorio, comandoSQL, "nome_sala");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os laboratórios: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Funcionalidades GridView

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

        private void lnkConsultaGeral_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConsultaGeral abrir = new frmConsultaGeral();
            abrir.Show();
            this.Close();
        }
    }
}
