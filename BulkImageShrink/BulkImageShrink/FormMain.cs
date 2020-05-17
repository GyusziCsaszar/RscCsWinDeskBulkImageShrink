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

        protected const int ciWIDTH_NORMAL  = 900;
        protected const int ciHEIGHT_NORMAL = 600;

        protected string m_sPathToSaveImageTo = "";

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
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            //TODO...
            //e.Cancel = true;

            /*if (this.Left >= 0)*/ StorageRegistry.Write("Main_Left", this.Left);
            if (this.Top >= 0) StorageRegistry.Write("Main_Top", this.Top);
            if (this.Width >= ciWIDTH_NORMAL) StorageRegistry.Write("Main_Width", this.Width);
            if (this.Height >= ciHEIGHT_NORMAL) StorageRegistry.Write("Main_Height", this.Height);

            //TODO...
        }

        private int MakeInt16(int iHi, int iLo)
        {
            return ((iLo << 8) | (iHi & 0xFF));
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "All Files (*.*)|*.*";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                Image img = Image.FromFile(dlg.FileName);

                foreach (System.Drawing.Imaging.PropertyItem pi in img.PropertyItems)
                {
                    string sProp = "";

                    sProp += "0x" + pi.Id.ToString("X04");

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

                        /*
                        default:
                        {
                            sProp += "0x" + pi.Id.ToString("X");
                            break;
                        }
                        */

                    }


                    switch (pi.Type)
                    {

                        case 2:
                        {
                            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
                            sProp += encoding.GetString(pi.Value);
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
                            sProp += "(";
                            sProp += pi.Type.ToString();
                            sProp += ")";

                            sProp += " [";
                            sProp += pi.Len.ToString();
                            sProp += "]";

                            break;
                        }

                    }

                    lbExifData.Items.Add(sProp);
                }

                pbImage.Image = img;

                tbPath.Text = dlg.FileName;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {

            SaveFileDialog dlg = new SaveFileDialog();

            dlg.Filter = "PNG (*.png)|*.png|All Files (*.*)|*.*";
            dlg.DefaultExt = ".png";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                m_sPathToSaveImageTo = dlg.FileName;

                tmrSaveFile.Enabled = true;
            }
        }

        private void tmrSaveFile_Tick(object sender, EventArgs e)
        {
            tmrSaveFile.Enabled = false;

            Rectangle rcImgCtrl = pbImage.Bounds;

            Point ptScreen = pbImage.PointToScreen(new Point(0, 0));

            using (Bitmap bmp = new Bitmap(rcImgCtrl.Width, rcImgCtrl.Height))
            {
                using (Graphics gScreen = Graphics.FromImage(bmp))
                {
                    gScreen.CopyFromScreen(ptScreen /*rc.Location*/, Point.Empty, rcImgCtrl.Size);
                }

                bmp.Save(m_sPathToSaveImageTo, System.Drawing.Imaging.ImageFormat.Png);
            }

        }
    }
}
