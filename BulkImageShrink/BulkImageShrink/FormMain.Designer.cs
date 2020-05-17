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
            this.lblExifData = new System.Windows.Forms.Label();
            this.lbExifData = new System.Windows.Forms.ListBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblPathValue = new System.Windows.Forms.Label();
            this.chbPortrait = new System.Windows.Forms.CheckBox();
            this.btnCpyExifToClpBrd = new System.Windows.Forms.Button();
            this.tmrProcessFolder = new System.Windows.Forms.Timer(this.components);
            this.btnPauseResume = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWorkplace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpenFile.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnOpenFile.Location = new System.Drawing.Point(537, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(168, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Image...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpenFolder.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnOpenFolder.Location = new System.Drawing.Point(712, 12);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(168, 23);
            this.btnOpenFolder.TabIndex = 3;
            this.btnOpenFolder.Text = "Folder...";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // pbWorkplace
            // 
            this.pbWorkplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbWorkplace.BackColor = System.Drawing.SystemColors.Info;
            this.pbWorkplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWorkplace.Location = new System.Drawing.Point(15, 12);
            this.pbWorkplace.Name = "pbWorkplace";
            this.pbWorkplace.Size = new System.Drawing.Size(503, 565);
            this.pbWorkplace.TabIndex = 4;
            this.pbWorkplace.TabStop = false;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Black;
            this.pbImage.Location = new System.Drawing.Point(26, 22);
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
            this.btnSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveFile.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveFile.Location = new System.Drawing.Point(537, 198);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(343, 23);
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
            this.lblTrgImgSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrgImgSize.BackColor = System.Drawing.Color.Bisque;
            this.lblTrgImgSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTrgImgSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrgImgSize.ForeColor = System.Drawing.Color.Black;
            this.lblTrgImgSize.Location = new System.Drawing.Point(537, 137);
            this.lblTrgImgSize.Name = "lblTrgImgSize";
            this.lblTrgImgSize.Size = new System.Drawing.Size(229, 23);
            this.lblTrgImgSize.TabIndex = 7;
            this.lblTrgImgSize.Text = "Target Image";
            this.lblTrgImgSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrgImgWidth
            // 
            this.lblTrgImgWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrgImgWidth.AutoSize = true;
            this.lblTrgImgWidth.Location = new System.Drawing.Point(538, 170);
            this.lblTrgImgWidth.Name = "lblTrgImgWidth";
            this.lblTrgImgWidth.Size = new System.Drawing.Size(38, 13);
            this.lblTrgImgWidth.TabIndex = 8;
            this.lblTrgImgWidth.Text = "Width:";
            // 
            // tbTrgImgWidth
            // 
            this.tbTrgImgWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTrgImgWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTrgImgWidth.Location = new System.Drawing.Point(578, 167);
            this.tbTrgImgWidth.Name = "tbTrgImgWidth";
            this.tbTrgImgWidth.Size = new System.Drawing.Size(52, 20);
            this.tbTrgImgWidth.TabIndex = 9;
            this.tbTrgImgWidth.Text = "240";
            this.tbTrgImgWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTrgImgWidth.TextChanged += new System.EventHandler(this.tbTrgImgWidth_TextChanged);
            // 
            // lblTrgImgHeight
            // 
            this.lblTrgImgHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrgImgHeight.AutoSize = true;
            this.lblTrgImgHeight.Location = new System.Drawing.Point(639, 170);
            this.lblTrgImgHeight.Name = "lblTrgImgHeight";
            this.lblTrgImgHeight.Size = new System.Drawing.Size(41, 13);
            this.lblTrgImgHeight.TabIndex = 10;
            this.lblTrgImgHeight.Text = "Height:";
            // 
            // tbTrgImgHeight
            // 
            this.tbTrgImgHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTrgImgHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTrgImgHeight.Location = new System.Drawing.Point(684, 167);
            this.tbTrgImgHeight.Name = "tbTrgImgHeight";
            this.tbTrgImgHeight.Size = new System.Drawing.Size(52, 20);
            this.tbTrgImgHeight.TabIndex = 11;
            this.tbTrgImgHeight.Text = "400";
            this.tbTrgImgHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTrgImgHeight.TextChanged += new System.EventHandler(this.tbTrgImgHeight_TextChanged);
            // 
            // lblExifData
            // 
            this.lblExifData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExifData.BackColor = System.Drawing.Color.Bisque;
            this.lblExifData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExifData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExifData.ForeColor = System.Drawing.Color.Black;
            this.lblExifData.Location = new System.Drawing.Point(537, 229);
            this.lblExifData.Name = "lblExifData";
            this.lblExifData.Size = new System.Drawing.Size(229, 23);
            this.lblExifData.TabIndex = 12;
            this.lblExifData.Text = "EXIF data";
            this.lblExifData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbExifData
            // 
            this.lbExifData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbExifData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbExifData.FormattingEnabled = true;
            this.lbExifData.HorizontalScrollbar = true;
            this.lbExifData.Location = new System.Drawing.Point(537, 254);
            this.lbExifData.Name = "lbExifData";
            this.lbExifData.Size = new System.Drawing.Size(343, 314);
            this.lbExifData.TabIndex = 13;
            // 
            // lblImage
            // 
            this.lblImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImage.BackColor = System.Drawing.Color.Bisque;
            this.lblImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImage.ForeColor = System.Drawing.Color.Black;
            this.lblImage.Location = new System.Drawing.Point(26, 544);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(479, 23);
            this.lblImage.TabIndex = 14;
            this.lblImage.Text = "ATTN: Keep image view visible during processing!!!";
            this.lblImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPathValue
            // 
            this.lblPathValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPathValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPathValue.Location = new System.Drawing.Point(537, 42);
            this.lblPathValue.Name = "lblPathValue";
            this.lblPathValue.Size = new System.Drawing.Size(343, 86);
            this.lblPathValue.TabIndex = 15;
            this.lblPathValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chbPortrait
            // 
            this.chbPortrait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbPortrait.AutoSize = true;
            this.chbPortrait.Checked = true;
            this.chbPortrait.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPortrait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbPortrait.Location = new System.Drawing.Point(770, 168);
            this.chbPortrait.Name = "chbPortrait";
            this.chbPortrait.Size = new System.Drawing.Size(110, 17);
            this.chbPortrait.TabIndex = 16;
            this.chbPortrait.Text = "Portrait Orientation";
            this.chbPortrait.UseVisualStyleBackColor = true;
            this.chbPortrait.CheckedChanged += new System.EventHandler(this.chbPortrait_CheckedChanged);
            // 
            // btnCpyExifToClpBrd
            // 
            this.btnCpyExifToClpBrd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCpyExifToClpBrd.BackColor = System.Drawing.SystemColors.Window;
            this.btnCpyExifToClpBrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCpyExifToClpBrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCpyExifToClpBrd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCpyExifToClpBrd.Location = new System.Drawing.Point(768, 229);
            this.btnCpyExifToClpBrd.Name = "btnCpyExifToClpBrd";
            this.btnCpyExifToClpBrd.Size = new System.Drawing.Size(111, 23);
            this.btnCpyExifToClpBrd.TabIndex = 17;
            this.btnCpyExifToClpBrd.Text = "Copy as Text";
            this.btnCpyExifToClpBrd.UseVisualStyleBackColor = false;
            this.btnCpyExifToClpBrd.Click += new System.EventHandler(this.btnCpyExifToClpBrd_Click);
            // 
            // tmrProcessFolder
            // 
            this.tmrProcessFolder.Interval = 500;
            this.tmrProcessFolder.Tick += new System.EventHandler(this.tmrProcessFolder_Tick);
            // 
            // btnPauseResume
            // 
            this.btnPauseResume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPauseResume.BackColor = System.Drawing.SystemColors.Window;
            this.btnPauseResume.Enabled = false;
            this.btnPauseResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPauseResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPauseResume.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnPauseResume.Location = new System.Drawing.Point(769, 137);
            this.btnPauseResume.Name = "btnPauseResume";
            this.btnPauseResume.Size = new System.Drawing.Size(111, 23);
            this.btnPauseResume.TabIndex = 18;
            this.btnPauseResume.Text = "PAUSE";
            this.btnPauseResume.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(892, 573);
            this.Controls.Add(this.btnPauseResume);
            this.Controls.Add(this.btnCpyExifToClpBrd);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.chbPortrait);
            this.Controls.Add(this.lblPathValue);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lbExifData);
            this.Controls.Add(this.lblExifData);
            this.Controls.Add(this.tbTrgImgHeight);
            this.Controls.Add(this.lblTrgImgHeight);
            this.Controls.Add(this.tbTrgImgWidth);
            this.Controls.Add(this.lblTrgImgWidth);
            this.Controls.Add(this.lblTrgImgSize);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.pbWorkplace);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnOpenFile);
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
        private System.Windows.Forms.Label lblExifData;
        private System.Windows.Forms.ListBox lbExifData;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblPathValue;
        private System.Windows.Forms.CheckBox chbPortrait;
        private System.Windows.Forms.Button btnCpyExifToClpBrd;
        private System.Windows.Forms.Timer tmrProcessFolder;
        private System.Windows.Forms.Button btnPauseResume;
    }
}

