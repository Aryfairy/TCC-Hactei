
namespace projetoetec
{
    partial class frmNovaSenha
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovaSenha));
            this.pnlNovaSennha = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.picMudarTema = new System.Windows.Forms.PictureBox();
            this.pnlNovaSennha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNovaSennha
            // 
            this.pnlNovaSennha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.pnlNovaSennha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNovaSennha.Controls.Add(this.btnConfirmar);
            this.pnlNovaSennha.Controls.Add(this.picLogo);
            this.pnlNovaSennha.Controls.Add(this.lblConfirmar);
            this.pnlNovaSennha.Controls.Add(this.lblNovaSenha);
            this.pnlNovaSennha.Controls.Add(this.txtConfirmar);
            this.pnlNovaSennha.Controls.Add(this.txtNovaSenha);
            this.pnlNovaSennha.Location = new System.Drawing.Point(226, 69);
            this.pnlNovaSennha.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNovaSennha.Name = "pnlNovaSennha";
            this.pnlNovaSennha.Size = new System.Drawing.Size(288, 303);
            this.pnlNovaSennha.TabIndex = 0;
            this.pnlNovaSennha.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(78, 261);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(128, 29);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(71, 18);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(142, 107);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblConfirmar.Location = new System.Drawing.Point(62, 192);
            this.lblConfirmar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(162, 19);
            this.lblConfirmar.TabIndex = 1;
            this.lblConfirmar.Text = "Confirme a senha:";
            this.lblConfirmar.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblNovaSenha.Location = new System.Drawing.Point(89, 141);
            this.lblNovaSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(108, 19);
            this.lblNovaSenha.TabIndex = 1;
            this.lblNovaSenha.Text = "Nova senha:";
            this.lblNovaSenha.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.txtConfirmar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmar.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtConfirmar.Location = new System.Drawing.Point(58, 213);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmar.MaxLength = 25;
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = 'l';
            this.txtConfirmar.Size = new System.Drawing.Size(171, 20);
            this.txtConfirmar.TabIndex = 2;
            this.txtConfirmar.Tag = "";
            this.txtConfirmar.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.txtNovaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNovaSenha.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.Location = new System.Drawing.Point(58, 162);
            this.txtNovaSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtNovaSenha.MaxLength = 25;
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(171, 20);
            this.txtNovaSenha.TabIndex = 1;
            this.txtNovaSenha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // picMudarTema
            // 
            this.picMudarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.picMudarTema.Image = ((System.Drawing.Image)(resources.GetObject("picMudarTema.Image")));
            this.picMudarTema.Location = new System.Drawing.Point(0, -2);
            this.picMudarTema.Name = "picMudarTema";
            this.picMudarTema.Size = new System.Drawing.Size(32, 32);
            this.picMudarTema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMudarTema.TabIndex = 3;
            this.picMudarTema.TabStop = false;
            // 
            // frmNovaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1097, 668);
            this.Controls.Add(this.picMudarTema);
            this.Controls.Add(this.pnlNovaSennha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "frmNovaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Senha";
            this.pnlNovaSennha.ResumeLayout(false);
            this.pnlNovaSennha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNovaSennha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.PictureBox picMudarTema;
    }
}

