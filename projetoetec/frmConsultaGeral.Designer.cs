
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
            this.tbcConsultaGeral = new System.Windows.Forms.TabControl();
            this.tbpReservas = new System.Windows.Forms.TabPage();
            this.tbpProfessores = new System.Windows.Forms.TabPage();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.panelProfessores = new System.Windows.Forms.Panel();
            this.btnExcluirReserva = new System.Windows.Forms.Button();
            this.cboReservas = new System.Windows.Forms.ComboBox();
            this.lblReservasSelected = new System.Windows.Forms.Label();
            this.lblReservas = new System.Windows.Forms.Label();
            this.lblCelularSelected = new System.Windows.Forms.Label();
            this.lblDisciplinaProfSelected = new System.Windows.Forms.Label();
            this.lblEmailSelected = new System.Windows.Forms.Label();
            this.lblNomeProfSelected = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblDisciplinaProf = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.cboProfessor = new System.Windows.Forms.ComboBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.picMudarTema = new System.Windows.Forms.PictureBox();
            this.pnlOpc = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkCadastro = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkConsultaDia = new System.Windows.Forms.LinkLabel();
            this.lnkConsultaGeral = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkReserva = new System.Windows.Forms.LinkLabel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlConsultaGeral.SuspendLayout();
            this.tbcConsultaGeral.SuspendLayout();
            this.tbpProfessores.SuspendLayout();
            this.panelProfessores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).BeginInit();
            this.pnlOpc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConsultaGeral
            // 
            this.pnlConsultaGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.pnlConsultaGeral.Controls.Add(this.tbcConsultaGeral);
            this.pnlConsultaGeral.Location = new System.Drawing.Point(96, 106);
            this.pnlConsultaGeral.Margin = new System.Windows.Forms.Padding(2);
            this.pnlConsultaGeral.Name = "pnlConsultaGeral";
            this.pnlConsultaGeral.Size = new System.Drawing.Size(906, 503);
            this.pnlConsultaGeral.TabIndex = 0;
            // 
            // tbcConsultaGeral
            // 
            this.tbcConsultaGeral.Controls.Add(this.tbpReservas);
            this.tbcConsultaGeral.Controls.Add(this.tbpProfessores);
            this.tbcConsultaGeral.Location = new System.Drawing.Point(4, 4);
            this.tbcConsultaGeral.Name = "tbcConsultaGeral";
            this.tbcConsultaGeral.SelectedIndex = 0;
            this.tbcConsultaGeral.Size = new System.Drawing.Size(899, 496);
            this.tbcConsultaGeral.TabIndex = 5;
            // 
            // tbpReservas
            // 
            this.tbpReservas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpReservas.Location = new System.Drawing.Point(4, 22);
            this.tbpReservas.Name = "tbpReservas";
            this.tbpReservas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpReservas.Size = new System.Drawing.Size(891, 470);
            this.tbpReservas.TabIndex = 0;
            this.tbpReservas.Text = "RESERVAS";
            this.tbpReservas.UseVisualStyleBackColor = true;
            // 
            // tbpProfessores
            // 
            this.tbpProfessores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.tbpProfessores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpProfessores.Controls.Add(this.btnConsultar);
            this.tbpProfessores.Controls.Add(this.panelProfessores);
            this.tbpProfessores.Controls.Add(this.cboProfessor);
            this.tbpProfessores.Location = new System.Drawing.Point(4, 22);
            this.tbpProfessores.Name = "tbpProfessores";
            this.tbpProfessores.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProfessores.Size = new System.Drawing.Size(891, 470);
            this.tbpProfessores.TabIndex = 1;
            this.tbpProfessores.Text = "PROFESSORES(AS)";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.btnConsultar.Location = new System.Drawing.Point(776, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(101, 27);
            this.btnConsultar.TabIndex = 23;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // panelProfessores
            // 
            this.panelProfessores.Controls.Add(this.btnExcluirReserva);
            this.panelProfessores.Controls.Add(this.cboReservas);
            this.panelProfessores.Controls.Add(this.lblReservasSelected);
            this.panelProfessores.Controls.Add(this.lblReservas);
            this.panelProfessores.Controls.Add(this.lblCelularSelected);
            this.panelProfessores.Controls.Add(this.lblDisciplinaProfSelected);
            this.panelProfessores.Controls.Add(this.lblEmailSelected);
            this.panelProfessores.Controls.Add(this.lblNomeProfSelected);
            this.panelProfessores.Controls.Add(this.lblCelular);
            this.panelProfessores.Controls.Add(this.lblDisciplinaProf);
            this.panelProfessores.Controls.Add(this.lblEmail);
            this.panelProfessores.Controls.Add(this.lblProfessor);
            this.panelProfessores.Location = new System.Drawing.Point(7, 37);
            this.panelProfessores.Name = "panelProfessores";
            this.panelProfessores.Size = new System.Drawing.Size(874, 423);
            this.panelProfessores.TabIndex = 14;
            // 
            // btnExcluirReserva
            // 
            this.btnExcluirReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.btnExcluirReserva.Location = new System.Drawing.Point(616, 305);
            this.btnExcluirReserva.Name = "btnExcluirReserva";
            this.btnExcluirReserva.Size = new System.Drawing.Size(101, 27);
            this.btnExcluirReserva.TabIndex = 24;
            this.btnExcluirReserva.Text = "Excluir Reserva";
            this.btnExcluirReserva.UseVisualStyleBackColor = false;
            this.btnExcluirReserva.Click += new System.EventHandler(this.btnExcluirReserva_Click);
            // 
            // cboReservas
            // 
            this.cboReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.cboReservas.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReservas.ForeColor = System.Drawing.Color.Black;
            this.cboReservas.FormattingEnabled = true;
            this.cboReservas.Location = new System.Drawing.Point(284, 256);
            this.cboReservas.Margin = new System.Windows.Forms.Padding(2);
            this.cboReservas.Name = "cboReservas";
            this.cboReservas.Size = new System.Drawing.Size(571, 26);
            this.cboReservas.TabIndex = 15;
            this.cboReservas.Text = "—";
            this.cboReservas.Click += new System.EventHandler(this.cboReservas_Click);
            // 
            // lblReservasSelected
            // 
            this.lblReservasSelected.AutoSize = true;
            this.lblReservasSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservasSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblReservasSelected.Location = new System.Drawing.Point(171, 254);
            this.lblReservasSelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReservasSelected.Name = "lblReservasSelected";
            this.lblReservasSelected.Size = new System.Drawing.Size(24, 25);
            this.lblReservasSelected.TabIndex = 22;
            this.lblReservasSelected.Text = "—";
            // 
            // lblReservas
            // 
            this.lblReservas.AutoSize = true;
            this.lblReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblReservas.Location = new System.Drawing.Point(22, 254);
            this.lblReservas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReservas.Name = "lblReservas";
            this.lblReservas.Size = new System.Drawing.Size(109, 25);
            this.lblReservas.TabIndex = 21;
            this.lblReservas.Text = "Reservas:";
            // 
            // lblCelularSelected
            // 
            this.lblCelularSelected.AutoSize = true;
            this.lblCelularSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelularSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblCelularSelected.Location = new System.Drawing.Point(169, 191);
            this.lblCelularSelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCelularSelected.Name = "lblCelularSelected";
            this.lblCelularSelected.Size = new System.Drawing.Size(24, 25);
            this.lblCelularSelected.TabIndex = 20;
            this.lblCelularSelected.Text = "—";
            // 
            // lblDisciplinaProfSelected
            // 
            this.lblDisciplinaProfSelected.AutoSize = true;
            this.lblDisciplinaProfSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisciplinaProfSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblDisciplinaProfSelected.Location = new System.Drawing.Point(171, 73);
            this.lblDisciplinaProfSelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisciplinaProfSelected.Name = "lblDisciplinaProfSelected";
            this.lblDisciplinaProfSelected.Size = new System.Drawing.Size(24, 25);
            this.lblDisciplinaProfSelected.TabIndex = 19;
            this.lblDisciplinaProfSelected.Text = "—";
            // 
            // lblEmailSelected
            // 
            this.lblEmailSelected.AutoSize = true;
            this.lblEmailSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblEmailSelected.Location = new System.Drawing.Point(171, 133);
            this.lblEmailSelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailSelected.Name = "lblEmailSelected";
            this.lblEmailSelected.Size = new System.Drawing.Size(24, 25);
            this.lblEmailSelected.TabIndex = 18;
            this.lblEmailSelected.Text = "—";
            // 
            // lblNomeProfSelected
            // 
            this.lblNomeProfSelected.AutoSize = true;
            this.lblNomeProfSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblNomeProfSelected.Location = new System.Drawing.Point(169, 17);
            this.lblNomeProfSelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeProfSelected.Name = "lblNomeProfSelected";
            this.lblNomeProfSelected.Size = new System.Drawing.Size(24, 25);
            this.lblNomeProfSelected.TabIndex = 17;
            this.lblNomeProfSelected.Text = "—";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblCelular.Location = new System.Drawing.Point(39, 191);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(86, 25);
            this.lblCelular.TabIndex = 15;
            this.lblCelular.Text = "Celular:";
            // 
            // lblDisciplinaProf
            // 
            this.lblDisciplinaProf.AutoSize = true;
            this.lblDisciplinaProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisciplinaProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblDisciplinaProf.Location = new System.Drawing.Point(10, 73);
            this.lblDisciplinaProf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisciplinaProf.Name = "lblDisciplinaProf";
            this.lblDisciplinaProf.Size = new System.Drawing.Size(111, 25);
            this.lblDisciplinaProf.TabIndex = 14;
            this.lblDisciplinaProf.Text = "Disciplina:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblEmail.Location = new System.Drawing.Point(49, 133);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 25);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblProfessor.Location = new System.Drawing.Point(55, 17);
            this.lblProfessor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(74, 25);
            this.lblProfessor.TabIndex = 16;
            this.lblProfessor.Text = "Nome:";
            // 
            // cboProfessor
            // 
            this.cboProfessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.cboProfessor.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProfessor.ForeColor = System.Drawing.Color.Black;
            this.cboProfessor.FormattingEnabled = true;
            this.cboProfessor.Location = new System.Drawing.Point(7, 5);
            this.cboProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.cboProfessor.Name = "cboProfessor";
            this.cboProfessor.Size = new System.Drawing.Size(357, 26);
            this.cboProfessor.TabIndex = 13;
            this.cboProfessor.Text = "Selecione um(a) professor(a)";
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGerar.Image")));
            this.btnGerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerar.Location = new System.Drawing.Point(960, 628);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(113, 29);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar PDF";
            this.btnGerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerar.UseVisualStyleBackColor = false;
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
            this.pnlOpc.Controls.Add(this.lnkConsultaDia);
            this.pnlOpc.Controls.Add(this.lnkConsultaGeral);
            this.pnlOpc.Controls.Add(this.label1);
            this.pnlOpc.Controls.Add(this.lnkReserva);
            this.pnlOpc.Controls.Add(this.picLogo);
            this.pnlOpc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.pnlOpc.Location = new System.Drawing.Point(0, 0);
            this.pnlOpc.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOpc.Name = "pnlOpc";
            this.pnlOpc.Size = new System.Drawing.Size(1103, 51);
            this.pnlOpc.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.label3.Location = new System.Drawing.Point(877, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "|";
            // 
            // lnkCadastro
            // 
            this.lnkCadastro.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkCadastro.AutoSize = true;
            this.lnkCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCadastro.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkCadastro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(23)))));
            this.lnkCadastro.Location = new System.Drawing.Point(927, 12);
            this.lnkCadastro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkCadastro.Name = "lnkCadastro";
            this.lnkCadastro.Size = new System.Drawing.Size(128, 25);
            this.lnkCadastro.TabIndex = 24;
            this.lnkCadastro.TabStop = true;
            this.lnkCadastro.Text = "CADASTRO";
            this.lnkCadastro.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCadastro_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(647, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "|";
            // 
            // lnkConsultaDia
            // 
            this.lnkConsultaDia.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkConsultaDia.AutoSize = true;
            this.lnkConsultaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkConsultaDia.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkConsultaDia.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(23)))));
            this.lnkConsultaDia.Location = new System.Drawing.Point(92, 12);
            this.lnkConsultaDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkConsultaDia.Name = "lnkConsultaDia";
            this.lnkConsultaDia.Size = new System.Drawing.Size(203, 25);
            this.lnkConsultaDia.TabIndex = 21;
            this.lnkConsultaDia.TabStop = true;
            this.lnkConsultaDia.Text = "CONSULTA DO DIA";
            this.lnkConsultaDia.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkConsultaDia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConsultaDia_LinkClicked);
            // 
            // lnkConsultaGeral
            // 
            this.lnkConsultaGeral.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkConsultaGeral.AutoSize = true;
            this.lnkConsultaGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkConsultaGeral.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkConsultaGeral.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(23)))));
            this.lnkConsultaGeral.Location = new System.Drawing.Point(393, 12);
            this.lnkConsultaGeral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkConsultaGeral.Name = "lnkConsultaGeral";
            this.lnkConsultaGeral.Size = new System.Drawing.Size(203, 25);
            this.lnkConsultaGeral.TabIndex = 22;
            this.lnkConsultaGeral.TabStop = true;
            this.lnkConsultaGeral.Text = "CONSULTA GERAL";
            this.lnkConsultaGeral.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(340, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "|";
            // 
            // lnkReserva
            // 
            this.lnkReserva.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkReserva.AutoSize = true;
            this.lnkReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReserva.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkReserva.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(23)))));
            this.lnkReserva.Location = new System.Drawing.Point(710, 12);
            this.lnkReserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkReserva.Name = "lnkReserva";
            this.lnkReserva.Size = new System.Drawing.Size(112, 25);
            this.lnkReserva.TabIndex = 23;
            this.lnkReserva.TabStop = true;
            this.lnkReserva.Text = "RESERVA";
            this.lnkReserva.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkReserva.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReserva_LinkClicked);
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
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.picMudarTema);
            this.Controls.Add(this.pnlConsultaGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "frmConsultaGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Geral";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultaGeral_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultaGeral_Load);
            this.pnlConsultaGeral.ResumeLayout(false);
            this.tbcConsultaGeral.ResumeLayout(false);
            this.tbpProfessores.ResumeLayout(false);
            this.panelProfessores.ResumeLayout(false);
            this.panelProfessores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).EndInit();
            this.pnlOpc.ResumeLayout(false);
            this.pnlOpc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlConsultaGeral;
        private System.Windows.Forms.PictureBox picMudarTema;
        private System.Windows.Forms.Panel pnlOpc;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkConsultaDia;
        private System.Windows.Forms.LinkLabel lnkConsultaGeral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkReserva;
        private System.Windows.Forms.TabControl tbcConsultaGeral;
        private System.Windows.Forms.TabPage tbpReservas;
        private System.Windows.Forms.TabPage tbpProfessores;
        private System.Windows.Forms.ComboBox cboProfessor;
        private System.Windows.Forms.Panel panelProfessores;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblDisciplinaProf;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblReservas;
        private System.Windows.Forms.Label lblCelularSelected;
        private System.Windows.Forms.Label lblDisciplinaProfSelected;
        private System.Windows.Forms.Label lblEmailSelected;
        private System.Windows.Forms.Label lblNomeProfSelected;
        private System.Windows.Forms.ComboBox cboReservas;
        private System.Windows.Forms.Label lblReservasSelected;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluirReserva;
    }
}