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

        private void btnOpenFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "All Files (*.*)|*.*";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                pbImage.Image = Image.FromFile(dlg.FileName);

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

            //ptWnd.X += pbWorkplace.Bounds.X;
            //ptWnd.Y += pbWorkplace.Bounds.Y;

            //ptWnd.X += rcImgCtrl.X;
            //ptWnd.Y += rcImgCtrl.Y;

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
