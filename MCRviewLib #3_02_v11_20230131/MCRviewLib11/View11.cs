using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
//using VMS_CS;
//using NdasSDKDemo.Resource;
using MCRviewLib11.Resource;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections;

namespace MCRviewLib11
{
    public partial class View11 : Form
    {
        //[DllImport("netcam.dll")]
        //extern public static int ndassock_setdisplay(IntPtr h_ncam, IntPtr hWnd);
        //[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        //public static extern IntPtr GetActiveWindow(); 
       
        protected delegate void RefreshPicture();
        protected delegate void RefreshRemain(string remain);
        protected delegate void RefreshStatus(string status);
        //protected delegate void NDAS_H();

      
        public static IntPtr pnetcam = IntPtr.Zero;
        public static IntPtr pnetcam01 = IntPtr.Zero;
        public static IntPtr pnetcam02 = IntPtr.Zero;
        public static IntPtr pnetcam03 = IntPtr.Zero;
        public static IntPtr pnetcam04 = IntPtr.Zero;
        public static IntPtr pnetcam05 = IntPtr.Zero;
        public static IntPtr pnetcam06 = IntPtr.Zero;
        public static IntPtr pnetcam07 = IntPtr.Zero;
        public static IntPtr pnetcam08 = IntPtr.Zero;
        public static IntPtr pnetcam09 = IntPtr.Zero;
        public static IntPtr pnetcam10 = IntPtr.Zero;
        public static IntPtr pnetcam11 = IntPtr.Zero;
        public static IntPtr pnetcam12 = IntPtr.Zero;
        public static IntPtr pnetcam13 = IntPtr.Zero;
        public static IntPtr pnetcam14 = IntPtr.Zero;
        public static IntPtr pnetcam15 = IntPtr.Zero;
        public static IntPtr pnetcam16 = IntPtr.Zero;
    

        public static IntPtr playbacknetcam = IntPtr.Zero;

        public static string dateselect = DateTime.Now.ToString("yyy-MM-dd hh:mm:ss").Trim();
        public static string searchdate = DateTime.Now.ToString("yyy-MM-dd").Trim();
        public static string searchtime = DateTime.Now.ToString("hh:mm:ss").Trim();
        public static bool m_stSearch = false;
        public static int isdisplay = 0;

        public ArrayList ip_list = new ArrayList();

        string ServerName = "sdktest";
        string IP = "192.168.1.9";
        string USER = "admin";
        string Password = "wizbrain1!";
        string WebPort = "80";
        string DevicePort = "9001";
        string Channel = "1";
        string NDASID = "BGPQS-FKUFM-U8PU0-52G3S-R4FTU";
        string DiskNO = "0";
        string Member = "62D1F6";
        
	    char[] ndas_id = new char[21];
	    char[] write_key = new char[6];	
        char[] str = new char[256];

        int buf_size = HttpClint.MAX_REPLY_SIZE;
        char[] buffer = new char[HttpClint.MAX_REPLY_SIZE];
        int timeOut;

        int search_type = HttpClint.SEARCH_TYPE_LXX;
        int audio_enable = 1;

        string bootpath = "";

     
        DisplayParam disparam01 = new DisplayParam();
        DisplayParam disparam02 = new DisplayParam();
        DisplayParam disparam03 = new DisplayParam();
        DisplayParam disparam04 = new DisplayParam();
        DisplayParam disparam05 = new DisplayParam();
        DisplayParam disparam06 = new DisplayParam();
        DisplayParam disparam07 = new DisplayParam();
        DisplayParam disparam08 = new DisplayParam();
        DisplayParam disparam09 = new DisplayParam();
        DisplayParam disparam10 = new DisplayParam();
        DisplayParam disparam11 = new DisplayParam();
        DisplayParam disparam12 = new DisplayParam();
        DisplayParam disparam13 = new DisplayParam();
        DisplayParam disparam14 = new DisplayParam();
        DisplayParam disparam15 = new DisplayParam();
        DisplayParam disparam16 = new DisplayParam();
    

        DownLoadParam downloadparam = new DownLoadParam();
        DownLoadParam2 downloadparam2 = new DownLoadParam2();
        PlayBackParam playbackparam = new PlayBackParam();
        PtzContrlParam ptzparam = new PtzContrlParam();

        string dateTime = System.DateTime.Now.ToString("yyyy.MM.dd tt hh:mm:ss");

        public View11()
        {
            InitializeComponent();
            //int ret = Netcam.initialize_netcam();
            //ResourceManager rm = new ResourceManager(typeof(Resource1));//
            ResourceManager rm = new ResourceManager(typeof(Resource2));//

            string String1 = (string)rm.GetObject("String1");
            string String2 = (string)rm.GetObject("String2");
            string String3 = (string)rm.GetObject("String3");
            string String4 = (string)rm.GetObject("String4");
            string String5 = (string)rm.GetObject("String5");
            string String6 = (string)rm.GetObject("String6");
            string String7 = (string)rm.GetObject("String7");
            string String8 = (string)rm.GetObject("String8");
            string String9 = (string)rm.GetObject("String9");
            string String10 = (string)rm.GetObject("String10");
            string String11 = (string)rm.GetObject("String11");
            string String12 = (string)rm.GetObject("String12");
            string String13 = (string)rm.GetObject("String13");
            string String14 = (string)rm.GetObject("String14");
            string String15 = (string)rm.GetObject("String15");
            string String16 = (string)rm.GetObject("String16");
            string String17 = (string)rm.GetObject("String17");
            string String18 = (string)rm.GetObject("String18");
            string String19 = (string)rm.GetObject("String19");
            string String20 = (string)rm.GetObject("String20");
            string String21 = (string)rm.GetObject("String21");
            string String22 = (string)rm.GetObject("String22");
            string String23 = (string)rm.GetObject("String23");
            string String24 = (string)rm.GetObject("String24");
            string String25 = (string)rm.GetObject("String25");
            string String26 = (string)rm.GetObject("String26");
            string String27 = (string)rm.GetObject("String27");
            string String28 = (string)rm.GetObject("String28");
            string String29 = (string)rm.GetObject("String29");
            string String30 = (string)rm.GetObject("String30");
            string String31 = (string)rm.GetObject("String31");
            string String32 = (string)rm.GetObject("String32");
            string String33 = (string)rm.GetObject("String33");
            string String34 = (string)rm.GetObject("String34");
            string String35 = (string)rm.GetObject("String35");
            string String36 = (string)rm.GetObject("String36");
            string String37 = (string)rm.GetObject("String37");
            string String38 = (string)rm.GetObject("String38");
            string String39 = (string)rm.GetObject("String39");
            string String40 = (string)rm.GetObject("String40");
            string String41 = (string)rm.GetObject("String41");
            string String42 = (string)rm.GetObject("String42");
            string String43 = (string)rm.GetObject("String43");
            string String44 = (string)rm.GetObject("String44");
            string String45 = (string)rm.GetObject("String45");
            string String46 = (string)rm.GetObject("String46");
            string String47 = (string)rm.GetObject("String47");
            string String48 = (string)rm.GetObject("String48");
            string String49 = (string)rm.GetObject("String49");
            string String50 = (string)rm.GetObject("String50");
            string String51 = (string)rm.GetObject("String51");
            string String52 = (string)rm.GetObject("String52");
            string String53 = (string)rm.GetObject("String53");
            string String54 = (string)rm.GetObject("String54");
            string String55 = (string)rm.GetObject("String55");
            string String56 = (string)rm.GetObject("String56");
            string String57 = (string)rm.GetObject("String57");
            string String58 = (string)rm.GetObject("String58");
            string String59 = (string)rm.GetObject("String59");
            string String60 = (string)rm.GetObject("String60");
            string String61 = (string)rm.GetObject("String61");
            string String62 = (string)rm.GetObject("String62");
            string String63 = (string)rm.GetObject("String63");
            string String64 = (string)rm.GetObject("String64");
            string String65 = (string)rm.GetObject("String65");
            string String66 = (string)rm.GetObject("String66");
            string String67 = (string)rm.GetObject("String67");
            string String68 = (string)rm.GetObject("String68");

            this.button1.Text = String1;
            this.label1.Text = String2;
            this.label2.Text = String3;
            this.label3.Text = String4;
            this.label4.Text = String5;
            this.label5.Text = String6;
            this.label6.Text = String7;
            this.label7.Text = String8;
            this.label8.Text = String9;
            this.label9.Text = String10;
            this.label10.Text = String11;
            this.label11.Text = String12;
            this.radioButton1.Text = String13;
            this.radioButton2.Text = String14;
            this.checkBox1.Text = String15;
            this.button2.Text = String16;
            this.btn_stop_11.Text = String17;
            this.button4.Text = String18;
            this.button5.Text = String19;
            this.button6.Text = String20;
            this.button7.Text = String21;
            this.button8.Text = String22;
            this.button9.Text = String23;
            this.button10.Text = String24;
            this.button11.Text = String25;
            this.button12.Text = String26;
            this.button13.Text = String27;
            this.button14.Text = String28;
            this.button15.Text = String29;
            this.button16.Text = String30;
            this.button17.Text = String31;
            this.label12.Text = String32;
            this.button18.Text = String33;
            this.button19.Text = String34;
            this.button20.Text = String35;
            this.button21.Text = String36;
            this.label13.Text = String37;
            this.checkBox2.Text = String38;
            this.label14.Text = String39;
            this.button22.Text = String40;
            this.button23.Text = String41;
            this.label15.Text = String42;
            this.label16.Text = String43;
            this.label17.Text = String44;
            this.button24.Text = String45;
            this.button25.Text = String46;
            this.button26.Text = String47;
            this.label18.Text = String48;
            this.label19.Text = String49;
            this.button27.Text = String50;
            this.button28.Text = String51;
            this.button29.Text = String52;
            this.button30.Text = String53;
            this.button31.Text = String54;
            this.button32.Text = String55;
            this.button33.Text = String56;
            this.button34.Text = String57;
            this.button35.Text = String58;
            this.button36.Text = String59;
            this.button37.Text = String60;
            this.button38.Text = String61;
            this.button39.Text = String62;
            this.button40.Text = String63;
            this.label20.Text = String64;
            this.label21.Text = String65;
            this.checkBox3.Text = String66;
            this.button41.Text = String67;
            this.button42.Text = String68;

            textBox1.Text = ServerName;
            textBox2.Text = IP;
            textBox3.Text = USER;
            textBox4.Text = Password;
            textBox5.Text = WebPort;
            textBox6.Text = DevicePort;
            textBox7.Text = Channel;
            textBox8.Text = NDASID;
            textBox9.Text = DiskNO;
            textBox10.Text = Member;
            this.radioButton1.Enabled = true;
            this.radioButton2.Checked = true;
            textBox16.Text = dateselect;
            textBox17.Text = "300";
            textBox20.Text = "1";
            textBox21.Text = searchdate;
            textBox22.Text = searchtime;
            textBox23.Text = "0x0002";
            textBox11.Text = "6";
            textBox12.Text = "0x00";

            //if (search_type == HttpClint.SEARCH_TYPE_ARCA)
            //    this.radioButton1.Checked =true ;
            //else
            //    this.radioButton2.Checked = false;
        }


