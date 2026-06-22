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
        string pathFirstFilePdf;
        string pathSecondFilePdf;
        int totalPage;
  
        bool firstPageOpen;
        bool secondPageOpen;
        bool mergePageOpen;
        string pathOfFolder;
        string outputFileName;
        string outputFilePath;
        public MergePdfControl()
        {
            InitializeComponent();
            btnFirstFile.Image=btnOpenFolder.Image=btnSecondFile.Image = new Bitmap(Properties.Resources.icon_icons__2_, new Size(20, 20));
            btnReset.Image = new Bitmap(Properties.Resources.icon_icons__1_, new Size(30, 30));
        }

        bool OpenFile(Label lblTotlalPage, Label lblNameFile,ref string   pathFilePdf)
        {
            int totalPage;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Pdf File";
                openFileDialog.Filter = "PDF Files|*.pdf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathFilePdf = openFileDialog.FileName;
                    using (PdfDocument pdfDocument = PdfReader.Open(pathFilePdf, PdfDocumentOpenMode.Import))
                    {
                        totalPage = pdfDocument.PageCount;
                        lblTotlalPage.Text = totalPage.ToString();
                        lblNameFile.Text = Path.GetFileName(pathFilePdf);
                        return true;

                    }
                }


            }
            return false;
        }
        void EnableButtonMerge(bool firstPageOpen,bool secondPageOpen,bool mergePageOpen)
        {
            if(firstPageOpen && secondPageOpen && this.mergePageOpen)
            {

                btnMerge.Enabled = true;

            }

        }
        private void btnFirstFile_Click(object sender, EventArgs e)
        {
            firstPageOpen = OpenFile(lblTotalFirstPage,lblNameFirsFile,ref pathFirstFilePdf);
            EnableButtonMerge(firstPageOpen, secondPageOpen, mergePageOpen);
        }

        private void btnSecondFile_Click(object sender, EventArgs e)
        {
            secondPageOpen = OpenFile(lblTotalSecondPage, lblNameSecondFile,ref pathSecondFilePdf);
            EnableButtonMerge(firstPageOpen, secondPageOpen, mergePageOpen);
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
                    EnableButtonMerge(firstPageOpen, secondPageOpen, mergePageOpen);
                }
            }
        }

        private void txtOutFolder_TextChanged(object sender, EventArgs e)
        {

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
        void MergePath()
        {


            outputFileName = txtOutFile.Text + ".pdf";
            outputFilePath = Path.Combine(pathOfFolder, outputFileName);
        }

        void SavePageToPath(PdfDocument document)
        {

           

               
                document.Save(outputFilePath);
                document.Close();
          
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
        void TotalPgseWhenMerge(PdfDocument first, PdfDocument second)
        {
            totalPage = first.PageCount + second.PageCount;
            lblTotalPages.Text = totalPage.ToString();
        }
        bool CheckIsNameFileExists()
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
                    File.Delete(outputFilePath);

                }
                else
                {
                    return false;
                }
            }
                return true;
           

        }



        void MergePdf()
        {
            using (PdfDocument pdfDocument = new PdfDocument())
            using (PdfDocument firstPdf = PdfReader.Open(pathFirstFilePdf, PdfDocumentOpenMode.Import))
            using (PdfDocument secondPdf = PdfReader.Open(pathSecondFilePdf, PdfDocumentOpenMode.Import))
            {
                if (!CheckIsNameFileExists())
                {

                    return;
                }
                TotalPgseWhenMerge(firstPdf,secondPdf);
                progressBar1.Value = 0;
                progressBar1.Maximum = totalPage;
                AddPages(firstPdf, pdfDocument);
                AddPages(secondPdf, pdfDocument);

                SavePageToPath(pdfDocument);
                MessageBox.Show("PDF files merged successfully.", "SuccessFully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }   
        
        
        private void btnMerge_Click(object sender, EventArgs e)
        {
            if (HasValidationErrors())
            {
                return;
            }
            MergePath();
            MergePdf();
        }
        void ResetPage()
        {

            lblFileSelectd.Text = "No file selected";
            lblNameFirsFile.Text = lblNameSecondFile.Text = "Choose the first PDF file";
            lblTotalFirstPage.Text = lblTotalPages.Text = lblTotalSecondPage.Text = "--";
            txtOutFile.Clear();
            txtOutFolder.Clear();

            btnMerge.Enabled = false;

            pathFirstFilePdf = pathSecondFilePdf = string.Empty;
            pathOfFolder = string.Empty;
            outputFileName = string.Empty;
            outputFilePath = string.Empty;
            firstPageOpen = false;
            secondPageOpen = false;
            mergePageOpen = false;
        


        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetPage();
        }

        private void MergePdfControl_Load(object sender, EventArgs e)
        {

        }
    }
}
