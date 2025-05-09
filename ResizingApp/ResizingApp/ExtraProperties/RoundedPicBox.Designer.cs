namespace ResizingImg_
{
    partial class RoundedPicBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoundedPicBox));
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();

            // 
            // pictureBox
            // 
            pictureBox.Name = "pictureBox";
            resources.ApplyResources(pictureBox, "pictureBox");
            pictureBox.TabStop = false;
            // 
            // RoundedPicBox

            resources.ApplyResources(this, "$this");
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();

        }



        private PictureBox pictureBox;
    }
}
