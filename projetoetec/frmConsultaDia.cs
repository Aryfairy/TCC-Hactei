using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoetec
{
    public partial class frmConsultaDia : Form
    {
        private dal_SQLiteDBManager dbManager;
        public frmConsultaDia()
        {
            InitializeComponent();
            dbManager = new dal_SQLiteDBManager(@"C:\Users\Laboratorio-Info\source\repos\TCC-Hactei\etecja_reservas.db");
            dbManager.AbrirConexao();
        }

        private void frmConsultaDia_Load(object sender, EventArgs e)
        {
            CarregarLaboratorios();
            cboLaboratorio.SelectedIndex = -1;
            cboLaboratorio.Text = "Selecione um laboratório";
        }

        //
        //
        //
        //
        // Carrega comboBox do lab
        private void CarregarLaboratorios()
        {
            try
            {
                // Consulta SQL para selecionar o nome do laboratório e a sala, concatenando-os
                string comandoSQL = "SELECT lab_nome || ' - ' || lab_sala AS nome_sala FROM laboratorio";

                // Chama o método para carregar o ComboBox
                dbManager.CarregarComboBox(cboLaboratorio, comandoSQL, "nome_sala");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os laboratórios: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //
        //
        //
        //
        // Funcionalidades GridView


        //
        //
        //
        //
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
