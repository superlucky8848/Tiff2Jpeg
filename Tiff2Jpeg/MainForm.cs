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


namespace Tiff2Jpeg
{
    public partial class MainForm : Form
    {
        private string tiffFile;
        private string oulputFolder;
        private string filePre;
        private string fileExt;
        private bool hasPreZero;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text=String.Format("Tiff2Jpeg[v{0}]",FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion);
        }

        private void bgWDoWork_DoWork(object sender, DoWorkEventArgs e)
        {
            
            MyUserState myUserState = new MyUserState();
            int padlength = 0;

            using(Stream imageStreamSource = new FileStream(tiffFile, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                TiffBitmapDecoder decoder = new TiffBitmapDecoder(imageStreamSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
                myUserState.totalFrame = decoder.Frames.Count;
                if (hasPreZero) padlength = (int)Math.Floor(Math.Log10((double)myUserState.totalFrame));
                for (int i = 0; i < decoder.Frames.Count; ++i)
                {
                    myUserState.curFrame = i + 1;
                    if (bgWDoWork.CancellationPending)
                    {
                        e.Cancel = true;
                        myUserState.message = "User canceled";
                        bgWDoWork.ReportProgress(100,myUserState);
                        break;
                    }
                    BitmapSource bigmapSource = decoder.Frames[i];
                    string jpegFileName = String.Format("{3}\\{0}{1}.{2}", filePre, (i + 1).ToString().PadLeft(padlength, '0'), fileExt, oulputFolder);
                    myUserState.message=String.Format("Converting {0} ...({1}/{2})",Path.GetFileName(jpegFileName),myUserState.curFrame,myUserState.totalFrame);
                    bgWDoWork.ReportProgress(100,myUserState);
                    using (FileStream stream = new FileStream(jpegFileName, FileMode.Create))
                    {
                        JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                        encoder.QualityLevel=80;
                        encoder.Frames.Add(BitmapFrame.Create(bigmapSource));
                        encoder.Save(stream);
                    }

                }//for (int i = 0; i < decoder.Frames.Count; ++i)
            }//using(Stream imageStreamSource = new FileStream(tiffFile, FileMode.Open, FileAccess.Read, FileShare.Read))

        }

        private void bgWDoWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            MyUserState userState = e.UserState as MyUserState;
            pBProgress.Maximum = userState.totalFrame;
            pBProgress.Value = userState.curFrame;
            lbMessage.Text = userState.message;
        }

        private void bgWDoWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) MessageBox.Show("Cancelled.");
            else MessageBox.Show("Finished.");
            btStart.Text = "Start";
            btOutputFolder.Enabled = btTiffFile.Enabled = true;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (btStart.Text == "Start")
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
                if (String.IsNullOrEmpty(tBExtension.Text)) tBExtension.Text = "jpg";

                tiffFile = tBTiffFile.Text;
                oulputFolder = tBOutputFolder.Text;
                filePre = tBFilePre.Text;
                fileExt = tBExtension.Text;
                hasPreZero = ckBPreZero.Checked;

                btOutputFolder.Enabled = btTiffFile.Enabled = false;
                bgWDoWork.RunWorkerAsync();
                btStart.Text = "Cancel";
            }
            else
            {
                bgWDoWork.CancelAsync();
            }
        }

        private void btTiffFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofDlg = new OpenFileDialog())
            {
                ofDlg.Multiselect = false;
                ofDlg.Filter = "Tiff File|*.tif; *.tiff|All File|*.*";
                if (ofDlg.ShowDialog() == DialogResult.OK) tBTiffFile.Text = ofDlg.FileName;
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
    }

    public class MyUserState
    {
        public int curFrame;
        public int totalFrame;
        public string message;
    }
}
