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


        //
        //
        //
        //
        // Mudança de telas
        private void btnEntrar_Click(object sender, EventArgs e )
        {

            
            conectaEmail ConectaEmail = new conectaEmail();
            ConectaEmail.EnviarEmail(txtEmail.Text.Trim(), "confirmação de login", "você acabou de ser cadastrado");
            frmConsultaDia abrir = new frmConsultaDia();
            abrir.Show();
            this.Hide();            
        }

        private void linkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperaEmail abrir = new frmRecuperaEmail();
            abrir.Show();
            this.Hide();
        }

        private void lnkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //está faltando a tela
        }
    }
}
