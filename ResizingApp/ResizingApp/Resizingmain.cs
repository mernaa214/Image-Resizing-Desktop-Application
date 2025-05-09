using System.Windows.Forms;

namespace ResizingApp
{
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
        }

        void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image directly into the PictureBox
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                browseButton.Location = new Point(471, 229);
                browseButton.Width = 53;
                browseButton.Height = 42;
                logolabel.Visible = false;
            }
        }
        void resizeButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Please select an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int newWidth, newHeight;
            if (!int.TryParse(widthTextBox.Text, out newWidth) || newWidth <= 0)
            {
                MessageBox.Show("Please enter a valid width value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(heightTextBox.Text, out newHeight) || newHeight <= 0)
            {
                MessageBox.Show("Please enter a valid height value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bitmap originalImage = new Bitmap(pictureBox.Image);
            Bitmap resizedImage = new Bitmap(originalImage, newWidth, newHeight);
            // Create a new form to display the resized image
            using (ResizedImageForm resizedImageForm = new ResizedImageForm())
            {
                // Set the resized image to the PictureBox in the new form
                resizedImageForm.SetImage(resizedImage);
                // Show the new form
                resizedImageForm.ShowDialog();
            }
            // Dispose the original image
            originalImage.Dispose();
        }
    }
}
