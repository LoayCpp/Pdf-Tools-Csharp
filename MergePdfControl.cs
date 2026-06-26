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
      
        List<string> lsPath;
        public MergePdfControl()
        {
            InitializeComponent();
         
            btnReset.Image = new Bitmap(Properties.Resources.icon_icons__1_, new Size(30, 30));
        }
        void AddFilesToListbox(List<string> path)
        {

            string namePath;
            foreach(string s in path)
            {
                namePath = Path.GetFileNameWithoutExtension(s);
                listBox1.Items.Add(namePath);

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
                    lsPath = openFileDialog.FileNames.ToList();
                    AddFilesToListbox(lsPath);
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
        private void btnFirstFile_Click(object sender, EventArgs e)
        {
            firstPageOpen = OpenFile(lblTotalFiles,lblNameFirsFile);

            TotalFilesAndPages();
            EnableButtonMerge(firstPageOpen, mergePageOpen);
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
            void AddPages(PdfDocument source, PdfDocument output)
            {
                foreach (PdfPage page in source.Pages)
                {
                    output.AddPage(page);
                progressBar1.Value++;
                    Application.DoEvents();
                }


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


        void TotalFilesAndPages()
        {
            SelctedItemInListbox();
             totalPages =0;
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
         
            lblTotalFiles.Text = lblTotalPages.Text = lblTotalPagesInListbox.Text = "--";
            txtOutFile.Clear();
            txtOutFolder.Clear();
            listBox1.Items.Clear();
            btnMerge.Enabled = false;

          
            pathOfFolder = string.Empty;
            outputFileName = string.Empty;
            outputFilePath = string.Empty;
            firstPageOpen = false;
          
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
