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
using PdfSharp.Pdf.Content.Objects;
using PdfSharp.Pdf.IO;

namespace learnpdf
{
    public partial class DeletePages : UserControl
    {
        public DeletePages()
        {
            InitializeComponent();
            btnReset.Image = new Bitmap(Properties.Resources.icon_icons__1_, new Size(30, 30));
            btnFirstFile.Image = new Bitmap(Properties.Resources.icon_icons__2_, new Size(30, 30));
            btnOpenFolder.Image = new Bitmap(Properties.Resources.icon_icons__2_, new Size(30, 30));
            btnDeletePage.Image = new Bitmap(Properties.Resources.icon_icons__8_, new Size(30, 30));
        }
        private string firstPath = "";
        private string pathOfSave = "";
        private bool IsPathFull = false;
        string ChoiceFileToDelete()
        {
            string fileName="";
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "PDF Files (*.pdf)|*.pdf";

                openFile.Title = "Choose PDF";

                if (openFile.ShowDialog() == DialogResult.OK)
                {

                    fileName = openFile.FileName;

                }
            }
            return fileName;
        }
        void ClearCheckBoxAndPath()
        {
            checkedListBox1.Items.Clear();
            firstPath = "";
            lblFileSelectd.Text = "No PDF Selected";
            lblNameFirsFile.Text = "Choose the first PDF file";






        }
        void AddPdfToCheckboxList(PdfDocument pdf)
        {
            int i = 1;
            foreach(PdfPage p in pdf.Pages)
            {

                checkedListBox1.Items.Add($"Page {i}");
                i++;
            }

        }
        void MessageBoxShowErrorPDF(string message,string title)
        {

            if (MessageBox.Show(
                   message,
                 title,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error) == DialogResult.OK)
            {
                ClearCheckBoxAndPath();
            }


        }
        void ConvertPathToPDF()
        {
            ClearCheckBoxAndPath();
             firstPath = ChoiceFileToDelete();
            if (string.IsNullOrEmpty(firstPath))
            {
                return;
            }

            lblNameFirsFile.Text = Path.GetFileNameWithoutExtension(firstPath);
            lblFileSelectd.Text = "PDF Selected";

            try
            {
                using (PdfDocument pdf = PdfReader.Open(firstPath, PdfDocumentOpenMode.Import))
                {
                    AddPdfToCheckboxList(pdf);
                    lblTotalFilesBeforeDelete.Text = pdf.PageCount.ToString();
                }
            }
            catch (PdfReaderException)
            {


                MessageBoxShowErrorPDF("The selected PDF file is corrupted or cannot be opened.", "Invalid PDF");
            }
            catch (IOException)
            {
           
              MessageBoxShowErrorPDF("An error occurred while reading the file.", "File Error");
            }
            catch (Exception ex)
            {
          

                      MessageBoxShowErrorPDF(ex.Message, "Unexpected Error");
            }


        }
        private void btnFirstFile_Click(object sender, EventArgs e)
        {
            ConvertPathToPDF();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        string GetPathSavePdf()
        {
            string path="";
            using (SaveFileDialog saveFile = new SaveFileDialog())
            {

                saveFile.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFile.Title = "Save as PDF";
                saveFile.DefaultExt = "pdf";
                saveFile.AddExtension = true;

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    path = saveFile.FileName;

                    txtOutFolder.Text = path;
                }
            }
            return path;

        }

        void SavePageOfPdf()
        {

            using (PdfDocument pdfDocument = PdfReader.Open(firstPath, PdfDocumentOpenMode.Import))
            {
                using (PdfDocument savePDF = new PdfDocument())
                {
                    progressBar1.Minimum = 0;
                    progressBar1.Value = 0;
                    progressBar1.Maximum = pdfDocument.PageCount;
                    for (int i = 0; i < pdfDocument.PageCount; i++)
                    {

                        if (!checkedListBox1.GetItemChecked(i))
                        {

                            savePDF.AddPage(pdfDocument.Pages[i]);
                        }
                        progressBar1.Value++;

                    }

                    lblTotalPagesAfterDelete.Text = savePDF.PageCount.ToString();
                    savePDF.Save(pathOfSave);
                }
            }

        }
        
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
           pathOfSave = GetPathSavePdf();
             IsPathFull = IsPathChoose();
            btnDeletePage.Enabled = IsPathFull;

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            
            if (index != -1)
            {
                checkedListBox1.SetItemChecked(index,true);
             
            }
           
        }
        bool IsPathChoose()
        {
            if (!string.IsNullOrWhiteSpace(firstPath) && !string.IsNullOrWhiteSpace(txtOutFolder.Text))
            {

                return true;
            }


            return false;

        }


        void StartDeletePages()
        {
            int totalPages = checkedListBox1.Items.Count;
            int pagesToDelete = checkedListBox1.CheckedItems.Count;

            int remainingPages = totalPages - pagesToDelete;

            if (remainingPages <= 0)
            {
                errorProvider1.SetError(
                    checkedListBox1,
                    "Cannot delete all pages. A PDF document must contain at least one page."
                );

                return;
            }

            SavePageOfPdf();
            MessageDeleteSuccessfully();
        }
       
            void MessageDeleteSuccessfully()
            {
              if(MessageBox.Show(
                    "Pages have been deleted successfully.",
                    "Operation Completed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                ) == DialogResult.OK)
            {

                ClearAllItem();
            }
            }
            


        
        private void btnDeletePage_Click(object sender, EventArgs e)
        {
            StartDeletePages();
         
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int count = checkedListBox1.CheckedItems.Count;
            if (e.NewValue == CheckState.Checked)
                count++;
            else
                count--;

            lblPageDelete.Text = count.ToString();
           
        }

        void ClearAllItem()
        {

            ClearCheckBoxAndPath();
            txtOutFolder.Clear();
            pathOfSave = "";
            progressBar1.Value = 0;
            lblPageDelete.Text = lblTotalFilesBeforeDelete.Text = lblTotalPagesAfterDelete.Text = "--";
            btnDeletePage.Enabled = false;

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAllItem();
        }
    }
}
