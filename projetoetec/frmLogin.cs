using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace projetoetec
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblBemvindo_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e )
        {
            /// Verificar se o endereço de e-mail é válido
            string destinatario = txbDesti.Text.Trim();
            EmailFinal(destinatario);
        }



        
    }
}
