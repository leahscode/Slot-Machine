namespace SlotMachineLS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fruitImageList = new System.Windows.Forms.ImageList(this.components);
            this.fruitImage1 = new System.Windows.Forms.PictureBox();
            this.fruitImage2 = new System.Windows.Forms.PictureBox();
            this.fruitImage3 = new System.Windows.Forms.PictureBox();
            this.insertLabel = new System.Windows.Forms.Label();
            this.insertTextBox = new System.Windows.Forms.TextBox();
            this.spinButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fruitImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitImage3)).BeginInit();
            this.SuspendLayout();
            // 
            // fruitImageList
            // 
            this.fruitImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fruitImageList.ImageStream")));
            this.fruitImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.fruitImageList.Images.SetKeyName(0, "Apple.bmp");
            this.fruitImageList.Images.SetKeyName(1, "Banana.bmp");
            this.fruitImageList.Images.SetKeyName(2, "Cherries.bmp");
            this.fruitImageList.Images.SetKeyName(3, "Grapes.bmp");
            this.fruitImageList.Images.SetKeyName(4, "Lemon.bmp");
            this.fruitImageList.Images.SetKeyName(5, "Lime.bmp");
            this.fruitImageList.Images.SetKeyName(6, "Orange.bmp");
            this.fruitImageList.Images.SetKeyName(7, "Pear.bmp");
            this.fruitImageList.Images.SetKeyName(8, "Strawberry.bmp");
            this.fruitImageList.Images.SetKeyName(9, "Watermelon.bmp");
            // 
            // fruitImage1
            // 
            this.fruitImage1.Location = new System.Drawing.Point(50, 50);
            this.fruitImage1.Name = "fruitImage1";
            this.fruitImage1.Size = new System.Drawing.Size(128, 128);
            this.fruitImage1.TabIndex = 0;
            this.fruitImage1.TabStop = false;
            // 
            // fruitImage2
            // 
            this.fruitImage2.Location = new System.Drawing.Point(198, 50);
            this.fruitImage2.Name = "fruitImage2";
            this.fruitImage2.Size = new System.Drawing.Size(128, 128);
            this.fruitImage2.TabIndex = 1;
            this.fruitImage2.TabStop = false;
            // 
            // fruitImage3
            // 
            this.fruitImage3.Location = new System.Drawing.Point(346, 50);
            this.fruitImage3.Name = "fruitImage3";
            this.fruitImage3.Size = new System.Drawing.Size(128, 128);
            this.fruitImage3.TabIndex = 2;
            this.fruitImage3.TabStop = false;
            // 
            // insertLabel
            // 
            this.insertLabel.AutoSize = true;
            this.insertLabel.Location = new System.Drawing.Point(160, 219);
            this.insertLabel.Name = "insertLabel";
            this.insertLabel.Size = new System.Drawing.Size(96, 13);
            this.insertLabel.TabIndex = 3;
            this.insertLabel.Text = "Amount Inserted: $";
            // 
            // insertTextBox
            // 
            this.insertTextBox.Location = new System.Drawing.Point(262, 216);
            this.insertTextBox.Name = "insertTextBox";
            this.insertTextBox.Size = new System.Drawing.Size(87, 20);
            this.insertTextBox.TabIndex = 4;
            // 
            // spinButton
            // 
            this.spinButton.Location = new System.Drawing.Point(163, 264);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(75, 23);
            this.spinButton.TabIndex = 5;
            this.spinButton.Text = "S&pin";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(274, 264);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.spinButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(539, 331);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.insertTextBox);
            this.Controls.Add(this.insertLabel);
            this.Controls.Add(this.fruitImage3);
            this.Controls.Add(this.fruitImage2);
            this.Controls.Add(this.fruitImage1);
            this.Name = "Form1";
            this.Text = "Slot Machine LS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fruitImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitImage3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList fruitImageList;
        private System.Windows.Forms.PictureBox fruitImage1;
        private System.Windows.Forms.PictureBox fruitImage2;
        private System.Windows.Forms.PictureBox fruitImage3;
        private System.Windows.Forms.Label insertLabel;
        private System.Windows.Forms.TextBox insertTextBox;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Button exitButton;
    }
}