        //20220808sh SetChComboBox
        public void SetChComboBox()
        {
            comboBox2.SelectedIndex = 10;    //dispicturebox1
            comboBox3.SelectedIndex = 38;    //picturebox1
            comboBox4.SelectedIndex = 39;    //picturebox2
            comboBox5.SelectedIndex = 40;    //picturebox3
            comboBox6.SelectedIndex = 41;    //picturebox4
            comboBox7.SelectedIndex = 44;    //picturebox5
            comboBox8.SelectedIndex = 45;    //picturebox6
            comboBox9.SelectedIndex = 46;    //picturebox7

            /*
            comboBox10.SelectedIndex = 1;
            comboBox11.SelectedIndex = 2;
            comboBox12.SelectedIndex = 3;
            comboBox13.SelectedIndex = 4;
            comboBox14.SelectedIndex = 5;
            comboBox15.SelectedIndex = 6;
            comboBox16.SelectedIndex = 7;
            comboBox17.SelectedIndex = 8;
            */
        }

        
        //20220808sh Set16View
        public void Set16View()
        {
            int x = 0;
            int y = 0;
            int width = 480;
            int height = 210;
            dispictureBox1.SetBounds(0, (height * 0), width, height);
            pictureBox1.SetBounds(480, (height * 0), width, height);
            pictureBox2.SetBounds(960, (height * 0), width, height);
            pictureBox3.SetBounds(1440, (height * 0), width, height);

            pictureBox4.SetBounds(0, (height * 1) + 20, width, height);
            pictureBox5.SetBounds(480, (height * 1) + 20, width, height);
            pictureBox6.SetBounds(960, (height * 1) + 20, width, height);
            pictureBox7.SetBounds(1440, (height * 1) + 20, width, height);

            pictureBox8.SetBounds(0, (height * 2) + 40, width, height);
            pictureBox9.SetBounds(480, (height * 2) + 40, width, height);
            pictureBox10.SetBounds(960, (height * 2) + 40, width, height);
            pictureBox11.SetBounds(1440, (height * 2) + 40, width, height);

            pictureBox12.SetBounds(0, (height * 3) + 60, width, height);
            pictureBox13.SetBounds(480, (height * 3) + 60, width, height);
            pictureBox14.SetBounds(960, (height * 3) + 60, width, height);
            pictureBox15.SetBounds(1440, (height * 3) + 60, width, height);

            int nwidth = 120;
            int nheight = 20;
            comboBox2.SetBounds(0, (height * 1), nwidth, nheight);
            comboBox3.SetBounds(480, (height * 1), nwidth, nheight);
            comboBox4.SetBounds(960, (height * 1), nwidth, nheight);
            comboBox5.SetBounds(1440, (height * 1), nwidth, nheight);

            comboBox6.SetBounds(0, (height * 2) + 20, nwidth, nheight);
            comboBox7.SetBounds(480, (height * 2) + 20, nwidth, nheight);
            comboBox8.SetBounds(960, (height * 2) + 20, nwidth, nheight);
            comboBox9.SetBounds(1440, (height * 2) + 20, nwidth, nheight);

            comboBox10.SetBounds(0, (height * 3) + 40, nwidth, nheight);
            comboBox11.SetBounds(480, (height * 3) + 40, nwidth, nheight);
            comboBox12.SetBounds(960, (height * 3) + 40, nwidth, nheight);
            comboBox13.SetBounds(1440, (height * 3) + 40, nwidth, nheight);

            comboBox14.SetBounds(0, (height * 4) + 60, nwidth, nheight);
            comboBox15.SetBounds(480, (height * 4) + 60, nwidth, nheight);
            comboBox16.SetBounds(960, (height * 4) + 60, nwidth, nheight);
            comboBox17.SetBounds(1440, (height * 4) + 60, nwidth, nheight);

            //SetChComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IP = textBox2.Text;
            WebPort = textBox5.Text;
            string[] s = NDASID.Split(new char[] { '-' });
            write_key = s[4].ToCharArray();
            string tmpstr = s[0] + s[1] + s[2] + s[3];
            StringBuilder str_buffer = new StringBuilder(HttpClint.MAX_REPLY_SIZE);
            
            ndas_id = tmpstr.ToCharArray();
            if (checkBox1.Checked)
            {
                audio_enable = 1;
            }
            else
            {
                audio_enable = 0;
            }

            if (radioButton1.Checked )
            {
                search_type = HttpClint.SEARCH_TYPE_ARCA;
            }
            if(radioButton2.Checked)
            {
                search_type = HttpClint.SEARCH_TYPE_LXX;
            }

            int request_ref = HttpClint.GetRequest(IP.ToString(), Int32.Parse(WebPort.ToString()), "/", USER.ToString(), Password.ToString());
            if (request_ref!=0)
            {
                if (HttpClint.WinHttpAuthSample(request_ref))
                {
                    Console.WriteLine("device search success");

                }
                else
                {
                    Console.WriteLine("device search error");
                }
            }
            //int flagNum;

            //int.TryParse(textBox7.Text, out Channel);
            Channel = textBox7.Text;

            string cmd = "/vb.htm?ch=" + Channel + "&getndasid0&getndasid1&getndasid2&getndasid3&getndaskey&getndasdiskno&getndasmember";
            HttpClint.LXXSendCommand(request_ref, cmd.ToString(), str_buffer, HttpClint.MAX_REPLY_SIZE);
            Debug.WriteLine(str_buffer);
            string temp_buffer = str_buffer.ToString();
            if (temp_buffer.Length != 0)
            {
                string id0 = CopyFromStr(temp_buffer, "getndasid0=", true);
                string id1 = CopyFromStr(temp_buffer, "getndasid1=", true);
                string id2 = CopyFromStr(temp_buffer, "getndasid2=", true);
                string id3 = CopyFromStr(temp_buffer, "getndasid3=", true);
                string key = CopyFromStr(temp_buffer, "getndaskey=", true);

                textBox8.Text = id0 + "-" + id1 + "-" + id2 + "-" + id3 + "-" + key;
                string diskno = CopyFromStr(temp_buffer, "getndasdiskno=", true);
                textBox9.Text = diskno;
                string member = CopyFromStr(temp_buffer, "getndasmember=", true);
                textBox10.Text = member;
            }
            if (request_ref!=0)
            {
                HttpClint.WinHttpClose(request_ref);
                Debug.WriteLine("CloseRequest");
            }
        }

        public void DrawPicture()
        {
            //result = ndassock_setdisplay(pnetcam, form1.Handle);
            int result = Netcam.ndassock_setdisplay(pnetcam01, dispictureBox1.Handle);
            Console.WriteLine("cam핸들 " + dispictureBox1.Handle + "반환값 " + result);
            result = Netcam.ndassock_play(pnetcam01);
            Console.WriteLine("반환 값 재생 " + result);
        }

