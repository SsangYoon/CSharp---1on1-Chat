namespace Chat
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plGroup = new System.Windows.Forms.Panel();
            this.plOption = new System.Windows.Forms.Panel();
            this.lbIP = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbServer = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.plMessage = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.tsslblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsBar = new System.Windows.Forms.ToolStrip();
            this.tsddbtnOption = new System.Windows.Forms.ToolStripDropDownButton();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnConnect = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDisconnect = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.plGroup.SuspendLayout();
            this.plOption.SuspendLayout();
            this.plMessage.SuspendLayout();
            this.ssBar.SuspendLayout();
            this.tsBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // plGroup
            // 
            this.plGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.plGroup.Controls.Add(this.plOption);
            this.plGroup.Controls.Add(this.rtbText);
            this.plGroup.Location = new System.Drawing.Point(12, 37);
            this.plGroup.Name = "plGroup";
            this.plGroup.Size = new System.Drawing.Size(618, 425);
            this.plGroup.TabIndex = 0;
            // 
            // plOption
            // 
            this.plOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.plOption.Controls.Add(this.lbIP);
            this.plOption.Controls.Add(this.btnClose);
            this.plOption.Controls.Add(this.cbServer);
            this.plOption.Controls.Add(this.btnSave);
            this.plOption.Controls.Add(this.txtIP);
            this.plOption.Controls.Add(this.lbPort);
            this.plOption.Controls.Add(this.lbID);
            this.plOption.Controls.Add(this.txtPort);
            this.plOption.Controls.Add(this.txtID);
            this.plOption.Location = new System.Drawing.Point(104, 56);
            this.plOption.Name = "plOption";
            this.plOption.Size = new System.Drawing.Size(420, 321);
            this.plOption.TabIndex = 8;
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(48, 36);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(40, 18);
            this.lbIP.TabIndex = 2;
            this.lbIP.Text = "IP : ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(241, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 50);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "닫 기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbServer
            // 
            this.cbServer.AutoSize = true;
            this.cbServer.Location = new System.Drawing.Point(153, 184);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(106, 22);
            this.cbServer.TabIndex = 0;
            this.cbServer.Text = "서버실행";
            this.cbServer.UseVisualStyleBackColor = true;
            this.cbServer.CheckedChanged += new System.EventHandler(this.cbServer_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(78, 233);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 52);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "설 정";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(94, 33);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(275, 28);
            this.txtIP.TabIndex = 1;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(17, 130);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(71, 18);
            this.lbPort.TabIndex = 5;
            this.lbPort.Text = "PORT : ";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(48, 84);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(34, 18);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "ID :";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(94, 127);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(275, 28);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "2008";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(94, 81);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(275, 28);
            this.txtID.TabIndex = 4;
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(7, 13);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(600, 400);
            this.rtbText.TabIndex = 9;
            this.rtbText.Text = "";
            // 
            // plMessage
            // 
            this.plMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plMessage.Controls.Add(this.txtMessage);
            this.plMessage.Controls.Add(this.btnSend);
            this.plMessage.Location = new System.Drawing.Point(12, 468);
            this.plMessage.Name = "plMessage";
            this.plMessage.Size = new System.Drawing.Size(618, 153);
            this.plMessage.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 29);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(446, 96);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMessage_KeyPress);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(469, 29);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(133, 96);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ssBar
            // 
            this.ssBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblTime});
            this.ssBar.Location = new System.Drawing.Point(0, 622);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(642, 30);
            this.ssBar.TabIndex = 2;
            this.ssBar.Text = "statusStrip1";
            // 
            // tsslblTime
            // 
            this.tsslblTime.Name = "tsslblTime";
            this.tsslblTime.Size = new System.Drawing.Size(186, 25);
            this.tsslblTime.Text = "메세지 받은시간 출력";
            // 
            // tsBar
            // 
            this.tsBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbtnOption,
            this.tsbtnConnect,
            this.tsbtnDisconnect});
            this.tsBar.Location = new System.Drawing.Point(0, 0);
            this.tsBar.Name = "tsBar";
            this.tsBar.Size = new System.Drawing.Size(642, 31);
            this.tsBar.TabIndex = 3;
            this.tsBar.Text = "toolStrip1";
            // 
            // tsddbtnOption
            // 
            this.tsddbtnOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbtnOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem,
            this.닫기ToolStripMenuItem});
            this.tsddbtnOption.Image = ((System.Drawing.Image)(resources.GetObject("tsddbtnOption.Image")));
            this.tsddbtnOption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbtnOption.Name = "tsddbtnOption";
            this.tsddbtnOption.Size = new System.Drawing.Size(42, 28);
            this.tsddbtnOption.Text = "toolStripDropDownButton1";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.설정ToolStripMenuItem.Text = "설정";
            this.설정ToolStripMenuItem.Click += new System.EventHandler(this.설정ToolStripMenuItem_Click);
            // 
            // 닫기ToolStripMenuItem
            // 
            this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.닫기ToolStripMenuItem.Text = "닫기";
            this.닫기ToolStripMenuItem.Click += new System.EventHandler(this.닫기ToolStripMenuItem_Click);
            // 
            // tsbtnConnect
            // 
            this.tsbtnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnConnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnConnect.Image")));
            this.tsbtnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConnect.Name = "tsbtnConnect";
            this.tsbtnConnect.Size = new System.Drawing.Size(28, 28);
            this.tsbtnConnect.Text = "연결";
            this.tsbtnConnect.Click += new System.EventHandler(this.tsbtnConnect_Click);
            // 
            // tsbtnDisconnect
            // 
            this.tsbtnDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDisconnect.Image")));
            this.tsbtnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDisconnect.Name = "tsbtnDisconnect";
            this.tsbtnDisconnect.Size = new System.Drawing.Size(28, 28);
            this.tsbtnDisconnect.Text = "끊기";
            this.tsbtnDisconnect.Click += new System.EventHandler(this.tsbtnDisconnect_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 31);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 591);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 652);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tsBar);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.plMessage);
            this.Controls.Add(this.plGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plGroup.ResumeLayout(false);
            this.plOption.ResumeLayout(false);
            this.plOption.PerformLayout();
            this.plMessage.ResumeLayout(false);
            this.plMessage.PerformLayout();
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.tsBar.ResumeLayout(false);
            this.tsBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plGroup;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.CheckBox cbServer;
        private System.Windows.Forms.Panel plMessage;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.ToolStrip tsBar;
        private System.Windows.Forms.Panel plOption;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtnOption;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtnConnect;
        private System.Windows.Forms.ToolStripButton tsbtnDisconnect;
        private System.Windows.Forms.ToolStripStatusLabel tsslblTime;
    }
}

