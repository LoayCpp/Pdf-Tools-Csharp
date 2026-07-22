namespace learnpdf
{
    partial class DeletePages
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDeletePage = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTotalPagesAfterDelete = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPageDelete = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalFilesBeforeDelete = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.txtOutFolder = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNameFirsFile = new System.Windows.Forms.Label();
            this.lblFileSelectd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFirstFile = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnDeletePage
            // 
            this.btnDeletePage.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDeletePage.Enabled = false;
            this.btnDeletePage.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDeletePage.ForeColor = System.Drawing.Color.White;
            this.errorProvider1.SetIconAlignment(this.btnDeletePage, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnDeletePage.Location = new System.Drawing.Point(22, 474);
            this.btnDeletePage.Name = "btnDeletePage";
            this.btnDeletePage.Size = new System.Drawing.Size(690, 82);
            this.btnDeletePage.TabIndex = 46;
            this.btnDeletePage.Text = "Delete Selected Pages";
            this.btnDeletePage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletePage.UseVisualStyleBackColor = false;
            this.btnDeletePage.Click += new System.EventHandler(this.btnDeletePage_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 642);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 28);
            this.label12.TabIndex = 63;
            this.label12.Text = "3. Operation Summary\r\n";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 562);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(934, 31);
            this.progressBar1.TabIndex = 62;
            // 
            // lblTotalPagesAfterDelete
            // 
            this.lblTotalPagesAfterDelete.AutoSize = true;
            this.lblTotalPagesAfterDelete.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPagesAfterDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagesAfterDelete.Location = new System.Drawing.Point(741, 693);
            this.lblTotalPagesAfterDelete.Name = "lblTotalPagesAfterDelete";
            this.lblTotalPagesAfterDelete.Size = new System.Drawing.Size(24, 23);
            this.lblTotalPagesAfterDelete.TabIndex = 61;
            this.lblTotalPagesAfterDelete.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(732, 716);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 23);
            this.label9.TabIndex = 60;
            this.label9.Text = "Remaining Pages";
            // 
            // lblPageDelete
            // 
            this.lblPageDelete.AutoSize = true;
            this.lblPageDelete.BackColor = System.Drawing.Color.Transparent;
            this.lblPageDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageDelete.Location = new System.Drawing.Point(425, 693);
            this.lblPageDelete.Name = "lblPageDelete";
            this.lblPageDelete.Size = new System.Drawing.Size(24, 23);
            this.lblPageDelete.TabIndex = 59;
            this.lblPageDelete.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(425, 716);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 58;
            this.label6.Text = "Pages to Delete";
            // 
            // lblTotalFilesBeforeDelete
            // 
            this.lblTotalFilesBeforeDelete.AutoSize = true;
            this.lblTotalFilesBeforeDelete.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFilesBeforeDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFilesBeforeDelete.Location = new System.Drawing.Point(108, 693);
            this.lblTotalFilesBeforeDelete.Name = "lblTotalFilesBeforeDelete";
            this.lblTotalFilesBeforeDelete.Size = new System.Drawing.Size(24, 23);
            this.lblTotalFilesBeforeDelete.TabIndex = 57;
            this.lblTotalFilesBeforeDelete.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 716);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 56;
            this.label4.Text = "Original Total Pages";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnReset.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReset.Location = new System.Drawing.Point(745, 474);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(165, 82);
            this.btnReset.TabIndex = 47;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOpenFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnOpenFolder.ForeColor = System.Drawing.Color.White;
            this.btnOpenFolder.Location = new System.Drawing.Point(725, 328);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(180, 44);
            this.btnOpenFolder.TabIndex = 45;
            this.btnOpenFolder.Text = "Save As...";
            this.btnOpenFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenFolder.UseVisualStyleBackColor = false;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // txtOutFolder
            // 
            this.txtOutFolder.BackColor = System.Drawing.Color.White;
            this.txtOutFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtOutFolder.Location = new System.Drawing.Point(316, 331);
            this.txtOutFolder.Multiline = true;
            this.txtOutFolder.Name = "txtOutFolder";
            this.txtOutFolder.ReadOnly = true;
            this.txtOutFolder.Size = new System.Drawing.Size(358, 38);
            this.txtOutFolder.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(99, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 28);
            this.label10.TabIndex = 52;
            this.label10.Text = "Save the New PDF As";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 28);
            this.label2.TabIndex = 51;
            this.label2.Text = "2. Choose Output Location";
            // 
            // lblNameFirsFile
            // 
            this.lblNameFirsFile.AutoSize = true;
            this.lblNameFirsFile.BackColor = System.Drawing.Color.Transparent;
            this.lblNameFirsFile.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFirsFile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNameFirsFile.Location = new System.Drawing.Point(108, 100);
            this.lblNameFirsFile.Name = "lblNameFirsFile";
            this.lblNameFirsFile.Size = new System.Drawing.Size(161, 19);
            this.lblNameFirsFile.TabIndex = 50;
            this.lblNameFirsFile.Text = "Choose the first PDF file";
            // 
            // lblFileSelectd
            // 
            this.lblFileSelectd.AutoSize = true;
            this.lblFileSelectd.BackColor = System.Drawing.Color.Transparent;
            this.lblFileSelectd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSelectd.Location = new System.Drawing.Point(109, 76);
            this.lblFileSelectd.Name = "lblFileSelectd";
            this.lblFileSelectd.Size = new System.Drawing.Size(138, 23);
            this.lblFileSelectd.TabIndex = 49;
            this.lblFileSelectd.Text = "No PDF Selected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, -34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 28);
            this.label1.TabIndex = 48;
            this.label1.Text = "1. Select PDF File";
            // 
            // btnFirstFile
            // 
            this.btnFirstFile.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFirstFile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnFirstFile.ForeColor = System.Drawing.Color.White;
            this.btnFirstFile.Location = new System.Drawing.Point(696, 73);
            this.btnFirstFile.Name = "btnFirstFile";
            this.btnFirstFile.Size = new System.Drawing.Size(214, 44);
            this.btnFirstFile.TabIndex = 44;
            this.btnFirstFile.Text = "Choose File";
            this.btnFirstFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFirstFile.UseVisualStyleBackColor = false;
            this.btnFirstFile.Click += new System.EventHandler(this.btnFirstFile_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(452, 153);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(300, 79);
            this.checkedListBox1.TabIndex = 66;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 28);
            this.label3.TabIndex = 67;
            this.label3.Text = "1. Select PDF File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 23);
            this.label5.TabIndex = 68;
            this.label5.Text = "Select the pages to remove from the PDF";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::learnpdf.Properties.Resources.Merge__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(943, 779);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DeletePages
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblTotalPagesAfterDelete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPageDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalFilesBeforeDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDeletePage);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.txtOutFolder);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNameFirsFile);
            this.Controls.Add(this.lblFileSelectd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFirstFile);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DeletePages";
            this.Size = new System.Drawing.Size(950, 790);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTotalPagesAfterDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPageDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalFilesBeforeDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDeletePage;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.TextBox txtOutFolder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNameFirsFile;
        private System.Windows.Forms.Label lblFileSelectd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFirstFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}
