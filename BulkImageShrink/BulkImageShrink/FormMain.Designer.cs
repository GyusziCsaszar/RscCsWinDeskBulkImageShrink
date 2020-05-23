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
            this.btnImgInfBarPp = new System.Windows.Forms.Button();
            this.lblImgInfSize = new System.Windows.Forms.Label();
            this.btnImgInfBarMm = new System.Windows.Forms.Button();
            this.btnFolderOfImage = new System.Windows.Forms.Button();
            this.chbAutoOrientation = new System.Windows.Forms.CheckBox();
            this.tbRen = new System.Windows.Forms.TextBox();
            this.lblRenInf = new System.Windows.Forms.Label();
            this.chbRen = new System.Windows.Forms.CheckBox();
            this.chbExifAsTx = new System.Windows.Forms.CheckBox();
            this.chbExifOnly = new System.Windows.Forms.CheckBox();
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
            this.btnOpenFile.Size = new System.Drawing.Size(104, 23);
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
            this.btnOpenFolder.Location = new System.Drawing.Point(768, 12);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(112, 23);
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
            this.btnSaveFile.Location = new System.Drawing.Point(537, 223);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(229, 23);
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
            this.tbTrgImgWidth.TabIndex = 11;
            this.tbTrgImgWidth.Text = "360";
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
            this.tbTrgImgHeight.TabIndex = 13;
            this.tbTrgImgHeight.Text = "480";
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
            this.lblExifData.Location = new System.Drawing.Point(537, 254);
            this.lblExifData.Name = "lblExifData";
            this.lblExifData.Size = new System.Drawing.Size(73, 23);
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
            this.lbExifData.Location = new System.Drawing.Point(537, 280);
            this.lbExifData.Name = "lbExifData";
            this.lbExifData.Size = new System.Drawing.Size(343, 249);
            this.lbExifData.TabIndex = 9;
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
            this.chbPortrait.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbPortrait.Location = new System.Drawing.Point(772, 168);
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
            this.btnCpyExifToClpBrd.Location = new System.Drawing.Point(769, 254);
            this.btnCpyExifToClpBrd.Name = "btnCpyExifToClpBrd";
            this.btnCpyExifToClpBrd.Size = new System.Drawing.Size(112, 23);
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
            this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
            // 
            // btnImgInfBarPp
            // 
            this.btnImgInfBarPp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImgInfBarPp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImgInfBarPp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnImgInfBarPp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnImgInfBarPp.Location = new System.Drawing.Point(537, 543);
            this.btnImgInfBarPp.Name = "btnImgInfBarPp";
            this.btnImgInfBarPp.Size = new System.Drawing.Size(32, 23);
            this.btnImgInfBarPp.TabIndex = 19;
            this.btnImgInfBarPp.Text = "+";
            this.btnImgInfBarPp.UseVisualStyleBackColor = true;
            this.btnImgInfBarPp.Click += new System.EventHandler(this.btnImgInfBarPp_Click);
            // 
            // lblImgInfSize
            // 
            this.lblImgInfSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImgInfSize.AutoSize = true;
            this.lblImgInfSize.Location = new System.Drawing.Point(616, 549);
            this.lblImgInfSize.Name = "lblImgInfSize";
            this.lblImgInfSize.Size = new System.Drawing.Size(153, 13);
            this.lblImgInfSize.TabIndex = 20;
            this.lblImgInfSize.Text = "<-- Font Size of Image Info Bar!";
            // 
            // btnImgInfBarMm
            // 
            this.btnImgInfBarMm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImgInfBarMm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImgInfBarMm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnImgInfBarMm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnImgInfBarMm.Location = new System.Drawing.Point(578, 543);
            this.btnImgInfBarMm.Name = "btnImgInfBarMm";
            this.btnImgInfBarMm.Size = new System.Drawing.Size(32, 23);
            this.btnImgInfBarMm.TabIndex = 21;
            this.btnImgInfBarMm.Text = "-";
            this.btnImgInfBarMm.UseVisualStyleBackColor = true;
            this.btnImgInfBarMm.Click += new System.EventHandler(this.btnImgInfBarMm_Click);
            // 
            // btnFolderOfImage
            // 
            this.btnFolderOfImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFolderOfImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderOfImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFolderOfImage.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnFolderOfImage.Location = new System.Drawing.Point(642, 12);
            this.btnFolderOfImage.Name = "btnFolderOfImage";
            this.btnFolderOfImage.Size = new System.Drawing.Size(124, 23);
            this.btnFolderOfImage.TabIndex = 22;
            this.btnFolderOfImage.Text = "Folder of Image";
            this.btnFolderOfImage.UseVisualStyleBackColor = true;
            this.btnFolderOfImage.Click += new System.EventHandler(this.btnFolderOfImage_Click);
            // 
            // chbAutoOrientation
            // 
            this.chbAutoOrientation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbAutoOrientation.AutoSize = true;
            this.chbAutoOrientation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbAutoOrientation.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chbAutoOrientation.Location = new System.Drawing.Point(772, 227);
            this.chbAutoOrientation.Name = "chbAutoOrientation";
            this.chbAutoOrientation.Size = new System.Drawing.Size(102, 17);
            this.chbAutoOrientation.TabIndex = 23;
            this.chbAutoOrientation.Text = "Auto Orientation";
            this.chbAutoOrientation.UseVisualStyleBackColor = true;
            this.chbAutoOrientation.CheckedChanged += new System.EventHandler(this.chbAutoOrientation_CheckedChanged);
            // 
            // tbRen
            // 
            this.tbRen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRen.Location = new System.Drawing.Point(597, 197);
            this.tbRen.Name = "tbRen";
            this.tbRen.Size = new System.Drawing.Size(139, 20);
            this.tbRen.TabIndex = 25;
            this.tbRen.Text = "%DT - %MK %ML (%FN)";
            this.tbRen.TextChanged += new System.EventHandler(this.tbRen_TextChanged);
            // 
            // lblRenInf
            // 
            this.lblRenInf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRenInf.BackColor = System.Drawing.SystemColors.Info;
            this.lblRenInf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRenInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRenInf.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblRenInf.Location = new System.Drawing.Point(748, 197);
            this.lblRenInf.Name = "lblRenInf";
            this.lblRenInf.Size = new System.Drawing.Size(133, 20);
            this.lblRenInf.TabIndex = 26;
            this.lblRenInf.Text = "%FN, %DT, %MK, %ML";
            this.lblRenInf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbRen
            // 
            this.chbRen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbRen.AutoSize = true;
            this.chbRen.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chbRen.Location = new System.Drawing.Point(539, 199);
            this.chbRen.Name = "chbRen";
            this.chbRen.Size = new System.Drawing.Size(52, 17);
            this.chbRen.TabIndex = 27;
            this.chbRen.Text = "REN:";
            this.chbRen.UseVisualStyleBackColor = true;
            this.chbRen.CheckedChanged += new System.EventHandler(this.chbRen_CheckedChanged);
            // 
            // chbExifAsTx
            // 
            this.chbExifAsTx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbExifAsTx.AutoSize = true;
            this.chbExifAsTx.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chbExifAsTx.Location = new System.Drawing.Point(619, 258);
            this.chbExifAsTx.Name = "chbExifAsTx";
            this.chbExifAsTx.Size = new System.Drawing.Size(64, 17);
            this.chbExifAsTx.TabIndex = 28;
            this.chbExifAsTx.Text = "as .TXT";
            this.chbExifAsTx.UseVisualStyleBackColor = true;
            this.chbExifAsTx.CheckedChanged += new System.EventHandler(this.chbExifAsTx_CheckedChanged);
            // 
            // chbExifOnly
            // 
            this.chbExifOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbExifOnly.AutoSize = true;
            this.chbExifOnly.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chbExifOnly.Location = new System.Drawing.Point(688, 258);
            this.chbExifOnly.Name = "chbExifOnly";
            this.chbExifOnly.Size = new System.Drawing.Size(71, 17);
            this.chbExifOnly.TabIndex = 29;
            this.chbExifOnly.Text = "EXIF only";
            this.chbExifOnly.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(892, 573);
            this.Controls.Add(this.chbExifOnly);
            this.Controls.Add(this.chbExifAsTx);
            this.Controls.Add(this.chbRen);
            this.Controls.Add(this.lblRenInf);
            this.Controls.Add(this.tbRen);
            this.Controls.Add(this.chbAutoOrientation);
            this.Controls.Add(this.btnFolderOfImage);
            this.Controls.Add(this.btnImgInfBarMm);
            this.Controls.Add(this.lblImgInfSize);
            this.Controls.Add(this.btnImgInfBarPp);
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
        private System.Windows.Forms.Button btnImgInfBarPp;
        private System.Windows.Forms.Label lblImgInfSize;
        private System.Windows.Forms.Button btnImgInfBarMm;
        private System.Windows.Forms.Button btnFolderOfImage;
        private System.Windows.Forms.CheckBox chbAutoOrientation;
        private System.Windows.Forms.TextBox tbRen;
        private System.Windows.Forms.Label lblRenInf;
        private System.Windows.Forms.CheckBox chbRen;
        private System.Windows.Forms.CheckBox chbExifAsTx;
        private System.Windows.Forms.CheckBox chbExifOnly;
    }
}

