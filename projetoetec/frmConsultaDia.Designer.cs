
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
            this.pnlOpc = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkCadastro = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkConsultaDia = new System.Windows.Forms.LinkLabel();
            this.lnkConsultaGeral = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkReserva = new System.Windows.Forms.LinkLabel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlConsultaDia = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvReservasDia = new System.Windows.Forms.DataGridView();
            this.HORÁRIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROFESSOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cboLaboratorio = new System.Windows.Forms.ComboBox();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.picMudarTema = new System.Windows.Forms.PictureBox();
            this.pnlOpc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlConsultaDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).BeginInit();
            this.SuspendLayout();
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
            this.pnlOpc.Location = new System.Drawing.Point(-3, -2);
            this.pnlOpc.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOpc.Name = "pnlOpc";
            this.pnlOpc.Size = new System.Drawing.Size(1102, 51);
            this.pnlOpc.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.label3.Location = new System.Drawing.Point(890, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "|";
            // 
            // lnkCadastro
            // 
            this.lnkCadastro.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkCadastro.AutoSize = true;
            this.lnkCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCadastro.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkCadastro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(23)))));
            this.lnkCadastro.Location = new System.Drawing.Point(940, 13);
            this.lnkCadastro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkCadastro.Name = "lnkCadastro";
            this.lnkCadastro.Size = new System.Drawing.Size(128, 25);
            this.lnkCadastro.TabIndex = 31;
            this.lnkCadastro.TabStop = true;
            this.lnkCadastro.Text = "CADASTRO";
            this.lnkCadastro.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastro_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(660, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 26);
            this.label2.TabIndex = 26;
            this.label2.Text = "|";
            // 
            // lnkConsultaDia
            // 
            this.lnkConsultaDia.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkConsultaDia.AutoSize = true;
            this.lnkConsultaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkConsultaDia.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkConsultaDia.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(23)))));
            this.lnkConsultaDia.Location = new System.Drawing.Point(105, 13);
            this.lnkConsultaDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkConsultaDia.Name = "lnkConsultaDia";
            this.lnkConsultaDia.Size = new System.Drawing.Size(203, 25);
            this.lnkConsultaDia.TabIndex = 28;
            this.lnkConsultaDia.TabStop = true;
            this.lnkConsultaDia.Text = "CONSULTA DO DIA";
            this.lnkConsultaDia.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            // 
            // lnkConsultaGeral
            // 
            this.lnkConsultaGeral.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkConsultaGeral.AutoSize = true;
            this.lnkConsultaGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkConsultaGeral.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkConsultaGeral.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(23)))));
            this.lnkConsultaGeral.Location = new System.Drawing.Point(406, 13);
            this.lnkConsultaGeral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkConsultaGeral.Name = "lnkConsultaGeral";
            this.lnkConsultaGeral.Size = new System.Drawing.Size(203, 25);
            this.lnkConsultaGeral.TabIndex = 29;
            this.lnkConsultaGeral.TabStop = true;
            this.lnkConsultaGeral.Text = "CONSULTA GERAL";
            this.lnkConsultaGeral.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkConsultaGeral.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConsultaGeral_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(353, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "|";
            // 
            // lnkReserva
            // 
            this.lnkReserva.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkReserva.AutoSize = true;
            this.lnkReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReserva.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkReserva.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(23)))));
            this.lnkReserva.Location = new System.Drawing.Point(723, 13);
            this.lnkReserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkReserva.Name = "lnkReserva";
            this.lnkReserva.Size = new System.Drawing.Size(112, 25);
            this.lnkReserva.TabIndex = 30;
            this.lnkReserva.TabStop = true;
            this.lnkReserva.Text = "RESERVA";
            this.lnkReserva.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.lnkReserva.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReserva_LinkClicked);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(3, 8);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(82, 37);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlConsultaDia
            // 
            this.pnlConsultaDia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConsultaDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.pnlConsultaDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlConsultaDia.Controls.Add(this.btnConsultar);
            this.pnlConsultaDia.Controls.Add(this.dgvReservasDia);
            this.pnlConsultaDia.Controls.Add(this.dtpData);
            this.pnlConsultaDia.Controls.Add(this.cboLaboratorio);
            this.pnlConsultaDia.Controls.Add(this.lblLaboratorio);
            this.pnlConsultaDia.Controls.Add(this.lblData);
            this.pnlConsultaDia.Location = new System.Drawing.Point(69, 85);
            this.pnlConsultaDia.Margin = new System.Windows.Forms.Padding(2);
            this.pnlConsultaDia.Name = "pnlConsultaDia";
            this.pnlConsultaDia.Size = new System.Drawing.Size(1005, 572);
            this.pnlConsultaDia.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.btnConsultar.Location = new System.Drawing.Point(845, 92);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(101, 27);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
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
            this.dgvReservasDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservasDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORÁRIO,
            this.SALA,
            this.PROFESSOR,
            this.STATUS});
            this.dgvReservasDia.Location = new System.Drawing.Point(64, 134);
            this.dgvReservasDia.Name = "dgvReservasDia";
            this.dgvReservasDia.ReadOnly = true;
            this.dgvReservasDia.RowHeadersWidth = 51;
            this.dgvReservasDia.Size = new System.Drawing.Size(882, 390);
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
            // dtpData
            // 
            this.dtpData.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.dtpData.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(219, 30);
            this.dtpData.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(113, 25);
            this.dtpData.TabIndex = 1;
            this.dtpData.UseWaitCursor = true;
            // 
            // cboLaboratorio
            // 
            this.cboLaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.cboLaboratorio.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cboLaboratorio.Location = new System.Drawing.Point(219, 93);
            this.cboLaboratorio.Margin = new System.Windows.Forms.Padding(2);
            this.cboLaboratorio.Name = "cboLaboratorio";
            this.cboLaboratorio.Size = new System.Drawing.Size(518, 25);
            this.cboLaboratorio.TabIndex = 2;
            this.cboLaboratorio.Text = "Selecione um laboratório";
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblLaboratorio.Location = new System.Drawing.Point(61, 91);
            this.lblLaboratorio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(127, 25);
            this.lblLaboratorio.TabIndex = 2;
            this.lblLaboratorio.Text = "Laboratório:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblData.Location = new System.Drawing.Point(134, 28);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(63, 25);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data:";
            // 
            // picMudarTema
            // 
            this.picMudarTema.Image = ((System.Drawing.Image)(resources.GetObject("picMudarTema.Image")));
            this.picMudarTema.Location = new System.Drawing.Point(0, 48);
            this.picMudarTema.Name = "picMudarTema";
            this.picMudarTema.Size = new System.Drawing.Size(32, 32);
            this.picMudarTema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMudarTema.TabIndex = 3;
            this.picMudarTema.TabStop = false;
            // 
            // frmConsultaDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1097, 668);
            this.Controls.Add(this.picMudarTema);
            this.Controls.Add(this.pnlConsultaDia);
            this.Controls.Add(this.pnlOpc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "frmConsultaDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta do Dia";
            this.Load += new System.EventHandler(this.frmConsultaDia_Load);
            this.pnlOpc.ResumeLayout(false);
            this.pnlOpc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlConsultaDia.ResumeLayout(false);
            this.pnlConsultaDia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpc;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlConsultaDia;
        private System.Windows.Forms.ComboBox cboLaboratorio;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.PictureBox picMudarTema;
        private System.Windows.Forms.DataGridView dgvReservasDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkConsultaDia;
        private System.Windows.Forms.LinkLabel lnkConsultaGeral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORÁRIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROFESSOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.Button btnConsultar;
    }
}