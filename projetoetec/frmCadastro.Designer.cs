
namespace projetoetec
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.lnkCadastro = new System.Windows.Forms.LinkLabel();
            this.lnkConsultaDia = new System.Windows.Forms.LinkLabel();
            this.lnkConsultaGeral = new System.Windows.Forms.LinkLabel();
            this.lnkReserva = new System.Windows.Forms.LinkLabel();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.maskedTxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtDisciplinaProf = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.txtDisciplinaLab = new System.Windows.Forms.TextBox();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.btnDeletarprof = new System.Windows.Forms.Button();
            this.btnCadastrarProf = new System.Windows.Forms.Button();
            this.btnDeletarLab = new System.Windows.Forms.Button();
            this.btnCadastrarLab = new System.Windows.Forms.Button();
            this.cboProfessor = new System.Windows.Forms.ComboBox();
            this.cboLaboratorio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lnkCadastro
            // 
            this.lnkCadastro.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkCadastro.AutoSize = true;
            this.lnkCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lnkCadastro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCadastro.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkCadastro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.lnkCadastro.Location = new System.Drawing.Point(1184, 18);
            this.lnkCadastro.Name = "lnkCadastro";
            this.lnkCadastro.Size = new System.Drawing.Size(149, 28);
            this.lnkCadastro.TabIndex = 31;
            this.lnkCadastro.TabStop = true;
            this.lnkCadastro.Text = "CADASTRO";
            this.lnkCadastro.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            // 
            // lnkConsultaDia
            // 
            this.lnkConsultaDia.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkConsultaDia.AutoSize = true;
            this.lnkConsultaDia.BackColor = System.Drawing.Color.Transparent;
            this.lnkConsultaDia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkConsultaDia.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkConsultaDia.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.lnkConsultaDia.Location = new System.Drawing.Point(146, 18);
            this.lnkConsultaDia.Name = "lnkConsultaDia";
            this.lnkConsultaDia.Size = new System.Drawing.Size(239, 28);
            this.lnkConsultaDia.TabIndex = 28;
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
            this.lnkConsultaGeral.Location = new System.Drawing.Point(530, 18);
            this.lnkConsultaGeral.Name = "lnkConsultaGeral";
            this.lnkConsultaGeral.Size = new System.Drawing.Size(236, 28);
            this.lnkConsultaGeral.TabIndex = 29;
            this.lnkConsultaGeral.TabStop = true;
            this.lnkConsultaGeral.Text = "CONSULTA GERAL";
            this.lnkConsultaGeral.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkConsultaGeral.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConsultaGeral_LinkClicked);
            // 
            // lnkReserva
            // 
            this.lnkReserva.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkReserva.AutoSize = true;
            this.lnkReserva.BackColor = System.Drawing.Color.Transparent;
            this.lnkReserva.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReserva.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkReserva.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.lnkReserva.Location = new System.Drawing.Point(914, 18);
            this.lnkReserva.Name = "lnkReserva";
            this.lnkReserva.Size = new System.Drawing.Size(128, 28);
            this.lnkReserva.TabIndex = 30;
            this.lnkReserva.TabStop = true;
            this.lnkReserva.Text = "RESERVA";
            this.lnkReserva.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkReserva.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReserva_LinkClicked);
            // 
            // txtSala
            // 
            this.txtSala.BackColor = System.Drawing.Color.White;
            this.txtSala.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSala.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSala.Location = new System.Drawing.Point(885, 278);
            this.txtSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSala.MaxLength = 50;
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(360, 20);
            this.txtSala.TabIndex = 5;
            // 
            // maskedTxtCelular
            // 
            this.maskedTxtCelular.BackColor = System.Drawing.Color.White;
            this.maskedTxtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTxtCelular.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxtCelular.Location = new System.Drawing.Point(885, 507);
            this.maskedTxtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTxtCelular.Mask = "(00) 99999-0000";
            this.maskedTxtCelular.Name = "maskedTxtCelular";
            this.maskedTxtCelular.Size = new System.Drawing.Size(172, 24);
            this.maskedTxtCelular.TabIndex = 8;
            // 
            // txtDisciplinaProf
            // 
            this.txtDisciplinaProf.BackColor = System.Drawing.Color.White;
            this.txtDisciplinaProf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisciplinaProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisciplinaProf.Location = new System.Drawing.Point(886, 433);
            this.txtDisciplinaProf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisciplinaProf.MaxLength = 50;
            this.txtDisciplinaProf.Name = "txtDisciplinaProf";
            this.txtDisciplinaProf.Size = new System.Drawing.Size(359, 20);
            this.txtDisciplinaProf.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(885, 356);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtProfessor
            // 
            this.txtProfessor.BackColor = System.Drawing.Color.White;
            this.txtProfessor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProfessor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfessor.Location = new System.Drawing.Point(225, 433);
            this.txtProfessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfessor.MaxLength = 50;
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(140, 20);
            this.txtProfessor.TabIndex = 7;
            // 
            // txtDisciplinaLab
            // 
            this.txtDisciplinaLab.BackColor = System.Drawing.Color.White;
            this.txtDisciplinaLab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisciplinaLab.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisciplinaLab.Location = new System.Drawing.Point(225, 356);
            this.txtDisciplinaLab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisciplinaLab.MaxLength = 20;
            this.txtDisciplinaLab.Name = "txtDisciplinaLab";
            this.txtDisciplinaLab.Size = new System.Drawing.Size(366, 20);
            this.txtDisciplinaLab.TabIndex = 7;
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.BackColor = System.Drawing.Color.White;
            this.txtLaboratorio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLaboratorio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLaboratorio.Location = new System.Drawing.Point(225, 278);
            this.txtLaboratorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLaboratorio.MaxLength = 50;
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(366, 20);
            this.txtLaboratorio.TabIndex = 3;
            // 
            // btnDeletarprof
            // 
            this.btnDeletarprof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(117)))));
            this.btnDeletarprof.FlatAppearance.BorderSize = 0;
            this.btnDeletarprof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarprof.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarprof.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletarprof.Location = new System.Drawing.Point(1142, 653);
            this.btnDeletarprof.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeletarprof.Name = "btnDeletarprof";
            this.btnDeletarprof.Size = new System.Drawing.Size(96, 23);
            this.btnDeletarprof.TabIndex = 13;
            this.btnDeletarprof.Text = "Deletar";
            this.btnDeletarprof.UseCompatibleTextRendering = true;
            this.btnDeletarprof.UseVisualStyleBackColor = false;
            this.btnDeletarprof.Click += new System.EventHandler(this.btnDeletarprof_Click);
            // 
            // btnCadastrarProf
            // 
            this.btnCadastrarProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(117)))));
            this.btnCadastrarProf.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarProf.Location = new System.Drawing.Point(1135, 507);
            this.btnCadastrarProf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrarProf.Name = "btnCadastrarProf";
            this.btnCadastrarProf.Size = new System.Drawing.Size(106, 26);
            this.btnCadastrarProf.TabIndex = 11;
            this.btnCadastrarProf.Text = "Cadastrar";
            this.btnCadastrarProf.UseCompatibleTextRendering = true;
            this.btnCadastrarProf.UseVisualStyleBackColor = false;
            this.btnCadastrarProf.Click += new System.EventHandler(this.btnCadastrarProf_Click);
            // 
            // btnDeletarLab
            // 
            this.btnDeletarLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(117)))));
            this.btnDeletarLab.FlatAppearance.BorderSize = 0;
            this.btnDeletarLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarLab.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.btnDeletarLab.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletarLab.Location = new System.Drawing.Point(493, 653);
            this.btnDeletarLab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeletarLab.Name = "btnDeletarLab";
            this.btnDeletarLab.Size = new System.Drawing.Size(77, 23);
            this.btnDeletarLab.TabIndex = 10;
            this.btnDeletarLab.Text = "Deletar";
            this.btnDeletarLab.UseCompatibleTextRendering = true;
            this.btnDeletarLab.UseVisualStyleBackColor = false;
            this.btnDeletarLab.Click += new System.EventHandler(this.btnDeletarLab_Click);
            // 
            // btnCadastrarLab
            // 
            this.btnCadastrarLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(117)))));
            this.btnCadastrarLab.FlatAppearance.BorderSize = 0;
            this.btnCadastrarLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarLab.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarLab.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarLab.Location = new System.Drawing.Point(481, 431);
            this.btnCadastrarLab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrarLab.Name = "btnCadastrarLab";
            this.btnCadastrarLab.Size = new System.Drawing.Size(100, 25);
            this.btnCadastrarLab.TabIndex = 8;
            this.btnCadastrarLab.Text = "Cadastrar";
            this.btnCadastrarLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarLab.UseCompatibleTextRendering = true;
            this.btnCadastrarLab.UseVisualStyleBackColor = false;
            this.btnCadastrarLab.Click += new System.EventHandler(this.btnCadastrarLab_Click);
            // 
            // cboProfessor
            // 
            this.cboProfessor.BackColor = System.Drawing.Color.White;
            this.cboProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProfessor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProfessor.ForeColor = System.Drawing.Color.Black;
            this.cboProfessor.FormattingEnabled = true;
            this.cboProfessor.Location = new System.Drawing.Point(883, 584);
            this.cboProfessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboProfessor.Name = "cboProfessor";
            this.cboProfessor.Size = new System.Drawing.Size(366, 25);
            this.cboProfessor.TabIndex = 12;
            this.cboProfessor.Text = "Selecione o professor que deseja deletar";
            // 
            // cboLaboratorio
            // 
            this.cboLaboratorio.BackColor = System.Drawing.Color.White;
            this.cboLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLaboratorio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLaboratorio.ForeColor = System.Drawing.Color.Black;
            this.cboLaboratorio.FormattingEnabled = true;
            this.cboLaboratorio.Items.AddRange(new object[] {
            "sqsq",
            "4ty4t",
            "y5y5y"});
            this.cboLaboratorio.Location = new System.Drawing.Point(227, 507);
            this.cboLaboratorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLaboratorio.MaxDropDownItems = 4;
            this.cboLaboratorio.Name = "cboLaboratorio";
            this.cboLaboratorio.Size = new System.Drawing.Size(361, 25);
            this.cboLaboratorio.TabIndex = 9;
            this.cboLaboratorio.Text = "Selecione o laboratório que deseja deletar";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1463, 822);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.lnkCadastro);
            this.Controls.Add(this.maskedTxtCelular);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDisciplinaProf);
            this.Controls.Add(this.btnCadastrarProf);
            this.Controls.Add(this.lnkConsultaGeral);
            this.Controls.Add(this.lnkReserva);
            this.Controls.Add(this.btnDeletarprof);
            this.Controls.Add(this.txtProfessor);
            this.Controls.Add(this.lnkConsultaDia);
            this.Controls.Add(this.txtLaboratorio);
            this.Controls.Add(this.txtDisciplinaLab);
            this.Controls.Add(this.cboProfessor);
            this.Controls.Add(this.btnDeletarLab);
            this.Controls.Add(this.btnCadastrarLab);
            this.Controls.Add(this.cboLaboratorio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastro_FormClosing);
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnkCadastro;
        private System.Windows.Forms.LinkLabel lnkConsultaDia;
        private System.Windows.Forms.LinkLabel lnkConsultaGeral;
        private System.Windows.Forms.LinkLabel lnkReserva;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.MaskedTextBox maskedTxtCelular;
        private System.Windows.Forms.TextBox txtDisciplinaProf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.TextBox txtDisciplinaLab;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.Button btnDeletarprof;
        private System.Windows.Forms.Button btnCadastrarProf;
        private System.Windows.Forms.Button btnDeletarLab;
        private System.Windows.Forms.Button btnCadastrarLab;
        private System.Windows.Forms.ComboBox cboProfessor;
        private System.Windows.Forms.ComboBox cboLaboratorio;
    }
}