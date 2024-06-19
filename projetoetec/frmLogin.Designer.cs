
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
            this.linkEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.lnkCadastrar = new System.Windows.Forms.LinkLabel();
            this.ckbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.picMudarTema = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).BeginInit();
            this.SuspendLayout();
            // 
            // linkEsqueceuSenha
            // 
            this.linkEsqueceuSenha.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.linkEsqueceuSenha.AutoSize = true;
            this.linkEsqueceuSenha.BackColor = System.Drawing.Color.Transparent;
            this.linkEsqueceuSenha.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEsqueceuSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.linkEsqueceuSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(202)))), ((int)(((byte)(244)))));
            this.linkEsqueceuSenha.Location = new System.Drawing.Point(1055, 508);
            this.linkEsqueceuSenha.Name = "linkEsqueceuSenha";
            this.linkEsqueceuSenha.Size = new System.Drawing.Size(162, 20);
            this.linkEsqueceuSenha.TabIndex = 15;
            this.linkEsqueceuSenha.TabStop = true;
            this.linkEsqueceuSenha.Text = "Esqueceu a senha?";
            this.linkEsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEsqueceuSenha_LinkClicked);
            // 
            // lnkCadastrar
            // 
            this.lnkCadastrar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.lnkCadastrar.AutoSize = true;
            this.lnkCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lnkCadastrar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(104)))));
            this.lnkCadastrar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(202)))), ((int)(((byte)(244)))));
            this.lnkCadastrar.Location = new System.Drawing.Point(983, 631);
            this.lnkCadastrar.Name = "lnkCadastrar";
            this.lnkCadastrar.Size = new System.Drawing.Size(90, 20);
            this.lnkCadastrar.TabIndex = 16;
            this.lnkCadastrar.TabStop = true;
            this.lnkCadastrar.Text = "Cadastrar";
            this.lnkCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCadastrar_LinkClicked_1);
            // 
            // ckbMostrarSenha
            // 
            this.ckbMostrarSenha.AutoSize = true;
            this.ckbMostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.ckbMostrarSenha.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMostrarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.ckbMostrarSenha.Location = new System.Drawing.Point(844, 508);
            this.ckbMostrarSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbMostrarSenha.Name = "ckbMostrarSenha";
            this.ckbMostrarSenha.Size = new System.Drawing.Size(148, 24);
            this.ckbMostrarSenha.TabIndex = 13;
            this.ckbMostrarSenha.Text = "Mostrar senha";
            this.ckbMostrarSenha.UseVisualStyleBackColor = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(117)))));
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(988, 557);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(79, 27);
            this.btnEntrar.TabIndex = 14;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(848, 470);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(1);
            this.txtSenha.MaxLength = 80;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = 'l';
            this.txtSenha.Size = new System.Drawing.Size(358, 20);
            this.txtSenha.TabIndex = 12;
            this.txtSenha.Tag = "";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(848, 379);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(1);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(358, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // picMudarTema
            // 
            this.picMudarTema.BackColor = System.Drawing.Color.Transparent;
            this.picMudarTema.Image = ((System.Drawing.Image)(resources.GetObject("picMudarTema.Image")));
            this.picMudarTema.Location = new System.Drawing.Point(0, -2);
            this.picMudarTema.Margin = new System.Windows.Forms.Padding(4);
            this.picMudarTema.Name = "picMudarTema";
            this.picMudarTema.Size = new System.Drawing.Size(32, 32);
            this.picMudarTema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMudarTema.TabIndex = 3;
            this.picMudarTema.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1458, 822);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lnkCadastrar);
            this.Controls.Add(this.linkEsqueceuSenha);
            this.Controls.Add(this.picMudarTema);
            this.Controls.Add(this.ckbMostrarSenha);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picMudarTema;
        private System.Windows.Forms.LinkLabel linkEsqueceuSenha;
        private System.Windows.Forms.LinkLabel lnkCadastrar;
        private System.Windows.Forms.CheckBox ckbMostrarSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
    }
}

