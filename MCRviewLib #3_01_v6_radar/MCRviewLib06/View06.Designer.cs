namespace MCRviewLib06
{
    partial class View06
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
            this.btn_stop = new System.Windows.Forms.Button();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.timer_clock = new System.Windows.Forms.Timer(this.components);
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.timer_reload_v6 = new System.Windows.Forms.Timer(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(93, 12);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 34);
            this.btn_stop.TabIndex = 0;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Visible = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lbl_clock
            // 
            this.lbl_clock.AutoSize = true;
            this.lbl_clock.Font = new System.Drawing.Font("맑은 고딕", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_clock.Location = new System.Drawing.Point(-1, 943);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(246, 128);
            this.lbl_clock.TabIndex = 1;
            this.lbl_clock.Text = "시계";
            this.lbl_clock.Visible = false;
            // 
            // timer_clock
            // 
            this.timer_clock.Tick += new System.EventHandler(this.timer_clock_Tick);
            // 
            // btn_reload
            // 
            this.btn_reload.Enabled = false;
            this.btn_reload.ForeColor = System.Drawing.Color.LightGray;
            this.btn_reload.Location = new System.Drawing.Point(174, 12);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(75, 34);
            this.btn_reload.TabIndex = 2;
            this.btn_reload.Text = "ReLoad";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Visible = false;
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(12, 12);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(75, 34);
            this.btn_restart.TabIndex = 3;
            this.btn_restart.Text = "ReStart";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // timer_reload_v6
            // 
            this.timer_reload_v6.Interval = 1000;
            this.timer_reload_v6.Tick += new System.EventHandler(this.timer_reload_v6_Tick);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(1833, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 34);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "닫기";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Visible = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // View06
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.lbl_clock);
            this.Controls.Add(this.btn_stop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View06";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Tag = "06";
            this.Text = "06 레이더 합성 영상";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.View06_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_clock;
        private System.Windows.Forms.Timer timer_clock;
        public System.Windows.Forms.Button btn_reload;
        public System.Windows.Forms.Button btn_stop;
        public System.Windows.Forms.Button btn_restart;
        public System.Windows.Forms.Timer timer_reload_v6;
        public System.Windows.Forms.Button btn_close;
    }
}

