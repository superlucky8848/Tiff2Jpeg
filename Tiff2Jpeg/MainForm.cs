using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Windows.Threading;
using System.Windows.Media.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Tiff2Jpeg
{
    public partial class MainForm : Form
    {
        private string tiffFile;
        private string oulputFolder;
        private string prefix;
        private string suffix;
        int pCentCompression=75;

        string sansWater;
        string avecWater;
        string pngWatermark;
        int pCentWaterSize = 50;
        bool shouldOverwriteWater = true;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text=String.Format("Tiff2Jpeg[v{0}]",FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion);

            tBTiffFile.Text = Properties.Settings.Default.inFold;
            tBOutputFolder.Text = Properties.Settings.Default.outFold;
            ckBEcraser.Checked = Properties.Settings.Default.chkOverwrite;
            tBPrefix.Text = Properties.Settings.Default.prefix;
            tbSuffix.Text = Properties.Settings.Default.suffix;

            tbSansWater.Text = Properties.Settings.Default.inWater;
            tbWithWater.Text = Properties.Settings.Default.outWater;
            tbWaterMark.Text = Properties.Settings.Default.pngWater;

            tbDimension.Text = Properties.Settings.Default.dimension;
            tBCompression.Text = Properties.Settings.Default.compression;

            ckBEcraserWater.Checked = Properties.Settings.Default.chkOverWater;
        }

        private void bgWDoWork_DoWork(object sender, DoWorkEventArgs e)
        {
            
            MyUserState myUserState = new MyUserState();

            string[] allTiffs = Directory.GetFiles(tiffFile, "*.tiff", SearchOption.AllDirectories);
            int done = 0;
            foreach(string tiffFile2 in allTiffs)
            {
                using(Stream imageStreamSource = new FileStream(tiffFile2, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    TiffBitmapDecoder decoder = new TiffBitmapDecoder(imageStreamSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
                    myUserState.totalFrame = decoder.Frames.Count;
                     for (int i = 0; i < decoder.Frames.Count; ++i)
                    {
                        myUserState.curFrame = i + 1;
                        if (bgWDoWork.CancellationPending)
                        {
                            e.Cancel = true;
                            myUserState.message = "User canceled";
                            break;
                        }
                        BitmapSource bigmapSource = decoder.Frames[i];
                        string fName = tiffFile2.Substring(tiffFile.Length);
                        fName = fName.Substring(0, fName.LastIndexOf("."));
                            //Path.GetFileNameWithoutExtension(tiffFile) + (i > 0 ? (i + 1).ToString().PadLeft(padlength, '0') : "");
                        string jpegFileName = String.Format("{0}\\{1}.jpg", oulputFolder, fName);
                        myUserState.message=String.Format("Converting {0} ...({1}/{2})",Path.GetFileNameWithoutExtension(jpegFileName),myUserState.curFrame,myUserState.totalFrame);
                        bgWDoWork.ReportProgress(++done * 100 / allTiffs.Length,myUserState);
                        Console.WriteLine(done * 100 / allTiffs.Length);
                        Console.WriteLine("UpdateProgression : " + done * 100 / allTiffs.Length);
                        Directory.CreateDirectory(Path.GetDirectoryName( jpegFileName));
                        using (FileStream stream = new FileStream(jpegFileName, FileMode.Create))
                        {
                            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                            encoder.QualityLevel = 100;// pCentCompression;
                            encoder.Frames.Add(BitmapFrame.Create(bigmapSource));
                            encoder.Save(stream);
                        }
                    }//for (int i = 0; i < decoder.Frames.Count; ++i)
                }//using(Stream imageStreamSource = new FileStream(tiffFile, FileMode.Open, FileAccess.Read, FileShare.Read))
            }//for each files
            myUserState.message = "Done converting Tiffs";
            bgWDoWork.ReportProgress( 100, myUserState);
        }

        private void bgWDoWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            MyUserState userState = e.UserState as MyUserState;
            //pBProgress.Maximum = 100;
            pBProgress.Value = e.ProgressPercentage;
            lbMessage.Text = userState.message;
        }

        private void bgWDoWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) MessageBox.Show("Cancelled.");
            else MessageBox.Show("Finished.");
            btStart.Text = "Convert";
            btOutputFolder.Enabled = btTiffFile.Enabled = true;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (btStart.Text == "Convert")
            {
                if (String.IsNullOrEmpty(tBTiffFile.Text))
                {
                    MessageBox.Show("Input a tiff file first");
                    return;
                }
                if (String.IsNullOrEmpty(tBOutputFolder.Text))
                {
                    MessageBox.Show("Input a folder to contain jpegs");
                    return;
                }

                tiffFile = tBTiffFile.Text;
                oulputFolder = tBOutputFolder.Text;

                btOutputFolder.Enabled = btTiffFile.Enabled = false;
                bgWDoWork.RunWorkerAsync();
                btStart.Text = "Cancel";

                Properties.Settings.Default.inFold = tBTiffFile.Text;
                Properties.Settings.Default.outFold = tBOutputFolder.Text;
                Properties.Settings.Default.chkOverwrite = ckBEcraser.Checked;
                
                Properties.Settings.Default.Save();
            }
            else
            {
                bgWDoWork.CancelAsync();
            }
        }

        private void btTiffFile_Click(object sender, EventArgs e)
        {
            /*using (OpenFileDialog ofDlg = new OpenFileDialog())
            {
                ofDlg.Multiselect = false;
                ofDlg.Filter = "Tiff File|*.tif; *.tiff|All File|*.*";
                if (ofDlg.ShowDialog() == DialogResult.OK) tBTiffFile.Text = ofDlg.FileName;
            }*/

            using (FolderBrowserDialog fbDlg = new FolderBrowserDialog())
            {
                fbDlg.ShowNewFolderButton = true;
                if (fbDlg.ShowDialog() == DialogResult.OK) tBTiffFile.Text = fbDlg.SelectedPath;
            }
        }

        private void btOutputFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbDlg = new FolderBrowserDialog())
            {
                fbDlg.ShowNewFolderButton = true;
                if (fbDlg.ShowDialog() == DialogResult.OK) tBOutputFolder.Text = fbDlg.SelectedPath;
            }
        }

        private void tBTiffFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                string ext = (Path.GetExtension(fileList[0]));
                if (Path.GetExtension(fileList[0]) == ".tif" || Path.GetExtension(fileList[0]) == ".tiff")
                    e.Effect = DragDropEffects.Copy;
                else e.Effect = DragDropEffects.None;
            }
            else e.Effect = DragDropEffects.None;
        }

        private void tBTiffFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            tBTiffFile.Text = fileList[0];
        }

        private void tBOutputFolder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else e.Effect = DragDropEffects.None;
        }

        private void tBOutputFolder_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            tBOutputFolder.Text = fileList[0];
        }

        private void BtnChooseNoWater_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbDlg = new FolderBrowserDialog())
            {
                fbDlg.ShowNewFolderButton = true;
                if (fbDlg.ShowDialog() == DialogResult.OK) tbSansWater.Text = fbDlg.SelectedPath;
            }
        }

        private void BtnChooseWithWater_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbDlg = new FolderBrowserDialog())
            {
                fbDlg.ShowNewFolderButton = true;
                if (fbDlg.ShowDialog() == DialogResult.OK) tbWithWater.Text = fbDlg.SelectedPath;
            }
        }

        private void BtnChooseWatermark_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofDlg = new OpenFileDialog())
            {
                ofDlg.Multiselect = false;
                ofDlg.Filter = "PNG File|*.png; *.png|All File|*.*";
                if (ofDlg.ShowDialog() == DialogResult.OK) tbWaterMark.Text = ofDlg.FileName;
            }
        }

        private void BtnCreateWater_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.inWater=tbSansWater.Text;
            Properties.Settings.Default.outWater = tbWithWater.Text;
            Properties.Settings.Default.pngWater = tbWaterMark.Text;
            Properties.Settings.Default.dimension = tbDimension.Text;
            Properties.Settings.Default.compression = tBCompression.Text;
            Properties.Settings.Default.prefix = tBPrefix.Text;
            Properties.Settings.Default.suffix = tbSuffix.Text;

            Properties.Settings.Default.chkOverWater = ckBEcraserWater.Checked;
            Properties.Settings.Default.Save();


            if (btnCreateWater.Text == "Watermarking")
            {
                if (String.IsNullOrEmpty(tbWithWater.Text))
                {
                    MessageBox.Show("Input a tiff file first");
                    return;
                }
                if (String.IsNullOrEmpty(tbSansWater.Text))
                {
                    MessageBox.Show("Input a folder to contain jpegs");
                    return;
                }
                if (String.IsNullOrEmpty(tBCompression.Text)) tBCompression.Text = "100";

                sansWater = tbSansWater.Text;
                avecWater = tbWithWater.Text;
                pngWatermark = tbWaterMark.Text;

                prefix = tBPrefix.Text;
                suffix = tbSuffix.Text;
                pCentCompression = Convert.ToInt32(tBCompression.Text);

                pCentWaterSize = Convert.ToInt32( tbDimension.Text);
                shouldOverwriteWater = ckBEcraserWater.Checked;

                btOutputFolder.Enabled = btTiffFile.Enabled = false;
                bgWWatermarks.RunWorkerAsync();
                btnCreateWater.Text = "Cancel";
            }
            else
            {
                bgWWatermarks.CancelAsync();
            }
        }

        private void BgWWatermarks_DoWork(object sender, DoWorkEventArgs e)
        {
            MyUserState myUserState = new MyUserState();

            string[] allImages = Directory.GetFiles(tbSansWater.Text, "*.jpg", SearchOption.AllDirectories);
            int done = 0;
            foreach (string jpgFile in allImages)
            {
                using (Stream imageStreamSource = new FileStream(jpgFile, FileMode.Open, FileAccess.Read, FileShare.Read))
                {

                    if (bgWWatermarks.CancellationPending)
                    {
                        e.Cancel = true;
                        myUserState.message = "User canceled";
                        break;
                    }

                    string fName = jpgFile.Substring(tbSansWater.Text.Length);
                    fName = fName.Substring(0, fName.LastIndexOf("."));
                    string jpegFileName = String.Format("{0}\\{1}.jpg", tbWithWater.Text, prefix + fName + suffix);
                    myUserState.message = String.Format("Converting {0} ...({1}/{2})", Path.GetFileNameWithoutExtension(jpegFileName), myUserState.curFrame, myUserState.totalFrame);
                    bgWWatermarks.ReportProgress(++done * 100 / allImages.Length, myUserState);
                    Directory.CreateDirectory(Path.GetDirectoryName(jpegFileName));

                    if (pCentWaterSize <= 0)
                    {
                        pngWatermark = jpgFile;
                    }

                    using (Image imageOri = Image.FromFile(jpgFile))
                    using (Image image = convert("path", imageOri))
                    using (Image watermarkImage = Image.FromFile(pngWatermark))
                   // using (Graphics imageGraphics = convert("path",image))
                    using (Graphics imageGraphics = Graphics.FromImage(image))
                    using (TextureBrush watermarkBrush = new TextureBrush(watermarkImage))
                    {

                        if (pCentWaterSize > 0)
                        {
                            float ratioToPrint = pCentWaterSize * Math.Min(100 * image.Width / watermarkImage.Width,
                                                                        100 * image.Height / watermarkImage.Height) / (100f*100f);
                             
                            int x = (int)(image.Width / 2 - watermarkImage.Width * ratioToPrint / 2);
                            int y = (int)(image.Height / 2 - watermarkImage.Height * ratioToPrint / 2);
                            watermarkBrush.TranslateTransform(x - ratioToPrint * watermarkImage.Width,
                                                             y - ratioToPrint * watermarkImage.Height);
                            watermarkBrush.ScaleTransform(ratioToPrint, ratioToPrint);
                            imageGraphics.FillRectangle(watermarkBrush, 
                                new Rectangle(new Point(x, y), 
                                new Size((int)(ratioToPrint * watermarkImage.Width + 1), (int)(ratioToPrint * watermarkImage.Height))));

                        }

                        ImageCodecInfo myImageCodecInfo = GetEncoderInfo("image/jpeg");
                        System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                        EncoderParameters myEncoderParameters = new EncoderParameters(1);

                        EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, (long)pCentCompression);
                        myEncoderParameters.Param[0] = myEncoderParameter;

                        image.Save(jpegFileName, myImageCodecInfo, myEncoderParameters);
                    }
                }//using(Stream imageStreamSource = new FileStream(tiffFile, FileMode.Open, FileAccess.Read, FileShare.Read))
            }//for each files
            myUserState.message = "Done adding Watermarks";
            bgWWatermarks.ReportProgress(100, myUserState);
        }
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        private void BgWWatermarks_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //pBProgress.Maximum = 100;
            MyUserState userState = e.UserState as MyUserState;
            pBProgress.Value = e.ProgressPercentage;
            lbMessage.Text = userState.message;
        }

        private void BgWWatermarks_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) MessageBox.Show("Cancelled.");
            else MessageBox.Show("Finished.");
            btnCreateWater.Text = "Watermarking";
            btOutputFolder.Enabled = btTiffFile.Enabled = true;
        }


        private Image convert(string pImagePath, Image pImage)
        {

            Graphics g;
            Image ImageToConvert = new Bitmap(pImage);
            ImageAttributes ImageAttributes = new ImageAttributes();
            int width = ImageToConvert.Width;
            int height = ImageToConvert.Height;
            float[][] GrayShear = new float[][] { new float[] { 0.5f, 0.5f, 0.5f, 0f, 0f}, 
                      new float[] { 0.5f, 0.5f, 0.5f, 0f, 0f}, 
             new float[] { 0.5f, 0.5f, 0.5f, 0f, 0f}, 
             new float[] { 0, 0, 0, 1, 0}, 
             new float[] { 0, 0, 0, 0, 1}                        };


        ColorMatrix colMatrix = new ColorMatrix(GrayShear);


        ImageAttributes.SetColorMatrix(colMatrix, ColorMatrixFlag.Default, 
        ColorAdjustType.Bitmap);


    g = Graphics.FromImage(ImageToConvert);

            g.DrawImage(ImageToConvert, 
            new Rectangle(0, 0, width, height), 0, 0, 
            width, height, GraphicsUnit.Pixel, ImageAttributes);

            return ImageToConvert;
            //g.Dispose();
            //return g;
}


    }

    public class MyUserState
    {
        public int curFrame;
        public int totalFrame;
        public string message;
    }
}
