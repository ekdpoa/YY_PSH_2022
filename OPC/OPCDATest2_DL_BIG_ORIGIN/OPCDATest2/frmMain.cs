using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TitaniumAS.Opc.Client.Common;
using TitaniumAS.Opc.Client.Da;
using TitaniumAS.Opc.Client.Da.Wrappers;
using TitaniumAS.Opc.Client.Interop.Da;

namespace OPCDATest2
{
    public partial class frmMain : Form
    {
        private OpcDaServer _server;
        int a = 0;
        int b = 1000;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //_server = new OpcDaServer(UrlBuilder.Build("Matrikon.OPC.Simulation.1"));
            //_server = new OpcDaServer("Matrikon.OPC.Simulation.1", "192.168.117.247:135");
            _server = new OpcDaServer("Matrikon.OPC.Modbus.1");
            _server.Connect();
            if (_server.IsConnected)
            {
                //MessageBox.Show("Connect");
            }
            else 
            {
                MessageBox.Show("Connection Miss");
            }
        }

        private void btnDisconn_Click(object sender, EventArgs e)
        {
            _server.Disconnect();
            _server.Dispose();
        }

        private void btnRGroup_Click(object sender, EventArgs e)
        {
            if (!_server.IsConnected)
                return;
            int count = 0;

            lbGroup.Items.Clear();

            _server.SyncGroups();
            foreach (var opcDaGroup in _server.Groups)
            {
                string strGroup = "G = [" + opcDaGroup.Name + "]";
                opcDaGroup.SyncItems();
                opcDaGroup.SyncState();
                lbGroup.Items.Add(strGroup);
                foreach (var oitem in opcDaGroup.Items)
                {
                    string strItem = "I = [" + oitem.ItemId + "]";
                    lbGroup.Items.Add(strItem);
                    count += 1;
                }
            }
            MessageBox.Show("Total Items : " + count);
        }

        //1. DCS데이터 읽어오기 -> listBox1에 표출
        private void btnRData_Click(object sender, EventArgs e)
        {
            //읽어올 DCS태그 이름 넣기
            string[] opcTag = {"MCR.01GTA_001UM_05AR33", "MCR.02GTA_001UM_05AR33", "MCR.03GTA_001UM_05AR33", 
                                "MCR.04GTA_001UM_05AR33", "MCR.UR_SELECLVL_16AR", "MCR.41KMH_001LVL_16AR",
                                "MCR.SURPLUS_VOLUMN_15AR", "MCR.41HVA_10MIN_INFLOW", "MCR.41HVA_10MIN_OUTFLOW"};

            List<TimeSpan> tsMax = new List<TimeSpan>();

            for(int j = 0; j < opcTag.Length; j++)
            {
                tsMax.Add(TimeSpan.Zero);
            }

            listBox1.Items.Clear();
            var values = _server.Read(opcTag, tsMax);
            for(int i = 0; i < opcTag.Length; i++)
            {
                listBox1.Items.Add(values[i].Value);
            }

            getValue();
        }

        public string a2 = "";
        public string a3 = "";
        public string a4 = "";
        public string a5 = "";
        public string a6 = "";
        public string a7 = "";
        public string a8 = "";
        public string a9 = "";
        public string a10 = "";

        //public string a11 = "";
        /*
        public string a12 = "";
        public string a13 = "";
        public string a14 = "";
        public string a15 = "";
        public string a16 = "";
        public string a17 = "";
        public string a18 = "";
        public string a19 = "";
        public string a20 = "";
        public string a21 = "";
        public string a22 = "";
        public string a23 = "";
        public string a24 = "";
        public string a25 = "";
        public string a26 = "";
        public string a27 = "";
        public string a28 = "";
        public string a29 = "";
        public string a30 = "";
        public string a31 = "";
        public string a32 = "";
        public string a33 = "";
        public string a34 = "";
        public string a35 = "";
        public string a36 = "";
        public string a37 = "";
        public string a38 = "";
        */

