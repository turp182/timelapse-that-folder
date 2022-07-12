namespace TimelapseThatFolder
{
    partial class formMain
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.workerImageLoader = new System.ComponentModel.BackgroundWorker();
            this.labelImagePosition = new System.Windows.Forms.Label();
            this.textBoxImagePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonCopyFilePath = new System.Windows.Forms.Button();
            this.buttonCopyImage = new System.Windows.Forms.Button();
            this.buttonCopyFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(1, 29);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1343, 675);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // workerImageLoader
            // 
            this.workerImageLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerImageLoader_DoWork);
            this.workerImageLoader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerImageLoader_RunWorkerCompleted);
            // 
            // labelImagePosition
            // 
            this.labelImagePosition.Location = new System.Drawing.Point(1247, 6);
            this.labelImagePosition.Name = "labelImagePosition";
            this.labelImagePosition.Size = new System.Drawing.Size(100, 23);
            this.labelImagePosition.TabIndex = 1;
            this.labelImagePosition.Text = "label1";
            // 
            // textBoxImagePath
            // 
            this.textBoxImagePath.Location = new System.Drawing.Point(79, 3);
            this.textBoxImagePath.Name = "textBoxImagePath";
            this.textBoxImagePath.Size = new System.Drawing.Size(618, 20);
            this.textBoxImagePath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image Path";
            // 
            // buttonForward
            // 
            this.buttonForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForward.Location = new System.Drawing.Point(703, 3);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(75, 21);
            this.buttonForward.TabIndex = 4;
            this.buttonForward.Text = "Forward";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonReverse
            // 
            this.buttonReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReverse.Location = new System.Drawing.Point(865, 3);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(75, 21);
            this.buttonReverse.TabIndex = 5;
            this.buttonReverse.Text = "Reverse";
            this.buttonReverse.UseVisualStyleBackColor = true;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(784, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 21);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonCopyFilePath
            // 
            this.buttonCopyFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopyFilePath.Location = new System.Drawing.Point(1053, 6);
            this.buttonCopyFilePath.Name = "buttonCopyFilePath";
            this.buttonCopyFilePath.Size = new System.Drawing.Size(75, 21);
            this.buttonCopyFilePath.TabIndex = 7;
            this.buttonCopyFilePath.Text = "Copy Path";
            this.buttonCopyFilePath.UseVisualStyleBackColor = true;
            this.buttonCopyFilePath.Click += new System.EventHandler(this.buttonCopyFilePath_Click);
            // 
            // buttonCopyImage
            // 
            this.buttonCopyImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopyImage.Location = new System.Drawing.Point(972, 5);
            this.buttonCopyImage.Name = "buttonCopyImage";
            this.buttonCopyImage.Size = new System.Drawing.Size(75, 21);
            this.buttonCopyImage.TabIndex = 8;
            this.buttonCopyImage.Text = "Copy Image";
            this.buttonCopyImage.UseVisualStyleBackColor = true;
            this.buttonCopyImage.Click += new System.EventHandler(this.buttonCopyImage_Click);
            // 
            // buttonCopyFile
            // 
            this.buttonCopyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopyFile.Location = new System.Drawing.Point(1134, 6);
            this.buttonCopyFile.Name = "buttonCopyFile";
            this.buttonCopyFile.Size = new System.Drawing.Size(75, 21);
            this.buttonCopyFile.TabIndex = 9;
            this.buttonCopyFile.Text = "Copy File";
            this.buttonCopyFile.UseVisualStyleBackColor = true;
            this.buttonCopyFile.Click += new System.EventHandler(this.buttonCopyFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 705);
            this.Controls.Add(this.buttonCopyFile);
            this.Controls.Add(this.buttonCopyImage);
            this.Controls.Add(this.buttonCopyFilePath);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxImagePath);
            this.Controls.Add(this.labelImagePosition);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Timelapse That Folder!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.ComponentModel.BackgroundWorker workerImageLoader;
        private System.Windows.Forms.Label labelImagePosition;
        private System.Windows.Forms.TextBox textBoxImagePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonCopyFilePath;
        private System.Windows.Forms.Button buttonCopyImage;
        private System.Windows.Forms.Button buttonCopyFile;
    }
}

