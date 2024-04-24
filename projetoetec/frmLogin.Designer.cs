
namespace projetoetec
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picMudarTema = new System.Windows.Forms.PictureBox();
            this.ckbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmailUsuario = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txbDesti = new System.Windows.Forms.TextBox();
            this.linkEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.lnkCadastrar = new System.Windows.Forms.LinkLabel();
            this.lblBemvindo = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.pnlLogin.Controls.Add(this.linkEsqueceuSenha);
            this.pnlLogin.Controls.Add(this.lnkCadastrar);
            this.pnlLogin.Controls.Add(this.ckbMostrarSenha);
            this.pnlLogin.Controls.Add(this.btnEntrar);
            this.pnlLogin.Controls.Add(this.lblSenha);
            this.pnlLogin.Controls.Add(this.lblEmailUsuario);
            this.pnlLogin.Controls.Add(this.txtSenha);
            this.pnlLogin.Controls.Add(this.txbDesti);
            this.pnlLogin.Controls.Add(this.picLogo);
            this.pnlLogin.Location = new System.Drawing.Point(307, 125);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(461, 465);
            this.pnlLogin.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(147, 24);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(142, 107);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // picMudarTema
            // 
            this.picMudarTema.Image = ((System.Drawing.Image)(resources.GetObject("picMudarTema.Image")));
            this.picMudarTema.Location = new System.Drawing.Point(0, -2);
            this.picMudarTema.Name = "picMudarTema";
            this.picMudarTema.Size = new System.Drawing.Size(32, 32);
            this.picMudarTema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMudarTema.TabIndex = 3;
            this.picMudarTema.TabStop = false;
            // 
            // ckbMostrarSenha
            // 
            this.ckbMostrarSenha.AutoSize = true;
            this.ckbMostrarSenha.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMostrarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.ckbMostrarSenha.Location = new System.Drawing.Point(71, 301);
            this.ckbMostrarSenha.Name = "ckbMostrarSenha";
            this.ckbMostrarSenha.Size = new System.Drawing.Size(117, 19);
            this.ckbMostrarSenha.TabIndex = 13;
            this.ckbMostrarSenha.Text = "Mostrar senha";
            this.ckbMostrarSenha.UseVisualStyleBackColor = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.btnEntrar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(146, 345);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(158, 34);
            this.btnEntrar.TabIndex = 14;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblSenha.Location = new System.Drawing.Point(193, 238);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(70, 24);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha";
            // 
            // lblEmailUsuario
            // 
            this.lblEmailUsuario.AutoSize = true;
            this.lblEmailUsuario.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lblEmailUsuario.Location = new System.Drawing.Point(127, 156);
            this.lblEmailUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailUsuario.Name = "lblEmailUsuario";
            this.lblEmailUsuario.Size = new System.Drawing.Size(202, 24);
            this.lblEmailUsuario.TabIndex = 9;
            this.lblEmailUsuario.Text = "Email do Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.txtSenha.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(71, 264);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.MaxLength = 25;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = 'l';
            this.txtSenha.Size = new System.Drawing.Size(317, 32);
            this.txtSenha.TabIndex = 12;
            this.txtSenha.Tag = "";
            // 
            // txbDesti
            // 
            this.txbDesti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.txbDesti.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDesti.Location = new System.Drawing.Point(71, 181);
            this.txbDesti.Margin = new System.Windows.Forms.Padding(2);
            this.txbDesti.MaxLength = 25;
            this.txbDesti.Name = "txbDesti";
            this.txbDesti.Size = new System.Drawing.Size(317, 32);
            this.txbDesti.TabIndex = 10;
            // 
            // linkEsqueceuSenha
            // 
            this.linkEsqueceuSenha.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.linkEsqueceuSenha.AutoSize = true;
            this.linkEsqueceuSenha.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEsqueceuSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.linkEsqueceuSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.linkEsqueceuSenha.Location = new System.Drawing.Point(162, 400);
            this.linkEsqueceuSenha.Name = "linkEsqueceuSenha";
            this.linkEsqueceuSenha.Size = new System.Drawing.Size(126, 15);
            this.linkEsqueceuSenha.TabIndex = 15;
            this.linkEsqueceuSenha.TabStop = true;
            this.linkEsqueceuSenha.Text = "Esqueceu a senha?";
            // 
            // lnkCadastrar
            // 
            this.lnkCadastrar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lnkCadastrar.AutoSize = true;
            this.lnkCadastrar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.lnkCadastrar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.lnkCadastrar.Location = new System.Drawing.Point(187, 426);
            this.lnkCadastrar.Name = "lnkCadastrar";
            this.lnkCadastrar.Size = new System.Drawing.Size(70, 15);
            this.lnkCadastrar.TabIndex = 16;
            this.lnkCadastrar.TabStop = true;
            this.lnkCadastrar.Text = "Cadastrar";
            // 
            // lblBemvindo
            // 
            this.lblBemvindo.AutoSize = true;
            this.lblBemvindo.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemvindo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.lblBemvindo.Location = new System.Drawing.Point(203, 42);
            this.lblBemvindo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBemvindo.Name = "lblBemvindo";
            this.lblBemvindo.Size = new System.Drawing.Size(697, 68);
            this.lblBemvindo.TabIndex = 11;
            this.lblBemvindo.Text = "Seja bem vindo(a) \r\nao Reserva de Laboratórios da Etec Jd. Ângela !";
            this.lblBemvindo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1097, 668);
            this.Controls.Add(this.lblBemvindo);
            this.Controls.Add(this.picMudarTema);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picMudarTema;
        private System.Windows.Forms.LinkLabel linkEsqueceuSenha;
        private System.Windows.Forms.LinkLabel lnkCadastrar;
        private System.Windows.Forms.CheckBox ckbMostrarSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmailUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txbDesti;
        private System.Windows.Forms.Label lblBemvindo;
    }
}

