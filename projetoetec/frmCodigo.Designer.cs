
namespace projetoetec
{
    partial class frmCodigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodigo));
            this.picMudarTema = new System.Windows.Forms.PictureBox();
            this.pnlCodigo = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).BeginInit();
            this.pnlCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picMudarTema
            // 
            this.picMudarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.picMudarTema.Image = ((System.Drawing.Image)(resources.GetObject("picMudarTema.Image")));
            this.picMudarTema.Location = new System.Drawing.Point(0, 0);
            this.picMudarTema.Name = "picMudarTema";
            this.picMudarTema.Size = new System.Drawing.Size(32, 32);
            this.picMudarTema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMudarTema.TabIndex = 13;
            this.picMudarTema.TabStop = false;
            // 
            // pnlCodigo
            // 
            this.pnlCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.pnlCodigo.Controls.Add(this.btnEnviar);
            this.pnlCodigo.Controls.Add(this.picLogo);
            this.pnlCodigo.Controls.Add(this.lblCodigo);
            this.pnlCodigo.Controls.Add(this.txtCodigo);
            this.pnlCodigo.Location = new System.Drawing.Point(189, 104);
            this.pnlCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCodigo.Name = "pnlCodigo";
            this.pnlCodigo.Size = new System.Drawing.Size(437, 266);
            this.pnlCodigo.TabIndex = 14;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.Location = new System.Drawing.Point(173, 212);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(91, 34);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(147, 19);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(142, 107);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblCodigo.Location = new System.Drawing.Point(7, 142);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(423, 19);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Insira o código que enviamos para o seu email:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(94, 175);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(245, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // frmCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(826, 518);
            this.Controls.Add(this.pnlCodigo);
            this.Controls.Add(this.picMudarTema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmCodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Código";
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).EndInit();
            this.pnlCodigo.ResumeLayout(false);
            this.pnlCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picMudarTema;
        private System.Windows.Forms.Panel pnlCodigo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}