        public void getValue()
        {
            a2 = listBox1.Items[0].ToString();
            a3 = listBox1.Items[1].ToString();
            a4 = listBox1.Items[2].ToString();
            a5 = listBox1.Items[3].ToString();
            a6 = listBox1.Items[4].ToString();
            a7 = listBox1.Items[5].ToString();
            a8 = listBox1.Items[6].ToString();
            a9 = listBox1.Items[7].ToString();
            a10 = listBox1.Items[8].ToString();

            //a11 = listBox1.Items[9].ToString();
            /*
            a12 = listBox1.Items[10].ToString();
            a13 = listBox1.Items[11].ToString();
            a14 = listBox1.Items[12].ToString();
            a15 = listBox1.Items[13].ToString();
            a16 = listBox1.Items[14].ToString();
            a17 = listBox1.Items[15].ToString();
            a18 = listBox1.Items[16].ToString();
            a19 = listBox1.Items[17].ToString();
            a20 = listBox1.Items[18].ToString();
            a21 = listBox1.Items[19].ToString();
            a22 = listBox1.Items[20].ToString();
            a23 = listBox1.Items[21].ToString();
            a24 = listBox1.Items[22].ToString();
            a25 = listBox1.Items[23].ToString();
            a26 = listBox1.Items[24].ToString();
            a27 = listBox1.Items[25].ToString();
            a28 = listBox1.Items[26].ToString();
            a29 = listBox1.Items[27].ToString();
            a30 = listBox1.Items[28].ToString();
            a31 = listBox1.Items[29].ToString();
            a32 = listBox1.Items[30].ToString();
            a33 = listBox1.Items[31].ToString();
            a34 = listBox1.Items[32].ToString();
            a35 = listBox1.Items[33].ToString();
            a36 = listBox1.Items[34].ToString();
            a37 = listBox1.Items[35].ToString();
            a38 = listBox1.Items[36].ToString();
            */
        }

        public void test()
        {
            MessageBox.Show(a5);
        }
        