        public void CurrentRemain(string str)
        {
            this.textBox18.Text = str;
        }
        public void CurrentStatus(string str)
        {
            this.textBox12.Text = str;
        }
        private string CopyFromStr(string str_source, string str_key, bool bl_contain_key) 
        { 
            int i_startPosition = str_source.IndexOf(str_key); 
            if (bl_contain_key) 
            {
                string idstr = str_source.Substring(i_startPosition + str_key.Length, 6);
                //string[] name = idstr.Split('\n');//
                //return str_source.Substring(i_startPosition + str_key.Length, 6);
                return idstr.Split('\n')[0];
            } 
            else 
            { 
                return str_source.Substring(i_startPosition, str_source.Length - i_startPosition); 
            } 
        }
        private string CopyFromStr1(string str_source, string str_key, bool bl_contain_key)
        {
            int i_startPosition = str_source.IndexOf(str_key);
            if (bl_contain_key)
            {
                string idstr = str_source.Substring(i_startPosition + str_key.Length, 4);
                //string[] name = idstr.Split('\n');//
                //return str_source.Substring(i_startPosition + str_key.Length, 6);
                return idstr.Split('\n')[0];
            }
            else
            {
                return str_source.Substring(i_startPosition, str_source.Length - i_startPosition);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            /*
                      IntPtr pnetcam = Netcam.netcam_create(
                        IntPtr.Zero,
                        "192.168.2.7",					// hostname : Camera IP or url
                        "9001",	// video port 设备端口. 9001
                        "80",		// web端口. 80
                        "BGPQSFKUFMU8PU052G3S",
                        "R4FTU",
                        0,
                        "62D1F6",
                        0,												// Disk Configuration
                        "00000000000000000000", "00000", 0,
                        "00000000000000000000", "00000", 0,
                        "00000000000000000000", "00000", 0,
                        "00000000000000000000", "00000", 0,
                        3,			// channel infomation(from 1 - ) 
                        "H264",												// codec name
                        1,
                        0,
                        0,
                        0,
                        "admin",								// 设备登录账号 ID admin
                        "9999");

                      int result = Netcam.ndassock_connect(pnetcam);
                      if (result != 0)
                      {
                          Console.WriteLine("can't camConnect");
                      }
                      result = Netcam.ndassock_setdisplay(pnetcam, this.Handle);
                      result = Netcam.ndassock_play(pnetcam);

                      result = Netcam.ndassock_stop(pnetcam);
                      result = Netcam.ndassock_disconnect(pnetcam);
                      result = Netcam.netcam_destroy(pnetcam);
            */
            if (View11.isdisplay == 2)
            {
                MessageBox.Show("isdisplya is 2");
                return;
            }
            
                    if (checkBox1.Checked)
                    {
                        audio_enable = 1;
                    }
                    else
                    {
                        audio_enable = 0;
                    }

                    if (radioButton1.Checked)
                    {
                        search_type = HttpClint.SEARCH_TYPE_ARCA;
                    }
                    if (radioButton2.Checked)
                    {
                        search_type = HttpClint.SEARCH_TYPE_LXX;
                    }

                    disparam01.ServerName = textBox1.Text.ToString();
                    disparam01.IP = textBox2.Text.ToString();
                    disparam01.USER = textBox3.Text.ToString();
                    disparam01.Password = textBox4.Text.ToString();
                    disparam01.WebPort = textBox5.Text.ToString();
                    disparam01.DevicePort = textBox6.Text.ToString();
                    disparam01.Channel = textBox7.Text.ToString();
                    disparam01.NDASID = textBox8.Text.ToString();
                    disparam01.DiskNO = textBox9.Text.ToString();
                    disparam01.Member = textBox10.Text.ToString();     
                    disparam01.audio_enable = audio_enable;
                    disparam01.search_type = search_type;
                    DisplayParam.stop = 1;
                    
                    int x = 0;
                    if(textBox14.Text.ToString()!="")
                        x = Int32.Parse(textBox14.Text.ToString());
                    if (x < 0 || x > 3) x = 0;

                    if (x == 0) Netcam.ndassock_buffering_enable(0, 0);
                    else Netcam.ndassock_buffering_enable(1, x-1);

                    if (checkBox2.Checked) Netcam.ndassock_iframe_play_Enable(true);
                    else Netcam.ndassock_iframe_play_Enable(false);
            /*
            ptzparam.ServerName = textBox1.Text.ToString();
            ptzparam.IP = textBox2.Text.ToString();
            ptzparam.USER = textBox3.Text.ToString();
            ptzparam.Password = textBox4.Text.ToString();
            ptzparam.WebPort = textBox5.Text.ToString();
            ptzparam.DevicePort = textBox6.Text.ToString();
            ptzparam.Channel = textBox7.Text.ToString();
            ptzparam.NDASID = textBox8.Text.ToString();
            ptzparam.DiskNO = textBox9.Text.ToString();
            ptzparam.Member = textBox10.Text.ToString();
            PtzContrlParam.stop = 1;
            PtzContrlParam.query = 1;
            PtzContrlParam.ptzCmd = 0;
            //Thread thr1 = new Thread(ContralPTZ);
            //thr1.Start((object)ptzparam);
            */
        }


        public void btn_play_Click(object sender, EventArgs e)
        {
            //20221125
            //return;
            SetRuntimeView();
            //SetRuntime1View("7");
        }
       

        public void btn_stop_11_Click(object sender, EventArgs e)
        {
            //DisplayParam.stop = 0;
            PtzContrlParam.stop = 0;

            disparam01.stop1 = 0;
            disparam02.stop1 = 0;
            disparam03.stop1 = 0;
            disparam04.stop1 = 0;
            disparam05.stop1 = 0;
            disparam06.stop1 = 0;
            disparam07.stop1 = 0;
            disparam08.stop1 = 0;

            View11.isdisplay = 0;

            SetViewRefresh();
        }

        // 1채널
        public void btn_1ch_Click(object sender, EventArgs e)
        {
            Set1View();
        }

        // 4채널
        public void btn_4ch_Click(object sender, EventArgs e)
        {
            Set4View();
        }

        // 8채널
        public void btn_8ch_Click(object sender, EventArgs e)
        {
            Set8View();
        }



        //20220810dy Set1View
        public void Set1View()
        {
            
            //this.btn_stop_Click(this, null);
            
            dispictureBox1.BringToFront();

            //btn_play.BringToFront();
            //btn_stop.BringToFront();

            //btn_1ch.BringToFront();
            //btn_4ch.BringToFront();
            //btn_8ch.BringToFront();

            dispictureBox1.SetBounds(0, 0, 1920, 1080);
            dispictureBox1.Visible = true;

            //SetRuntime1View();
            
        }

        public Thread tt1 = null;

        public void SetRuntime1View(string strCH1)
        {
            try
            { 
                    /*
                    if (listBoxViewData11.Items.Count == 0) { return; }
                    else { disparam01.Channel = listBoxViewData11.Items[1].ToString(); }
                    */
                    //DisplayParam.stop = 1;

                    //btn_stop_11_Click(this, null);
            
                    string ch = strCH1;
                    disparam01.Channel = ch;
                    disparam01.displaywnd = dispictureBox1.Handle;
                    disparam01.Boxname = dispictureBox1.Name;
                    disparam01.pnetcamP = IntPtr.Zero;
                    tt1 = new Thread(PlayRuntimeView);
                    tt1.Start((object)disparam01);
                    //thr1.IsBackground = true;

                    //SetRuntimeView();
                    
            }
            catch(Exception e)
            {
                Console.WriteLine("1채널설정 EX");

            }
        }

        //20220810dy Set4View
        public void Set4View()
        {
            //this.btn_stop_Click(this, null);

            dispictureBox1.BringToFront();
            pictureBox1.BringToFront();
            pictureBox2.BringToFront();
            pictureBox3.BringToFront();

            //btn_play.BringToFront();
            //btn_stop_11.BringToFront();

            //btn_1ch.BringToFront();
            //btn_4ch.BringToFront();
            //btn_8ch.BringToFront();
            
            dispictureBox1.SetBounds(0, 0, 960, 540);
            pictureBox1.SetBounds(960, 0, 960, 540);
            pictureBox2.SetBounds(0, 540, 960, 540);
            pictureBox3.SetBounds(960, 540, 960, 540);

            dispictureBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            //SetRuntime4View();
        }
        public void SetRuntime4View()
        {
            if (listBoxViewData11.Items.Count == 0) { }
            else { disparam01.Channel = listBoxViewData11.Items[1].ToString(); }
            disparam01.displaywnd = dispictureBox1.Handle;
            disparam01.Boxname = dispictureBox1.Name;
            disparam01.pnetcamP = pnetcam01;
            Thread thr1 = new Thread(PlayRuntimeView);
            thr1.Start((object)disparam01);

            if (listBoxViewData11.Items.Count == 0) { }
            else { disparam02.Channel = listBoxViewData11.Items[2].ToString(); }
            disparam02.displaywnd = pictureBox1.Handle;
            disparam02.Boxname = pictureBox1.Name;
            disparam02.pnetcamP = pnetcam02;
            Thread thr2 = new Thread(PlayRuntimeView);
            thr2.Start((object)disparam02);

            if (listBoxViewData11.Items.Count == 0) { }
            else { disparam03.Channel = listBoxViewData11.Items[3].ToString(); }
            disparam03.displaywnd = pictureBox2.Handle;
            disparam03.Boxname = pictureBox2.Name;
            disparam03.pnetcamP = pnetcam03;
            Thread thr3 = new Thread(PlayRuntimeView);
            thr3.Start((object)disparam03);

            if (listBoxViewData11.Items.Count == 0) { }
            else { disparam04.Channel = listBoxViewData11.Items[4].ToString(); }
            disparam04.displaywnd = pictureBox3.Handle;
            disparam04.Boxname = pictureBox3.Name;
            disparam04.pnetcamP = pnetcam04;
            Thread thr4 = new Thread(PlayRuntimeView);
            thr4.Start((object)disparam04);
        }

        //20220810dy Set8View
        public void Set8View()
        {
            //this.btn_stop_Click(this, null);
            
            dispictureBox1.BringToFront();
            pictureBox1.BringToFront();
            pictureBox2.BringToFront();
            pictureBox3.BringToFront();
            pictureBox4.BringToFront();
            pictureBox5.BringToFront();
            pictureBox6.BringToFront();
            pictureBox7.BringToFront();

            //btn_play.BringToFront();
            //btn_stop_11.BringToFront();

            //btn_1ch.BringToFront();
            //btn_4ch.BringToFront();
            //btn_8ch.BringToFront();

            dispictureBox1.SetBounds(0, 0, 1440, 810);
            pictureBox1.SetBounds(1440, 0, 480, 270);
            pictureBox2.SetBounds(1440, 270, 480, 270);
            pictureBox3.SetBounds(1440, 540, 480, 270);
            pictureBox4.SetBounds(1440, 810, 480, 270);
            pictureBox5.SetBounds(0, 810, 480, 270);
            pictureBox6.SetBounds(480, 810, 480, 270);
            pictureBox7.SetBounds(960, 810, 480, 270);

            dispictureBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;

            //SetRuntime8View();
        }


        public void SetRuntime8View()
        {
            if (listBoxViewData11.Items.Count == 0) { }
            else { disparam01.Channel = listBoxViewData11.Items[1].ToString(); }
            disparam01.displaywnd = dispictureBox1.Handle;
            disparam01.Boxname = dispictureBox1.Name;
            disparam01.pnetcamP = pnetcam01;
            Thread thr1 = new Thread(PlayRuntimeView);
            thr1.Start((object)disparam01);

            if (listBoxViewData11.Items.Count == 0) { }
            else { disparam02.Channel = listBoxViewData11.Items[2].ToString(); }
            disparam02.displaywnd = pictureBox1.Handle;
            disparam02.Boxname = pictureBox1.Name;
            disparam02.pnetcamP = pnetcam02;
            Thread thr2 = new Thread(PlayRuntimeView);
            thr2.Start((object)disparam02);

            if (listBoxViewData11.Items.Count == 0) { }
            else { disparam03.Channel = listBoxViewData11.Items[3].ToString(); }
            disparam03.displaywnd = pictureBox2.Handle;
            disparam03.Boxname = pictureBox2.Name;
            disparam03.pnetcamP = pnetcam03;
            Thread thr3 = new Thread(PlayRuntimeView);
            thr3.Start((object)disparam03);

            if (listBoxViewData11.Items.Count == 0) { }
            else { disparam04.Channel = listBoxViewData11.Items[4].ToString(); }
            disparam04.displaywnd = pictureBox3.Handle;
            disparam04.Boxname = pictureBox3.Name;
            disparam04.pnetcamP = pnetcam04;
            Thread thr4 = new Thread(PlayRuntimeView);
            thr4.Start((object)disparam04);

            if (listBoxViewData11.Items.Count == 0) { }
            else { disparam05.Channel = listBoxViewData11.Items[5].ToString(); }
            disparam05.displaywnd = pictureBox4.Handle;
            disparam05.Boxname = pictureBox4.Name;
            disparam05.pnetcamP = pnetcam05;
            Thread thr5 = new Thread(PlayRuntimeView);
            thr5.Start((object)disparam05);

            if (listBoxViewData11.Items.Count == 0) { }
            else { disparam06.Channel = listBoxViewData11.Items[6].ToString(); }
            disparam06.displaywnd = pictureBox5.Handle;
            disparam06.Boxname = pictureBox5.Name;
            disparam06.pnetcamP = pnetcam06;
            Thread thr6 = new Thread(PlayRuntimeView);
            thr6.Start((object)disparam06);

            if (listBoxViewData11.Items.Count == 0) { }
            else { disparam07.Channel = listBoxViewData11.Items[7].ToString(); }
            disparam07.displaywnd = pictureBox6.Handle;
            disparam07.Boxname = pictureBox6.Name;
            disparam07.pnetcamP = pnetcam07;
            Thread thr7 = new Thread(PlayRuntimeView);
            thr7.Start((object)disparam07);

            if (listBoxViewData11.Items.Count == 0) { }
            else { disparam08.Channel = listBoxViewData11.Items[8].ToString(); }
            disparam08.displaywnd = pictureBox7.Handle;
            disparam08.Boxname = pictureBox7.Name;
            disparam08.pnetcamP = pnetcam08;
            Thread thr8 = new Thread(PlayRuntimeView);
            thr8.Start((object)disparam08);
        }

        public void SetDefaultView()
        {
            dispictureBox1.BringToFront();
            pictureBox1.BringToFront();
            pictureBox2.BringToFront();
            pictureBox3.BringToFront();
            pictureBox4.BringToFront();
            pictureBox5.BringToFront();
            pictureBox6.BringToFront();
            pictureBox7.BringToFront();

            btn_play.BringToFront();
            btn_stop_11.BringToFront();

            btn_1ch.BringToFront();
            btn_4ch.BringToFront();
            btn_8ch.BringToFront();

            dispictureBox1.SetBounds(0, 0, 1440, 810);
            pictureBox1.SetBounds(1440, 0, 480, 270);
            pictureBox2.SetBounds(1440, 270, 480, 270);
            pictureBox3.SetBounds(1440, 540, 480, 270);
            pictureBox4.SetBounds(1440, 810, 480, 270);
            pictureBox5.SetBounds(0, 810, 480, 270);
            pictureBox6.SetBounds(480, 810, 480, 270);
            pictureBox7.SetBounds(960, 810, 480, 270);

            dispictureBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }

        public Thread thr1 = null;
        public Thread thr2 = null;
        public Thread thr3 = null;
        public Thread thr4 = null;
        public Thread thr5 = null;
        public Thread thr6 = null;
        public Thread thr7 = null;
        public Thread thr8 = null;       

        
        //20220808 SetRuntimeView 
        public void SetRuntimeView()
        {
            disparam01.id = "1";
            //disparam01.Channel = ch1;
            disparam01.Channel = "53";
            //disparam01.Channel = comboBox2.SelectedItem.ToString();
            disparam01.displaywnd = dispictureBox1.Handle;
            disparam01.Boxname = dispictureBox1.Name;
            //disparam01.pnetcamP = pnetcam01;
            disparam01.pnetcamP = IntPtr.Zero;
            //Thread thr1 = new Thread(PlayRuntimeView);
            thr1 = new Thread(PlayRuntimeView);
            thr1.Start((object)disparam01);

            disparam02.id = "2";
            //disparam02.Channel = ch1;
            disparam02.Channel = "40";
            //disparam02.Channel = comboBox3.SelectedItem.ToString();
            disparam02.displaywnd = pictureBox1.Handle;
            disparam02.Boxname = pictureBox1.Name;
            //disparam02.pnetcamP = pnetcam02;
            disparam02.pnetcamP = IntPtr.Zero;
            //Thread thr2 = new Thread(PlayRuntimeView);
            thr2 = new Thread(PlayRuntimeView);
            thr2.Start((object)disparam02);

            disparam03.id = "3";
            //disparam03.Channel = ch1;
            disparam03.Channel = "37";
            //disparam03.Channel = comboBox4.SelectedItem.ToString();
            disparam03.displaywnd = pictureBox2.Handle;
            disparam03.Boxname = pictureBox2.Name;
            //disparam03.pnetcamP = pnetcam03;
            disparam03.pnetcamP = IntPtr.Zero;
            //Thread thr3 = new Thread(PlayRuntimeView);
            thr3 = new Thread(PlayRuntimeView);
            thr3.Start((object)disparam03);

            disparam04.id = "4";
            //disparam04.Channel = ch1;
            disparam04.Channel = "44";
            //disparam04.Channel = comboBox5.SelectedItem.ToString();
            disparam04.displaywnd = pictureBox3.Handle;
            disparam04.Boxname = pictureBox3.Name;          
            //disparam04.pnetcamP = pnetcam04;
            disparam04.pnetcamP = IntPtr.Zero;
            //Thread thr4 = new Thread(PlayRuntimeView);
            thr4 = new Thread(PlayRuntimeView);
            thr4.Start((object)disparam04);

            disparam05.id = "5";
            //disparam05.Channel = ch1;
            disparam05.Channel = "58";
            //disparam05.Channel = comboBox6.SelectedItem.ToString();
            disparam05.displaywnd = pictureBox4.Handle;
            disparam05.Boxname = pictureBox4.Name;
            //disparam05.pnetcamP = pnetcam05;
            disparam05.pnetcamP = IntPtr.Zero;
            //Thread thr5 = new Thread(PlayRuntimeView);
            thr5 = new Thread(PlayRuntimeView);
            thr5.Start((object)disparam05);

            disparam06.id = "6";
            //disparam06.Channel = ch1;
            disparam06.Channel = "59";
            //disparam06.Channel = comboBox7.SelectedItem.ToString();
            disparam06.displaywnd = pictureBox5.Handle;
            disparam06.Boxname = pictureBox5.Name;
            //disparam06.pnetcamP = pnetcam06;
            disparam06.pnetcamP = IntPtr.Zero;
            //Thread thr6 = new Thread(PlayRuntimeView);
            thr6 = new Thread(PlayRuntimeView);
            thr6.Start((object)disparam06);

            disparam07.id = "7";
            //disparam07.Channel = ch1;
            disparam07.Channel = "48";
            //disparam07.Channel = comboBox8.SelectedItem.ToString();
            disparam07.displaywnd = pictureBox6.Handle;
            disparam07.Boxname = pictureBox6.Name;
            //disparam07.pnetcamP = pnetcam07;
            disparam07.pnetcamP = IntPtr.Zero;
            //Thread thr7 = new Thread(PlayRuntimeView);
            thr7 = new Thread(PlayRuntimeView);
            thr7.Start((object)disparam07);

            disparam08.id = "8";
            //disparam08.Channel = ch1;
            disparam08.Channel = "21";
            //disparam08.Channel = comboBox9.SelectedItem.ToString();
            disparam08.displaywnd = pictureBox7.Handle;
            disparam08.Boxname = pictureBox7.Name;
            //disparam08.pnetcamP = pnetcam08;
            disparam08.pnetcamP = IntPtr.Zero;
            //Thread thr8 = new Thread(PlayRuntimeView);
            thr8 = new Thread(PlayRuntimeView);
            thr8.Start((object)disparam08);

            

            /*
            disparam09.Channel = comboBox10.SelectedItem.ToString();
            disparam09.displaywnd = pictureBox8.Handle;
            disparam09.pnetcamP = pnetcam09;
            Thread thr9 = new Thread(PlayRuntimeView);
            thr9.Start((object)disparam09);

            disparam10.Channel = comboBox11.SelectedItem.ToString();
            disparam10.displaywnd = pictureBox9.Handle;
            disparam10.pnetcamP = pnetcam10;
            Thread thr10 = new Thread(PlayRuntimeView);
            thr10.Start((object)disparam10);

            disparam11.Channel = comboBox12.SelectedItem.ToString();
            disparam11.displaywnd = pictureBox10.Handle;
            disparam11.pnetcamP = pnetcam11;
            Thread thr11 = new Thread(PlayRuntimeView);
            thr11.Start((object)disparam11);

            disparam12.Channel = comboBox13.SelectedItem.ToString();
            disparam12.displaywnd = pictureBox11.Handle;
            disparam12.pnetcamP = pnetcam12;
            Thread thr12 = new Thread(PlayRuntimeView);
            thr12.Start((object)disparam12);

            disparam13.Channel = comboBox14.SelectedItem.ToString();
            disparam13.displaywnd = pictureBox12.Handle;
            disparam13.pnetcamP = pnetcam13;
            Thread thr13 = new Thread(PlayRuntimeView);
            thr13.Start((object)disparam13);

            disparam14.Channel = comboBox15.SelectedItem.ToString();
            disparam14.displaywnd = pictureBox13.Handle;
            disparam14.pnetcamP = pnetcam14;
            Thread thr14 = new Thread(PlayRuntimeView);
            thr14.Start((object)disparam14);

            disparam15.Channel = comboBox16.SelectedItem.ToString();
            disparam15.displaywnd = pictureBox14.Handle;
            disparam15.pnetcamP = pnetcam15;
            Thread thr15 = new Thread(PlayRuntimeView);
            thr15.Start((object)disparam15);

            disparam16.Channel = comboBox17.SelectedItem.ToString();
            disparam16.displaywnd = pictureBox15.Handle;
            disparam16.pnetcamP = pnetcam16;
            Thread thr16 = new Thread(PlayRuntimeView);
            thr16.Start((object)disparam16);
            */
        }
        public string ch1 = "7";
        public string ch2 = "8";
        public string ch3 = "9";
        public string ch4 = "10";
        public string ch5 = "11";
        public string ch6 = "12";
        public string ch7 = "13";
        public string ch8 = "14";
        public void ChangeRuntimeView1(string c1)
        {
            ch1 = c1;
            //disparam01.Channel = ch;
            disparam01.stop1 = 0;
        }

        public void ChangeRuntimeView8(string c1, string c2, string c3, string c4, string c5, string c6, string c7, string c8, string st)
        {
            if(st.Equals("1"))
            {
                Set1View();
                ch1 = c1;
                disparam01.stop1 = 0;
            }
            else if (st.Equals("2"))
            {
                Set4View();
                ch1 = c1;
                ch2 = c2;
                ch3 = c3;
                ch4 = c4;
                disparam01.stop1 = 0;
                disparam02.stop1 = 0;
                disparam03.stop1 = 0;
                disparam04.stop1 = 0;             
            }
            else if (st.Equals("3"))
            {
                Set8View();
                ch1 = c1;
                ch2 = c2;
                //disparam02.Channel = c2;
                ch3 = c3;
                ch4 = c4;
                ch5 = c5;
                ch6 = c6;
                ch7 = c7;
                ch8 = c8;
                //disparam01.Channel = ch;
                disparam01.stop1 = 0;
                disparam02.stop1 = 0;
                disparam03.stop1 = 0;
                disparam04.stop1 = 0;
                disparam05.stop1 = 0;
                disparam06.stop1 = 0;
                disparam07.stop1 = 0;
                disparam08.stop1 = 0;
            }
            else { }

                
        }

        public string m_streamingIP = "192.168.20.2";

        //20220808 PlayRuntimeView
        void PlayRuntimeView(object disparam)
        {
             
                    DisplayParam th_disparam = (DisplayParam)disparam;
                    //Form1.isdisplay = 1;
                    //string[] s = th_disparam.NDASID.Split(new char[] { '-' });
                    //string key = s[4];
                    //string id = s[0] + s[1] + s[2] + s[3];
                    //Netcam.ndassock_iframe_play_Enable(false);
                    string strCH = "";

                    if(th_disparam.id.Equals("1")) { strCH = ch1; }
                    else if (th_disparam.id.Equals("2")) { strCH = ch2; }
                    else if (th_disparam.id.Equals("3")) { strCH = ch3; }
                    else if (th_disparam.id.Equals("4")) { strCH = ch4; }
                    else if (th_disparam.id.Equals("5")) { strCH = ch5; }
                    else if (th_disparam.id.Equals("6")) { strCH = ch6; }
                    else if (th_disparam.id.Equals("7")) { strCH = ch7; }
                    else if (th_disparam.id.Equals("8")) { strCH = ch8; }
            try
            { 
                    if (th_disparam.pnetcamP == IntPtr.Zero)
                    {
                        th_disparam.pnetcamP = Netcam.netcam_create(
                            IntPtr.Zero,
                            m_streamingIP,          // hostname : Camera IP or url
                                                    //"192.168.1.9",	        // hostname : Camera IP or url
                            "9001",	                // video port 9001
                            "80",		            // web포트 80
                            "BGPQSFKUFMU8PU052G3S",
                            "R4FTU",
                            0,
                            "62D1F6",
                            0,					    // Disk Configuration
                            "00000000000000000000", "00000", 0,
                            "00000000000000000000", "00000", 0,
                            "00000000000000000000", "00000", 0,
                            "00000000000000000000", "00000", 0,
                            //Int32.Parse(th_disparam.Channel.ToString()),    // channel infomation(from 1 - )
                            Int32.Parse(strCH.ToString()) + 6,                                                                       
                                                                            //16,
                            "H265",											// codec name
                            1,
                            HttpClint.SEARCH_TYPE_ARCA,
                            0,
                            0,
                            "admin",			    // 기기 로그인 계정 ID
                            "wizbrain1!");
                    }

                    int result = Netcam.ndassock_connect(th_disparam.pnetcamP);
                    //Console.WriteLine("Connect DLL: " + th_disparam.pnetcamP + ", result: " + result);
                    if (result != 0){ Console.WriteLine("Connect Fail"); return; }


                    //RefreshPicture refreshctrl = new RefreshPicture(DrawPicture);
                    //dispictureBox1.Invoke(refreshctrl);
                  
                result = Netcam.ndassock_setdisplay(th_disparam.pnetcamP, th_disparam.displaywnd);
                //Console.WriteLine("SetDisplay: " + th_disparam.displaywnd + ", result: " + result);
                if (result != 0) { Console.WriteLine("SetDisplay Fail"); return; }


                result = Netcam.ndassock_play(th_disparam.pnetcamP);                        
                if (result != 0) { Console.WriteLine("Liveplay Fail"); return; }
                Console.WriteLine("발전_CCTV_LOAD VIEW_ID: " + th_disparam.id + " ,CH: " + strCH);


                while (true)
                {
                    //if (DisplayParam.stop == 0)
                    if (th_disparam.stop1 == 0)
                    {
                        Thread.Sleep(Netcam.CHECKTIME_DELAY);
                        break;
                    }
                    
                    int ret = Netcam.ndassock_iskilled(th_disparam.pnetcamP);
                    if (ret == Netcam.KILL_STATUS_FAILED || ret == Netcam.KILL_STATUS_DISCONNECTED)
                    {
                        Console.WriteLine("발전_CCTV_RELOAD STATUS_CODE: " + ret + " ,TIME: " + dateTime + " ,VIEW_ID: " + th_disparam.id + " ,CH: " + strCH);
                        Thread.Sleep(Netcam.CHECKTIME_DELAY);
                                            
                        if (th_disparam.pnetcamP != null) { Netcam.ndassock_stop(th_disparam.pnetcamP); }
                        if (th_disparam.pnetcamP != null) { Netcam.ndassock_disconnect(th_disparam.pnetcamP); }
                        if (th_disparam.pnetcamP != null) { Netcam.netcam_destroy(th_disparam.pnetcamP); }

                        //DisplayParam.stop = 1;
                        th_disparam.stop1 = 1;
                        th_disparam.pnetcamP = IntPtr.Zero;
                       
                        Thread.Sleep(10000);

                        PlayRuntimeView(th_disparam);
                    }

                    Thread.Sleep(Netcam.CHECKTIME_DELAY);
                }
                                          
                if (th_disparam.pnetcamP != null) { Netcam.ndassock_stop(th_disparam.pnetcamP); }
                if (th_disparam.pnetcamP != null) { Netcam.ndassock_disconnect(th_disparam.pnetcamP); }
                if (th_disparam.pnetcamP != null) { Netcam.netcam_destroy(th_disparam.pnetcamP); }

                //DisplayParam.stop = 1;
                th_disparam.stop1 = 1;
                th_disparam.pnetcamP = IntPtr.Zero;

                PlayRuntimeView(th_disparam);
            }
            catch (System.AccessViolationException ae)
            {
                Console.WriteLine("발전_CCTV_Exception_AVE VIEW_ID : " + th_disparam.id + " , PLAY_CH : " + strCH);
                Console.WriteLine(ae.ToString()); 
            }
            catch (Exception e)
            {
                Console.WriteLine("발전_CCTV_Exception VIEW_ID : " + th_disparam.id + " , PLAY_CH : " + strCH);
                Console.WriteLine(e.ToString());
            }
            

            /*
            finally 
            {               
                Console.WriteLine("End CCTV_CH : " + th_disparam.Channel.ToString());

                DisplayParam.stop = 1;
                th_disparam.pnetcamP = IntPtr.Zero;
            } 
            */
        }


        void boardcast(object disparam)
        {
            DisplayParam th_disparam = (DisplayParam)disparam;
            View11.isdisplay = 1;
            string[] s = th_disparam.NDASID.Split(new char[] { '-' });
            string key = s[4];
            string id = s[0] + s[1] + s[2] + s[3];
            //Netcam.ndassock_iframe_play_Enable(false);
           //pnetcam = Netcam.netcam_create(
           //  IntPtr.Zero,
           //  "192.168.2.7",					// hostname : Camera IP or url
           //  "9001",	// video port 设备端口. 9001
           //  "80",		// web端口. 80
           //  "XQDL0S54YQTMLUMRT2N4",
           //  "7X3Q8",
           //  0,
           //  "92B525",
           //  0,												// Disk Configuration
           //  "00000000000000000000", "00000", 0,
           //  "00000000000000000000", "00000", 0,
           //  "00000000000000000000", "00000", 0,
           //  "00000000000000000000", "00000", 0,
           //  9,			// channel infomation(from 1 - ) 
           //  "H264",												// codec name
           //  1,
           //  0,
           //  0,
           //  0,
           //  "admin",								// 设备登录账号 ID admin
           //  "9999");
            if (pnetcam == IntPtr.Zero)
            {
                pnetcam = Netcam.netcam_create(
                  IntPtr.Zero,
                  th_disparam.IP,					// hostname : Camera IP or url
                  th_disparam.DevicePort,	// video port 设备端口. 9001
                  th_disparam.WebPort,		// web端口. 80
                  id,
                  key,
                  Int32.Parse(th_disparam.DiskNO.ToString()),
                  th_disparam.Member,
                  0,												// Disk Configuration
                  "00000000000000000000", "00000", 0,
                  "00000000000000000000", "00000", 0,
                  "00000000000000000000", "00000", 0,
                  "00000000000000000000", "00000", 0,
                  Int32.Parse(th_disparam.Channel.ToString()),			// channel infomation(from 1 - ) 
                  "H264",												// codec name
                  th_disparam.audio_enable,
                  th_disparam.search_type,
                  0,
                  0,
                  th_disparam.USER,								// 设备登录账号 ID admin
                  th_disparam.Password);
            }
            int result = Netcam.ndassock_connect(pnetcam);
            Console.WriteLine("create cam " +pnetcam+"返回"+ result);
            if (result != 0)
            {
                Console.WriteLine("can't camConnect");
            }

            //RefreshPicture refreshctrl = new RefreshPicture(DrawPicture);
            //dispictureBox1.Invoke(refreshctrl);

           result = Netcam.ndassock_setdisplay(pnetcam, th_disparam.displaywnd);
           Console.WriteLine("cam句柄 " + th_disparam.displaywnd + "返回值" + result);
            result = Netcam.ndassock_play(pnetcam);
            Console.WriteLine("播放返回值 " + result);

            //result = Netcam.ndassock_setdisplay(pnetcam, th_disparam.displaywnd);
            //Console.WriteLine("句柄 " + th_disparam.displaywnd +"返回值"+ result);
            //result = Netcam.ndassock_play(pnetcam);
            //Console.WriteLine("播放返回值 " + result);
            while (true)
            {
                if (DisplayParam.stop == 0)
                {
                    Thread.Sleep(Netcam.CHECKTIME_DELAY);
                    break;
                }
                int ret = Netcam.ndassock_iskilled(pnetcam);
                if (ret == Netcam.KILL_STATUS_FAILED || ret == Netcam.KILL_STATUS_DISCONNECTED)
                {
                    Console.WriteLine("ndassock_play is fail " + ret);
                    //Thread.Sleep(Netcam.CHECKTIME_DELAY);
                    break;
                }

                 Thread.Sleep(Netcam.CHECKTIME_DELAY);
            }
            Netcam.ndassock_stop(pnetcam);
            Netcam.ndassock_disconnect(pnetcam);
            Netcam.netcam_destroy(pnetcam);
            DisplayParam.stop = 0;
            pnetcam = IntPtr.Zero;
            
       }
        public void ContralPTZ(object ptzparam)
        {
            PtzContrlParam th_ptzparam = (PtzContrlParam)ptzparam;
            string[] s = th_ptzparam.NDASID.Split(new char[] { '-' });
            write_key = s[4].ToCharArray();
            string tmpstr = s[0] + s[1] + s[2] + s[3];
            StringBuilder str_buffer = new StringBuilder(HttpClint.MAX_REPLY_SIZE);

            ndas_id = tmpstr.ToCharArray();
            if (checkBox1.Checked)
            {
                audio_enable = 1;
            }
            else
            {
                audio_enable = 0;
            }

            if (radioButton1.Checked)
            {
                search_type = HttpClint.SEARCH_TYPE_ARCA;
            }
            if (radioButton2.Checked)
            {
                search_type = HttpClint.SEARCH_TYPE_LXX;
            }

            int request_ref1 = HttpClint.GetRequest(th_ptzparam.IP.ToString(), Int32.Parse(th_ptzparam.WebPort.ToString()), "/", th_ptzparam.USER.ToString(), th_ptzparam.Password.ToString());
            if (request_ref1 != 0)
            {
                if (HttpClint.WinHttpAuthSample(request_ref1))
                {
                    Console.WriteLine("device search success");

                }
                else
                {
                    Console.WriteLine("device search error");
                }
            }

            string cmd = "/vb.htm?ch=" + th_ptzparam.Channel + "&getalarmstatus";
            int timeOut = Netcam.GETSTATUS_DELAY;
            string str = "";

            while (PtzContrlParam.stop != 0)
            {
                if (PtzContrlParam.query != 0)
                {
                    PtzContrlParam.query = 0;
                    switch (PtzContrlParam.ptzCmd)
                    {
                        case Netcam.PTZ_CMD_LEFTUP:
					 str="ipncptz=leftup";
					break;
                        case Netcam.PTZ_CMD_UP:
					 str="ipncptz=tiltup";
					break;
                        case Netcam.PTZ_CMD_RIGHTUP:
					str="ipncptz=rigtup";
					break;
                        case Netcam.PTZ_CMD_LEFT:
					str="ipncptz=panlef";
					break;
                        case Netcam.PTZ_CMD_STOP:
					str="ipncptz=movest";
					break;
                        case Netcam.PTZ_CMD_RIGHT:
					str="ipncptz=panrig";
					break;
                        case Netcam.PTZ_CMD_LEFTDOWN:
					str="ipncptz=lefdwn";
					break;
                        case Netcam.PTZ_CMD_DOWN:
					str="ipncptz=tiltdo";
					break;
                        case Netcam.PTZ_CMD_RIGHTDOWN:
					str="ipncptz=rigdwn";
					break;
                        case Netcam.PTZ_CMD_SPEED:
					
					str="ipncptz=spd"+textBox11.Text;
					break;
                        case Netcam.PTZ_CMD_ZOOMIN:
					str="ipncptz=zoomin";
					break;
                        case Netcam.PTZ_CMD_ZOOMOUT:
					str="ipncptz=zoomou";
					break;
                        case Netcam.PTZ_CMD_FOCUSFAR:
					str="ipncptz=focusf";
					break;
                        case Netcam.PTZ_CMD_FOCUSNEAR:
					str="ipncptz=focusn";
					break;
				
				    default:
					Debug.WriteLine("Unsupported command");
					break;

			        }
                    cmd = "/vb.htm?ch=" + th_ptzparam.Channel + "&" + str;
                    
                    Debug.WriteLine("cmd = "+cmd);

                    
                    HttpClint.LXXSendCommand(request_ref1, cmd.ToString(), str_buffer, HttpClint.MAX_REPLY_SIZE);
                    Console.WriteLine(str_buffer);
                }
                Thread.Sleep(1000);
                timeOut -= Netcam.CHECKTIME_DELAY;
                if (timeOut <= 0)
                {
                    cmd = "/vb.htm?ch=" + th_ptzparam.Channel + "&getalarmstatus";

                    HttpClint.LXXSendCommand(request_ref1, cmd.ToString(), str_buffer, HttpClint.MAX_REPLY_SIZE);
                    Debug.WriteLine("SendCommand: reply = " + str_buffer);

                    string temp_buffer = str_buffer.ToString();
                    //if (temp_buffer.IndexOf("404 Not Found") != -1)
                    if(temp_buffer.Length !=0)
                    {
                        
                        RefreshStatus status = new RefreshStatus(CurrentStatus);
                        string statustr = CopyFromStr1(temp_buffer, "getalarmstatus=", true);
                        this.BeginInvoke(status, new object[] { (statustr) });
                    }
                    //if (ret == 0)
                    //{
                    //    //Debug("reply = %s", buffer);
                    //    if (strstr(buffer, "404 Not Found") == 0)
                    //    {
                    //        ParseReply(buffer, "getalarmstatus", str);
                    //        pObject->m_stStatus.SetWindowText(str);
                    //    }
                    //}
                    timeOut = Netcam.GETSTATUS_DELAY;
                }
            }
            if (request_ref1 != 0)
            {
                HttpClint.WinHttpClose(request_ref1);
                Debug.WriteLine("CloseRequestPtz");
            }
            PtzContrlParam.stop = 0;
        }


        //20220808sh SetViewRefresh
        public void SetViewRefresh()
        {
            Thread.Sleep(100);

            dispictureBox1.Refresh();
            pictureBox1.Refresh();
            pictureBox2.Refresh();
            pictureBox3.Refresh();
            pictureBox4.Refresh();
            pictureBox5.Refresh();
            pictureBox6.Refresh();
            pictureBox7.Refresh();
            pictureBox8.Refresh();
            pictureBox9.Refresh();
            pictureBox10.Refresh();
            pictureBox11.Refresh();
            pictureBox12.Refresh();
            pictureBox13.Refresh();
            pictureBox14.Refresh();
            pictureBox15.Refresh();
        }

        

        private void button18_Click(object sender, EventArgs e)
        {
            //根据输入字符串建立目录
            if (bootpath == "" && textBox13.Text.ToString() !="")
            {
                if(!Directory.Exists(bootpath))
                    System.IO.Directory.CreateDirectory(textBox13.Text);
                bootpath = textBox13.Text;
            }
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBox13.Text = fd.SelectedPath;
                bootpath = fd.SelectedPath;
            }
            
                Console.WriteLine(fd.SelectedPath);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (bootpath == "")
            {
                MessageBox.Show("路径名为空");
                return;
            }
            DateTime DT = System.DateTime.Now;
            Netcam.tm capture_time = new Netcam.tm();


            capture_time.tm_year    = DT.Year;              
            capture_time.tm_mon		= DT.Month;	
            capture_time.tm_mday    = DT.Day;	    
            capture_time.tm_hour    = DT.Hour;	    
            capture_time.tm_min		= DT.Minute;   
            capture_time.tm_sec		= DT.Second;
            if (pnetcam != IntPtr.Zero)
            {
                int ret = Netcam.ndassock_capture_file(pnetcam, bootpath, ServerName, ref capture_time);
                if (ret != 0)
                    MessageBox.Show("抓图失败");
            }
            else
            {
                MessageBox.Show("预览没有开启");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (bootpath == "")
            {
                MessageBox.Show("路径名为空");
                return;
            }
            DateTime DT = System.DateTime.Now;
            Netcam.tm capture_time = new Netcam.tm();


            capture_time.tm_year = DT.Year;
            capture_time.tm_mon = DT.Month;
            capture_time.tm_mday = DT.Day;
            capture_time.tm_hour = DT.Hour;
            capture_time.tm_min = DT.Minute;
            capture_time.tm_sec = DT.Second;

            Netcam.tm end_time = new Netcam.tm();
            
            if (pnetcam != IntPtr.Zero)
            {
                int ret = Netcam.ndassock_avi_open_output_file(pnetcam, bootpath, ServerName, ref capture_time, ref end_time);
                if (ret != 0)
                    MessageBox.Show("本地录像开始失败");
            }
            else
            {
                MessageBox.Show("预览没有开启");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (pnetcam != IntPtr.Zero)
            {
                int ret = Netcam.ndassock_avi_close(pnetcam);
                if (ret != 0)
                    MessageBox.Show("本地录像关闭失败");
            }
            else
            {
                MessageBox.Show("预览没有开启");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (bootpath == "")
            {
                MessageBox.Show("路径名为空");
                return;
            }
            DateTime DT = System.DateTime.Now;
            Netcam.tm capture_time = new Netcam.tm();


            capture_time.tm_year = DT.Year;
            capture_time.tm_mon = DT.Month;
            capture_time.tm_mday = DT.Day;
            capture_time.tm_hour = DT.Hour;
            capture_time.tm_min = DT.Minute;
            capture_time.tm_sec = DT.Second;

            Netcam.tm end_time = new Netcam.tm();
            string filename = bootpath + "\\" + textBox15.Text;
            
            if (pnetcam != IntPtr.Zero)
            {
                int ret = Netcam.ndassock_avi_open_output_file2(pnetcam, filename, ref capture_time, ref end_time);
                if (ret != 0)
                    MessageBox.Show("本地录像2开始失败");
            }
            else
            {
                MessageBox.Show("预览没有开启");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (pnetcam != IntPtr.Zero)
            {
                int ret = Netcam.ndassock_avi_close(pnetcam);
                if (ret != 0)
                    MessageBox.Show("本地录像关闭失败");
            }
            else
            {
                MessageBox.Show("预览没有开启");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {

            Form2 f = new Form2(this);
            PointToClient(this.button26.Location);
            f.setX(this.button26.Location.X + this.Location.X + this.button26.Width);
            f.setY(this.button26.Location.Y+this.Location.Y+this.button26.Height);
            f.setbutID(1);
            f.ShowDialog();
            
        }
        public void freshDateText()
        {
            this.textBox16.Text = dateselect;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (bootpath != "")
                downloadparam.bootpath = bootpath;
            else
            {
                MessageBox.Show("路径名不能为空！");
                return;
            }
            //if (checkBox1.Checked)
            //{
            //    audio_enable = 1;
            //}
            //else
            //{
            //    audio_enable = 0;
            //}

            //if (radioButton1.Checked)
            //{
            //    search_type = HttpClint.SEARCH_TYPE_ARCA;
            //}
            //if (radioButton2.Checked)
            //{
            //    search_type = HttpClint.SEARCH_TYPE_LXX;
            //}

            downloadparam.ServerName = textBox1.Text.ToString();
            downloadparam.IP = textBox2.Text.ToString();
            downloadparam.USER = textBox3.Text.ToString();
            downloadparam.Password = textBox4.Text.ToString();
            downloadparam.WebPort = textBox5.Text.ToString();
            downloadparam.DevicePort = textBox6.Text.ToString();
            downloadparam.Channel = textBox7.Text.ToString();
            downloadparam.NDASID = textBox8.Text.ToString();
            downloadparam.DiskNO = textBox9.Text.ToString();
            downloadparam.Member = textBox10.Text.ToString();

            downloadparam.audio_enable = audio_enable;
            downloadparam.search_type = search_type;

            downloadparam.dateselect = textBox16.Text.ToString();
            downloadparam.duration = Int32.Parse(textBox17.Text.ToString());
            DownLoadParam.stop = 1;

            Thread thr = new Thread(download);
            thr.Start((object)downloadparam);
        }
        private void download(object downloadparam)
        {
            DownLoadParam th_downloadparam = (DownLoadParam)downloadparam;
            string[] s = th_downloadparam.NDASID.Split(new char[] { '-' });
            string key = s[4];
            string id = s[0] + s[1] + s[2] + s[3];

            //IntPtr pnetcam1 = Netcam.netcam_create(
            //  IntPtr.Zero,
            //  "192.168.2.7",					// hostname : Camera IP or url
            //  "9001",	// video port 设备端口. 9001
            //  "80",		// web端口. 80
            //  "XQDL0S54YQTMLUMRT2N4",
            //  "7X3Q8",
            //  0,
            //  "92B525",
            //  0,												// Disk Configuration
            //  "00000000000000000000", "00000", 0,
            //  "00000000000000000000", "00000", 0,
            //  "00000000000000000000", "00000", 0,
            //  "00000000000000000000", "00000", 0,
            //  3,			// channel infomation(from 1 - ) 
            //  "H264",												// codec name
            //  1,
            //  0,
            //  0,
            //  0,
            //  "admin",								// 设备登录账号 ID admin
            //  "9999");

            IntPtr pnetcam1 = Netcam.netcam_create(
              IntPtr.Zero,
              th_downloadparam.IP,					// hostname : Camera IP or url
              th_downloadparam.DevicePort,	// video port 设备端口. 9001
              th_downloadparam.WebPort,		// web端口. 80
              id,
              key,
              Int32.Parse(th_downloadparam.DiskNO.ToString()),
              th_downloadparam.Member,
              0,												// Disk Configuration
              "00000000000000000000", "00000", 0,
              "00000000000000000000", "00000", 0,
              "00000000000000000000", "00000", 0,
              "00000000000000000000", "00000", 0,
              Int32.Parse(th_downloadparam.Channel.ToString()),			// channel infomation(from 1 - ) 
              "H264",												// codec name
              th_downloadparam.audio_enable,
              th_downloadparam.search_type,//
              0,
              0,
              th_downloadparam.USER,								// 设备登录账号 ID admin
              th_downloadparam.Password);

            DateTime dt = Convert.ToDateTime(th_downloadparam.dateselect);
            Netcam.tm capture_time = new Netcam.tm();

            
            capture_time.tm_year = dt.Year - Netcam.DOWNLOAD_YEARCONST;
            capture_time.tm_mon = dt.Month - Netcam.DOWNLOAD_MONTHCONST;
            capture_time.tm_mday = dt.Day;
            capture_time.tm_hour = dt.Hour;
            capture_time.tm_min = dt.Minute;
            capture_time.tm_sec = dt.Second;
            //int duration = Int32.Parse(textBox17.Text);
            int duration = th_downloadparam.duration;
            //Console.WriteLine("time ==" + capture_time.tm_year + capture_time.tm_mon + capture_time.tm_mday + capture_time.tm_hour);
            //int result = Netcam.nbiofats_download_start(pnetcam1, "f:\\", "test1", ref capture_time, (duration + 59) / 60);
            Console.WriteLine("result = " + th_downloadparam.bootpath);
            int result = Netcam.nbiofats_download_start(pnetcam1, th_downloadparam.bootpath, th_downloadparam.ServerName, ref capture_time, (duration + 59) / 60);
            Console.WriteLine("result = " + result);
            while (DownLoadParam.stop != 0)
            {

                int ret = Netcam.nbiofats_iskilled(pnetcam1);
                Console.WriteLine("Download complete" + ret);
                if (ret == Netcam.KILL_STATUS_FAILED || ret == Netcam.KILL_STATUS_DISCONNECTED)
                {
                    Console.WriteLine("Download failed");
                    break;
                }

                ret = Netcam.nbiofats_download_status(pnetcam1, out duration);
                RefreshRemain remain = new RefreshRemain(CurrentRemain);
                string str = duration.ToString();
                this.BeginInvoke(remain,new object[]{(str)} );
                Console.WriteLine("ret = " + ret + "duration = " + duration + "handle" + pnetcam1);
                if (duration == 0)
                {
                    Console.WriteLine("Download complete");
                    break;
                }

                Thread.Sleep(100);
            }


            Netcam.nbiofats_download_stop(pnetcam1);
            Netcam.netcam_destroy(pnetcam1);
            DownLoadParam.stop = 0;
            pnetcam1 = IntPtr.Zero;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            DownLoadParam.stop = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int ret = Netcam.initialize_netcam();

            int n = -77;
            try
            {
                n = Netcam.initialize_netcam();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Netcam_int_num: " + n);
                Console.WriteLine(ex.ToString()); 
            }

            //20220808sh
            //기존
            SetDefaultView();
            btn_play_Click(this, null);
        }

        private void download2(object downloadparam)
        {
            DownLoadParam2 th_downloadparam = (DownLoadParam2)downloadparam;
            string[] s = th_downloadparam.NDASID.Split(new char[] { '-' });
            string key = s[4];
            string id = s[0] + s[1] + s[2] + s[3];

            //IntPtr pnetcam1 = Netcam.netcam_create(
            //  IntPtr.Zero,
            //  "192.168.2.7",					// hostname : Camera IP or url
            //  "9001",	// video port 设备端口. 9001
            //  "80",		// web端口. 80
            //  "XQDL0S54YQTMLUMRT2N4",
            //  "7X3Q8",
            //  0,
            //  "92B525",
            //  0,												// Disk Configuration
            //  "00000000000000000000", "00000", 0,
            //  "00000000000000000000", "00000", 0,
            //  "00000000000000000000", "00000", 0,
            //  "00000000000000000000", "00000", 0,
            //  3,			// channel infomation(from 1 - ) 
            //  "H264",												// codec name
            //  1,
            //  0,
            //  0,
            //  0,
            //  "admin",								// 设备登录账号 ID admin
            //  "9999");

            IntPtr pnetcam1 = Netcam.netcam_create(
              IntPtr.Zero,
              th_downloadparam.IP,					// hostname : Camera IP or url
              th_downloadparam.DevicePort,	// video port 设备端口. 9001
              th_downloadparam.WebPort,		// web端口. 80
              id,
              key,
              Int32.Parse(th_downloadparam.DiskNO.ToString()),
              th_downloadparam.Member,
              0,												// Disk Configuration
              "00000000000000000000", "00000", 0,
              "00000000000000000000", "00000", 0,
              "00000000000000000000", "00000", 0,
              "00000000000000000000", "00000", 0,
              Int32.Parse(th_downloadparam.Channel.ToString()),			// channel infomation(from 1 - ) 
              "H264",												// codec name
              th_downloadparam.audio_enable,
              th_downloadparam.search_type,
              0,
              0,
              th_downloadparam.USER,								// 设备登录账号 ID admin
              th_downloadparam.Password);

            DateTime dt = Convert.ToDateTime(th_downloadparam.dateselect);
            Netcam.tm capture_time = new Netcam.tm();


            capture_time.tm_year = dt.Year - Netcam.DOWNLOAD_YEARCONST;
            capture_time.tm_mon = dt.Month - Netcam.DOWNLOAD_MONTHCONST;
            capture_time.tm_mday = dt.Day;
            capture_time.tm_hour = dt.Hour;
            capture_time.tm_min = dt.Minute;
            capture_time.tm_sec = dt.Second;
            //int duration = Int32.Parse(textBox17.Text);
            int duration = th_downloadparam.duration;
            //Console.WriteLine("time ==" + capture_time.tm_year + capture_time.tm_mon + capture_time.tm_mday + capture_time.tm_hour);
            //int result = Netcam.nbiofats_download_start(pnetcam1, "f:\\", "test1", ref capture_time, (duration + 59) / 60);
            string filename = th_downloadparam.bootpath +"\\"+ th_downloadparam.filename;
            int result = Netcam.nbiofats_download_start2(pnetcam1, filename , ref capture_time, (duration + 59) / 60);
            Console.WriteLine("result = " + result);
            while (DownLoadParam2.stop != 0)
            {

                int ret = Netcam.nbiofats_iskilled(pnetcam1);
                //Console.WriteLine("Download complete" + ret);
                if (ret == Netcam.KILL_STATUS_FAILED || ret == Netcam.KILL_STATUS_DISCONNECTED)
                {
                    //Console.WriteLine("Download failed");
                    break;
                }

                ret = Netcam.nbiofats_download_status(pnetcam1, out duration);
                RefreshRemain remain = new RefreshRemain(CurrentRemain);
                string str = duration.ToString();
                this.BeginInvoke(remain, new object[] { (str) });
                //Console.WriteLine("ret = " + ret + "duration = " + duration + "handle" + pnetcam1);
                if (duration == 0)
                {
                    //Console.WriteLine("Download complete");
                    break;
                }

                Thread.Sleep(100);
            }


            Netcam.nbiofats_download_stop(pnetcam1);
            Netcam.netcam_destroy(pnetcam1);
            DownLoadParam2.stop = 0;
            pnetcam1 = IntPtr.Zero;
        }
        private void button27_Click(object sender, EventArgs e)
        {
            if (bootpath != "")
                downloadparam2.bootpath = bootpath;
            else
            {
                MessageBox.Show("路径名不能为空！");
                return;
            }
            if (textBox19.Text.ToString() == "")
            {
                MessageBox.Show("文件名不能为空！");
                return;
            }
            else
                downloadparam2.filename = textBox19.Text.ToString();

            downloadparam2.ServerName = textBox1.Text.ToString();
            downloadparam2.IP = textBox2.Text.ToString();
            downloadparam2.USER = textBox3.Text.ToString();
            downloadparam2.Password = textBox4.Text.ToString();
            downloadparam2.WebPort = textBox5.Text.ToString();
            downloadparam2.DevicePort = textBox6.Text.ToString();
            downloadparam2.Channel = textBox7.Text.ToString();
            downloadparam2.NDASID = textBox8.Text.ToString();
            downloadparam2.DiskNO = textBox9.Text.ToString();
            downloadparam2.Member = textBox10.Text.ToString();

            downloadparam2.audio_enable = audio_enable;
            downloadparam2.search_type = search_type;

            downloadparam2.dateselect = textBox16.Text.ToString();
            downloadparam2.duration = Int32.Parse(textBox17.Text.ToString());
            DownLoadParam2.stop = 1;

            Thread thr = new Thread(download2);
            thr.Start((object)downloadparam2);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            DownLoadParam2.stop = 0;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (View11.isdisplay == 1)
            {
                MessageBox.Show("请关闭视频预览后再进行回放！");
                View11.m_stSearch = false;
                return;
            }
            playbackparam.ServerName = textBox1.Text.ToString();
            playbackparam.IP = textBox2.Text.ToString();
            playbackparam.USER = textBox3.Text.ToString();
            playbackparam.Password = textBox4.Text.ToString();
            playbackparam.WebPort = textBox5.Text.ToString();
            playbackparam.DevicePort = textBox6.Text.ToString();
            playbackparam.Channel = textBox7.Text.ToString();
            playbackparam.NDASID = textBox8.Text.ToString();
            playbackparam.DiskNO = textBox9.Text.ToString();
            playbackparam.Member = textBox10.Text.ToString();

            playbackparam.audio_enable = audio_enable;
            playbackparam.search_type = search_type;
            
            playbackparam.date = textBox21.Text.ToString();
            playbackparam.time = textBox22.Text.ToString();
            playbackparam.eventId = textBox23.Text.ToString();
            playbackparam.issearch = View11.m_stSearch;
            playbackparam.backplaywnd = dispictureBox1.Handle;
            playbackparam.isEvent = checkBox3.Checked;
            PlayBackParam.stop = 1;

            Thread thr = new Thread(playback);
            thr.Start((object)playbackparam);
        }
        private void playback(object playbackparam)
        {
            PlayBackParam th_playbackparam = (PlayBackParam)playbackparam;

            View11.isdisplay = 2;
            int action, year, mon, mday, hour, min, sec;
            int event_mode;

            string[] s = th_playbackparam.NDASID.Split(new char[] { '-' });
            string key = s[4];
            string id = s[0] + s[1] + s[2] + s[3];
            //IntPtr pnetcam1 = Netcam.netcam_create(
            //      IntPtr.Zero,
            //      "192.168.2.7",					// hostname : Camera IP or url
            //      "9001",	// video port 设备端口. 9001
            //      "80",		// web端口. 80
            //      "XQDL0S54YQTMLUMRT2N4",
            //      "7X3Q8",
            //      0,
            //      "92B525",
            //      0,												// Disk Configuration
            //      "00000000000000000000", "00000", 0,
            //      "00000000000000000000", "00000", 0,
            //      "00000000000000000000", "00000", 0,
            //      "00000000000000000000", "00000", 0,
            //      3,			// channel infomation(from 1 - ) 
            //      "H264",												// codec name
            //      1,
            //      0,
            //      0,
            //      0,
            //      "admin",								// 设备登录账号 ID admin
            //      "9999");

            IntPtr pnetcam1 = Netcam.netcam_create(
              IntPtr.Zero,
              th_playbackparam.IP,					// hostname : Camera IP or url
              th_playbackparam.DevicePort,	// video port 设备端口. 9001
              th_playbackparam.WebPort,		// web端口. 80
              id,
              key,
              Int32.Parse(th_playbackparam.DiskNO.ToString()),
              th_playbackparam.Member,
              0,												// Disk Configuration
              "00000000000000000000", "00000", 0,
              "00000000000000000000", "00000", 0,
              "00000000000000000000", "00000", 0,
              "00000000000000000000", "00000", 0,
              Int32.Parse(th_playbackparam.Channel.ToString()),			// channel infomation(from 1 - ) 
              "H264",												// codec name
              th_playbackparam.audio_enable,
              th_playbackparam.search_type,
              0,
              0,
              th_playbackparam.USER,								// 设备登录账号 ID admin
              th_playbackparam.Password);


            View11.playbacknetcam = pnetcam1;
            int time1 = System.Environment.TickCount;
            int result = Netcam.nbiofats_connect(pnetcam1);
            if (result != 0)
            {
                Debug.WriteLine("can't camPBConnect");
            }

            timeOut = Netcam.MAX_TIMEOUT;
            while (true)
            {
                result = Netcam.nbiofats_iskilled(pnetcam1);
                if (result == Netcam.KILL_STATUS_FAILED || result == Netcam.KILL_STATUS_DISCONNECTED)
                {
                    Debug.WriteLine("Connect failed: result = "+ result);
                    closeplayback(pnetcam1);
                    return;
                }
                else if (result == Netcam.KILL_STATUS_CONNECTED || result == Netcam.KILL_STATUS_PLAY)
                {
                    Debug.WriteLine("Connect Success");
                    break;
                }
                Thread.Sleep(Netcam.CHECKTIME_DELAY);
                timeOut -= Netcam.CHECKTIME_DELAY;
                if (timeOut < 0)
                {
                    Debug.WriteLine("Connect Timeout: result = " + result);
                    closeplayback(pnetcam1);
                    return;
                }
            }
            ///////////////////////////////////////
            // TIME TABLE is VALID form this point
            ///////////////////////////////////////
            IntPtr hndas = IntPtr.Zero;
            result = Netcam.nbiofats_get_connection_handle(pnetcam1,out hndas);
            Debug.WriteLine("camPBConnectHandle: result = " + result + " NDAS_H = " + hndas);
            DisplayTimeTable(hndas);
            //获取日期  时间
            DateTime dt = Convert.ToDateTime(th_playbackparam.date+" "+th_playbackparam.time);
            year = dt.Year;
            mon = dt.Month;
            mday = dt.Day;

            hour = dt.Hour;
            min = dt.Minute;
            sec = dt.Second;
            if (th_playbackparam.eventId != "")
                event_mode = Convert.ToInt32(th_playbackparam.eventId, 16);
            else
                event_mode = 0x00;

            Netcam.nbiofats_setdisplay(pnetcam1, th_playbackparam.backplaywnd);
            //time1 = timeGetTime();
            if (th_playbackparam.isEvent)
            {
                action = Netcam.ACTION_DIRECT_EVENT_FORWARD;
                result = Netcam.nbiofats_seek(pnetcam1, action, year, mon, mday, hour, min, sec, event_mode);
                if (result < 0)
                {
                    Debug.WriteLine("camPBSeek failed. result = " + result);
                    closeplayback(pnetcam1);
                    return;
                }
            }
            else
            {
                action = Netcam.ACTION_DIRECT_FORWARD;
                result = Netcam.nbiofats_seek(pnetcam1, action, year, mon, mday, hour, min, sec, Netcam.EVT_FLAG_NONE);
                if (result < 0)
                {
                    Debug.WriteLine("camPBSeek failed. result = " + result);
                    closeplayback(pnetcam1);
                    return;
                }
            }
            while (PlayBackParam.stop!=0)
            {

                result = Netcam.nbiofats_iskilled(pnetcam1);
                if (result == Netcam.KILL_STATUS_FAILED || result == Netcam.KILL_STATUS_DISCONNECTED)
                {
                    Debug.WriteLine("Connect failed: result ="+ result);
                    closeplayback(pnetcam1);
                    return;
                }

                if (th_playbackparam.issearch)
                {
                    th_playbackparam.issearch = false;
                    View11.m_stSearch = false;
                    //获取日期  时间
                    //DateTime dt = Convert.ToDateTime(th_playbackparam.date + " " + th_playbackparam.time);
                    year = dt.Year;
                    mon = dt.Month;
                    mday = dt.Day;

                    hour = dt.Hour;
                    min = dt.Minute;
                    sec = dt.Second;
                    if (th_playbackparam.eventId != "")
                        event_mode = Convert.ToInt32(th_playbackparam.eventId, 16);
                    else
                        event_mode = 0x00;


                    time1 = System.Environment.TickCount;;
                    if (th_playbackparam.isEvent)
                    {
                        action = Netcam.ACTION_DIRECT_EVENT_FORWARD;
                        result = Netcam.nbiofats_seek(pnetcam1, action, year, mon, mday, hour, min, sec, event_mode);
                        if (result < 0)
                        {
                            Debug.WriteLine("camPBSeek failed. result = " + result);
                            closeplayback(pnetcam1);
                            return;
                        }
                    }
                    else
                    {
                        action = Netcam.ACTION_DIRECT_FORWARD;
                        result = Netcam.nbiofats_seek(pnetcam1, action, year, mon, mday, hour, min, sec, Netcam.EVT_FLAG_NONE);
                        if (result < 0)
                        {
                            Debug.WriteLine("camPBSeek failed. result = " + result);
                            closeplayback(pnetcam1);
                            return;
                        }
                    }
                    Debug.WriteLine("Seek Time = "+(System.Environment.TickCount - time1));

                }
                Thread.Sleep(Netcam.CHECKTIME_DELAY);
            }
            result = Netcam.nbiofats_stop(pnetcam1);
            result = Netcam.nbiofats_disconnect(pnetcam1);

            result = Netcam.netcam_destroy(pnetcam1);
            PlayBackParam.stop = 0;
            pnetcam1 = IntPtr.Zero;
            View11.playbacknetcam = pnetcam1;

        }
        void DisplayTimeTable(IntPtr ndas_h)
        {
            Netcam.ndas_handle_t new_ndas_h = (Netcam.ndas_handle_t)Marshal.PtrToStructure(ndas_h,typeof(Netcam.ndas_handle_t));
            //Netcam.nbiofat_file_time_info_t time_info = (Netcam.nbiofat_file_time_info_t)Marshal.PtrToStructure(new_ndas_h.file_time_info, typeof(Netcam.nbiofat_file_time_info_t));
            List<Netcam.nbiofat_file_time_info_t> time_info = MarshalPtrToStructArray<Netcam.nbiofat_file_time_info_t>(new_ndas_h.file_time_info, new_ndas_h.file_time_info_count);

            //int x = time_info.Count();
            int i, count;
            //Netcam.nbiofat_file_time_info_t  time_info;

            if (!ndas_h.Equals(null))
            {
               
                //time_info = ndas_h.;

                count = new_ndas_h.file_time_info_count;
                Debug.WriteLine("DISPLAY TIME TABLE : ENTRY COUNT = " + count);
                for (i = 0; i < count; i++)
                {
                    Debug.WriteLine("file_index = " + time_info[i].file_index +
                        ", flags = " + time_info[i].flags +
                        "x, create_date = " +
                        (time_info[i].create_time.tm_year + 1900) +"-"+
                        (time_info[i].create_time.tm_mon + 1) + "-" +
                        time_info[i].create_time.tm_mday + ", create_time = " +

                        time_info[i].create_time.tm_hour +":"+
                        time_info[i].create_time.tm_min + ":" +
                        time_info[i].create_time.tm_sec +
                        "end_date =" +
                        (time_info[i].end_time.tm_year + 1900) + "-" +
                        (time_info[i].end_time.tm_mon + 1) + "-" +
                        time_info[i].end_time.tm_mday +
                        "end_time = " +
                        time_info[i].end_time.tm_hour + ":" +
                        time_info[i].end_time.tm_min + ":" +
                        time_info[i].end_time.tm_sec
                        );
                }

            }

            return;

        }
        public static List<T> MarshalPtrToStructArray<T>(IntPtr p, int count)
        {
            List<T> l = new List<T>();
            for (int i = 0; i < count; i++, p = new IntPtr(p.ToInt32() + Marshal.SizeOf(typeof(T))))
            {
                T t = (T)Marshal.PtrToStructure(p, typeof(T));
                l.Add(t);
            }
            return l;
        }

        private void closeplayback(IntPtr pnetcam)
        {
            int result = Netcam.nbiofats_stop(pnetcam);
            result = Netcam.nbiofats_disconnect(pnetcam);

            result = Netcam.netcam_destroy(pnetcam);

            pnetcam = IntPtr.Zero;
        }
        private void button41_Click(object sender, EventArgs e)
        {
            View11.m_stSearch = true;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            PlayBackParam.stop = 0;
            View11.m_stSearch = false;
            View11.isdisplay = 0;
            dispictureBox1.Refresh();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (bootpath == "")
            {
                MessageBox.Show("路径名为空");
                return;
            }
            DateTime DT = System.DateTime.Now;
            Netcam.tm capture_time = new Netcam.tm();


            capture_time.tm_year = DT.Year;
            capture_time.tm_mon = DT.Month;
            capture_time.tm_mday = DT.Day;
            capture_time.tm_hour = DT.Hour;
            capture_time.tm_min = DT.Minute;
            capture_time.tm_sec = DT.Second;
            if (playbacknetcam != IntPtr.Zero)
            {
                int result = Netcam.nbiofats_capture_file(playbacknetcam,bootpath, ServerName, ref capture_time);
                Debug.WriteLine("nbiofats_capture_file: ret = " + result);
            }
            else
            {
                MessageBox.Show("回放没有启动！");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int event_mode = Convert.ToInt32(textBox23.Text.ToString(), 16);

            int action = Netcam.ACTION_EVENT_BACKWARD;
            int ret = Netcam.nbiofats_seek(playbacknetcam, action, 0, 0, 0, 0, 0, 0, event_mode);
            Debug.WriteLine("camPBSeek Previous Event: ret =" + ret);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int event_mode = Convert.ToInt32(textBox23.Text.ToString(), 16);

            int action = Netcam.ACTION_EVENT_FORWARD;
            int ret = Netcam.nbiofats_seek(playbacknetcam, action, 0, 0, 0, 0, 0, 0, event_mode);

            Debug.WriteLine("camPBSeek Next Event: ret = " + ret);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            dispictureBox1.Refresh();
            int action = Netcam.ACTION_SNAP_BACKWARD;
            int ret = Netcam.nbiofats_seek(playbacknetcam, action, 0, 0, 0, 0, 0, 0, Netcam.EVT_FLAG_NONE);
            Debug.WriteLine("camPBSeek Backward: ret = " + ret);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            dispictureBox1.Refresh();
            int action = Netcam.ACTION_SNAP_FORWARD;
            int ret = Netcam.nbiofats_seek(playbacknetcam, action, 0, 0, 0, 0, 0, 0, Netcam.EVT_FLAG_NONE);
            Debug.WriteLine("camPBSeek Forward: ret = " + ret);
        }
        private void button37_Click(object sender, EventArgs e)
        {
            if (playbacknetcam != IntPtr.Zero)
            {
                int result = Netcam.nbiofats_rewind(playbacknetcam);
                Debug.WriteLine("nbiofats_rewind: ret = " + result);
            }
            else
            {
                MessageBox.Show("回放没有启动！");
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (playbacknetcam != IntPtr.Zero)
            {
                int result = Netcam.nbiofats_play(playbacknetcam);
                Debug.WriteLine("nbiofats_play: ret = " + result);
            }
            else
            {
                MessageBox.Show("回放没有启动！");
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (playbacknetcam != IntPtr.Zero)
            {
                int result = Netcam.nbiofats_stop(playbacknetcam);
                Debug.WriteLine("nbiofats_stop: ret = " + result);
            }
            else
            {
                MessageBox.Show("回放没有启动！");
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            
            int x = Int32.Parse(textBox20.Text.ToString());

            if (x == 1) x = 0;
            if (x > -32)
            {
                x--;
            }
            if (playbacknetcam != IntPtr.Zero)
            {
                if (x < 0) Netcam.nbiosfat_set_slow_set(playbacknetcam, System.Math.Abs(x));
                textBox20.Text = x.ToString();
                int ret = Netcam.nbiofats_set_x(playbacknetcam, x);
                Debug.WriteLine("camPBSetX Forward: ret = " + ret);
            }
            else
                MessageBox.Show("回放没有启动！");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox20.Text.ToString());


            if (x == -1) x = 0;
            if (x < Netcam.MAX_PLAY_SPEED)
            {
                x++;
            }
            if (playbacknetcam != IntPtr.Zero)
            {
                if (x < 0) Netcam.nbiosfat_set_slow_set(playbacknetcam, System.Math.Abs(x));
                textBox20.Text = x.ToString();
                int ret = Netcam.nbiofats_set_x(playbacknetcam, x);
                Debug.WriteLine("camPBSetX Forward: ret = " + ret);
            }
            else
                MessageBox.Show("回放没有启动！");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PtzContrlParam.query = 1;
            PtzContrlParam.ptzCmd = Netcam.PTZ_CMD_LEFTUP;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PtzContrlParam.query = 1;
            PtzContrlParam.ptzCmd = Netcam.PTZ_CMD_UP;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PtzContrlParam.query = 1;
            PtzContrlParam.ptzCmd = Netcam.PTZ_CMD_RIGHTUP;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PtzContrlParam.query = 1;
            PtzContrlParam.ptzCmd = Netcam.PTZ_CMD_LEFT;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PtzContrlParam.query = 1;
            PtzContrlParam.ptzCmd = Netcam.PTZ_CMD_STOP;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PtzContrlParam.query = 1;
            PtzContrlParam.ptzCmd = Netcam.PTZ_CMD_RIGHT;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PtzContrlParam.query = 1;
            PtzContrlParam.ptzCmd = Netcam.PTZ_CMD_LEFTDOWN;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PtzContrlParam.query = 1;
            PtzContrlParam.ptzCmd = Netcam.PTZ_CMD_DOWN;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            PtzContrlParam.query = 1;
            PtzContrlParam.ptzCmd = Netcam.PTZ_CMD_RIGHTDOWN;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PtzContrlParam.query = 1;
            PtzContrlParam.ptzCmd = Netcam.PTZ_CMD_ZOOMIN;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            PtzContrlParam.query = 1;
            PtzContrlParam.ptzCmd = Netcam.PTZ_CMD_ZOOMOUT;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            PtzContrlParam.query = 1;
            PtzContrlParam.ptzCmd = Netcam.PTZ_CMD_FOCUSFAR;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            PtzContrlParam.query = 1;
            PtzContrlParam.ptzCmd = Netcam.PTZ_CMD_FOCUSNEAR;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            PtzContrlParam.query = 1;
            PtzContrlParam.ptzCmd = Netcam.PTZ_CMD_SPEED;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);
            //PointToClient(this.button42.Location); 
            f.setX(this.button42.Location.X + this.panel3.Location.X + this.Location.X + this.button42.Width);
            f.setY(this.button42.Location.Y + this.panel3.Location.Y + this.Location.Y + this.button42.Height);
            f.setbutID(2);
            f.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IPInstaller.DATASTRUCT dataStructs = new IPInstaller.DATASTRUCT();
           
            if (comboBox1.SelectedIndex >= 0)
            {
                dataStructs = (IPInstaller.DATASTRUCT)ip_list[comboBox1.SelectedIndex];

                textBox2.Text = dataStructs.ip_addr;
                textBox3.Text = dataStructs.user_name;
                textBox4.Text = "9999";
                textBox5.Text = dataStructs.http_port.ToString();
            }
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int[] ip_address = new int[4];
            IPInstaller.DATASTRUCT dataStructs = new IPInstaller.DATASTRUCT();
            comboBox1.Items.Clear();
            ip_list.Clear();

            if (IPInstaller.IP_Search() == 0)
            {
                int ip_count = IPInstaller.Get_IP_Result(1000);
                if (ip_count > 0)
                {
                    for (int i = 0; i < ip_count; i++)
                    {
                        IPInstaller.Get_IP_Info(i, out dataStructs);
                        IPInstaller.Get_IP_address(i, out ip_address[0], out ip_address[1], out ip_address[2], out ip_address[3]);
                        dataStructs.ip_addr = ip_address[0].ToString() + "." + ip_address[1].ToString() + "." + ip_address[2].ToString() + "." + ip_address[3].ToString();

                        dataStructs.channels = IPInstaller.ntohl(dataStructs.channels);
                        dataStructs.http_port = IPInstaller.ntohl(dataStructs.http_port);
                        dataStructs.video_port = IPInstaller.ntohl(dataStructs.video_port);

                        if (dataStructs.model_name == "SC_EMBED" || dataStructs.model_name == "SC_GRAND")
                        {
                            comboBox1.Items.Add("Storage :" + dataStructs.ip_addr);
                            ip_list.Add(dataStructs);
                        }
                        //                         else if (dataStructs.model_name == "ENDAS_SDI_IPNC" || dataStructs.model_name == "ENDAS_4D_IPNC" || dataStructs.model_name == "ENDAS_1D_IPNC")
                        //                         {
                        //                             comboBox1.Items.Add("Video Sever    -   " + dataStructs.ip_addr);
                        //                             ip_list.Add(dataStructs);
                        //                         }
                    }
                }
            }
            IPInstaller.IP_Search_End();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Close(object sender, FormClosingEventArgs e)
        {
            //DisplayParam.stop = 0;

            disparam01.stop1 = 0;
            disparam02.stop1 = 0;
            disparam03.stop1 = 0;
            disparam04.stop1 = 0;
            disparam05.stop1 = 0;
            disparam06.stop1 = 0;
            disparam07.stop1 = 0;
            disparam08.stop1 = 0;
        }

        private void dispictureBox1_Click(object sender, EventArgs e)
        {
            //dispictureBox1.SetBounds(0,0,1921,1080);

        }

        // 16채널
        private void button47_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;

            comboBox3.Visible = true;
            comboBox4.Visible = true;
            comboBox5.Visible = true;
            comboBox6.Visible = true;
            comboBox7.Visible = true;
            comboBox8.Visible = true;
            comboBox9.Visible = true;
            comboBox10.Visible = true;
            comboBox11.Visible = true;
            comboBox12.Visible = true;
            comboBox13.Visible = true;
            comboBox14.Visible = true;
            comboBox15.Visible = true;
            comboBox16.Visible = true;
            comboBox17.Visible = true;

            Set16View();
            //SetChComboBox();

            //SetRuntimeView();
        }

        private void timer_clock_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = System.DateTime.Now.ToString("yyyy.MM.dd tt hh:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {

        }

        private void timer6_Tick(object sender, EventArgs e)
        {

        }

        private void timer7_Tick(object sender, EventArgs e)
        {

        }

        private void timer8_Tick(object sender, EventArgs e)
        {

        }
    }






















    class DisplayParam
    {
       public string ServerName = "sdktest";
       public string IP = "192.168.1.9";
       public string USER = "admin";
       public string Password = "wizbrain1!";
       public string WebPort = "80";
       public string DevicePort = "9001";
       public string Channel = "1";
       public string NDASID = "BGPQS-FKUFM-U8PU0-52G3S-R4FTU";
       public string DiskNO = "0";
       public string Member = "62D1F6";
       public int audio_enable = 1;
       public int search_type = 0;
       public IntPtr displaywnd = IntPtr.Zero;
       public static int stop = 1;
       public string Boxname = "";
       public IntPtr pnetcamP = IntPtr.Zero;

        public int stop1 = 1;
        public string id = "-1";

        public DisplayParam()
       {
                   
       }
    }
    class DownLoadParam
    {
        public string ServerName = "sdktest";
        public string IP = "192.168.1.9";
        public string USER = "admin";
        public string Password = "wizbrain1!";
        public string WebPort = "80";
        public string DevicePort = "9001";
        public string Channel = "1";
        public string NDASID = "BGPQS-FKUFM-U8PU0-52G3S-R4FTU";
        public string DiskNO = "0";
        public string Member = "62D1F6";
        public int audio_enable = 1;
        public int search_type = 0;

        public static int stop = 1;
        public int duration = 300;
        public string dateselect = "";
        public string bootpath = "";
        public DownLoadParam()
        {

        }
    }
    class DownLoadParam2
    {
        public string ServerName = "sdktest";
        public string IP = "192.168.1.9";
        public string USER = "admin";
        public string Password = "wizbrain1!";
        public string WebPort = "80";
        public string DevicePort = "9001";
        public string Channel = "1";
        public string NDASID = "BGPQS-FKUFM-U8PU0-52G3S-R4FTU";
        public string DiskNO = "0";
        public string Member = "62D1F6";
        public int audio_enable = 1;
        public int search_type = 0;

        public static int stop = 1;
        public int duration = 300;
        public string dateselect = "";
        public string bootpath = "";
        public string filename = "";
        public DownLoadParam2()
        {

        }
    }
    class PlayBackParam
    {
        public string ServerName = "sdktest";
        public string IP = "192.168.1.9";
        public string USER = "admin";
        public string Password = "wizbrain1!";
        public string WebPort = "80";
        public string DevicePort = "9001";
        public string Channel = "1";
        public string NDASID = "BGPQS-FKUFM-U8PU0-52G3S-R4FTU";
        public string DiskNO = "0";
        public string Member = "62D1F6";
        public int audio_enable = 1;
        public int search_type = 0;

        public static int stop = 1;
        public bool issearch = false;
        public string date = "";
        public string time = "";
        public string eventId = "";
        public IntPtr backplaywnd=IntPtr.Zero;
        public bool isEvent = false;
        public PlayBackParam()
        {

        }
    }
    class PtzContrlParam
    {
        public string ServerName = "sdktest";
        public string IP = "192.168.1.9";
        public string USER = "admin";
        public string Password = "wizbrain1!";
        public string WebPort = "80";
        public string Channel = "1";
        public string DevicePort = "9001";
        public string NDASID = "BGPQS-FKUFM-U8PU0-52G3S-R4FTU";
        public string DiskNO = "0";
        public string Member = "62D1F6";
        public int audio_enable = 1;
        public int search_type = 0;

        public static int stop = 1;
        public static int query = 1;
        public static int ptzCmd = 0;
        public PtzContrlParam()
        {

        }
    }
}
