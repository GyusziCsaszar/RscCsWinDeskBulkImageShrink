namespace BulkImageShrink
{
    partial class FormMain
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
            this.lblPath = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.pbWorkplace = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.tmrSaveFile = new System.Windows.Forms.Timer(this.components);
            this.lblTrgImgSize = new System.Windows.Forms.Label();
            this.lblTrgImgWidth = new System.Windows.Forms.Label();
            this.tbTrgImgWidth = new System.Windows.Forms.TextBox();
            this.lblTrgImgHeight = new System.Windows.Forms.Label();
            this.tbTrgImgHeight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWorkplace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 9);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(101, 13);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Path (File or Folder):";
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPath.Location = new System.Drawing.Point(119, 6);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(600, 20);
            this.tbPath.TabIndex = 1;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Location = new System.Drawing.Point(736, 4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(65, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Image...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolder.Location = new System.Drawing.Point(815, 4);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(65, 23);
            this.btnOpenFolder.TabIndex = 3;
            this.btnOpenFolder.Text = "Folder...";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            // 
            // pbWorkplace
            // 
            this.pbWorkplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbWorkplace.BackColor = System.Drawing.SystemColors.Info;
            this.pbWorkplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWorkplace.Location = new System.Drawing.Point(15, 71);
            this.pbWorkplace.Name = "pbWorkplace";
            this.pbWorkplace.Size = new System.Drawing.Size(704, 506);
            this.pbWorkplace.TabIndex = 4;
            this.pbWorkplace.TabStop = false;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Black;
            this.pbImage.Location = new System.Drawing.Point(26, 83);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(240, 400);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 5;
            this.pbImage.TabStop = false;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFile.Location = new System.Drawing.Point(736, 71);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(144, 23);
            this.btnSaveFile.TabIndex = 6;
            this.btnSaveFile.Text = "Save Image As...";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // tmrSaveFile
            // 
            this.tmrSaveFile.Interval = 250;
            this.tmrSaveFile.Tick += new System.EventHandler(this.tmrSaveFile_Tick);
            // 
            // lblTrgImgSize
            // 
            this.lblTrgImgSize.AutoSize = true;
            this.lblTrgImgSize.Location = new System.Drawing.Point(12, 41);
            this.lblTrgImgSize.Name = "lblTrgImgSize";
            this.lblTrgImgSize.Size = new System.Drawing.Size(96, 13);
            this.lblTrgImgSize.TabIndex = 7;
            this.lblTrgImgSize.Text = "Target Image Size:";
            // 
            // lblTrgImgWidth
            // 
            this.lblTrgImgWidth.AutoSize = true;
            this.lblTrgImgWidth.Location = new System.Drawing.Point(109, 41);
            this.lblTrgImgWidth.Name = "lblTrgImgWidth";
            this.lblTrgImgWidth.Size = new System.Drawing.Size(38, 13);
            this.lblTrgImgWidth.TabIndex = 8;
            this.lblTrgImgWidth.Text = "Width:";
            // 
            // tbTrgImgWidth
            // 
            this.tbTrgImgWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTrgImgWidth.Location = new System.Drawing.Point(149, 38);
            this.tbTrgImgWidth.Name = "tbTrgImgWidth";
            this.tbTrgImgWidth.Size = new System.Drawing.Size(52, 20);
            this.tbTrgImgWidth.TabIndex = 9;
            this.tbTrgImgWidth.Text = "240";
            this.tbTrgImgWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTrgImgHeight
            // 
            this.lblTrgImgHeight.AutoSize = true;
            this.lblTrgImgHeight.Location = new System.Drawing.Point(210, 41);
            this.lblTrgImgHeight.Name = "lblTrgImgHeight";
            this.lblTrgImgHeight.Size = new System.Drawing.Size(41, 13);
            this.lblTrgImgHeight.TabIndex = 10;
            this.lblTrgImgHeight.Text = "Height:";
            // 
            // tbTrgImgHeight
            // 
            this.tbTrgImgHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTrgImgHeight.Location = new System.Drawing.Point(255, 38);
            this.tbTrgImgHeight.Name = "tbTrgImgHeight";
            this.tbTrgImgHeight.Size = new System.Drawing.Size(52, 20);
            this.tbTrgImgHeight.TabIndex = 11;
            this.tbTrgImgHeight.Text = "400";
            this.tbTrgImgHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(892, 573);
            this.Controls.Add(this.tbTrgImgHeight);
            this.Controls.Add(this.lblTrgImgHeight);
            this.Controls.Add(this.tbTrgImgWidth);
            this.Controls.Add(this.lblTrgImgWidth);
            this.Controls.Add(this.lblTrgImgSize);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.pbWorkplace);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.lblPath);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbWorkplace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.PictureBox pbWorkplace;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Timer tmrSaveFile;
        private System.Windows.Forms.Label lblTrgImgSize;
        private System.Windows.Forms.Label lblTrgImgWidth;
        private System.Windows.Forms.TextBox tbTrgImgWidth;
        private System.Windows.Forms.Label lblTrgImgHeight;
        private System.Windows.Forms.TextBox tbTrgImgHeight;
    }
}

