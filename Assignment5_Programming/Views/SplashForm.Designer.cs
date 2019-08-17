namespace Assignment5_Programming.Views
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.SplashPictureBox = new System.Windows.Forms.PictureBox();
            this.DollarLabel = new System.Windows.Forms.Label();
            this.SplashScreenTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SplashPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashPictureBox
            // 
            this.SplashPictureBox.ErrorImage = null;
            this.SplashPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SplashPictureBox.Image")));
            this.SplashPictureBox.InitialImage = null;
            this.SplashPictureBox.Location = new System.Drawing.Point(70, 115);
            this.SplashPictureBox.Name = "SplashPictureBox";
            this.SplashPictureBox.Size = new System.Drawing.Size(685, 379);
            this.SplashPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SplashPictureBox.TabIndex = 0;
            this.SplashPictureBox.TabStop = false;
            // 
            // DollarLabel
            // 
            this.DollarLabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DollarLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.DollarLabel.Location = new System.Drawing.Point(84, 36);
            this.DollarLabel.Name = "DollarLabel";
            this.DollarLabel.Size = new System.Drawing.Size(618, 65);
            this.DollarLabel.TabIndex = 1;
            this.DollarLabel.Text = "WECOME! TO Dollar Computers";
            // 
            // SplashScreenTimer
            // 
            this.SplashScreenTimer.Interval = 3000;
            this.SplashScreenTimer.Tick += new System.EventHandler(this.SplashScreenTimer_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.DollarLabel);
            this.Controls.Add(this.SplashPictureBox);
            this.Name = "SplashForm";
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SplashPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SplashPictureBox;
        private System.Windows.Forms.Label DollarLabel;
        private System.Windows.Forms.Timer SplashScreenTimer;
    }
}