namespace SerialMonitor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnScan = new Button();
            cmbCOMPort = new ComboBox();
            btnOpen = new Button();
            btnClose = new Button();
            tbxTxData = new TextBox();
            btnSend = new Button();
            tbxRxData = new TextBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnScan
            // 
            btnScan.Location = new Point(12, 12);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(94, 29);
            btnScan.TabIndex = 0;
            btnScan.Text = "更新";
            btnScan.UseVisualStyleBackColor = true;
            // 
            // cmbCOMPort
            // 
            cmbCOMPort.FormattingEnabled = true;
            cmbCOMPort.Location = new Point(112, 13);
            cmbCOMPort.Name = "cmbCOMPort";
            cmbCOMPort.Size = new Size(151, 28);
            cmbCOMPort.TabIndex = 1;
            cmbCOMPort.Text = "- Select -";
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(269, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(94, 29);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "接続";
            btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(369, 13);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "切断";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // tbxTxData
            // 
            tbxTxData.Location = new Point(12, 47);
            tbxTxData.Name = "tbxTxData";
            tbxTxData.Size = new Size(351, 27);
            tbxTxData.TabIndex = 4;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(369, 46);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 5;
            btnSend.Text = "送信";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // tbxRxData
            // 
            tbxRxData.Location = new Point(12, 103);
            tbxRxData.Multiline = true;
            tbxRxData.Name = "tbxRxData";
            tbxRxData.ScrollBars = ScrollBars.Vertical;
            tbxRxData.Size = new Size(351, 222);
            tbxRxData.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(369, 103);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "受信";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 334);
            Controls.Add(btnClear);
            Controls.Add(tbxRxData);
            Controls.Add(btnSend);
            Controls.Add(tbxTxData);
            Controls.Add(btnClose);
            Controls.Add(btnOpen);
            Controls.Add(cmbCOMPort);
            Controls.Add(btnScan);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnScan;
        private ComboBox cmbCOMPort;
        private Button btnOpen;
        private Button btnClose;
        private TextBox tbxTxData;
        private Button btnSend;
        private TextBox tbxRxData;
        private Button btnClear;
    }
}