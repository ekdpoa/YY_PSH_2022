using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Threading;
using Oracle.ManagedDataAccess.Client;
using System.Security.Cryptography;
//using MCRviewLib01;
//using NdasSDKDemo;



namespace MCRsysMain
{
    public partial class ViewMain : Form
    {
        public ViewMain()
        {
            InitializeComponent();
        }

        public static MCRviewLib01.View01 v01 = new MCRviewLib01.View01();
        public static MCRviewLib02.View02 v02 = new MCRviewLib02.View02();
        public static MCRviewLib03.View03 v03 = new MCRviewLib03.View03();
        public static MCRviewLib04.View04 v04 = new MCRviewLib04.View04();
        public static MCRviewLib05.View05 v05 = new MCRviewLib05.View05();
        public static MCRviewLib06.View06 v06 = new MCRviewLib06.View06();
        public static MCRviewLib07.View07 v07 = new MCRviewLib07.View07();
        public static MCRviewLib08.View08 v08 = new MCRviewLib08.View08();
        public static MCRviewLib09.View09 v09 = new MCRviewLib09.View09();
        public static MCRviewLib10.View10 v10 = new MCRviewLib10.View10();
        public static MCRviewLib11.View11 v11 = new MCRviewLib11.View11();
        public static MCRviewLib12.View12 v12 = new MCRviewLib12.View12();
        public static MCRviewLib13.View13 v13 = new MCRviewLib13.View13();
        public static MCRviewLib14.View14 v14 = new MCRviewLib14.View14();
        public static MCRviewLib15.View15 v15 = new MCRviewLib15.View15();

        public static MCRdbmsLib_20220901.Form1 vDB = new MCRdbmsLib_20220901.Form1();

        public static MCRdbmsLib_20220901.Form1 m_DbV12 = new MCRdbmsLib_20220901.Form1();

        string dateTime = System.DateTime.Now.ToString("yyyy.MM.dd tt hh:mm:ss");



        public OracleConnection m_Conn_AI = null;
        public OracleCommand m_Cmd_AI = null;
        public OracleDataReader m_Rdr_AI;
        public string m_CmdTextAI = @"SELECT * FROM 
                                    (SELECT AI_DL_ID,
                                        YY_LOG_DATE,
                                        AI_DATE,
                                        PRE_DATE_1,
                                        YY_PR_LV_1,
                                        YY_PR_OPEN_PER_1,
                                        PRE_DATE_3,
                                        YY_PR_LV_3,
                                        YY_PR_OPEN_PER_3,
                                        PRE_DATE_6,
                                        YY_PR_LV_6,
                                        YY_PR_OPEN_PER_6,
                                        YY_PR_CLOSE_PER_1,
                                        YY_PR_CLOSE_PER_3,
                                        YY_PR_CLOSE_PER_6,
                                        DL_DATE,
                                        YY_10MIN_SURPLUS_10THOUSAND,
                                        YY_41HVA_10MIN_INFLOW,
                                        YY_41HVA_10MIN_OUTFLOW 
                                        FROM AI_DL 
                                        ORDER BY YY_LOG_DATE DESC) 
                                        WHERE ROWNUM <= 138 ";
        public void Load_AI_Data() 
        {
            if (m_Cmd_AI != null) { m_Cmd_AI.Dispose(); }
            if (m_Conn_AI != null) { m_Conn_AI.Close(); }

            m_Conn_AI = new OracleConnection(m_strConn);
            if (m_Conn_AI == null) { return; }
            else { m_Conn_AI.Open(); }
            m_Cmd_AI = new OracleCommand();
            m_Cmd_AI.Connection = m_Conn_AI;
            m_Cmd_AI.CommandText = m_CmdTextAI;
            Console.WriteLine("InitConnAI proc complete");

            try
            {
                m_Rdr_AI = m_Cmd_AI.ExecuteReader();
                if (m_Rdr_AI == null) { return; }
                else
                {
                    v04.listBoxViewDataAI.Items.Clear();
                    while (m_Rdr_AI.Read())
                    {
                        for (int i = 0; i < m_Rdr_AI.FieldCount; i++)
                        {
                            v04.listBoxViewDataAI.Items.Add(m_Rdr_AI[i].ToString());
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Custom Check : QueryConnAI() : " + ex.Message);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
        }


        private void ViewMain_Load(object sender, EventArgs e)
        {
            //v03.listBoxViewData03.Visible = true;
            //v11.listBoxViewData11.Visible = true;
            //NdasSDKDemo.Form1 f = new NdasSDKDemo.Form1();
            //f.Show();
            LoadConfig();
            v11.m_streamingIP = m_streamingIP;
            v12.m_streamingIP = m_streamingIP;

            //Console.WriteLine("### v11 " + v11.m_streamingIP);
            //Console.WriteLine("### v12 " + v12.m_streamingIP);
            //Console.WriteLine("### main " + m_streamingIP);

            if (m_dlLoad.Equals("1")) { Load_AI_Data(); } else { }

            button3_Click(this, null);
        }

        private void ViewMain_Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        public string m_strExePath = "";
        public string m_strFileName = "";
        public string m_streamingIP = "";
        public string m_daySimul = "";

        public string m_dlLoad = ""; 

        public void LoadConfig()
        {
            try
            {
                StringBuilder sb = new StringBuilder(255);
                System.IO.FileInfo exefileinfo = new System.IO.FileInfo(System.Windows.Forms.Application.ExecutablePath);
                m_strExePath = exefileinfo.Directory.FullName.ToString();
                m_strFileName = m_strExePath + @"\" + System.Windows.Forms.Application.ProductName + ".ini";

                //string sbStr = sb.ToString();
                //int sbInt = int.Parse(sb.ToString());
                //short sbShort = short.Parse(sb.ToString());
                //double sbShort = double.Parse(sb.ToString());
                
                Win32RegNative.GetPrivateProfileString("MCRsysMain", "STRCONN", "", sb, 255, m_strFileName);
                m_strConn = sb.ToString();

                Win32RegNative.GetPrivateProfileString("MCRsysMain", "CMDMAIN", "", sb, 255, m_strFileName);
                m_CmdTextMain = sb.ToString();
                //Console.WriteLine(sb.ToString());

                Win32RegNative.GetPrivateProfileString("MCRsysMain", "DAYSIMUL", "", sb, 255, m_strFileName);
                m_daySimul = sb.ToString();



                Win32RegNative.GetPrivateProfileString("MCRsysMain", "DLLOAD", "", sb, 255, m_strFileName);
                m_dlLoad = sb.ToString();




                if (m_daySimul.Equals("1"))
                {
                    m_timer_ds.Enabled = false;
                }
                if (m_daySimul.Equals("2"))
                {
                    //m_Cmd_DS.CommandText = m_CmdTextDS;
                    m_timer_ds.Interval = 1000;
                    m_timer_ds.Enabled = true;
                }

                Win32RegNative.GetPrivateProfileString("MCRsysMain", "WIDTH", "", sb, 255, m_strFileName);
                m_width = int.Parse(sb.ToString());
                //Console.WriteLine(sb.ToString());

                Win32RegNative.GetPrivateProfileString("MCRsysMain", "HEIGHT", "", sb, 255, m_strFileName);
                m_height = int.Parse(sb.ToString());

                Win32RegNative.GetPrivateProfileString("MCRsysMain", "SCREEN1", "", sb, 255, m_strFileName);
                m_screen1 = int.Parse(sb.ToString());

                Win32RegNative.GetPrivateProfileString("MCRsysMain", "SCREEN2", "", sb, 255, m_strFileName);
                m_screen2 = int.Parse(sb.ToString());

                Win32RegNative.GetPrivateProfileString("MCRsysMain", "SCREEN3", "", sb, 255, m_strFileName);
                m_screen3 = int.Parse(sb.ToString());

                Win32RegNative.GetPrivateProfileString("MCRsysMain", "SCREEN4", "", sb, 255, m_strFileName);
                m_screen4 = int.Parse(sb.ToString());

                Win32RegNative.GetPrivateProfileString("MCRsysMain", "STREAMINGIP", "", sb, 255, m_strFileName);
                m_streamingIP = sb.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }



        private void btn_display_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 4)
            {
                MessageBox.Show("선택 화면 수량 불일치 _ (선택화면 4개고정)");
                return;
            }
            else
            {
                HideAllView();
                SetDisplay();
            }

            if (listBox1.Items.Contains("11"))
            {
                //v11.btn_play_Click(sender, e);
            }

            if (listBox1.Items.Contains("12"))
            {
                //v12.btn_play_Click(sender, e);
            }
        }

       
        public void HideAllView()
        {
            v01.Hide();
            v02.Hide();
            v03.Hide();
            v04.Hide();
            v05.Hide();
            v06.Hide();
            v07.Hide();
            v08.Hide();
            v09.Hide();
            v10.Hide();
            v11.Hide();
            v12.Hide();
            v13.Hide();
            v14.Hide();
            v15.Hide();
        }

        // 초기화버튼
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }
            HideAllView();

            if (listBox1.Items.Contains("11"))
            {
                v11.btn_stop_11_Click(sender, e);
            }

            if (listBox1.Items.Contains("12"))
            {
                v12.btn_stop_Click(sender, e);
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                //btn_play.Enabled = false;
                MessageBox.Show("재생할 영상이 없습니다.");
            }

            if (listBox1.Items.Contains("11"))
            {
                //v11.btn_play_Click(sender, e);
            }

            if (listBox1.Items.Contains("12"))
            {
                //v12.btn_play_Click(sender, e);
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                btn_stop.Enabled = false;
            }

            if (listBox1.Items.Contains("11"))
            {
                v11.btn_stop_11_Click(sender, e);
            }

            if (listBox1.Items.Contains("12"))
            {
                v12.btn_stop_Click(sender, e);
            }
        }

        private void btn_view01_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //UpdateViewList(btn.Text);
            UpdateViewList("01");
        }

        private void btn_view02_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //UpdateViewList(btn.Text);
            UpdateViewList("02");
        }

