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
    public partial class frmCodigo : Form
    {
        string cod;
        string Email;
        bool pag;
        public frmCodigo(string codigo, string email,bool Pag)
        {
            InitializeComponent();
            cod = codigo;
            Email = email;
            pag = Pag;

        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {

            
           

            //comparando os codigos
            if (txtCodigo.Text == cod)
            {
                if (pag) {
                    //istancia
                    frmCadastrarAdministrador AbrirAdm = new frmCadastrarAdministrador(Email);
                    AbrirAdm.Show();
                    this.Hide();
                }
                else
                { 
                    //istancia
                    frmNovaSenha Abrir = new frmNovaSenha(Email);
                    Abrir.Show();
                    this.Hide();
                }

            }

            else
            {
                MessageBox.Show("codigo errado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
