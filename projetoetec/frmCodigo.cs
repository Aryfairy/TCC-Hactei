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
        public frmCodigo(string codigo, string email)
        {
            InitializeComponent();
            cod = codigo;
            Email = email;
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {

            //istancia
            frmNovaSenha Abrir = new frmNovaSenha(Email);

            //comparando os codigos
            if (txtCodigo.Text == cod)
            {
                Abrir.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("codigo errado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCodigo_Load(object sender, EventArgs e)
        {

        }
    }
}
