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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_box_zip = new System.Windows.Forms.CheckBox();
            this.chk_box_cbz = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_clr_list = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.files_size_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(388, 212);
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
            this.btn_folderselect.Location = new System.Drawing.Point(12, 568);
            this.btn_folderselect.Name = "btn_folderselect";
            this.btn_folderselect.Size = new System.Drawing.Size(91, 23);
            this.btn_folderselect.TabIndex = 1;
            this.btn_folderselect.Text = "Select Folder";
            this.btn_folderselect.UseVisualStyleBackColor = true;
            this.btn_folderselect.Click += new System.EventHandler(this.btn_folderselect_Click);
            // 
            // btn_saveto
            // 
            this.btn_saveto.Location = new System.Drawing.Point(12, 597);
            this.btn_saveto.Name = "btn_saveto";
            this.btn_saveto.Size = new System.Drawing.Size(91, 23);
            this.btn_saveto.TabIndex = 2;
            this.btn_saveto.Text = "Save To";
            this.btn_saveto.UseVisualStyleBackColor = true;
            this.btn_saveto.Click += new System.EventHandler(this.btn_saveto_Click);
            // 
            // lnk_folderloc
            // 
            this.lnk_folderloc.AutoSize = true;
            this.lnk_folderloc.Location = new System.Drawing.Point(126, 573);
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
            this.fldr_browser_saveto.Location = new System.Drawing.Point(126, 601);
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
            this.btn_compress_start.Location = new System.Drawing.Point(11, 626);
            this.btn_compress_start.Name = "btn_compress_start";
            this.btn_compress_start.Size = new System.Drawing.Size(92, 70);
            this.btn_compress_start.TabIndex = 5;
            this.btn_compress_start.Text = "Compress";
            this.btn_compress_start.UseVisualStyleBackColor = false;
            this.btn_compress_start.Click += new System.EventHandler(this.btn_compress_start_Click);
            // 
            // btn_list_delete
            // 
            this.btn_list_delete.Location = new System.Drawing.Point(11, 5);
            this.btn_list_delete.Name = "btn_list_delete";
            this.btn_list_delete.Size = new System.Drawing.Size(117, 23);
            this.btn_list_delete.TabIndex = 6;
            this.btn_list_delete.Text = "Delete Selection";
            this.btn_list_delete.UseVisualStyleBackColor = true;
            this.btn_list_delete.Click += new System.EventHandler(this.btn_list_delete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Type a File Name";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "File Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "File Name Cannot Contain: \\ / : * ? \" < > |";
            // 
            // chk_box_zip
            // 
            this.chk_box_zip.AutoSize = true;
            this.chk_box_zip.Location = new System.Drawing.Point(13, 468);
            this.chk_box_zip.Name = "chk_box_zip";
            this.chk_box_zip.Size = new System.Drawing.Size(46, 17);
            this.chk_box_zip.TabIndex = 10;
            this.chk_box_zip.Text = ".ZIP";
            this.chk_box_zip.UseVisualStyleBackColor = true;
            // 
            // chk_box_cbz
            // 
            this.chk_box_cbz.AutoSize = true;
            this.chk_box_cbz.Location = new System.Drawing.Point(13, 491);
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
            this.label3.Location = new System.Drawing.Point(9, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Please Choose a file extension to save your files as";
            // 
            // btn_clr_list
            // 
            this.btn_clr_list.Location = new System.Drawing.Point(283, 5);
            this.btn_clr_list.Name = "btn_clr_list";
            this.btn_clr_list.Size = new System.Drawing.Size(117, 23);
            this.btn_clr_list.TabIndex = 13;
            this.btn_clr_list.Text = "Clear List";
            this.btn_clr_list.UseVisualStyleBackColor = true;
            this.btn_clr_list.Click += new System.EventHandler(this.btn_clr_list_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 634);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(620, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 691);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(624, 665);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(624, 665);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(208, 334);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(193, 16);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Visit Website for news & updates";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Created By: Martin Garcilazo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Comic Book Wizard(Alpha)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total Size:";
            // 
            // files_size_total
            // 
            this.files_size_total.AutoSize = true;
            this.files_size_total.Location = new System.Drawing.Point(92, 261);
            this.files_size_total.Name = "files_size_total";
            this.files_size_total.Size = new System.Drawing.Size(0, 13);
            this.files_size_total.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 708);
            this.Controls.Add(this.files_size_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_list_delete);
            this.Controls.Add(this.btn_clr_list);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chk_box_cbz);
            this.Controls.Add(this.chk_box_zip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_compress_start);
            this.Controls.Add(this.fldr_browser_saveto);
            this.Controls.Add(this.lnk_folderloc);
            this.Controls.Add(this.btn_saveto);
            this.Controls.Add(this.btn_folderselect);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "The Comic Book Wizard *ALPHA*";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FolderBrowserDialog fldr_browser_selectfolder;
        private System.Windows.Forms.FolderBrowserDialog fldr_save_to;
        private System.Windows.Forms.Button btn_folderselect;
        private System.Windows.Forms.Button btn_saveto;
        private System.Windows.Forms.LinkLabel lnk_folderloc;
        private System.Windows.Forms.LinkLabel fldr_browser_saveto;
        private System.Windows.Forms.Button btn_compress_start;
        private System.Windows.Forms.Button btn_list_delete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_box_zip;
        private System.Windows.Forms.CheckBox chk_box_cbz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_clr_list;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label files_size_total;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

