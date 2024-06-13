
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
            this.dtpReservaRepetir = new System.Windows.Forms.DateTimePicker();
            this.ckbRepetir = new System.Windows.Forms.CheckBox();
            this.cboFinal = new System.Windows.Forms.ComboBox();
            this.cboInicial = new System.Windows.Forms.ComboBox();
            this.dtpReserva = new System.Windows.Forms.DateTimePicker();
            this.btnReservar = new System.Windows.Forms.Button();
            this.cboProfessor = new System.Windows.Forms.ComboBox();
            this.cboLaboratorio = new System.Windows.Forms.ComboBox();
            this.lnkCadastro = new System.Windows.Forms.LinkLabel();
            this.lnkReserva = new System.Windows.Forms.LinkLabel();
            this.lnkConsultaGeral = new System.Windows.Forms.LinkLabel();
            this.linkConsultaDia = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // dtpReservaRepetir
            // 
            this.dtpReservaRepetir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReservaRepetir.Location = new System.Drawing.Point(482, 508);
            this.dtpReservaRepetir.Margin = new System.Windows.Forms.Padding(4);
            this.dtpReservaRepetir.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpReservaRepetir.Name = "dtpReservaRepetir";
            this.dtpReservaRepetir.Size = new System.Drawing.Size(645, 27);
            this.dtpReservaRepetir.TabIndex = 14;
            // 
            // ckbRepetir
            // 
            this.ckbRepetir.AutoSize = true;
            this.ckbRepetir.BackColor = System.Drawing.Color.Transparent;
            this.ckbRepetir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbRepetir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.ckbRepetir.Location = new System.Drawing.Point(1159, 439);
            this.ckbRepetir.Margin = new System.Windows.Forms.Padding(4);
            this.ckbRepetir.Name = "ckbRepetir";
            this.ckbRepetir.Size = new System.Drawing.Size(90, 20);
            this.ckbRepetir.TabIndex = 13;
            this.ckbRepetir.Text = "REPETIR";
            this.ckbRepetir.UseVisualStyleBackColor = false;
            this.ckbRepetir.CheckedChanged += new System.EventHandler(this.ckbRepetir_CheckedChanged);
            this.ckbRepetir.MouseHover += new System.EventHandler(this.ckbRepetir_MouseHover);
            // 
            // cboFinal
            // 
            this.cboFinal.BackColor = System.Drawing.Color.White;
            this.cboFinal.DropDownHeight = 150;
            this.cboFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFinal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFinal.FormattingEnabled = true;
            this.cboFinal.IntegralHeight = false;
            this.cboFinal.ItemHeight = 20;
            this.cboFinal.Location = new System.Drawing.Point(689, 584);
            this.cboFinal.Margin = new System.Windows.Forms.Padding(4);
            this.cboFinal.Name = "cboFinal";
            this.cboFinal.Size = new System.Drawing.Size(100, 28);
            this.cboFinal.TabIndex = 12;
            // 
            // cboInicial
            // 
            this.cboInicial.BackColor = System.Drawing.Color.White;
            this.cboInicial.DropDownHeight = 150;
            this.cboInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboInicial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInicial.FormattingEnabled = true;
            this.cboInicial.IntegralHeight = false;
            this.cboInicial.ItemHeight = 20;
            this.cboInicial.Location = new System.Drawing.Point(482, 583);
            this.cboInicial.Margin = new System.Windows.Forms.Padding(4);
            this.cboInicial.Name = "cboInicial";
            this.cboInicial.Size = new System.Drawing.Size(98, 28);
            this.cboInicial.TabIndex = 11;
            // 
            // dtpReserva
            // 
            this.dtpReserva.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReserva.Location = new System.Drawing.Point(482, 432);
            this.dtpReserva.Margin = new System.Windows.Forms.Padding(4);
            this.dtpReserva.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpReserva.Name = "dtpReserva";
            this.dtpReserva.Size = new System.Drawing.Size(645, 27);
            this.dtpReserva.TabIndex = 3;
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(117)))));
            this.btnReservar.FlatAppearance.BorderSize = 0;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(1018, 584);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(114, 28);
            this.btnReservar.TabIndex = 6;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // cboProfessor
            // 
            this.cboProfessor.BackColor = System.Drawing.Color.White;
            this.cboProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProfessor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProfessor.ForeColor = System.Drawing.Color.Black;
            this.cboProfessor.FormattingEnabled = true;
            this.cboProfessor.Location = new System.Drawing.Point(482, 356);
            this.cboProfessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboProfessor.Name = "cboProfessor";
            this.cboProfessor.Size = new System.Drawing.Size(645, 28);
            this.cboProfessor.TabIndex = 2;
            this.cboProfessor.Text = "Selecione um professor para a reserva";
            // 
            // cboLaboratorio
            // 
            this.cboLaboratorio.BackColor = System.Drawing.Color.White;
            this.cboLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLaboratorio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLaboratorio.ForeColor = System.Drawing.Color.Black;
            this.cboLaboratorio.FormattingEnabled = true;
            this.cboLaboratorio.Location = new System.Drawing.Point(482, 279);
            this.cboLaboratorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLaboratorio.MaxDropDownItems = 1;
            this.cboLaboratorio.Name = "cboLaboratorio";
            this.cboLaboratorio.Size = new System.Drawing.Size(645, 28);
            this.cboLaboratorio.TabIndex = 1;
            this.cboLaboratorio.Text = "Selecione um laboratório para a reserva";
            // 
            // lnkCadastro
            // 
            this.lnkCadastro.AutoSize = true;
            this.lnkCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lnkCadastro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCadastro.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkCadastro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.lnkCadastro.Location = new System.Drawing.Point(1138, 17);
            this.lnkCadastro.Name = "lnkCadastro";
            this.lnkCadastro.Size = new System.Drawing.Size(149, 28);
            this.lnkCadastro.TabIndex = 20;
            this.lnkCadastro.TabStop = true;
            this.lnkCadastro.Text = "CADASTRO";
            this.lnkCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCadastro_LinkClicked);
            // 
            // lnkReserva
            // 
            this.lnkReserva.AutoSize = true;
            this.lnkReserva.BackColor = System.Drawing.Color.Transparent;
            this.lnkReserva.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReserva.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkReserva.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.lnkReserva.Location = new System.Drawing.Point(890, 17);
            this.lnkReserva.Name = "lnkReserva";
            this.lnkReserva.Size = new System.Drawing.Size(128, 28);
            this.lnkReserva.TabIndex = 19;
            this.lnkReserva.TabStop = true;
            this.lnkReserva.Text = "RESERVA";
            // 
            // lnkConsultaGeral
            // 
            this.lnkConsultaGeral.AutoSize = true;
            this.lnkConsultaGeral.BackColor = System.Drawing.Color.Transparent;
            this.lnkConsultaGeral.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkConsultaGeral.ForeColor = System.Drawing.Color.Black;
            this.lnkConsultaGeral.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkConsultaGeral.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.lnkConsultaGeral.Location = new System.Drawing.Point(534, 17);
            this.lnkConsultaGeral.Name = "lnkConsultaGeral";
            this.lnkConsultaGeral.Size = new System.Drawing.Size(236, 28);
            this.lnkConsultaGeral.TabIndex = 18;
            this.lnkConsultaGeral.TabStop = true;
            this.lnkConsultaGeral.Text = "CONSULTA GERAL";
            this.lnkConsultaGeral.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConsultaGeral_LinkClicked);
            // 
            // linkConsultaDia
            // 
            this.linkConsultaDia.AutoSize = true;
            this.linkConsultaDia.BackColor = System.Drawing.Color.Transparent;
            this.linkConsultaDia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkConsultaDia.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkConsultaDia.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.linkConsultaDia.Location = new System.Drawing.Point(176, 17);
            this.linkConsultaDia.Name = "linkConsultaDia";
            this.linkConsultaDia.Size = new System.Drawing.Size(239, 28);
            this.linkConsultaDia.TabIndex = 17;
            this.linkConsultaDia.TabStop = true;
            this.linkConsultaDia.Text = "CONSULTA DO DIA";
            this.linkConsultaDia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkConsultaDia_LinkClicked);
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1463, 822);
            this.Controls.Add(this.lnkCadastro);
            this.Controls.Add(this.cboFinal);
            this.Controls.Add(this.lnkReserva);
            this.Controls.Add(this.dtpReservaRepetir);
            this.Controls.Add(this.cboInicial);
            this.Controls.Add(this.lnkConsultaGeral);
            this.Controls.Add(this.linkConsultaDia);
            this.Controls.Add(this.ckbRepetir);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.cboLaboratorio);
            this.Controls.Add(this.dtpReserva);
            this.Controls.Add(this.cboProfessor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReserva_FormClosing);
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.ComboBox cboProfessor;
        private System.Windows.Forms.ComboBox cboLaboratorio;
        private System.Windows.Forms.DateTimePicker dtpReserva;
        private System.Windows.Forms.LinkLabel lnkCadastro;
        private System.Windows.Forms.LinkLabel lnkReserva;
        private System.Windows.Forms.LinkLabel lnkConsultaGeral;
        private System.Windows.Forms.LinkLabel linkConsultaDia;
        private System.Windows.Forms.ComboBox cboFinal;
        private System.Windows.Forms.ComboBox cboInicial;
        private System.Windows.Forms.CheckBox ckbRepetir;
        private System.Windows.Forms.DateTimePicker dtpReservaRepetir;
    }
}