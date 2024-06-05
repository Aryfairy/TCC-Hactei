using System;
using System.Windows.Forms;

namespace projetoetec
{
    public partial class frmSplash : Form
    {
             

        public frmSplash()
        {
            InitializeComponent();
            
        }        

        private void timer_Tick(object sender, EventArgs e)
        {
            prgSplash.Increment(10);
            if (prgSplash.Value == 100)
            {
                // Para o timer
                timerBar.Enabled = false;
                frmConsultaDia abrir = new frmConsultaDia();
                abrir.Show();
                this.Hide();
            }
        }
    }
}
