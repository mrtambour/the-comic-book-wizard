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
using NUnrar.Archive;
using NUnrar.Reader;






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
        string[] file_extension = { "", ".zip", ".cbz", ".rar", ".cbr" };
        bool disable_preview = false;
        imageview loaded_image_window2 = new imageview();
        
        

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

            loaded_image_window2.image_windows_1_list = Directory.GetFiles(@Folder_File_Location);
            

            FileInfo[] all_files = di.GetFiles();

            foreach (string dir in files)
            {
                if (files[search].ToString().EndsWith(".zip") | files[search].ToString().EndsWith(".rar"))
                {
                    ++search;
                    continue;
                }

                listBox1.Items.Add(files[search]);
                search++;
            }

            foreach(FileInfo f in all_files)
                total_size += (ulong)f.Length;

            total_size += (total_size / 1024);
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

            
            MyImage.Dispose();
            File.Delete(selected_file_list);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            loaded_image_window2.Show();
            loaded_image_window2.Location = new Point(this.Location.X + this.Width + 5, this.Location.Y);
            
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
            
        }

        
        public Bitmap MyImage;
        public Bitmap window2_image;
        public void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //If the file cant be assigned to test it creates and error that is caught and prevented (shortcut to checking wether each item clicked is an image, more specific error later on)
                try
                {
                    Image test = Image.FromFile(listBox1.SelectedItem.ToString());
                    test.Dispose();
                }


                catch
                {
                    return;
                }

                Image image_copy = Image.FromFile(listBox1.SelectedItem.ToString());
                window2_image = new Bitmap(image_copy);
                //loaded_image_window2.pictureBox_image_viewer.Image = (window2_image);
                loaded_image_window2.pictureBox_image_viewer.LoadAsync(listBox1.SelectedItem.ToString());
                
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            if (disable_preview == true)
                return; 
            
                

            if (checkbox_disable_docking.Checked == true)
                return;

            loaded_image_window2.Location = new Point(this.Location.X + this.Width + 5, this.Location.Y);
            loaded_image_window2.BringToFront();
        }

        private void btn_reset_window2_dimensions_Click(object sender, EventArgs e)
        {
            loaded_image_window2.Location = new Point(this.Location.X + this.Width + 5, this.Location.Y);

            if(loaded_image_window2.Size.Height != 685 | loaded_image_window2.Size.Width != 737 )
            {
                loaded_image_window2.Height = 685;
                loaded_image_window2.Width = 737;
 
            }
        }

        private void btn_about_Click(object sender, EventArgs e)
        {

        }

        private void link_about_website_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"https://sourceforge.net/projects/comicbookwizard/");
        }

        private void btn_select_archive_directory_Click(object sender, EventArgs e)
        {
            string archive_location_directory = "";
            folder_archive_directory_dialog.ShowDialog();
            archive_location_directory = folder_archive_directory_dialog.SelectedPath.ToString();

            string [] archive_files = Directory.GetFiles(@archive_location_directory);

            int search = 0;
            foreach(string dir in archive_files)
            {
                if (!(archive_files[search].EndsWith(".zip") | archive_files[search].EndsWith(".rar") | archive_files[search].EndsWith(".cbr")))
                {
                    search++;
                    continue;
                }
                
                listbox_archive_list.Items.Add(archive_files[search]);
                search++;
            }
            
        }

        private void btn_archive_process_Click(object sender, EventArgs e)
        {
            string archive_location_directory = folder_archive_directory_dialog.SelectedPath.ToString();
            string [] archive_files = Directory.GetFiles(@archive_location_directory);
            var file_names = Directory.GetFiles(@archive_location_directory).Select(f => Path.GetFileName(f));
            string[] prearchived_file_list = file_names.ToArray<string>();

            string original_file_extension = "";
             
            
            
            int search = 0;
            foreach (string dir in archive_files)
            {
                string archive_save_directory = "";
                string program_root_folder = "";
                string temporary_root_folder = "";
                bool recurse = true;
                original_file_extension = prearchived_file_list[search].ToString();
                original_file_extension = original_file_extension.Substring(original_file_extension.Length - 4);
                archive_save_directory = folder_archive_saveto_dialog.SelectedPath.ToString();

                if (chkbox_cnvrt_to_cbz.Checked != true)
                      chkbox_cnvrt_to_cbz.Checked = true;

                if (original_file_extension == ".rar" | original_file_extension == ".cbr")
                {
                    program_root_folder = Environment.CurrentDirectory.ToString();
                    Directory.CreateDirectory(program_root_folder + search.ToString());
                    temporary_root_folder = (program_root_folder + search.ToString());

                    RarArchive.WriteToDirectory(archive_files[search], temporary_root_folder);

                    FastZip archive = new FastZip();
                    string zip_name = archive_files[search].Substring(0, archive_files[search].Length - 4);

                    archive.CreateZip(prearchived_file_list[search].Substring(0, prearchived_file_list[search].Length - 4) + ".cbz", temporary_root_folder, recurse, null);

                        if (File.Exists(prearchived_file_list[search].Substring(0, prearchived_file_list[search].Length - 4) + ".cbz"))
                            File.Delete(prearchived_file_list[search].Substring(0, prearchived_file_list[search].Length - 4) + ".cbz");

                        File.Move(program_root_folder + "\\" + prearchived_file_list[search].Substring(0, prearchived_file_list[search].Length - 4) + ".cbz", archive_save_directory + "\\" + prearchived_file_list[search].Substring(0, prearchived_file_list[search].Length - 4) + ".cbz");
                    }

                    Directory.Delete(temporary_root_folder, true);
                

                if (original_file_extension == ".zip")
                {
                    File.Copy(archive_files[search], archive_save_directory+ "\\" + prearchived_file_list[search].Substring(0, prearchived_file_list[search].Length - 4) + ".cbz");
                }
                
                search++;
        
            }
            
        }

        private void btn_save_archive_to_Click(object sender, EventArgs e)
        {
            string archive_save_directory = "";
            folder_archive_saveto_dialog.ShowDialog();
            archive_save_directory = folder_archive_saveto_dialog.SelectedPath.ToString();
        }

        private void chk_box_disable_preview_Click(object sender, EventArgs e)
        {
            if (chk_box_disable_preview.Checked == true)
            {
            disable_preview = true;
            loaded_image_window2.show_preview = false;
            loaded_image_window2.Hide();
            }

            if (chk_box_disable_preview.Checked == false)
            {
                disable_preview = false;
                loaded_image_window2.show_preview = true;
                loaded_image_window2.Show();
                loaded_image_window2.Location = new Point(this.Location.X + this.Width + 5, this.Location.Y);
                loaded_image_window2.BringToFront();
            }

        }
                
    }
}
