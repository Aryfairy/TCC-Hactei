
namespace projetoetec
{
    partial class frmConsultaDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaDia));
            this.lnkCadastro = new System.Windows.Forms.LinkLabel();
            this.lnkConsultaDia = new System.Windows.Forms.LinkLabel();
            this.lnkConsultaGeral = new System.Windows.Forms.LinkLabel();
            this.lnkReserva = new System.Windows.Forms.LinkLabel();
            this.cboLaboratorio = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dgvReservasDia = new System.Windows.Forms.DataGridView();
            this.HORÁRIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROFESSOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasDia)).BeginInit();
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
            this.lnkCadastro.Location = new System.Drawing.Point(1133, 17);
            this.lnkCadastro.Name = "lnkCadastro";
            this.lnkCadastro.Size = new System.Drawing.Size(149, 28);
            this.lnkCadastro.TabIndex = 31;
            this.lnkCadastro.TabStop = true;
            this.lnkCadastro.Text = "CADASTRO";
            this.lnkCadastro.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastro_LinkClicked);
            // 
            // lnkConsultaDia
            // 
            this.lnkConsultaDia.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkConsultaDia.AutoSize = true;
            this.lnkConsultaDia.BackColor = System.Drawing.Color.Transparent;
            this.lnkConsultaDia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkConsultaDia.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkConsultaDia.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.lnkConsultaDia.Location = new System.Drawing.Point(184, 17);
            this.lnkConsultaDia.Name = "lnkConsultaDia";
            this.lnkConsultaDia.Size = new System.Drawing.Size(239, 28);
            this.lnkConsultaDia.TabIndex = 28;
            this.lnkConsultaDia.TabStop = true;
            this.lnkConsultaDia.Text = "CONSULTA DO DIA";
            this.lnkConsultaDia.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
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
            this.lnkReserva.Location = new System.Drawing.Point(893, 17);
            this.lnkReserva.Name = "lnkReserva";
            this.lnkReserva.Size = new System.Drawing.Size(128, 28);
            this.lnkReserva.TabIndex = 30;
            this.lnkReserva.TabStop = true;
            this.lnkReserva.Text = "RESERVA";
            this.lnkReserva.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkReserva.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReserva_LinkClicked);
            // 
            // cboLaboratorio
            // 
            this.cboLaboratorio.BackColor = System.Drawing.Color.White;
            this.cboLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLaboratorio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLaboratorio.ForeColor = System.Drawing.Color.Black;
            this.cboLaboratorio.FormattingEnabled = true;
            this.cboLaboratorio.Items.AddRange(new object[] {
            "Laboratório 1   00:00  Disponível",
            "Laboratório 2   00:00  Reservado",
            "Laboratório 3   00:00  Reservado",
            "Laboratório 1   00:00  Disponível",
            "Laboratório 2   00:00  Reservado",
            "Laboratório 3   00:00  Reservado",
            "Laboratório 1   00:00  Disponível",
            "Laboratório 2   00:00  Reservado",
            "Laboratório 3   00:00  Reservado"});
            this.cboLaboratorio.Location = new System.Drawing.Point(454, 267);
            this.cboLaboratorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLaboratorio.Name = "cboLaboratorio";
            this.cboLaboratorio.Size = new System.Drawing.Size(553, 25);
            this.cboLaboratorio.TabIndex = 2;
            this.cboLaboratorio.Text = "Selecione um laboratório";
            // 
            // dtpData
            // 
            this.dtpData.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpData.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(251, 267);
            this.dtpData.Margin = new System.Windows.Forms.Padding(4);
            this.dtpData.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(123, 25);
            this.dtpData.TabIndex = 1;
            this.dtpData.UseWaitCursor = true;
            // 
            // dgvReservasDia
            // 
            this.dgvReservasDia.AllowUserToAddRows = false;
            this.dgvReservasDia.AllowUserToDeleteRows = false;
            this.dgvReservasDia.AllowUserToResizeColumns = false;
            this.dgvReservasDia.AllowUserToResizeRows = false;
            this.dgvReservasDia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservasDia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservasDia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(106)))), ((int)(((byte)(119)))));
            this.dgvReservasDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservasDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservasDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORÁRIO,
            this.SALA,
            this.PROFESSOR,
            this.STATUS});
            this.dgvReservasDia.Location = new System.Drawing.Point(239, 319);
            this.dgvReservasDia.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReservasDia.Name = "dgvReservasDia";
            this.dgvReservasDia.ReadOnly = true;
            this.dgvReservasDia.RowHeadersWidth = 51;
            this.dgvReservasDia.Size = new System.Drawing.Size(986, 325);
            this.dgvReservasDia.TabIndex = 3;
            this.dgvReservasDia.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservasDia_CellDoubleClick);
            this.dgvReservasDia.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReservasDia_CellFormatting);
            // 
            // HORÁRIO
            // 
            this.HORÁRIO.HeaderText = "HORÁRIO";
            this.HORÁRIO.MinimumWidth = 6;
            this.HORÁRIO.Name = "HORÁRIO";
            this.HORÁRIO.ReadOnly = true;
            // 
            // SALA
            // 
            this.SALA.HeaderText = "SALA";
            this.SALA.MinimumWidth = 6;
            this.SALA.Name = "SALA";
            this.SALA.ReadOnly = true;
            // 
            // PROFESSOR
            // 
            this.PROFESSOR.HeaderText = "PROFESSOR";
            this.PROFESSOR.MinimumWidth = 6;
            this.PROFESSOR.Name = "PROFESSOR";
            this.PROFESSOR.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.MinimumWidth = 6;
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(117)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(1102, 265);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(102, 27);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsultaDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1463, 822);
            this.Controls.Add(this.dgvReservasDia);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lnkCadastro);
            this.Controls.Add(this.cboLaboratorio);
            this.Controls.Add(this.lnkReserva);
            this.Controls.Add(this.lnkConsultaGeral);
            this.Controls.Add(this.lnkConsultaDia);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "frmConsultaDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta do Dia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultaDia_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultaDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnkCadastro;
        private System.Windows.Forms.LinkLabel lnkConsultaDia;
        private System.Windows.Forms.LinkLabel lnkConsultaGeral;
        private System.Windows.Forms.LinkLabel lnkReserva;
        private System.Windows.Forms.ComboBox cboLaboratorio;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridView dgvReservasDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORÁRIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROFESSOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.Button btnConsultar;
    }
}