namespace Shy_Panda
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
            this.imagepicture = new System.Windows.Forms.PictureBox();
            this.FaceImagepicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagepicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaceImagepicture)).BeginInit();
            this.SuspendLayout();
            // 
            // imagepicture
            // 
            this.imagepicture.Location = new System.Drawing.Point(23, 138);
            this.imagepicture.Name = "imagepicture";
            this.imagepicture.Size = new System.Drawing.Size(175, 198);
            this.imagepicture.TabIndex = 0;
            this.imagepicture.TabStop = false;
            // 
            // FaceImagepicture
            // 
            this.FaceImagepicture.Location = new System.Drawing.Point(290, 63);
            this.FaceImagepicture.Name = "FaceImagepicture";
            this.FaceImagepicture.Size = new System.Drawing.Size(487, 364);
            this.FaceImagepicture.TabIndex = 1;
            this.FaceImagepicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FaceImagepicture);
            this.Controls.Add(this.imagepicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imagepicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaceImagepicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagepicture;
        private System.Windows.Forms.PictureBox FaceImagepicture;
    }
}

