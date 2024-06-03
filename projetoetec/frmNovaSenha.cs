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
    public partial class frmNovaSenha : Form
    {

        dal_SQLServerDBManager dbManager;
        private string email;
        string novaSenha, confirma;
        public frmNovaSenha(string email)
        {
            InitializeComponent();
            this.email = email;
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=etecja_reservas;Integrated Security=True";
            dbManager = new dal_SQLServerDBManager(connectionString);


        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            novaSenha = txtNovaSenha.Text;
            confirma = txtConfirmar.Text;
            try
            {
                if (!string.IsNullOrWhiteSpace(novaSenha) && !string.IsNullOrWhiteSpace(confirma) && novaSenha == confirma)
                {
                    if (novaSenha == confirma)
                    {
                        string comandoSQL = $"UPDATE administrador SET admin_senha = '{novaSenha}' WHERE admin_email = '{email}'";

                        dbManager.InserirDados(comandoSQL);
                        frmLogin loguin = new frmLogin();
                        MessageBox.Show("senha trocada");
                        loguin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("As senhas não coincidem ou estão vazias.");
                    }
                }
                else
                {
                    MessageBox.Show("digite uma nova senha e confirme ela!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a senha: " + ex.Message);
            }
        }

    }
}
