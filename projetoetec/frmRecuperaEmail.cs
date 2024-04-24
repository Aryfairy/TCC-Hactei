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
        private string _cod;

        public static string cod
        {
           
            
        }

        public frmRecuperaEmail()
        {
            InitializeComponent();
            _codigo = codigo;
        }        

        private void frmEmail_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin();
            abrir.Show();
            this.Hide();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            conectaEmail ConectEmail = new conectaEmail();
            // cod = ConectEmail.CodigoEmail();
            cod = "123gth";
            ConectEmail.EnviarEmail(txtEmail.Text.Trim(), "confirmação de troca de senha", "o seu codigo é " +cod);
            frmCodigo Abrir = new frmCodigo();
            Abrir.Show();
            this.Hide();
        }
    }
}
