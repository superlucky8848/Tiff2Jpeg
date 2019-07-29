namespace Tiff2Jpeg
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            this.tBTiffFile = new System.Windows.Forms.TextBox();
            this.btTiffFile = new System.Windows.Forms.Button();
            this.btOutputFolder = new System.Windows.Forms.Button();
            this.tBOutputFolder = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.pBProgress = new System.Windows.Forms.ProgressBar();
            this.tBPrefix = new System.Windows.Forms.TextBox();
            this.tBCompression = new System.Windows.Forms.TextBox();
            this.bgWDoWork = new System.ComponentModel.BackgroundWorker();
            this.lbMessage = new System.Windows.Forms.Label();
            this.ckBEcraser = new System.Windows.Forms.CheckBox();
            this.btnChooseWithWater = new System.Windows.Forms.Button();
            this.tbWithWater = new System.Windows.Forms.TextBox();
            this.btnChooseNoWater = new System.Windows.Forms.Button();
            this.tbSansWater = new System.Windows.Forms.TextBox();
            this.btnChooseWatermark = new System.Windows.Forms.Button();
            this.tbWaterMark = new System.Windows.Forms.TextBox();
            this.btnCreateWater = new System.Windows.Forms.Button();
            this.ckBEcraserWater = new System.Windows.Forms.CheckBox();
            this.grpConvert = new System.Windows.Forms.GroupBox();
            this.tbSuffix = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDimension = new System.Windows.Forms.TextBox();
            this.bgWWatermarks = new System.ComponentModel.BackgroundWorker();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.grpConvert.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(31, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 13);
            label1.TabIndex = 0;
            label1.Text = "Tiff Original:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 13);
            label2.TabIndex = 3;
            label2.Text = "Dossier Output :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(19, 144);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 13);
            label3.TabIndex = 10;
            label3.Text = "Prefix:";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(586, 116);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(120, 13);
            label4.TabIndex = 12;
            label4.Text = "Compression(30-100%) :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 61);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(136, 13);
            label5.TabIndex = 18;
            label5.Text = "Dossier Avec Watermarks :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(31, 30);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(115, 13);
            label6.TabIndex = 15;
            label6.Text = "Jpg sans Watermarks :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(54, 93);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(86, 13);
            label7.TabIndex = 21;
            label7.Text = "png Watermark :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(231, 143);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(36, 13);
            label8.TabIndex = 16;
            label8.Text = "Suffix:";
            // 
            // label9
            // 
            label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(331, 116);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(161, 13);
            label9.TabIndex = 18;
            label9.Text = "Dimension Watermark (0-100%) :";
            // 
            // tBTiffFile
            // 
            this.tBTiffFile.AllowDrop = true;
            this.tBTiffFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBTiffFile.Location = new System.Drawing.Point(102, 30);
            this.tBTiffFile.Name = "tBTiffFile";
            this.tBTiffFile.Size = new System.Drawing.Size(649, 20);
            this.tBTiffFile.TabIndex = 1;
            this.tBTiffFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.tBTiffFile_DragDrop);
            this.tBTiffFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.tBTiffFile_DragEnter);
            // 
            // btTiffFile
            // 
            this.btTiffFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTiffFile.Location = new System.Drawing.Point(757, 27);
            this.btTiffFile.Name = "btTiffFile";
            this.btTiffFile.Size = new System.Drawing.Size(75, 25);
            this.btTiffFile.TabIndex = 2;
            this.btTiffFile.Text = "...";
            this.btTiffFile.UseVisualStyleBackColor = true;
            this.btTiffFile.Click += new System.EventHandler(this.btTiffFile_Click);
            // 
            // btOutputFolder
            // 
            this.btOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOutputFolder.Location = new System.Drawing.Point(757, 56);
            this.btOutputFolder.Name = "btOutputFolder";
            this.btOutputFolder.Size = new System.Drawing.Size(75, 25);
            this.btOutputFolder.TabIndex = 5;
            this.btOutputFolder.Text = "...";
            this.btOutputFolder.UseVisualStyleBackColor = true;
            this.btOutputFolder.Click += new System.EventHandler(this.btOutputFolder_Click);
            // 
            // tBOutputFolder
            // 
            this.tBOutputFolder.AllowDrop = true;
            this.tBOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBOutputFolder.Location = new System.Drawing.Point(102, 61);
            this.tBOutputFolder.Name = "tBOutputFolder";
            this.tBOutputFolder.Size = new System.Drawing.Size(649, 20);
            this.tBOutputFolder.TabIndex = 4;
            this.tBOutputFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.tBOutputFolder_DragDrop);
            this.tBOutputFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.tBOutputFolder_DragEnter);
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Location = new System.Drawing.Point(334, 88);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(162, 25);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "Convert";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // pBProgress
            // 
            this.pBProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBProgress.Location = new System.Drawing.Point(12, 355);
            this.pBProgress.Name = "pBProgress";
            this.pBProgress.Size = new System.Drawing.Size(841, 13);
            this.pBProgress.TabIndex = 7;
            // 
            // tBPrefix
            // 
            this.tBPrefix.Location = new System.Drawing.Point(70, 140);
            this.tBPrefix.Name = "tBPrefix";
            this.tBPrefix.Size = new System.Drawing.Size(121, 20);
            this.tBPrefix.TabIndex = 9;
            // 
            // tBCompression
            // 
            this.tBCompression.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBCompression.Location = new System.Drawing.Point(712, 113);
            this.tBCompression.Name = "tBCompression";
            this.tBCompression.Size = new System.Drawing.Size(36, 20);
            this.tBCompression.TabIndex = 11;
            this.tBCompression.Text = "75";
            // 
            // bgWDoWork
            // 
            this.bgWDoWork.WorkerReportsProgress = true;
            this.bgWDoWork.WorkerSupportsCancellation = true;
            this.bgWDoWork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWDoWork_DoWork);
            this.bgWDoWork.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWDoWork_ProgressChanged);
            this.bgWDoWork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWDoWork_RunWorkerCompleted);
            // 
            // lbMessage
            // 
            this.lbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMessage.Location = new System.Drawing.Point(629, 326);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(215, 25);
            this.lbMessage.TabIndex = 13;
            this.lbMessage.Text = "Tiff2Jpeg";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ckBEcraser
            // 
            this.ckBEcraser.AutoSize = true;
            this.ckBEcraser.Enabled = false;
            this.ckBEcraser.Location = new System.Drawing.Point(10, 87);
            this.ckBEcraser.Name = "ckBEcraser";
            this.ckBEcraser.Size = new System.Drawing.Size(150, 17);
            this.ckBEcraser.TabIndex = 14;
            this.ckBEcraser.Text = "Écraser anciennes images";
            this.ckBEcraser.UseVisualStyleBackColor = true;
            // 
            // btnChooseWithWater
            // 
            this.btnChooseWithWater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseWithWater.Location = new System.Drawing.Point(757, 56);
            this.btnChooseWithWater.Name = "btnChooseWithWater";
            this.btnChooseWithWater.Size = new System.Drawing.Size(75, 25);
            this.btnChooseWithWater.TabIndex = 20;
            this.btnChooseWithWater.Text = "...";
            this.btnChooseWithWater.UseVisualStyleBackColor = true;
            this.btnChooseWithWater.Click += new System.EventHandler(this.BtnChooseWithWater_Click);
            // 
            // tbWithWater
            // 
            this.tbWithWater.AllowDrop = true;
            this.tbWithWater.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWithWater.Location = new System.Drawing.Point(146, 58);
            this.tbWithWater.Name = "tbWithWater";
            this.tbWithWater.Size = new System.Drawing.Size(605, 20);
            this.tbWithWater.TabIndex = 19;
            // 
            // btnChooseNoWater
            // 
            this.btnChooseNoWater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseNoWater.Location = new System.Drawing.Point(757, 24);
            this.btnChooseNoWater.Name = "btnChooseNoWater";
            this.btnChooseNoWater.Size = new System.Drawing.Size(75, 25);
            this.btnChooseNoWater.TabIndex = 17;
            this.btnChooseNoWater.Text = "...";
            this.btnChooseNoWater.UseVisualStyleBackColor = true;
            this.btnChooseNoWater.Click += new System.EventHandler(this.BtnChooseNoWater_Click);
            // 
            // tbSansWater
            // 
            this.tbSansWater.AllowDrop = true;
            this.tbSansWater.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSansWater.Location = new System.Drawing.Point(146, 27);
            this.tbSansWater.Name = "tbSansWater";
            this.tbSansWater.Size = new System.Drawing.Size(605, 20);
            this.tbSansWater.TabIndex = 16;
            // 
            // btnChooseWatermark
            // 
            this.btnChooseWatermark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseWatermark.Location = new System.Drawing.Point(757, 87);
            this.btnChooseWatermark.Name = "btnChooseWatermark";
            this.btnChooseWatermark.Size = new System.Drawing.Size(75, 25);
            this.btnChooseWatermark.TabIndex = 23;
            this.btnChooseWatermark.Text = "...";
            this.btnChooseWatermark.UseVisualStyleBackColor = true;
            this.btnChooseWatermark.Click += new System.EventHandler(this.BtnChooseWatermark_Click);
            // 
            // tbWaterMark
            // 
            this.tbWaterMark.AllowDrop = true;
            this.tbWaterMark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWaterMark.Location = new System.Drawing.Point(146, 90);
            this.tbWaterMark.Name = "tbWaterMark";
            this.tbWaterMark.Size = new System.Drawing.Size(605, 20);
            this.tbWaterMark.TabIndex = 22;
            // 
            // btnCreateWater
            // 
            this.btnCreateWater.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateWater.Location = new System.Drawing.Point(414, 137);
            this.btnCreateWater.Name = "btnCreateWater";
            this.btnCreateWater.Size = new System.Drawing.Size(214, 25);
            this.btnCreateWater.TabIndex = 24;
            this.btnCreateWater.Text = "Watermarking";
            this.btnCreateWater.UseVisualStyleBackColor = true;
            this.btnCreateWater.Click += new System.EventHandler(this.BtnCreateWater_Click);
            // 
            // ckBEcraserWater
            // 
            this.ckBEcraserWater.AutoSize = true;
            this.ckBEcraserWater.Enabled = false;
            this.ckBEcraserWater.Location = new System.Drawing.Point(22, 118);
            this.ckBEcraserWater.Name = "ckBEcraserWater";
            this.ckBEcraserWater.Size = new System.Drawing.Size(150, 17);
            this.ckBEcraserWater.TabIndex = 25;
            this.ckBEcraserWater.Text = "Écraser anciennes images";
            this.ckBEcraserWater.UseVisualStyleBackColor = true;
            // 
            // grpConvert
            // 
            this.grpConvert.Controls.Add(label1);
            this.grpConvert.Controls.Add(this.tBTiffFile);
            this.grpConvert.Controls.Add(this.btTiffFile);
            this.grpConvert.Controls.Add(label2);
            this.grpConvert.Controls.Add(this.tBOutputFolder);
            this.grpConvert.Controls.Add(this.btOutputFolder);
            this.grpConvert.Controls.Add(this.ckBEcraser);
            this.grpConvert.Controls.Add(this.btStart);
            this.grpConvert.Location = new System.Drawing.Point(12, 12);
            this.grpConvert.Name = "grpConvert";
            this.grpConvert.Size = new System.Drawing.Size(838, 128);
            this.grpConvert.TabIndex = 26;
            this.grpConvert.TabStop = false;
            this.grpConvert.Text = "Conversion TIFF";
            // 
            // tbSuffix
            // 
            this.tbSuffix.Location = new System.Drawing.Point(272, 140);
            this.tbSuffix.Name = "tbSuffix";
            this.tbSuffix.Size = new System.Drawing.Size(121, 20);
            this.tbSuffix.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label8);
            this.groupBox1.Controls.Add(this.tbDimension);
            this.groupBox1.Controls.Add(this.tbSuffix);
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(label9);
            this.groupBox1.Controls.Add(this.tbSansWater);
            this.groupBox1.Controls.Add(this.ckBEcraserWater);
            this.groupBox1.Controls.Add(this.btnChooseNoWater);
            this.groupBox1.Controls.Add(this.btnCreateWater);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.tBPrefix);
            this.groupBox1.Controls.Add(this.btnChooseWatermark);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.tbWithWater);
            this.groupBox1.Controls.Add(this.tBCompression);
            this.groupBox1.Controls.Add(this.tbWaterMark);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.btnChooseWithWater);
            this.groupBox1.Controls.Add(label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 172);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbDimension
            // 
            this.tbDimension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDimension.Location = new System.Drawing.Point(498, 112);
            this.tbDimension.Name = "tbDimension";
            this.tbDimension.Size = new System.Drawing.Size(49, 20);
            this.tbDimension.TabIndex = 17;
            this.tbDimension.Text = "50";
            // 
            // bgWWatermarks
            // 
            this.bgWWatermarks.WorkerReportsProgress = true;
            this.bgWWatermarks.WorkerSupportsCancellation = true;
            this.bgWWatermarks.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWWatermarks_DoWork);
            this.bgWWatermarks.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgWWatermarks_ProgressChanged);
            this.bgWWatermarks.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWWatermarks_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpConvert);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.pBProgress);
            this.Name = "MainForm";
            this.Text = "Tiff2Jpeg";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpConvert.ResumeLayout(false);
            this.grpConvert.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBTiffFile;
        private System.Windows.Forms.Button btTiffFile;
        private System.Windows.Forms.Button btOutputFolder;
        private System.Windows.Forms.TextBox tBOutputFolder;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.ProgressBar pBProgress;
        private System.Windows.Forms.TextBox tBPrefix;
        private System.Windows.Forms.TextBox tBCompression;
        private System.ComponentModel.BackgroundWorker bgWDoWork;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.CheckBox ckBEcraser;
        private System.Windows.Forms.Button btnChooseWithWater;
        private System.Windows.Forms.TextBox tbWithWater;
        private System.Windows.Forms.Button btnChooseNoWater;
        private System.Windows.Forms.TextBox tbSansWater;
        private System.Windows.Forms.Button btnChooseWatermark;
        private System.Windows.Forms.TextBox tbWaterMark;
        private System.Windows.Forms.Button btnCreateWater;
        private System.Windows.Forms.CheckBox ckBEcraserWater;
        private System.Windows.Forms.GroupBox grpConvert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker bgWWatermarks;
        private System.Windows.Forms.TextBox tbSuffix;
        private System.Windows.Forms.TextBox tbDimension;
    }
}

