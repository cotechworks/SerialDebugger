namespace SerialMonitor
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnScan = new System.Windows.Forms.Button();
            this.cmbCOMPort = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxTxData = new System.Windows.Forms.TextBox();
            this.tbxRxData = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbCRLF = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbCR = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbLF = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(200, 12);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "更新";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cmbCOMPort
            // 
            this.cmbCOMPort.FormattingEnabled = true;
            this.cmbCOMPort.Location = new System.Drawing.Point(93, 13);
            this.cmbCOMPort.Name = "cmbCOMPort";
            this.cmbCOMPort.Size = new System.Drawing.Size(101, 23);
            this.cmbCOMPort.TabIndex = 1;
            this.cmbCOMPort.Text = "- Select -";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(15, 128);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "接続";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(105, 128);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "切断";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(200, 159);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "送信";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxTxData
            // 
            this.tbxTxData.Location = new System.Drawing.Point(15, 160);
            this.tbxTxData.Name = "tbxTxData";
            this.tbxTxData.Size = new System.Drawing.Size(179, 22);
            this.tbxTxData.TabIndex = 5;
            // 
            // tbxRxData
            // 
            this.tbxRxData.Location = new System.Drawing.Point(15, 188);
            this.tbxRxData.Multiline = true;
            this.tbxRxData.Name = "tbxRxData";
            this.tbxRxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxRxData.Size = new System.Drawing.Size(260, 212);
            this.tbxRxData.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(15, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbBaud.Location = new System.Drawing.Point(93, 43);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(101, 23);
            this.cmbBaud.TabIndex = 8;
            this.cmbBaud.Text = "- Select -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "COMポート";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "ボーレート";
            // 
            // rbCRLF
            // 
            this.rbCRLF.AutoSize = true;
            this.rbCRLF.Checked = true;
            this.rbCRLF.Location = new System.Drawing.Point(93, 72);
            this.rbCRLF.Name = "rbCRLF";
            this.rbCRLF.Size = new System.Drawing.Size(63, 19);
            this.rbCRLF.TabIndex = 11;
            this.rbCRLF.Text = "CRLF";
            this.rbCRLF.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "改行コード";
            // 
            // rbCR
            // 
            this.rbCR.AutoSize = true;
            this.rbCR.Location = new System.Drawing.Point(162, 72);
            this.rbCR.Name = "rbCR";
            this.rbCR.Size = new System.Drawing.Size(47, 19);
            this.rbCR.TabIndex = 13;
            this.rbCR.Text = "CR";
            this.rbCR.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(162, 97);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(60, 19);
            this.rbNone.TabIndex = 14;
            this.rbNone.Text = "none";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // rbLF
            // 
            this.rbLF.AutoSize = true;
            this.rbLF.Location = new System.Drawing.Point(93, 97);
            this.rbLF.Name = "rbLF";
            this.rbLF.Size = new System.Drawing.Size(44, 19);
            this.rbLF.TabIndex = 15;
            this.rbLF.Text = "LF";
            this.rbLF.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 436);
            this.Controls.Add(this.rbLF);
            this.Controls.Add(this.rbNone);
            this.Controls.Add(this.rbCR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbCRLF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBaud);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbxRxData);
            this.Controls.Add(this.tbxTxData);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cmbCOMPort);
            this.Controls.Add(this.btnScan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "シリアルモニター";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ComboBox cmbCOMPort;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxTxData;
        private System.Windows.Forms.TextBox tbxRxData;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbCRLF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbCR;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbLF;
    }
}

