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
            this.tBTiffFile = new System.Windows.Forms.TextBox();
            this.btTiffFile = new System.Windows.Forms.Button();
            this.btOutputFolder = new System.Windows.Forms.Button();
            this.tBOutputFolder = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.pBProgress = new System.Windows.Forms.ProgressBar();
            this.ckBPreZero = new System.Windows.Forms.CheckBox();
            this.tBFilePre = new System.Windows.Forms.TextBox();
            this.tBExtension = new System.Windows.Forms.TextBox();
            this.bgWDoWork = new System.ComponentModel.BackgroundWorker();
            this.lbMessage = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(36, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 12);
            label1.TabIndex = 0;
            label1.Text = "Tiff File:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 38);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 12);
            label2.TabIndex = 3;
            label2.Text = "Output Folder:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(24, 66);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 12);
            label3.TabIndex = 10;
            label3.Text = "File Prefix:";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(406, 66);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(95, 12);
            label4.TabIndex = 12;
            label4.Text = "File Extension:";
            // 
            // tBTiffFile
            // 
            this.tBTiffFile.AllowDrop = true;
            this.tBTiffFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tBTiffFile.Location = new System.Drawing.Point(107, 6);
            this.tBTiffFile.Name = "tBTiffFile";
            this.tBTiffFile.Size = new System.Drawing.Size(469, 21);
            this.tBTiffFile.TabIndex = 1;
            this.tBTiffFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.tBTiffFile_DragDrop);
            this.tBTiffFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.tBTiffFile_DragEnter);
            // 
            // btTiffFile
            // 
            this.btTiffFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTiffFile.Location = new System.Drawing.Point(582, 4);
            this.btTiffFile.Name = "btTiffFile";
            this.btTiffFile.Size = new System.Drawing.Size(75, 23);
            this.btTiffFile.TabIndex = 2;
            this.btTiffFile.Text = "...";
            this.btTiffFile.UseVisualStyleBackColor = true;
            this.btTiffFile.Click += new System.EventHandler(this.btTiffFile_Click);
            // 
            // btOutputFolder
            // 
            this.btOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOutputFolder.Location = new System.Drawing.Point(582, 33);
            this.btOutputFolder.Name = "btOutputFolder";
            this.btOutputFolder.Size = new System.Drawing.Size(75, 23);
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
            this.tBOutputFolder.Location = new System.Drawing.Point(107, 35);
            this.tBOutputFolder.Name = "tBOutputFolder";
            this.tBOutputFolder.Size = new System.Drawing.Size(469, 21);
            this.tBOutputFolder.TabIndex = 4;
            this.tBOutputFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.tBOutputFolder_DragDrop);
            this.tBOutputFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.tBOutputFolder_DragEnter);
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Location = new System.Drawing.Point(228, 126);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(198, 33);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // pBProgress
            // 
            this.pBProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pBProgress.Location = new System.Drawing.Point(12, 95);
            this.pBProgress.Name = "pBProgress";
            this.pBProgress.Size = new System.Drawing.Size(645, 25);
            this.pBProgress.TabIndex = 7;
            // 
            // ckBPreZero
            // 
            this.ckBPreZero.AutoSize = true;
            this.ckBPreZero.Location = new System.Drawing.Point(294, 65);
            this.ckBPreZero.Name = "ckBPreZero";
            this.ckBPreZero.Size = new System.Drawing.Size(96, 16);
            this.ckBPreZero.TabIndex = 8;
            this.ckBPreZero.Text = "Add Pre Zero";
            this.ckBPreZero.UseVisualStyleBackColor = true;
            // 
            // tBFilePre
            // 
            this.tBFilePre.Location = new System.Drawing.Point(107, 63);
            this.tBFilePre.Name = "tBFilePre";
            this.tBFilePre.Size = new System.Drawing.Size(181, 21);
            this.tBFilePre.TabIndex = 9;
            // 
            // tBExtension
            // 
            this.tBExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBExtension.Location = new System.Drawing.Point(507, 63);
            this.tBExtension.Name = "tBExtension";
            this.tBExtension.Size = new System.Drawing.Size(150, 21);
            this.tBExtension.TabIndex = 11;
            this.tBExtension.Text = "jpg";
            // 
            // bgWDoWork
            // 
            this.bgWDoWork.WorkerReportsProgress = true;
            this.bgWDoWork.WorkerSupportsCancellation = true;
            this.bgWDoWork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWDoWork_DoWork);
            this.bgWDoWork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWDoWork_RunWorkerCompleted);
            this.bgWDoWork.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWDoWork_ProgressChanged);
            // 
            // lbMessage
            // 
            this.lbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMessage.Location = new System.Drawing.Point(442, 126);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(215, 23);
            this.lbMessage.TabIndex = 13;
            this.lbMessage.Text = "Tiff2Jpeg";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 171);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(label4);
            this.Controls.Add(this.tBExtension);
            this.Controls.Add(label3);
            this.Controls.Add(this.tBFilePre);
            this.Controls.Add(this.ckBPreZero);
            this.Controls.Add(this.pBProgress);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btOutputFolder);
            this.Controls.Add(this.tBOutputFolder);
            this.Controls.Add(label2);
            this.Controls.Add(this.btTiffFile);
            this.Controls.Add(this.tBTiffFile);
            this.Controls.Add(label1);
            this.Name = "MainForm";
            this.Text = "Tiff2Jpeg";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBTiffFile;
        private System.Windows.Forms.Button btTiffFile;
        private System.Windows.Forms.Button btOutputFolder;
        private System.Windows.Forms.TextBox tBOutputFolder;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.ProgressBar pBProgress;
        private System.Windows.Forms.CheckBox ckBPreZero;
        private System.Windows.Forms.TextBox tBFilePre;
        private System.Windows.Forms.TextBox tBExtension;
        private System.ComponentModel.BackgroundWorker bgWDoWork;
        private System.Windows.Forms.Label lbMessage;
    }
}

