
namespace projetoetec
{
    partial class frmRecuperaEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperaEmail));
            this.picMudarTema = new System.Windows.Forms.PictureBox();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).BeginInit();
            this.pnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
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
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.pnlEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmail.Controls.Add(this.btnVoltar);
            this.pnlEmail.Controls.Add(this.btnEnviar);
            this.pnlEmail.Controls.Add(this.picLogo);
            this.pnlEmail.Controls.Add(this.lblEmail);
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Location = new System.Drawing.Point(127, 57);
            this.pnlEmail.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(483, 334);
            this.pnlEmail.TabIndex = 6;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(40, 270);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(92, 29);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.Location = new System.Drawing.Point(340, 270);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(92, 29);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(168, 29);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(142, 107);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblEmail.Location = new System.Drawing.Point(36, 177);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(396, 19);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Insira seu email para recuperação de senha:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.txtEmail.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(40, 208);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(392, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // frmRecuperaEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.picMudarTema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "frmRecuperaEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email";
            this.Load += new System.EventHandler(this.frmEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).EndInit();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picMudarTema;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
    }
}

