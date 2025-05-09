using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ResizingApp
{
    public partial class ResizedImageForm : Form
    {
        public ResizedImageForm()
        {
            InitializeComponent();
        }

        private void downloadbutton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp";
                saveFileDialog.Title = "Save Image";
                saveFileDialog.FileName = "picture"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImageFormat imageFormat = ImageFormat.Jpeg; // Default to JPEG
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 2:
                            imageFormat = ImageFormat.Png;
                            break;
                        case 3:
                            imageFormat = ImageFormat.Bmp;
                            break;
                    }

                    // Save the image to the selected file path
                    resizedPictureBox.Image.Save(saveFileDialog.FileName, imageFormat);
                }   
                else
                {
                        MessageBox.Show("No image to download.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

}
    }