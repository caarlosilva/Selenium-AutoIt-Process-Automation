using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class TessOCR : Form
    {
        public TessOCR()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Wrap the creation of the OpenFileDialog instance in a using statement,
            // rather than manually calling the Dispose method to ensure proper disposal
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pbImage.Image = new Bitmap(dlg.FileName);
                    txtPath.Text = dlg.FileName;
                    txtTextExtracted.Text = OCR.TesseractOCR.GetTextFromImage(dlg.FileName);
                }
            }
        }

        private void TessOCR_FormClosed(object sender, FormClosedEventArgs e)
        {
            var of = Application.OpenForms;
            foreach (Form f in of)
            {
                if (f.Name.Equals("MainForm")){
                    f.Show();
                }
                   
            }
            
        }
    }
}
