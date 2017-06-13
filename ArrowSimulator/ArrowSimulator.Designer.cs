namespace ArrowSimulator
{
    partial class ArrowSimulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbServerAddr = new System.Windows.Forms.TextBox();
            this.txtBServPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtBoxLOG = new System.Windows.Forms.RichTextBox();
            this.cmbxSigs = new System.Windows.Forms.ComboBox();
            this.btnSendSig = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbServerAddr
            // 
            this.txtbServerAddr.Location = new System.Drawing.Point(12, 42);
            this.txtbServerAddr.Name = "txtbServerAddr";
            this.txtbServerAddr.Size = new System.Drawing.Size(100, 20);
            this.txtbServerAddr.TabIndex = 0;
            this.txtbServerAddr.Text = "Server";
            // 
            // txtBServPort
            // 
            this.txtBServPort.Location = new System.Drawing.Point(128, 42);
            this.txtBServPort.Name = "txtBServPort";
            this.txtBServPort.Size = new System.Drawing.Size(100, 20);
            this.txtBServPort.TabIndex = 1;
            this.txtBServPort.Text = "Port";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(242, 42);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // txtBoxLOG
            // 
            this.txtBoxLOG.Location = new System.Drawing.Point(12, 160);
            this.txtBoxLOG.Name = "txtBoxLOG";
            this.txtBoxLOG.Size = new System.Drawing.Size(563, 285);
            this.txtBoxLOG.TabIndex = 4;
            this.txtBoxLOG.Text = "";
            // 
            // cmbxSigs
            // 
            this.cmbxSigs.FormattingEnabled = true;
            this.cmbxSigs.Items.AddRange(new object[] {
            "Hi0",
            "GSM",
            "POWER"});
            this.cmbxSigs.Location = new System.Drawing.Point(13, 102);
            this.cmbxSigs.Name = "cmbxSigs";
            this.cmbxSigs.Size = new System.Drawing.Size(121, 21);
            this.cmbxSigs.TabIndex = 5;
            // 
            // btnSendSig
            // 
            this.btnSendSig.Location = new System.Drawing.Point(242, 100);
            this.btnSendSig.Name = "btnSendSig";
            this.btnSendSig.Size = new System.Drawing.Size(75, 23);
            this.btnSendSig.TabIndex = 6;
            this.btnSendSig.Text = "Send";
            this.btnSendSig.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 7;
            // 
            // ArrowSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 457);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSendSig);
            this.Controls.Add(this.cmbxSigs);
            this.Controls.Add(this.txtBoxLOG);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtBServPort);
            this.Controls.Add(this.txtbServerAddr);
            this.Name = "ArrowSimulator";
            this.Text = "ArrowSimulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbServerAddr;
        private System.Windows.Forms.TextBox txtBServPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RichTextBox txtBoxLOG;
        private System.Windows.Forms.ComboBox cmbxSigs;
        private System.Windows.Forms.Button btnSendSig;
        private System.Windows.Forms.TextBox textBox1;
    }
}

