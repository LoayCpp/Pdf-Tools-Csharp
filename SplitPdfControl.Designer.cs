namespace learnpdf
{
    partial class SplitPdfControl
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
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnFolderPath = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtOutFile = new System.Windows.Forms.TextBox();
            this.txtOutFolder = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotlalPage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numarticFromPage = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNameFile = new System.Windows.Forms.Label();
            this.lblFileSelectd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numarticToPage = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numarticFromPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numarticToPage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSplit
            // 
            this.btnSplit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSplit.Enabled = false;
            this.btnSplit.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSplit.ForeColor = System.Drawing.Color.White;
            this.btnSplit.Location = new System.Drawing.Point(28, 699);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(690, 46);
            this.btnSplit.TabIndex = 4;
            this.btnSplit.Text = "Split";
            this.btnSplit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSplit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnFolderPath
            // 
            this.btnFolderPath.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFolderPath.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnFolderPath.ForeColor = System.Drawing.Color.White;
            this.btnFolderPath.Location = new System.Drawing.Point(721, 514);
            this.btnFolderPath.Name = "btnFolderPath";
            this.btnFolderPath.Size = new System.Drawing.Size(143, 44);
            this.btnFolderPath.TabIndex = 3;
            this.btnFolderPath.Text = "Browse";
            this.btnFolderPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFolderPath.UseVisualStyleBackColor = false;
            this.btnFolderPath.Click += new System.EventHandler(this.btnFolderPath_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 651);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(690, 31);
            this.progressBar1.TabIndex = 17;
            this.progressBar1.Visible = false;
            // 
            // txtOutFile
            // 
            this.txtOutFile.BackColor = System.Drawing.Color.White;
            this.txtOutFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtOutFile.Location = new System.Drawing.Point(223, 597);
            this.txtOutFile.Multiline = true;
            this.txtOutFile.Name = "txtOutFile";
            this.txtOutFile.Size = new System.Drawing.Size(587, 38);
            this.txtOutFile.TabIndex = 14;
            // 
            // txtOutFolder
            // 
            this.txtOutFolder.BackColor = System.Drawing.Color.White;
            this.txtOutFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtOutFolder.Location = new System.Drawing.Point(201, 516);
            this.txtOutFolder.Multiline = true;
            this.txtOutFolder.Name = "txtOutFolder";
            this.txtOutFolder.ReadOnly = true;
            this.txtOutFolder.Size = new System.Drawing.Size(514, 38);
            this.txtOutFolder.TabIndex = 13;
            this.txtOutFolder.TextChanged += new System.EventHandler(this.txtOutFolder_TextChanged);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOpenFile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.Location = new System.Drawing.Point(683, 67);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(180, 44);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Choose File";
            this.btnOpenFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnReset.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReset.Location = new System.Drawing.Point(727, 696);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(165, 44);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.ResetPage);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(95, 604);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Output File Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(95, 525);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Output Folder";
            // 
            // lblTotlalPage
            // 
            this.lblTotlalPage.AutoSize = true;
            this.lblTotlalPage.BackColor = System.Drawing.Color.Transparent;
            this.lblTotlalPage.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotlalPage.Location = new System.Drawing.Point(175, 384);
            this.lblTotlalPage.Name = "lblTotlalPage";
            this.lblTotlalPage.Size = new System.Drawing.Size(24, 23);
            this.lblTotlalPage.TabIndex = 8;
            this.lblTotlalPage.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(80, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total Pages:";
            // 
            // numarticFromPage
            // 
            this.numarticFromPage.Enabled = false;
            this.numarticFromPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.numarticFromPage.Location = new System.Drawing.Point(120, 285);
            this.numarticFromPage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numarticFromPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numarticFromPage.Name = "numarticFromPage";
            this.numarticFromPage.Size = new System.Drawing.Size(242, 34);
            this.numarticFromPage.TabIndex = 1;
            this.numarticFromPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "From Page";
            // 
            // lblNameFile
            // 
            this.lblNameFile.AutoSize = true;
            this.lblNameFile.BackColor = System.Drawing.Color.Transparent;
            this.lblNameFile.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNameFile.Location = new System.Drawing.Point(116, 120);
            this.lblNameFile.Name = "lblNameFile";
            this.lblNameFile.Size = new System.Drawing.Size(250, 19);
            this.lblNameFile.TabIndex = 5;
            this.lblNameFile.Text = "Please choose a PDF file to get started";
            // 
            // lblFileSelectd
            // 
            this.lblFileSelectd.AutoSize = true;
            this.lblFileSelectd.BackColor = System.Drawing.Color.Transparent;
            this.lblFileSelectd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSelectd.Location = new System.Drawing.Point(123, 88);
            this.lblFileSelectd.Name = "lblFileSelectd";
            this.lblFileSelectd.Size = new System.Drawing.Size(130, 23);
            this.lblFileSelectd.TabIndex = 4;
            this.lblFileSelectd.Text = "No file selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "3. Output Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "2. Select Page Range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Select PDF File";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::learnpdf.Properties.Resources.pdfBackground1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(958, 792);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(636, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "To Page";
            // 
            // numarticToPage
            // 
            this.numarticToPage.Enabled = false;
            this.numarticToPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numarticToPage.Location = new System.Drawing.Point(636, 281);
            this.numarticToPage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numarticToPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numarticToPage.Name = "numarticToPage";
            this.numarticToPage.Size = new System.Drawing.Size(247, 34);
            this.numarticToPage.TabIndex = 2;
            this.numarticToPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SplitPdfControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnFolderPath);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtOutFile);
            this.Controls.Add(this.txtOutFolder);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotlalPage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNameFile);
            this.Controls.Add(this.lblFileSelectd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numarticToPage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numarticFromPage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SplitPdfControl";
            this.Size = new System.Drawing.Size(966, 798);
            ((System.ComponentModel.ISupportInitialize)(this.numarticFromPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numarticToPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnFolderPath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtOutFile;
        private System.Windows.Forms.TextBox txtOutFolder;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotlalPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numarticFromPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNameFile;
        private System.Windows.Forms.Label lblFileSelectd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numarticToPage;
        private System.Windows.Forms.Label label7;
    }
}
