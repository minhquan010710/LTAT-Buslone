namespace Client
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtMessaged_Receive = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPadding = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGetIp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessaged_Receive
            // 
            this.txtMessaged_Receive.Location = new System.Drawing.Point(65, 25);
            this.txtMessaged_Receive.Multiline = true;
            this.txtMessaged_Receive.Name = "txtMessaged_Receive";
            this.txtMessaged_Receive.Size = new System.Drawing.Size(393, 35);
            this.txtMessaged_Receive.TabIndex = 4;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(538, 25);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(393, 20);
            this.txtKey.TabIndex = 10;
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(65, 85);
            this.txtDecrypted.Multiline = true;
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new System.Drawing.Size(393, 35);
            this.txtDecrypted.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "KEY";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 274);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(925, 212);
            this.listBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Decrypted";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEncrypt);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.txtEncrypted);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 186);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(56, 135);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 40);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(324, 135);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 40);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(56, 85);
            this.txtEncrypted.Multiline = true;
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(393, 35);
            this.txtEncrypted.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encrypted";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(56, 25);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(393, 35);
            this.txtMessage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Message";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPadding);
            this.groupBox2.Controls.Add(this.txtDecrypted);
            this.groupBox2.Controls.Add(this.txtMessaged_Receive);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(473, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 186);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decrypt";
            // 
            // txtPadding
            // 
            this.txtPadding.Location = new System.Drawing.Point(65, 135);
            this.txtPadding.Multiline = true;
            this.txtPadding.Name = "txtPadding";
            this.txtPadding.Size = new System.Drawing.Size(393, 31);
            this.txtPadding.TabIndex = 15;
            this.txtPadding.Visible = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(658, 51);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(138, 25);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "Generate key";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(68, 29);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(393, 20);
            this.txtIP.TabIndex = 13;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(273, 55);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(138, 25);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnGetIp
            // 
            this.btnGetIp.Location = new System.Drawing.Point(104, 55);
            this.btnGetIp.Name = "btnGetIp";
            this.btnGetIp.Size = new System.Drawing.Size(138, 25);
            this.btnGetIp.TabIndex = 15;
            this.btnGetIp.Text = "Get IP";
            this.btnGetIp.UseVisualStyleBackColor = true;
            this.btnGetIp.Click += new System.EventHandler(this.btnGetIp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 511);
            this.Controls.Add(this.btnGetIp);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessaged_Receive;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtPadding;
        private System.Windows.Forms.Button btnGetIp;

    }
}

