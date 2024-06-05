using System;
using System.Windows.Forms;

namespace projetoetec
{
    public partial class frmRecuperaEmail : Form
    {
        // Instâncias
        conectaEmail ConectEmail = new conectaEmail();
        dal_SQLServerDBManager dbManager;
        string cod, email;
        frmCodigo abrir;
        frmLogin abrirLog;
        bool pag;

        public frmRecuperaEmail(bool Pag)
        {
            InitializeComponent();
            // Instância do gerenciador do banco de dados
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=etecja_reservas;Integrated Security=True";
            dbManager = new dal_SQLServerDBManager(connectionString);
            pag = Pag;
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
            try
            {
                // Verificar se o campo txtEmail não está vazio
                if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    email = txtEmail.Text.Trim();

                    if (pag)
                    {
                        if (ConectEmail.IsValidEmail(email))
                        {
                            // Gerar o código e passar para a variável cod
                            cod = ConectEmail.CodigoEmail();
                            // Enviar o email com o código de confirmação
                            ConectEmail.EnviarEmail(email, "Confirmação de troca de senha", "O seu código é: " + cod);
                            abrir = new frmCodigo(cod, email,pag); // Passando o código e o email para o próximo formulário
                            // Ocultar a tela atual e abrir a próxima etapa
                            abrir.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Exibir mensagem de erro para email inválido
                            MessageBox.Show("Email inválido.");
                        }
                    }
                    else
                    {
                        // Autenticar usuário com base no email
                        bool autenticado = dbManager.AutenticarEmail(email);
                        if (autenticado)
                        {
                            // Gerar o código e passar para a variável cod
                            cod = ConectEmail.CodigoEmail();
                            // Enviar o email com o código de confirmação
                            ConectEmail.EnviarEmail(email, "Confirmação de troca de senha", "O seu código é: " + cod);
                            abrir = new frmCodigo(cod, email,pag); // Passando o código e o email para o próximo formulário
                            // Ocultar a tela atual e abrir a próxima etapa
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