        private void btnWrite_Click(object sender, EventArgs e)
        {
            /*
            string[] itemIds = new[] { "TEST.Channel1.TAG0001", "TEST.Channel2.TEST0001", "TEST.Channel2.TEST0002" };
            OpcDaItemValue[] values = new OpcDaItemValue[]
            {
                new OpcDaItemValue()
                {
                    Value = Convert.ToInt32(txtVal.Text),
                    Timestamp = DateTimeOffset.Now-TimeSpan.FromHours(1)
                },
                new OpcDaItemValue()
                {
                    Value = 0,
                    Timestamp = DateTimeOffset.Now-TimeSpan.FromHours(1)
                },
                new OpcDaItemValue()
                {
                    Value = 0,
                    Timestamp = DateTimeOffset.Now-TimeSpan.FromHours(1)
                },
            };
            HRESULT[] errors = _server.WriteVQT(itemIds, values);
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitConnDS();
            QueryConnDS();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.SetBounds(0, 0, 320, 900);

            InitConnDS();
            btnList_Click(sender, e);

            timer1.Enabled = true;
            timer2.Interval = 1000*60;
            timer2.Enabled = true;
        }

        //2. 읽어온 DCS데이터 DB에 insert
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

        public OracleConnection m_Conn_DS = null;
        public OracleCommand m_Cmd_DS = null;
        public OracleDataReader m_Rdr_DS;

        //insert문 작성
        public string m_CmdTextDS;
        //DB 접속정보
        public string m_strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.10.2)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));User Id=YY_PSH;Password=Yangyang1234!@;pooling=false;";

        public void QueryConnDS()
        {
            try
            {
                //listBox2.Items.Add("QUERYConnDA..st");
                //bool viewPos = true;

                //listBox2.Items.Add(a2);

                m_CmdTextDS = @"insert into DL_BIG_ORIGIN values(CONCAT('DBO_', TO_CHAR(SYSDATE, 'YYYYMMDDHH24MISS')), TO_CHAR(SYSDATE, 'YYYYMMDDHH24MISS')" + ", '"
                    + a2  + "', '" + a3  + "', '" + a4  + "', '"
                    + a5  + "', '" + a6  + "', '" + a7  + "', '" 
                    + a8  + "', '" + a9  + "', '" + a10 + "')";
                /*
                m_CmdTextDS = @"UPDATE RT_DCS SET YY_LOG_DATE = TO_CHAR(SYSDATE, 'YYYYMMDDHH24MISS'), " 
                                + "YY_99KSC_GIS_BUS1_FREQ = '" + a2 +
                                "', YY_01GTA_001UM_05AR33 = '" + a3 +
                                "', YY_01GTA_GEN_ST = '" + a4 +
                                "', YY_01GTA_PUMP_ST = '" + a5 +
                                "', YY_01GTA_MAINT_027IP = '" + a6 +
                                "', YY_01GTA_006JS_021DI = '" + a7 +
                                "', YY_01GTA_007JS_021DI = '" + a8 +
                                "', YY_01GRE_100VG_08AI = '" + a9 +
                                "', YY_01GTA_001JD_160DI = '" + a10 +
                                "', YY_01GTA_001JD_021DI = '" + a11 +
                                "', YY_02GTA_001UM_05AR33 = '" + a12 +
                                "', YY_02GTA_GEN_ST = '" + a13 +
                                "', YY_02GTA_PUMP_ST = '" + a14 +
                                "', YY_02GTA_MAINT_027IP = '" + a15 +
                                "', YY_02GTA_006JS_021DI = '" + a16 +
                                "', YY_02GTA_007JS_021DI = '" + a17 +
                                "', YY_02GRE_100VG_08AI = '" + a18 +
                                "', YY_02GTA_001JD_160DI = '" + a19 +
                                "', YY_02GTA_001JD_021DI = '" + a20 +
                                "', YY_03GTA_001UM_05AR33 = '" + a21 +
                                "', YY_03GTA_GEN_ST = '" + a22 +
                                "', YY_03GTA_PUMP_ST = '" + a23 +
                                "', YY_03GTA_MAINT_027IP = '" + a24 +
                                "', YY_03GTA_006JS_021DI = '" + a25 +
                                "', YY_03GTA_007JS_021DI = '" + a26 +
                                "', YY_03GRE_100VG_08AI = '" + a27 +
                                "', YY_03GTA_001JD_160DI = '" + a28 +
                                "', YY_03GTA_001JD_021DI = '" + a29 +
                                "', YY_04GTA_001UM_05AR33 = '" + a30 +
                                "', YY_04GTA_GEN_ST = '" + a31 +
                                "', YY_04GTA_PUMP_ST = '" + a32 +
                                "', YY_04GTA_MAINT_027IP = '" + a33 +
                                "', YY_04GTA_006JS_021DI = '" + a34 +
                                "', YY_04GTA_007JS_021DI = '" + a35 +
                                "', YY_04GRE_100VG_08AI = '" + a36 +
                                "', YY_04GTA_001JD_160DI = '" + a37 +
                                "', YY_04GTA_001JD_021DI = '" + a38 + 
                                "' WHERE ROWNUM = 1";
                */

                m_Cmd_DS.CommandText = m_CmdTextDS;

                int ret = m_Cmd_DS.ExecuteNonQuery();
                //listBox2.Items.Add("insert ret = " + ret);

                //OracleDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                /*
                if (m_Rdr_DS == null) { return; }
                else
                {
                    listBox2.Items.Clear();
                    while (m_Rdr_DS.Read())
                    {
                        for (int i = 0; i < m_Rdr_DS.FieldCount; i++)
                        {
                            listBox2.Items.Add(m_Rdr_DS[i].ToString());
                        }
                    }
                }
                */
            }
            catch (OracleException ex)
            {
                listBox2.Items.Add(ex.Message);
                //Console.WriteLine("Custom Check : QueryConnMain() : " + ex.Message);
            }
        }

        //DCS데이터 읽어오기
        private void timer1_tick(object sender, EventArgs e)
        {
            btnRData_Click(sender, e);
        }

        //읽어온 DCS데이터 DB insert
        private void timer2_tick(object sender, EventArgs e)
        {
            //if (listBox1.Items.Count < 37) return;
            
            //getValue();


            QueryConnDS();
        }
    }
}
