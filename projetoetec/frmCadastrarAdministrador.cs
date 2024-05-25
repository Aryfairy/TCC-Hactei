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
    public partial class frmCadastrarAdministrador : Form
    {
        public frmCadastrarAdministrador()
        {
            InitializeComponent();
        }

        private void lnkCadastrarNovoAdm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin voltarLogin = new frmLogin();
            voltarLogin.Show();
            this.Hide();
        }

        private void frmCadastrarAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
