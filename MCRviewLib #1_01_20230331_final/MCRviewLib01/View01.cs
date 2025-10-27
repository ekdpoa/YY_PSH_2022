using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCRviewLib01
{
    public partial class View01 : Form
    {
        string dateTime = System.DateTime.Now.ToString("yyyy.MM.dd tt hh:mm:ss");

        public View01()
        {
            InitializeComponent();
        }

        private void View01_Load(object sender, EventArgs e)
        {
            this.SetBounds(0, 0, 1920, 2160);

            circularProgressBar1.SetBounds(130, 1640, 389, 389);
            circularProgressBar2.SetBounds(556, 1640, 389, 389);
            circularProgressBar3.SetBounds(980, 1640, 389, 389);
            circularProgressBar4.SetBounds(1403, 1640, 389, 389);

            lbl_rate_title.BringToFront();
            txt_supp_reserve_rate.BringToFront();
            lbl_per.BringToFront();

            txt_01gta_amount.BringToFront();
            txt_02gta_amount.BringToFront();
            txt_03gta_amount.BringToFront();
            txt_04gta_amount.BringToFront();

            label1.BringToFront();
            label2.BringToFront();
            label3.BringToFront();
            label4.BringToFront();

            //timer_get_value_01.Interval = 1000*60;
            timer_get_value_01.Interval = 1000;
            timer_get_value_01.Enabled = true;

            //timer_get_value_02.Interval = 1000;
            timer_get_value_02.Interval = 3000;
            timer_get_value_02.Enabled = true;
        }

        private void timer_clock_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = System.DateTime.Now.ToString("yyyy.MM.dd tt hh:mm:ss");
        }

        //초록 뺑글이 show
        private void button1_Click(object sender, EventArgs e)
        {
            pic_gta01_p_moving.SetBounds(165, 1674, 320, 320);
            pic_gta01_p_moving.Visible = true;

            pic_gta02_p_moving.SetBounds(591, 1674, 320, 320);
            pic_gta02_p_moving.Visible = true;

            pic_gta03_p_moving.SetBounds(1014, 1674, 320, 320);
            pic_gta03_p_moving.Visible = true;

            pic_gta04_p_moving.SetBounds(1440, 1674, 320, 320);
            pic_gta04_p_moving.Visible = true;
        }

        //초록 뺑글이 hide
        private void button2_Click(object sender, EventArgs e)
        {
            pic_gta01_p_moving.Visible = false;
            pic_gta02_p_moving.Visible = false;
            pic_gta03_p_moving.Visible = false;
            pic_gta04_p_moving.Visible = false;
        }

        //파랑 뺑글이 show
        private void button3_Click(object sender, EventArgs e)
        {
            pic_gta01_g_moving.SetBounds(165, 1674, 320, 320);
            pic_gta01_g_moving.Visible = true;

            pic_gta02_g_moving.SetBounds(591, 1674, 320, 320);
            pic_gta02_g_moving.Visible = true;

            pic_gta03_g_moving.SetBounds(1014, 1674, 320, 320);
            pic_gta03_g_moving.Visible = true;

            pic_gta04_g_moving.SetBounds(1440, 1674, 320, 320);
            pic_gta04_g_moving.Visible = true;
        }

        //파랑 뺑글이 hide
        private void button4_Click(object sender, EventArgs e)
        {
            pic_gta01_g_moving.Visible = false;
            pic_gta02_g_moving.Visible = false;
            pic_gta03_g_moving.Visible = false;
            pic_gta04_g_moving.Visible = false;
        }





        //1면: 양수발전소 종합현황
        //db: REALTIME_TOTAL_INFO (API)
        //pi: 없음

        //전력예비율
        double supplyAbility = 0.0;          //공급능력(mw)
        double currentPower = 0.0;           //현재 수요(mw)
        double supplyReservePower = 0.0;     //공급 예비력(mw)
        double supplyReserveRate = 0.0;      //공급 예비율(%)

        //양수발전소
        double yyPsh = 0.0;
        double cpPsh = 0.0;
        double srPsh = 0.0;
        double mjPsh = 0.0;
        double scPsh = 0.0;
        double csPsh = 0.0;
        double ycPsh = 0.0;

        //수력발전소
        double hcHydro = 0.0;
        double chHydro = 0.0;
        double uaHydro = 0.0;
        double cpHydro = 0.0;
        double pdHydro = 0.0;
        double cbHydro = 0.0;
        double bsHydro = 0.0;

        //원자력발전소
        double huNuc = 0.0;
        double wsNuc = 0.0;
        double suNuc = 0.0;
        double grNuc = 0.0;
        double hbNuc = 0.0;

        private void timer_get_value_01_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.listBoxViewData01.Items.Count <= 0) { }
                else
                {
                    supplyAbility = double.Parse(listBoxViewData01.Items[1].ToString());
                    currentPower = double.Parse(listBoxViewData01.Items[2].ToString());
                    supplyReservePower = double.Parse(listBoxViewData01.Items[3].ToString());
                    supplyReserveRate = double.Parse(listBoxViewData01.Items[4].ToString());

                    yyPsh = double.Parse(listBoxViewData01.Items[5].ToString());
                    cpPsh = double.Parse(listBoxViewData01.Items[6].ToString());
                    mjPsh = double.Parse(listBoxViewData01.Items[7].ToString());
                    scPsh = double.Parse(listBoxViewData01.Items[8].ToString());
                    csPsh = double.Parse(listBoxViewData01.Items[9].ToString());
                    ycPsh = double.Parse(listBoxViewData01.Items[10].ToString());
                    srPsh = double.Parse(listBoxViewData01.Items[11].ToString());

                    //양양1000 무주600 예천800 삼랑진600 청송600 산청700 청평400
                    //test
                    /*
                    yyPsh = 500;
                    cpPsh = 200;
                    mjPsh = 0;
                    scPsh = -0;
                    csPsh = -200;
                    ycPsh = -300;
                    srPsh = -100;
                    */

                    hcHydro = double.Parse(listBoxViewData01.Items[12].ToString());
                    chHydro = double.Parse(listBoxViewData01.Items[13].ToString());
                    uaHydro = double.Parse(listBoxViewData01.Items[14].ToString());
                    cpHydro = double.Parse(listBoxViewData01.Items[15].ToString());
                    pdHydro = double.Parse(listBoxViewData01.Items[16].ToString());
                    cbHydro = double.Parse(listBoxViewData01.Items[17].ToString());
                    bsHydro = double.Parse(listBoxViewData01.Items[18].ToString());

                    huNuc = double.Parse(listBoxViewData01.Items[19].ToString());
                    wsNuc = double.Parse(listBoxViewData01.Items[20].ToString());
                    suNuc = double.Parse(listBoxViewData01.Items[21].ToString());
                    grNuc = double.Parse(listBoxViewData01.Items[22].ToString());
                    hbNuc = double.Parse(listBoxViewData01.Items[23].ToString());

                    SetControls01();
                }
                EmergencyWarningRate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void SetControls01()
        {
            int numYY = 0;
            int hYY = 0;
            int numCP = 0;
            int hCP = 0;
            int numYC = 0;
            int hYC = 0;
            int numMJ = 0;
            int hMJ = 0;
            int numCS = 0;
            int hCS = 0;
            int numSC = 0;
            int hSC = 0;
            int numSR = 0;
            int hSR = 0;

            //양양1000 무주600 예천800 삼랑진600 청송600 산청700 청평400

            //양양
            //numYY = Convert.ToInt32(Math.Truncate(yyPsh));
            numYY = Convert.ToInt32(Math.Truncate(gta01MW + gta02MW + gta03MW + gta04MW));
            if (numYY < 0) 
            {
                hYY = (int)(150 - ((numYY / 1000.00) * 150 * -1));
                pictureBoxYY.BackColor = Color.LawnGreen;
                pictureBoxYY_B.SetBounds(1628, 504, 25, hYY);
            } 
            else 
            {
                hYY = (int)(150 - ((numYY / 1000.00) * 150 * 1));
                pictureBoxYY.BackColor = Color.Cyan; 
                pictureBoxYY_B.SetBounds(1628, 504, 25, hYY);
            }

            //청평
            numCP = Convert.ToInt32(Math.Truncate(cpPsh));
            if (numCP < 0) 
            {
                hCP = (int)(150 - ((numCP / 400.00) * 150 * -1));
                pictureBoxCP.BackColor = Color.LawnGreen;
                pictureBoxCP_B.SetBounds(1423, 503, 25, hCP);
            } 
            else 
            { 
                hCP = (int)(150 - ((numCP / 400.00) * 150 * 1));
                pictureBoxCP.BackColor = Color.Cyan; 
                pictureBoxCP_B.SetBounds(1423, 503, 25, hCP);
            }

            //예천
            numYC = Convert.ToInt32(Math.Truncate(ycPsh));
            if (numYC < 0) 
            {
                hYC = (int)(150 - ((numYC / 800.00) * 150 * -1));
                pictureBoxYC.BackColor = Color.LawnGreen;
                pictureBoxYC_B.SetBounds(1623, 817, 25, hYC);
            } 
            else 
            {
                hYC = (int)(150 - ((numYC / 800.00) * 150 * 1));
                pictureBoxYC.BackColor = Color.Cyan; 
                pictureBoxYC_B.SetBounds(1623, 817, 25, hYC);
            }
            
            //무주
            numMJ = Convert.ToInt32(Math.Truncate(mjPsh));
            if (numMJ < 0) 
            {
                hMJ = (int)(150 - ((numMJ / 600.00) * 150 * -1));
                pictureBoxMJ.BackColor = Color.LawnGreen;
                pictureBoxMJ_B.SetBounds(1457, 921, 25, hMJ);
            } 
            else 
            { 
                hMJ = (int)(150 - ((numMJ / 600.00) * 150 * 1));
                pictureBoxMJ.BackColor = Color.Cyan; 
                pictureBoxMJ_B.SetBounds(1457, 921, 25, hMJ);
            }

            //청송
            numCS = Convert.ToInt32(Math.Truncate(csPsh));
            if (numCS < 0) 
            {
                hCS = (int)(150 - ((numCS / 600.00) * 150 * -1));
                pictureBoxCS.BackColor = Color.LawnGreen;
                pictureBoxCS_B.SetBounds(1750, 912, 25, hCS);
            } 
            else 
            {
                hCS = (int)(150 - ((numCS / 600.00) * 150 * 1));
                pictureBoxCS.BackColor = Color.Cyan; 
                pictureBoxCS_B.SetBounds(1750, 912, 25, hCS);
            }

            //산청
            numSC = Convert.ToInt32(Math.Truncate(scPsh));
            if (numSC < 0) 
            {
                hSC = (int)(150 - ((numSC / 700.00) * 150 * -1));
                pictureBoxSC.BackColor = Color.LawnGreen;
                pictureBoxSC_B.SetBounds(1479, 1090, 25, hSC);
            } 
            else 
            {
                hSC = (int)(150 - ((numSC / 700.00) * 150 * 1));
                pictureBoxSC.BackColor = Color.Cyan; 
                pictureBoxSC_B.SetBounds(1479, 1090, 25, hSC);
            }

            //삼랑진
            numSR = Convert.ToInt32(Math.Truncate(srPsh));
            if (numSR < 0) 
            {
                hSR = (int)(150 - ((numSR / 600.00) * 150 * -1));
                pictureBoxSR.BackColor = Color.LawnGreen;
                pictureBoxSR_B.SetBounds(1631, 1052, 25, hSR);
            } 
            else 
            { 
                hSR = (int)(150 - ((numSR / 600.00) * 150 * 1));
                pictureBoxSR.BackColor = Color.Cyan; 
                pictureBoxSR_B.SetBounds(1631, 1052, 25, hSR);
            }

            //전력예비율
            txt_supp_ability.Text = supplyAbility.ToString("#,#");
            txt_curr_pwr.Text = currentPower.ToString("#,#");
            txt_supp_reserve_pwr.Text = supplyReservePower.ToString("#,#");
            txt_supp_reserve_rate.Text = supplyReserveRate.ToString("#,#.0");

            //전국 양수발전소
            if (gta01MW > 250) { gta01MW = 250; }
            if (gta01MW < -250) { gta01MW = -250; }

            if (gta02MW > 250) { gta02MW = 250; }
            if (gta02MW < -250) { gta02MW = -250; }

            if (gta03MW > 250) { gta03MW = 250; }
            if (gta03MW < -250) { gta03MW = -250; }

            if (gta04MW > 250) { gta04MW = 250; }
            if (gta04MW < -250) { gta04MW = -250; }

            //0110
            //test
            //txt_yy_psh_total.Text = yyPsh.ToString("F0");
            txt_yy_psh_total.Text = (gta01MW + gta02MW + gta03MW + gta04MW).ToString("F0");
            txt_cp_psh_total.Text = cpPsh.ToString("F0");
            txt_sr_psh_total.Text = srPsh.ToString("F0");
            txt_mj_psh_total.Text = mjPsh.ToString("F0");
            txt_sc_psh_total.Text = scPsh.ToString("F0");
            txt_cs_psh_total.Text = csPsh.ToString("F0");
            txt_yc_psh_total.Text = ycPsh.ToString("F0");

            //전국 수력발전소
            txt_hc_hydro_total.Text = hcHydro.ToString("F2");
            txt_ch_hydro_total.Text = chHydro.ToString("F2");
            txt_ua_hydro_total.Text = uaHydro.ToString("F2");
            txt_cp_hydro_total.Text = cpHydro.ToString("F2");
            txt_pd_hydro_total.Text = pdHydro.ToString("F2");
            txt_cb_hydro_total.Text = cbHydro.ToString("F2");
            txt_bs_hydro_total.Text = bsHydro.ToString("F2");

            //전국 원자력발전소
            txt_hu_nuc_total.Text = huNuc.ToString("#,#");
            txt_ws_nuc_total.Text = wsNuc.ToString("#,#");
            txt_su_nuc_total.Text = suNuc.ToString("#,#");
            txt_gr_nuc_total.Text = grNuc.ToString("#,#");
            txt_hb_nuc_total.Text = hbNuc.ToString("#,#");
        }

        /*
            등급 기준
            - 공급예비율 = 공급예비력 / 전력수요
            - 예비전력 = 공급능력 - 전력수요
                준비(1단계): 예비전력이 4,500mw 이상 ~ 5,500mw 미만인 경우 
                관심(2단계): 예비전력이 3,500mw 이상 ~ 4,500mw 미만인 경우 
                주의(3단계): 예비전력이 2,500mw 이상 ~ 3,500mw 미만인 경우 
                경계(4단계): 예비전력이 1,500mw 이상 ~ 2,500mw 미만인 경우 
                심각(5단계): 예비전력이 1,500mw 미만인 경우 
         */
        public void EmergencyWarningRate()
        {
            if (supplyReservePower > 5500)
            {
                //정상
                lbl_rate_title.Text = "정상단계";
                pic_supply_reserve_rate.Image = Properties.Resources.rate_nomal;
                lbl_rate_title.ForeColor = Color.DodgerBlue;
                txt_supp_reserve_rate.ForeColor = Color.DodgerBlue;
                lbl_per.ForeColor = Color.DodgerBlue;
            }

            if (supplyReservePower >= 4500 && supplyReservePower < 5500)
            {
                //준비
                lbl_rate_title.Text = "준비단계";
                pic_supply_reserve_rate.Image = Properties.Resources.rate_ready;
                lbl_rate_title.ForeColor = Color.LimeGreen;
                txt_supp_reserve_rate.ForeColor = Color.LimeGreen;
                lbl_per.ForeColor = Color.LimeGreen;
            }

            if (supplyReservePower >= 3500 && supplyReservePower < 4500)
            {
                //관심
                lbl_rate_title.Text = "관심단계";
                pic_supply_reserve_rate.Image = Properties.Resources.rate_attention;
                lbl_rate_title.ForeColor = Color.YellowGreen;
                txt_supp_reserve_rate.ForeColor = Color.YellowGreen;
                lbl_per.ForeColor = Color.YellowGreen;
            }

            if (supplyReservePower >= 2500 && supplyReservePower < 3500)
            {
                //주의
                lbl_rate_title.Text = "주의단계";
                pic_supply_reserve_rate.Image = Properties.Resources.rate_caution;
                lbl_rate_title.ForeColor = Color.Gold;
                txt_supp_reserve_rate.ForeColor = Color.Gold;
                lbl_per.ForeColor = Color.Gold;
            }

            if (supplyReservePower >= 1500 && supplyReservePower < 2500)
            {
                //경계
                lbl_rate_title.Text = "경계단계";
                pic_supply_reserve_rate.Image = Properties.Resources.rate_alert;
                lbl_rate_title.ForeColor = Color.Orange;
                txt_supp_reserve_rate.ForeColor = Color.Orange;
                lbl_per.ForeColor = Color.Orange;
            }

            if (supplyReservePower < 1500)
            {
                //심각
                lbl_rate_title.Text = "심각단계";
                pic_supply_reserve_rate.Image = Properties.Resources.rate_serious;
                lbl_rate_title.ForeColor = Color.IndianRed;
                txt_supp_reserve_rate.ForeColor = Color.IndianRed;
                lbl_per.ForeColor = Color.IndianRed;
            }
        }


        //2면: 양양 양수발전 운전현황
        //db: GTA_ALL_STATUS (DCS)
        //pi: 1. 발전호기 및 종합현황
        // G모드, P모드 변경 태그
        string gta01GenStatus = "";      // 1호기 발전(발전상태면 1, 아니면 0) 01GTA_GEN_ST
        string gta01PumpStatus = "";     // 1호기 양수(양수상태면 1, 아니면 0) 01GTA_PUMP_ST
        string gta02GenStatus = "";      // 2호기 발전(발전상태면 1, 아니면 0) 02GTA_GEN_ST
        string gta02PumpStatus = "";     // 2호기 양수(양수상태면 1, 아니면 0) 02GTA_PUMP_ST
        string gta03GenStatus = "";      // 3호기 발전(발전상태면 1, 아니면 0) 03GTA_GEN_ST
        string gta03PumpStatus = "";     // 3호기 양수(양수상태면 1, 아니면 0) 03GTA_PUMP_ST
        string gta04GenStatus = "";      // 4호기 발전(발전상태면 1, 아니면 0) 04GTA_GEN_ST
        string gta04PumpStatus = "";     // 4호기 양수(양수상태면 1, 아니면 0) 04GTA_PUMP_ST

        // 발전량, 양수량 태그
        // 밴 다이어그램으로 사용하되, abs로 절대값으로 0 ~ 250까지만 표현
        // 발전시는 0 ~ 250, 양수시는 -250 ~ 0
        // 발전과 양수는 다른색으로 표현할 것
        double gta01MW = 0.0;            // 01GTA_001UM_05AR33
        double gta02MW = 0.0;            // 02GTA_001UM_05AR33
        double gta03MW = 0.0;            // 03GTA_001UM_05AR33
        double gta04MW = 0.0;            // 04GTA_001UM_05AR33

        // 계통 주파수
        string gridFreq = "";

        // 정비
        string gta01Maint = "";
        string gta02Maint = "";
        string gta03Maint = "";
        string gta04Maint = "";

        // 운전상태 조건
        string gta01DS_pump_close = "";   //양수용 단로기 006
        string gta01DS_gen_close = "";    //발전용 단로기 007
        double gta01RPM = 0.0;
        string gta01UCB_open = "";

        string gta02DS_pump_close = "";   //양수용 단로기 006
        string gta02DS_gen_close = "";    //발전용 단로기 007
        double gta02RPM = 0.0;
        string gta02UCB_open = "";

        string gta03DS_pump_close = "";   //양수용 단로기 006
        string gta03DS_gen_close = "";    //발전용 단로기 007
        double gta03RPM = 0.0;
        string gta03UCB_open = "";

        string gta04DS_pump_close = "";   //양수용 단로기 006
        string gta04DS_gen_close = "";    //발전용 단로기 007
        double gta04RPM = 0.0;
        string gta04UCB_open = "";

        private void timer_get_value_02_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.listBoxViewData02.Items.Count <= 0) { }
                else
                {
                    gta01GenStatus = string.Empty;
                    gta01PumpStatus = string.Empty;
                    gta02GenStatus = string.Empty;
                    gta02PumpStatus = string.Empty;
                    gta03GenStatus = string.Empty;
                    gta03PumpStatus = string.Empty;
                    gta04GenStatus = string.Empty;
                    gta04PumpStatus = string.Empty;

                    gta01MW = 0.0;
                    gta02MW = 0.0;
                    gta03MW = 0.0;
                    gta04MW = 0.0;

                    gta01GenStatus = listBoxViewData02.Items[3].ToString();
                    gta01PumpStatus = listBoxViewData02.Items[4].ToString();
                    gta02GenStatus = listBoxViewData02.Items[12].ToString();
                    gta02PumpStatus = listBoxViewData02.Items[13].ToString();
                    gta03GenStatus = listBoxViewData02.Items[21].ToString();
                    gta03PumpStatus = listBoxViewData02.Items[22].ToString();
                    gta04GenStatus = listBoxViewData02.Items[30].ToString();
                    gta04PumpStatus = listBoxViewData02.Items[31].ToString();

                    gta01MW = double.Parse(listBoxViewData02.Items[2].ToString());
                    gta02MW = double.Parse(listBoxViewData02.Items[11].ToString());
                    gta03MW = double.Parse(listBoxViewData02.Items[20].ToString());
                    gta04MW = double.Parse(listBoxViewData02.Items[29].ToString());

                    gridFreq = String.Empty;
                    gridFreq = listBoxViewData02.Items[1].ToString();

                    gta01Maint = listBoxViewData02.Items[5].ToString();
                    gta02Maint = listBoxViewData02.Items[14].ToString();
                    gta03Maint = listBoxViewData02.Items[23].ToString();
                    gta04Maint = listBoxViewData02.Items[32].ToString();

                    /*
                    //test
                    gta02DS_pump_close = "True";
                    gta02DS_gen_close = "False";
                    gta02RPM = 0.123;
                    gta02UCB_open = "True";
                    */

                    gta01DS_pump_close = listBoxViewData02.Items[6].ToString();
                    gta01DS_gen_close = listBoxViewData02.Items[7].ToString();
                    gta01RPM = double.Parse(listBoxViewData02.Items[8].ToString());
                    gta01UCB_open = listBoxViewData02.Items[9].ToString();

                    gta02DS_pump_close = listBoxViewData02.Items[15].ToString();
                    gta02DS_gen_close = listBoxViewData02.Items[16].ToString();
                    gta02RPM = double.Parse(listBoxViewData02.Items[17].ToString());
                    gta02UCB_open = listBoxViewData02.Items[18].ToString();

                    gta03DS_pump_close = listBoxViewData02.Items[24].ToString();
                    gta03DS_gen_close = listBoxViewData02.Items[25].ToString();
                    gta03RPM = double.Parse(listBoxViewData02.Items[26].ToString());
                    gta03UCB_open = listBoxViewData02.Items[27].ToString();

                    gta04DS_pump_close = listBoxViewData02.Items[33].ToString();
                    gta04DS_gen_close = listBoxViewData02.Items[34].ToString();
                    gta04RPM = double.Parse(listBoxViewData02.Items[35].ToString());
                    gta04UCB_open = listBoxViewData02.Items[36].ToString();

                    SetControls02();
                }
                ChangeMode();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        int gta01MW_1 = 0;            // 01GTA_001UM_05AR33
        int gta02MW_1 = 0;            // 02GTA_001UM_05AR33
        int gta03MW_1 = 0;            // 03GTA_001UM_05AR33
        int gta04MW_1 = 0;            // 04GTA_001UM_05AR33

        public void SetControls02()
        {
            lbl_hz.Text = gridFreq;

            /*

            //1호기 양수모드 test
            if(260>=gta01MW&& gta01MW>=-260)//-240 -230 -220
            {
                if(gta01MW == 0)
                {
                    //test_i = 0;
                    //test_b = true;

                }
                else if (gta01MW == -260)
                {
                    test_i = 1;
                    //test_b = false;                    
                }
                else if (gta01MW == 260)
                {
                    test_i = 2;
                }

                if (test_i == 1)
                {
                    gta01MW += 10;  //-230 -220 -210
                }
                else if (test_i == 2)
                {
                    gta01MW -= 10;  //-230 -220 -210
                }
            }

            */

            /*else if(gta01MW<=0 && gta01MW )//-260 0
            {
                //gta01MW = 250;
                gta01MW -= 10;
            }
            else
            {
                return;
            }*/


            //20230113
            //정비모드
            if (gta01Maint.Equals("True"))
            {
                label2.Visible = false;
                lbl_01gta_M.BringToFront();
                lbl_01gta_M.SetBounds(230, 1838, 200, 68);
                lbl_01gta_M.Visible = true;
            }
            else
            {
                label2.Visible = true;
                lbl_01gta_M.Visible = false;
            }

            if (gta02Maint.Equals("True"))
            {
                label3.Visible = false;
                lbl_02gta_M.BringToFront();
                lbl_02gta_M.SetBounds(657, 1838, 200, 68);
                lbl_02gta_M.Visible = true;
            }
            else
            {
                label3.Visible = true;
                lbl_02gta_M.Visible = false;
            }

            if (gta03Maint.Equals("True"))
            {
                label4.Visible = false;
                lbl_03gta_M.BringToFront();
                lbl_03gta_M.SetBounds(1080, 1838, 200, 68);
                lbl_03gta_M.Visible = true;
            }
            else
            {
                label4.Visible = true;
                lbl_03gta_M.Visible = false;
            }

            if (gta04Maint.Equals("True"))
            {
                label5.Visible = false;
                lbl_04gta_M.BringToFront();
                lbl_04gta_M.SetBounds(1505, 1838, 200, 68);
                lbl_04gta_M.Visible = true;
            }
            else
            {
                label5.Visible = true;
                lbl_04gta_M.Visible = false;
            }

            //절대값으로 변환(소수점 이하 반올림)
            gta01MW_1 = 0;
            gta02MW_1 = 0;
            gta03MW_1 = 0;
            gta04MW_1 = 0;

            gta01MW_1 = Convert.ToInt32(Math.Abs(gta01MW));
            gta02MW_1 = Convert.ToInt32(Math.Abs(gta02MW));
            gta03MW_1 = Convert.ToInt32(Math.Abs(gta03MW));
            gta04MW_1 = Convert.ToInt32(Math.Abs(gta04MW));


            if (gta01MW > 250) { gta01MW = 250; }
            if (gta01MW_1 > 250) { gta01MW_1 = 250; }

            if (gta02MW > 250) { gta02MW = 250; }
            if (gta02MW_1 > 250) { gta02MW_1 = 250; }

            if (gta03MW > 250) { gta03MW = 250; }
            if (gta03MW_1 > 250) { gta03MW_1 = 250; }

            if (gta04MW > 250) { gta04MW = 250; }
            if (gta04MW_1 > 250) { gta04MW_1 = 250; }

            circularProgressBar1.Value = gta01MW_1;
            circularProgressBar2.Value = gta02MW_1;
            circularProgressBar3.Value = gta03MW_1;
            circularProgressBar4.Value = gta04MW_1;


            /*
            Console.WriteLine("#### gta01MW " + gta01MW);
            Console.WriteLine("#### gta02MW " + gta02MW);
            Console.WriteLine("#### gta03MW " + gta03MW);
            Console.WriteLine("#### gta04MW " + gta04MW);

            Console.WriteLine("#### gta01MW_1 " + gta01MW_1);
            Console.WriteLine("#### gta02MW_1 -0.1001232일때 " + gta02MW_1); //0 초록
            Console.WriteLine("#### gta03MW_1  0.1001232일때 " + gta03MW_1); //0 민트
            Console.WriteLine("#### gta04MW_1 " + gta04MW_1);

            Console.WriteLine("#### gta01MW_1 2 " + gta01MW_1);
            Console.WriteLine("#### gta02MW_1 2 " + gta02MW_1);
            Console.WriteLine("#### gta03MW_1 2 " + gta03MW_1);
            Console.WriteLine("#### gta04MW_1 2 " + gta04MW_1);
            */





            /*
            Console.WriteLine("==================================================================");
            Console.WriteLine("################# 1호기 정비: " + gta01Maint);
            Console.WriteLine("################# 2호기 정비: " + gta02Maint);
            Console.WriteLine("################# 3호기 정비: " + gta03Maint);
            Console.WriteLine("################# 4호기 정비: " + gta04Maint);
            */

            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("1호기 양수용 단로기 close: " + gta01DS_pump_close);
            Console.WriteLine("1호기 발전용 단로기 close: " + gta01DS_gen_close);
            Console.WriteLine("1호기 rpm: " + gta01RPM);
            Console.WriteLine("1호기 ucb open: " + gta01UCB_open);

            Console.WriteLine("==================================================");
            Console.WriteLine("2호기 양수용 단로기 close: " + gta02DS_pump_close);
            Console.WriteLine("2호기 발전용 단로기 close: " + gta02DS_gen_close);
            Console.WriteLine("2호기 rpm: " + gta02RPM);
            Console.WriteLine("2호기 ucb open: " + gta02UCB_open);

            Console.WriteLine("==================================================");
            Console.WriteLine("3호기 양수용 단로기 close: " + gta03DS_pump_close);
            Console.WriteLine("3호기 발전용 단로기 close: " + gta03DS_gen_close);
            Console.WriteLine("3호기 rpm: " + gta03RPM);
            Console.WriteLine("3호기 ucb open: " + gta03UCB_open);

            Console.WriteLine("==================================================");
            Console.WriteLine("4호기 양수용 단로기 close: " + gta04DS_pump_close);
            Console.WriteLine("4호기 발전용 단로기 close: " + gta04DS_gen_close);
            Console.WriteLine("4호기 rpm: " + gta04RPM);
            Console.WriteLine("4호기 ucb open: " + gta04UCB_open);
            Console.WriteLine("==================================================");
            */
        }

        public void ChangeMode()
        {
            //1호기 양수
            if (gta01MW < 0)
            {
                txt_01gta_amount.Text = "-" + gta01MW_1.ToString("F0");
                txt_01gta_amount.ForeColor = Color.Lime;
                label2.ForeColor = Color.Lime;
                circularProgressBar1.ProgressColor = Color.Lime;
            }
            if (gta01MW_1 == 0)
            {
                txt_01gta_amount.Text = gta01MW_1.ToString("F0");
                txt_01gta_amount.ForeColor = Color.Aqua;
                label2.ForeColor = Color.Aqua;
                circularProgressBar1.ProgressColor = Color.Transparent;
            }
            if (gta01MW > 0)
            {
                txt_01gta_amount.Text = gta01MW_1.ToString("F0");
                txt_01gta_amount.ForeColor = Color.Aqua;
                label2.ForeColor = Color.Aqua;
                circularProgressBar1.ProgressColor = Color.Aqua;
                
            }
            
            //2호기 양수
            if (gta02MW < 0)
            {
                txt_02gta_amount.Text = "-" + gta02MW_1.ToString("F0");
                txt_02gta_amount.ForeColor = Color.Lime;
                label3.ForeColor = Color.Lime;
                circularProgressBar2.ProgressColor = Color.Lime;
            }
            if (gta02MW_1 == 0)
            {
                txt_02gta_amount.Text = gta02MW_1.ToString("F0");
                txt_02gta_amount.ForeColor = Color.Aqua;
                label3.ForeColor = Color.Aqua;
                circularProgressBar2.ProgressColor = Color.Transparent;
            }
            //2호기 발전
            if (gta02MW > 0)
            {
                txt_02gta_amount.Text = gta02MW_1.ToString("F0");
                txt_02gta_amount.ForeColor = Color.Aqua;
                label3.ForeColor = Color.Aqua;
                circularProgressBar2.ProgressColor = Color.Aqua;
            }

            //3호기 양수
            if (gta03MW < 0)
            {
                txt_03gta_amount.Text = "-" + gta03MW_1.ToString("F0");
                txt_03gta_amount.ForeColor = Color.Lime;
                label4.ForeColor = Color.Lime;
                circularProgressBar3.ProgressColor = Color.Lime;
            }
            if (gta03MW_1 == 0)
            {
                txt_03gta_amount.Text = gta03MW_1.ToString("F0");
                txt_03gta_amount.ForeColor = Color.Aqua;
                label4.ForeColor = Color.Aqua;
                circularProgressBar3.ProgressColor = Color.Transparent;
            }
            //3호기 발전
            if (gta03MW > 0)
            {
                txt_03gta_amount.Text = gta03MW_1.ToString("F0");
                txt_03gta_amount.ForeColor = Color.Aqua;
                label4.ForeColor = Color.Aqua;
                circularProgressBar3.ProgressColor = Color.Aqua;
            }

            //4호기 양수
            if (gta04MW < 0)
            {
                txt_04gta_amount.Text = "-" + gta04MW_1.ToString("F0");
                txt_04gta_amount.ForeColor = Color.Lime;
                label5.ForeColor = Color.Lime;
                circularProgressBar4.ProgressColor = Color.Lime;
            }
            if (gta04MW_1 == 0)
            {
                txt_04gta_amount.Text = gta04MW_1.ToString("F0");
                txt_04gta_amount.ForeColor = Color.Aqua;
                label5.ForeColor = Color.Aqua;
                circularProgressBar4.ProgressColor = Color.Transparent;
            }
            //4호기 발전
            if (gta04MW > 0)
            {
                txt_04gta_amount.Text = gta04MW_1.ToString("F0");
                txt_04gta_amount.ForeColor = Color.Aqua;
                label5.ForeColor = Color.Aqua;
                circularProgressBar4.ProgressColor = Color.Aqua;
            }

            //양수 대기
            if (txt_01gta_amount.Text.Equals("0"))
            {
                if (gta01DS_gen_close.Equals("True") && gta01RPM > 0.0 && gta01UCB_open.Equals("True"))
                {
                    Console.WriteLine("### 1호기 양수 대기");
                    //pic_gta01_p_moving.SetBounds(184, 1692, 285, 285);
                    pic_gta01_p_moving.SetBounds(165, 1674, 320, 320);
                    pic_gta01_p_moving.Visible = true;
                }
                else
                {
                    pic_gta01_p_moving.Visible = false;
                }
            }
            else
            {
                pic_gta01_p_moving.Visible = false;
            }

            if (txt_02gta_amount.Text.Equals("0"))
            {
                if (gta02DS_gen_close.Equals("True") && gta02RPM > 0.0 && gta02UCB_open.Equals("True"))
                {
                    Console.WriteLine("### 2호기 양수 대기");
                    //pic_gta02_p_moving.SetBounds(608, 1692, 285, 285);
                    pic_gta02_p_moving.SetBounds(591, 1674, 320, 320);
                    pic_gta02_p_moving.Visible = true;
                }
                else
                {
                    pic_gta02_p_moving.Visible = false;
                }
            }
            else
            {
                pic_gta02_p_moving.Visible = false;
            }

            if (txt_03gta_amount.Text.Equals("0"))
            {
                if (gta03DS_gen_close.Equals("True") && gta03RPM > 0.0 && gta03UCB_open.Equals("True"))
                {
                    Console.WriteLine("### 3호기 양수 대기");
                    //pic_gta03_p_moving.SetBounds(1034, 1692, 285, 285);
                    pic_gta03_p_moving.SetBounds(1014, 1674, 320, 320);
                    pic_gta03_p_moving.Visible = true;
                }
                else
                {
                    pic_gta03_p_moving.Visible = false;
                }
            }
            else
            {
                pic_gta03_p_moving.Visible = false;
            }

            if (txt_04gta_amount.Text.Equals("0"))
            {
                if (gta04DS_gen_close.Equals("True") && gta04RPM > 0.0 && gta04UCB_open.Equals("True"))
                {
                    Console.WriteLine("### 4호기 양수 대기");
                    pic_gta04_p_moving.SetBounds(1440, 1674, 320, 320);
                    pic_gta04_p_moving.Visible = true;
                }
                else
                {
                    pic_gta04_p_moving.Visible = false;
                }
            }
            else
            {
                pic_gta04_p_moving.Visible = false;
            }

            //발전 대기
            if (txt_01gta_amount.Text.Equals("0"))
            {
                if (gta01DS_pump_close.Equals("True") && gta01RPM > 0.0 && gta01UCB_open.Equals("True"))
                {
                    Console.WriteLine("### 1호기 발전 대기");
                    //pic_gta01_g_moving.SetBounds(184, 1692, 285, 285);
                    pic_gta01_g_moving.SetBounds(165, 1674, 320, 320);
                    pic_gta01_g_moving.Visible = true;
                }
                else
                {
                    pic_gta01_g_moving.Visible = false;
                }
            }
            else
            {
                pic_gta01_g_moving.Visible = false;
            }

            if (txt_02gta_amount.Text.Equals("0"))
            {
                if (gta02DS_pump_close.Equals("True") && gta02RPM > 0.0 && gta02UCB_open.Equals("True"))
                {
                    Console.WriteLine("### 2호기 발전 대기");
                    //pic_gta02_g_moving.SetBounds(608, 1692, 285, 285);
                    pic_gta02_g_moving.SetBounds(591, 1674, 320, 320);
                    pic_gta02_g_moving.Visible = true;
                }
                else
                {
                    pic_gta02_g_moving.Visible = false;
                }
            }
            else
            {
                pic_gta02_g_moving.Visible = false;
            }

            if (txt_03gta_amount.Text.Equals("0"))
            {
                if (gta03DS_pump_close.Equals("True") && gta03RPM > 0.0 && gta03UCB_open.Equals("True"))
                {
                    Console.WriteLine("### 3호기 발전 대기");
                    //pic_gta03_g_moving.SetBounds(1034, 1692, 285, 285);
                    pic_gta03_g_moving.SetBounds(1014, 1674, 320, 320);
                    pic_gta03_g_moving.Visible = true;
                }
                else
                {
                    pic_gta03_g_moving.Visible = false;
                }
            }
            else
            {
                pic_gta03_g_moving.Visible = false;
            }

            if (txt_04gta_amount.Text.Equals("0"))
            {
                if (gta04DS_pump_close.Equals("True") && gta04RPM > 0.0 && gta04UCB_open.Equals("True"))
                {
                    Console.WriteLine("### 4호기 발전 대기");
                    //pic_gta04_g_moving.SetBounds(1454, 1692, 285, 285);
                    pic_gta04_g_moving.SetBounds(1440, 1674, 320, 320);
                    pic_gta04_g_moving.Visible = true;
                }
                else
                {
                    pic_gta04_g_moving.Visible = false;
                }
            }
            else
            {
                pic_gta04_g_moving.Visible = false;
            }

            //발전 완료
            if (gta01DS_gen_close.Equals("True") && gta01UCB_open.Equals("False")) { Console.WriteLine("### 1호기 양수");}
            if (gta02DS_gen_close.Equals("True") && gta02UCB_open.Equals("False")) { Console.WriteLine("### 2호기 양수");}
            if (gta03DS_gen_close.Equals("True") && gta03UCB_open.Equals("False")) { Console.WriteLine("### 3호기 양수");}
            if (gta04DS_gen_close.Equals("True") && gta04UCB_open.Equals("False")) { Console.WriteLine("### 4호기 양수"); }

            //양수 완료
            if (gta01DS_pump_close.Equals("True") && gta01UCB_open.Equals("False")) { Console.WriteLine("### 1호기 발전"); }
            if (gta02DS_pump_close.Equals("True") && gta02UCB_open.Equals("False")) { Console.WriteLine("### 2호기 발전"); }
            if (gta03DS_pump_close.Equals("True") && gta03UCB_open.Equals("False")) { Console.WriteLine("### 3호기 발전"); }
            if (gta04DS_pump_close.Equals("True") && gta04UCB_open.Equals("False")) { Console.WriteLine("### 4호기 발전"); }

            //발전 정지 완료
            if (gta01DS_gen_close.Equals("False") && gta01RPM == 0.0) { Console.WriteLine("### 1호기 양수 정지"); }
            if (gta02DS_gen_close.Equals("False") && gta02RPM == 0.0) { Console.WriteLine("### 2호기 양수 정지"); }
            if (gta03DS_gen_close.Equals("False") && gta03RPM == 0.0) { Console.WriteLine("### 3호기 양수 정지"); }
            if (gta04DS_gen_close.Equals("False") && gta04RPM == 0.0) { Console.WriteLine("### 4호기 양수 정지"); }

            //양수 정지 완료
            if (gta01DS_pump_close.Equals("False") && gta01RPM == 0.0) { Console.WriteLine("### 1호기 발전 정지"); }
            if (gta02DS_pump_close.Equals("False") && gta02RPM == 0.0) { Console.WriteLine("### 2호기 발전 정지"); }
            if (gta03DS_pump_close.Equals("False") && gta03RPM == 0.0) { Console.WriteLine("### 3호기 발전 정지"); }
            if (gta04DS_pump_close.Equals("False") && gta04RPM == 0.0) { Console.WriteLine("### 4호기 발전 정지"); }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

//========================================================================================================

        Random random = new Random();

        //호기별 출력
        int ran_gta01 = 0;
        int ran_gta02 = 0;
        int ran_gta03 = 0;
        int ran_gta04 = 0;

        //전력수급현황
        int ran_sp = 0;         //공급능력
        int ran_cp = 0;         //전력수요(현재 부하)
        int ran_srp = 0;        //공급예비력(공급능력-전력수요)
        double ran_rate = 0.0;  //공급예비율

        //전국 발전소 발전량
        //양수
        int ran_yy_psh = 0;
        int ran_cp_psh = 0;
        int ran_sr_psh = 0;
        int ran_mj_psh = 0;
        int ran_sc_psh = 0;
        int ran_cs_psh = 0;
        int ran_yc_psh = 0;

        //수력
        int ran_hc_hydro = 0;
        int ran_ch_hydro = 0;
        int ran_ua_hydro = 0;
        int ran_cp_hydro = 0;
        int ran_pd_hydro = 0;
        int ran_gr_hydro = 0;
        int ran_cb_hydro = 0;

        //원자력
        int ran_hu_nuc = 0;
        int ran_ws_nuc = 0;
        int ran_su_nuc = 0;
        int ran_gr_nuc = 0;
        int ran_hb_nuc = 0;


        private void timer_random_SRR_Tick(object sender, EventArgs e)
        {
            RandomSP();
            RandomCP();
            RandomSRP();

            //공급예비율 = 공급예비력 / 최대전력수요
            ran_rate = ran_srp / 100;
            txt_supp_reserve_rate.Text = ran_rate.ToString("#.0");

            EmergencyWarningRate();
        }

        //공급능력
        public void RandomSP()
        {
            ran_sp = random.Next(12000, 85000);
            supplyAbility = ran_sp;
            txt_supp_ability.Text = supplyAbility.ToString("#,#");
        }

        //전력수요(현재 부하)
        public void RandomCP()
        {
            ran_cp = random.Next(12000, 70000);
            currentPower = ran_cp;
            txt_curr_pwr.Text = currentPower.ToString("#,#");
        }

        //공급예비력 = 공급능력 - 전력수요(현재 부하)
        public void RandomSRP()
        {
            ran_srp = random.Next(1200, 4000);
            supplyReservePower = ran_srp;
            txt_supp_reserve_pwr.Text = supplyReservePower.ToString("#,#");
        }


        private void timer_random_MW_Tick(object sender, EventArgs e)
        {
            RandomPSH();
            RandomHydro();
            RandomNuc();
        }

        //전국 양수발전소 발전량
        public void RandomPSH()
        {
            ran_yy_psh = random.Next(0, 1000);
            txt_yy_psh_total.Text = ran_yy_psh.ToString("#,#");
            //verticalProgressBar_yy.Value = ran_yy_psh;
            //verticalProgressBar_yy.PerformStep();

            ran_cp_psh = random.Next(0, 400);
            txt_cp_psh_total.Text = ran_cp_psh.ToString();
            //verticalProgressBar_cp.Value = ran_cp_psh;
            //verticalProgressBar_cp.PerformStep();

            ran_sr_psh = random.Next(0, 600);
            txt_sr_psh_total.Text = ran_sr_psh.ToString();
            //verticalProgressBar_sr.Value = ran_sr_psh;
            //verticalProgressBar_sr.PerformStep();

            ran_mj_psh = random.Next(0, 600);
            txt_mj_psh_total.Text = ran_mj_psh.ToString();
            //verticalProgressBar_mj.Value = ran_mj_psh;
            //verticalProgressBar_mj.PerformStep();

            ran_sc_psh = random.Next(0, 700);
            txt_sc_psh_total.Text = ran_sc_psh.ToString();
            //verticalProgressBar_sc.Value = ran_sc_psh;
            //verticalProgressBar_sc.PerformStep();

            ran_cs_psh = random.Next(0, 600);
            txt_cs_psh_total.Text = ran_cs_psh.ToString();
            //verticalProgressBar_cs.Value = ran_cs_psh;
            //verticalProgressBar_cs.PerformStep();

            ran_yc_psh = random.Next(0, 800);
            txt_yc_psh_total.Text = ran_yc_psh.ToString();
            //verticalProgressBar_yc.Value = ran_yc_psh;
            //verticalProgressBar_yc.PerformStep();
        }

        //전국 수력발전소 발전량
        //한수원 웹: 화천, 춘천, 의암, 청평, 팔당, 칠보, 보성강, 괴산, 강림, 강릉
        //DB: 안흥, 춘천, 의암, 화천, 청평, 섬진강, 보성강, 팔당, 괴산  / 칠보, 강림, 강릉
        //디자인: 화천, 춘천, 의암, 청평, 팔당, 강릉, 칠보   / 보성강, 괴산, 강림
        public void RandomHydro()
        {
            ran_hc_hydro = random.Next(10, 108);
            txt_hc_hydro_total.Text = ran_hc_hydro.ToString("#.#0");

            ran_ch_hydro = random.Next(10, 62);      //62.28
            txt_ch_hydro_total.Text = ran_ch_hydro.ToString("#.#0");

            ran_ua_hydro = random.Next(10, 48);
            txt_ua_hydro_total.Text = ran_ua_hydro.ToString("#.#0");

            ran_cp_hydro = random.Next(10, 140);     //140.1
            txt_cp_hydro_total.Text = ran_cp_hydro.ToString("#.#0");

            ran_pd_hydro = random.Next(10, 120);
            txt_pd_hydro_total.Text = ran_pd_hydro.ToString("#.#0");

            //강릉, 칠보는 db에 없음
            ran_gr_hydro = random.Next(10, 82);
            txt_cb_hydro_total.Text = ran_gr_hydro.ToString("#.#0");

            ran_cb_hydro = random.Next(10, 35);      //35.4
            txt_bs_hydro_total.Text = ran_cb_hydro.ToString("#.#0");
        }

        //전국 원자력발전소 발전량
        //고리 4550, 새울 2800, 월성 2100, 신월성 2000, 한빛 5900, 한울 5900
        public void RandomNuc()
        {
            ran_hu_nuc = random.Next(0, 5900);
            txt_hu_nuc_total.Text = ran_hu_nuc.ToString("#,#");

            ran_ws_nuc = random.Next(0, 2100);
            txt_ws_nuc_total.Text = ran_ws_nuc.ToString("#,#");

            ran_su_nuc = random.Next(0, 2800);
            txt_su_nuc_total.Text = ran_su_nuc.ToString("#,#");

            ran_gr_nuc = random.Next(0, 4550);
            txt_gr_nuc_total.Text = ran_gr_nuc.ToString("#,#");

            ran_hb_nuc = random.Next(0, 5900);
            txt_hb_nuc_total.Text = ran_hb_nuc.ToString("#,#");
        }


        private void timer_random_gen_Tick(object sender, EventArgs e)
        {
            ChangeGEN01Value();
            ChangeGEN02Value();
            ChangeGEN03Value();
            ChangeGEN04Value();
        }

        public void ChangeGEN01Value()
        {
            try
            {
                ran_gta01 = random.Next(100, 250);
                circularProgressBar1.Value = ran_gta01;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                ran_gta01 = random.Next(100, 250);
                circularProgressBar1.Value = ran_gta01;
            }

            //txt_yy_gta01_mw.Text = ran_gta01.ToString();
            txt_01gta_amount.Text = ran_gta01.ToString();

            txt_01gta_amount.ForeColor = Color.Aqua;
            label2.ForeColor = Color.Aqua;
            circularProgressBar1.ProgressColor = Color.Aqua;

            circularProgressBar1.PerformStep();
        }

        public void ChangeGEN02Value()
        {
            try
            {
                ran_gta02 = random.Next(100, 250);
                circularProgressBar2.Value = ran_gta02;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                ran_gta02 = random.Next(100, 250);
                circularProgressBar2.Value = ran_gta02;
            }

            //txt_yy_gta02_mw.Text = ran_gta02.ToString();
            txt_02gta_amount.Text = ran_gta02.ToString();

            txt_02gta_amount.ForeColor = Color.Aqua;
            label3.ForeColor = Color.Aqua;
            circularProgressBar2.ProgressColor = Color.Aqua;

            circularProgressBar2.PerformStep();
        }

        public void ChangeGEN03Value()
        {
            try
            {
                ran_gta03 = random.Next(100, 250);
                circularProgressBar3.Value = ran_gta03;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                ran_gta03 = random.Next(100, 250);
                circularProgressBar3.Value = ran_gta03;
            }

            //txt_yy_gta03_mw.Text = ran_gta03.ToString();
            txt_03gta_amount.Text = ran_gta03.ToString();

            txt_03gta_amount.ForeColor = Color.Aqua;
            label4.ForeColor = Color.Aqua;
            circularProgressBar3.ProgressColor = Color.Aqua;

            circularProgressBar3.PerformStep();
        }

        public void ChangeGEN04Value()
        {
            try
            {
                ran_gta04 = random.Next(100, 250);
                circularProgressBar4.Value = ran_gta04;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                ran_gta04 = random.Next(100, 250);
                circularProgressBar4.Value = ran_gta04;
            }

            //txt_yy_gta04_mw.Text = (ran_gta04 * -1).ToString();
            txt_04gta_amount.Text = (ran_gta04 * -1).ToString();

            txt_04gta_amount.ForeColor = Color.Lime;
            label5.ForeColor = Color.Lime;
            circularProgressBar4.ProgressColor = Color.Lime;

            circularProgressBar4.PerformStep();
        }

        private void btn_db_polling_Click(object sender, EventArgs e)
        {
            timer_random_SRR.Enabled = false;
            timer_random_MW.Enabled = false;
            timer_random_gen.Enabled = false;

            timer_get_value_01.Interval = 1000;
            timer_get_value_01.Enabled = true;

            timer_get_value_02.Interval = 1000;
            timer_get_value_02.Enabled = true;
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            timer_get_value_01.Enabled = false;
            timer_get_value_02.Enabled = false;

            timer_random_SRR.Interval = 1000;
            timer_random_SRR.Enabled = true;

            timer_random_MW.Interval = 2000;
            timer_random_MW.Enabled = true;
            
            timer_random_gen.Interval = 1000;
            timer_random_gen.Enabled = true;
        }

    }
}
