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
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
namespace learnpdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnFolderPath.Image = new Bitmap(Properties.Resources.icon_icons__2_, new Size(20, 20));
            btnOpenFile.Image = new Bitmap(Properties.Resources.icon_icons__2_, new Size(20, 20));
            btnSplit.Image= new Bitmap(Properties.Resources.icon_icons, new Size(30, 30));
            btnReset.Image= new Bitmap(Properties.Resources.icon_icons__1_, new Size(30, 30));
            panel3.Visible = true;
        }
        string pathFilePdf;
        string pathOfFolder;
        string outputFileName; 
        string outputFilePath;
        int totalPage;
        void GetPathOfFile()
        {
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
                        lblFileSelectd.Text = "File Selected";
                        numarticFromPage.Enabled = numarticToPage.Enabled = true;
                        btnSplit.Enabled = true;
                    }
                }
            }
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            GetPathOfFile();
        }
        void ResetPage()
        {

            lblFileSelectd.Text = "No file selected";
            lblNameFile.Text = "Please choose a PDF file to get started";
            lblTotlalPage.Text = "--";
            txtOutFile.Clear();
            txtOutFolder.Clear();
            numarticFromPage.Enabled = numarticToPage.Enabled = false;
            btnSplit.Enabled = false;
            numarticFromPage.Value = numarticToPage.Value = 1;
            pathFilePdf = string.Empty;
            pathOfFolder = string.Empty;
            outputFileName = string.Empty;
            outputFilePath = string.Empty;
            totalPage = 0;
            progressBar1.Visible = false;


        }
        private void btnFolderPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {

                    pathOfFolder = folderBrowserDialog.SelectedPath;
                    txtOutFolder.Text = pathOfFolder;
                }
            }
        }
        void SavePageToPath(PdfDocument document)
        {

            if (File.Exists(outputFilePath))
            {

                File.Delete(outputFilePath);
            }

            document.Save(outputFilePath);
            document.Close();



        }
        void AddPages(PdfDocument pdfDocument)
        {

            PdfDocument document = new PdfDocument();

            int from = (int)numarticFromPage.Value;
            int To = (int)numarticToPage.Value;
            int total = To - from + 1;

            progressBar1.Maximum = total;
          
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            for (int i = from; i <= To; i++)
            {

                document.AddPage(pdfDocument.Pages[i - 1]);
                progressBar1.Value++;
                Application.DoEvents();
            }
            SavePageToPath(document);

        }

        void CopyPdf()
        {
            PdfDocument pdfDocument = PdfReader.Open(pathFilePdf,PdfDocumentOpenMode.Import);
           
           

            AddPages(pdfDocument);
         
            pdfDocument.Close();

        }
        void MergePath()
        {


            outputFileName = txtOutFile.Text + ".pdf";
            outputFilePath = Path.Combine(pathOfFolder, outputFileName);
        }
        bool HasValidationErrors()
        {
            bool hasError = false;

            if (numarticFromPage.Value > numarticToPage.Value)
            {
                errorProvider1.SetError(numarticFromPage, "From page must be less than or equal to To page.");
                hasError = true;
            }
            else
            {
                errorProvider1.SetError(numarticFromPage, "");
            }
            if (totalPage < numarticToPage.Value)
            {
                errorProvider1.SetError(numarticToPage, "TO page must be less than total Pages.");
                hasError = true;
            }
            else
            {
                errorProvider1.SetError(numarticToPage, "");
            }
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
        private void btnSplit_Click(object sender, EventArgs e)
        {
            
            if (HasValidationErrors())
            {

                return;
            }
            MergePath();
            CopyPdf();
           
        }

     

        private void ResetPage(object sender, EventArgs e)
        {
            ResetPage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new frmAboutMe();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
