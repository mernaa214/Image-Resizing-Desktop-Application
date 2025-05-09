using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ResizingApp
{
    partial class ResizedImageForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        public void InitializeComponent()
        {
            resizedPictureBox = new PictureBox();
            downloadbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)resizedPictureBox).BeginInit();
            SuspendLayout();
            // 
            // resizedPictureBox
            // 
            resizedPictureBox.BackgroundImageLayout = ImageLayout.None;
            resizedPictureBox.Location = new Point(0, 0);
            resizedPictureBox.Name = "resizedPictureBox";
            resizedPictureBox.Size = new Size(744, 689);
            resizedPictureBox.TabIndex = 0;
            resizedPictureBox.TabStop = false;
            // 
            // downloadbutton
            // 
            downloadbutton.BackColor = Color.DarkSalmon;
            downloadbutton.FlatAppearance.BorderSize = 0;
            downloadbutton.FlatStyle = FlatStyle.Flat;
            downloadbutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            downloadbutton.Location = new Point(293, 695);
            downloadbutton.Name = "downloadbutton";
            downloadbutton.Size = new Size(153, 35);
            downloadbutton.TabIndex = 1;
            downloadbutton.Text = "DOWNLOAD";
            downloadbutton.UseVisualStyleBackColor = false;
            downloadbutton.Click += downloadbutton_Click;
            // 
            // ResizedImageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 742);
            Controls.Add(downloadbutton);
            Controls.Add(resizedPictureBox);
            Name = "ResizedImageForm";
            Text = "Resized Image";
            ((System.ComponentModel.ISupportInitialize)resizedPictureBox).EndInit();
            ResumeLayout(false);
        }

        public void SetImage(Bitmap image)//public is required that form1.cs can access on it
        {
            resizedPictureBox.Image = image;
            resizedPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        #endregion

        public PictureBox resizedPictureBox;
        private Button downloadbutton;
    }
}