using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;







namespace thecomicbookwizard
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        String Folder_File_Location = "";
        String Folder_Save_Location = "";
        
        
        private void btn_folderselect_Click(object sender, EventArgs e)
        {
            ulong total_size = 0;            

            fldr_browser_selectfolder.ShowDialog();
            Folder_File_Location = fldr_browser_selectfolder.SelectedPath.ToString();
            
            if (Folder_File_Location == "")
            {
                return;
            }

            lnk_folderloc.Text = Folder_File_Location;          
            listBox1.Items.Clear();
            int search = 0;
            DirectoryInfo di = new DirectoryInfo(Folder_File_Location);
            string[] files = Directory.GetFiles(@Folder_File_Location);
            FileInfo[] all_files = di.GetFiles();

            foreach (string dir in files)
            {
                listBox1.Items.Add(files[search]);
                search++;
            }

            foreach(FileInfo f in all_files)
                total_size /= (total_size += (ulong)f.Length);

            files_size_total.Text = (total_size.ToString() + " KB");
            
        }

        private void btn_saveto_Click(object sender, EventArgs e)
        {
            fldr_save_to.ShowDialog();
            Folder_Save_Location = fldr_save_to.SelectedPath.ToString();
            fldr_browser_saveto.Text = Folder_Save_Location;
        }

        private void lnk_folderloc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("explorer.exe", @Folder_File_Location);
        }

        private void fldr_browser_saveto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @Folder_Save_Location);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String selected_file = "";

            try
            {
                selected_file = listBox1.SelectedItem.ToString();
                System.Diagnostics.Process.Start("explorer.exe", @selected_file);
            }
            

            catch
            {
                return;
            }
        }

        private void btn_compress_start_Click(object sender, EventArgs e)
        { 
           
            string[] file_extension = { "", ".zip", ".cbz" };
            string current_directory = Environment.CurrentDirectory.ToString();

            prgrs_bar.Value = 10;
            FastZip fastzip = new FastZip();
            bool recurse_files = true;
            string filter = null;
            prgrs_bar.Value = 25;

            //failsafe default
            if (!chk_box_cbz.Checked & !chk_box_zip.Checked)
            {
                chk_box_zip.Checked = true;

                if (File.Exists(Folder_Save_Location + "\\" + textBox1.Text.ToString() + file_extension[1]))
                    File.Delete(Folder_Save_Location + "\\" + textBox1.Text.ToString() + file_extension[1]);

                if (File.Exists(current_directory + "\\" + textBox1.Text.ToString() + file_extension[1]))
                    File.Delete(current_directory + "\\" + textBox1.Text.ToString() + file_extension[1]);

                prgrs_bar.Value = 50;
                fastzip.CreateZip(textBox1.Text.ToString() + file_extension[1], @Folder_File_Location, recurse_files, filter);
                

                File.Move((current_directory + "\\" + textBox1.Text.ToString() + file_extension[1]), (Folder_Save_Location + "\\" + textBox1.Text.ToString() + file_extension[1]));
                prgrs_bar.Value = 100;
            }

            if (!chk_box_cbz.Checked & chk_box_zip.Checked)
            {
                

                if (File.Exists(Folder_Save_Location + "\\" + textBox1.Text.ToString() + file_extension[1]))
                    File.Delete(Folder_Save_Location + "\\" + textBox1.Text.ToString() + file_extension[1]);

                if (File.Exists(current_directory + "\\" + textBox1.Text.ToString() + file_extension[1]))
                    File.Delete(current_directory + "\\" + textBox1.Text.ToString() + file_extension[1]);

                prgrs_bar.Value = 50;
                fastzip.CreateZip(textBox1.Text.ToString() + file_extension[1], @Folder_File_Location, recurse_files, filter);
                

                File.Move((current_directory + "\\" + textBox1.Text.ToString() + file_extension[1]), (Folder_Save_Location + "\\" + textBox1.Text.ToString() + file_extension[1]));
                prgrs_bar.Value = 100;
            }

            if (chk_box_cbz.Checked & !chk_box_zip.Checked)
            {


                if (File.Exists(Folder_Save_Location + "\\" + textBox1.Text.ToString() + file_extension[2]))
                    File.Delete(Folder_Save_Location + "\\" + textBox1.Text.ToString() + file_extension[2]);

                if (File.Exists(current_directory + "\\" + textBox1.Text.ToString() + file_extension[2]))
                    File.Delete(current_directory + "\\" + textBox1.Text.ToString() + file_extension[2]);
                
                prgrs_bar.Value = 50;
                fastzip.CreateZip(textBox1.Text.ToString() + file_extension[2], @Folder_File_Location, recurse_files, filter);
                

                File.Move((current_directory + "\\" + textBox1.Text.ToString() + file_extension[2]), (Folder_Save_Location + "\\" + textBox1.Text.ToString() + file_extension[2]));
                prgrs_bar.Value = 100;
            }

            if (chk_box_cbz.Checked & chk_box_zip.Checked)
            {


                if (File.Exists(Folder_Save_Location + "\\" + textBox1.Text.ToString() + file_extension[1]))
                    File.Delete(Folder_Save_Location + "\\" + textBox1.Text.ToString() + file_extension[1]);

                if (File.Exists(current_directory + "\\" + textBox1.Text.ToString() + file_extension[1]))
                    File.Delete(current_directory + "\\" + textBox1.Text.ToString() + file_extension[1]);

                if (File.Exists(current_directory + "\\" + textBox1.Text.ToString() + file_extension[2]))
                    File.Delete(current_directory + "\\" + textBox1.Text.ToString() + file_extension[2]);

                if (File.Exists(Folder_Save_Location + "\\" + textBox1.Text.ToString() + file_extension[2]))
                    File.Delete(Folder_Save_Location + "\\" + textBox1.Text.ToString() + file_extension[2]);

                prgrs_bar.Value = 50;
                fastzip.CreateZip(textBox1.Text.ToString() + file_extension[1], @Folder_File_Location, recurse_files, filter);
                fastzip.CreateZip(textBox1.Text.ToString() + file_extension[2], @Folder_File_Location, recurse_files, filter);
                
                prgrs_bar.Value = 75;
                File.Move((current_directory + "\\" + textBox1.Text.ToString() + file_extension[1]), (Folder_Save_Location + "\\" + textBox1.Text.ToString() + file_extension[1]));
                File.Move((current_directory + "\\" + textBox1.Text.ToString() + file_extension[2]), (Folder_Save_Location + "\\" + textBox1.Text.ToString() + file_extension[2]));
                prgrs_bar.Value = 100;
            }

        }

        private void btn_list_delete_Click(object sender, EventArgs e)
        {
            string selected_file_list = "";

            try
            {
                selected_file_list = listBox1.SelectedItem.ToString();
            }

            catch
            {
                return;
            }

            pictureBox1.Dispose();
            pictureBox1.Image.Dispose();
            MyImage.Dispose();
            File.Delete(selected_file_list);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
                      
            
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < s.Length; i++)
                listBox1.Items.Add(s[i]);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
          if (textBox1.Text == "")
            textBox1.Text = "Type a File Name";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|]"))
            {
                e.Handled = true;
            }
        }

        private void btn_clr_list_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pictureBox1.Dispose();
        }

        
        public Bitmap MyImage;
        public void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //If the file cant be assigned to test it creates and error that is caught and prevented (shortcut to checking wether each item clicked is an image)
                try
                {
                    Image test = Image.FromFile(listBox1.SelectedItem.ToString());
                    test.Dispose();
                }


                catch
                {
                    return;
                }

                Image newImage = Image.FromFile(listBox1.SelectedItem.ToString());

                
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                MyImage = new Bitmap(newImage);
                pictureBox1.ClientSize = new Size(pictureBox1.Size.Width, pictureBox1.Size.Height);
                pictureBox1.Image = (newImage);


        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", @listBox1.SelectedItem.ToString());
            }
            
            catch
            {
                MessageBox.Show("No Image Available");
                return;
            }
            
        }
                
    }
}
