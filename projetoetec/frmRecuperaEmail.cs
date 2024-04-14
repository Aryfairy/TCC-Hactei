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
    }
}
