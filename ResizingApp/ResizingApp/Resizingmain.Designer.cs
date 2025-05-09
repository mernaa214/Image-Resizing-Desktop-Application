using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ResizingApp //name of project
{

    partial class app
    {
        ///  Required designer variable.
        private System.ComponentModel.IContainer components = null;
    
        ///  Clean up any resources being used.
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        ///  Required method for Designer support - do not modify the contents of this method with the code editor.
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(app));
            resizeButton = new Button();
            widthlabel = new Label();
            heightlabel = new Label();
            toplabel = new Label();
            widthTextBox = new TextBox();
            pictureBox = new RoundedPictureBox();
            browseButton = new Button();
            logolabel = new Label();
            heightTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // resizeButton
            // 
            resizeButton.BackColor = Color.Honeydew;
            resizeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            resizeButton.ForeColor = SystemColors.ActiveCaptionText;
            resizeButton.Location = new Point(294, 558);
            resizeButton.Name = "resizeButton";
            resizeButton.Size = new Size(98, 49);
            resizeButton.TabIndex = 8;
            resizeButton.Text = "RESIZE";
            resizeButton.UseVisualStyleBackColor = false;
            resizeButton.Click += resizeButton_Click;
            // 
            // widthlabel
            // 
            widthlabel.AutoSize = true;
            widthlabel.BackColor = Color.Transparent;
            widthlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            widthlabel.ForeColor = Color.Honeydew;
            widthlabel.Location = new Point(199, 303);
            widthlabel.Name = "widthlabel";
            widthlabel.Size = new Size(74, 22);
            widthlabel.TabIndex = 12;
            widthlabel.Text = "WIDTH";
            // 
            // heightlabel
            // 
            heightlabel.AutoSize = true;
            heightlabel.BackColor = Color.Transparent;
            heightlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            heightlabel.ForeColor = Color.Honeydew;
            heightlabel.Location = new Point(199, 418);
            heightlabel.Name = "heightlabel";
            heightlabel.Size = new Size(88, 23);
            heightlabel.TabIndex = 13;
            heightlabel.Text = "HEIGHT";
            // 
            // toplabel
            // 
            toplabel.AutoSize = true;
            toplabel.BackColor = Color.Transparent;
            toplabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            toplabel.ForeColor = Color.Honeydew;
            toplabel.Location = new Point(205, 21);
            toplabel.Name = "toplabel";
            toplabel.Size = new Size(292, 32);
            toplabel.TabIndex = 1;
            toplabel.Text = "RESIZE YOUR IMAGE";
            // 
            // widthTextBox
            // 
            widthTextBox.BackColor = Color.Honeydew;
            widthTextBox.Location = new Point(201, 328);
            widthTextBox.Multiline = true;
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(296, 40);
            widthTextBox.TabIndex = 6;
            
            // pictureBox
            pictureBox.BackColor = Color.Honeydew;
            pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox.CornerRadius = 20;
            pictureBox.Location = new Point(227, 69);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(238, 179);
            pictureBox.TabIndex = 20;
            pictureBox.TabStop = false;
             
            // browseButton
            browseButton.BackColor = Color.Honeydew;
            browseButton.BackgroundImage = Properties.Resources.diagonal_arrows;
            browseButton.BackgroundImageLayout = ImageLayout.Zoom;
            browseButton.FlatAppearance.BorderSize = 0;
            browseButton.FlatStyle = FlatStyle.Flat;
            browseButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            browseButton.ForeColor = Color.Black;
            browseButton.Location = new Point(301, 114);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(86, 62);
            browseButton.TabIndex = 21;
            browseButton.UseVisualStyleBackColor = false;
            browseButton.Click += browseButton_Click;
            
            // logolabel
            logolabel.AutoSize = true;
            logolabel.BackColor = Color.Honeydew;
            logolabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6F);
            logolabel.ForeColor = SystemColors.ControlDarkDark;
            logolabel.Location = new Point(294, 191);
            logolabel.Name = "logolabel";
            logolabel.Size = new Size(105, 11);
            logolabel.TabIndex = 22;
            logolabel.Text = "SELECT AN IMAGE  ";
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(199, 444);
            heightTextBox.Multiline = true;
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(298, 42);
            heightTextBox.TabIndex = 23;
            // 
            // app
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 182, 149);
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(691, 724);
            Controls.Add(heightTextBox);
            Controls.Add(logolabel);
            Controls.Add(browseButton);
            Controls.Add(pictureBox);
            Controls.Add(toplabel);
            Controls.Add(heightlabel);
            Controls.Add(widthlabel);
            Controls.Add(resizeButton);
            Controls.Add(widthTextBox);
            Name = "app";
            Text = "Resizing App";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button resizeButton;
        private Label widthlabel;
        private Label heightlabel;
        private Label toplabel;
        private TextBox widthTextBox;
        private RoundedPictureBox pictureBox;
        private Button browseButton;
        private Label logolabel;
        private TextBox heightTextBox;
    }


}
