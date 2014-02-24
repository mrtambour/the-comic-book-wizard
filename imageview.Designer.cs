namespace thecomicbookwizard
{
    partial class imageview
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
            this.pictureBox_image_viewer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image_viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_image_viewer
            // 
            this.pictureBox_image_viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox_image_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_image_viewer.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_image_viewer.Name = "pictureBox_image_viewer";
            this.pictureBox_image_viewer.Size = new System.Drawing.Size(721, 642);
            this.pictureBox_image_viewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_image_viewer.TabIndex = 0;
            this.pictureBox_image_viewer.TabStop = false;
            this.pictureBox_image_viewer.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox_image_viewer_LoadCompleted);
            // 
            // imageview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 642);
            this.Controls.Add(this.pictureBox_image_viewer);
            this.Name = "imageview";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "imageview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.imageview_FormClosing);
            this.Load += new System.EventHandler(this.imageview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image_viewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox_image_viewer;

    }
}