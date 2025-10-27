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
            string[] opcTag = {"MCR.01GTA_001JD_160DI", "MCR.01GTA_001JD_021DI", "MCR.02GTA_001JD_160DI", "MCR.02GTA_001JD_021DI",
                                "MCR.03GTA_001JD_160DI", "MCR.03GTA_001JD_021DI", "MCR.04GTA_001JD_160DI", "MCR.04GTA_001JD_021DI",
                                "MCR.01GTA_005JS_160DI", "MCR.01GTA_005JS_021DI", "MCR.02GTA_005JS_160DI", "MCR.02GTA_005JS_021DI",
                                "MCR.03GTA_005JS_160DI", "MCR.03GTA_005JS_021DI", "MCR.04GTA_005JS_160DI", "MCR.04GTA_005JS_021DI",
                                "MCR.11GTA_001JD_160DI", "MCR.11GTA_001JD_021DI", "MCR.12GTA_001JD_160DI", "MCR.12GTA_001JD_021DI",
                                "MCR.20LGA_1SW01B_160DI", "MCR.20LGA_1SW01B_021DI", "MCR.20LGA_2SW01B_160DI", "MCR.20LGA_2SW01B_021DI",
                                "MCR.01GTA_006JS_021DI", "MCR.02GTA_006JS_021DI", "MCR.03GTA_006JS_021DI", "MCR.04GTA_006JS_021DI",
                                "MCR.01GTA_007JS_021DI", "MCR.02GTA_007JS_021DI", "MCR.03GTA_007JS_021DI", "MCR.04GTA_007JS_021DI",
                                "MCR.01GTA_004JS_160DI", "MCR.01GTA_004JS_021DI", "MCR.02GTA_004JS_160DI", "MCR.02GTA_004JS_021DI",
                                "MCR.03GTA_004JS_160DI", "MCR.03GTA_004JS_021DI", "MCR.04GTA_004JS_160DI", "MCR.04GTA_004JS_021DI",
                                "MCR.01GTA_003JS_160DI", "MCR.01GTA_003JS_021DI", "MCR.02GTA_003JS_160DI", "MCR.02GTA_003JS_021DI",
                                "MCR.03GTA_003JS_160DI", "MCR.03GTA_003JS_021DI", "MCR.04GTA_003JS_160DI", "MCR.04GTA_003JS_021DI",
                                "MCR.01GTA_002JS_160DI", "MCR.01GTA_002JS_021DI", "MCR.02GTA_002JS_160DI", "MCR.02GTA_002JS_021DI",
                                "MCR.03GTA_002JS_160DI", "MCR.03GTA_002JS_021DI", "MCR.04GTA_002JS_160DI", "MCR.04GTA_002JS_021DI",
                                "MCR.20GTA_001JD_160DI", "MCR.20GTA_001JD_021DI", "MCR.20SFC_002JD_160DI", "MCR.20SFC_002JD_021DI",
                                "MCR.11GTA_001JS_160DI", "MCR.11GTA_001JS_021DI", "MCR.12GTA_001JS_160DI", "MCR.12GTA_001JS_021DI"};

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
        public string a11 = "";
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
        public string a39 = "";
        public string a40 = "";
        public string a41 = "";
        public string a42 = "";
        public string a43 = "";
        public string a44 = "";
        public string a45 = "";
        public string a46 = "";
        public string a47 = "";
        public string a48 = "";
        public string a49 = "";
        public string a50 = "";
        public string a51 = "";
        public string a52 = "";
        public string a53 = "";
        public string a54 = "";
        public string a55 = "";
        public string a56 = "";
        public string a57 = "";
        public string a58 = "";
        public string a59 = "";
        public string a60 = "";
        public string a61 = "";
        public string a62 = "";
        public string a63 = "";
        public string a64 = "";
        public string a65 = "";

        public void getValue()
        {
            //listBox2.Items.Add("#########" + listBox1.Items.Count);

            a2 = listBox1.Items[0].ToString();
            if (a2.Equals("True")) { a2 = "1"; }
            if (a2.Equals("False")) { a2 = "0"; }

            a3 = listBox1.Items[1].ToString();
            if (a3.Equals("True")) { a3 = "1"; }
            if (a3.Equals("False")) { a3 = "0"; }

            a4 = listBox1.Items[2].ToString();
            if (a4.Equals("True")) { a4 = "1"; }
            if (a4.Equals("False")) { a4 = "0"; }

            a5 = listBox1.Items[3].ToString();
            if (a5.Equals("True")) { a5 = "1"; }
            if (a5.Equals("False")) { a5 = "0"; }

            a6 = listBox1.Items[4].ToString();
            if (a6.Equals("True")) { a6 = "1"; }
            if (a6.Equals("False")) { a6 = "0"; }

            a7 = listBox1.Items[5].ToString();
            if (a7.Equals("True")) { a7 = "1"; }
            if (a7.Equals("False")) { a7 = "0"; }

            a8 = listBox1.Items[6].ToString();
            if (a8.Equals("True")) { a8 = "1"; }
            if (a8.Equals("False")) { a8 = "0"; }

            a9 = listBox1.Items[7].ToString();
            if (a9.Equals("True")) { a9 = "1"; }
            if (a9.Equals("False")) { a9 = "0"; }

            a10 = listBox1.Items[8].ToString();
            if (a10.Equals("True")) { a10 = "1"; }
            if (a10.Equals("False")) { a10 = "0"; }

            a11 = listBox1.Items[9].ToString();
            if (a11.Equals("True")) { a11 = "1"; }
            if (a11.Equals("False")) { a11 = "0"; }

            a12 = listBox1.Items[10].ToString();
            if (a12.Equals("True")) { a12 = "1"; }
            if (a12.Equals("False")) { a12 = "0"; }

            a13 = listBox1.Items[11].ToString();
            if (a13.Equals("True")) { a13 = "1"; }
            if (a13.Equals("False")) { a13 = "0"; }

            a14 = listBox1.Items[12].ToString();
            if (a14.Equals("True")) { a14 = "1"; }
            if (a14.Equals("False")) { a14 = "0"; }

            a15 = listBox1.Items[13].ToString();
            if (a15.Equals("True")) { a15 = "1"; }
            if (a15.Equals("False")) { a15 = "0"; }

            a16 = listBox1.Items[14].ToString();
            if (a16.Equals("True")) { a16 = "1"; }
            if (a16.Equals("False")) { a16 = "0"; }

            a17 = listBox1.Items[15].ToString();
            if (a17.Equals("True")) { a17 = "1"; }
            if (a17.Equals("False")) { a17 = "0"; }

            a18 = listBox1.Items[16].ToString();
            if (a18.Equals("True")) { a18 = "1"; }
            if (a18.Equals("False")) { a18 = "0"; }

            a19 = listBox1.Items[17].ToString();
            if (a19.Equals("True")) { a19 = "1"; }
            if (a19.Equals("False")) { a19 = "0"; }

            a20 = listBox1.Items[18].ToString();
            if (a20.Equals("True")) { a20 = "1"; }
            if (a20.Equals("False")) { a20 = "0"; }

            a21 = listBox1.Items[19].ToString();
            if (a21.Equals("True")) {  a21 = "1"; }
            if (a21.Equals("False")) { a21 = "0"; }

            a22 = listBox1.Items[20].ToString();
            if (a22.Equals("True")) { a22 = "1"; }
            if (a22.Equals("False")) { a22 = "0"; }

            a23 = listBox1.Items[21].ToString();
            if (a23.Equals("True")) { a23 = "1"; }
            if (a23.Equals("False")) { a23 = "0"; }

            a24 = listBox1.Items[22].ToString();
            if (a24.Equals("True")) { a24 = "1"; }
            if (a24.Equals("False")) { a24 = "0"; }

            a25 = listBox1.Items[23].ToString();
            if (a25.Equals("True")) { a25 = "1"; }
            if (a25.Equals("False")) { a25 = "0"; }

            a26 = listBox1.Items[24].ToString();
            if (a26.Equals("True")) { a26 = "1"; }
            if (a26.Equals("False")) { a26 = "0"; }

            a27 = listBox1.Items[25].ToString();
            if (a27.Equals("True")) { a27 = "1"; }
            if (a27.Equals("False")) { a27 = "0"; }

            a28 = listBox1.Items[26].ToString();
            if (a28.Equals("True")) { a28 = "1"; }
            if (a28.Equals("False")) { a28 = "0"; }

            a29 = listBox1.Items[27].ToString();
            if (a29.Equals("True")) { a29 = "1"; }
            if (a29.Equals("False")) { a29 = "0"; }

            a30 = listBox1.Items[28].ToString();
            if (a30.Equals("True")) { a30 = "1"; }
            if (a30.Equals("False")) { a30 = "0"; }

            a31 = listBox1.Items[29].ToString();
            if (a31.Equals("True")) { a31 = "1"; }
            if (a31.Equals("False")) { a31 = "0"; }

            a32 = listBox1.Items[30].ToString();
            if (a32.Equals("True")) { a32 = "1"; }
            if (a32.Equals("False")) { a32 = "0"; }

            a33 = listBox1.Items[31].ToString();
            if (a33.Equals("True")) { a33 = "1"; }
            if (a33.Equals("False")) { a33 = "0"; }

            a34 = listBox1.Items[32].ToString();
            if (a34.Equals("True")) { a34 = "1"; }
            if (a34.Equals("False")) { a34 = "0"; }

            a35 = listBox1.Items[33].ToString();
            if (a35.Equals("True")) { a35 = "1"; }
            if (a35.Equals("False")) { a35 = "0"; }

            a36 = listBox1.Items[34].ToString();
            if (a36.Equals("True")) { a36 = "1"; }
            if (a36.Equals("False")) { a36 = "0"; }

            a37 = listBox1.Items[35].ToString();
            if (a37.Equals("True")) { a37 = "1"; }
            if (a37.Equals("False")) { a37 = "0"; }

            a38 = listBox1.Items[36].ToString();
            if (a38.Equals("True")) { a38 = "1"; }
            if (a38.Equals("False")) { a38 = "0"; }

            a39 = listBox1.Items[37].ToString();
            if (a39.Equals("True")) { a39 = "1"; }
            if (a39.Equals("False")) { a39 = "0"; }

            a40 = listBox1.Items[38].ToString();
            if (a40.Equals("True")) { a40 = "1"; }
            if (a40.Equals("False")) { a40 = "0"; }

            a41 = listBox1.Items[39].ToString();
            if (a41.Equals("True")) { a41 = "1"; }
            if (a41.Equals("False")) { a41 = "0"; }

            a42 = listBox1.Items[40].ToString();
            if (a42.Equals("True")) { a42 = "1"; }
            if (a42.Equals("False")) { a42 = "0"; }

            a43 = listBox1.Items[41].ToString();
            if (a43.Equals("True")) { a43 = "1"; }
            if (a43.Equals("False")) { a43 = "0"; }

            a44 = listBox1.Items[42].ToString();
            if (a44.Equals("True")) { a44 = "1"; }
            if (a44.Equals("False")) { a44 = "0"; }

            a45 = listBox1.Items[43].ToString();
            if (a45.Equals("True")) { a45 = "1"; }
            if (a45.Equals("False")) { a45 = "0"; }

            a46 = listBox1.Items[44].ToString();
            if (a46.Equals("True")) { a46 = "1"; }
            if (a46.Equals("False")) { a46 = "0"; }

            a47 = listBox1.Items[45].ToString();
            if (a47.Equals("True")) { a47 = "1"; }
            if (a47.Equals("False")) { a47 = "0"; }

            a48 = listBox1.Items[46].ToString();
            if (a48.Equals("True")) { a48 = "1"; }
            if (a48.Equals("False")) { a48 = "0"; }

            a49 = listBox1.Items[47].ToString();
            if (a49.Equals("True")) { a49 = "1"; }
            if (a49.Equals("False")) { a49 = "0"; }

            a50 = listBox1.Items[48].ToString();
            if (a50.Equals("True")) { a50 = "1"; }
            if (a50.Equals("False")) { a50 = "0"; }

            a51 = listBox1.Items[49].ToString();
            if (a51.Equals("True")) { a51 = "1"; }
            if (a51.Equals("False")) { a51 = "0"; }

            a52 = listBox1.Items[50].ToString();
            if (a52.Equals("True")) { a52 = "1"; }
            if (a52.Equals("False")) { a52 = "0"; }

            a53 = listBox1.Items[51].ToString();
            if (a53.Equals("True")) { a53 = "1"; }
            if (a53.Equals("False")) { a53 = "0"; }

            a54 = listBox1.Items[52].ToString();
            if (a54.Equals("True")) { a54 = "1"; }
            if (a54.Equals("False")) { a54 = "0"; }

            a55 = listBox1.Items[53].ToString();
            if (a55.Equals("True")) { a55 = "1"; }
            if (a55.Equals("False")) { a55 = "0"; }

            a56 = listBox1.Items[54].ToString();
            if (a56.Equals("True")) { a56 = "1"; }
            if (a56.Equals("False")) { a56 = "0"; }

            a57 = listBox1.Items[55].ToString();
            if (a57.Equals("True")) { a57 = "1"; }
            if (a57.Equals("False")) { a57 = "0"; }

            a58 = listBox1.Items[56].ToString();
            if (a58.Equals("True")) { a58 = "1"; }
            if (a58.Equals("False")) { a58 = "0"; }

            a59 = listBox1.Items[57].ToString();
            if (a59.Equals("True")) { a59 = "1"; }
            if (a59.Equals("False")) { a59 = "0"; }

            a60 = listBox1.Items[58].ToString();
            if (a60.Equals("True")) { a60 = "1"; }
            if (a60.Equals("False")) { a60 = "0"; }

            a61 = listBox1.Items[59].ToString();
            if (a61.Equals("True")) { a61 = "1"; }
            if (a61.Equals("False")) { a61 = "0"; }

            a62 = listBox1.Items[60].ToString();
            if (a62.Equals("True")) { a62 = "1"; }
            if (a62.Equals("False")) { a62 = "0"; }

            a63 = listBox1.Items[61].ToString();
            if (a63.Equals("True")) { a63 = "1"; }
            if (a63.Equals("False")) { a63 = "0"; }

            a64 = listBox1.Items[62].ToString();
            if (a64.Equals("True")) { a64 = "1"; }
            if (a64.Equals("False")) { a64 = "0"; }

            a65 = listBox1.Items[63].ToString();
            if (a65.Equals("True")) { a65 = "1"; }
            if (a65.Equals("False")) { a65 = "0"; }
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
            timer2.Interval = 1000;
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

                /*
                m_CmdTextDS = @"insert into RT_DCS values(" + "TO_CHAR(SYSDATE, 'YYYYMMDDHH24MISS')" + ", '"
                    + a2  + "', '" + a3  + "', '" + a4  + "', '"
                    + a5  + "', '" + a6  + "', '" + a7  + "', '" + a8  + "', '" + a9  + "', '" + a10 + "', '"
                    + a11 + "', '" + a12 + "', '" + a13 + "', '" + a14 + "', '" + a15 + "', '"
                    + a16 + "', '" + a17 + "', '" + a18 + "', '" + a19 + "', '" + a20 + "', '" + a21 + "', '"
                    + a22 + "', '" + a23 + "', '" + a24 + "', '" + a25 + "', '" + a26 + "', '" + a27 + "', '"
                    + a28 + "', '" + a29 + "', '" + a30 + "', '" + a31 + "', '" + a32 + "', '" + a33 + "', '"
                    + a34 + "', '" + a35 + "', '" + a36 + "', '" + a37 + "', '" + a38 + "')";
                */

                m_CmdTextDS = @"UPDATE CB_18KV SET YY_LOG_DATE = TO_CHAR(SYSDATE, 'YYYYMMDDHH24MISS'), "
                                + "YY_01GTA_001JD_160DI = '" + a2 +
                                "', YY_01GTA_001JD_021DI = '" + a3 +
                                "', YY_02GTA_001JD_160DI = '" + a4 +
                                "', YY_02GTA_001JD_021DI = '" + a5 +
                                "', YY_03GTA_001JD_160DI = '" + a6 +
                                "', YY_03GTA_001JD_021DI = '" + a7 +
                                "', YY_04GTA_001JD_160DI = '" + a8 +
                                "', YY_04GTA_001JD_021DI = '" + a9 +
                                "', YY_01GTA_005JS_160DI = '" + a10 +
                                "', YY_01GTA_005JS_021DI = '" + a11 +
                                "', YY_02GTA_005JS_160DI = '" + a12 +
                                "', YY_02GTA_005JS_021DI = '" + a13 +
                                "', YY_03GTA_005JS_160DI = '" + a14 +
                                "', YY_03GTA_005JS_021DI = '" + a15 +
                                "', YY_04GTA_005JS_160DI = '" + a16 +
                                "', YY_04GTA_005JS_021DI = '" + a17 +
                                "', YY_11GTA_001JD_160DI = '" + a18 +
                                "', YY_11GTA_001JD_021DI = '" + a19 +
                                "', YY_12GTA_001JD_160DI = '" + a20 +
                                "', YY_12GTA_001JD_021DI = '" + a21 +
                                "', YY_20LGA_1SW01B_160DI = '" + a22 +
                                "', YY_20LGA_1SW01B_021DI = '" + a23 +
                                "', YY_20LGA_2SW01B_160DI = '" + a24 +
                                "', YY_20LGA_2SW01B_021DI = '" + a25 +
                                "', YY_01GTA_006JS_021DI = '" + a26 +
                                "', YY_02GTA_006JS_021DI = '" + a27 +
                                "', YY_03GTA_006JS_021DI = '" + a28 +
                                "', YY_04GTA_006JS_021DI = '" + a29 +
                                "', YY_01GTA_007JS_021DI = '" + a30 +
                                "', YY_02GTA_007JS_021DI = '" + a31 +
                                "', YY_03GTA_007JS_021DI = '" + a32 +
                                "', YY_04GTA_007JS_021DI = '" + a33 +
                                "', YY_01GTA_004JS_160DI = '" + a34 +
                                "', YY_01GTA_004JS_021DI = '" + a35 +
                                "', YY_02GTA_004JS_160DI = '" + a36 +
                                "', YY_02GTA_004JS_021DI = '" + a37 +
                                "', YY_03GTA_004JS_160DI = '" + a38 +
                                "', YY_03GTA_004JS_021DI = '" + a39 +
                                "', YY_04GTA_004JS_160DI = '" + a40 +
                                "', YY_04GTA_004JS_021DI = '" + a41 +
                                "', YY_01GTA_003JS_160DI = '" + a42 +
                                "', YY_01GTA_003JS_021DI = '" + a43 +
                                "', YY_02GTA_003JS_160DI = '" + a44 +
                                "', YY_02GTA_003JS_021DI = '" + a45 +
                                "', YY_03GTA_003JS_160DI = '" + a46 +
                                "', YY_03GTA_003JS_021DI = '" + a47 +
                                "', YY_04GTA_003JS_160DI = '" + a48 +
                                "', YY_04GTA_003JS_021DI = '" + a49 +
                                "', YY_01GTA_002JS_160DI = '" + a50 +
                                "', YY_01GTA_002JS_021DI = '" + a51 +
                                "', YY_02GTA_002JS_160DI = '" + a52 +
                                "', YY_02GTA_002JS_021DI = '" + a53 +
                                "', YY_03GTA_002JS_160DI = '" + a54 +
                                "', YY_03GTA_002JS_021DI = '" + a55 +
                                "', YY_04GTA_002JS_160DI = '" + a56 +
                                "', YY_04GTA_002JS_021DI = '" + a57 +
                                "', YY_20GTA_001JD_160DI = '" + a58 +
                                "', YY_20GTA_001JD_021DI = '" + a59 +
                                "', YY_20SFC_002JD_160DI = '" + a60 +
                                "', YY_20SFC_002JD_021DI = '" + a61 +
                                "', YY_11GTA_001JS_160DI = '" + a62 +
                                "', YY_11GTA_001JS_021DI = '" + a63 +
                                "', YY_12GTA_001JS_160DI = '" + a64 +
                                "', YY_12GTA_001JS_021DI = '" + a65 + 
                                "' WHERE ROWNUM = 1";
                

                m_Cmd_DS.CommandText = m_CmdTextDS;

                int ret = m_Cmd_DS.ExecuteNonQuery();
                //listBox2.Items.Add("$$$$$$$$$");

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
            
            QueryConnDS();
        }
    }
}
