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
            //frmRecuperaEmail ChamaCod=new frmRecuperaEmail();
            
            if (txtCodigo.Text == frmRecuperaEmail.cod)
            {
                frmNovaSenha Abrir = new frmNovaSenha();
                Abrir.Show();
                this.Hide();
                frmRecuperaEmail.cod = "";
                MessageBox.Show(frmRecuperaEmail.cod);

            }

            else {
                MessageBox.Show(frmRecuperaEmail.cod, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);




            }
        }
    }
}
