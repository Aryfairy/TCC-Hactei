
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
            this.prgSplash = new System.Windows.Forms.ProgressBar();
            this.timerBar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // prgSplash
            // 
            this.prgSplash.BackColor = System.Drawing.Color.White;
            this.prgSplash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.prgSplash.Location = new System.Drawing.Point(630, 406);
            this.prgSplash.Margin = new System.Windows.Forms.Padding(4);
            this.prgSplash.Name = "prgSplash";
            this.prgSplash.Size = new System.Drawing.Size(240, 31);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1463, 822);
            this.Controls.Add(this.prgSplash);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar prgSplash;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerBar;
    }
}