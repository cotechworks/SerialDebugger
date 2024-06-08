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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnScan = new System.Windows.Forms.Button();
            this.cmbCOMPort = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxTxData = new System.Windows.Forms.TextBox();
            this.tbxRxData = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(12, 12);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "更新";
            this.btnScan.UseVisualStyleBackColor = true;
            // 
            // cmbCOMPort
            // 
            this.cmbCOMPort.FormattingEnabled = true;
            this.cmbCOMPort.Location = new System.Drawing.Point(93, 13);
            this.cmbCOMPort.Name = "cmbCOMPort";
            this.cmbCOMPort.Size = new System.Drawing.Size(121, 23);
            this.cmbCOMPort.TabIndex = 1;
            this.cmbCOMPort.Text = "- Select -";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(220, 13);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "接続";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(301, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "切断";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(301, 42);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "送信";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // tbxTxData
            // 
            this.tbxTxData.Location = new System.Drawing.Point(12, 41);
            this.tbxTxData.Name = "tbxTxData";
            this.tbxTxData.Size = new System.Drawing.Size(283, 22);
            this.tbxTxData.TabIndex = 5;
            // 
            // tbxRxData
            // 
            this.tbxRxData.Location = new System.Drawing.Point(12, 89);
            this.tbxRxData.Multiline = true;
            this.tbxRxData.Name = "tbxRxData";
            this.tbxRxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxRxData.Size = new System.Drawing.Size(283, 212);
            this.tbxRxData.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(301, 88);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 314);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbxRxData);
            this.Controls.Add(this.tbxTxData);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cmbCOMPort);
            this.Controls.Add(this.btnScan);
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
    }
}

