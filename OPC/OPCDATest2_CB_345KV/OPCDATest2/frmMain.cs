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
            string[] opcTag = {"MCR.61LRL_002JS_160DI", "MCR.61LRL_002JS_021DI", "MCR.61LRL_012JS_160DI", "MCR.61LRL_012JS_021DI",
                                "MCR.61LRL_001JD_160DI", "MCR.61LRL_001JD_021DI", "MCR.61LRL_011JS_160DI", "MCR.61LRL_011JS_021DI",
                                "MCR.61LRL_001JS_160DI", "MCR.61LRL_001JS_021DI", "MCR.61LRL_013JS_160DI", "MCR.61LRL_013JS_021DI",
                                "MCR.61LRL_003JS_160DI", "MCR.61LRL_003JS_021DI", "MCR.61LRL_010JS_160DI", "MCR.61LRL_010JS_021DI",
                                "MCR.60LRC_001JS_160DI", "MCR.60LRC_001JS_021DI", "MCR.60LRC_011JS_160DI", "MCR.60LRC_011JS_021DI",
                                "MCR.60LRC_001JD_160DI", "MCR.60LRC_001JD_021DI", "MCR.60LRC_012JS_160DI", "MCR.60LRC_012JS_021DI",
                                "MCR.60LRC_002JS_160DI", "MCR.60LRC_002JS_021DI", "MCR.61LRT_003JS_160DI", "MCR.61LRT_003JS_021DI",
                                "MCR.61LRT_010JS_160DI", "MCR.61LRT_010JS_021DI", "MCR.61LRT_013JS_160DI", "MCR.61LRT_013JS_021DI",
                                "MCR.61LRT_001JS_160DI", "MCR.61LRT_001JS_021DI", "MCR.61LRT_011JS_160DI", "MCR.61LRT_011JS_021DI",
                                "MCR.61LRT_001JD_160DI", "MCR.61LRT_001JD_021DI", "MCR.61LRT_012JS_160DI", "MCR.61LRT_012JS_021DI",
                                "MCR.61LRT_002JS_160DI", "MCR.61LRT_002JS_021DI", "MCR.60LRC_021JS_160DI", "MCR.60LRC_021JS_021DI",
                                "MCR.60LRC_022JS_160DI", "MCR.60LRC_022JS_021DI", "MCR.62LRT_002JS_160DI", "MCR.62LRT_002JS_021DI",
                                "MCR.62LRT_012JS_160DI", "MCR.62LRT_012JS_021DI", "MCR.62LRT_001JD_160DI", "MCR.62LRT_001JD_021DI",
                                "MCR.62LRT_011JS_160DI", "MCR.62LRT_011JS_021DI", "MCR.62LRT_001JS_160DI", "MCR.62LRT_001JS_021DI",
                                "MCR.62LRT_013JS_160DI", "MCR.62LRT_013JS_021DI", "MCR.62LRT_003JS_160DI", "MCR.62LRT_003JS_021DI",
                                "MCR.62LRT_010JS_160DI", "MCR.62LRT_010JS_021DI", "MCR.60LRC_003JS_160DI", "MCR.60LRC_003JS_021DI",
                                "MCR.60LRC_013JS_160DI", "MCR.60LRC_013JS_021DI", "MCR.60LRC_002JD_160DI", "MCR.60LRC_002JD_021DI",
                                "MCR.60LRC_014JS_160DI", "MCR.60LRC_014JS_021DI", "MCR.60LRC_004JS_160DI", "MCR.60LRC_004JS_021DI",
                                "MCR.63LRT_013JS_160DI", "MCR.63LRT_013JS_021DI", "MCR.63LRT_003JS_160DI", "MCR.63LRT_003JS_021DI",
                                "MCR.63LRT_001JS_160DI", "MCR.63LRT_001JS_021DI", "MCR.63LRT_011JS_160DI", "MCR.63LRT_011JS_021DI",
                                "MCR.63LRT_001JD_160DI", "MCR.63LRT_001JD_021DI", "MCR.63LRT_012JS_160DI", "MCR.63LRT_012JS_021DI",
                                "MCR.63LRT_002JS_160DI", "MCR.63LRT_002JS_021DI", "MCR.63LRT_010JS_160DI", "MCR.63LRT_010JS_021DI",
                                "MCR.62LRL_002JS_160DI", "MCR.62LRL_002JS_021DI", "MCR.62LRL_012JS_160DI", "MCR.62LRL_012JS_021DI",
                                "MCR.62LRL_001JD_160DI", "MCR.62LRL_001JD_021DI", "MCR.62LRL_011JS_160DI", "MCR.62LRL_011JS_021DI",
                                "MCR.62LRL_001JS_160DI", "MCR.62LRL_001JS_021DI", "MCR.62LRL_013JS_160DI", "MCR.62LRL_013JS_021DI",
                                "MCR.62LRL_003JS_160DI", "MCR.62LRL_003JS_021DI", "MCR.62LRL_010JS_160DI", "MCR.62LRL_010JS_021DI",
                                "MCR.60LRC_005JS_160DI", "MCR.60LRC_005JS_021DI", "MCR.60LRC_015JS_160DI", "MCR.60LRC_015JS_021DI",
                                "MCR.60LRC_003JD_160DI", "MCR.60LRC_003JD_021DI", "MCR.60LRC_016JS_160DI", "MCR.60LRC_016JS_021DI",
                                "MCR.60LRC_006JS_160DI", "MCR.60LRC_006JS_021DI", "MCR.64LRT_013JS_160DI", "MCR.64LRT_013JS_021DI",
                                "MCR.64LRT_003JS_160DI", "MCR.64LRT_003JS_021DI", "MCR.64LRT_010JS_160DI", "MCR.64LRT_010JS_021DI",
                                "MCR.64LRT_001JS_160DI", "MCR.64LRT_001JS_021DI", "MCR.64LRT_011JS_160DI", "MCR.64LRT_011JS_021DI",
                                "MCR.64LRT_001JD_160DI", "MCR.64LRT_001JD_021DI", "MCR.64LRT_012JS_160DI", "MCR.64LRT_012JS_021DI",
                                "MCR.64LRT_002JS_160DI", "MCR.64LRT_002JS_021DI"};

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
        public string a66 = "";
        public string a67 = "";
        public string a68 = "";
        public string a69 = "";
        public string a70 = "";
        public string a71 = "";
        public string a72 = "";
        public string a73 = "";
        public string a74 = "";
        public string a75 = "";
        public string a76 = "";
        public string a77 = "";
        public string a78 = "";
        public string a79 = "";
        public string a80 = "";
        public string a81 = "";
        public string a82 = "";
        public string a83 = "";
        public string a84 = "";
        public string a85 = "";
        public string a86 = "";
        public string a87 = "";
        public string a88 = "";
        public string a89 = "";
        public string a90 = "";
        public string a91 = "";
        public string a92 = "";
        public string a93 = "";
        public string a94 = "";
        public string a95 = "";
        public string a96 = "";
        public string a97 = "";
        public string a98 = "";
        public string a99 = "";
        public string a100 = "";
        public string a101 = "";
        public string a102 = "";
        public string a103 = "";
        public string a104 = "";
        public string a105 = "";
        public string a106 = "";
        public string a107 = "";
        public string a108 = "";
        public string a109 = "";
        public string a110 = "";
        public string a111 = "";
        public string a112 = "";
        public string a113 = "";
        public string a114 = "";
        public string a115 = "";
        public string a116 = "";
        public string a117 = "";
        public string a118 = "";
        public string a119 = "";
        public string a120 = "";
        public string a121 = "";
        public string a122 = "";
        public string a123 = "";
        public string a124 = "";
        public string a125 = "";
        public string a126 = "";
        public string a127 = "";
        public string a128 = "";
        public string a129 = "";
        public string a130 = "";
        public string a131 = "";

        public void getValue()
        {
            //listBox2.Items.Add("#########" + listBox1.Items.Count);

            a2 = listBox1.Items[0].ToString();
            if (a2.Equals("True")) {  a2 = "1"; }
            if (a2.Equals("False")) { a2 = "0"; }

            a3 = listBox1.Items[1].ToString();
            if (a3.Equals("True")) {  a3 = "1"; }
            if (a3.Equals("False")) { a3 = "0"; }

            a4 = listBox1.Items[2].ToString();
            if (a4.Equals("True")) {  a4 = "1"; }
            if (a4.Equals("False")) { a4 = "0"; }

            a5 = listBox1.Items[3].ToString();
            if (a5.Equals("True")) {  a5 = "1"; }
            if (a5.Equals("False")) { a5 = "0"; }

            a6 = listBox1.Items[4].ToString();
            if (a6.Equals("True")) {  a6 = "1"; }
            if (a6.Equals("False")) { a6 = "0"; }

            a7 = listBox1.Items[5].ToString();
            if (a7.Equals("True")) {  a7 = "1"; }
            if (a7.Equals("False")) { a7 = "0"; }

            a8 = listBox1.Items[6].ToString();
            if (a8.Equals("True")) {  a8 = "1"; }
            if (a8.Equals("False")) { a8 = "0"; }

            a9 = listBox1.Items[7].ToString();
            if (a9.Equals("True")) {  a9 = "1"; }
            if (a9.Equals("False")) { a9 = "0"; }

            a10 = listBox1.Items[8].ToString();
            if (a10.Equals("True")) {  a10 = "1"; }
            if (a10.Equals("False")) { a10 = "0"; }

            a11 = listBox1.Items[9].ToString();
            if (a11.Equals("True")) {  a11 = "1"; }
            if (a11.Equals("False")) { a11 = "0"; }

            a12 = listBox1.Items[10].ToString();
            if (a12.Equals("True")) {  a12 = "1"; }
            if (a12.Equals("False")) { a12 = "0"; }

            a13 = listBox1.Items[11].ToString();
            if (a13.Equals("True")) {  a13 = "1"; }
            if (a13.Equals("False")) { a13 = "0"; }

            a14 = listBox1.Items[12].ToString();
            if (a14.Equals("True")) {  a14 = "1"; }
            if (a14.Equals("False")) { a14 = "0"; }

            a15 = listBox1.Items[13].ToString();
            if (a15.Equals("True")) {  a15 = "1"; }
            if (a15.Equals("False")) { a15 = "0"; }

            a16 = listBox1.Items[14].ToString();
            if (a16.Equals("True")) {  a16 = "1"; }
            if (a16.Equals("False")) { a16 = "0"; }

            a17 = listBox1.Items[15].ToString();
            if (a17.Equals("True")) {  a17 = "1"; }
            if (a17.Equals("False")) { a17 = "0"; }

            a18 = listBox1.Items[16].ToString();
            if (a18.Equals("True")) {  a18 = "1"; }
            if (a18.Equals("False")) { a18 = "0"; }

            a19 = listBox1.Items[17].ToString();
            if (a19.Equals("True")) {  a19 = "1"; }
            if (a19.Equals("False")) { a19 = "0"; }

            a20 = listBox1.Items[18].ToString();
            if (a20.Equals("True")) {  a20 = "1"; }
            if (a20.Equals("False")) { a20 = "0"; }

            a21 = listBox1.Items[19].ToString();
            if (a21.Equals("True")) {  a21 = "1"; }
            if (a21.Equals("False")) { a21 = "0"; }

            a22 = listBox1.Items[20].ToString();
            if (a22.Equals("True")) {  a22 = "1"; }
            if (a22.Equals("False")) { a22 = "0"; }

            a23 = listBox1.Items[21].ToString();
            if (a23.Equals("True")) {  a23 = "1"; }
            if (a23.Equals("False")) { a23 = "0"; }

            a24 = listBox1.Items[22].ToString();
            if (a24.Equals("True")) {  a24 = "1"; }
            if (a24.Equals("False")) { a24 = "0"; }

            a25 = listBox1.Items[23].ToString();
            if (a25.Equals("True")) {  a25 = "1"; }
            if (a25.Equals("False")) { a25 = "0"; }

            a26 = listBox1.Items[24].ToString();
            if (a26.Equals("True")) {  a26 = "1"; }
            if (a26.Equals("False")) { a26 = "0"; }

            a27 = listBox1.Items[25].ToString();
            if (a27.Equals("True")) {  a27 = "1"; }
            if (a27.Equals("False")) { a27 = "0"; }

            a28 = listBox1.Items[26].ToString();
            if (a28.Equals("True")) {  a28 = "1"; }
            if (a28.Equals("False")) { a28 = "0"; }

            a29 = listBox1.Items[27].ToString();
            if (a29.Equals("True")) {  a29 = "1"; }
            if (a29.Equals("False")) { a29 = "0"; }

            a30 = listBox1.Items[28].ToString();
            if (a30.Equals("True")) {  a30 = "1"; }
            if (a30.Equals("False")) { a30 = "0"; }

            a31 = listBox1.Items[29].ToString();
            if (a31.Equals("True")) {  a31 = "1"; }
            if (a31.Equals("False")) { a31 = "0"; }

            a32 = listBox1.Items[30].ToString();
            if (a32.Equals("True")) {  a32 = "1"; }
            if (a32.Equals("False")) { a32 = "0"; }

            a33 = listBox1.Items[31].ToString();
            if (a33.Equals("True")) {  a33 = "1"; }
            if (a33.Equals("False")) { a33 = "0"; }

            a34 = listBox1.Items[32].ToString();
            if (a34.Equals("True")) {  a34 = "1"; }
            if (a34.Equals("False")) { a34 = "0"; }

            a35 = listBox1.Items[33].ToString();
            if (a35.Equals("True")) {  a35 = "1"; }
            if (a35.Equals("False")) { a35 = "0"; }

            a36 = listBox1.Items[34].ToString();
            if (a36.Equals("True")) {  a36 = "1"; }
            if (a36.Equals("False")) { a36 = "0"; }

            a37 = listBox1.Items[35].ToString();
            if (a37.Equals("True")) {  a37 = "1"; }
            if (a37.Equals("False")) { a37 = "0"; }

            a38 = listBox1.Items[36].ToString();
            if (a38.Equals("True")) {  a38 = "1"; }
            if (a38.Equals("False")) { a38 = "0"; }

            a39 = listBox1.Items[37].ToString();
            if (a39.Equals("True")) {  a39 = "1"; }
            if (a39.Equals("False")) { a39 = "0"; }

            a40 = listBox1.Items[38].ToString();
            if (a40.Equals("True")) {  a40 = "1"; }
            if (a40.Equals("False")) { a40 = "0"; }

            a41 = listBox1.Items[39].ToString();
            if (a41.Equals("True")) {  a41 = "1"; }
            if (a41.Equals("False")) { a41 = "0"; }

            a42 = listBox1.Items[40].ToString();
            if (a42.Equals("True")) {  a42 = "1"; }
            if (a42.Equals("False")) { a42 = "0"; }

            a43 = listBox1.Items[41].ToString();
            if (a43.Equals("True")) {  a43 = "1"; }
            if (a43.Equals("False")) { a43 = "0"; }

            a44 = listBox1.Items[42].ToString();
            if (a44.Equals("True")) {  a44 = "1"; }
            if (a44.Equals("False")) { a44 = "0"; }

            a45 = listBox1.Items[43].ToString();
            if (a45.Equals("True")) {  a45 = "1"; }
            if (a45.Equals("False")) { a45 = "0"; }

            a46 = listBox1.Items[44].ToString();
            if (a46.Equals("True")) {  a46 = "1"; }
            if (a46.Equals("False")) { a46 = "0"; }

            a47 = listBox1.Items[45].ToString();
            if (a47.Equals("True")) {  a47 = "1"; }
            if (a47.Equals("False")) { a47 = "0"; }

            a48 = listBox1.Items[46].ToString();
            if (a48.Equals("True")) {  a48 = "1"; }
            if (a48.Equals("False")) { a48 = "0"; }

            a49 = listBox1.Items[47].ToString();
            if (a49.Equals("True")) {  a49 = "1"; }
            if (a49.Equals("False")) { a49 = "0"; }

            a50 = listBox1.Items[48].ToString();
            if (a50.Equals("True")) {  a50 = "1"; }
            if (a50.Equals("False")) { a50 = "0"; }

            a51 = listBox1.Items[49].ToString();
            if (a51.Equals("True")) {  a51 = "1"; }
            if (a51.Equals("False")) { a51 = "0"; }

            a52 = listBox1.Items[50].ToString();
            if (a52.Equals("True")) {  a52 = "1"; }
            if (a52.Equals("False")) { a52 = "0"; }

            a53 = listBox1.Items[51].ToString();
            if (a53.Equals("True")) {  a53 = "1"; }
            if (a53.Equals("False")) { a53 = "0"; }

            a54 = listBox1.Items[52].ToString();
            if (a54.Equals("True")) {  a54 = "1"; }
            if (a54.Equals("False")) { a54 = "0"; }

            a55 = listBox1.Items[53].ToString();
            if (a55.Equals("True")) {  a55 = "1"; }
            if (a55.Equals("False")) { a55 = "0"; }

            a56 = listBox1.Items[54].ToString();
            if (a56.Equals("True")) {  a56 = "1"; }
            if (a56.Equals("False")) { a56 = "0"; }

            a57 = listBox1.Items[55].ToString();
            if (a57.Equals("True")) {  a57 = "1"; }
            if (a57.Equals("False")) { a57 = "0"; }

            a58 = listBox1.Items[56].ToString();
            if (a58.Equals("True")) {  a58 = "1"; }
            if (a58.Equals("False")) { a58 = "0"; }

            a59 = listBox1.Items[57].ToString();
            if (a59.Equals("True")) {  a59 = "1"; }
            if (a59.Equals("False")) { a59 = "0"; }

            a60 = listBox1.Items[58].ToString();
            if (a60.Equals("True")) {  a60 = "1"; }
            if (a60.Equals("False")) { a60 = "0"; }

            a61 = listBox1.Items[59].ToString();
            if (a61.Equals("True")) {  a61 = "1"; }
            if (a61.Equals("False")) { a61 = "0"; }

            a62 = listBox1.Items[60].ToString();
            if (a62.Equals("True")) {  a62 = "1"; }
            if (a62.Equals("False")) { a62 = "0"; }

            a63 = listBox1.Items[61].ToString();
            if (a63.Equals("True")) {  a63 = "1"; }
            if (a63.Equals("False")) { a63 = "0"; }

            a64 = listBox1.Items[62].ToString();
            if (a64.Equals("True")) {  a64 = "1"; }
            if (a64.Equals("False")) { a64 = "0"; }

            a65 = listBox1.Items[63].ToString();
            if (a65.Equals("True")) {  a65 = "1"; }
            if (a65.Equals("False")) { a65 = "0"; }

            a66 = listBox1.Items[64].ToString();
            if (a66.Equals("True")) {  a66 = "1"; }
            if (a66.Equals("False")) { a66 = "0"; }

            a67 = listBox1.Items[65].ToString();
            if (a67.Equals("True")) {  a67 = "1"; }
            if (a67.Equals("False")) { a67 = "0"; }

            a68 = listBox1.Items[66].ToString();
            if (a68.Equals("True")) {  a68 = "1"; }
            if (a68.Equals("False")) { a68 = "0"; }

            a69 = listBox1.Items[67].ToString();
            if (a69.Equals("True")) {  a69 = "1"; }
            if (a69.Equals("False")) { a69 = "0"; }

            a70 = listBox1.Items[68].ToString();
            if (a70.Equals("True")) {  a70 = "1"; }
            if (a70.Equals("False")) { a70 = "0"; }

            a71 = listBox1.Items[69].ToString();
            if (a71.Equals("True")) {  a71 = "1"; }
            if (a71.Equals("False")) { a71 = "0"; }

            a72 = listBox1.Items[70].ToString();
            if (a72.Equals("True")) {  a72 = "1"; }
            if (a72.Equals("False")) { a72 = "0"; }

            a73 = listBox1.Items[71].ToString();
            if (a73.Equals("True")) {  a73 = "1"; }
            if (a73.Equals("False")) { a73 = "0"; }

            a74 = listBox1.Items[72].ToString();
            if (a74.Equals("True")) {  a74 = "1"; }
            if (a74.Equals("False")) { a74 = "0"; }

            a75 = listBox1.Items[73].ToString();
            if (a75.Equals("True")) {  a75 = "1"; }
            if (a75.Equals("False")) { a75 = "0"; }

            a76 = listBox1.Items[74].ToString();
            if (a76.Equals("True")) {  a76 = "1"; }
            if (a76.Equals("False")) { a76 = "0"; }

            a77 = listBox1.Items[75].ToString();
            if (a77.Equals("True")) {  a77 = "1"; }
            if (a77.Equals("False")) { a77 = "0"; }

            a78 = listBox1.Items[76].ToString();
            if (a78.Equals("True")) {  a78 = "1"; }
            if (a78.Equals("False")) { a78 = "0"; }

            a79 = listBox1.Items[77].ToString();
            if (a79.Equals("True")) {  a79 = "1"; }
            if (a79.Equals("False")) { a79 = "0"; }

            a80 = listBox1.Items[78].ToString();
            if (a80.Equals("True")) {  a80 = "1"; }
            if (a80.Equals("False")) { a80 = "0"; }

            a81 = listBox1.Items[79].ToString();
            if (a81.Equals("True")) {  a81 = "1"; }
            if (a81.Equals("False")) { a81 = "0"; }

            a82 = listBox1.Items[80].ToString();
            if (a82.Equals("True")) {  a82 = "1"; }
            if (a82.Equals("False")) { a82 = "0"; }

            a83 = listBox1.Items[81].ToString();
            if (a83.Equals("True")) {  a83 = "1"; }
            if (a83.Equals("False")) { a83 = "0"; }

            a84 = listBox1.Items[82].ToString();
            if (a84.Equals("True")) {  a84 = "1"; }
            if (a84.Equals("False")) { a84 = "0"; }

            a85 = listBox1.Items[83].ToString();
            if (a85.Equals("True")) {  a85 = "1"; }
            if (a85.Equals("False")) { a85 = "0"; }

            a86 = listBox1.Items[84].ToString();
            if (a86.Equals("True")) {  a86 = "1"; }
            if (a86.Equals("False")) { a86 = "0"; }

            a87 = listBox1.Items[85].ToString();
            if (a87.Equals("True")) {  a87 = "1"; }
            if (a87.Equals("False")) { a87 = "0"; }

            a88 = listBox1.Items[86].ToString();
            if (a88.Equals("True")) {  a88 = "1"; }
            if (a88.Equals("False")) { a88 = "0"; }

            a89 = listBox1.Items[87].ToString();
            if (a89.Equals("True")) {  a89 = "1"; }
            if (a89.Equals("False")) { a89 = "0"; }

            a90 = listBox1.Items[88].ToString();
            if (a90.Equals("True")) {  a90 = "1"; }
            if (a90.Equals("False")) { a90 = "0"; }

            a91 = listBox1.Items[89].ToString();
            if (a91.Equals("True")) {  a91 = "1"; }
            if (a91.Equals("False")) { a91 = "0"; }

            a92 = listBox1.Items[90].ToString();
            if (a92.Equals("True")) {  a92 = "1"; }
            if (a92.Equals("False")) { a92 = "0"; }

            a93 = listBox1.Items[91].ToString();
            if (a93.Equals("True")) {  a93 = "1"; }
            if (a93.Equals("False")) { a93 = "0"; }

            a94 = listBox1.Items[92].ToString();
            if (a94.Equals("True")) {  a94 = "1"; }
            if (a94.Equals("False")) { a94 = "0"; }

            a95 = listBox1.Items[93].ToString();
            if (a95.Equals("True")) {  a95 = "1"; }
            if (a95.Equals("False")) { a95 = "0"; }

            a96 = listBox1.Items[94].ToString();
            if (a96.Equals("True")) {  a96 = "1"; }
            if (a96.Equals("False")) { a96 = "0"; }

            a97 = listBox1.Items[95].ToString();
            if (a97.Equals("True")) {  a97 = "1"; }
            if (a97.Equals("False")) { a97 = "0"; }

            a98 = listBox1.Items[96].ToString();
            if (a98.Equals("True")) {  a98 = "1"; }
            if (a98.Equals("False")) { a98 = "0"; }

            a99 = listBox1.Items[97].ToString();
            if (a99.Equals("True")) {  a99 = "1"; }
            if (a99.Equals("False")) { a99 = "0"; }

            a100 = listBox1.Items[98].ToString();
            if (a100.Equals("True")) {  a100 = "1"; }
            if (a100.Equals("False")) { a100 = "0"; }

            a101 = listBox1.Items[99].ToString();
            if (a101.Equals("True")) {  a101 = "1"; }
            if (a101.Equals("False")) { a101 = "0"; }

            a102 = listBox1.Items[100].ToString();
            if (a102.Equals("True")) {  a102 = "1"; }
            if (a102.Equals("False")) { a102 = "0"; }

            a103 = listBox1.Items[101].ToString();
            if (a103.Equals("True")) {  a103 = "1"; }
            if (a103.Equals("False")) { a103 = "0"; }

            a104 = listBox1.Items[102].ToString();
            if (a104.Equals("True")) {  a104 = "1"; }
            if (a104.Equals("False")) { a104 = "0"; }

            a105 = listBox1.Items[103].ToString();
            if (a105.Equals("True")) {  a105 = "1"; }
            if (a105.Equals("False")) { a105 = "0"; }

            a106 = listBox1.Items[104].ToString();
            if (a106.Equals("True")) {  a106 = "1"; }
            if (a106.Equals("False")) { a106 = "0"; }

            a107 = listBox1.Items[105].ToString();
            if (a107.Equals("True")) {  a107 = "1"; }
            if (a107.Equals("False")) { a107 = "0"; }

            a108 = listBox1.Items[106].ToString();
            if (a108.Equals("True")) {  a108 = "1"; }
            if (a108.Equals("False")) { a108 = "0"; }

            a109 = listBox1.Items[107].ToString();
            if (a109.Equals("True")) {  a109 = "1"; }
            if (a109.Equals("False")) { a109 = "0"; }

            a110 = listBox1.Items[108].ToString();
            if (a110.Equals("True")) {  a110 = "1"; }
            if (a110.Equals("False")) { a110 = "0"; }

            a111 = listBox1.Items[109].ToString();
            if (a111.Equals("True")) {  a111 = "1"; }
            if (a111.Equals("False")) { a111 = "0"; }

            a112 = listBox1.Items[110].ToString();
            if (a112.Equals("True")) {  a112 = "1"; }
            if (a112.Equals("False")) { a112 = "0"; }

            a113 = listBox1.Items[111].ToString();
            if (a113.Equals("True")) {  a113 = "1"; }
            if (a113.Equals("False")) { a113 = "0"; }

            a114 = listBox1.Items[112].ToString();
            if (a114.Equals("True")) {  a114 = "1"; }
            if (a114.Equals("False")) { a114 = "0"; }

            a115 = listBox1.Items[113].ToString();
            if (a115.Equals("True")) {  a115 = "1"; }
            if (a115.Equals("False")) { a115 = "0"; }

            a116 = listBox1.Items[114].ToString();
            if (a116.Equals("True")) {  a116 = "1"; }
            if (a116.Equals("False")) { a116 = "0"; }

            a117 = listBox1.Items[115].ToString();
            if (a117.Equals("True")) {  a117 = "1"; }
            if (a117.Equals("False")) { a117 = "0"; }

            a118 = listBox1.Items[116].ToString();
            if (a118.Equals("True")) {  a118 = "1"; }
            if (a118.Equals("False")) { a118 = "0"; }

            a119 = listBox1.Items[117].ToString();
            if (a119.Equals("True")) {  a119 = "1"; }
            if (a119.Equals("False")) { a119 = "0"; }

            a120 = listBox1.Items[118].ToString();
            if (a120.Equals("True")) {  a120 = "1"; }
            if (a120.Equals("False")) { a120 = "0"; }

            a121 = listBox1.Items[119].ToString();
            if (a121.Equals("True")) {  a121 = "1"; }
            if (a121.Equals("False")) { a121 = "0"; }

            a122 = listBox1.Items[120].ToString();
            if (a122.Equals("True")) {  a122 = "1"; }
            if (a122.Equals("False")) { a122 = "0"; }

            a123 = listBox1.Items[121].ToString();
            if (a123.Equals("True")) {  a123 = "1"; }
            if (a123.Equals("False")) { a123 = "0"; }

            a124 = listBox1.Items[122].ToString();
            if (a124.Equals("True")) {  a124 = "1"; }
            if (a124.Equals("False")) { a124 = "0"; }

            a125 = listBox1.Items[123].ToString();
            if (a125.Equals("True")) {  a125 = "1"; }
            if (a125.Equals("False")) { a125 = "0"; }

            a126 = listBox1.Items[124].ToString();
            if (a126.Equals("True")) {  a126 = "1"; }
            if (a126.Equals("False")) { a126 = "0"; }

            a127 = listBox1.Items[125].ToString();
            if (a127.Equals("True")) {  a127 = "1"; }
            if (a127.Equals("False")) { a127 = "0"; }

            a128 = listBox1.Items[126].ToString();
            if (a128.Equals("True")) {  a128 = "1"; }
            if (a128.Equals("False")) { a128 = "0"; }

            a129 = listBox1.Items[127].ToString();
            if (a129.Equals("True")) {  a129 = "1"; }
            if (a129.Equals("False")) { a129 = "0"; }

            a130 = listBox1.Items[128].ToString();
            if (a130.Equals("True")) {  a130 = "1"; }
            if (a130.Equals("False")) { a130 = "0"; }

            a131 = listBox1.Items[129].ToString();
            if (a131.Equals("True")) {  a131 = "1"; }
            if (a131.Equals("False")) { a131 = "0"; }
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

                m_CmdTextDS = @"UPDATE CB_345KV SET YY_LOG_DATE = TO_CHAR(SYSDATE, 'YYYYMMDDHH24MISS'), "
                                + "YY_61LRL_002JS_160DI = '" + a2 +
                                "', YY_61LRL_002JS_021DI = '" + a3 +
                                "', YY_61LRL_012JS_160DI = '" + a4 +
                                "', YY_61LRL_012JS_021DI = '" + a5 +
                                "', YY_61LRL_001JD_160DI = '" + a6 +
                                "', YY_61LRL_001JD_021DI = '" + a7 +
                                "', YY_61LRL_011JS_160DI = '" + a8 +
                                "', YY_61LRL_011JS_021DI = '" + a9 +
                                "', YY_61LRL_001JS_160DI = '" + a10 +
                                "', YY_61LRL_001JS_021DI = '" + a11 +
                                "', YY_61LRL_013JS_160DI = '" + a12 +
                                "', YY_61LRL_013JS_021DI = '" + a13 +
                                "', YY_61LRL_003JS_160DI = '" + a14 +
                                "', YY_61LRL_003JS_021DI = '" + a15 +
                                "', YY_61LRL_010JS_160DI = '" + a16 +
                                "', YY_61LRL_010JS_021DI = '" + a17 +
                                "', YY_60LRC_001JS_160DI = '" + a18 +
                                "', YY_60LRC_001JS_021DI = '" + a19 +
                                "', YY_60LRC_011JS_160DI = '" + a20 +
                                "', YY_60LRC_011JS_021DI = '" + a21 +
                                "', YY_60LRC_001JD_160DI = '" + a22 +
                                "', YY_60LRC_001JD_021DI = '" + a23 +
                                "', YY_60LRC_012JS_160DI = '" + a24 +
                                "', YY_60LRC_012JS_021DI = '" + a25 +
                                "', YY_60LRC_002JS_160DI = '" + a26 +
                                "', YY_60LRC_002JS_021DI = '" + a27 +
                                "', YY_61LRT_003JS_160DI = '" + a28 +
                                "', YY_61LRT_003JS_021DI = '" + a29 +
                                "', YY_61LRT_010JS_160DI = '" + a30 +
                                "', YY_61LRT_010JS_021DI = '" + a31 +
                                "', YY_61LRT_013JS_160DI = '" + a32 +
                                "', YY_61LRT_013JS_021DI = '" + a33 +
                                "', YY_61LRT_001JS_160DI = '" + a34 +
                                "', YY_61LRT_001JS_021DI = '" + a35 +
                                "', YY_61LRT_011JS_160DI = '" + a36 +
                                "', YY_61LRT_011JS_021DI = '" + a37 +
                                "', YY_61LRT_001JD_160DI = '" + a38 +
                                "', YY_61LRT_001JD_021DI = '" + a39 +
                                "', YY_61LRT_012JS_160DI = '" + a40 +
                                "', YY_61LRT_012JS_021DI = '" + a41 +
                                "', YY_61LRT_002JS_160DI = '" + a42 +
                                "', YY_61LRT_002JS_021DI = '" + a43 +
                                "', YY_60LRC_021JS_160DI = '" + a44 +
                                "', YY_60LRC_021JS_021DI = '" + a45 +
                                "', YY_60LRC_022JS_160DI = '" + a46 +
                                "', YY_60LRC_022JS_021DI = '" + a47 +
                                "', YY_62LRT_002JS_160DI = '" + a48 +
                                "', YY_62LRT_002JS_021DI = '" + a49 +
                                "', YY_62LRT_012JS_160DI = '" + a50 +
                                "', YY_62LRT_012JS_021DI = '" + a51 +
                                "', YY_62LRT_001JD_160DI = '" + a52 +
                                "', YY_62LRT_001JD_021DI = '" + a53 +
                                "', YY_62LRT_011JS_160DI = '" + a54 +
                                "', YY_62LRT_011JS_021DI = '" + a55 +
                                "', YY_62LRT_001JS_160DI = '" + a56 +
                                "', YY_62LRT_001JS_021DI = '" + a57 +
                                "', YY_62LRT_013JS_160DI = '" + a58 +
                                "', YY_62LRT_013JS_021DI = '" + a59 +
                                "', YY_62LRT_003JS_160DI = '" + a60 +
                                "', YY_62LRT_003JS_021DI = '" + a61 +
                                "', YY_62LRT_010JS_160DI = '" + a62 +
                                "', YY_62LRT_010JS_021DI = '" + a63 +
                                "', YY_60LRC_003JS_160DI = '" + a64 +
                                "', YY_60LRC_003JS_021DI = '" + a65 +
                                "', YY_60LRC_013JS_160DI = '" + a66 +
                                "', YY_60LRC_013JS_021DI = '" + a67 +
                                "', YY_60LRC_002JD_160DI = '" + a68 +
                                "', YY_60LRC_002JD_021DI = '" + a69 +
                                "', YY_60LRC_014JS_160DI = '" + a70 +
                                "', YY_60LRC_014JS_021DI = '" + a71 +
                                "', YY_60LRC_004JS_160DI = '" + a72 +
                                "', YY_60LRC_004JS_021DI = '" + a73 +
                                "', YY_63LRT_013JS_160DI = '" + a74 +
                                "', YY_63LRT_013JS_021DI = '" + a75 +
                                "', YY_63LRT_003JS_160DI = '" + a76 +
                                "', YY_63LRT_003JS_021DI = '" + a77 +
                                "', YY_63LRT_001JS_160DI = '" + a78 +
                                "', YY_63LRT_001JS_021DI = '" + a79 +
                                "', YY_63LRT_011JS_160DI = '" + a80 +
                                "', YY_63LRT_011JS_021DI = '" + a81 +
                                "', YY_63LRT_001JD_160DI = '" + a82 +
                                "', YY_63LRT_001JD_021DI = '" + a83 +
                                "', YY_63LRT_012JS_160DI = '" + a84 +
                                "', YY_63LRT_012JS_021DI = '" + a85 +
                                "', YY_63LRT_002JS_160DI = '" + a86 +
                                "', YY_63LRT_002JS_021DI = '" + a87 +
                                "', YY_63LRT_010JS_160DI = '" + a88 +
                                "', YY_63LRT_010JS_021DI = '" + a89 +
                                "', YY_62LRL_002JS_160DI = '" + a90 +
                                "', YY_62LRL_002JS_021DI = '" + a91 +
                                "', YY_62LRL_012JS_160DI = '" + a92 +
                                "', YY_62LRL_012JS_021DI = '" + a93 +
                                "', YY_62LRL_001JD_160DI = '" + a94 +
                                "', YY_62LRL_001JD_021DI = '" + a95 +
                                "', YY_62LRL_011JS_160DI = '" + a96 +
                                "', YY_62LRL_011JS_021DI = '" + a97 +
                                "', YY_62LRL_001JS_160DI = '" + a98 +
                                "', YY_62LRL_001JS_021DI = '" + a99 +
                                "', YY_62LRL_013JS_160DI = '" + a100 +
                                "', YY_62LRL_013JS_021DI = '" + a101 +
                                "', YY_62LRL_003JS_160DI = '" + a102 +
                                "', YY_62LRL_003JS_021DI = '" + a103 +
                                "', YY_62LRL_010JS_160DI = '" + a104 +
                                "', YY_62LRL_010JS_021DI = '" + a105 +
                                "', YY_60LRC_005JS_160DI = '" + a106 +
                                "', YY_60LRC_005JS_021DI = '" + a107 +
                                "', YY_60LRC_015JS_160DI = '" + a108 +
                                "', YY_60LRC_015JS_021DI = '" + a109 +
                                "', YY_60LRC_003JD_160DI = '" + a110 +
                                "', YY_60LRC_003JD_021DI = '" + a111 +
                                "', YY_60LRC_016JS_160DI = '" + a112 +
                                "', YY_60LRC_016JS_021DI = '" + a113 +
                                "', YY_60LRC_006JS_160DI = '" + a114 +
                                "', YY_60LRC_006JS_021DI = '" + a115 +
                                "', YY_64LRT_013JS_160DI = '" + a116 +
                                "', YY_64LRT_013JS_021DI = '" + a117 +
                                "', YY_64LRT_003JS_160DI = '" + a118 +
                                "', YY_64LRT_003JS_021DI = '" + a119 +
                                "', YY_64LRT_010JS_160DI = '" + a120 +
                                "', YY_64LRT_010JS_021DI = '" + a121 +
                                "', YY_64LRT_001JS_160DI = '" + a122 +
                                "', YY_64LRT_001JS_021DI = '" + a123 +
                                "', YY_64LRT_011JS_160DI = '" + a124 +
                                "', YY_64LRT_011JS_021DI = '" + a125 +
                                "', YY_64LRT_001JD_160DI = '" + a126 +
                                "', YY_64LRT_001JD_021DI = '" + a127 +
                                "', YY_64LRT_012JS_160DI = '" + a128 +
                                "', YY_64LRT_012JS_021DI = '" + a129 +
                                "', YY_64LRT_002JS_160DI = '" + a130 +
                                "', YY_64LRT_002JS_021DI = '" + a131 +
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
