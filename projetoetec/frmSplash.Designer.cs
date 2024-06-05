
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
            this.timerBar = new System.Windows.Forms.Timer(this.components);
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
            this.prgSplash.Location = new System.Drawing.Point(409, 433);
            this.prgSplash.Name = "prgSplash";
            this.prgSplash.Size = new System.Drawing.Size(310, 23);
            this.prgSplash.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgSplash.TabIndex = 1;
            // 
            // timerBar
            // 
            this.timerBar.Enabled = true;
            this.timerBar.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1097, 668);
            this.Controls.Add(this.prgSplash);
            this.Controls.Add(this.picLogoA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            ((System.ComponentModel.ISupportInitialize)(this.picLogoA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogoA;
        private System.Windows.Forms.ProgressBar prgSplash;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerBar;
    }
}