using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace thecomicbookwizard
{
    public partial class imageview : Form
    {
        public imageview()
        {
            InitializeComponent();
             
        }
        
        public string[] image_windows_1_list;

        private void imageview_Load(object sender, EventArgs e)
        {
            pictureBox_image_viewer.ClientSize = new Size(pictureBox_image_viewer.Size.Width, pictureBox_image_viewer.Size.Height);
        }

        private void imageview_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void pictureBox_image_viewer_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
        }

        private void pictureBox_image_viewer_BackgroundImageChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_next_image_Click(object sender, EventArgs e)
        {

        }
    }
}
