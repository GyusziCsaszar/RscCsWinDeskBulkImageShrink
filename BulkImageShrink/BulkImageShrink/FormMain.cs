using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BulkImageShrink
{
    public partial class FormMain : Form
    {

        protected const string csAPP_TITLE  = "Bulk Image Shrink v1.00";
        protected const string csAPP_NAME   = "BulkImageShrink";

        protected const string csDEF_OUTPUT_EXT = ".png";

        protected const string csBTNCAP_PAUSE = "PAUSE";
        protected const string csBTNCAP_RESUME = "RESUME";

        protected const int ciWIDTH_NORMAL  = 900;
        protected const int ciHEIGHT_NORMAL = 600;

        protected const string csATTN_KEEP_IMAGE_VISISBLE = "ATTN: Keep image view visible during processing!!!";

        protected string m_sPathToSaveImageTo = "";
        protected bool m_bFolderOperation = false;

        protected List<string> m_asImageFiles = null;
        protected int m_iImageFiles = 0;

        protected string m_sFolderToSaveImageTo = "";

        public FormMain()
        {
            InitializeComponent();

            StorageRegistry.m_sAppName  = csAPP_NAME;
            this.Text                   = csAPP_TITLE;
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            this.Left = /*Math.Max(0,*/ StorageRegistry.Read("Main_Left", this.Left); //);
            this.Top = Math.Max(0, StorageRegistry.Read("Main_Top", this.Top));
            this.Width = Math.Max(ciWIDTH_NORMAL, StorageRegistry.Read("Main_Width", this.Width));
            this.Height = Math.Max(ciHEIGHT_NORMAL, StorageRegistry.Read("Main_Height", this.Height));

            int iTrgIgmWidth  = StorageRegistry.Read("TargetImage_Width" , pbImage.Width );
            int iTrgIgmHeight = StorageRegistry.Read("TargetImage_Height", pbImage.Height);
            tbTrgImgWidth.Text = iTrgIgmWidth.ToString();
            tbTrgImgHeight.Text = iTrgIgmHeight.ToString();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (tmrProcessFolder.Enabled)
            {
                if (DialogResult.Yes != MessageBox.Show("Saving Images is in progress!\n\nDo you want to abort operation?", csAPP_TITLE, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
                {
                    e.Cancel = true;
                    return;
                }
            }

            /*if (this.Left >= 0)*/ StorageRegistry.Write("Main_Left", this.Left);
            if (this.Top >= 0) StorageRegistry.Write("Main_Top", this.Top);
            if (this.Width >= ciWIDTH_NORMAL) StorageRegistry.Write("Main_Width", this.Width);
            if (this.Height >= ciHEIGHT_NORMAL) StorageRegistry.Write("Main_Height", this.Height);
        }

        private void Clear()
        {
            pbImage.Image = null;

            lblPathValue.Text = "";

            lblImage.Text = csATTN_KEEP_IMAGE_VISISBLE;

            lbExifData.Items.Clear();

            chbPortrait.Checked = true;
          //SetOrientation(chbPortrait.Checked);

            if (m_asImageFiles != null)
            {
                m_asImageFiles.Clear();
            }
            m_asImageFiles = null;
            m_iImageFiles  = 0;

            m_sFolderToSaveImageTo = "";

            m_sPathToSaveImageTo = "";

            m_bFolderOperation = false;
        }

        private void SetOrientation(bool bPortrait)
        {
            int iWidth = 0;
            if (tbTrgImgWidth.Text.Length == 0)
            {
              //MessageBox.Show("Empty Width value!", csAPP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTrgImgWidth.Focus();
                return;
            }
            if (!Int32.TryParse(tbTrgImgWidth.Text, out iWidth))
            {
              //MessageBox.Show("Invalid Width value!", csAPP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTrgImgWidth.Focus();
                return;
            }
            if (iWidth < 8)
            {
              //MessageBox.Show("Width must be in range 8 - " + Screen.PrimaryScreen.Bounds.Width.ToString() + "!", csAPP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTrgImgWidth.Focus();
                return;
            }
            if (iWidth > Screen.PrimaryScreen.Bounds.Width)
            {
                MessageBox.Show("Width must be in range 8 - " + Screen.PrimaryScreen.Bounds.Width.ToString() + "!", csAPP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTrgImgWidth.Focus();
                return;
            }

            int iHeight = 0;
            if (tbTrgImgHeight.Text.Length == 0)
            {
              //MessageBox.Show("Empty Height value!", csAPP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTrgImgHeight.Focus();
                return;
            }
            if (!Int32.TryParse(tbTrgImgHeight.Text, out iHeight))
            {
              //MessageBox.Show("Invalid Height value!", csAPP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTrgImgHeight.Focus();
                return;
            }
            if (iHeight < 8)
            {
              //MessageBox.Show("Height must be in range 8 - " + Screen.PrimaryScreen.Bounds.Height.ToString() + "!", csAPP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTrgImgHeight.Focus();
                return;
            }
            if (iHeight > Screen.PrimaryScreen.Bounds.Height)
            {
                MessageBox.Show("Height must be in range 8 - " + Screen.PrimaryScreen.Bounds.Height.ToString() + "!", csAPP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTrgImgHeight.Focus();
                return;
            }

            StorageRegistry.Write("TargetImage_Width" , iWidth );
            StorageRegistry.Write("TargetImage_Height", iHeight);

            if (bPortrait)
            {
                pbImage.Width = iWidth;
                pbImage.Height = iHeight;
            }
            else
            {
                pbImage.Width = iHeight;
                pbImage.Height = iWidth;
            }
        }

        private int MakeInt16(int iHi, int iLo)
        {
            return ((iLo << 8) | (iHi & 0xFF));
        }

        private void chbPortrait_CheckedChanged(object sender, EventArgs e)
        {
            SetOrientation(chbPortrait.Checked);
        }

        private void tbTrgImgWidth_TextChanged(object sender, EventArgs e)
        {
            SetOrientation(chbPortrait.Checked);
        }

        private void tbTrgImgHeight_TextChanged(object sender, EventArgs e)
        {
            SetOrientation(chbPortrait.Checked);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "All Files (*.*)|*.*";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                Image img = null;

                try
                {
                    img = Image.FromFile(dlg.FileName);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Unable to open file \"" + dlg.FileName + "\"!\n\nException: " + exc.Message, csAPP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Clear();

                if (!LoadImage(img, dlg.FileName))
                {
                    Clear();
                    return;
                }

                btnSaveFile.Text = "Save Shrinked Single Image As...";
            }
        }

        private bool LoadImage(Image img, string sImagePath, string sTitlePre = "")
        {
            string sExifTitle = "";

            try
            {
                foreach (System.Drawing.Imaging.PropertyItem pi in img.PropertyItems)
                {
                    string sProp = "";

                    sProp += "0x" + pi.Id.ToString("X04");

                    sProp += " ";
                    sProp += "Type(";
                    sProp += pi.Type.ToString();
                    sProp += ")";

                    sProp += " ";

                    switch (pi.Id)
                    {

                        case 0x010F: sProp += "Equip Make -> "; break;

                        case 0x0110: sProp += "Equip Model -> "; break;

                        case 0x011A: sProp += "X Resolution -> "; break;

                        case 0x011B: sProp += "Y Resolution -> "; break;

                        case 0x0112: sProp += "Orientation -> "; break;

                        case 0x0128: sProp += "Resolution Unit -> "; break;

                        case 0x0132: sProp += "DateTime -> "; break;

                        case 0x0213: sProp += "YCbCr Positioning -> "; break;

                        case 0x0320: sProp += "Image Title -> "; break;

                        case 0x9003: sProp += "Exif DT Orig -> "; break;

                        case 0x9004: sProp += "Exif DT Digitized -> "; break;

                    }


                    switch (pi.Type)
                    {

                        case 2:
                            {
                                System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
                                string sTx = encoding.GetString(pi.Value);

                                if (sTx.Length > 0)
                                {
                                    if (sTx[sTx.Length - 1] == '\0')
                                    {
                                        sTx = sTx.Substring(0, sTx.Length - 1);
                                    }

                                    sProp += sTx;

                                    switch (pi.Id)
                                    {

                                        case 0x010F: //Equip Make
                                            {
                                                if (sExifTitle.Length > 0) sExifTitle += " - ";
                                                sExifTitle += sTx.Substring(0, 1).ToUpper() + sTx.Substring(1);
                                                break;
                                            }

                                        case 0x0110: //Equip Model
                                        case 0x9003: //Exif DT Orig
                                            {
                                                if (sExifTitle.Length > 0) sExifTitle += " - ";
                                                sExifTitle += sTx;
                                                break;
                                            }
                                    }
                                }

                                break;
                            }

                        case 3:
                            {
                                int int16 = MakeInt16(pi.Value[0], pi.Value[1]);
                                sProp += int16.ToString();
                                break;
                            }

                        default:
                            {
                                sProp += " Value[";
                                sProp += pi.Len.ToString();
                                sProp += "] ";

                                for (int i = 0; i < pi.Len; i++)
                                {
                                    sProp += " " + pi.Value[i].ToString("X02");
                                }

                                break;
                            }

                    }

                    lbExifData.Items.Add(sProp);
                }
            }
            catch (Exception exc)
            {
                sExifTitle = "ERROR: " + exc.Message;
            }

            if (sExifTitle.Length == 0) sExifTitle = "N/A";
            lblImage.Text = sTitlePre + sExifTitle;

            pbImage.Image = img;

            chbPortrait.Checked = (img.Height > img.Width);

            lblPathValue.Text = sImagePath;

            return true;
        }

        private void SetButtonStates(bool bInProgress)
        {
            btnOpenFile.Enabled = !bInProgress;
            btnOpenFolder.Enabled = !bInProgress;

            btnSaveFile.Enabled = !bInProgress;

            btnCpyExifToClpBrd.Enabled = !bInProgress;

            btnPauseResume.Enabled = bInProgress;
            btnPauseResume.Text = csBTNCAP_PAUSE;
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (m_asImageFiles != null)
            {
                if (m_asImageFiles.Count == 0)
                {
                    MessageBox.Show("Selected folder is empty!", csAPP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                FolderBrowserDialog dlg = new FolderBrowserDialog();

                dlg.SelectedPath = lblPathValue.Text;

                if (DialogResult.OK == dlg.ShowDialog())
                {
                    m_sFolderToSaveImageTo = dlg.SelectedPath;

                    SetButtonStates(true);

                    tmrProcessFolder.Enabled = true;
                }
            }
            else
            {
                SaveFileDialog dlg = new SaveFileDialog();

                dlg.Filter = "PNG (*" + csDEF_OUTPUT_EXT + ")|*" + csDEF_OUTPUT_EXT + "|All Files (*.*)|*.*";
                dlg.DefaultExt = csDEF_OUTPUT_EXT;

                if (DialogResult.OK == dlg.ShowDialog())
                {

                    m_sPathToSaveImageTo    = dlg.FileName;
                    m_bFolderOperation      = false;

                    tmrSaveFile.Enabled     = true;
                }
            }
        }

        private void tmrSaveFile_Tick(object sender, EventArgs e)
        {
            tmrSaveFile.Enabled = false;

            if (SaveShrinkedImage(m_sPathToSaveImageTo))
            {
                if (m_bFolderOperation)
                {
                    if (btnPauseResume.Text != csBTNCAP_RESUME)
                    {
                        tmrProcessFolder.Enabled = true;
                    }
                }
            }
        }

        private bool SaveShrinkedImage(string sImagePath)
        {
            try
            {
                Rectangle rcImgCtrl = pbImage.Bounds;

                Point ptScreen = pbImage.PointToScreen(new Point(0, 0));

                using (Bitmap bmp = new Bitmap(rcImgCtrl.Width, rcImgCtrl.Height))
                {
                    using (Graphics gScreen = Graphics.FromImage(bmp))
                    {
                        gScreen.CopyFromScreen(ptScreen /*rc.Location*/, Point.Empty, rcImgCtrl.Size);
                    }

                    bmp.Save(sImagePath, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unable to save shrinked image file \"" + sImagePath + "\"!\n\nException: " + exc.Message, csAPP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCpyExifToClpBrd_Click(object sender, EventArgs e)
        {
            if (lbExifData.Items.Count == 0)
            {
                MessageBox.Show("EXIF data list is empty!", csAPP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string sAsTx = "Image Path: " + lblPathValue.Text + "\r\n";

            foreach (object obj in lbExifData.Items)
            {
                if (sAsTx.Length > 0) sAsTx += "\r\n";
                sAsTx += obj.ToString();
            }
            sAsTx += "\r\n";

            Clipboard.Clear();
            Clipboard.SetText(sAsTx);

            MessageBox.Show("EXIF data copied to clipboard!", csAPP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (lblPathValue.Text.Length > 0)
            {
                dlg.SelectedPath = System.IO.Path.GetDirectoryName(lblPathValue.Text);
            }

            if (DialogResult.OK == dlg.ShowDialog())
            {
                Clear();

                List<string> asImageFiles = null;
                try
                {
                    asImageFiles = new List<string>(System.IO.Directory.EnumerateFiles(dlg.SelectedPath, "*.*"));
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Unable to parse folder \"" + dlg.SelectedPath + "\"!", csAPP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Clear();

                lblPathValue.Text = dlg.SelectedPath;

                m_asImageFiles = asImageFiles;
                m_iImageFiles  = m_asImageFiles.Count;

                btnSaveFile.Text = "Save All Shrinked Images to Folder...";
            }

        }

        private void tmrProcessFolder_Tick(object sender, EventArgs e)
        {
            tmrProcessFolder.Enabled = false;

            if (m_asImageFiles.Count == 0)
            {
                SetButtonStates(false);

                Clear();

                MessageBox.Show("Operation completed successfully!", csAPP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return; //Nothing to do!
            }

            string sImagePath = m_asImageFiles[0];
            m_asImageFiles.RemoveAt(0);

            string sImgPos = "Image " + (m_iImageFiles - m_asImageFiles.Count).ToString() + " of " + m_iImageFiles.ToString() + " | ";

            bool bLoadSuccess = false;

            for (; ; )
            {
                string sLastError = "";

                Image img = null;

                try
                {
                    img = Image.FromFile(sImagePath);
                    bLoadSuccess = true;
                }
                catch (Exception exc)
                {
                    sLastError = "Unable to open file \"" + sImagePath + "\"! Exception: " + exc.Message;
                    bLoadSuccess = false;
                }

                lbExifData.Items.Clear();

                if (bLoadSuccess)
                {
                    bLoadSuccess = LoadImage(img, sImagePath, sImgPos);
                }

                if (!bLoadSuccess)
                {
                    DialogResult dr = MessageBox.Show("An error occurred loading image \"" + sImagePath + "\"!\n\nERROR: " + sLastError + "\n\nDo you want to continue?", csAPP_TITLE, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

                    if (dr == DialogResult.Abort)
                    {
                        return;
                    }

                    if (dr == DialogResult.Retry)
                    {
                        continue;
                    }
                }

                break;
            }

            if (bLoadSuccess)
            {

                m_sPathToSaveImageTo    = m_sFolderToSaveImageTo + "\\" + System.IO.Path.GetFileNameWithoutExtension(sImagePath) + csDEF_OUTPUT_EXT;
                m_bFolderOperation      = true;

                tmrSaveFile.Enabled     = true;
            }
            else
            {
                if (btnPauseResume.Text != csBTNCAP_RESUME)
                {
                    tmrProcessFolder.Enabled = true;
                }
            }
        }

        private void btnPauseResume_Click(object sender, EventArgs e)
        {
            if (btnPauseResume.Text == csBTNCAP_PAUSE)
            {
                if (m_iImageFiles > 0 && m_asImageFiles != null)
                {

                    tmrProcessFolder.Enabled = false;

                    btnPauseResume.Text = csBTNCAP_RESUME;
                }
            }
            else
            {
                if (m_iImageFiles > 0 && m_asImageFiles != null)
                {
                    tmrProcessFolder.Enabled = true;

                    btnPauseResume.Text = csBTNCAP_PAUSE;
                }
            }
        }
    }
}
