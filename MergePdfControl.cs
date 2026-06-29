using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using System.CodeDom;

namespace learnpdf
{
    public partial class MergePdfControl : UserControl
    {
       
      
        int totalPageAfterMerge;
        int totalPages;
        bool firstPageOpen;
      
        bool mergePageOpen;
        string pathOfFolder;
        string outputFileName;
        string outputFilePath;
      
        List<string> lsPath= new List<string>();
        public MergePdfControl()
        {
            InitializeComponent();
         
            btnReset.Image = new Bitmap(Properties.Resources.icon_icons__1_, new Size(30, 30));
            btnClearLsit.Image = new Bitmap(Properties.Resources.icon_icons__5_, new Size(30, 30));
            btnFirstFile.Image = new Bitmap(Properties.Resources.icon_icons__2_, new Size(30, 30));
           btnOpenFolder.Image= new Bitmap(Properties.Resources.icon_icons__2_, new Size(30, 30));
            btnMerge.Image = new Bitmap(Properties.Resources.icon_icons__7_, new Size(30, 30));
            this.DoubleBuffered = true;

        }
        void MoveFileDown()
        {
            if (listBox1.SelectedIndex == -1)
            {

                return;

            }
            int index = listBox1.SelectedIndex;
            string temp;
            string tempListPath;
            if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
            {
                return;
            }
            if (listBox1.Items.Count > 1)
            {
                if (index == listBox1.Items.Count - 1)
                {
                    return;
                }


                temp = listBox1.Items[index].ToString();
                listBox1.Items[index] = listBox1.Items[index + 1];
                listBox1.Items[index + 1] = temp;
                tempListPath = lsPath[index];
                lsPath[index] = lsPath[index + 1];
                lsPath[index + 1] = tempListPath;

                listBox1.SelectedIndex = index + 1;
            }
        }
        void MoveFileUp()
        {
            int index = listBox1.SelectedIndex;
            string temp;
            string tempListPath;
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            if (listBox1.Items.Count > 1)
            {
                if (index == 0)
                {
                    return;
                }


                temp = listBox1.Items[index].ToString();
                listBox1.Items[index] = listBox1.Items[index - 1];
                listBox1.Items[index - 1] = temp;
                tempListPath = lsPath[index];
                lsPath[index] = lsPath[index - 1];
                lsPath[index - 1] = tempListPath;

                listBox1.SelectedIndex = index - 1;
            }




        }
        void AddFilesToListbox(string [] fileNames)
        {
           
          
            foreach (string s in fileNames)
            {
              
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(s));

            }

        }
        bool OpenFile(Label lblTotlalPage, Label lblNameFile)
        {
            

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Title = "Pdf File";
                openFileDialog.Filter = "PDF Files|*.pdf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lsPath.AddRange(openFileDialog.FileNames);

                    AddFilesToListbox(openFileDialog.FileNames);
                    return true;
                }

            }
            return false;
        }
        void EnableButtonMerge(bool firstPageOpen,bool mergePageOpen)
        {
            if(firstPageOpen && this.mergePageOpen)
            {

                btnMerge.Enabled = true;

            }

        }
        void ClearList()
        {
            lblTotalFiles.Text = lblTotalPages.Text = lblTotalPagesInListbox.Text = "--";
            lblFileSelectd.Text = "No File Selected";
            lsPath.Clear();
            listBox1.Items.Clear();
            btnMerge.Enabled = false;



        }
        void MergePath()
        {


            outputFileName = txtOutFile.Text + ".pdf";
            outputFilePath = Path.Combine(pathOfFolder, outputFileName);
        }
        void TotalPagesWhenMerge(PdfDocument pages)
        {
            totalPageAfterMerge = pages.PageCount;
            lblTotalPages.Text = totalPageAfterMerge.ToString();
        }
        void SavePageToPath(PdfDocument document)
        {

           

               
                document.Save(outputFilePath);
                document.Close();
          
        }
        bool IsFilePathExist()
        {

            if (File.Exists(outputFilePath))
            {

                DialogResult result = MessageBox.Show(
      "A file with the same name already exists.\n\nDo you want to replace it?",
      "Confirm File Replace",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Warning,
      MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    return true;
                }
                else
                {

                    return false;
                }
              

            }
            return true;

            

        }
            void AddPages(PdfDocument source, PdfDocument output)
            {
                foreach (PdfPage page in source.Pages)
                {
                    output.AddPage(page);
                progressBar1.Value++;
                    Application.DoEvents();
                }


            }
        void SelctedItemInListbox()
        {

            if (listBox1.Items.Count > 0)
            {

                lblFileSelectd.Text = "File Selected";
            }
            else
            {
                lblFileSelectd.Text = "No File Selected";

            }

        }
        bool HasValidationErrors()
        {
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(txtOutFolder.Text))
            {
                errorProvider1.SetError(txtOutFolder, "You must select a path");
                hasError = true;
            }
            else
            {
                errorProvider1.SetError(txtOutFolder, "");
            }

            if (string.IsNullOrWhiteSpace(txtOutFile.Text))
            {
                errorProvider1.SetError(txtOutFile, "You must write a name of PDF");
                hasError = true;
            }
            else
            {
                errorProvider1.SetError(txtOutFile, "");
            }

            return hasError;
        }
        private void btnFirstFile_Click(object sender, EventArgs e)
        {
            
            firstPageOpen = OpenFile(lblTotalFiles,lblNameFirsFile);

            TotalFilesAndPages();
            EnableButtonMerge(firstPageOpen, mergePageOpen);
            
        }
        void StartMerge()
        {
            if (HasValidationErrors())
            {
                return;
            }
            MergePath();
            if (!IsFilePathExist())
            {

                return;
            }
            MergePdf();



        }

        void TotalFilesAndPages()
        {
            SelctedItemInListbox();
             totalPages =0;
            if(lsPath==null || lsPath.Count == 0)
            {
                return;
            }
           int totalFiles = lsPath.Count();
            foreach (string path in lsPath)
            {

                using (PdfDocument firstPdf = PdfReader.Open(path, PdfDocumentOpenMode.Import))
                {


                    totalPages += firstPdf.PageCount;

                }

                    


            }
            lblTotalPagesInListbox.Text=totalPages.ToString();
            lblTotalFiles.Text = totalFiles.ToString();

        }
        void MergePdf()
        {
            
            using (PdfDocument pdfDocument = new PdfDocument()) {
              
                progressBar1.Minimum = 0;
                progressBar1.Value = 0;
                progressBar1.Maximum = totalPages;
             foreach (string path in lsPath)
                {

                    using (PdfDocument firstPdf = PdfReader.Open(path, PdfDocumentOpenMode.Import))
                    {

                        AddPages(firstPdf, pdfDocument);

                    }
            }

                TotalPagesWhenMerge(pdfDocument);
                SavePageToPath(pdfDocument);
                MessageBox.Show("PDF files merged successfully.", "SuccessFully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
           

            
        }   
        void ResetPage()
        {

            ClearList();


            txtOutFile.Clear();
            txtOutFolder.Clear();
       
            btnMerge.Enabled = false;

          
            pathOfFolder = string.Empty;
            outputFileName = string.Empty;
            outputFilePath = string.Empty;
            firstPageOpen = false;
            progressBar1.Value = 0;
            mergePageOpen = false;
        


        }
      
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {

                    pathOfFolder = folderBrowserDialog.SelectedPath;
                    txtOutFolder.Text = pathOfFolder;
                    mergePageOpen = true;
                    EnableButtonMerge(firstPageOpen, mergePageOpen);
                }
            }
        }

        private void txtOutFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMerge_Click(object sender, EventArgs e)
        {

            StartMerge();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetPage();
        }

        private void MergePdfControl_Load(object sender, EventArgs e)
        {

        }


       
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void btnClearLsit_Click(object sender, EventArgs e)
        {
            ClearList();
        }

        private void picUp_Click(object sender, EventArgs e)
        {
            MoveFileUp();
        }

        private void picDown_Click(object sender, EventArgs e)
        {
            MoveFileDown();
        }
    }
    }

