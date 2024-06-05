
namespace projetoetec
{
    partial class frmReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserva));
            this.pnlReserva = new System.Windows.Forms.Panel();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.dtpReservaRepetir = new System.Windows.Forms.DateTimePicker();
            this.ckbRepetir = new System.Windows.Forms.CheckBox();
            this.cboFinal = new System.Windows.Forms.ComboBox();
            this.cboInicial = new System.Windows.Forms.ComboBox();
            this.lblAs = new System.Windows.Forms.Label();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.dtpReserva = new System.Windows.Forms.DateTimePicker();
            this.btnReservar = new System.Windows.Forms.Button();
            this.cboProfessor = new System.Windows.Forms.ComboBox();
            this.cboLaboratorio = new System.Windows.Forms.ComboBox();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.pnlOpc = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lnkCadastro = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.lnkReserva = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lnkConsultaGeral = new System.Windows.Forms.LinkLabel();
            this.linkConsultaDia = new System.Windows.Forms.LinkLabel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picMudarTema = new System.Windows.Forms.PictureBox();
            this.pnlReserva.SuspendLayout();
            this.pnlOpc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReserva
            // 
            this.pnlReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.pnlReserva.Controls.Add(this.lblDataFinal);
            this.pnlReserva.Controls.Add(this.dtpReservaRepetir);
            this.pnlReserva.Controls.Add(this.ckbRepetir);
            this.pnlReserva.Controls.Add(this.cboFinal);
            this.pnlReserva.Controls.Add(this.cboInicial);
            this.pnlReserva.Controls.Add(this.lblAs);
            this.pnlReserva.Controls.Add(this.lblDataInicial);
            this.pnlReserva.Controls.Add(this.dtpReserva);
            this.pnlReserva.Controls.Add(this.btnReservar);
            this.pnlReserva.Controls.Add(this.cboProfessor);
            this.pnlReserva.Controls.Add(this.cboLaboratorio);
            this.pnlReserva.Controls.Add(this.lblProfessor);
            this.pnlReserva.Controls.Add(this.lblHora);
            this.pnlReserva.Controls.Add(this.lblLaboratorio);
            this.pnlReserva.Location = new System.Drawing.Point(100, 108);
            this.pnlReserva.Margin = new System.Windows.Forms.Padding(2);
            this.pnlReserva.Name = "pnlReserva";
            this.pnlReserva.Size = new System.Drawing.Size(906, 503);
            this.pnlReserva.TabIndex = 0;
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblDataFinal.Location = new System.Drawing.Point(124, 204);
            this.lblDataFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(120, 22);
            this.lblDataFinal.TabIndex = 15;
            this.lblDataFinal.Text = "Data Final:";
            // 
            // dtpReservaRepetir
            // 
            this.dtpReservaRepetir.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReservaRepetir.Location = new System.Drawing.Point(248, 204);
            this.dtpReservaRepetir.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpReservaRepetir.Name = "dtpReservaRepetir";
            this.dtpReservaRepetir.Size = new System.Drawing.Size(514, 29);
            this.dtpReservaRepetir.TabIndex = 14;
            // 
            // ckbRepetir
            // 
            this.ckbRepetir.AutoSize = true;
            this.ckbRepetir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.ckbRepetir.Location = new System.Drawing.Point(768, 165);
            this.ckbRepetir.Name = "ckbRepetir";
            this.ckbRepetir.Size = new System.Drawing.Size(73, 17);
            this.ckbRepetir.TabIndex = 13;
            this.ckbRepetir.Text = "REPETIR";
            this.ckbRepetir.UseVisualStyleBackColor = true;
            this.ckbRepetir.CheckedChanged += new System.EventHandler(this.ckbRepetir_CheckedChanged);
            this.ckbRepetir.MouseHover += new System.EventHandler(this.ckbRepetir_MouseHover);
            // 
            // cboFinal
            // 
            this.cboFinal.DropDownHeight = 150;
            this.cboFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFinal.FormattingEnabled = true;
            this.cboFinal.IntegralHeight = false;
            this.cboFinal.ItemHeight = 18;
            this.cboFinal.Location = new System.Drawing.Point(421, 279);
            this.cboFinal.Name = "cboFinal";
            this.cboFinal.Size = new System.Drawing.Size(100, 26);
            this.cboFinal.TabIndex = 12;
            // 
            // cboInicial
            // 
            this.cboInicial.DropDownHeight = 150;
            this.cboInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInicial.FormattingEnabled = true;
            this.cboInicial.IntegralHeight = false;
            this.cboInicial.ItemHeight = 18;
            this.cboInicial.Location = new System.Drawing.Point(248, 279);
            this.cboInicial.Name = "cboInicial";
            this.cboInicial.Size = new System.Drawing.Size(100, 26);
            this.cboInicial.TabIndex = 11;
            // 
            // lblAs
            // 
            this.lblAs.AutoSize = true;
            this.lblAs.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblAs.Location = new System.Drawing.Point(372, 281);
            this.lblAs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAs.Name = "lblAs";
            this.lblAs.Size = new System.Drawing.Size(30, 22);
            this.lblAs.TabIndex = 10;
            this.lblAs.Text = "às";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblDataInicial.Location = new System.Drawing.Point(183, 160);
            this.lblDataInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(60, 22);
            this.lblDataInicial.TabIndex = 7;
            this.lblDataInicial.Text = "Data:";
            // 
            // dtpReserva
            // 
            this.dtpReserva.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReserva.Location = new System.Drawing.Point(248, 160);
            this.dtpReserva.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpReserva.Name = "dtpReserva";
            this.dtpReserva.Size = new System.Drawing.Size(514, 29);
            this.dtpReserva.TabIndex = 3;
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.btnReservar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(766, 432);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(2);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(106, 36);
            this.btnReservar.TabIndex = 6;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // cboProfessor
            // 
            this.cboProfessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.cboProfessor.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProfessor.ForeColor = System.Drawing.Color.Black;
            this.cboProfessor.FormattingEnabled = true;
            this.cboProfessor.Location = new System.Drawing.Point(248, 87);
            this.cboProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.cboProfessor.Name = "cboProfessor";
            this.cboProfessor.Size = new System.Drawing.Size(514, 30);
            this.cboProfessor.TabIndex = 2;
            this.cboProfessor.Text = "Selecione um professor para a reserva";
            // 
            // cboLaboratorio
            // 
            this.cboLaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.cboLaboratorio.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLaboratorio.ForeColor = System.Drawing.Color.Black;
            this.cboLaboratorio.FormattingEnabled = true;
            this.cboLaboratorio.Location = new System.Drawing.Point(248, 41);
            this.cboLaboratorio.Margin = new System.Windows.Forms.Padding(2);
            this.cboLaboratorio.MaxDropDownItems = 1;
            this.cboLaboratorio.Name = "cboLaboratorio";
            this.cboLaboratorio.Size = new System.Drawing.Size(514, 30);
            this.cboLaboratorio.TabIndex = 1;
            this.cboLaboratorio.Text = "Selecione um laboratório para a reserva";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblProfessor.Location = new System.Drawing.Point(134, 87);
            this.lblProfessor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(110, 22);
            this.lblProfessor.TabIndex = 3;
            this.lblProfessor.Text = "Professor:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblHora.Location = new System.Drawing.Point(74, 281);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(170, 22);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "Horário Inicial:";
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblLaboratorio.Location = new System.Drawing.Point(114, 44);
            this.lblLaboratorio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(130, 22);
            this.lblLaboratorio.TabIndex = 0;
            this.lblLaboratorio.Text = "Laboratório:";
            // 
            // pnlOpc
            // 
            this.pnlOpc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.pnlOpc.Controls.Add(this.label7);
            this.pnlOpc.Controls.Add(this.lnkCadastro);
            this.pnlOpc.Controls.Add(this.label6);
            this.pnlOpc.Controls.Add(this.lnkReserva);
            this.pnlOpc.Controls.Add(this.label5);
            this.pnlOpc.Controls.Add(this.lnkConsultaGeral);
            this.pnlOpc.Controls.Add(this.linkConsultaDia);
            this.pnlOpc.Controls.Add(this.picLogo);
            this.pnlOpc.Location = new System.Drawing.Point(-1, -1);
            this.pnlOpc.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOpc.Name = "pnlOpc";
            this.pnlOpc.Size = new System.Drawing.Size(1097, 51);
            this.pnlOpc.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.label7.Location = new System.Drawing.Point(839, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "|";
            // 
            // lnkCadastro
            // 
            this.lnkCadastro.AutoSize = true;
            this.lnkCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCadastro.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkCadastro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(23)))));
            this.lnkCadastro.Location = new System.Drawing.Point(912, 15);
            this.lnkCadastro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkCadastro.Name = "lnkCadastro";
            this.lnkCadastro.Size = new System.Drawing.Size(114, 24);
            this.lnkCadastro.TabIndex = 20;
            this.lnkCadastro.TabStop = true;
            this.lnkCadastro.Text = "CADASTRO";
            this.lnkCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCadastro_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.label6.Location = new System.Drawing.Point(603, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "|";
            // 
            // lnkReserva
            // 
            this.lnkReserva.AutoSize = true;
            this.lnkReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReserva.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkReserva.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(23)))));
            this.lnkReserva.Location = new System.Drawing.Point(678, 15);
            this.lnkReserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkReserva.Name = "lnkReserva";
            this.lnkReserva.Size = new System.Drawing.Size(100, 24);
            this.lnkReserva.TabIndex = 19;
            this.lnkReserva.TabStop = true;
            this.lnkReserva.Text = "RESERVA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.label5.Location = new System.Drawing.Point(309, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "|";
            // 
            // lnkConsultaGeral
            // 
            this.lnkConsultaGeral.AutoSize = true;
            this.lnkConsultaGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkConsultaGeral.ForeColor = System.Drawing.Color.Black;
            this.lnkConsultaGeral.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkConsultaGeral.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(23)))));
            this.lnkConsultaGeral.Location = new System.Drawing.Point(365, 15);
            this.lnkConsultaGeral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkConsultaGeral.Name = "lnkConsultaGeral";
            this.lnkConsultaGeral.Size = new System.Drawing.Size(180, 24);
            this.lnkConsultaGeral.TabIndex = 18;
            this.lnkConsultaGeral.TabStop = true;
            this.lnkConsultaGeral.Text = "CONSULTA GERAL";
            this.lnkConsultaGeral.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConsultaGeral_LinkClicked);
            // 
            // linkConsultaDia
            // 
            this.linkConsultaDia.AutoSize = true;
            this.linkConsultaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkConsultaDia.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkConsultaDia.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(23)))));
            this.linkConsultaDia.Location = new System.Drawing.Point(88, 15);
            this.linkConsultaDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkConsultaDia.Name = "linkConsultaDia";
            this.linkConsultaDia.Size = new System.Drawing.Size(180, 24);
            this.linkConsultaDia.TabIndex = 17;
            this.linkConsultaDia.TabStop = true;
            this.linkConsultaDia.Text = "CONSULTA DO DIA";
            this.linkConsultaDia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkConsultaDia_LinkClicked);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 9);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(70, 38);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // picMudarTema
            // 
            this.picMudarTema.Image = ((System.Drawing.Image)(resources.GetObject("picMudarTema.Image")));
            this.picMudarTema.Location = new System.Drawing.Point(-1, 50);
            this.picMudarTema.Name = "picMudarTema";
            this.picMudarTema.Size = new System.Drawing.Size(32, 32);
            this.picMudarTema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMudarTema.TabIndex = 4;
            this.picMudarTema.TabStop = false;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1097, 668);
            this.Controls.Add(this.picMudarTema);
            this.Controls.Add(this.pnlOpc);
            this.Controls.Add(this.pnlReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReserva_FormClosing);
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.pnlReserva.ResumeLayout(false);
            this.pnlReserva.PerformLayout();
            this.pnlOpc.ResumeLayout(false);
            this.pnlOpc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlReserva;
        private System.Windows.Forms.Panel pnlOpc;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.ComboBox cboProfessor;
        private System.Windows.Forms.ComboBox cboLaboratorio;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.DateTimePicker dtpReserva;
        private System.Windows.Forms.Label lblAs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lnkCadastro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lnkReserva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lnkConsultaGeral;
        private System.Windows.Forms.LinkLabel linkConsultaDia;
        private System.Windows.Forms.PictureBox picMudarTema;
        private System.Windows.Forms.ComboBox cboFinal;
        private System.Windows.Forms.ComboBox cboInicial;
        private System.Windows.Forms.CheckBox ckbRepetir;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.DateTimePicker dtpReservaRepetir;
    }
}