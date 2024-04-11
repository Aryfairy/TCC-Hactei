
namespace projetoetec
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.picLogoA = new System.Windows.Forms.PictureBox();
            this.prgSplash = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoA)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogoA
            // 
            this.picLogoA.Image = ((System.Drawing.Image)(resources.GetObject("picLogoA.Image")));
            this.picLogoA.Location = new System.Drawing.Point(409, 106);
            this.picLogoA.Name = "picLogoA";
            this.picLogoA.Size = new System.Drawing.Size(310, 301);
            this.picLogoA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoA.TabIndex = 0;
            this.picLogoA.TabStop = false;
            // 
            // prgSplash
            // 
            this.prgSplash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.prgSplash.Location = new System.Drawing.Point(409, 431);
            this.prgSplash.Name = "prgSplash";
            this.prgSplash.Size = new System.Drawing.Size(310, 23);
            this.prgSplash.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgSplash.TabIndex = 1;
            this.prgSplash.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(548, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "0%";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1097, 668);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prgSplash);
            this.Controls.Add(this.picLogoA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogoA;
        private System.Windows.Forms.ProgressBar prgSplash;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}