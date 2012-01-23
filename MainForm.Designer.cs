namespace Workbench
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.request = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.requestCachePolicy = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uri = new System.Windows.Forms.TextBox();
            this.method = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sendRequest = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.responseLog = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.clientLog = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.requestSystemProxy = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.responseLastModified = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.responseCacheControl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.requestUseMachineName = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.randomStuff = new System.Windows.Forms.Label();
            this.serverPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.serverPrefix = new System.Windows.Forms.TextBox();
            this.restartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.request);
            this.splitContainer1.Panel1.Controls.Add(this.panel7);
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Size = new System.Drawing.Size(860, 500);
            this.splitContainer1.SplitterDistance = 357;
            this.splitContainer1.TabIndex = 0;
            // 
            // request
            // 
            this.request.Dock = System.Windows.Forms.DockStyle.Fill;
            this.request.Location = new System.Drawing.Point(0, 80);
            this.request.Multiline = true;
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(357, 320);
            this.request.TabIndex = 3;
            this.request.Text = "User-Agent: OpenRastaWorkbench";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.requestCachePolicy);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 55);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(357, 25);
            this.panel7.TabIndex = 7;
            // 
            // requestCachePolicy
            // 
            this.requestCachePolicy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestCachePolicy.FormattingEnabled = true;
            this.requestCachePolicy.Location = new System.Drawing.Point(74, 0);
            this.requestCachePolicy.Name = "requestCachePolicy";
            this.requestCachePolicy.Size = new System.Drawing.Size(283, 21);
            this.requestCachePolicy.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cache-Control";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 400);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(357, 100);
            this.panel6.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Server stats";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uri);
            this.panel1.Controls.Add(this.method);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 23);
            this.panel1.TabIndex = 2;
            // 
            // uri
            // 
            this.uri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uri.Location = new System.Drawing.Point(73, 0);
            this.uri.Name = "uri";
            this.uri.Size = new System.Drawing.Size(284, 20);
            this.uri.TabIndex = 3;
            this.uri.Text = "/1";
            // 
            // method
            // 
            this.method.Dock = System.Windows.Forms.DockStyle.Left;
            this.method.FormattingEnabled = true;
            this.method.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.method.Location = new System.Drawing.Point(0, 0);
            this.method.Name = "method";
            this.method.Size = new System.Drawing.Size(73, 21);
            this.method.TabIndex = 2;
            this.method.Text = "GET";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.sendRequest);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 32);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Request";
            // 
            // sendRequest
            // 
            this.sendRequest.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendRequest.Location = new System.Drawing.Point(282, 0);
            this.sendRequest.Name = "sendRequest";
            this.sendRequest.Size = new System.Drawing.Size(75, 32);
            this.sendRequest.TabIndex = 2;
            this.sendRequest.Text = "Send";
            this.sendRequest.UseVisualStyleBackColor = true;
            this.sendRequest.Click += new System.EventHandler(this.sendRequest_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(499, 455);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.responseLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(489, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HTTP Comm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // responseLog
            // 
            this.responseLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.responseLog.Location = new System.Drawing.Point(3, 3);
            this.responseLog.Multiline = true;
            this.responseLog.Name = "responseLog";
            this.responseLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.responseLog.Size = new System.Drawing.Size(483, 429);
            this.responseLog.TabIndex = 0;
            this.responseLog.WordWrap = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.clientLog);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(489, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Logs";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // clientLog
            // 
            this.clientLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientLog.Location = new System.Drawing.Point(0, 0);
            this.clientLog.Multiline = true;
            this.clientLog.Name = "clientLog";
            this.clientLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clientLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.clientLog.Size = new System.Drawing.Size(489, 435);
            this.clientLog.TabIndex = 0;
            this.clientLog.WordWrap = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(491, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.requestSystemProxy);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 80);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client Request";
            // 
            // requestSystemProxy
            // 
            this.requestSystemProxy.AutoSize = true;
            this.requestSystemProxy.Location = new System.Drawing.Point(17, 20);
            this.requestSystemProxy.Name = "requestSystemProxy";
            this.requestSystemProxy.Size = new System.Drawing.Size(108, 17);
            this.requestSystemProxy.TabIndex = 0;
            this.requestSystemProxy.Text = "Use system proxy";
            this.requestSystemProxy.UseVisualStyleBackColor = true;
            this.requestSystemProxy.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.responseLastModified);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.responseCacheControl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Response";
            // 
            // responseLastModified
            // 
            this.responseLastModified.FormattingEnabled = true;
            this.responseLastModified.Items.AddRange(new object[] {
            "(Now)",
            "(None)"});
            this.responseLastModified.Location = new System.Drawing.Point(104, 43);
            this.responseLastModified.Name = "responseLastModified";
            this.responseLastModified.Size = new System.Drawing.Size(299, 21);
            this.responseLastModified.TabIndex = 7;
            this.responseLastModified.Text = "(Now)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last-Modified";
            // 
            // responseCacheControl
            // 
            this.responseCacheControl.Location = new System.Drawing.Point(104, 19);
            this.responseCacheControl.Name = "responseCacheControl";
            this.responseCacheControl.Size = new System.Drawing.Size(299, 20);
            this.responseCacheControl.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cache-Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.restartButton);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.clearButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(499, 32);
            this.panel5.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Server";
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.clearButton.Location = new System.Drawing.Point(424, 0);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 32);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.radioButton2);
            this.panel8.Controls.Add(this.requestUseMachineName);
            this.panel8.Location = new System.Drawing.Point(146, 20);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 43);
            this.panel8.TabIndex = 3;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Use localhost";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // requestUseMachineName
            // 
            this.requestUseMachineName.AutoSize = true;
            this.requestUseMachineName.Checked = true;
            this.requestUseMachineName.Location = new System.Drawing.Point(3, 1);
            this.requestUseMachineName.Name = "requestUseMachineName";
            this.requestUseMachineName.Size = new System.Drawing.Size(116, 17);
            this.requestUseMachineName.TabIndex = 3;
            this.requestUseMachineName.TabStop = true;
            this.requestUseMachineName.Text = "Use machine name";
            this.requestUseMachineName.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.serverPrefix);
            this.groupBox3.Controls.Add(this.randomStuff);
            this.groupBox3.Controls.Add(this.serverPort);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 73);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server Config";
            // 
            // randomStuff
            // 
            this.randomStuff.AutoSize = true;
            this.randomStuff.Location = new System.Drawing.Point(14, 46);
            this.randomStuff.Name = "randomStuff";
            this.randomStuff.Size = new System.Drawing.Size(33, 13);
            this.randomStuff.TabIndex = 6;
            this.randomStuff.Text = "Prefix";
            // 
            // serverPort
            // 
            this.serverPort.Location = new System.Drawing.Point(104, 19);
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(299, 20);
            this.serverPort.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Port";
            // 
            // serverPrefix
            // 
            this.serverPrefix.Location = new System.Drawing.Point(104, 43);
            this.serverPrefix.Name = "serverPrefix";
            this.serverPrefix.Size = new System.Drawing.Size(299, 20);
            this.serverPrefix.TabIndex = 7;
            // 
            // restartButton
            // 
            this.restartButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.restartButton.Location = new System.Drawing.Point(349, 0);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 32);
            this.restartButton.TabIndex = 3;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 500);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "OpenRasta Workbench";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox request;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox uri;
        private System.Windows.Forms.ComboBox method;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendRequest;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox responseLog;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox clientLog;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox responseLastModified;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox responseCacheControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox requestCachePolicy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox requestSystemProxy;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton requestUseMachineName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label randomStuff;
        private System.Windows.Forms.TextBox serverPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox serverPrefix;
        private System.Windows.Forms.Button restartButton;
    }
}

