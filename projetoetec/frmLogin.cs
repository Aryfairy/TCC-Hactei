using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace projetoetec
{
    public partial class frmLogin : Form
    {
        conectaEmail ConectaEmail;
        dal_SQLServerDBManager dbManager;
        public frmLogin()
        {
            InitializeComponent();
            ConectaEmail = new conectaEmail();
            // Instância do gerenciador do banco de dados
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=etecja_reservas;Integrated Security=True";
            dbManager = new dal_SQLServerDBManager(connectionString);
        }



        //
        //
        //
        //
        // Mudança de telas
        // Mudança de telas
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Autenticar usuário com email e senha
            bool autenticado = dbManager.AutenticarAdmin(txtEmail.Text, txtSenha.Text);

            try
            {
                // Verificar se os campos txtEmail e txtSenha não estão vazios
                if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtSenha.Text))
                {

                    if (autenticado)
                    {
                        // Enviar email de confirmação
                        ConectaEmail.EnviarEmail(txtEmail.Text.Trim(), "confirmação de login", "você acabou de ser cadastrado");

                        // Abrir o formulário frmConsultaDia
                        frmConsultaDia abrir = new frmConsultaDia();
                        abrir.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Exibir mensagem de erro
                        MessageBox.Show("Email ou senha incorretos.");
                    }
                }
                else
                {
                    // Exibir mensagem solicitando preenchimento dos campos
                    MessageBox.Show("Por favor, preencha todos os campos.");
                }
            }
            catch (Exception ex)
            {
                // Tratar qualquer exceção que possa ocorrer e exibir uma mensagem de erro
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void linkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperaEmail abrir = new frmRecuperaEmail();
            abrir.Show();
            this.Hide();
        }

      

        private void lnkCadastrar_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastrarAdministrador cadastrar = new frmCadastrarAdministrador();
            cadastrar.Show();
            this.Hide();
        }
    }
}
