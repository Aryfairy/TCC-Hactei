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
        public frmConsultaDia()
        {
            InitializeComponent();
        }

        private void frmConsultaDia_Load(object sender, EventArgs e)
        {

        }

        //
        //
        //
        //
        // Mudança de telas
        private void lnkConsultaGeral_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConsultaGeral abrir = new frmConsultaGeral();
            abrir.Show();
            this.Close();
        }

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
    }
}