        private void btn_view03_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //UpdateViewList(btn.Text);
            UpdateViewList("03");
        }

        private void btn_view04_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //UpdateViewList(btn.Text);
            UpdateViewList("04");
        }

        private void btn_view05_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //UpdateViewList(btn.Text);
            UpdateViewList("05");
        }

        private void btn_view06_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //UpdateViewList(btn.Text);
            UpdateViewList("06");
        }

        private void btn_view07_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //UpdateViewList(btn.Text);
            UpdateViewList("07");
        }

        private void btn_view08_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //UpdateViewList(btn.Text);
            UpdateViewList("08");
        }

        private void btn_view09_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //UpdateViewList(btn.Text);
            UpdateViewList("09");
        }

        private void btn_view10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //UpdateViewList(btn.Text);
            UpdateViewList("10");
        }
        private void btn_view11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //UpdateViewList(btn.Text);
            UpdateViewList("11");
        }

        private void btn_view12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //UpdateViewList(btn.Text);
            UpdateViewList("12");
        }

        private void btn_view13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //UpdateViewList(btn.Text);
            UpdateViewList("13");
        }


        public void UpdateViewList(string viewName)
        {
            if(listBox1.Items.Count >= 4)
            {
                MessageBox.Show("선택 화면 수량 초과 _ (선택화면 3개고정)");
            }
            else
            {
                listBox1.Items.Add(viewName);
            }
        }

        public int m_width = 0;
        public int m_height = 0;

        public int m_screen1 = 0;
        public int m_screen2 = 0;
        public int m_screen3 = 0;
        public int m_screen4 = 0;

        public void SetDisplay()
        {
            int x = 0, y = 0, w = m_width, h = m_height;
            //int x = 0, y = 0, w = 1920, h = 2160;
            //int x = 0, y = 0, w = 3840, h = 2160;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (i == 0) x = m_screen1;
                if (i == 1) x = m_screen2;
                if (i == 2) x = m_screen3;
                if (i == 3) x = m_screen4;

                //폼텍스트 참조 비교(나중에)
                //if (listBox1.Items[i].ToString().Equals(v1.text)) { v1.SetBounds(x, y, w, h); }  
                /*
                if (listBox1.Items[i].ToString().Equals("01 발전소 종합현황")) { v1.SetBounds(x, y, w, h); v1.Show(); }
                else if (listBox1.Items[i].ToString().Equals("02 양양 양수발전 운전현황")) { v2.SetBounds(x, y, w, h); v2.Show(); }
                else if (listBox1.Items[i].ToString().Equals("03 345kV 차단기")) { v3.SetBounds(x, y, w, h); v3.Show(); }
                else if (listBox1.Items[i].ToString().Equals("04 상하부댐 현황")) { v4.SetBounds(x, y, w, h); v4.Show(); }
                else if (listBox1.Items[i].ToString().Equals("05 하부댐 여수로 소수력 어도")) { v5.SetBounds(x, y, w, h); v5.Show(); }
                else if (listBox1.Items[i].ToString().Equals("06 기상현황 레이더 영상")) { v6.SetBounds(x, y, w, h); v6.Show(); }
                else if (listBox1.Items[i].ToString().Equals("07 수력발전소 종합현황")) { v7.SetBounds(x, y, w, h); v7.Show(); }
                else if (listBox1.Items[i].ToString().Equals("08 양양 양수발전 운전현황 상세")) { v8.SetBounds(x, y, w, h); v8.Show(); }
                else if (listBox1.Items[i].ToString().Equals("09 18kV 차단기")) { v9.SetBounds(x, y, w, h); v9.Show(); }
                else if (listBox1.Items[i].ToString().Equals("10 하부댐 수위 및 수위예측")) { v10.SetBounds(x, y, w, h); v10.Show(); }
                else if (listBox1.Items[i].ToString().Equals("11 발전소 CCTV")) { v11.SetBounds(x, y, w, h); v11.Show(); }
                else if (listBox1.Items[i].ToString().Equals("12 하부댐 인근지역 CCTV")) { v12.SetBounds(x, y, w, h); v12.Show(); }
                else if (listBox1.Items[i].ToString().Equals("13 태풍 진행경로")) { v13.SetBounds(x, y, w, h); v13.Show(); }
                */
                if (listBox1.Items[i].ToString().Equals("01")) { v01.SetBounds(x, y, w, h); v01.Show(); Console.WriteLine(dateTime + " 1 실시간 발전 종합현황 실행"); }
                else if (listBox1.Items[i].ToString().Equals("02")) { v02.SetBounds(x, y, w, h); v02.Show(); Console.WriteLine(dateTime + " 2 양양 호기별 출력현황 실행"); }
                else if (listBox1.Items[i].ToString().Equals("03")) { v03.SetBounds(x, y, w, h); v03.Show(); Console.WriteLine(dateTime + " 3 345kV 실행"); }
                else if (listBox1.Items[i].ToString().Equals("04")) { v04.SetBounds(x, y, w, h); v04.Show(); Console.WriteLine(dateTime + " 4 상하부댐 현황 실행"); }
                else if (listBox1.Items[i].ToString().Equals("05")) { v05.SetBounds(x, y, w, h); v05.Show(); Console.WriteLine(dateTime + " 5 여수로/소수력/어도 실행"); }
                else if (listBox1.Items[i].ToString().Equals("06")) { v06.SetBounds(x, y, w, h); v06.Show(); Console.WriteLine(dateTime + " 6 기상레이더 실행"); }
                else if (listBox1.Items[i].ToString().Equals("07")) { v07.SetBounds(x, y, w, h); v07.Show(); Console.WriteLine(dateTime + " 7 2x2 날씨정보 실행"); }
                else if (listBox1.Items[i].ToString().Equals("08")) { v08.SetBounds(x, y, w, h); v08.Show(); Console.WriteLine(dateTime + " 8             실행"); }
                else if (listBox1.Items[i].ToString().Equals("09")) { v09.SetBounds(x, y, w, h); v09.Show(); Console.WriteLine(dateTime + " 9 18kV 실행"); }
                else if (listBox1.Items[i].ToString().Equals("10")) { v10.SetBounds(x, y, w, h); v10.Show(); Console.WriteLine(dateTime + " 10 하부댐 AI 실행"); }
                else if (listBox1.Items[i].ToString().Equals("11")) { v11.SetBounds(x, y, w, h); v11.Show(); Console.WriteLine(dateTime + " 11 발전CCTV 실행"); }
                else if (listBox1.Items[i].ToString().Equals("12")) { v12.SetBounds(x, y, w, h); v12.Show(); Console.WriteLine(dateTime + " 12 수계CCTV 실행"); }
                else if (listBox1.Items[i].ToString().Equals("13")) { v13.SetBounds(x, y, w, h); v13.Show(); Console.WriteLine(dateTime + " 13 태풍통보문 실행"); }
                else if (listBox1.Items[i].ToString().Equals("14")) { v14.SetBounds(x, y, w, h); v14.Show(); Console.WriteLine(dateTime + " 14 날씨예보 실행"); }
                else if (listBox1.Items[i].ToString().Equals("15")) { v15.SetBounds(x, y, w, h); v15.Show(); Console.WriteLine(dateTime + " 15 windy 실행"); }
            }
        }

        // DbPlay 버튼
        private void button3_Click(object sender, EventArgs e)
        {          
            InitConnMain();
            InitConnDS();   //20221124
            InitConn1st();
            InitConn2nd();
            InitConn3rd();
            InitConn4th();

            m_timer_PC_INFO.Enabled = true;

            if (listBox1.Items.Contains("11"))
            {
                //v11.btn_play_Click(sender, e);
            }

            if (listBox1.Items.Contains("12"))
            {
                //v12.btn_play_Click(sender, e);
            }
        }



        // DbStop 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            //vDB.Hide();
            //vDB.StopDbSelect();

            TimerSleep();
            m_timer_PC_INFO.Enabled = false;

            if (listBox1.Items.Contains("11"))
            {
                v11.btn_stop_11_Click(sender, e);
            }

            if (listBox1.Items.Contains("12"))
            {
                v12.btn_stop_Click(sender, e);
            }
        }

        public void StartOracleProcess()
        {
            m_runDb = 1;

            Thread t1 = new Thread(QueryOracleProcess);
            t1.Start(1);
        }

        public void StopOracleProcess()
        {
            m_runDb = 0;
        }

        public static int m_runDb = 0;

        public static int m_deviceNum = 1;

        public string m_query_PC_INFO;

        public string m_query_CB_18KV;
        public string m_query_CB_345KV;
        public string m_query_CCTV_CHANGE_INFO;
        public string m_query_CCTV_INFO;
        public string m_query_DL_BIG_DATA;
        public string m_query_ELECTRIC_LOW_SUPPLY;
        public string m_query_GTA_ALL_STATUS;
        public string m_query_HYDRO_GN_STATUS;
        public string m_query_HYDRO_OPERATION;
        public string m_query_HYDROPOWER_FISHROAD;
        public string m_query_NUCLEAR_GN_STATUS;
        public string m_query_PSH_STATUS;
        public string m_query_SCREEN_CHANGE_INFO;
        public string m_query_SCREEN_INFO;
        public string m_query_SHORT_FCST;
        public string m_query_TYPOON_NOTICE;
        public string m_query_UPDOWN_DAM;
        public string m_query_USER_INFO;
        public string m_query_WATERGATE_INFO;
        public string m_query_WEATHER_AWS;



        public void QueryOracleProcess(object id)
        {
            if (id == null) { return; }
            while (m_runDb == 1) { }
        }


        //string m_strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.117.4)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));User Id=yy_psh;Password=yy1234;";
        //string m_strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.87)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));User Id=YY_PSH;Password=Yangyang1234!@;pooling=false;";
        public string m_strConn = "";

        public void QueryOracle_PC_INFO2(string query)
        {
            bool viewPos = true;
            //OracleDataReader rdr = null;
            //rdr = vDB.QueryOracleReceiveValue(query);
            OracleConnection conn = new OracleConnection(m_strConn);
            if (conn == null)
            {
                return;
            }
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //string qry1 = "SELECT * FROM(SELECT * FROM CB_345KV ORDER BY YY_LOG_DATE DESC) WHERE ROWNUM = 1";
            //cmd.CommandText = "SELECT * FROM employees WHERE Id >= :id";
            //cmd.Parameters.Add(new OracleParameter("id", 1));
            //cmd.CommandText = qry1;
            cmd.CommandText = query;
            OracleDataReader rdr = cmd.ExecuteReader();
            //OracleDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (rdr == null) { return; }
            else
            {
                /*
                for(int i = 0; i < 3; i++)
                {
                    //listBox1.FindStringExact(rdr[i].ToString());
                    if (!listBox1.Items[i].ToString().Equals(rdr[i].ToString()))
                    {
                        viewPos = false;
                    }
                    else { }                   
                }
                */
                string s1, s2, s3, s4, s5, s6, t1, t2;
                if (listBox1.Items.Count < 3)
                {
                    s1 = "0"; s2 = "0"; s3 = "0"; t1 = "0";
                }
                else
                {
                    s1 = listBox1.Items[0].ToString();
                    s2 = listBox1.Items[1].ToString();
                    s3 = listBox1.Items[2].ToString();
                    t1 = listBox1.Items[3].ToString();
                }

                rdr.Read();
                //s4 = rdr[0].ToString();
                //s5 = rdr[1].ToString();
                //s6 = rdr[2].ToString();
                s4 = rdr["SCREEN1"].ToString();
                s5 = rdr["SCREEN2"].ToString();
                s6 = rdr["SCREEN3"].ToString();
                t2 = rdr["SCREEN4"].ToString();

                if (s1.Equals(s4)) { } else { viewPos = false; }
                if (s2.Equals(s5)) { } else { viewPos = false; }
                if (s3.Equals(s6)) { } else { viewPos = false; }
                if (t1.Equals(t2)) { } else { viewPos = false; }

                if (viewPos == true)
                {
                    rdr.Close();
                    return;
                }
                else
                {
                    if (listBox1.Items.Count > 0)
                    {
                        listBox1.Items.Clear();
                    }
                    UpdateViewList(s4);
                    UpdateViewList(s5);
                    UpdateViewList(s6);
                    UpdateViewList(t2);
                    rdr.Close();

                    btn_display_Click(this, null);
                }
            }
            cmd.Dispose();
            conn.Dispose();
            conn.Close();
        }

        public void QueryOracle_PC_INFO(string query)
        {
            bool viewPos = true;

            OracleDataReader rdr = null;
            rdr = vDB.QueryOracleReceiveValue(query);

            if (rdr == null) { return; }
            else
            {
                /*
                for(int i = 0; i < 3; i++)
                {
                    //listBox1.FindStringExact(rdr[i].ToString());
                    if (!listBox1.Items[i].ToString().Equals(rdr[i].ToString()))
                    {
                        viewPos = false;
                    }
                    else { }                   
                }
                */

                string s1, s2, s3, s4, s5, s6, t1, t2;
                if (listBox1.Items.Count < 3)
                {
                    s1 = "0"; s2 = "0"; s3 = "0"; t1 = "0";
                }
                else
                {
                    s1 = listBox1.Items[0].ToString();
                    s2 = listBox1.Items[1].ToString();
                    s3 = listBox1.Items[2].ToString();
                    t1 = listBox1.Items[3].ToString();
                }

                rdr.Read();
                //s4 = rdr[0].ToString();
                //s5 = rdr[1].ToString();
                //s6 = rdr[2].ToString();
                s4 = rdr["SCREEN1"].ToString();
                s5 = rdr["SCREEN2"].ToString();
                s6 = rdr["SCREEN3"].ToString();
                t2 = rdr["SCREEN4"].ToString();

                if (s1.Equals(s4)) { } else { viewPos = false; }
                if (s2.Equals(s5)) { } else { viewPos = false; }
                if (s3.Equals(s6)) { } else { viewPos = false; }
                if (t1.Equals(t2)) { } else { viewPos = false; }

                if (viewPos == true)
                {
                    rdr.Close();
                    return;
                }
                else
                {
                    if (listBox1.Items.Count > 0)
                    {
                        listBox1.Items.Clear();
                    }
                    UpdateViewList(s4);
                    UpdateViewList(s5);
                    UpdateViewList(s6);
                    UpdateViewList(t2);
                    rdr.Close();

                    btn_display_Click(this, null);
                }
            }
        }

        public void QueryOracle_MAP_CCTV2(string query)
        {
            OracleConnection conn = new OracleConnection(m_strConn);
            if (conn == null)
            {
                return;
            }
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = query;
            OracleDataReader rdr = cmd.ExecuteReader();

            string s4 = "0";
            string f = "0";
            if (rdr == null) { return; }
            else
            {
                rdr.Read();
                if (rdr["CNT"].ToString().Equals("0"))
                {
                    //return;
                    s4 = "0";
                    if (m_MapCctvSelectId.Equals(s4))
                    {
                        return;
                    }
                    else
                    {
                        v12.UpdateDefaultView(m_MapCctvSelectId);
                        m_MapCctvSelectId = s4;
                    }
                }
                else
                {
                    rdr.Close();
                    string s = @"SELECT CCTV_ID FROM MAP_CCTV WHERE FLAG_VAL='T'";
                    cmd.CommandText = s;
                    rdr = cmd.ExecuteReader();

                    //rdr = m_DbV12.QueryOracleReceiveValue(s);
                    if (rdr == null) { return; }
                    else
                    {
                        f = "0";
                        rdr.Read();
                        f = rdr["CCTV_ID"].ToString();
                        if (f.Equals(m_MapCctvSelectId))
                        {
                            return;
                        }
                        else
                        {
                            v12.UpdateDefaultView(m_MapCctvSelectId);
                            v12.UpdateFullView(f);
                            m_MapCctvSelectId = f;
                        }
                    }
                }
            }
            rdr.Close();
            cmd.Dispose();
            conn.Dispose();
            conn.Close();
            //20221013_sh
            Console.WriteLine("s4:" + s4 + ", mID:" + m_MapCctvSelectId + ", f:" + f);
        }

        public void QueryOracle_MAP_CCTV(string query)
        {
            bool viewPos = true;
            OracleDataReader rdr = null;
            //rdr = m_DbV12.QueryOracleReceiveValue(query);
            string s4 = "0";
            string f = "0";
            if (rdr == null) { return; }
            else
            {
                rdr.Read();
                if (rdr["CNT"].ToString().Equals("0"))
                {
                    //return;
                    s4 = "0";
                    if (m_MapCctvSelectId.Equals(s4))
                    {
                        return;
                    }
                    else
                    {
                        v12.UpdateDefaultView(m_MapCctvSelectId);
                        m_MapCctvSelectId = s4;
                    }
                }
                else
                {
                    //s4 = rdr[0].ToString();
                    //s5 = rdr[1].ToString();
                    //s6 = rdr[2].ToString();
                    //s4 = rdr["CCTV_ID"].ToString();
                    rdr.Close();
                    string s = @"SELECT CCTV_ID FROM MAP_CCTV WHERE FLAG_VAL='T'";
                    //rdr = m_DbV12.QueryOracleReceiveValue(s);
                    if (rdr == null) { return; }
                    else
                    {
                        f = "0";
                        rdr.Read();
                        f = rdr["CCTV_ID"].ToString();
                        if (f.Equals(m_MapCctvSelectId))
                        {
                            return;
                        }
                        else
                        {
                            v12.UpdateDefaultView(m_MapCctvSelectId);
                            v12.UpdateFullView(f);
                            m_MapCctvSelectId = f;
                        }
                    }
                }
            }
            rdr.Close();
            //20221013_sh
            Console.WriteLine("s4:" + s4 + ", mID:" + m_MapCctvSelectId + ", f:" + f);
        }


        public string m_MapCctvSelectId = "0";

        //20221124
        public OracleConnection m_Conn_DS = null;
        public OracleCommand m_Cmd_DS = null;
        public OracleDataReader m_Rdr_DS;
        public string m_CmdTextDS = @"SELECT * FROM TIME_SEASON WHERE ROWNUM = 1";


        //20221013
        public OracleConnection m_Conn_Main = null;
        public OracleConnection m_Conn_1st = null;
        public OracleConnection m_Conn_2nd = null;
        public OracleConnection m_Conn_3rd = null;
        public OracleConnection m_Conn_4th = null;
        public OracleCommand m_Cmd_Main = null;
        public OracleCommand m_Cmd_1st = null;
        public OracleCommand m_Cmd_2nd = null;
        public OracleCommand m_Cmd_3rd = null;
        public OracleCommand m_Cmd_4th = null;
        public OracleDataReader m_Rdr_Main;
        public OracleDataReader m_Rdr_1st;
        public OracleDataReader m_Rdr_2nd;
        public OracleDataReader m_Rdr_3rd;
        public OracleDataReader m_Rdr_4th;

        //public string m_CmdTextMain = @"SELECT SCREEN1, SCREEN2, SCREEN3, SCREEN4 FROM PC_INFO WHERE PC_ID = 3";
        public string m_CmdTextMain = "";
        //전력예비율, 양수/수력/원자력 발전량
        public string m_CmdText01 = @"SELECT * FROM 
                                    (SELECT 
                                        YY_LOG_DATE,
                                        SUPPABILITY,
                                        CURR_PWRTOT,
                                        SUPPRESERVE_PWR,
                                        SUPPRESERVE_RATE,
                                        PSH_YY,
                                        PSH_CP,
                                        PSH_MJ,
                                        PSH_SC,
                                        PSH_CS,
                                        PSH_YC,
                                        PSH_SRJ,
                                        HYDRO_HC,
                                        HYDRO_CH,
                                        HYDRO_UA,
                                        HYDRO_CP,
                                        HYDRO_PD,
                                        HYDRO_CB,
                                        HYDRO_BS,
                                        NUCLEAR_UJ,
                                        NUCLEAR_WS,
                                        NUCLEAR_SU,
                                        NUCLEAR_KR,
                                        NUCLEAR_YK
                                    FROM RT_API 
                                    ORDER BY YY_LOG_DATE DESC) WHERE ROWNUM = 1";
        //계통주파수, 실시간 발전량
        public string m_CmdText02 = @"SELECT * FROM 
                                    (SELECT YY_LOG_DATE, 
                                        YY_99KSC_GIS_BUS1_FREQ, 
                                        YY_01GTA_001UM_05AR33, 
                                        YY_01GTA_GEN_ST, 
                                        YY_01GTA_PUMP_ST, 
                                        YY_01GTA_MAINT_027IP, 
                                        YY_01GTA_006JS_021DI, 
                                        YY_01GTA_007JS_021DI, 
                                        YY_01GRE_100VG_08AI, 
                                        YY_01GTA_001JD_160DI, 
                                        YY_01GTA_001JD_021DI, 
                                        YY_02GTA_001UM_05AR33, 
                                        YY_02GTA_GEN_ST, 
                                        YY_02GTA_PUMP_ST, 
                                        YY_02GTA_MAINT_027IP, 
                                        YY_02GTA_006JS_021DI, 
                                        YY_02GTA_007JS_021DI, 
                                        YY_02GRE_100VG_08AI, 
                                        YY_02GTA_001JD_160DI, 
                                        YY_02GTA_001JD_021DI, 
                                        YY_03GTA_001UM_05AR33, 
                                        YY_03GTA_GEN_ST, 
                                        YY_03GTA_PUMP_ST, 
                                        YY_03GTA_MAINT_027IP, 
                                        YY_03GTA_006JS_021DI, 
                                        YY_03GTA_007JS_021DI, 
                                        YY_03GRE_100VG_08AI, 
                                        YY_03GTA_001JD_160DI, 
                                        YY_03GTA_001JD_021DI, 
                                        YY_04GTA_001UM_05AR33, 
                                        YY_04GTA_GEN_ST, 
                                        YY_04GTA_PUMP_ST, 
                                        YY_04GTA_MAINT_027IP, 
                                        YY_04GTA_006JS_021DI, 
                                        YY_04GTA_007JS_021DI, 
                                        YY_04GRE_100VG_08AI, 
                                        YY_04GTA_001JD_160DI, 
                                        YY_04GTA_001JD_021DI 
                                    FROM RT_DCS 
                                    ORDER BY YY_LOG_DATE DESC) WHERE ROWNUM = 1";
        //345kV
        public string m_CmdText03 = @"SELECT * FROM 
                                    (SELECT 
                                        YY_LOG_DATE, 
                                        YY_61LRL_002JS_160DI, 
                                        YY_61LRL_002JS_021DI, 
                                        YY_61LRL_012JS_160DI, 
                                        YY_61LRL_012JS_021DI, 
                                        YY_61LRL_001JD_160DI, 
                                        YY_61LRL_001JD_021DI, 
                                        YY_61LRL_011JS_160DI, 
                                        YY_61LRL_011JS_021DI, 
                                        YY_61LRL_001JS_160DI, 
                                        YY_61LRL_001JS_021DI, 
                                        YY_61LRL_013JS_160DI, 
                                        YY_61LRL_013JS_021DI, 
                                        YY_61LRL_003JS_160DI, 
                                        YY_61LRL_003JS_021DI, 
                                        YY_61LRL_010JS_160DI, 
                                        YY_61LRL_010JS_021DI, 
                                        YY_60LRC_001JS_160DI, 
                                        YY_60LRC_001JS_021DI, 
                                        YY_60LRC_011JS_160DI, 
                                        YY_60LRC_011JS_021DI, 
                                        YY_60LRC_001JD_160DI, 
                                        YY_60LRC_001JD_021DI, 
                                        YY_60LRC_012JS_160DI, 
                                        YY_60LRC_012JS_021DI, 
                                        YY_60LRC_002JS_160DI, 
                                        YY_60LRC_002JS_021DI,
                                        YY_61LRT_003JS_160DI, 
                                        YY_61LRT_003JS_021DI, 
                                        YY_61LRT_010JS_160DI, 
                                        YY_61LRT_010JS_021DI, 
                                        YY_61LRT_013JS_160DI, 
                                        YY_61LRT_013JS_021DI, 
                                        YY_61LRT_001JS_160DI, 
                                        YY_61LRT_001JS_021DI, 
                                        YY_61LRT_011JS_160DI, 
                                        YY_61LRT_011JS_021DI, 
                                        YY_61LRT_001JD_160DI, 
                                        YY_61LRT_001JD_021DI, 
                                        YY_61LRT_012JS_160DI, 
                                        YY_61LRT_012JS_021DI, 
                                        YY_61LRT_002JS_160DI, 
                                        YY_61LRT_002JS_021DI, 
                                        YY_60LRC_021JS_160DI, 
                                        YY_60LRC_021JS_021DI, 
                                        YY_60LRC_022JS_160DI, 
                                        YY_60LRC_022JS_021DI, 
                                        YY_62LRT_002JS_160DI, 
                                        YY_62LRT_002JS_021DI, 
                                        YY_62LRT_012JS_160DI, 
                                        YY_62LRT_012JS_021DI, 
                                        YY_62LRT_001JD_160DI, 
                                        YY_62LRT_001JD_021DI, 
                                        YY_62LRT_011JS_160DI, 
                                        YY_62LRT_011JS_021DI, 
                                        YY_62LRT_001JS_160DI, 
                                        YY_62LRT_001JS_021DI, 
                                        YY_62LRT_013JS_160DI, 
                                        YY_62LRT_013JS_021DI, 
                                        YY_62LRT_003JS_160DI, 
                                        YY_62LRT_003JS_021DI, 
                                        YY_62LRT_010JS_160DI, 
                                        YY_62LRT_010JS_021DI, 
                                        YY_60LRC_003JS_160DI, 
                                        YY_60LRC_003JS_021DI, 
                                        YY_60LRC_013JS_160DI, 
                                        YY_60LRC_013JS_021DI, 
                                        YY_60LRC_002JD_160DI, 
                                        YY_60LRC_002JD_021DI, 
                                        YY_60LRC_014JS_160DI, 
                                        YY_60LRC_014JS_021DI, 
                                        YY_60LRC_004JS_160DI, 
                                        YY_60LRC_004JS_021DI, 
                                        YY_63LRT_013JS_160DI, 
                                        YY_63LRT_013JS_021DI, 
                                        YY_63LRT_003JS_160DI, 
                                        YY_63LRT_003JS_021DI, 
                                        YY_63LRT_001JS_160DI, 
                                        YY_63LRT_001JS_021DI, 
                                        YY_63LRT_011JS_160DI, 
                                        YY_63LRT_011JS_021DI, 
                                        YY_63LRT_001JD_160DI, 
                                        YY_63LRT_001JD_021DI, 
                                        YY_63LRT_012JS_160DI, 
                                        YY_63LRT_012JS_021DI, 
                                        YY_63LRT_002JS_160DI, 
                                        YY_63LRT_002JS_021DI, 
                                        YY_63LRT_010JS_160DI, 
                                        YY_63LRT_010JS_021DI, 
                                        YY_62LRL_002JS_160DI, 
                                        YY_62LRL_002JS_021DI, 
                                        YY_62LRL_012JS_160DI, 
                                        YY_62LRL_012JS_021DI, 
                                        YY_62LRL_001JD_160DI, 
                                        YY_62LRL_001JD_021DI, 
                                        YY_62LRL_011JS_160DI, 
                                        YY_62LRL_011JS_021DI, 
                                        YY_62LRL_001JS_160DI, 
                                        YY_62LRL_001JS_021DI, 
                                        YY_62LRL_013JS_160DI, 
                                        YY_62LRL_013JS_021DI, 
                                        YY_62LRL_003JS_160DI, 
                                        YY_62LRL_003JS_021DI, 
                                        YY_62LRL_010JS_160DI, 
                                        YY_62LRL_010JS_021DI, 
                                        YY_60LRC_005JS_160DI, 
                                        YY_60LRC_005JS_021DI, 
                                        YY_60LRC_015JS_160DI, 
                                        YY_60LRC_015JS_021DI, 
                                        YY_60LRC_003JD_160DI, 
                                        YY_60LRC_003JD_021DI, 
                                        YY_60LRC_016JS_160DI, 
                                        YY_60LRC_016JS_021DI, 
                                        YY_60LRC_006JS_160DI, 
                                        YY_60LRC_006JS_021DI, 
                                        YY_64LRT_013JS_160DI, 
                                        YY_64LRT_013JS_021DI, 
                                        YY_64LRT_003JS_160DI, 
                                        YY_64LRT_003JS_021DI, 
                                        YY_64LRT_010JS_160DI, 
                                        YY_64LRT_010JS_021DI, 
                                        YY_64LRT_001JS_160DI, 
                                        YY_64LRT_001JS_021DI, 
                                        YY_64LRT_011JS_160DI, 
                                        YY_64LRT_011JS_021DI, 
                                        YY_64LRT_001JD_160DI, 
                                        YY_64LRT_001JD_021DI, 
                                        YY_64LRT_012JS_160DI, 
                                        YY_64LRT_012JS_021DI, 
                                        YY_64LRT_002JS_160DI, 
                                        YY_64LRT_002JS_021DI
                                    FROM CB_345KV  
                                    ORDER BY YY_LOG_DATE DESC) WHERE ROWNUM = 1";
        //상하부댐 현황
        //20230118 상하부댐 강수량 10분 -> 1일 변경
        public string m_CmdText04 = @"SELECT * FROM 
                                    (SELECT 
                                        YY_LOG_DATE, 
                                        YY_UR_SELECLVL_16AR, 
                                        YY_31KMH_RAINFALL_1DAY, 
                                        YY_31HVA_TEMP_017AR, 
                                        YY_41KMH_001LVL_16AR, 
                                        YY_41KMH_RAINFALL_1DAY, 
                                        YY_41HVA_TEMP_017AR, 
                                        YY_41HVA_10MIN_INFLOW, 
                                        YY_41HVA_10MIN_OUTFLOW, 
                                        YY_41KMH_VOLUMN_15AR, 
                                        YY_SURPLUS_VOLUMN_15AR,
                                        YY_31KMH_VOLUMN_15AR, 
                                        YY_41HVA_1HOUR_INFLOW
                                    FROM HYDRO_OPERATION 
                                    ORDER BY YY_LOG_DATE DESC) WHERE ROWNUM = 1";
        //하부댐 여수로, 소수력, 어도
        public string m_CmdText05 = @"SELECT * FROM 
                                    (SELECT 
                                        YY_LOG_DATE, 
                                        YY_41HVA_301VN_011AR2, 
                                        YY_41HVA_301VN_OUTFLOW, 
                                        YY_41HVA_302VN_011AR2, 
                                        YY_41HVA_302VN_OUTFLOW, 
                                        YY_41HVA_303VN_011AR2, 
                                        YY_41HVA_303VN_OUTFLOW, 
                                        YY_41HVA_304VN_011AR2, 
                                        YY_41HVA_304VN_OUTFLOW, 
                                        YY_41GTA_GCP1_AP_05AR, 
                                        YY_41GTA_FI_001_04AR, 
                                        YY_42GTA_FI_002_04AR, 
                                        YY_43GTA_GCP1_AP_05AR, 
                                        YY_43GTA_FI_003_04AR, 
                                        YY_42HVA_ZIT_101VN, 
                                        YY_42HVA_FQIT101_SEC, 
                                        YY_42HVA_ZIT_401VN, 
                                        YY_42HVA_FQIT401_SEC, 
                                        YY_42HVA_ZIT_501VN, 
                                        YY_42HVA_FQIT501_SEC, 
                                        YY_42GTA_GCP1_AP_05AR
                                    FROM ALL_HYDRO_ROAD  
                                    ORDER BY YY_LOG_DATE DESC) WHERE ROWNUM = 1";
        //web
        public string m_CmdText06 = @"";
        //2*2화면 계절별 낮밤 이미지 기존버전
        public string m_CmdText07 = @"SELECT 
                                    A.YY_LOG_DATE, A.DAY_ST, A.DAY_ED, A.NGT_ST, A.NGT_ED, 
                                    A.SPRING_ST, A.SPRING_ED, A.SUMMER_ST, A.SUMMER_ED, A.AUTUMN_ST, A.AUTUMN_ED, A.WINTER_ST, A.WINTER_ED, 
                                    B.FCSTDATE, B.FCSTTIME,B.SKY, B.PTY, B.TMN, B.TMX, B.PCP
                                    FROM 
                                    (
                                    select T.* from
                                        (select * from SETTING_TERM 
                                        order by YY_LOG_DATE desc) T
                                        where rownum=1
                                    ) A, 
                                    (
                                        select T.* from
                                        (select * from SHORT_FCST 
                                        order by fcstdate desc,fcsttime desc) T
                                        where rownum=1
                                    )B
                                    ORDER BY A.YY_LOG_DATE, B.FCSTDATE, B.FCSTTIME DESC";
        //2*2화면 계절별 낮밤 이미지 시뮬레이션
        public string m_CmdText07_1 = @"SELECT * FROM TIME_SEASON WHERE ROWNUM = 1";
        public string m_CmdText08 = @"SELECT * FROM (SELECT * FROM OPERATION_PSH ORDER BY YY_LOG_DATE DESC) WHERE ROWNUM = 1";
        //18kV
        /*
        //20230320 18kv + 발전호기별 정격출력 조회
        public string m_CmdText09 = @"SELECT
	                                        A.YY_LOG_DATE, A.YY_01GTA_001JD_160DI, A.YY_01GTA_001JD_021DI, A.YY_02GTA_001JD_160DI, A.YY_02GTA_001JD_021DI, 
	                                        A.YY_03GTA_001JD_160DI, A.YY_03GTA_001JD_021DI, A.YY_04GTA_001JD_160DI, A.YY_04GTA_001JD_021DI, A.YY_01GTA_005JS_160DI, 
	                                        A.YY_01GTA_005JS_021DI, A.YY_02GTA_005JS_160DI, A.YY_02GTA_005JS_021DI, A.YY_03GTA_005JS_160DI, A.YY_03GTA_005JS_021DI, 
	                                        A.YY_04GTA_005JS_160DI, A.YY_04GTA_005JS_021DI, A.YY_11GTA_001JD_160DI, A.YY_11GTA_001JD_021DI, A.YY_12GTA_001JD_160DI, 
	                                        A.YY_12GTA_001JD_021DI, A.YY_20LGA_1SW01B_160DI, A.YY_20LGA_1SW01B_021DI, A.YY_20LGA_2SW01B_160DI, A.YY_20LGA_2SW01B_021DI, 
	                                        A.YY_01GTA_006JS_021DI, A.YY_02GTA_006JS_021DI, A.YY_03GTA_006JS_021DI, A.YY_04GTA_006JS_021DI, A.YY_01GTA_007JS_021DI, 
	                                        A.YY_02GTA_007JS_021DI, A.YY_03GTA_007JS_021DI, A.YY_04GTA_007JS_021DI, A.YY_01GTA_004JS_160DI, A.YY_01GTA_004JS_021DI, 
	                                        A.YY_02GTA_004JS_160DI, A.YY_02GTA_004JS_021DI, A.YY_03GTA_004JS_160DI, A.YY_03GTA_004JS_021DI, A.YY_04GTA_004JS_160DI, 
	                                        A.YY_04GTA_004JS_021DI, A.YY_01GTA_003JS_160DI, A.YY_01GTA_003JS_021DI, A.YY_02GTA_003JS_160DI, A.YY_02GTA_003JS_021DI, 
	                                        A.YY_03GTA_003JS_160DI, A.YY_03GTA_003JS_021DI, A.YY_04GTA_003JS_160DI, A.YY_04GTA_003JS_021DI, A.YY_01GTA_002JS_160DI, 
	                                        A.YY_01GTA_002JS_021DI, A.YY_02GTA_002JS_160DI, A.YY_02GTA_002JS_021DI, A.YY_03GTA_002JS_160DI, A.YY_03GTA_002JS_021DI, 
	                                        A.YY_04GTA_002JS_160DI, A.YY_04GTA_002JS_021DI, A.YY_20GTA_001JD_160DI, A.YY_20GTA_001JD_021DI, A.YY_20SFC_002JD_160DI, 
	                                        A.YY_20SFC_002JD_021DI, A.YY_11GTA_001JS_160DI, A.YY_11GTA_001JS_021DI, A.YY_12GTA_001JS_160DI, A.YY_12GTA_001JS_021DI, 
	                                        B.YY_LOG_DATE, B.YY_01GTA_001UM_05AR33, B.YY_02GTA_001UM_05AR33, B.YY_03GTA_001UM_05AR33, B.YY_04GTA_001UM_05AR33, 
                                            B.YY_01GTA_MAINT_027IP, B.YY_02GTA_MAINT_027IP, B.YY_03GTA_MAINT_027IP, B.YY_04GTA_MAINT_027IP
                                        FROM
	                                        (
		                                        SELECT T.* FROM
			                                        (SELECT 
				                                        YY_LOG_DATE, YY_01GTA_001JD_160DI, YY_01GTA_001JD_021DI, YY_02GTA_001JD_160DI, YY_02GTA_001JD_021DI, 
				                                        YY_03GTA_001JD_160DI, YY_03GTA_001JD_021DI, YY_04GTA_001JD_160DI, YY_04GTA_001JD_021DI, 
				                                        YY_01GTA_005JS_160DI, YY_01GTA_005JS_021DI, YY_02GTA_005JS_160DI, YY_02GTA_005JS_021DI, 
				                                        YY_03GTA_005JS_160DI, YY_03GTA_005JS_021DI, YY_04GTA_005JS_160DI, YY_04GTA_005JS_021DI, 
				                                        YY_11GTA_001JD_160DI, YY_11GTA_001JD_021DI, YY_12GTA_001JD_160DI, YY_12GTA_001JD_021DI, 
				                                        YY_20LGA_1SW01B_160DI, YY_20LGA_1SW01B_021DI, YY_20LGA_2SW01B_160DI, YY_20LGA_2SW01B_021DI, 
				                                        YY_01GTA_006JS_021DI, YY_02GTA_006JS_021DI, YY_03GTA_006JS_021DI, YY_04GTA_006JS_021DI, 
				                                        YY_01GTA_007JS_021DI, YY_02GTA_007JS_021DI, YY_03GTA_007JS_021DI, YY_04GTA_007JS_021DI, 
				                                        YY_01GTA_004JS_160DI, YY_01GTA_004JS_021DI, YY_02GTA_004JS_160DI, YY_02GTA_004JS_021DI, 
				                                        YY_03GTA_004JS_160DI, YY_03GTA_004JS_021DI, YY_04GTA_004JS_160DI, YY_04GTA_004JS_021DI, 
				                                        YY_01GTA_003JS_160DI, YY_01GTA_003JS_021DI, YY_02GTA_003JS_160DI, YY_02GTA_003JS_021DI, 
				                                        YY_03GTA_003JS_160DI, YY_03GTA_003JS_021DI, YY_04GTA_003JS_160DI, YY_04GTA_003JS_021DI, 
				                                        YY_01GTA_002JS_160DI, YY_01GTA_002JS_021DI, YY_02GTA_002JS_160DI, YY_02GTA_002JS_021DI, 
				                                        YY_03GTA_002JS_160DI, YY_03GTA_002JS_021DI, YY_04GTA_002JS_160DI, YY_04GTA_002JS_021DI, 
				                                        YY_20GTA_001JD_160DI, YY_20GTA_001JD_021DI, YY_20SFC_002JD_160DI, YY_20SFC_002JD_021DI, 
				                                        YY_11GTA_001JS_160DI, YY_11GTA_001JS_021DI, YY_12GTA_001JS_160DI, YY_12GTA_001JS_021DI
			                                        FROM CB_18KV
			                                        ORDER BY YY_LOG_DATE DESC) T
		                                        WHERE ROWNUM = 1
	                                        ) A, 
	                                        (
		                                        SELECT T.* FROM 
			                                        (SELECT 
				                                        YY_LOG_DATE, YY_01GTA_001UM_05AR33, YY_02GTA_001UM_05AR33, 
				                                        YY_03GTA_001UM_05AR33, YY_04GTA_001UM_05AR33, 
                                                        YY_01GTA_MAINT_027IP, YY_02GTA_MAINT_027IP, YY_03GTA_MAINT_027IP, YY_04GTA_MAINT_027IP
			                                        FROM RT_DCS
			                                        ORDER BY YY_LOG_DATE DESC) T
		                                        WHERE ROWNUM = 1
	                                        ) B
                                        ORDER BY A.YY_LOG_DATE, B.YY_LOG_DATE DESC";
        */

        //18kv만 조회(기존)
        public string m_CmdText09 = @"SELECT * FROM 
                                    (SELECT 
                                        YY_LOG_DATE, 
                                        YY_01GTA_001JD_160DI, 
                                        YY_01GTA_001JD_021DI, 
                                        YY_02GTA_001JD_160DI, 
                                        YY_02GTA_001JD_021DI, 
                                        YY_03GTA_001JD_160DI, 
                                        YY_03GTA_001JD_021DI, 
                                        YY_04GTA_001JD_160DI, 
                                        YY_04GTA_001JD_021DI, 
                                        YY_01GTA_005JS_160DI, 
                                        YY_01GTA_005JS_021DI, 
                                        YY_02GTA_005JS_160DI, 
                                        YY_02GTA_005JS_021DI, 
                                        YY_03GTA_005JS_160DI, 
                                        YY_03GTA_005JS_021DI, 
                                        YY_04GTA_005JS_160DI, 
                                        YY_04GTA_005JS_021DI, 
                                        YY_11GTA_001JD_160DI, 
                                        YY_11GTA_001JD_021DI, 
                                        YY_12GTA_001JD_160DI, 
                                        YY_12GTA_001JD_021DI, 
                                        YY_20LGA_1SW01B_160DI, 
                                        YY_20LGA_1SW01B_021DI, 
                                        YY_20LGA_2SW01B_160DI, 
                                        YY_20LGA_2SW01B_021DI, 
                                        YY_01GTA_006JS_021DI, 
                                        YY_02GTA_006JS_021DI, 
                                        YY_03GTA_006JS_021DI, 
                                        YY_04GTA_006JS_021DI, 
                                        YY_01GTA_007JS_021DI, 
                                        YY_02GTA_007JS_021DI, 
                                        YY_03GTA_007JS_021DI, 
                                        YY_04GTA_007JS_021DI, 
                                        YY_01GTA_004JS_160DI, 
                                        YY_01GTA_004JS_021DI, 
                                        YY_02GTA_004JS_160DI, 
                                        YY_02GTA_004JS_021DI, 
                                        YY_03GTA_004JS_160DI, 
                                        YY_03GTA_004JS_021DI, 
                                        YY_04GTA_004JS_160DI, 
                                        YY_04GTA_004JS_021DI, 
                                        YY_01GTA_003JS_160DI, 
                                        YY_01GTA_003JS_021DI, 
                                        YY_02GTA_003JS_160DI, 
                                        YY_02GTA_003JS_021DI, 
                                        YY_03GTA_003JS_160DI, 
                                        YY_03GTA_003JS_021DI, 
                                        YY_04GTA_003JS_160DI, 
                                        YY_04GTA_003JS_021DI, 
                                        YY_01GTA_002JS_160DI, 
                                        YY_01GTA_002JS_021DI, 
                                        YY_02GTA_002JS_160DI, 
                                        YY_02GTA_002JS_021DI, 
                                        YY_03GTA_002JS_160DI, 
                                        YY_03GTA_002JS_021DI, 
                                        YY_04GTA_002JS_160DI, 
                                        YY_04GTA_002JS_021DI, 
                                        YY_20GTA_001JD_160DI, 
                                        YY_20GTA_001JD_021DI, 
                                        YY_20SFC_002JD_160DI, 
                                        YY_20SFC_002JD_021DI, 
                                        YY_11GTA_001JS_160DI, 
                                        YY_11GTA_001JS_021DI, 
                                        YY_12GTA_001JS_160DI, 
                                        YY_12GTA_001JS_021DI
                                    FROM CB_18KV  
                                    ORDER BY YY_LOG_DATE DESC) WHERE ROWNUM = 1";

        //수위예측
        public string m_CmdText10 = /*@"select * from ai_dl order by yy_log_date desc ";*/
                                    @"SELECT * FROM
                                    (SELECT 
                                        AI_DL_ID,
                                        YY_LOG_DATE,
                                        AI_DATE,
                                        PRE_DATE_1,
                                        YY_PR_LV_1,
                                        YY_PR_OPEN_PER_1,
                                        PRE_DATE_3,
                                        YY_PR_LV_3,
                                        YY_PR_OPEN_PER_3,
                                        PRE_DATE_6,
                                        YY_PR_LV_6,
                                        YY_PR_OPEN_PER_6,
                                        YY_PR_CLOSE_PER_1,
                                        YY_PR_CLOSE_PER_3,
                                        YY_PR_CLOSE_PER_6,
                                        DL_DATE,
                                        YY_10MIN_SURPLUS_10THOUSAND,
                                        YY_41HVA_10MIN_INFLOW,
                                        YY_41HVA_10MIN_OUTFLOW
                                    FROM AI_DL
                                    ORDER BY YY_LOG_DATE DESC) WHERE ROWNUM = 1";


        //수위예측
        public string m_CmdText101 = /*@"select * from ai_dl order by yy_log_date desc ";*/
                                    @"SELECT * FROM
                                    (SELECT 
                                        AI_DL_ID,
                                        YY_LOG_DATE,
                                        AI_DATE,
                                        PRE_DATE_1,
                                        YY_PR_LV_1,
                                        YY_PR_OPEN_PER_1,
                                        PRE_DATE_3,
                                        YY_PR_LV_3,
                                        YY_PR_OPEN_PER_3,
                                        PRE_DATE_6,
                                        YY_PR_LV_6,
                                        YY_PR_OPEN_PER_6,
                                        YY_PR_CLOSE_PER_1,
                                        YY_PR_CLOSE_PER_3,
                                        YY_PR_CLOSE_PER_6,
                                        DL_DATE,
                                        YY_10MIN_SURPLUS_10THOUSAND,
                                        YY_41HVA_10MIN_INFLOW,
                                        YY_41HVA_10MIN_OUTFLOW
                                    FROM AI_DL
                                    ORDER BY YY_LOG_DATE DESC) WHERE ROWNUM <= 138";


        //발전cctv
        public string m_CmdText11 = @"SELECT 
                                        SCREEN_TYPE, 
                                        SCREEN1, 
                                        SCREEN2, 
                                        SCREEN3, 
                                        SCREEN4, 
                                        SCREEN5, 
                                        SCREEN6, 
                                        SCREEN7, 
                                        SCREEN8, 
                                        FLAG_VAL
                                    FROM CCTV_CHANGE_INFO
                                    WHERE FLAG_VAL = 'T'";
        //수계cctv
        public string m_CmdText12 = @"SELECT FLAG_VAL FROM MAP_CCTV";
        public string m_CmdText13 = @"";
        public ListBox m_ListBox1st;
        public ListBox m_ListBox2nd;
        public ListBox m_ListBox3rd;
        public ListBox m_ListBox4th;


        public void InitConnDS()
        {
            if (m_Cmd_DS != null) { m_Cmd_DS.Dispose(); }
            if (m_Conn_DS != null) { m_Conn_DS.Close(); }

            m_Conn_DS = new OracleConnection(m_strConn);
            if (m_Conn_DS == null) { return; }
            else { m_Conn_DS.Open(); }
            m_Cmd_DS = new OracleCommand();
            m_Cmd_DS.Connection = m_Conn_DS;
            m_Cmd_DS.CommandText = m_CmdTextDS;
            Console.WriteLine("InitConnDS proc complete");
        }

        public void InitConnMain()
        {
            if (m_Cmd_Main != null) { m_Cmd_Main.Dispose(); }
            if (m_Conn_Main != null) { m_Conn_Main.Close(); }

            m_Conn_Main = new OracleConnection(m_strConn);
            if (m_Conn_Main == null) { return; }
            else { m_Conn_Main.Open(); }
            m_Cmd_Main = new OracleCommand();
            m_Cmd_Main.Connection = m_Conn_Main;
            m_Cmd_Main.CommandText = m_CmdTextMain;
            Console.WriteLine("InitConnMain proc complete");
        }

        public void InitConn1st()
        {
            if (m_Cmd_1st != null) { m_Cmd_1st.Dispose(); }
            if (m_Conn_1st != null) { m_Conn_1st.Close(); }

            m_Conn_1st = new OracleConnection(m_strConn);
            if (m_Conn_1st == null) { return; }
            else { m_Conn_1st.Open(); }
            m_Cmd_1st = new OracleCommand();
            m_Cmd_1st.Connection = m_Conn_1st;
            Console.WriteLine("InitConn1st proc complete");
        }

        public void InitConn2nd()
        {
            if (m_Cmd_2nd != null) { m_Cmd_2nd.Dispose(); }
            if (m_Conn_2nd != null) { m_Conn_2nd.Close(); }

            m_Conn_2nd = new OracleConnection(m_strConn);
            if (m_Conn_2nd == null) { return; }
            else { m_Conn_2nd.Open(); }
            m_Cmd_2nd = new OracleCommand();
            m_Cmd_2nd.Connection = m_Conn_2nd;
            Console.WriteLine("InitConn2nd proc complete");
        }

        public void InitConn3rd()
        {
            if (m_Cmd_3rd != null) { m_Cmd_3rd.Dispose(); }
            if (m_Conn_3rd != null) { m_Conn_3rd.Close(); }

            m_Conn_3rd = new OracleConnection(m_strConn);
            if (m_Conn_3rd == null) { return; }
            else { m_Conn_3rd.Open(); }
            m_Cmd_3rd = new OracleCommand();
            m_Cmd_3rd.Connection = m_Conn_3rd;
            Console.WriteLine("InitConn3rd proc complete");
        }

        public void InitConn4th()
        {
            if (m_Cmd_4th != null) { m_Cmd_4th.Dispose(); }
            if (m_Conn_4th != null) { m_Conn_4th.Close(); }

            m_Conn_4th = new OracleConnection(m_strConn);
            if (m_Conn_4th == null) { return; }
            else { m_Conn_4th.Open(); }
            m_Cmd_4th = new OracleCommand();
            m_Cmd_4th.Connection = m_Conn_4th;
            Console.WriteLine("InitConn4th proc complete");
        }





        public void SetCmdText1st(string strItem)
        {
            if (strItem.Equals("01")) { m_Cmd_1st.CommandText = m_CmdText01; m_ListBox1st = listBox01; }
            else if (strItem.Equals("02")) { m_Cmd_1st.CommandText = m_CmdText02; m_ListBox1st = listBox02; }
            else if (strItem.Equals("03")) { m_Cmd_1st.CommandText = m_CmdText03; m_ListBox1st = listBox03; }
            else if (strItem.Equals("04")) { m_Cmd_1st.CommandText = m_CmdText04; m_ListBox1st = listBox04; }
            else if (strItem.Equals("05")) { m_Cmd_1st.CommandText = m_CmdText05; m_ListBox1st = listBox05; }
            else if (strItem.Equals("06")) { m_Cmd_1st.CommandText = m_CmdText06; m_ListBox1st = listBox06; }

            else if (strItem.Equals("07")) {
                m_Cmd_1st.CommandText = m_CmdText07; m_ListBox1st = listBox07;
                /*
                if (m_daySimul == 1)
                {
                    m_Cmd_1st.CommandText = m_CmdText07; m_ListBox1st = listBox07; 
                }
                if (m_daySimul == 2)
                {
                    m_Cmd_1st.CommandText = m_CmdText07_1; m_ListBox1st = listBox07;
                }
                */
            }

            else if (strItem.Equals("08")) { m_Cmd_1st.CommandText = m_CmdText08; m_ListBox1st = listBox08; }
            else if (strItem.Equals("09")) { m_Cmd_1st.CommandText = m_CmdText09; m_ListBox1st = listBox09; }
            else if (strItem.Equals("10")) { m_Cmd_1st.CommandText = m_CmdText10; m_ListBox1st = listBox10; }
            else if (strItem.Equals("11")) { m_Cmd_1st.CommandText = m_CmdText11; m_ListBox1st = listBox11; }
            else if (strItem.Equals("12")) { m_Cmd_1st.CommandText = m_CmdText12; m_ListBox1st = listBox12; }
            else if (strItem.Equals("13")) { m_Cmd_1st.CommandText = m_CmdText13; m_ListBox1st = listBox13; }
            //20221124
            //else if (strItem.Equals("14")) { m_Cmd_1st.CommandText = m_CmdTextDS; m_ListBox1st = listBox14; }
        }

        public void SetCmdText2nd(string strItem)
        {
            if (strItem.Equals("01")) { m_Cmd_2nd.CommandText = m_CmdText01; m_ListBox2nd = listBox01; }
            else if (strItem.Equals("02")) { m_Cmd_2nd.CommandText = m_CmdText02; m_ListBox2nd = listBox02; }
            else if (strItem.Equals("03")) { m_Cmd_2nd.CommandText = m_CmdText03; m_ListBox2nd = listBox03; }
            else if (strItem.Equals("04")) { m_Cmd_2nd.CommandText = m_CmdText04; m_ListBox2nd = listBox04; }
            else if (strItem.Equals("05")) { m_Cmd_2nd.CommandText = m_CmdText05; m_ListBox2nd = listBox05; }
            else if (strItem.Equals("06")) { m_Cmd_2nd.CommandText = m_CmdText06; m_ListBox2nd = listBox06; }

            else if (strItem.Equals("07")) {
                m_Cmd_2nd.CommandText = m_CmdText07; m_ListBox2nd = listBox07;
                /*
                if (m_daySimul == 1)
                {
                    m_Cmd_2nd.CommandText = m_CmdText07; m_ListBox2nd = listBox07;
                }
                if (m_daySimul == 2)
                {
                    m_Cmd_2nd.CommandText = m_CmdText07_1; m_ListBox2nd = listBox07;
                }
                */
            }

            else if (strItem.Equals("08")) { m_Cmd_2nd.CommandText = m_CmdText08; m_ListBox2nd = listBox08; }
            else if (strItem.Equals("09")) { m_Cmd_2nd.CommandText = m_CmdText09; m_ListBox2nd = listBox09; }
            else if (strItem.Equals("10")) { m_Cmd_2nd.CommandText = m_CmdText10; m_ListBox2nd = listBox10; }
            else if (strItem.Equals("11")) { m_Cmd_2nd.CommandText = m_CmdText11; m_ListBox2nd = listBox11; }
            else if (strItem.Equals("12")) { m_Cmd_2nd.CommandText = m_CmdText12; m_ListBox2nd = listBox12; }
            else if (strItem.Equals("13")) { m_Cmd_2nd.CommandText = m_CmdText13; m_ListBox2nd = listBox13; }
            //20221124
            //else if (strItem.Equals("14")) { m_Cmd_2nd.CommandText = m_CmdTextDS; m_ListBox2nd = listBox14; }
        }

        public void SetCmdText3rd(string strItem)
        {
            if (strItem.Equals("01")) { m_Cmd_3rd.CommandText = m_CmdText01; m_ListBox3rd = listBox01; }
            else if (strItem.Equals("02")) { m_Cmd_3rd.CommandText = m_CmdText02; m_ListBox3rd = listBox02; }
            else if (strItem.Equals("03")) { m_Cmd_3rd.CommandText = m_CmdText03; m_ListBox3rd = listBox03; }
            else if (strItem.Equals("04")) { m_Cmd_3rd.CommandText = m_CmdText04; m_ListBox3rd = listBox04; }
            else if (strItem.Equals("05")) { m_Cmd_3rd.CommandText = m_CmdText05; m_ListBox3rd = listBox05; }
            else if (strItem.Equals("06")) { m_Cmd_3rd.CommandText = m_CmdText06; m_ListBox3rd = listBox06; }

            else if (strItem.Equals("07")) {
                m_Cmd_3rd.CommandText = m_CmdText07; m_ListBox3rd = listBox07;
                /*
                if (m_daySimul == 1)
                {
                    m_Cmd_3rd.CommandText = m_CmdText07; m_ListBox3rd = listBox07;
                }
                if (m_daySimul == 2)
                {
                    m_Cmd_3rd.CommandText = m_CmdText07_1; m_ListBox3rd = listBox07;
                }
                */
            }

            else if (strItem.Equals("08")) { m_Cmd_3rd.CommandText = m_CmdText08; m_ListBox3rd = listBox08; }
            else if (strItem.Equals("09")) { m_Cmd_3rd.CommandText = m_CmdText09; m_ListBox3rd = listBox09; }
            else if (strItem.Equals("10")) { m_Cmd_3rd.CommandText = m_CmdText10; m_ListBox3rd = listBox10; }
            else if (strItem.Equals("11")) { m_Cmd_3rd.CommandText = m_CmdText11; m_ListBox3rd = listBox11; }
            else if (strItem.Equals("12")) { m_Cmd_3rd.CommandText = m_CmdText12; m_ListBox3rd = listBox12; }
            else if (strItem.Equals("13")) { m_Cmd_3rd.CommandText = m_CmdText13; m_ListBox3rd = listBox13; }
            //20221124
            //else if (strItem.Equals("14")) { m_Cmd_3rd.CommandText = m_CmdTextDS; m_ListBox3rd = listBox14; }
        }

        public void SetCmdText4th(string strItem)
        {
            if (strItem.Equals("01")) { m_Cmd_4th.CommandText = m_CmdText01; m_ListBox4th = listBox01; }
            else if (strItem.Equals("02")) { m_Cmd_4th.CommandText = m_CmdText02; m_ListBox4th = listBox02; }
            else if (strItem.Equals("03")) { m_Cmd_4th.CommandText = m_CmdText03; m_ListBox4th = listBox03; }
            else if (strItem.Equals("04")) { m_Cmd_4th.CommandText = m_CmdText04; m_ListBox4th = listBox04; }
            else if (strItem.Equals("05")) { m_Cmd_4th.CommandText = m_CmdText05; m_ListBox4th = listBox05; }
            else if (strItem.Equals("06")) { m_Cmd_4th.CommandText = m_CmdText06; m_ListBox4th = listBox06; }

            else if (strItem.Equals("07")) { 
                m_Cmd_4th.CommandText = m_CmdText07; m_ListBox4th = listBox07;
                /*
                if (m_daySimul == 1)
                {
                    m_Cmd_4th.CommandText = m_CmdText07; m_ListBox4th = listBox07;
                }
                if (m_daySimul == 2)
                {
                    m_Cmd_4th.CommandText = m_CmdText07_1; m_ListBox4th = listBox07;
                }
                */
            }

            else if (strItem.Equals("08")) { m_Cmd_4th.CommandText = m_CmdText08; m_ListBox4th = listBox08; }
            else if (strItem.Equals("09")) { m_Cmd_4th.CommandText = m_CmdText09; m_ListBox4th = listBox09; }
            else if (strItem.Equals("10")) { m_Cmd_4th.CommandText = m_CmdText10; m_ListBox4th = listBox10; }
            else if (strItem.Equals("11")) { m_Cmd_4th.CommandText = m_CmdText11; m_ListBox4th = listBox11; }
            else if (strItem.Equals("12")) { m_Cmd_4th.CommandText = m_CmdText12; m_ListBox4th = listBox12; }
            else if (strItem.Equals("13")) { m_Cmd_4th.CommandText = m_CmdText13; m_ListBox4th = listBox13; }
            //20221124
            //else if (strItem.Equals("14")) { m_Cmd_4th.CommandText = m_CmdTextDS; m_ListBox4th = listBox14; }
        }



        private void Tick_timer_PC_INFO(object sender, EventArgs e)
        {
            //string qry1 = "SELECT SCREEN1, SCREEN2, SCREEN3, SCREEN4 FROM PC_INFO WHERE PC_ID=1";
            //string qry2 = "SELECT SCREEN1, SCREEN2, SCREEN3, SCREEN4 FROM PC_INFO WHERE PC_ID=2";
            //string qry3 = "SELECT SCREEN1, SCREEN2, SCREEN3, SCREEN4 FROM PC_INFO WHERE PC_ID=3";
            //QueryOracle_PC_INFO(qry3);
            //QueryOracle_PC_INFO2(qry3);
            QueryConnMain();
        }




        //20221124 계절별 낮밤 이미지 변경
        public void QueryConnDS()
        {
            try
            {
                bool viewPos = true;
                m_Rdr_DS = m_Cmd_DS.ExecuteReader();
                //OracleDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (m_Rdr_DS == null) { return; }
                else
                {
                    string s1, s2, s3, s4, s5, s6, t1, t2;
                    if (listBox14.Items.Count < 2)
                    {
                        s1 = "00"; s2 = "00";
                    }
                    else
                    {
                        s1 = listBox14.Items[0].ToString();
                        s2 = listBox14.Items[1].ToString();
                     
                    }
                    m_Rdr_DS.Read();
                    //s4 = rdr[0].ToString();
                    //s5 = rdr[1].ToString();
                    //s6 = rdr[2].ToString();
                    s4 = m_Rdr_DS["DAYNIGHT"].ToString();   //대상 테이블 컬럼명 _낮밤
                    s5 = m_Rdr_DS["SEASON"].ToString();   //대상 테이블 컬럼명 _계절


                    if (s1.Equals(s4)) { } else { viewPos = false; }
                    if (s2.Equals(s5)) { } else { viewPos = false; }
                 
                    if (viewPos == true) { m_Rdr_DS.Close(); return; }
                    else
                    {
                        //TimerSleep();

                        //변경값 식별에 따른 배경테마 변경적용 작업 실행
                        if (s4.Equals("01")) 
                        {
                            //낮에 따른 사계절
                            if (s5.Equals("01")) { v04.btn_spring_day_Click(this, null); }
                            else if (s5.Equals("02")) { v04.btn_summer_day_Click(this, null); }
                            else if (s5.Equals("03")) { v04.btn_autumn_day_Click(this, null); }
                            else if (s5.Equals("04")) { v04.btn_winter_day_Click(this, null); }
                        }
                        else
                        {
                            // 밤
                            if (s5.Equals("01")) { v04.btn_spring_night_Click(this, null); }
                            else if (s5.Equals("02")) { v04.btn_summer_night_Click(this, null); }
                            else if (s5.Equals("03")) { v04.btn_autumn_night_Click(this, null); }
                            else if (s5.Equals("04")) { v04.btn_winter_night_Click(this, null); }
                        }

                        if (listBox14.Items.Count > 0)
                        {
                            listBox14.Items.Clear();
                        }

                        listBox14.Items.Add(s4);
                        listBox14.Items.Add(s5);

                        m_Rdr_DS.Close();
                        //btn_display_Click(this, null);

                        //TimerRun();
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Custom Check : QueryConnMain() : " + ex.Message);
                button2_Click(this, null);
                button3_Click(this, null);
            }
        }


        public void QueryConnMain()
        {
            try
            {
                bool viewPos = true;
                m_Rdr_Main = m_Cmd_Main.ExecuteReader();
                //OracleDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (m_Rdr_Main == null) { return; }
                else
                {
                    string s1, s2, s3, s4, s5, s6, t1, t2;
                    if (listBox1.Items.Count < 3)
                    {
                        s1 = "00"; s2 = "00"; s3 = "00"; t1 = "00";
                    }
                    else
                    {
                        s1 = listBox1.Items[0].ToString();
                        s2 = listBox1.Items[1].ToString();
                        s3 = listBox1.Items[2].ToString();
                        t1 = listBox1.Items[3].ToString();
                    }
                    m_Rdr_Main.Read();
                    //s4 = rdr[0].ToString();
                    //s5 = rdr[1].ToString();
                    //s6 = rdr[2].ToString();
                    s4 = m_Rdr_Main["SCREEN1"].ToString();
                    s5 = m_Rdr_Main["SCREEN2"].ToString();
                    s6 = m_Rdr_Main["SCREEN3"].ToString();
                    t2 = m_Rdr_Main["SCREEN4"].ToString();

                    if (s1.Equals(s4)) { } else { viewPos = false; }
                    if (s2.Equals(s5)) { } else { viewPos = false; }
                    if (s3.Equals(s6)) { } else { viewPos = false; }
                    if (t1.Equals(t2)) { } else { viewPos = false; }

                    if (viewPos == true) { m_Rdr_Main.Close(); return; }
                    else
                    {
                        TimerSleep();

                        if (listBox1.Items.Count > 0)
                        {
                            listBox1.Items.Clear();
                        }
                        UpdateViewList(s4);
                        UpdateViewList(s5);
                        UpdateViewList(s6);
                        UpdateViewList(t2);
                        m_Rdr_Main.Close();
                        btn_display_Click(this, null);

                        SetCmdText1st(s4);
                        SetCmdText2nd(s5);
                        SetCmdText3rd(s6);
                        SetCmdText4th(t2);

                        TimerRun();

                        //20230111
                        if (listBox1.Items.Contains("11")) { m_timer_gen_cctv.Enabled = true; }
                        else { return; }
                        
                        //20230105
                        if (listBox1.Items.Contains("12")) { m_timer_map_cctv.Enabled = true; }
                        else { return; }
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Custom Check : QueryConnMain() : " + ex.Message);
                button2_Click(this, null);
                button3_Click(this, null);
            }
        }


        

        private void m_timer_gen_cctv_Tick(object sender, EventArgs e)
        {
            //CheckGenCCTV();

            CheckGenCCTVScreen();

        }

        string gen_a = "";
        string gen_b = "";
        
        string screenType = "";


        public void CheckGenCCTV()
        {
            /*
            try
            {
                gen_a = string.Empty;
                gen_b = string.Empty;

                for (int i = 0; i < listBox11.Items.Count; i++)
                {
                    gen_a = listBox11.Items[i].ToString();
                    gen_b = listBox111.Items[i].ToString();

                    if (gen_a.Equals(gen_b)) { }
                    else
                    {
                        listBox111.Items.RemoveAt(i);
                        listBox111.Items.Insert(i, gen_a);

                        CheckGenCCTVScreen();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            */
        }


        public string strCH11 = "";
        public string strCH12 = "";
        public string strCH13 = "";
        public string strCH14 = "";
        public string strCH15 = "";
        public string strCH16 = "";
        public string strCH17 = "";
        public string strCH18 = "";
        public void CheckGenCCTVScreen()
        {
            if (listBox11.Items.Count < 10) { return; }

            Boolean bChk = true;

            string strCH1 = "";
            string strCH2 = "";
            string strCH3 = "";
            string strCH4 = "";
            string strCH5 = "";
            string strCH6 = "";
            string strCH7 = "";
            string strCH8 = "";
            /*
            string strCH11 = "";
            string strCH12 = "";
            string strCH13 = "";
            string strCH14 = "";
            string strCH15 = "";
            string strCH16 = "";
            string strCH17 = "";
            string strCH18 = "";
            */
            //v11.btn_stop_11_Click(this, null);
            //v11.btn_play_Click(this, null);

            if (listBox11.Items.Count == 0) { }
            else
            {
                screenType = listBox11.Items[0].ToString();
            }

            if (screenType.Equals("1"))
            {
                strCH1 = listBox11.Items[1].ToString();

                //strCH11 = listBox111.Items[0].ToString();

                if (strCH1.Equals(strCH11)) { } else { bChk = false; }

                if (bChk == true) { return; }
                else
                {
                    strCH11 = strCH1;
                    /*
                    listBox111.Items.Clear();
                    listBox111.Items.Add(strCH11);
                    */
                    v11.ChangeRuntimeView8(strCH11, strCH12, strCH13, strCH14, strCH15, strCH16, strCH17, strCH18, screenType);
                    

                }
            }
            else if (screenType.Equals("2"))
            {
                strCH1 = listBox11.Items[1].ToString();
                strCH2 = listBox11.Items[2].ToString();
                strCH3 = listBox11.Items[3].ToString();
                strCH4 = listBox11.Items[4].ToString();
                /*
                strCH11 = listBox111.Items[0].ToString();
                strCH12 = listBox111.Items[1].ToString();
                strCH13 = listBox111.Items[2].ToString();
                strCH14 = listBox111.Items[3].ToString();
                */
                if (strCH1.Equals(strCH11)) { } else { bChk = false; }
                if (strCH2.Equals(strCH12)) { } else { bChk = false; }
                if (strCH3.Equals(strCH13)) { } else { bChk = false; }
                if (strCH4.Equals(strCH14)) { } else { bChk = false; }

                if (bChk == true) { return; }
                else
                {
                    strCH11 = strCH1;
                    strCH12 = strCH2;
                    strCH13 = strCH3;
                    strCH14 = strCH4;
                    /*
                    listBox111.Items.Clear();
                    listBox111.Items.Add(strCH11);
                    listBox111.Items.Add(strCH12);
                    listBox111.Items.Add(strCH13);
                    listBox111.Items.Add(strCH14);
                    */
                    v11.ChangeRuntimeView8(strCH11, strCH12, strCH13, strCH14, strCH15, strCH16, strCH17, strCH18, screenType);

                }
            }
            else if (screenType.Equals("3"))
            {
                strCH1 = listBox11.Items[1].ToString();
                strCH2 = listBox11.Items[2].ToString();
                strCH3 = listBox11.Items[3].ToString();
                strCH4 = listBox11.Items[4].ToString();
                strCH5 = listBox11.Items[5].ToString();
                strCH6 = listBox11.Items[6].ToString();
                strCH7 = listBox11.Items[7].ToString();
                strCH8 = listBox11.Items[8].ToString();
                /*
                strCH11 = listBox111.Items[0].ToString();
                strCH12 = listBox111.Items[1].ToString();
                strCH13 = listBox111.Items[2].ToString();
                strCH14 = listBox111.Items[3].ToString();
                strCH15 = listBox111.Items[4].ToString();
                strCH16 = listBox111.Items[5].ToString();
                strCH17 = listBox111.Items[6].ToString();
                strCH18 = listBox111.Items[7].ToString();
                */
                if (strCH1.Equals(strCH11)) { } else { bChk = false; }
                if (strCH2.Equals(strCH12)) { } else { bChk = false; }
                if (strCH3.Equals(strCH13)) { } else { bChk = false; }
                if (strCH4.Equals(strCH14)) { } else { bChk = false; }
                if (strCH5.Equals(strCH15)) { } else { bChk = false; }
                if (strCH6.Equals(strCH16)) { } else { bChk = false; }
                if (strCH7.Equals(strCH17)) { } else { bChk = false; }
                if (strCH8.Equals(strCH18)) { } else { bChk = false; }

                if (bChk == true) { return; }
                else
                {
                    strCH11 = strCH1;
                    strCH12 = strCH2;
                    strCH13 = strCH3;
                    strCH14 = strCH4;
                    strCH15 = strCH5;
                    strCH16 = strCH6;
                    strCH17 = strCH7;
                    strCH18 = strCH8;
                    /*
                    listBox111.Items.Clear();
                    listBox111.Items.Add(strCH11);
                    listBox111.Items.Add(strCH12);
                    listBox111.Items.Add(strCH13);
                    listBox111.Items.Add(strCH14);
                    listBox111.Items.Add(strCH15);
                    listBox111.Items.Add(strCH16);
                    listBox111.Items.Add(strCH17);
                    listBox111.Items.Add(strCH18);
                    */
                    v11.ChangeRuntimeView8(strCH11, strCH12, strCH13, strCH14, strCH15, strCH16, strCH17, strCH18, screenType);
                    
                }
            }
            else { }





        }

        //발전cctv: 7~104

        public void ChangeGenCCTVCh()
        {

        }


        private void timer_map_cctv_Tick(object sender, EventArgs e)
        {
            CheckMapCCTV();
        }


        string map_a = "";
        string map_b = "";

        public void CheckMapCCTV()
        {
            try
            {
                map_a = string.Empty;
                map_b = string.Empty;

                for (int i = 0; i < listBox12.Items.Count; i++)
                {
                    map_a = listBox12.Items[i].ToString();
                    map_b = listBox121.Items[i].ToString();

                    if (map_a.Equals(map_b)) { }
                    else
                    {
                        listBox121.Items.RemoveAt(i);
                        listBox121.Items.Insert(i, map_a);

                        ChangeMapCCTVSize();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            } 
        }


        //default: -2, all F:-1, T: i
        public int m_checkNum = -2;
        
        public void ChangeMapCCTVSize()
        {
            try
            {
                string m_f = "";

                for (int i = 0; i < listBox121.Items.Count; i++)
                {
                    if (listBox121.Items[i].ToString().Equals("T"))
                    {
                        m_checkNum = i;

                        //Console.WriteLine("##### m_checkNum: " + m_checkNum);

                        if (m_checkNum == 0) { v12.dispictureBox1_Click(this, null); }
                        else if (m_checkNum == 1) { v12.pictureBox1_Click(this, null); }
                        else if (m_checkNum == 2) { v12.pictureBox2_Click(this, null); }
                        else if (m_checkNum == 3) { v12.pictureBox3_Click(this, null); }
                        else if (m_checkNum == 4) { v12.pictureBox4_Click(this, null); }
                        else if (m_checkNum == 5) { v12.pictureBox5_Click(this, null); }
                    }

                    if (listBox121.Items[i].ToString().Equals("F"))
                    {
                        m_checkNum = -1;
                        m_f += String.Format("F");
                    }
                    
                    if (m_f.Equals("FFFFFF")) { v12.SetDefaultSize(); }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        public void TimerSleep()
        {
            m_timer_ds.Enabled = false;         //20221124
            m_timer_map_cctv.Enabled = false;   //20230110
            m_timer_gen_cctv.Enabled = false;   //20230111
            m_timer_1st.Enabled = false;
            m_timer_2nd.Enabled = false;
            m_timer_3rd.Enabled = false;
            m_timer_4th.Enabled = false;
            m_timer_1stSend.Enabled = false;
            m_timer_2ndSend.Enabled = false;
            m_timer_3rdSend.Enabled = false;
            m_timer_4thSend.Enabled = false;
        }

        public void TimerRun()
        {
            m_timer_ds.Enabled = true;
            m_timer_1st.Enabled = true;
            m_timer_2nd.Enabled = true;
            m_timer_3rd.Enabled = true;
            m_timer_4th.Enabled = true;
            m_timer_1stSend.Enabled = true;
            m_timer_2ndSend.Enabled = true;
            m_timer_3rdSend.Enabled = true;
            m_timer_4thSend.Enabled = true;
        }


        public void QueryConn1st()
        {
            try
            {
                m_Rdr_1st = m_Cmd_1st.ExecuteReader();
                if (m_Rdr_1st == null) { return; }
                else
                {
                    m_ListBox1st.Items.Clear();
                    while (m_Rdr_1st.Read())
                    {
                        for (int i = 0; i < m_Rdr_1st.FieldCount; i++)
                        {
                            m_ListBox1st.Items.Add(m_Rdr_1st[i].ToString());
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Custom Check : QueryConn1st() : " + ex.Message);
                button2_Click(this, null);
                button3_Click(this, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                button2_Click(this, null);
                button3_Click(this, null);
            }
        }


        public void QueryConn2nd()
        {
            try
            {
                m_Rdr_2nd = m_Cmd_2nd.ExecuteReader();
                if (m_Rdr_2nd == null) { return; }
                else
                {
                    m_ListBox2nd.Items.Clear();
                    while (m_Rdr_2nd.Read())
                    {
                        for (int i = 0; i < m_Rdr_2nd.FieldCount; i++)
                        {
                            m_ListBox2nd.Items.Add(m_Rdr_2nd[i].ToString());
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Custom Check : QueryConn2nd() : " + ex.Message);
                button2_Click(this, null);
                button3_Click(this, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                button2_Click(this, null);
                button3_Click(this, null);
            }
        }


        public void QueryConn3rd()
        {
            try
            {
                m_Rdr_3rd = m_Cmd_3rd.ExecuteReader();
                if (m_Rdr_3rd == null) { return; }
                else
                {
                    m_ListBox3rd.Items.Clear();
                    while (m_Rdr_3rd.Read())
                    {
                        for (int i = 0; i < m_Rdr_3rd.FieldCount; i++)
                        {
                            m_ListBox3rd.Items.Add(m_Rdr_3rd[i].ToString());
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Custom Check : QueryConn3rd() : " + ex.Message);
                button2_Click(this, null);
                button3_Click(this, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                button2_Click(this, null);
                button3_Click(this, null);
            }
        }


        public void QueryConn4th()
        {
            try
            {
                m_Rdr_4th = m_Cmd_4th.ExecuteReader();
                if (m_Rdr_4th == null) { return; }
                else
                {
                    m_ListBox4th.Items.Clear();
                    while (m_Rdr_4th.Read())
                    {
                        for (int i = 0; i < m_Rdr_4th.FieldCount; i++)
                        {
                            m_ListBox4th.Items.Add(m_Rdr_4th[i].ToString());
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Custom Check : QueryConn4th() : " + ex.Message);
                button2_Click(this, null);
                button3_Click(this, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                button2_Click(this, null);
                button3_Click(this, null);
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Size = new Size(1310, 540);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Size = new Size(210, 540);
        }


        private void Tick_timer_V12(object sender, EventArgs e)
        {
            //string qry = @"SELECT CCTV_ID FROM MAP_CCTV WHERE FLAG_VAL='T'";
            string qry = @"SELECT COUNT(*) AS CNT FROM MAP_CCTV WHERE FLAG_VAL='T'";
            //string qry = @"select count(cctv_id) as CNT, cctv_id from map_cctv  group by flag_val, cctv_id having flag_val = 'T'";
            //QueryOracle_MAP_CCTV2(qry);
        }

        //20221124
        public string m_simulatorKind = "0";

        private void Tick_timer_DS(object sender, EventArgs e)
        {
            //if (m_Conn_DS.CommandText.Length < 1) { return; }
            QueryConnDS();
        }

        private void Tick_timer_1st(object sender, EventArgs e)
        {
            if (m_Cmd_1st.CommandText.Length < 1) { return; }
            QueryConn1st();
        }

        private void Tick_timer_2nd(object sender, EventArgs e)
        {
            if (m_Cmd_2nd.CommandText.Length < 1) { return; }
            QueryConn2nd();
        }

        private void Tick_timer_3rd(object sender, EventArgs e)
        {
            if (m_Cmd_3rd.CommandText.Length < 1) { return; }
            QueryConn3rd();
        }

        private void Tick_timer_4th(object sender, EventArgs e)
        {
            if (m_Cmd_4th.CommandText.Length < 1) { return; }
            QueryConn4th();
        }

        private void Tick_timer_1stSend(object sender, EventArgs e)
        {
            SetListboxViewData(0);
        }

        private void Tick_timer_2ndSend(object sender, EventArgs e)
        {
            SetListboxViewData(1);
        }

        private void Tick_timer_3rdSend(object sender, EventArgs e)
        {
            SetListboxViewData(2);
        }

        private void Tick_timer_4thSend(object sender, EventArgs e)
        {
            SetListboxViewData(3);
        }

        public void SetListboxViewData(int idx)
        {
            string strItem = listBox1.Items[idx].ToString();
            if (strItem.Equals("01")) { SendListboxViewData01(); }
            else if (strItem.Equals("02")) { SendListboxViewData02(); }
            else if (strItem.Equals("03")) { SendListboxViewData03(); }
            else if (strItem.Equals("04")) { SendListboxViewData04(); }
            else if (strItem.Equals("05")) { SendListboxViewData05(); }
            else if (strItem.Equals("06")) { SendListboxViewData06(); }
            else if (strItem.Equals("07")) { SendListboxViewData07(); }
            else if (strItem.Equals("08")) { SendListboxViewData08(); }
            else if (strItem.Equals("09")) { SendListboxViewData09(); }
            else if (strItem.Equals("10")) { SendListboxViewData10(); }
            else if (strItem.Equals("11")) { SendListboxViewData11(); }
            else if (strItem.Equals("12")) { SendListboxViewData12(); }
            else if (strItem.Equals("13")) { SendListboxViewData13(); }
        }

        public void SendListboxViewData01()
        {
            if (listBox01.Items.Count <= 0) { return; }
            v01.listBoxViewData01.Items.Clear();

            for (int i = 0; i < listBox01.Items.Count; i++)
            {
                v01.listBoxViewData01.Items.Add(listBox01.Items[i].ToString());
            }
        }
        public void SendListboxViewData02()
        {
            if (listBox02.Items.Count <= 0) { return; }
            v01.listBoxViewData02.Items.Clear();

            for (int i = 0; i < listBox02.Items.Count; i++)
            {
                v01.listBoxViewData02.Items.Add(listBox02.Items[i].ToString());
            }
        }

        public void SendListboxViewData03()
        {
            if (listBox03.Items.Count <= 0) { return; }
            v03.listBoxViewData03.Items.Clear();

            for (int i = 0; i < listBox03.Items.Count; i++)
            {
                v03.listBoxViewData03.Items.Add(listBox03.Items[i].ToString());
            }
        }

        public void SendListboxViewData04()
        {
            if (listBox04.Items.Count <= 0) { return; }
            v04.listBoxViewData04.Items.Clear();

            for (int i = 0; i < listBox04.Items.Count; i++)
            {
                v04.listBoxViewData04.Items.Add(listBox04.Items[i].ToString());
            }
        }

        public void SendListboxViewData05()
        {
            if (listBox05.Items.Count <= 0) { return; }
            v04.listBoxViewData05.Items.Clear();

            for (int i = 0; i < listBox05.Items.Count; i++)
            {
                v04.listBoxViewData05.Items.Add(listBox05.Items[i].ToString());
            }
        }

        public void SendListboxViewData06() { }

        //2x2화면 날씨, 계절정보
        public void SendListboxViewData07()
        {
            if (listBox07.Items.Count <= 0) { return; }
            v04.listBoxViewData07.Items.Clear();

            for (int i = 0; i < listBox07.Items.Count; i++)
            {
                v04.listBoxViewData07.Items.Add(listBox07.Items[i].ToString());
            }
        }

        public void SendListboxViewData08()
        {
            if (listBox08.Items.Count <= 0) { return; }
            v08.listBoxViewData.Items.Clear();

            for (int i = 0; i < listBox08.Items.Count; i++)
            {
                v08.listBoxViewData.Items.Add(listBox08.Items[i].ToString());
            }
        }

        public void SendListboxViewData09()
        {
            if (listBox09.Items.Count <= 0) { return; }
            v03.listBoxViewData09.Items.Clear();

            for (int i = 0; i < listBox09.Items.Count; i++)
            {
                v03.listBoxViewData09.Items.Add(listBox09.Items[i].ToString());
            }
        }

        public void SendListboxViewData10()
        {
            if (listBox10.Items.Count <= 0) { return; }
            v04.listBoxViewData10.Items.Clear();

            for (int i = 0; i < listBox10.Items.Count; i++)
            {
                v04.listBoxViewData10.Items.Add(listBox10.Items[i].ToString());
            }
        }

        public void SendListboxViewData11()
        {
            if (listBox11.Items.Count <= 0) { return; }
            v11.listBoxViewData11.Items.Clear();

            for (int i = 0; i < listBox11.Items.Count; i++)
            {
                v11.listBoxViewData11.Items.Add(listBox11.Items[i].ToString());
            }
        }

        public void SendListboxViewData12()
        {
            if (listBox12.Items.Count <= 0) { return; }
            v12.listBoxViewData.Items.Clear();

            for (int i = 0; i < listBox12.Items.Count; i++)
            {
                v12.listBoxViewData.Items.Add(listBox12.Items[i].ToString());
            }
        }
        public void SendListboxViewData13() { }

        

        //20221124
        //public void SendListboxViewData14() { }

    }
}
