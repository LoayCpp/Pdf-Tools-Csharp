namespace learnpdf
{
    partial class MergePdfControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnFirstFile = new System.Windows.Forms.Button();
            this.lblNameFirsFile = new System.Windows.Forms.Label();
            this.lblFileSelectd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOutFolder = new System.Windows.Forms.TextBox();
            this.txtOutFile = new System.Windows.Forms.TextBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalFiles = new System.Windows.Forms.Label();
            this.lblTotalPagesInListbox = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalPages = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnClearLsit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirstFile
            // 
            this.btnFirstFile.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFirstFile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnFirstFile.ForeColor = System.Drawing.Color.White;
            this.btnFirstFile.Location = new System.Drawing.Point(725, 96);
            this.btnFirstFile.Name = "btnFirstFile";
            this.btnFirstFile.Size = new System.Drawing.Size(180, 44);
            this.btnFirstFile.TabIndex = 0;
            this.btnFirstFile.Text = "Browse";
            this.btnFirstFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFirstFile.UseVisualStyleBackColor = false;
            this.btnFirstFile.Click += new System.EventHandler(this.btnFirstFile_Click);
            // 
            // lblNameFirsFile
            // 
            this.lblNameFirsFile.AutoSize = true;
            this.lblNameFirsFile.BackColor = System.Drawing.Color.Transparent;
            this.lblNameFirsFile.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFirsFile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNameFirsFile.Location = new System.Drawing.Point(117, 113);
            this.lblNameFirsFile.Name = "lblNameFirsFile";
            this.lblNameFirsFile.Size = new System.Drawing.Size(161, 19);
            this.lblNameFirsFile.TabIndex = 17;
            this.lblNameFirsFile.Text = "Choose the first PDF file";
            // 
            // lblFileSelectd
            // 
            this.lblFileSelectd.AutoSize = true;
            this.lblFileSelectd.BackColor = System.Drawing.Color.Transparent;
            this.lblFileSelectd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSelectd.Location = new System.Drawing.Point(123, 83);
            this.lblFileSelectd.Name = "lblFileSelectd";
            this.lblFileSelectd.Size = new System.Drawing.Size(135, 23);
            this.lblFileSelectd.TabIndex = 16;
            this.lblFileSelectd.Text = "No File Selected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "1. Select PDF File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "2. Output Settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(102, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Output Folder";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(101, 419);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Output File Name";
            // 
            // txtOutFolder
            // 
            this.txtOutFolder.BackColor = System.Drawing.Color.White;
            this.txtOutFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtOutFolder.Location = new System.Drawing.Point(205, 345);
            this.txtOutFolder.Multiline = true;
            this.txtOutFolder.Name = "txtOutFolder";
            this.txtOutFolder.ReadOnly = true;
            this.txtOutFolder.Size = new System.Drawing.Size(514, 38);
            this.txtOutFolder.TabIndex = 23;
            this.txtOutFolder.TextChanged += new System.EventHandler(this.txtOutFolder_TextChanged);
            // 
            // txtOutFile
            // 
            this.txtOutFile.BackColor = System.Drawing.Color.White;
            this.txtOutFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtOutFile.Location = new System.Drawing.Point(230, 408);
            this.txtOutFile.Multiline = true;
            this.txtOutFile.Name = "txtOutFile";
            this.txtOutFile.Size = new System.Drawing.Size(587, 38);
            this.txtOutFile.TabIndex = 24;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOpenFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnOpenFolder.ForeColor = System.Drawing.Color.White;
            this.btnOpenFolder.Location = new System.Drawing.Point(725, 342);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(180, 44);
            this.btnOpenFolder.TabIndex = 2;
            this.btnOpenFolder.Text = "Browse";
            this.btnOpenFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenFolder.UseVisualStyleBackColor = false;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMerge.Enabled = false;
            this.btnMerge.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnMerge.ForeColor = System.Drawing.Color.White;
            this.errorProvider1.SetIconAlignment(this.btnMerge, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnMerge.Location = new System.Drawing.Point(29, 477);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(690, 82);
            this.btnMerge.TabIndex = 3;
            this.btnMerge.Text = "Merge PDF";
            this.btnMerge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMerge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMerge.UseVisualStyleBackColor = false;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnReset.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReset.Location = new System.Drawing.Point(740, 477);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(165, 82);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 728);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Total Files";
            // 
            // lblTotalFiles
            // 
            this.lblTotalFiles.AutoSize = true;
            this.lblTotalFiles.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFiles.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFiles.Location = new System.Drawing.Point(116, 703);
            this.lblTotalFiles.Name = "lblTotalFiles";
            this.lblTotalFiles.Size = new System.Drawing.Size(24, 23);
            this.lblTotalFiles.TabIndex = 30;
            this.lblTotalFiles.Text = "--";
            // 
            // lblTotalPagesInListbox
            // 
            this.lblTotalPagesInListbox.AutoSize = true;
            this.lblTotalPagesInListbox.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPagesInListbox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagesInListbox.Location = new System.Drawing.Point(430, 703);
            this.lblTotalPagesInListbox.Name = "lblTotalPagesInListbox";
            this.lblTotalPagesInListbox.Size = new System.Drawing.Size(24, 23);
            this.lblTotalPagesInListbox.TabIndex = 32;
            this.lblTotalPagesInListbox.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 728);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Total Pges";
            // 
            // lblTotalPages
            // 
            this.lblTotalPages.AutoSize = true;
            this.lblTotalPages.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPages.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPages.Location = new System.Drawing.Point(747, 703);
            this.lblTotalPages.Name = "lblTotalPages";
            this.lblTotalPages.Size = new System.Drawing.Size(24, 23);
            this.lblTotalPages.TabIndex = 34;
            this.lblTotalPages.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(745, 728);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 23);
            this.label9.TabIndex = 33;
            this.label9.Text = "Total Pages After Merge";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 577);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(934, 31);
            this.progressBar1.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 652);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 28);
            this.label12.TabIndex = 36;
            this.label12.Text = "3. Merge Information";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(38, 158);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(452, 96);
            this.listBox1.TabIndex = 37;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(497, 167);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(77, 34);
            this.btnUp.TabIndex = 39;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(497, 207);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(77, 34);
            this.btnDown.TabIndex = 40;
            this.btnDown.Text = "down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnClearLsit
            // 
            this.btnClearLsit.BackColor = System.Drawing.Color.White;
            this.btnClearLsit.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnClearLsit.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClearLsit.Location = new System.Drawing.Point(725, 181);
            this.btnClearLsit.Name = "btnClearLsit";
            this.btnClearLsit.Size = new System.Drawing.Size(180, 44);
            this.btnClearLsit.TabIndex = 41;
            this.btnClearLsit.Text = "Clear List";
            this.btnClearLsit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearLsit.UseVisualStyleBackColor = false;
            this.btnClearLsit.Click += new System.EventHandler(this.btnClearLsit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::learnpdf.Properties.Resources.Merge__1_;
            this.pictureBox1.Location = new System.Drawing.Point(7, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(943, 779);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MergePdfControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnClearLsit);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblTotalPages);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotalPagesInListbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalFiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.txtOutFile);
            this.Controls.Add(this.txtOutFolder);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNameFirsFile);
            this.Controls.Add(this.lblFileSelectd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFirstFile);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MergePdfControl";
            this.Size = new System.Drawing.Size(950, 790);
            this.Load += new System.EventHandler(this.MergePdfControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirstFile;
        private System.Windows.Forms.Label lblNameFirsFile;
        private System.Windows.Forms.Label lblFileSelectd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOutFolder;
        private System.Windows.Forms.TextBox txtOutFile;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalFiles;
        private System.Windows.Forms.Label lblTotalPagesInListbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalPages;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnClearLsit;
    }
}
