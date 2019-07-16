namespace ball
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ballPic = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ballPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.ballPic.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.ballPic.Location = new System.Drawing.Point(393, 116);
            this.ballPic.Name = "pictureBox1";
            this.ballPic.Size = new System.Drawing.Size(201, 201);
            this.ballPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ballPic.TabIndex = 0;
            this.ballPic.TabStop = false;
            this.ballPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(984, 514);
            this.Controls.Add(this.ballPic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ballPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ballPic;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

