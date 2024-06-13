
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.lnkCadastro = new System.Windows.Forms.LinkLabel();
            this.lnkConsultaDia = new System.Windows.Forms.LinkLabel();
            this.lnkConsultaGeral = new System.Windows.Forms.LinkLabel();
            this.lnkReserva = new System.Windows.Forms.LinkLabel();
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
            this.tbcConsultaGeral.SuspendLayout();
            this.tbpProfessores.SuspendLayout();
            this.panelProfessores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(117)))));
            this.btnGerar.FlatAppearance.BorderSize = 0;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGerar.Image")));
            this.btnGerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerar.Location = new System.Drawing.Point(1040, 660);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(120, 27);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar PDF";
            this.btnGerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerar.UseVisualStyleBackColor = false;
            // 
            // lnkCadastro
            // 
            this.lnkCadastro.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkCadastro.AutoSize = true;
            this.lnkCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lnkCadastro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCadastro.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkCadastro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.lnkCadastro.Location = new System.Drawing.Point(1132, 17);
            this.lnkCadastro.Name = "lnkCadastro";
            this.lnkCadastro.Size = new System.Drawing.Size(149, 28);
            this.lnkCadastro.TabIndex = 24;
            this.lnkCadastro.TabStop = true;
            this.lnkCadastro.Text = "CADASTRO";
            this.lnkCadastro.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCadastro_LinkClicked);
            // 
            // lnkConsultaDia
            // 
            this.lnkConsultaDia.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkConsultaDia.AutoSize = true;
            this.lnkConsultaDia.BackColor = System.Drawing.Color.Transparent;
            this.lnkConsultaDia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkConsultaDia.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkConsultaDia.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.lnkConsultaDia.Location = new System.Drawing.Point(183, 17);
            this.lnkConsultaDia.Name = "lnkConsultaDia";
            this.lnkConsultaDia.Size = new System.Drawing.Size(239, 28);
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
            this.lnkConsultaGeral.BackColor = System.Drawing.Color.Transparent;
            this.lnkConsultaGeral.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkConsultaGeral.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkConsultaGeral.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.lnkConsultaGeral.Location = new System.Drawing.Point(541, 17);
            this.lnkConsultaGeral.Name = "lnkConsultaGeral";
            this.lnkConsultaGeral.Size = new System.Drawing.Size(236, 28);
            this.lnkConsultaGeral.TabIndex = 22;
            this.lnkConsultaGeral.TabStop = true;
            this.lnkConsultaGeral.Text = "CONSULTA GERAL";
            this.lnkConsultaGeral.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            // 
            // lnkReserva
            // 
            this.lnkReserva.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkReserva.AutoSize = true;
            this.lnkReserva.BackColor = System.Drawing.Color.Transparent;
            this.lnkReserva.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReserva.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkReserva.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.lnkReserva.Location = new System.Drawing.Point(894, 17);
            this.lnkReserva.Name = "lnkReserva";
            this.lnkReserva.Size = new System.Drawing.Size(128, 28);
            this.lnkReserva.TabIndex = 23;
            this.lnkReserva.TabStop = true;
            this.lnkReserva.Text = "RESERVA";
            this.lnkReserva.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkReserva.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReserva_LinkClicked);
            // 
            // tbcConsultaGeral
            // 
            this.tbcConsultaGeral.Controls.Add(this.tbpReservas);
            this.tbcConsultaGeral.Controls.Add(this.tbpProfessores);
            this.tbcConsultaGeral.Location = new System.Drawing.Point(294, 247);
            this.tbcConsultaGeral.Margin = new System.Windows.Forms.Padding(4);
            this.tbcConsultaGeral.Name = "tbcConsultaGeral";
            this.tbcConsultaGeral.SelectedIndex = 0;
            this.tbcConsultaGeral.Size = new System.Drawing.Size(876, 378);
            this.tbcConsultaGeral.TabIndex = 5;
            // 
            // tbpReservas
            // 
            this.tbpReservas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpReservas.Location = new System.Drawing.Point(4, 25);
            this.tbpReservas.Margin = new System.Windows.Forms.Padding(4);
            this.tbpReservas.Name = "tbpReservas";
            this.tbpReservas.Padding = new System.Windows.Forms.Padding(4);
            this.tbpReservas.Size = new System.Drawing.Size(868, 349);
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
            this.tbpProfessores.Location = new System.Drawing.Point(4, 25);
            this.tbpProfessores.Margin = new System.Windows.Forms.Padding(4);
            this.tbpProfessores.Name = "tbpProfessores";
            this.tbpProfessores.Padding = new System.Windows.Forms.Padding(4);
            this.tbpProfessores.Size = new System.Drawing.Size(868, 349);
            this.tbpProfessores.TabIndex = 1;
            this.tbpProfessores.Text = "PROFESSORES(AS)";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.btnConsultar.Location = new System.Drawing.Point(1035, 5);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(135, 33);
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
            this.panelProfessores.Location = new System.Drawing.Point(9, 46);
            this.panelProfessores.Margin = new System.Windows.Forms.Padding(4);
            this.panelProfessores.Name = "panelProfessores";
            this.panelProfessores.Size = new System.Drawing.Size(1165, 521);
            this.panelProfessores.TabIndex = 14;
            // 
            // btnExcluirReserva
            // 
            this.btnExcluirReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.btnExcluirReserva.Location = new System.Drawing.Point(821, 375);
            this.btnExcluirReserva.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirReserva.Name = "btnExcluirReserva";
            this.btnExcluirReserva.Size = new System.Drawing.Size(135, 33);
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
            this.cboReservas.Location = new System.Drawing.Point(379, 315);
            this.cboReservas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboReservas.Name = "cboReservas";
            this.cboReservas.Size = new System.Drawing.Size(760, 30);
            this.cboReservas.TabIndex = 15;
            this.cboReservas.Text = "—";
            this.cboReservas.Click += new System.EventHandler(this.cboReservas_Click);
            // 
            // lblReservasSelected
            // 
            this.lblReservasSelected.AutoSize = true;
            this.lblReservasSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservasSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblReservasSelected.Location = new System.Drawing.Point(228, 313);
            this.lblReservasSelected.Name = "lblReservasSelected";
            this.lblReservasSelected.Size = new System.Drawing.Size(30, 31);
            this.lblReservasSelected.TabIndex = 22;
            this.lblReservasSelected.Text = "—";
            // 
            // lblReservas
            // 
            this.lblReservas.AutoSize = true;
            this.lblReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblReservas.Location = new System.Drawing.Point(29, 313);
            this.lblReservas.Name = "lblReservas";
            this.lblReservas.Size = new System.Drawing.Size(138, 31);
            this.lblReservas.TabIndex = 21;
            this.lblReservas.Text = "Reservas:";
            // 
            // lblCelularSelected
            // 
            this.lblCelularSelected.AutoSize = true;
            this.lblCelularSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelularSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblCelularSelected.Location = new System.Drawing.Point(225, 235);
            this.lblCelularSelected.Name = "lblCelularSelected";
            this.lblCelularSelected.Size = new System.Drawing.Size(30, 31);
            this.lblCelularSelected.TabIndex = 20;
            this.lblCelularSelected.Text = "—";
            // 
            // lblDisciplinaProfSelected
            // 
            this.lblDisciplinaProfSelected.AutoSize = true;
            this.lblDisciplinaProfSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisciplinaProfSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblDisciplinaProfSelected.Location = new System.Drawing.Point(228, 90);
            this.lblDisciplinaProfSelected.Name = "lblDisciplinaProfSelected";
            this.lblDisciplinaProfSelected.Size = new System.Drawing.Size(30, 31);
            this.lblDisciplinaProfSelected.TabIndex = 19;
            this.lblDisciplinaProfSelected.Text = "—";
            // 
            // lblEmailSelected
            // 
            this.lblEmailSelected.AutoSize = true;
            this.lblEmailSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblEmailSelected.Location = new System.Drawing.Point(228, 164);
            this.lblEmailSelected.Name = "lblEmailSelected";
            this.lblEmailSelected.Size = new System.Drawing.Size(30, 31);
            this.lblEmailSelected.TabIndex = 18;
            this.lblEmailSelected.Text = "—";
            // 
            // lblNomeProfSelected
            // 
            this.lblNomeProfSelected.AutoSize = true;
            this.lblNomeProfSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblNomeProfSelected.Location = new System.Drawing.Point(225, 21);
            this.lblNomeProfSelected.Name = "lblNomeProfSelected";
            this.lblNomeProfSelected.Size = new System.Drawing.Size(30, 31);
            this.lblNomeProfSelected.TabIndex = 17;
            this.lblNomeProfSelected.Text = "—";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblCelular.Location = new System.Drawing.Point(52, 235);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(108, 31);
            this.lblCelular.TabIndex = 15;
            this.lblCelular.Text = "Celular:";
            // 
            // lblDisciplinaProf
            // 
            this.lblDisciplinaProf.AutoSize = true;
            this.lblDisciplinaProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisciplinaProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblDisciplinaProf.Location = new System.Drawing.Point(13, 90);
            this.lblDisciplinaProf.Name = "lblDisciplinaProf";
            this.lblDisciplinaProf.Size = new System.Drawing.Size(139, 31);
            this.lblDisciplinaProf.TabIndex = 14;
            this.lblDisciplinaProf.Text = "Disciplina:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblEmail.Location = new System.Drawing.Point(65, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(98, 31);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblProfessor.Location = new System.Drawing.Point(73, 21);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(94, 31);
            this.lblProfessor.TabIndex = 16;
            this.lblProfessor.Text = "Nome:";
            // 
            // cboProfessor
            // 
            this.cboProfessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.cboProfessor.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProfessor.ForeColor = System.Drawing.Color.Black;
            this.cboProfessor.FormattingEnabled = true;
            this.cboProfessor.Location = new System.Drawing.Point(9, 6);
            this.cboProfessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboProfessor.Name = "cboProfessor";
            this.cboProfessor.Size = new System.Drawing.Size(475, 30);
            this.cboProfessor.TabIndex = 13;
            this.cboProfessor.Text = "Selecione um(a) professor(a)";
            // 
            // frmConsultaGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1463, 822);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lnkCadastro);
            this.Controls.Add(this.lnkConsultaDia);
            this.Controls.Add(this.tbcConsultaGeral);
            this.Controls.Add(this.lnkConsultaGeral);
            this.Controls.Add(this.lnkReserva);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "frmConsultaGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Geral";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultaGeral_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultaGeral_Load);
            this.tbcConsultaGeral.ResumeLayout(false);
            this.tbpProfessores.ResumeLayout(false);
            this.panelProfessores.ResumeLayout(false);
            this.panelProfessores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.LinkLabel lnkCadastro;
        private System.Windows.Forms.LinkLabel lnkConsultaDia;
        private System.Windows.Forms.LinkLabel lnkConsultaGeral;
        private System.Windows.Forms.LinkLabel lnkReserva;
        private System.Windows.Forms.TabControl tbcConsultaGeral;
        private System.Windows.Forms.TabPage tbpReservas;
        private System.Windows.Forms.TabPage tbpProfessores;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel panelProfessores;
        private System.Windows.Forms.Button btnExcluirReserva;
        private System.Windows.Forms.ComboBox cboReservas;
        private System.Windows.Forms.Label lblReservasSelected;
        private System.Windows.Forms.Label lblReservas;
        private System.Windows.Forms.Label lblCelularSelected;
        private System.Windows.Forms.Label lblDisciplinaProfSelected;
        private System.Windows.Forms.Label lblEmailSelected;
        private System.Windows.Forms.Label lblNomeProfSelected;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblDisciplinaProf;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.ComboBox cboProfessor;
    }
}