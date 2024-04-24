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
        //variaveis globais 
        string _cod;
        public static string cod;



        public frmRecuperaEmail()
        {
            InitializeComponent();

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
            //istancias 
            conectaEmail ConectEmail = new conectaEmail();
            frmCodigo Abrir = new frmCodigo();

            //gerando o codigo e passando para variavel cod
            _cod = ConectEmail.CodigoEmail();
            cod = _cod;

            //madando o email
            ConectEmail.EnviarEmail(txtEmail.Text.Trim(), "confirmação de troca de senha", "o seu codigo é " + cod);

            //valindando se a pesso realmente escreveu um email valido antes dela ir para a proxima pagina
            if (conectaEmail.valid){
                Abrir.Show();
                this.Hide();}

                txtEmail.Clear();
                txtEmail.Focus();
        }
    }
}