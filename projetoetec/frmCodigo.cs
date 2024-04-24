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
        public frmCodigo()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            frmRecuperaEmail ChamaCod=new frmRecuperaEmail();
            
            if (txtCodigo.Text == ChamaCod.cod)
            {
                frmNovaSenha Abrir = new frmNovaSenha();
                Abrir.Show();
                this.Hide();
                ChamaCod.cod = "";


            }

            else {
                MessageBox.Show("codigo errado tente de novo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);




            }
        }
    }
}
