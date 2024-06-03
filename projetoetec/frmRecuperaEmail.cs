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


    public partial class frmRecuperaEmail : Form
    {
        //istancias 
        conectaEmail ConectEmail = new conectaEmail();
        dal_SQLServerDBManager dbManager;
        string cod, email;
        frmCodigo abrir;
        frmLogin abrirLog;
        public frmRecuperaEmail()
        {
            InitializeComponent();
            // Instância do gerenciador do banco de dados
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=etecja_reservas;Integrated Security=True";
            dbManager = new dal_SQLServerDBManager(connectionString);

            abrirLog = new frmLogin();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin();
            abrir.Show();
            this.Hide();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {


            // Autenticar usuário com base no email
            bool autenticado = dbManager.AutenticarEmail(txtEmail.Text);

            {
                try
                {
                    // Verificar se o campo txtEmail não está vazio
                    if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                    {

                        if (autenticado)
                        {
                            // Gerar o código e passar para a variável cod
                            cod = ConectEmail.CodigoEmail();
                            //variavel para o email
                            email = txtEmail.Text.Trim();
                            // Enviar o email com o código de confirmação
                            ConectEmail.EnviarEmail(email, "confirmação de troca de senha", "O seu código é: " + cod);
                            abrir = new frmCodigo(cod, email); // Passando o código e o email para o próximo formulário
                            // Ocultar a tela atual e abrir a próxima etapa (exemplo: abrir um formulário para inserir o código de confirmação)
                            abrir.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Exibir mensagem de erro e limpar o campo de email
                            MessageBox.Show("Email não encontrado.");
                            txtEmail.Clear();
                            txtEmail.Focus();
                        }
                    }
                    else
                    {
                        // Exibir mensagem solicitando preenchimento do campo
                        MessageBox.Show("Por favor, preencha o campo de email.");
                    }
                }
                catch (Exception ex)
                {
                    // Tratar qualquer exceção que possa ocorrer e exibir uma mensagem de erro
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }
    }
}