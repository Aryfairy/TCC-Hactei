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
        conectaEmail ConectaEmail;
        dal_SQLServerDBManager dbManager;
        string nome, email, usuario, senha;
        public frmCadastrarAdministrador()
        {
            InitializeComponent();
            ConectaEmail = new conectaEmail();
            // Instância do gerenciador do banco de dados
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=etecja_reservas;Integrated Security=True";
            dbManager = new dal_SQLServerDBManager(connectionString);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text.Trim();
            email = txtEmail.Text.Trim();
            usuario = txtUsuario.Text.Trim();
            senha = txtSenha.Text.Trim();

            if (ConectaEmail.IsValidEmail(email))
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(email) &&
                        !string.IsNullOrWhiteSpace(usuario) && !string.IsNullOrWhiteSpace(senha))
                    {
                        string comandoSQL = $"INSERT INTO administrador (admin_nome, admin_email, admin_usuario, admin_senha) VALUES ('{nome}', '{email}', '{usuario}', '{senha}')";
                        dbManager.InserirDados(comandoSQL);

                        MessageBox.Show("Administrador adicionado com sucesso.");
                        this.Close(); // Fecha o formulário atual
                    }
                    else
                    {
                        MessageBox.Show("Todos os campos devem ser preenchidos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao adicionar o administrador: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("coleque um email valido");
            }
        }

        

        private void lnkCadastrarNovoAdm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {



            frmLogin loguin = new frmLogin();
            loguin.Show();
            this.Hide(); 
        }
       
    
    }
}
