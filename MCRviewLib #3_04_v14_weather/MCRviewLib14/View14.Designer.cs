namespace MCRviewLib14
{
    partial class View14
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
            this.timer_RefreshWeb = new System.Windows.Forms.Timer(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.timer_clock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer_RefreshWeb
            // 
            this.timer_RefreshWeb.Tick += new System.EventHandler(this.timer_RefreshWeb_Tick);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(102, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(84, 35);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "닫기";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Visible = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(12, 12);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(84, 35);
            this.btn_reload.TabIndex = 4;
            this.btn_reload.Text = "새로고침";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Visible = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(192, 12);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(84, 35);
            this.btn_restart.TabIndex = 5;
            this.btn_restart.Text = "재시작";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // lbl_clock
            // 
            this.lbl_clock.AutoSize = true;
            this.lbl_clock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.lbl_clock.Font = new System.Drawing.Font("맑은 고딕", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_clock.ForeColor = System.Drawing.Color.White;
            this.lbl_clock.Location = new System.Drawing.Point(392, 871);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(246, 128);
            this.lbl_clock.TabIndex = 6;
            this.lbl_clock.Text = "시계";
            this.lbl_clock.Visible = false;
            // 
            // timer_clock
            // 
            this.timer_clock.Tick += new System.EventHandler(this.timer_clock_Tick);
            // 
            // View14
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_clock);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Tag = "14";
            this.Text = "14 날씨예보";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.View13_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_RefreshWeb;
        public System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Button btn_reload;
        public System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Label lbl_clock;
        private System.Windows.Forms.Timer timer_clock;
    }
}

