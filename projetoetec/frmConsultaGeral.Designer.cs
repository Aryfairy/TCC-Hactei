
namespace projetoetec
{
    partial class frmConsultaGeral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaGeral));
            this.pnlConsultaGeral = new System.Windows.Forms.Panel();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblCalendario = new System.Windows.Forms.Label();
            this.dtpCalendario = new System.Windows.Forms.DateTimePicker();
            this.cboLaboratorio = new System.Windows.Forms.ComboBox();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.picMudarTema = new System.Windows.Forms.PictureBox();
            this.pnlOpc = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkCadastro = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkReserva = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkConsultaGeral = new System.Windows.Forms.LinkLabel();
            this.lnkConsultaDia = new System.Windows.Forms.LinkLabel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlConsultaGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).BeginInit();
            this.pnlOpc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConsultaGeral
            // 
            this.pnlConsultaGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.pnlConsultaGeral.Controls.Add(this.btnGerar);
            this.pnlConsultaGeral.Controls.Add(this.lblCalendario);
            this.pnlConsultaGeral.Controls.Add(this.dtpCalendario);
            this.pnlConsultaGeral.Controls.Add(this.cboLaboratorio);
            this.pnlConsultaGeral.Controls.Add(this.lblLaboratorio);
            this.pnlConsultaGeral.Location = new System.Drawing.Point(89, 78);
            this.pnlConsultaGeral.Margin = new System.Windows.Forms.Padding(2);
            this.pnlConsultaGeral.Name = "pnlConsultaGeral";
            this.pnlConsultaGeral.Size = new System.Drawing.Size(557, 325);
            this.pnlConsultaGeral.TabIndex = 0;
            this.pnlConsultaGeral.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.btnGerar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(426, 278);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(114, 33);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "Gerar PDF";
            this.btnGerar.UseVisualStyleBackColor = false;
            // 
            // lblCalendario
            // 
            this.lblCalendario.AutoSize = true;
            this.lblCalendario.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblCalendario.Location = new System.Drawing.Point(14, 79);
            this.lblCalendario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalendario.Name = "lblCalendario";
            this.lblCalendario.Size = new System.Drawing.Size(108, 19);
            this.lblCalendario.TabIndex = 3;
            this.lblCalendario.Text = "Calendário:";
            // 
            // dtpCalendario
            // 
            this.dtpCalendario.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.dtpCalendario.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCalendario.Location = new System.Drawing.Point(135, 76);
            this.dtpCalendario.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCalendario.Name = "dtpCalendario";
            this.dtpCalendario.Size = new System.Drawing.Size(308, 23);
            this.dtpCalendario.TabIndex = 2;
            this.dtpCalendario.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cboLaboratorio
            // 
            this.cboLaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.cboLaboratorio.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLaboratorio.FormattingEnabled = true;
            this.cboLaboratorio.Location = new System.Drawing.Point(135, 19);
            this.cboLaboratorio.Margin = new System.Windows.Forms.Padding(2);
            this.cboLaboratorio.Name = "cboLaboratorio";
            this.cboLaboratorio.Size = new System.Drawing.Size(308, 23);
            this.cboLaboratorio.TabIndex = 1;
            this.cboLaboratorio.Text = "escolher o laboratório";
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblLaboratorio.Location = new System.Drawing.Point(14, 19);
            this.lblLaboratorio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(117, 19);
            this.lblLaboratorio.TabIndex = 0;
            this.lblLaboratorio.Text = "Laboratório:";
            // 
            // picMudarTema
            // 
            this.picMudarTema.Image = ((System.Drawing.Image)(resources.GetObject("picMudarTema.Image")));
            this.picMudarTema.Location = new System.Drawing.Point(0, 50);
            this.picMudarTema.Name = "picMudarTema";
            this.picMudarTema.Size = new System.Drawing.Size(32, 32);
            this.picMudarTema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMudarTema.TabIndex = 3;
            this.picMudarTema.TabStop = false;
            // 
            // pnlOpc
            // 
            this.pnlOpc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.pnlOpc.Controls.Add(this.label3);
            this.pnlOpc.Controls.Add(this.lnkCadastro);
            this.pnlOpc.Controls.Add(this.label2);
            this.pnlOpc.Controls.Add(this.lnkReserva);
            this.pnlOpc.Controls.Add(this.label1);
            this.pnlOpc.Controls.Add(this.lnkConsultaGeral);
            this.pnlOpc.Controls.Add(this.lnkConsultaDia);
            this.pnlOpc.Controls.Add(this.picLogo);
            this.pnlOpc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.pnlOpc.Location = new System.Drawing.Point(0, 0);
            this.pnlOpc.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOpc.Name = "pnlOpc";
            this.pnlOpc.Size = new System.Drawing.Size(740, 51);
            this.pnlOpc.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.label3.Location = new System.Drawing.Point(596, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "|";
            // 
            // lnkCadastro
            // 
            this.lnkCadastro.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkCadastro.AutoSize = true;
            this.lnkCadastro.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCadastro.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkCadastro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(23)))));
            this.lnkCadastro.Location = new System.Drawing.Point(620, 20);
            this.lnkCadastro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkCadastro.Name = "lnkCadastro";
            this.lnkCadastro.Size = new System.Drawing.Size(105, 19);
            this.lnkCadastro.TabIndex = 17;
            this.lnkCadastro.TabStop = true;
            this.lnkCadastro.Text = "CADASTRO";
            this.lnkCadastro.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(465, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "|";
            // 
            // lnkReserva
            // 
            this.lnkReserva.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkReserva.AutoSize = true;
            this.lnkReserva.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReserva.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkReserva.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(23)))));
            this.lnkReserva.Location = new System.Drawing.Point(488, 20);
            this.lnkReserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkReserva.Name = "lnkReserva";
            this.lnkReserva.Size = new System.Drawing.Size(91, 19);
            this.lnkReserva.TabIndex = 16;
            this.lnkReserva.TabStop = true;
            this.lnkReserva.Text = "RESERVA";
            this.lnkReserva.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(261, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "|";
            // 
            // lnkConsultaGeral
            // 
            this.lnkConsultaGeral.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkConsultaGeral.AutoSize = true;
            this.lnkConsultaGeral.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkConsultaGeral.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkConsultaGeral.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(23)))));
            this.lnkConsultaGeral.Location = new System.Drawing.Point(284, 20);
            this.lnkConsultaGeral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkConsultaGeral.Name = "lnkConsultaGeral";
            this.lnkConsultaGeral.Size = new System.Drawing.Size(166, 19);
            this.lnkConsultaGeral.TabIndex = 15;
            this.lnkConsultaGeral.TabStop = true;
            this.lnkConsultaGeral.Text = "CONSULTA GERAL";
            this.lnkConsultaGeral.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            // 
            // lnkConsultaDia
            // 
            this.lnkConsultaDia.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkConsultaDia.AutoSize = true;
            this.lnkConsultaDia.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkConsultaDia.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkConsultaDia.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(23)))));
            this.lnkConsultaDia.Location = new System.Drawing.Point(87, 20);
            this.lnkConsultaDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkConsultaDia.Name = "lnkConsultaDia";
            this.lnkConsultaDia.Size = new System.Drawing.Size(169, 19);
            this.lnkConsultaDia.TabIndex = 14;
            this.lnkConsultaDia.TabStop = true;
            this.lnkConsultaDia.Text = "CONSULTA DO DIA";
            this.lnkConsultaDia.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(2, 5);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(65, 36);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // frmConsultaGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1097, 668);
            this.Controls.Add(this.pnlOpc);
            this.Controls.Add(this.picMudarTema);
            this.Controls.Add(this.pnlConsultaGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "frmConsultaGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Geral";
            this.pnlConsultaGeral.ResumeLayout(false);
            this.pnlConsultaGeral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).EndInit();
            this.pnlOpc.ResumeLayout(false);
            this.pnlOpc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlConsultaGeral;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.ComboBox cboLaboratorio;
        private System.Windows.Forms.DateTimePicker dtpCalendario;
        private System.Windows.Forms.Label lblCalendario;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.PictureBox picMudarTema;
        private System.Windows.Forms.Panel pnlOpc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkConsultaGeral;
        private System.Windows.Forms.LinkLabel lnkConsultaDia;
        private System.Windows.Forms.PictureBox picLogo;
    }
}