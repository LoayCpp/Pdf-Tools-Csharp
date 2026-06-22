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
        private SplitPdfControl splitControl;
        private MergePdfControl merge;
        private UserControl currentControl;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                  ControlStyles.UserPaint |
                  ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            splitControl = new SplitPdfControl();
            merge = new MergePdfControl();
            merge.Dock = DockStyle.Fill;
            splitControl.Dock = DockStyle.Fill;

            PanalForm.Controls.Add(splitControl);
            PanalForm.Controls.Add(merge);
            merge.Hide();
            currentControl = splitControl;

        }
      
     

       
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new frmAboutMe();
            frm.ShowDialog();
        }
        void ShowAndHideUserControl(UserControl userControl)
        {
            if (userControl == currentControl)
            {

                return;
            }
            foreach (UserControl c in PanalForm.Controls)
                c.Hide();

            userControl.Show();
            userControl.BringToFront();

            currentControl = userControl;



        }
       
        private void btnSplit_Click(object sender, EventArgs e)
        {
            
            ShowAndHideUserControl(splitControl);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            ShowAndHideUserControl(merge);
        }

        
    }
}
