namespace OPCDATest2
{
    partial class frmMain
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbServer = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnDisconn = new System.Windows.Forms.Button();
            this.btnRGroup = new System.Windows.Forms.Button();
            this.lbGroup = new System.Windows.Forms.ListBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.btnRData = new System.Windows.Forms.Button();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbServer
            // 
            this.lbServer.FormattingEnabled = true;
            this.lbServer.ItemHeight = 12;
            this.lbServer.Location = new System.Drawing.Point(358, 535);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(61, 28);
            this.lbServer.TabIndex = 5;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(358, 506);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(128, 23);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "List OPC Server";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(358, 421);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(102, 21);
            this.txtIP.TabIndex = 3;
            this.txtIP.Text = "192.168.117.247";
            // 
            // btnDisconn
            // 
            this.btnDisconn.Location = new System.Drawing.Point(358, 477);
            this.btnDisconn.Name = "btnDisconn";
            this.btnDisconn.Size = new System.Drawing.Size(124, 23);
            this.btnDisconn.TabIndex = 6;
            this.btnDisconn.Text = "Disconnect Server";
            this.btnDisconn.UseVisualStyleBackColor = true;
            this.btnDisconn.Click += new System.EventHandler(this.btnDisconn_Click);
            // 
            // btnRGroup
            // 
            this.btnRGroup.Location = new System.Drawing.Point(358, 448);
            this.btnRGroup.Name = "btnRGroup";
            this.btnRGroup.Size = new System.Drawing.Size(124, 23);
            this.btnRGroup.TabIndex = 7;
            this.btnRGroup.Text = "Read Group";
            this.btnRGroup.UseVisualStyleBackColor = true;
            this.btnRGroup.Click += new System.EventHandler(this.btnRGroup_Click);
            // 
            // lbGroup
            // 
            this.lbGroup.FormattingEnabled = true;
            this.lbGroup.ItemHeight = 12;
            this.lbGroup.Location = new System.Drawing.Point(425, 535);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(65, 28);
            this.lbGroup.TabIndex = 8;
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 12;
            this.lbResult.Location = new System.Drawing.Point(496, 535);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(65, 28);
            this.lbResult.TabIndex = 9;
            // 
            // btnRData
            // 
            this.btnRData.Location = new System.Drawing.Point(0, 3);
            this.btnRData.Name = "btnRData";
            this.btnRData.Size = new System.Drawing.Size(300, 23);
            this.btnRData.TabIndex = 10;
            this.btnRData.Text = "Read DCS";
            this.btnRData.UseVisualStyleBackColor = true;
            this.btnRData.Click += new System.EventHandler(this.btnRData_Click);
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(359, 367);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(127, 21);
            this.txtVal.TabIndex = 3;
            this.txtVal.Text = "100";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(358, 394);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(168, 21);
            this.txtTag.TabIndex = 3;
            this.txtTag.Text = "TEST.Channel1.TAG0001";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(358, 338);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(106, 23);
            this.btnWrite.TabIndex = 11;
            this.btnWrite.Text = "Write Data";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Insert DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 496);
            this.listBox1.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_tick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(0, 566);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(300, 184);
            this.listBox2.TabIndex = 14;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(612, 756);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRData);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbGroup);
            this.Controls.Add(this.btnRGroup);
            this.Controls.Add(this.btnDisconn);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.txtIP);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Name = "frmMain";
            this.Text = "ALL_HYDRO_ROAD";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbServer;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnDisconn;
        private System.Windows.Forms.Button btnRGroup;
        private System.Windows.Forms.ListBox lbGroup;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Button btnRData;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ListBox listBox2;
    }
}

