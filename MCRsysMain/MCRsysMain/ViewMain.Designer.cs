namespace MCRsysMain
{
    partial class ViewMain
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
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_view01 = new System.Windows.Forms.Button();
            this.btn_view02 = new System.Windows.Forms.Button();
            this.btn_view03 = new System.Windows.Forms.Button();
            this.btn_view04 = new System.Windows.Forms.Button();
            this.btn_view05 = new System.Windows.Forms.Button();
            this.btn_view10 = new System.Windows.Forms.Button();
            this.btn_view09 = new System.Windows.Forms.Button();
            this.btn_view08 = new System.Windows.Forms.Button();
            this.btn_view07 = new System.Windows.Forms.Button();
            this.btn_view06 = new System.Windows.Forms.Button();
            this.btn_view13 = new System.Windows.Forms.Button();
            this.btn_view12 = new System.Windows.Forms.Button();
            this.btn_view11 = new System.Windows.Forms.Button();
            this.txt_SelectedViewNo = new System.Windows.Forms.TextBox();
            this.btn_display = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.m_timer_PC_INFO = new System.Windows.Forms.Timer(this.components);
            this.m_timer_1st = new System.Windows.Forms.Timer(this.components);
            this.listBox01 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox02 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listBox03 = new System.Windows.Forms.ListBox();
            this.listBox04 = new System.Windows.Forms.ListBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.listBox05 = new System.Windows.Forms.ListBox();
            this.button10 = new System.Windows.Forms.Button();
            this.listBox06 = new System.Windows.Forms.ListBox();
            this.listBox07 = new System.Windows.Forms.ListBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.listBox14 = new System.Windows.Forms.ListBox();
            this.listBox13 = new System.Windows.Forms.ListBox();
            this.button15 = new System.Windows.Forms.Button();
            this.listBox12 = new System.Windows.Forms.ListBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.listBox11 = new System.Windows.Forms.ListBox();
            this.listBox10 = new System.Windows.Forms.ListBox();
            this.button18 = new System.Windows.Forms.Button();
            this.listBox09 = new System.Windows.Forms.ListBox();
            this.button19 = new System.Windows.Forms.Button();
            this.listBox08 = new System.Windows.Forms.ListBox();
            this.m_timer_2nd = new System.Windows.Forms.Timer(this.components);
            this.m_timer_3rd = new System.Windows.Forms.Timer(this.components);
            this.m_timer_4th = new System.Windows.Forms.Timer(this.components);
            this.m_timer_1stSend = new System.Windows.Forms.Timer(this.components);
            this.m_timer_2ndSend = new System.Windows.Forms.Timer(this.components);
            this.m_timer_3rdSend = new System.Windows.Forms.Timer(this.components);
            this.m_timer_4thSend = new System.Windows.Forms.Timer(this.components);
            this.m_timer_ds = new System.Windows.Forms.Timer(this.components);
            this.listBox111 = new System.Windows.Forms.ListBox();
            this.listBox121 = new System.Windows.Forms.ListBox();
            this.m_timer_map_cctv = new System.Windows.Forms.Timer(this.components);
            this.m_timer_gen_cctv = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(0, 143);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(91, 20);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "StreamPlay";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(100, 143);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(91, 20);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "StreamStop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_view01
            // 
            this.btn_view01.Location = new System.Drawing.Point(0, 169);
            this.btn_view01.Name = "btn_view01";
            this.btn_view01.Size = new System.Drawing.Size(190, 20);
            this.btn_view01.TabIndex = 3;
            this.btn_view01.Tag = "1";
            this.btn_view01.Text = "01 발전소 종합현황";
            this.btn_view01.UseVisualStyleBackColor = true;
            this.btn_view01.Click += new System.EventHandler(this.btn_view01_Click);
            // 
            // btn_view02
            // 
            this.btn_view02.Location = new System.Drawing.Point(0, 195);
            this.btn_view02.Name = "btn_view02";
            this.btn_view02.Size = new System.Drawing.Size(190, 20);
            this.btn_view02.TabIndex = 4;
            this.btn_view02.Tag = "2";
            this.btn_view02.Text = "02 양양 양수발전 운전현황";
            this.btn_view02.UseVisualStyleBackColor = true;
            this.btn_view02.Click += new System.EventHandler(this.btn_view02_Click);
            // 
            // btn_view03
            // 
            this.btn_view03.Location = new System.Drawing.Point(0, 221);
            this.btn_view03.Name = "btn_view03";
            this.btn_view03.Size = new System.Drawing.Size(190, 20);
            this.btn_view03.TabIndex = 5;
            this.btn_view03.Tag = "3";
            this.btn_view03.Text = "03 345kV 차단기";
            this.btn_view03.UseVisualStyleBackColor = true;
            this.btn_view03.Click += new System.EventHandler(this.btn_view03_Click);
            // 
            // btn_view04
            // 
            this.btn_view04.Location = new System.Drawing.Point(0, 247);
            this.btn_view04.Name = "btn_view04";
            this.btn_view04.Size = new System.Drawing.Size(190, 20);
            this.btn_view04.TabIndex = 6;
            this.btn_view04.Tag = "4";
            this.btn_view04.Text = "04 상하부댐 현황";
            this.btn_view04.UseVisualStyleBackColor = true;
            this.btn_view04.Click += new System.EventHandler(this.btn_view04_Click);
            // 
            // btn_view05
            // 
            this.btn_view05.Location = new System.Drawing.Point(0, 273);
            this.btn_view05.Name = "btn_view05";
            this.btn_view05.Size = new System.Drawing.Size(190, 20);
            this.btn_view05.TabIndex = 7;
            this.btn_view05.Tag = "5";
            this.btn_view05.Text = "05 하부댐 여수로 소수력 어도";
            this.btn_view05.UseVisualStyleBackColor = true;
            this.btn_view05.Click += new System.EventHandler(this.btn_view05_Click);
            // 
            // btn_view10
            // 
            this.btn_view10.Location = new System.Drawing.Point(0, 403);
            this.btn_view10.Name = "btn_view10";
            this.btn_view10.Size = new System.Drawing.Size(190, 20);
            this.btn_view10.TabIndex = 12;
            this.btn_view10.Tag = "10";
            this.btn_view10.Text = "10 하부댐 수위 및 수위예측";
            this.btn_view10.UseVisualStyleBackColor = true;
            this.btn_view10.Click += new System.EventHandler(this.btn_view10_Click);
            // 
            // btn_view09
            // 
            this.btn_view09.Location = new System.Drawing.Point(0, 377);
            this.btn_view09.Name = "btn_view09";
            this.btn_view09.Size = new System.Drawing.Size(190, 20);
            this.btn_view09.TabIndex = 11;
            this.btn_view09.Tag = "9";
            this.btn_view09.Text = "09 18kV 차단기";
            this.btn_view09.UseVisualStyleBackColor = true;
            this.btn_view09.Click += new System.EventHandler(this.btn_view09_Click);
            // 
            // btn_view08
            // 
            this.btn_view08.Location = new System.Drawing.Point(0, 351);
            this.btn_view08.Name = "btn_view08";
            this.btn_view08.Size = new System.Drawing.Size(190, 20);
            this.btn_view08.TabIndex = 10;
            this.btn_view08.Tag = "8";
            this.btn_view08.Text = "08 양양 양수발전 운전현황";
            this.btn_view08.UseVisualStyleBackColor = true;
            this.btn_view08.Click += new System.EventHandler(this.btn_view08_Click);
            // 
            // btn_view07
            // 
            this.btn_view07.Location = new System.Drawing.Point(0, 325);
            this.btn_view07.Name = "btn_view07";
            this.btn_view07.Size = new System.Drawing.Size(190, 20);
            this.btn_view07.TabIndex = 9;
            this.btn_view07.Tag = "7";
            this.btn_view07.Text = "07 수력발전소 종합현황";
            this.btn_view07.UseVisualStyleBackColor = true;
            this.btn_view07.Click += new System.EventHandler(this.btn_view07_Click);
            // 
            // btn_view06
            // 
            this.btn_view06.Location = new System.Drawing.Point(0, 299);
            this.btn_view06.Name = "btn_view06";
            this.btn_view06.Size = new System.Drawing.Size(190, 20);
            this.btn_view06.TabIndex = 8;
            this.btn_view06.Tag = "6";
            this.btn_view06.Text = "06 기상현황 레이더 영상";
            this.btn_view06.UseVisualStyleBackColor = true;
            this.btn_view06.Click += new System.EventHandler(this.btn_view06_Click);
            // 
            // btn_view13
            // 
            this.btn_view13.Location = new System.Drawing.Point(0, 481);
            this.btn_view13.Name = "btn_view13";
            this.btn_view13.Size = new System.Drawing.Size(190, 20);
            this.btn_view13.TabIndex = 15;
            this.btn_view13.Tag = "13";
            this.btn_view13.Text = "13 태풍 진행경로";
            this.btn_view13.UseVisualStyleBackColor = true;
            this.btn_view13.Click += new System.EventHandler(this.btn_view13_Click);
            // 
            // btn_view12
            // 
            this.btn_view12.Location = new System.Drawing.Point(0, 455);
            this.btn_view12.Name = "btn_view12";
            this.btn_view12.Size = new System.Drawing.Size(190, 20);
            this.btn_view12.TabIndex = 14;
            this.btn_view12.Tag = "12";
            this.btn_view12.Text = "12 하부댐 인근지역 CCTV";
            this.btn_view12.UseVisualStyleBackColor = true;
            this.btn_view12.Click += new System.EventHandler(this.btn_view12_Click);
            // 
            // btn_view11
            // 
            this.btn_view11.Location = new System.Drawing.Point(0, 429);
            this.btn_view11.Name = "btn_view11";
            this.btn_view11.Size = new System.Drawing.Size(190, 20);
            this.btn_view11.TabIndex = 13;
            this.btn_view11.Tag = "11";
            this.btn_view11.Text = "11 발전소 CCTV";
            this.btn_view11.UseVisualStyleBackColor = true;
            this.btn_view11.Click += new System.EventHandler(this.btn_view11_Click);
            // 
            // txt_SelectedViewNo
            // 
            this.txt_SelectedViewNo.Location = new System.Drawing.Point(0, 523);
            this.txt_SelectedViewNo.Name = "txt_SelectedViewNo";
            this.txt_SelectedViewNo.Size = new System.Drawing.Size(190, 21);
            this.txt_SelectedViewNo.TabIndex = 16;
            this.txt_SelectedViewNo.Visible = false;
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(0, 91);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(91, 20);
            this.btn_display.TabIndex = 17;
            this.btn_display.Text = "게시";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(1, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(90, 76);
            this.listBox1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 20);
            this.button1.TabIndex = 19;
            this.button1.Text = "초기화";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 20);
            this.button2.TabIndex = 21;
            this.button2.Text = "DbStop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 20);
            this.button3.TabIndex = 20;
            this.button3.Text = "DbPlay";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // m_timer_PC_INFO
            // 
            this.m_timer_PC_INFO.Interval = 1000;
            this.m_timer_PC_INFO.Tick += new System.EventHandler(this.Tick_timer_PC_INFO);
            // 
            // m_timer_1st
            // 
            this.m_timer_1st.Interval = 3000;
            this.m_timer_1st.Tick += new System.EventHandler(this.Tick_timer_1st);
            // 
            // listBox01
            // 
            this.listBox01.FormattingEnabled = true;
            this.listBox01.ItemHeight = 12;
            this.listBox01.Location = new System.Drawing.Point(202, 34);
            this.listBox01.Name = "listBox01";
            this.listBox01.Size = new System.Drawing.Size(150, 220);
            this.listBox01.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(202, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 20);
            this.button4.TabIndex = 23;
            this.button4.Text = "01";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(358, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 20);
            this.button5.TabIndex = 25;
            this.button5.Text = "02";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // listBox02
            // 
            this.listBox02.FormattingEnabled = true;
            this.listBox02.ItemHeight = 12;
            this.listBox02.Location = new System.Drawing.Point(358, 34);
            this.listBox02.Name = "listBox02";
            this.listBox02.Size = new System.Drawing.Size(150, 220);
            this.listBox02.TabIndex = 24;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(100, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 20);
            this.button6.TabIndex = 26;
            this.button6.Text = ">";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(100, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 20);
            this.button7.TabIndex = 27;
            this.button7.Text = "<";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // listBox03
            // 
            this.listBox03.FormattingEnabled = true;
            this.listBox03.ItemHeight = 12;
            this.listBox03.Location = new System.Drawing.Point(514, 34);
            this.listBox03.Name = "listBox03";
            this.listBox03.Size = new System.Drawing.Size(150, 220);
            this.listBox03.TabIndex = 28;
            // 
            // listBox04
            // 
            this.listBox04.FormattingEnabled = true;
            this.listBox04.ItemHeight = 12;
            this.listBox04.Location = new System.Drawing.Point(670, 34);
            this.listBox04.Name = "listBox04";
            this.listBox04.Size = new System.Drawing.Size(150, 220);
            this.listBox04.TabIndex = 29;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(514, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 20);
            this.button8.TabIndex = 30;
            this.button8.Text = "03";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(670, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(91, 20);
            this.button9.TabIndex = 31;
            this.button9.Text = "04";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // listBox05
            // 
            this.listBox05.FormattingEnabled = true;
            this.listBox05.ItemHeight = 12;
            this.listBox05.Location = new System.Drawing.Point(826, 34);
            this.listBox05.Name = "listBox05";
            this.listBox05.Size = new System.Drawing.Size(150, 220);
            this.listBox05.TabIndex = 32;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(826, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(91, 20);
            this.button10.TabIndex = 33;
            this.button10.Text = "05";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // listBox06
            // 
            this.listBox06.BackColor = System.Drawing.Color.White;
            this.listBox06.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox06.FormattingEnabled = true;
            this.listBox06.ItemHeight = 12;
            this.listBox06.Location = new System.Drawing.Point(982, 34);
            this.listBox06.Name = "listBox06";
            this.listBox06.Size = new System.Drawing.Size(150, 216);
            this.listBox06.TabIndex = 34;
            // 
            // listBox07
            // 
            this.listBox07.FormattingEnabled = true;
            this.listBox07.ItemHeight = 12;
            this.listBox07.Location = new System.Drawing.Point(1138, 34);
            this.listBox07.Name = "listBox07";
            this.listBox07.Size = new System.Drawing.Size(150, 220);
            this.listBox07.TabIndex = 35;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(982, 12);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(91, 20);
            this.button11.TabIndex = 36;
            this.button11.Text = "06";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1138, 12);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(91, 20);
            this.button12.TabIndex = 37;
            this.button12.Text = "07";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(1138, 259);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(91, 20);
            this.button13.TabIndex = 51;
            this.button13.Text = "14";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(982, 259);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(91, 20);
            this.button14.TabIndex = 50;
            this.button14.Text = "13";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // listBox14
            // 
            this.listBox14.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox14.FormattingEnabled = true;
            this.listBox14.ItemHeight = 12;
            this.listBox14.Location = new System.Drawing.Point(1138, 281);
            this.listBox14.Name = "listBox14";
            this.listBox14.Size = new System.Drawing.Size(150, 216);
            this.listBox14.TabIndex = 49;
            // 
            // listBox13
            // 
            this.listBox13.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox13.FormattingEnabled = true;
            this.listBox13.ItemHeight = 12;
            this.listBox13.Location = new System.Drawing.Point(982, 281);
            this.listBox13.Name = "listBox13";
            this.listBox13.Size = new System.Drawing.Size(150, 216);
            this.listBox13.TabIndex = 48;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(826, 259);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(91, 20);
            this.button15.TabIndex = 47;
            this.button15.Text = "12";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // listBox12
            // 
            this.listBox12.FormattingEnabled = true;
            this.listBox12.ItemHeight = 12;
            this.listBox12.Location = new System.Drawing.Point(826, 281);
            this.listBox12.Name = "listBox12";
            this.listBox12.Size = new System.Drawing.Size(150, 112);
            this.listBox12.TabIndex = 46;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(670, 259);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(91, 20);
            this.button16.TabIndex = 45;
            this.button16.Text = "11";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(514, 259);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(91, 20);
            this.button17.TabIndex = 44;
            this.button17.Text = "10";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // listBox11
            // 
            this.listBox11.FormattingEnabled = true;
            this.listBox11.ItemHeight = 12;
            this.listBox11.Location = new System.Drawing.Point(670, 281);
            this.listBox11.Name = "listBox11";
            this.listBox11.Size = new System.Drawing.Size(150, 112);
            this.listBox11.TabIndex = 43;
            // 
            // listBox10
            // 
            this.listBox10.FormattingEnabled = true;
            this.listBox10.ItemHeight = 12;
            this.listBox10.Location = new System.Drawing.Point(514, 281);
            this.listBox10.Name = "listBox10";
            this.listBox10.Size = new System.Drawing.Size(150, 220);
            this.listBox10.TabIndex = 42;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(358, 259);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(91, 20);
            this.button18.TabIndex = 41;
            this.button18.Text = "09";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // listBox09
            // 
            this.listBox09.FormattingEnabled = true;
            this.listBox09.ItemHeight = 12;
            this.listBox09.Location = new System.Drawing.Point(358, 281);
            this.listBox09.Name = "listBox09";
            this.listBox09.Size = new System.Drawing.Size(150, 220);
            this.listBox09.TabIndex = 40;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(202, 259);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(91, 20);
            this.button19.TabIndex = 39;
            this.button19.Text = "08";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // listBox08
            // 
            this.listBox08.FormattingEnabled = true;
            this.listBox08.ItemHeight = 12;
            this.listBox08.Location = new System.Drawing.Point(202, 281);
            this.listBox08.Name = "listBox08";
            this.listBox08.Size = new System.Drawing.Size(150, 220);
            this.listBox08.TabIndex = 38;
            // 
            // m_timer_2nd
            // 
            this.m_timer_2nd.Interval = 3000;
            this.m_timer_2nd.Tick += new System.EventHandler(this.Tick_timer_2nd);
            // 
            // m_timer_3rd
            // 
            this.m_timer_3rd.Interval = 3000;
            this.m_timer_3rd.Tick += new System.EventHandler(this.Tick_timer_3rd);
            // 
            // m_timer_4th
            // 
            this.m_timer_4th.Interval = 3000;
            this.m_timer_4th.Tick += new System.EventHandler(this.Tick_timer_4th);
            // 
            // m_timer_1stSend
            // 
            this.m_timer_1stSend.Interval = 3000;
            this.m_timer_1stSend.Tick += new System.EventHandler(this.Tick_timer_1stSend);
            // 
            // m_timer_2ndSend
            // 
            this.m_timer_2ndSend.Interval = 3000;
            this.m_timer_2ndSend.Tick += new System.EventHandler(this.Tick_timer_2ndSend);
            // 
            // m_timer_3rdSend
            // 
            this.m_timer_3rdSend.Interval = 3000;
            this.m_timer_3rdSend.Tick += new System.EventHandler(this.Tick_timer_3rdSend);
            // 
            // m_timer_4thSend
            // 
            this.m_timer_4thSend.Interval = 3000;
            this.m_timer_4thSend.Tick += new System.EventHandler(this.Tick_timer_4thSend);
            // 
            // m_timer_ds
            // 
            this.m_timer_ds.Interval = 1000;
            this.m_timer_ds.Tick += new System.EventHandler(this.Tick_timer_DS);
            // 
            // listBox111
            // 
            this.listBox111.FormattingEnabled = true;
            this.listBox111.ItemHeight = 12;
            this.listBox111.Items.AddRange(new object[] {
            "FF",
            "FF",
            "FF",
            "FF",
            "FF",
            "FF",
            "FF",
            "FF",
            "FF",
            "FF"});
            this.listBox111.Location = new System.Drawing.Point(670, 389);
            this.listBox111.Name = "listBox111";
            this.listBox111.Size = new System.Drawing.Size(150, 112);
            this.listBox111.TabIndex = 52;
            // 
            // listBox121
            // 
            this.listBox121.FormattingEnabled = true;
            this.listBox121.ItemHeight = 12;
            this.listBox121.Items.AddRange(new object[] {
            "FF",
            "FF",
            "FF",
            "FF",
            "FF",
            "FF"});
            this.listBox121.Location = new System.Drawing.Point(826, 389);
            this.listBox121.Name = "listBox121";
            this.listBox121.Size = new System.Drawing.Size(150, 112);
            this.listBox121.TabIndex = 53;
            // 
            // m_timer_map_cctv
            // 
            this.m_timer_map_cctv.Interval = 1000;
            this.m_timer_map_cctv.Tick += new System.EventHandler(this.timer_map_cctv_Tick);
            // 
            // m_timer_gen_cctv
            // 
            this.m_timer_gen_cctv.Interval = 2000;
            this.m_timer_gen_cctv.Tick += new System.EventHandler(this.m_timer_gen_cctv_Tick);
            // 
            // ViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 501);
            this.Controls.Add(this.listBox121);
            this.Controls.Add(this.listBox111);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.listBox14);
            this.Controls.Add(this.listBox13);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.listBox12);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.listBox11);
            this.Controls.Add(this.listBox10);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.listBox09);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.listBox08);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.listBox07);
            this.Controls.Add(this.listBox06);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.listBox05);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.listBox04);
            this.Controls.Add(this.listBox03);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listBox02);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox01);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.txt_SelectedViewNo);
            this.Controls.Add(this.btn_view13);
            this.Controls.Add(this.btn_view12);
            this.Controls.Add(this.btn_view11);
            this.Controls.Add(this.btn_view10);
            this.Controls.Add(this.btn_view09);
            this.Controls.Add(this.btn_view08);
            this.Controls.Add(this.btn_view07);
            this.Controls.Add(this.btn_view06);
            this.Controls.Add(this.btn_view05);
            this.Controls.Add(this.btn_view04);
            this.Controls.Add(this.btn_view03);
            this.Controls.Add(this.btn_view02);
            this.Controls.Add(this.btn_view01);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainSysView";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewMain_Close);
            this.Load += new System.EventHandler(this.ViewMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_view01;
        private System.Windows.Forms.Button btn_view02;
        private System.Windows.Forms.Button btn_view03;
        private System.Windows.Forms.Button btn_view04;
        private System.Windows.Forms.Button btn_view05;
        private System.Windows.Forms.Button btn_view10;
        private System.Windows.Forms.Button btn_view09;
        private System.Windows.Forms.Button btn_view08;
        private System.Windows.Forms.Button btn_view07;
        private System.Windows.Forms.Button btn_view06;
        private System.Windows.Forms.Button btn_view13;
        private System.Windows.Forms.Button btn_view12;
        private System.Windows.Forms.Button btn_view11;
        private System.Windows.Forms.TextBox txt_SelectedViewNo;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer m_timer_PC_INFO;
        private System.Windows.Forms.Timer m_timer_1st;
        private System.Windows.Forms.ListBox listBox01;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox02;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox listBox03;
        private System.Windows.Forms.ListBox listBox04;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ListBox listBox05;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ListBox listBox06;
        private System.Windows.Forms.ListBox listBox07;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.ListBox listBox14;
        private System.Windows.Forms.ListBox listBox13;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.ListBox listBox12;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.ListBox listBox11;
        private System.Windows.Forms.ListBox listBox10;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.ListBox listBox09;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.ListBox listBox08;
        private System.Windows.Forms.Timer m_timer_2nd;
        private System.Windows.Forms.Timer m_timer_3rd;
        private System.Windows.Forms.Timer m_timer_4th;
        private System.Windows.Forms.Timer m_timer_1stSend;
        private System.Windows.Forms.Timer m_timer_2ndSend;
        private System.Windows.Forms.Timer m_timer_3rdSend;
        private System.Windows.Forms.Timer m_timer_4thSend;
        private System.Windows.Forms.Timer m_timer_ds;
        private System.Windows.Forms.ListBox listBox111;
        private System.Windows.Forms.ListBox listBox121;
        private System.Windows.Forms.Timer m_timer_map_cctv;
        private System.Windows.Forms.Timer m_timer_gen_cctv;
    }
}

