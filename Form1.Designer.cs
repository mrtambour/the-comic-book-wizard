namespace thecomicbookwizard
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.fldr_browser_selectfolder = new System.Windows.Forms.FolderBrowserDialog();
            this.fldr_save_to = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_folderselect = new System.Windows.Forms.Button();
            this.btn_saveto = new System.Windows.Forms.Button();
            this.lnk_folderloc = new System.Windows.Forms.LinkLabel();
            this.fldr_browser_saveto = new System.Windows.Forms.LinkLabel();
            this.btn_compress_start = new System.Windows.Forms.Button();
            this.btn_list_delete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_box_zip = new System.Windows.Forms.CheckBox();
            this.chk_box_cbz = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.files_size_total = new System.Windows.Forms.Label();
            this.prgrs_bar = new System.Windows.Forms.ProgressBar();
            this.btn_reset_window2_dimensions = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chk_box_disable_preview = new System.Windows.Forms.CheckBox();
            this.checkbox_disable_docking = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl_cnvrt_to_txt = new System.Windows.Forms.Label();
            this.chkbox_cnvrt_to_cbz = new System.Windows.Forms.CheckBox();
            this.btn_save_archive_to = new System.Windows.Forms.Button();
            this.btn_archive_process = new System.Windows.Forms.Button();
            this.btn_select_archive_directory = new System.Windows.Forms.Button();
            this.listbox_archive_list = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.link_about_website = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.folder_archive_directory_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.folder_archive_saveto_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(388, 160);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // btn_folderselect
            // 
            this.btn_folderselect.Location = new System.Drawing.Point(8, 317);
            this.btn_folderselect.Name = "btn_folderselect";
            this.btn_folderselect.Size = new System.Drawing.Size(93, 31);
            this.btn_folderselect.TabIndex = 1;
            this.btn_folderselect.Text = "Select Folder";
            this.btn_folderselect.UseVisualStyleBackColor = true;
            this.btn_folderselect.Click += new System.EventHandler(this.btn_folderselect_Click);
            // 
            // btn_saveto
            // 
            this.btn_saveto.Location = new System.Drawing.Point(8, 367);
            this.btn_saveto.Name = "btn_saveto";
            this.btn_saveto.Size = new System.Drawing.Size(93, 31);
            this.btn_saveto.TabIndex = 2;
            this.btn_saveto.Text = "Save To";
            this.btn_saveto.UseVisualStyleBackColor = true;
            this.btn_saveto.Click += new System.EventHandler(this.btn_saveto_Click);
            // 
            // lnk_folderloc
            // 
            this.lnk_folderloc.AutoSize = true;
            this.lnk_folderloc.Location = new System.Drawing.Point(122, 326);
            this.lnk_folderloc.Name = "lnk_folderloc";
            this.lnk_folderloc.Size = new System.Drawing.Size(36, 13);
            this.lnk_folderloc.TabIndex = 3;
            this.lnk_folderloc.TabStop = true;
            this.lnk_folderloc.Text = "Folder";
            this.lnk_folderloc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_folderloc_LinkClicked);
            // 
            // fldr_browser_saveto
            // 
            this.fldr_browser_saveto.AutoSize = true;
            this.fldr_browser_saveto.Location = new System.Drawing.Point(122, 375);
            this.fldr_browser_saveto.Name = "fldr_browser_saveto";
            this.fldr_browser_saveto.Size = new System.Drawing.Size(48, 13);
            this.fldr_browser_saveto.TabIndex = 4;
            this.fldr_browser_saveto.TabStop = true;
            this.fldr_browser_saveto.Text = "Save To";
            this.fldr_browser_saveto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fldr_browser_saveto_LinkClicked);
            // 
            // btn_compress_start
            // 
            this.btn_compress_start.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_compress_start.Location = new System.Drawing.Point(303, 504);
            this.btn_compress_start.Name = "btn_compress_start";
            this.btn_compress_start.Size = new System.Drawing.Size(92, 64);
            this.btn_compress_start.TabIndex = 5;
            this.btn_compress_start.Text = "Compress";
            this.btn_compress_start.UseVisualStyleBackColor = false;
            this.btn_compress_start.Click += new System.EventHandler(this.btn_compress_start_Click);
            // 
            // btn_list_delete
            // 
            this.btn_list_delete.Location = new System.Drawing.Point(6, 6);
            this.btn_list_delete.Name = "btn_list_delete";
            this.btn_list_delete.Size = new System.Drawing.Size(117, 23);
            this.btn_list_delete.TabIndex = 6;
            this.btn_list_delete.Text = "Delete Selection";
            this.btn_list_delete.UseVisualStyleBackColor = true;
            this.btn_list_delete.Click += new System.EventHandler(this.btn_list_delete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 464);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Type a File Name";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "File Name Cannot Contain: \\ / : * ? \" < > |";
            // 
            // chk_box_zip
            // 
            this.chk_box_zip.AutoSize = true;
            this.chk_box_zip.Location = new System.Drawing.Point(18, 532);
            this.chk_box_zip.Name = "chk_box_zip";
            this.chk_box_zip.Size = new System.Drawing.Size(46, 17);
            this.chk_box_zip.TabIndex = 10;
            this.chk_box_zip.Text = ".ZIP";
            this.chk_box_zip.UseVisualStyleBackColor = true;
            // 
            // chk_box_cbz
            // 
            this.chk_box_cbz.AutoSize = true;
            this.chk_box_cbz.Location = new System.Drawing.Point(18, 555);
            this.chk_box_cbz.Name = "chk_box_cbz";
            this.chk_box_cbz.Size = new System.Drawing.Size(50, 17);
            this.chk_box_cbz.TabIndex = 11;
            this.chk_box_cbz.TabStop = false;
            this.chk_box_cbz.Text = ".CBZ";
            this.chk_box_cbz.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Save your archive(s) as:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total Size:";
            // 
            // files_size_total
            // 
            this.files_size_total.AutoSize = true;
            this.files_size_total.Location = new System.Drawing.Point(84, 197);
            this.files_size_total.Name = "files_size_total";
            this.files_size_total.Size = new System.Drawing.Size(0, 13);
            this.files_size_total.TabIndex = 17;
            // 
            // prgrs_bar
            // 
            this.prgrs_bar.Location = new System.Drawing.Point(6, 584);
            this.prgrs_bar.Name = "prgrs_bar";
            this.prgrs_bar.Size = new System.Drawing.Size(390, 24);
            this.prgrs_bar.Step = 100;
            this.prgrs_bar.TabIndex = 20;
            // 
            // btn_reset_window2_dimensions
            // 
            this.btn_reset_window2_dimensions.Location = new System.Drawing.Point(279, 6);
            this.btn_reset_window2_dimensions.Name = "btn_reset_window2_dimensions";
            this.btn_reset_window2_dimensions.Size = new System.Drawing.Size(116, 23);
            this.btn_reset_window2_dimensions.TabIndex = 21;
            this.btn_reset_window2_dimensions.Text = "Reset Preview";
            this.btn_reset_window2_dimensions.UseVisualStyleBackColor = true;
            this.btn_reset_window2_dimensions.Click += new System.EventHandler(this.btn_reset_window2_dimensions_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 699);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chk_box_disable_preview);
            this.tabPage1.Controls.Add(this.checkbox_disable_docking);
            this.tabPage1.Controls.Add(this.btn_reset_window2_dimensions);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btn_folderselect);
            this.tabPage1.Controls.Add(this.prgrs_bar);
            this.tabPage1.Controls.Add(this.btn_saveto);
            this.tabPage1.Controls.Add(this.files_size_total);
            this.tabPage1.Controls.Add(this.lnk_folderloc);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.fldr_browser_saveto);
            this.tabPage1.Controls.Add(this.btn_list_delete);
            this.tabPage1.Controls.Add(this.btn_compress_start);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.chk_box_cbz);
            this.tabPage1.Controls.Add(this.chk_box_zip);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(402, 673);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chk_box_disable_preview
            // 
            this.chk_box_disable_preview.AutoSize = true;
            this.chk_box_disable_preview.Location = new System.Drawing.Point(6, 266);
            this.chk_box_disable_preview.Name = "chk_box_disable_preview";
            this.chk_box_disable_preview.Size = new System.Drawing.Size(102, 17);
            this.chk_box_disable_preview.TabIndex = 23;
            this.chk_box_disable_preview.Text = "Disable Preview";
            this.chk_box_disable_preview.UseVisualStyleBackColor = true;
            this.chk_box_disable_preview.Click += new System.EventHandler(this.chk_box_disable_preview_Click);
            // 
            // checkbox_disable_docking
            // 
            this.checkbox_disable_docking.AutoSize = true;
            this.checkbox_disable_docking.Location = new System.Drawing.Point(6, 243);
            this.checkbox_disable_docking.Name = "checkbox_disable_docking";
            this.checkbox_disable_docking.Size = new System.Drawing.Size(145, 17);
            this.checkbox_disable_docking.TabIndex = 22;
            this.checkbox_disable_docking.Text = "Disable Preview Docking";
            this.checkbox_disable_docking.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbl_cnvrt_to_txt);
            this.tabPage3.Controls.Add(this.chkbox_cnvrt_to_cbz);
            this.tabPage3.Controls.Add(this.btn_save_archive_to);
            this.tabPage3.Controls.Add(this.btn_archive_process);
            this.tabPage3.Controls.Add(this.btn_select_archive_directory);
            this.tabPage3.Controls.Add(this.listbox_archive_list);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(402, 673);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Archive Manager";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbl_cnvrt_to_txt
            // 
            this.lbl_cnvrt_to_txt.AutoSize = true;
            this.lbl_cnvrt_to_txt.Location = new System.Drawing.Point(5, 465);
            this.lbl_cnvrt_to_txt.Name = "lbl_cnvrt_to_txt";
            this.lbl_cnvrt_to_txt.Size = new System.Drawing.Size(121, 13);
            this.lbl_cnvrt_to_txt.TabIndex = 5;
            this.lbl_cnvrt_to_txt.Text = "Convert All Archives To:";
            // 
            // chkbox_cnvrt_to_cbz
            // 
            this.chkbox_cnvrt_to_cbz.AutoSize = true;
            this.chkbox_cnvrt_to_cbz.Checked = true;
            this.chkbox_cnvrt_to_cbz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbox_cnvrt_to_cbz.Location = new System.Drawing.Point(8, 491);
            this.chkbox_cnvrt_to_cbz.Name = "chkbox_cnvrt_to_cbz";
            this.chkbox_cnvrt_to_cbz.Size = new System.Drawing.Size(50, 17);
            this.chkbox_cnvrt_to_cbz.TabIndex = 4;
            this.chkbox_cnvrt_to_cbz.Text = ".CBZ";
            this.chkbox_cnvrt_to_cbz.UseVisualStyleBackColor = true;
            // 
            // btn_save_archive_to
            // 
            this.btn_save_archive_to.Location = new System.Drawing.Point(3, 363);
            this.btn_save_archive_to.Name = "btn_save_archive_to";
            this.btn_save_archive_to.Size = new System.Drawing.Size(93, 31);
            this.btn_save_archive_to.TabIndex = 3;
            this.btn_save_archive_to.Text = "Save To";
            this.btn_save_archive_to.UseVisualStyleBackColor = true;
            this.btn_save_archive_to.Click += new System.EventHandler(this.btn_save_archive_to_Click);
            // 
            // btn_archive_process
            // 
            this.btn_archive_process.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_archive_process.Location = new System.Drawing.Point(299, 541);
            this.btn_archive_process.Name = "btn_archive_process";
            this.btn_archive_process.Size = new System.Drawing.Size(92, 64);
            this.btn_archive_process.TabIndex = 2;
            this.btn_archive_process.Text = "Process";
            this.btn_archive_process.UseVisualStyleBackColor = false;
            this.btn_archive_process.Click += new System.EventHandler(this.btn_archive_process_Click);
            // 
            // btn_select_archive_directory
            // 
            this.btn_select_archive_directory.Location = new System.Drawing.Point(3, 299);
            this.btn_select_archive_directory.Name = "btn_select_archive_directory";
            this.btn_select_archive_directory.Size = new System.Drawing.Size(93, 31);
            this.btn_select_archive_directory.TabIndex = 1;
            this.btn_select_archive_directory.Text = "Select Folder";
            this.btn_select_archive_directory.UseVisualStyleBackColor = true;
            this.btn_select_archive_directory.Click += new System.EventHandler(this.btn_select_archive_directory_Click);
            // 
            // listbox_archive_list
            // 
            this.listbox_archive_list.FormattingEnabled = true;
            this.listbox_archive_list.Location = new System.Drawing.Point(3, 3);
            this.listbox_archive_list.Name = "listbox_archive_list";
            this.listbox_archive_list.Size = new System.Drawing.Size(396, 290);
            this.listbox_archive_list.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.link_about_website);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(402, 673);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // link_about_website
            // 
            this.link_about_website.AutoSize = true;
            this.link_about_website.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_about_website.Location = new System.Drawing.Point(102, 101);
            this.link_about_website.Name = "link_about_website";
            this.link_about_website.Size = new System.Drawing.Size(179, 16);
            this.link_about_website.TabIndex = 2;
            this.link_about_website.TabStop = true;
            this.link_about_website.Text = "Comic Book Wizard Website";
            this.link_about_website.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_about_website_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "By: Martin Garcilazo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "The Comic Book Wizard v0.4.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 642);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "The Comic Book Wizard *v0.4.1*";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fldr_browser_selectfolder;
        private System.Windows.Forms.FolderBrowserDialog fldr_save_to;
        private System.Windows.Forms.Button btn_folderselect;
        private System.Windows.Forms.Button btn_saveto;
        private System.Windows.Forms.LinkLabel lnk_folderloc;
        private System.Windows.Forms.LinkLabel fldr_browser_saveto;
        private System.Windows.Forms.Button btn_compress_start;
        private System.Windows.Forms.Button btn_list_delete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_box_zip;
        private System.Windows.Forms.CheckBox chk_box_cbz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label files_size_total;
        private System.Windows.Forms.ProgressBar prgrs_bar;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_reset_window2_dimensions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel link_about_website;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listbox_archive_list;
        private System.Windows.Forms.Button btn_archive_process;
        private System.Windows.Forms.Button btn_select_archive_directory;
        private System.Windows.Forms.FolderBrowserDialog folder_archive_directory_dialog;
        private System.Windows.Forms.FolderBrowserDialog folder_archive_saveto_dialog;
        private System.Windows.Forms.Button btn_save_archive_to;
        private System.Windows.Forms.CheckBox checkbox_disable_docking;
        private System.Windows.Forms.Label lbl_cnvrt_to_txt;
        private System.Windows.Forms.CheckBox chkbox_cnvrt_to_cbz;
        private System.Windows.Forms.CheckBox chk_box_disable_preview;
    }
}

