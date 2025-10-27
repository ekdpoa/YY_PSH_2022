using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MCRviewLib04
{
    public partial class View04 : Form
    {
        public static string nowMonthandHour = System.DateTime.Now.ToString("MMHHmm");
        string dateTime = DateTime.Now.ToString("yyyy.MM.dd tt hh:mm:ss");
        System.Timers.Timer tm_putOnData = null;
        public View04()
        {
            InitializeComponent();
        }

        private void View04_Load(object sender, EventArgs e)
        {
            //pictureBox9.BringToFront();
            pic_weather.BringToFront();
            //pic_overG_bg.Parent = pictureBox5;
            /*pic_overG_bg.Parent = this;
            pic_overG_bg.BringToFront();
            pictureBox5.Parent = this;*/
            //panel_upper.BringToFront();
            //panel_lower.BringToFront();
            //panel_dam_gate.BringToFront();
            //panel_small_hydro.BringToFront();
            //panel_fish_road.BringToFront();
            
            //label22.BringToFront();
            //label22.Parent = pictureBox7;

            //pic_damOpen_1.BackColor = Color.Transparent;

            string s = string.Empty;
            //proB_overGraph_B.proper

            for (int i = 0; i < 24; i++)
            {
                if (i.ToString().Length == 1)
                {
                    s = "";
                    s = "0" + i.ToString();
                }
                list_spare_DamTime.Add(s + "");
            }

            //pn_overGraph.Parent = picB_bg;
            //pictureBox5.Parent = pic_overG_bg;

            //AI Chart
            initChartSet();
            Init_chartDataSetting();
            Init_chartDataView();

            //chart_DataSetting_repeat();

           /* tm_putOnData = new System.Timers.Timer();
            tm_putOnData.Elapsed += new System.Timers.ElapsedEventHandler(chart_DataSetting_repeat);
            //tm_putOnData.Interval = 600000;
            tm_putOnData.Interval = 1000;
            tm_putOnData.Enabled = true;
            tm_putOnData.Start();*/


            lbl_clock.Text = System.DateTime.Now.ToString("yyyy년 MM월 dd일 HH : mm : ss");
            lbl_clock.BringToFront();
            //lbl_clock.SetBounds(880,71,200,50);

            timer_clock.Interval = 1000;  // 상단 시계
            timer_clock.Enabled = true;

            timer_get_value_07.Interval = 3000;  //배경화면 계절연계
            timer_get_value_07.Enabled = true;

            timer_get_value_04.Interval = 3000; //상하부댐 수계정보
            timer_get_value_04.Enabled = true;

            //timer_get_value_05.Interval = 3000;  //게이트 1~4 , 소수력, 어도
            timer_get_value_05.Interval = 5000;  //게이트 1~4 , 소수력, 어도 20230119
            timer_get_value_05.Enabled = true;



            pictureBox13.Parent = this;
            //pic_overG_bg.Parent = pictureBox12;
        }

        private void timer_clock_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = System.DateTime.Now.ToString("yyyy년 MM월 dd일 HH : mm : ss");
            //ChangeDayNight();
        }


        //=== 차트 시작 ======================================================================================================

        public void prdictGraph(string x, string y, string z, string zz)
        {
            try
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(z);


                /*int i_1 = Convert.ToInt32(x);
                int i_2 = Convert.ToInt32(y);
                int i_3 = Convert.ToInt32(z);
                int i_4 = Convert.ToInt32(zz);*/


                var i1 = Convert.ToDouble(x);
                var i2 = Convert.ToDouble(y);
                var i3 = Convert.ToDouble(z);


                var ii1 = Math.Truncate(i1);
                var ii2 = Math.Truncate(i2);
                var ii3 = Math.Truncate(i3);

                var i_1 = Convert.ToInt32(ii1);
                var i_2 = Convert.ToInt32(ii2);
                var i_3 = Convert.ToInt32(ii3);


                //var i_4 = Convert.ToInt32(zz);



                //최종디자인
                //pictureBox5.SetBounds(100, 130 + ((200 - i_a) * 2), 64, 590 - ((200 - i_a) * 2));
                //pictureBox5.SetBounds(2356, 426 + ((200 - i_a) * 2), 64, 590 - ((200 - i_a) * 2));
                //임시
                //pictureBox5.SetBounds(93, 130 + ((200 - i_a) * 2), 64, 590 - ((200 - i_a) * 2));

                /*pic_11.SetBounds(2799, 1357 + ((150 - i_1) * 2), 41, 577 - ((150 - i_1) * 2));
                pic_12.SetBounds(2943, 1357 + ((150 - i_2) * 2), 41, 577 - ((150 - i_2) * 2));
                pic_13.SetBounds(3075, 1357 + ((150 - i_3) * 2), 41, 577 - ((150 - i_3) * 2));*/
                //pic_11.SetBounds(2809, 1307 + (5200 - i_1) * 2), 41, 577 - ((200 - i_1) * 2));

            }catch(Exception e) { Console.WriteLine(e.ToString()); }


        }

        //ai
        Series s_inflow = new Series("유입량");
        Series s_outflow = new Series("방류량");
        Series s_overD = new Series("초과저수량");
        Series s_overD_Makdae = new Series("막대_초과저수량");

        Series s_prLv = new Series("pr_over");
        Series s_makPrLv = new Series("mak_pr_over");


        Series s_twinkle_1 = new Series("twincle_1");
        Series s_twinkle_2 = new Series("twincle_2");
        Series s_twinkle_3 = new Series("twincle_3");

        Series s_per1 = new Series("1시간 후 개방확률");
        Series s_per3 = new Series("3시간 후 개방확률");
        Series s_per6 = new Series("6시간 후 개방확률");

        //Series s_lowLv = new Series("series2");

        Series s_opPrPer = new Series("OpenPrPer");
        Series s_cloPrPer = new Series("ClosePrPer");



        public void initChartSet()
        {
            s_inflow.ChartType = SeriesChartType.Spline;
            s_outflow.ChartType = SeriesChartType.Spline;
            s_overD.ChartType = SeriesChartType.Spline;

            s_prLv.ChartType = SeriesChartType.Line;
            s_makPrLv.ChartType = SeriesChartType.Column;
            //s_makPrLv.ChartType = SeriesChartType.Bubble;
            //s_prLv.ChartType = SeriesChartType.Radar;//세모
            //s_prLv.EmptyPointStyle = true;
            string[] labels2 = { "now", "1H", "3H", "6H" };

            //s_prLv.ChartType = SeriesChartType.RangeColumn;

            s_cloPrPer.ChartType = SeriesChartType.Column;
            s_opPrPer.ChartType = SeriesChartType.Column;

            s_overD_Makdae.ChartType = SeriesChartType.Column;

            s_twinkle_1.ChartType = SeriesChartType.Point;
            s_twinkle_2.ChartType = SeriesChartType.Point;
            s_twinkle_3.ChartType = SeriesChartType.Point;

            s_inflow.BorderWidth = 5;
            s_outflow.BorderWidth = 5;
            s_overD.BorderWidth = 5;

            s_twinkle_1.BorderWidth = 5;
            s_twinkle_2.BorderWidth = 5;
            s_twinkle_3.BorderWidth = 5;

            s_prLv.BorderWidth = 5;
            s_makPrLv.BorderWidth = 2;
            s_makPrLv.BorderColor = Color.FromArgb(0, 199, 204);
            

            s_cloPrPer.BorderWidth = 2;
            s_opPrPer.BorderWidth = 2;

            s_overD_Makdae.BorderWidth = 5;

            s_inflow.Color = Color.FromArgb(0, 199, 204);
            s_outflow.Color = Color.FromArgb(246, 255, 0);
            //s_overD.Color = Color.FromArgb(236, 8, 208);
            s_overD.Color = Color.FromArgb(255, 91, 220);

            s_twinkle_1.Color = Color.FromArgb(47, 151, 255);
            s_twinkle_2.Color = Color.FromArgb(47, 151, 255);
            s_twinkle_3.Color = Color.FromArgb(47, 151, 255);

            s_prLv.Color = Color.FromArgb(0, 199, 204);
            //s_makPrLv.Color = Color.FromArgb(130, 152, 158);
            s_makPrLv.Color = Color.FromArgb(0, 69, 79);

            s_cloPrPer.Color = Color.FromArgb(0, 199, 204);
            s_opPrPer.Color = Color.FromArgb(0, 199, 204);

            //s_overD_Makdae.Color = Color.FromArgb(236, 8, 208);
            s_overD_Makdae.Color = Color.FromArgb(255, 91, 220);

            cht_damInfo.ChartAreas[0].AxisX.Minimum = 0;
            cht_damInfo.ChartAreas[0].AxisX.Maximum = 23;

            cht_damInfo.ChartAreas[0].AxisY.Minimum = -50;
            cht_damInfo.ChartAreas[0].AxisY.Maximum = 220;


            cht_AI.ChartAreas[0].AxisX.Minimum = 1;
            cht_AI.ChartAreas[0].AxisX.Maximum = 10;

            cht_AI.ChartAreas[0].AxisY.Minimum = 100;
            cht_AI.ChartAreas[0].AxisY.Maximum = 130;


            chart_AI_opPer.ChartAreas[0].AxisY.Minimum = 0;
            chart_AI_opPer.ChartAreas[0].AxisY.Maximum = 100;


            chart_AI_cloPer.ChartAreas[0].AxisX.Minimum = 1;
            chart_AI_cloPer.ChartAreas[0].AxisX.Maximum = 5;

            chart_AI_cloPer.ChartAreas[0].AxisY.Minimum = 0;
            chart_AI_cloPer.ChartAreas[0].AxisY.Maximum = 100;

            //차트 x,y축 글씨 색
            cht_damInfo.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(0, 199, 204);
            cht_damInfo.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            cht_AI.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(0, 199, 204);
            cht_AI.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.FromArgb(0, 20, 25);


            chart_AI_opPer.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(0, 199, 204);
            chart_AI_cloPer.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(0, 199, 204);

            /*chart_AI_Per.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chart_AI_Per.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;*/

            //차트 x,y축 폰트
            cht_damInfo.ChartAreas[0].AxisY.LabelStyle.Font = new Font("맑은 고딕", 16f);
            cht_damInfo.ChartAreas[0].AxisX.LabelStyle.Font = new Font("맑은 고딕", 16f);

            cht_AI.ChartAreas[0].AxisY.LabelStyle.Font = new Font("맑은 고딕", 16f);
            cht_AI.ChartAreas[0].AxisX.LabelStyle.Font = new Font("맑은 고딕", 16f);


            chart_AI_opPer.ChartAreas[0].AxisY.LabelStyle.Font = new Font("맑은 고딕", 16f);
            chart_AI_cloPer.ChartAreas[0].AxisY.LabelStyle.Font = new Font("맑은 고딕", 16f);


            chart_AI_opPer.ChartAreas[0].AxisY.Interval = 20;
            cht_damInfo.ChartAreas[0].AxisX.Interval = 1;

            cht_AI.ChartAreas[0].AxisY.Interval =5;
            cht_AI.ChartAreas[0].AxisX.Interval = 1;
            chart_AI_cloPer.ChartAreas[0].AxisX.Interval = 1;



        }

        List<string> list_inflow = new List<string>();
        List<string> list_outflow = new List<string>();
        List<string> list_overD = new List<string>();

        List<string> list_prLowLv = new List<string>();
        List<string> list_prLowPer = new List<string>();

        List<string> list_DamTime = new List<string>();
        List<string> list_spare_DamTime = new List<string>();

        double inflow = 0.0;
        double outflow = 0.0;
        double overD = 0.0;
        double lowLv = 0.0;

        double per1 = 0.0;
        double per3 = 0.0;
        double per6 = 0.0;

        double op_1 = 0.0;
        double op_2 = 0.0;
        double op_3 = 0.0;

        double clo1 = 0.0;
        double clo2 = 0.0;
        double clo3 = 0.0;


        public void Init_chartDataSetting()
        {
            int lowCnt = 0;
            int allVal = 0;

            //allVal = listBoxViewData10.Items.Count;
            allVal = listBoxViewDataAI.Items.Count;

            //lowCnt = allVal / 16;
            lowCnt = allVal / 19;

            Console.WriteLine("db 모든 데이터: " + allVal);
            Console.WriteLine("행 수 : " + lowCnt);

            list_DamTime.Clear();

            list_overD.Clear();
            list_inflow.Clear();
            list_outflow.Clear();

            list_prLowLv.Clear();
            list_prLowPer.Clear();



            string nowTime_damLv = string.Empty;
            

            if (listBoxViewDataAI.Items.Count < 0) { return; }
            else
            {
                
                try
                {
                    //하부댐 예측한 시간
                    nowTime_damLv = listBoxViewDataAI.Items[2].ToString();

                    //하부댐 수위
                    /*list_prLowLv.Add(listBoxViewData10.Items[2].ToString());
                    list_prLowLv.Add(listBoxViewData10.Items[5].ToString());
                    list_prLowLv.Add(listBoxViewData10.Items[8].ToString());*/

                    //Console.WriteLine(listBoxViewDataAI.Items[4].ToString() + "\n" + listBoxViewDataAI.Items[7].ToString() + "\n" + listBoxViewDataAI.Items[10].ToString());

                    list_prLowLv.Add(listBoxViewDataAI.Items[4].ToString());
                    list_prLowLv.Add(listBoxViewDataAI.Items[7].ToString());
                    list_prLowLv.Add(listBoxViewDataAI.Items[10].ToString());

                    double cvtD1 = 0.0;
                    double cvtD3 = 0.0;
                    double cvtD6 = 0.0;


                    cvtD1 = Convert.ToDouble(listBoxViewDataAI.Items[4].ToString());
                    cvtD3 = Convert.ToDouble(listBoxViewDataAI.Items[7].ToString());
                    cvtD6 = Convert.ToDouble(listBoxViewDataAI.Items[10].ToString());


                    lb_1h_m.Text = "";
                    lb_3h_m.Text = "";
                    lb_6h_m.Text = "";

                    
                    lb_1h_m.Text = Math.Round(cvtD1, 2).ToString();
                    lb_3h_m.Text = Math.Round(cvtD3, 2).ToString();
                    lb_6h_m.Text = Math.Round(cvtD6, 2).ToString();
                        


                    //하부댐 개방 확률
                    string op_temp_1 = string.Empty;
                    //op_temp_1 = listBoxViewData10.Items[3].ToString();
                    op_temp_1 = listBoxViewDataAI.Items[5].ToString();
                    op_1 = Convert.ToDouble(op_temp_1);
                    op_1 = Math.Truncate(op_1);
                    list_prLowPer.Add(op_1.ToString());

                    if (op_1 < 0)
                    {
                        op_1 = 0;
                    }
                    else if (op_1 > 100)
                    {
                        op_1 = 100;
                    }
                    //lb_1open.Text = op_1.ToString() + "%";
                    lb_1open.Text = op_1.ToString();
                    
                    //Console.WriteLine(listBoxViewData10.Items[5].ToString());


                    string op_temp_2 = string.Empty;
                    //op_temp_2 = listBoxViewData10.Items[6].ToString();
                    op_temp_2 = listBoxViewDataAI.Items[8].ToString();
                    op_2 = Convert.ToDouble(op_temp_2);
                    op_2 = Math.Truncate(op_2);
                    list_prLowPer.Add(op_2.ToString());
                    if (op_2 < 0)
                    {
                        op_2 = 0;
                    }
                    else if (op_2 > 100)
                    {
                        op_2 = 100;
                    }
                    //lb_3open.Text = op_2.ToString() + "%";
                    lb_3open.Text = op_2.ToString();
                    
                    //Console.WriteLine(listBoxViewData10.Items[8].ToString());

                    string op_temp_3 = string.Empty;
                    //op_temp_3 = listBoxViewData10.Items[9].ToString();
                    op_temp_3 = listBoxViewDataAI.Items[11].ToString();
                    op_3 = Convert.ToDouble(op_temp_3);
                    op_3 = Math.Truncate(op_3);
                    list_prLowPer.Add(op_3.ToString());
                    if (op_3 < 0)
                    {
                        op_3 = 0;
                    }
                    else if (op_3 > 100)
                    {
                        op_3 = 100;
                    }
                    //lb_6open.Text = op_3.ToString() + "%";
                    lb_6open.Text = op_3.ToString();
                    //Console.WriteLine(listBoxViewData10.Items[11].ToString());



                    //하부댐 폐쇄 확률
                    string clo_temp_1 = string.Empty;
                    //op_temp_3 = listBoxViewData10.Items[9].ToString();
                    clo_temp_1 = listBoxViewDataAI.Items[12].ToString();
                    clo1 = Convert.ToDouble(clo_temp_1);
                    clo1 = Math.Truncate(clo1);
                    list_prLowPer.Add(clo1.ToString());
                    if (clo1 < 0)
                    {
                        clo1 = 0;
                    }
                    else if (clo1 > 100)
                    {
                        clo1 = 100;
                    }



                    string clo_temp_3 = string.Empty;
                    //op_temp_3 = listBoxViewData10.Items[9].ToString();
                    clo_temp_3 = listBoxViewDataAI.Items[13].ToString();
                    clo2 = Convert.ToDouble(clo_temp_3);
                    clo2 = Math.Truncate(clo2);
                    list_prLowPer.Add(clo2.ToString());
                    if (clo2 < 0)
                    {
                        clo2 = 0;
                    }
                    else if (clo2 > 100)
                    {
                        clo2 = 100;
                    }




                    string clo_temp_6 = string.Empty;
                    //op_temp_3 = listBoxViewData10.Items[9].ToString();
                    clo_temp_6 = listBoxViewDataAI.Items[14].ToString();
                    clo3 = Convert.ToDouble(clo_temp_6);
                    clo3 = Math.Truncate(clo3);
                    list_prLowPer.Add(clo3.ToString());
                    if (clo3 < 0)
                    {
                        clo3 = 0;
                    }
                    else if (clo3 > 100)
                    {
                        clo3 = 100;
                    }
                    //

                    //lb_6close.Text = clo3.ToString() + "%";
                    //lb_1close.Text = clo1.ToString() + "%";
                    //lb_3close.Text = clo2.ToString() + "%";
                    
                    lb_1close.Text = clo1.ToString();
                    lb_3close.Text = clo2.ToString();
                    lb_6close.Text = clo3.ToString();

                    


                    int a = 16;
                    //초과저수량 유입량 방류량

                    double d_surP = 0.0;
                    //for (int i = 13; i < listBoxViewData10.Items.Count; i++)
                    if (listBoxViewDataAI.Items.Count < 19 * 6)              //00시 ~ 01시 사이라 데이터가 6개 미만일때
                    {
                        d_surP = 0.0;
                        d_surP = Convert.ToDouble(listBoxViewDataAI.Items[16]);
                        d_surP = d_surP / 10000;
                        list_overD.Add(d_surP.ToString());
                        list_inflow.Add(listBoxViewDataAI.Items[17].ToString());
                        list_outflow.Add(listBoxViewDataAI.Items[18].ToString());
                    }
                    else
                    {
                        
                        while (a < listBoxViewDataAI.Items.Count)
                        {
                            d_surP = 0.0;
                            d_surP = Convert.ToDouble(listBoxViewDataAI.Items[a]);
                            d_surP = d_surP / 10000;
                            list_overD.Add(d_surP.ToString());
                            //Console.WriteLine("초 " + listBoxViewData10.Items[a].ToString());
                            //16
                            a++;

                            list_inflow.Add(listBoxViewDataAI.Items[a].ToString());
                            //Console.WriteLine("유 " + listBoxViewData10.Items[a].ToString());
                            //17
                            a++;

                            list_outflow.Add(listBoxViewDataAI.Items[a].ToString());
                            //Console.WriteLine("방 " + listBoxViewData10.Items[a].ToString());
                            //18
                            a += (19 * 6)-2;
                            //Console.WriteLine("@@@ " + i);
                        }                        
                    }
                    
                    
                    a = 0;
                    
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void Init_chartDataView()
        {
            cht_AI.Series.Clear();
            cht_damInfo.Series.Clear();
            chart_AI_cloPer.Series.Clear();
            chart_AI_opPer.Series.Clear();

            fix_X = 0;
            s_overD.Points.Clear();
            s_outflow.Points.Clear();
            s_inflow.Points.Clear();
            s_twinkle_1.Points.Clear();
            s_twinkle_2.Points.Clear();
            s_twinkle_3.Points.Clear();
            s_overD_Makdae.Points.Clear();


            Console.WriteLine("★\n" + list_overD.Count + "\n" + list_inflow.Count + "\n" + list_outflow.Count + "\n");
            try
            {
                for (int i = 0; i < list_overD.Count; i++)
                {
                    //20221226 16:43  ..jh makdae_overD 주석처리
                    if (i == 0)
                    {
                        //makdae_overD(Convert.ToDouble(list_overD[i]));
                    }

                    fix_X = list_overD.Count - 1;
                    if (list_overD.Count == 1)
                    {
                        s_overD.Points.AddXY(0, Convert.ToDouble(list_overD[i]));
                        s_outflow.Points.AddXY(0, Convert.ToDouble(list_outflow[i]));
                        s_inflow.Points.AddXY(0, Convert.ToDouble(list_inflow[i]));

                        s_twinkle_1.Points.AddXY(0, Convert.ToDouble(list_overD[i]));
                        s_twinkle_2.Points.AddXY(0, Convert.ToDouble(list_outflow[i]));
                        s_twinkle_3.Points.AddXY(0, Convert.ToDouble(list_inflow[i]));
                    }
                    else
                    {
                        s_overD.Points.AddXY(i, Convert.ToDouble(list_overD[i]));
                        s_outflow.Points.AddXY(i, Convert.ToDouble(list_outflow[i]));
                        s_inflow.Points.AddXY(i, Convert.ToDouble(list_inflow[i]));

                        if (i == fix_X)
                        {
                            s_twinkle_1.Points.AddXY(i, Convert.ToDouble(list_overD[i]));
                            s_twinkle_2.Points.AddXY(i, Convert.ToDouble(list_outflow[i]));
                            s_twinkle_3.Points.AddXY(i, Convert.ToDouble(list_inflow[i]));
                        }
                    }
                }

                cht_damInfo.Series.Add(s_outflow);
                cht_damInfo.Series.Add(s_inflow);
                cht_damInfo.Series.Add(s_overD);

                List<string> list_temp = new List<string>();
                /*list_temp.Add("10");
                list_temp.Add("5");
                list_temp.Add("17");*/
                list_temp.Clear();

                s_prLv.Points.Clear();
                s_makPrLv.Points.Clear();

                /*for (int i = 0; i < list_prLowLv.Count; i++)
                {
                    s_prLv.Points.AddXY(i + 2, Convert.ToDouble(list_prLowLv[i]));
                    s_makPrLv.Points.AddXY(i + 2, Convert.ToDouble(list_prLowLv[i]));
                    
                    list_temp.Add(list_prLowLv[i]);

                    i += 2;
                }*/



                s_prLv.Points.AddXY(3, Convert.ToDouble(list_prLowLv[0]));
                s_prLv.Points.AddXY(6, Convert.ToDouble(list_prLowLv[1]));
                s_prLv.Points.AddXY(9, Convert.ToDouble(list_prLowLv[2]));


                s_makPrLv.Points.AddXY(1, 0);
                s_makPrLv.Points.AddXY(2, 0);
                s_makPrLv.Points.AddXY(3, Convert.ToDouble(list_prLowLv[0]));
                s_makPrLv.Points.AddXY(4, 0);
                s_makPrLv.Points.AddXY(5, 0);
                s_makPrLv.Points.AddXY(6, Convert.ToDouble(list_prLowLv[1]));

                s_makPrLv.Points.AddXY(7, 0);
                s_makPrLv.Points.AddXY(8, 0);
                s_makPrLv.Points.AddXY(9, Convert.ToDouble(list_prLowLv[2]));

                s_makPrLv.Points.AddXY(10, 0);


                //s_prLv.Points.AddXY(5, 100);
                list_temp.Add("100");

                //int ch = 0;
                //if (list_temp.Count != 4) { return; }
                //prdictGraph(list_temp[0], list_temp[1], list_temp[2], list_temp[3]);


                cht_AI.Series.Add(s_prLv);
                cht_AI.Series.Add(s_makPrLv);

                s_cloPrPer.Points.Clear();
                s_opPrPer.Points.Clear();
                //실 코드
                if (list_prLowPer.Count < 1) { return; }

                /*var op_1 = Math.Abs(Convert.ToDouble(list_prLowPer[0]));
                var clo_1 = Math.Abs(Convert.ToDouble(list_prLowPer[1]));
                var op_3 = Math.Abs(Convert.ToDouble(list_prLowPer[2]));
                var clo_3 = Math.Abs(Convert.ToDouble(list_prLowPer[3]));
                var op_6 = Math.Abs(Convert.ToDouble(list_prLowPer[4]));
                var clo_6 = Math.Abs(Convert.ToDouble(list_prLowPer[5]));*/





                s_opPrPer.Points.AddXY(1, op_1);
                s_cloPrPer.Points.AddXY(2, clo1);
                /*lb_1open.Text = op_1.ToString() + "%";
                lb_1open.Text = op_1.ToString() + "%";
                lb_1close.Text = clo_1.ToString() + "%";
                lb_1close.Text = clo_1.ToString() + "%";*/

                s_opPrPer.Points.AddXY(2, op_2);
                s_cloPrPer.Points.AddXY(3, clo2);

                if(op_2>79 && op_2 < 100)
                {
                    pic_open_80_1.SetBounds(3332 - 10, 1320+2, 6, 700+30);
                    pic_open_80_2.SetBounds(3332 - 10, 1320+2, 67, 6);
                    pic_open_80_3.SetBounds(3398 - 10, 1320+2, 6, 700+30);
                    pic_open_80_4.SetBounds(3331 - 8, 2021 - 5 + 32, 67, 6);

                    pic_open_80_1.Visible = true;
                    pic_open_80_2.Visible = true;
                    pic_open_80_3.Visible = true;
                    pic_open_80_4.Visible = true;
                    pic_open_80_1.BringToFront();
                    pic_open_80_2.BringToFront();
                    pic_open_80_3.BringToFront();
                    pic_open_80_4.BringToFront();

                    pic_open_100_1.Visible = false;
                    pic_open_100_2.Visible = false;
                    pic_open_100_3.Visible = false;
                    pic_open_100_4.Visible = false;

                    pic_close_80_1.Visible = false;
                    pic_close_80_2.Visible = false;
                    pic_close_80_3.Visible = false;
                    pic_close_80_4.Visible = false;
                        
                    pic_close_100_1.Visible = false;
                    pic_close_100_2.Visible = false;
                    pic_close_100_3.Visible = false;
                    pic_close_100_4.Visible = false;

                }
                else if(op_2 == 100)
                {
                    pic_open_100_1.SetBounds(3332 - 10, 1320+2, 6, 700+30);
                    pic_open_100_2.SetBounds(3332 - 10, 1320+2, 67, 6);
                    pic_open_100_3.SetBounds(3398 - 10, 1320+2, 6, 700+30);
                    pic_open_100_4.SetBounds(3331 - 8, 2021 - 5 + 32, 67, 6);

                    pic_open_80_1.Visible = false;
                    pic_open_80_2.Visible = false;
                    pic_open_80_3.Visible = false;
                    pic_open_80_4.Visible = false;

                    pic_open_100_1.Visible = true;
                    pic_open_100_2.Visible = true;
                    pic_open_100_3.Visible = true;
                    pic_open_100_4.Visible = true;

                    pic_open_100_1.BringToFront();
                    pic_open_100_2.BringToFront();
                    pic_open_100_3.BringToFront();
                    pic_open_100_4.BringToFront();


                    pic_close_80_1.Visible = false;
                    pic_close_80_2.Visible = false;
                    pic_close_80_3.Visible = false;
                    pic_close_80_4.Visible = false;

                    pic_close_100_1.Visible = false;
                    pic_close_100_2.Visible = false;
                    pic_close_100_3.Visible = false;
                    pic_close_100_4.Visible = false;

                }
                else
                {
                    pic_open_80_1.Visible = false;
                    pic_open_80_2.Visible = false;
                    pic_open_80_3.Visible = false;
                    pic_open_80_4.Visible = false;

                    pic_open_100_1.Visible = false;
                    pic_open_100_2.Visible = false;
                    pic_open_100_3.Visible = false;
                    pic_open_100_4.Visible = false;


                }

                //

                if (clo2 > 79 && clo2 < 100)
                {
                    pic_close_80_1.SetBounds(3655, 1323, 6, 700+30);
                    pic_close_80_2.SetBounds(3655, 1323, 67, 6);
                    pic_close_80_3.SetBounds(3721, 1323, 6, 700+30);
                    pic_close_80_4.SetBounds(3654 + 1, 2024 - 4 + 30, 71, 6);


                    pic_close_80_1.Visible = true;
                    pic_close_80_2.Visible = true;
                    pic_close_80_3.Visible = true;
                    pic_close_80_4.Visible = true;

                    pic_close_80_1.BringToFront();
                    pic_close_80_2.BringToFront();
                    pic_close_80_3.BringToFront();
                    pic_close_80_4.BringToFront();

                    pic_close_100_1.Visible = false;
                    pic_close_100_2.Visible = false;
                    pic_close_100_3.Visible = false;
                    pic_close_100_4.Visible = false;


                    pic_open_80_1.Visible = false;
                    pic_open_80_2.Visible = false;
                    pic_open_80_3.Visible = false;
                    pic_open_80_4.Visible = false;

                    pic_open_100_1.Visible = false;
                    pic_open_100_2.Visible = false;
                    pic_open_100_3.Visible = false;
                    pic_open_100_4.Visible = false;


                }
                else if (clo2 == 100)
                {
                    pic_close_100_1.SetBounds(3655, 1323, 6, 700+30);
                    pic_close_100_2.SetBounds(3655, 1323, 67, 6);
                    pic_close_100_3.SetBounds(3721, 1323, 6, 700+30);
                    pic_close_100_4.SetBounds(3654 + 1, 2024 - 4 + 30, 71, 6);


                    pic_close_80_1.Visible = false;
                    pic_close_80_2.Visible = false;
                    pic_close_80_3.Visible = false;
                    pic_close_80_4.Visible = false;

                    pic_close_100_1.Visible = true;
                    pic_close_100_2.Visible = true;
                    pic_close_100_3.Visible = true;
                    pic_close_100_4.Visible = true;

                    pic_close_100_1.BringToFront();
                    pic_close_100_2.BringToFront();
                    pic_close_100_3.BringToFront();
                    pic_close_100_4.BringToFront();

                    pic_open_80_1.Visible = false;
                    pic_open_80_2.Visible = false;
                    pic_open_80_3.Visible = false;
                    pic_open_80_4.Visible = false;

                    pic_open_100_1.Visible = false;
                    pic_open_100_2.Visible = false;
                    pic_open_100_3.Visible = false;
                    pic_open_100_4.Visible = false;
                }
                else
                {
                    


                    pic_close_80_1.Visible = false;
                    pic_close_80_2.Visible = false;
                    pic_close_80_3.Visible = false;
                    pic_close_80_4.Visible = false;

                    pic_close_100_1.Visible = false;
                    pic_close_100_2.Visible = false;
                    pic_close_100_3.Visible = false;
                    pic_close_100_4.Visible = false;
                }




                /*lb_3open.Text = op_3.ToString() + "%";
                lb_3close.Text = clo_3.ToString() + "%";
*/
                s_opPrPer.Points.AddXY(3, op_3);
                s_cloPrPer.Points.AddXY(4, clo3);
                /*lb_6open.Text = op_6.ToString() + "%";
                lb_6close.Text = clo_6.ToString() + "%";
*/



                chart_AI_opPer.Series.Add(s_opPrPer);
                chart_AI_cloPer.Series.Add(s_cloPrPer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }


        //****************************************************************************************************************************차트
        int time_cnt = 0;
        //public void chart_DataSetting_repeat(object sender, ElapsedEventArgs ee)
        public void chart_DataSetting_repeat()
        {
            //list_DamTime.Clear();

            if(list_overD.Count > 23)
            {
                list_overD.Clear();
                list_inflow.Clear();
                list_outflow.Clear();
            }
                                    

            list_prLowLv.Clear();
            list_prLowPer.Clear();


            string nowTime_damLv = string.Empty;

            if (listBoxViewData10.Items.Count < 0) { return; }
            else
            {
                try
                {
                    //하부댐 예측한 시간
                    //nowTime_damLv = listBoxViewDataAI.Items[2].ToString();

                    //하부댐 수위
                    list_prLowLv.Add(listBoxViewData10.Items[4].ToString());
                    list_prLowLv.Add(listBoxViewData10.Items[7].ToString());
                    list_prLowLv.Add(listBoxViewData10.Items[10].ToString());



                    double cvtD1 = 0.0;
                    double cvtD3 = 0.0;
                    double cvtD6 = 0.0;

                    //하부댐 수위 예측
                    cvtD1 = Convert.ToDouble(listBoxViewData10.Items[4].ToString());
                    cvtD3 = Convert.ToDouble(listBoxViewData10.Items[7].ToString());
                    cvtD6 = Convert.ToDouble(listBoxViewData10.Items[10].ToString());


                    lb_1h_m.Text = "";
                    lb_3h_m.Text = "";
                    lb_6h_m.Text = "";


                    lb_1h_m.Text = Math.Round(cvtD1, 2).ToString();
                    lb_3h_m.Text = Math.Round(cvtD3, 2).ToString();
                    lb_6h_m.Text = Math.Round(cvtD6, 2).ToString();




                    //하부댐 개방 확률
                    string op_temp_1 = string.Empty;
                    //op_temp_1 = listBoxViewData10.Items[3].ToString();
                    op_temp_1 = listBoxViewData10.Items[5].ToString();

                    op_1 = 0.0;
                    op_1 = Convert.ToDouble(op_temp_1);
                    op_1 = Math.Truncate(op_1);
                    list_prLowPer.Add(op_1.ToString());

                    if (op_1 < 0)
                    {
                        op_1 = 0;
                    }
                    else if (op_1 > 100)
                    {
                        op_1 = 100;
                    }
                    //lb_1open.Text = op_1.ToString() + "%";
                    lb_1open.Text = op_1.ToString();
                    //Console.WriteLine(listBoxViewData10.Items[5].ToString());


                    string op_temp_2 = string.Empty;
                    //op_temp_2 = listBoxViewData10.Items[6].ToString();
                    op_temp_2 = listBoxViewData10.Items[8].ToString();
                    op_2 = 0.0;
                    op_2 = Convert.ToDouble(op_temp_2);
                    op_2 = Math.Truncate(op_2);
                    list_prLowPer.Add(op_2.ToString());
                    if (op_2 < 0)
                    {
                        op_2 = 0;
                    }
                    else if (op_2 > 100)
                    {
                        op_2 = 100;
                    }
                    //lb_3open.Text = op_2.ToString() + "%";
                    lb_3open.Text = op_2.ToString();
                    //Console.WriteLine(listBoxViewData10.Items[8].ToString());

                    string op_temp_3 = string.Empty;
                    //op_temp_3 = listBoxViewData10.Items[9].ToString();
                    op_temp_3 = listBoxViewData10.Items[11].ToString();

                    op_3 = 0.0;
                    op_3 = Convert.ToDouble(op_temp_3);
                    op_3 = Math.Truncate(op_3);
                    list_prLowPer.Add(op_3.ToString());
                    if (op_3 < 0)
                    {
                        op_3 = 0;
                    }
                    else if (op_3 > 100)
                    {
                        op_3 = 100;
                    }
                    //lb_6open.Text = op_3.ToString() + "%";
                    lb_6open.Text = op_3.ToString();
                    //Console.WriteLine(listBoxViewData10.Items[11].ToString());



                    //하부댐 폐쇄 확률                    
                    clo1 = 0.0;
                    clo2 = 0.0;                   
                    clo3 = 0.0;
                  

                    //하부댐 폐쇄 확률
                    string clo_temp_1 = string.Empty;
                    //op_temp_3 = listBoxViewData10.Items[9].ToString();
                    clo_temp_1 = listBoxViewData10.Items[12].ToString();
                    clo1 = Convert.ToDouble(clo_temp_1);
                    clo1 = Math.Truncate(clo1);
                    list_prLowPer.Add(clo1.ToString());
                    if (clo1 < 0)
                    {
                        clo1 = 0;
                    }
                    else if (clo1 > 100)
                    {
                        clo1 = 100;
                    }



                    string clo_temp_3 = string.Empty;
                    //op_temp_3 = listBoxViewData10.Items[9].ToString();
                    clo_temp_3 = listBoxViewData10.Items[13].ToString();
                    clo2 = Convert.ToDouble(clo_temp_3);
                    clo2 = Math.Truncate(clo2);
                    list_prLowPer.Add(clo2.ToString());
                    if (clo2 < 0)
                    {
                        clo2 = 0;
                    }
                    else if (clo2 > 100)
                    {
                        clo2 = 100;
                    }




                    string clo_temp_6 = string.Empty;
                    //op_temp_3 = listBoxViewData10.Items[9].ToString();
                    clo_temp_6 = listBoxViewData10.Items[14].ToString();
                    clo3 = Convert.ToDouble(clo_temp_6);
                    clo3 = Math.Truncate(clo3);
                    list_prLowPer.Add(clo3.ToString());
                    if (clo3 < 0)
                    {
                        clo3 = 0;
                    }
                    else if (clo3 > 100)
                    {
                        clo3 = 100;
                    }
                    //

                    //lb_1close.Text = clo1.ToString() + "%";
                    //lb_3close.Text = clo2.ToString() + "%";
                    //lb_6close.Text = clo3.ToString() + "%";

                    lb_1close.Text = clo1.ToString();
                    lb_3close.Text = clo2.ToString();
                    lb_6close.Text = clo3.ToString();
                    //





                    int a = 16;



                    //초과저수량 유입량 방류량
                    //for (int i = 13; i < listBoxViewData10.Items.Count; i++)
                    double d_surP = 0.0;
                    
                    //한시간이 되어야 값 계산
                    if(time_cnt == 5)
                    {
                        d_surP = Convert.ToDouble(listBoxViewData10.Items[16]);
                        d_surP = d_surP / 10000;

                        //list_overD.Add(listBoxViewData10.Items[16].ToString());
                        list_overD.Add(d_surP.ToString());
                        list_inflow.Add(listBoxViewData10.Items[17].ToString());
                        list_outflow.Add(listBoxViewData10.Items[18].ToString());
                                                
                        time_cnt = 0;
                    }
                    else
                    {
                        time_cnt++;
                    }

                    Console.WriteLine("※\n" + d_surP + "\n" + listBoxViewData10.Items[17].ToString() + "\n" + listBoxViewData10.Items[18].ToString());

                    putOn_data_repeat();

                    
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }


        //***********************************************************************************************
        //타이머 돌면서 차트에 데이터 뿌리는 함수
        
        public void putOn_data_repeat()
        {

            Invoke((MethodInvoker)delegate
            {
                
                    cht_AI.Series.Clear();
                    cht_damInfo.Series.Clear();
                    chart_AI_cloPer.Series.Clear();
                    chart_AI_opPer.Series.Clear();

                    fix_X = 0;
                    s_overD.Points.Clear();
                    s_outflow.Points.Clear();
                    s_inflow.Points.Clear();
                    s_twinkle_1.Points.Clear();
                    s_twinkle_2.Points.Clear();
                    s_twinkle_3.Points.Clear();
                    s_overD_Makdae.Points.Clear();
                
                

                

            
            

                Console.WriteLine("★★★\n" + list_overD.Count + "\n" + list_inflow.Count + "\n" + list_outflow.Count + "\n");
                try
                {
                    for (int i = 0; i < list_overD.Count; i++)
                    {
                        //20221226 16:43  ..jh makdae_overD 주석처리
                        if (i == 0)
                        {
                            //makdae_overD(Convert.ToDouble(list_overD[i]));
                        }

                        fix_X = list_overD.Count - 1;
                        if (list_overD.Count == 1)
                        {
                            s_overD.Points.AddXY(0, Convert.ToDouble(list_overD[i]));
                            s_outflow.Points.AddXY(0, Convert.ToDouble(list_outflow[i]));
                            s_inflow.Points.AddXY(0, Convert.ToDouble(list_inflow[i]));

                            s_twinkle_1.Points.AddXY(0, Convert.ToDouble(list_overD[i]));
                            s_twinkle_2.Points.AddXY(0, Convert.ToDouble(list_outflow[i]));
                            s_twinkle_3.Points.AddXY(0, Convert.ToDouble(list_inflow[i]));
                        }
                        else
                        {
                            s_overD.Points.AddXY(i, Convert.ToDouble(list_overD[i]));
                            s_outflow.Points.AddXY(i, Convert.ToDouble(list_outflow[i]));
                            s_inflow.Points.AddXY(i, Convert.ToDouble(list_inflow[i]));

                            if (i == fix_X)
                            {
                                s_twinkle_1.Points.AddXY(i, Convert.ToDouble(list_overD[i]));
                                s_twinkle_2.Points.AddXY(i, Convert.ToDouble(list_outflow[i]));
                                s_twinkle_3.Points.AddXY(i, Convert.ToDouble(list_inflow[i]));
                            }
                        }
                    }


                
                    cht_damInfo.Series.Add(s_outflow);
                    cht_damInfo.Series.Add(s_inflow);
                    cht_damInfo.Series.Add(s_overD);

                    List<string> list_temp = new List<string>();
                    /*list_temp.Add("10");
                    list_temp.Add("5");
                    list_temp.Add("17");*/
                    list_temp.Clear();

                    s_prLv.Points.Clear();
                    s_makPrLv.Points.Clear();

                    /*for (int i = 0; i < list_prLowLv.Count; i++)
                    {
                        s_prLv.Points.AddXY(i + 2, Convert.ToDouble(list_prLowLv[i]));
                        s_makPrLv.Points.AddXY(i + 2, Convert.ToDouble(list_prLowLv[i]));
                    
                        list_temp.Add(list_prLowLv[i]);

                        i += 2;
                    }*/



                    s_prLv.Points.AddXY(3, Convert.ToDouble(list_prLowLv[0]));
                    s_prLv.Points.AddXY(6, Convert.ToDouble(list_prLowLv[1]));
                    s_prLv.Points.AddXY(9, Convert.ToDouble(list_prLowLv[2]));


                    s_makPrLv.Points.AddXY(1, 0);
                    s_makPrLv.Points.AddXY(2, 0);
                    s_makPrLv.Points.AddXY(3, Convert.ToDouble(list_prLowLv[0]));
                    s_makPrLv.Points.AddXY(4, 0);
                    s_makPrLv.Points.AddXY(5, 0);
                    s_makPrLv.Points.AddXY(6, Convert.ToDouble(list_prLowLv[1]));

                    s_makPrLv.Points.AddXY(7, 0);
                    s_makPrLv.Points.AddXY(8, 0);
                    s_makPrLv.Points.AddXY(9, Convert.ToDouble(list_prLowLv[2]));

                    s_makPrLv.Points.AddXY(10, 0);


                    //s_prLv.Points.AddXY(5, 100);
                    list_temp.Add("100");

                    //int ch = 0;
                    //if (list_temp.Count != 4) { return; }
                    //prdictGraph(list_temp[0], list_temp[1], list_temp[2], list_temp[3]);


                    cht_AI.Series.Add(s_prLv);
                    cht_AI.Series.Add(s_makPrLv);

                    s_cloPrPer.Points.Clear();
                    s_opPrPer.Points.Clear();
                    //실 코드
                    if (list_prLowPer.Count < 1) { return; }

                    s_opPrPer.Points.AddXY(1, op_1);
                    s_cloPrPer.Points.AddXY(2, clo1);
                    /*lb_1open.Text = op_1.ToString() + "%";
                    lb_1open.Text = op_1.ToString() + "%";
                    lb_1close.Text = clo_1.ToString() + "%";
                    lb_1close.Text = clo_1.ToString() + "%";*/

                    s_opPrPer.Points.AddXY(2, op_2);
                    s_cloPrPer.Points.AddXY(3, clo2);
                    /*lb_3open.Text = op_3.ToString() + "%";
                    lb_3close.Text = clo_3.ToString() + "%";
    */

                    if (op_2 > 79 && op_2 < 100)
                    {
                        pic_open_80_1.SetBounds(3332 - 10, 1320+2, 6, 700+30);
                        pic_open_80_2.SetBounds(3332 - 10, 1320+2, 67, 6);
                        pic_open_80_3.SetBounds(3398 - 10, 1320+2, 6, 700+30);
                        pic_open_80_4.SetBounds(3331 - 8, 2021 - 5 + 32, 67, 6);

                        pic_open_80_1.Visible = true;
                        pic_open_80_2.Visible = true;
                        pic_open_80_3.Visible = true;
                        pic_open_80_4.Visible = true;


                        pic_open_80_1.BringToFront();
                        pic_open_80_2.BringToFront();
                        pic_open_80_3.BringToFront();
                        pic_open_80_4.BringToFront();

                        pic_open_100_1.Visible = false;
                        pic_open_100_2.Visible = false;
                        pic_open_100_3.Visible = false;
                        pic_open_100_4.Visible = false;

                        pic_close_80_1.Visible = false;
                        pic_close_80_2.Visible = false;
                        pic_close_80_3.Visible = false;
                        pic_close_80_4.Visible = false;

                        pic_close_100_1.Visible = false;
                        pic_close_100_2.Visible = false;
                        pic_close_100_3.Visible = false;
                        pic_close_100_4.Visible = false;

                    }
                    else if (op_2 == 100)
                    {
                        pic_open_100_1.SetBounds(3332 - 10, 1320+2, 6, 700+30);
                        pic_open_100_2.SetBounds(3332 - 10, 1320+2, 67, 6);
                        pic_open_100_3.SetBounds(3398 - 10, 1320+2, 6, 700+30);
                        pic_open_100_4.SetBounds(3331 - 8, 2021 - 5 + 32, 67, 6);

                        pic_open_80_1.Visible = false;
                        pic_open_80_2.Visible = false;
                        pic_open_80_3.Visible = false;
                        pic_open_80_4.Visible = false;

                        pic_open_100_1.Visible = true;
                        pic_open_100_2.Visible = true;
                        pic_open_100_3.Visible = true;
                        pic_open_100_4.Visible = true;

                        pic_open_100_1.BringToFront();
                        pic_open_100_2.BringToFront();
                        pic_open_100_3.BringToFront();
                        pic_open_100_4.BringToFront();


                        pic_close_80_1.Visible = false;
                        pic_close_80_2.Visible = false;
                        pic_close_80_3.Visible = false;
                        pic_close_80_4.Visible = false;

                        pic_close_100_1.Visible = false;
                        pic_close_100_2.Visible = false;
                        pic_close_100_3.Visible = false;
                        pic_close_100_4.Visible = false;

                    }
                    else
                    {
                        pic_open_80_1.Visible = false;
                        pic_open_80_2.Visible = false;
                        pic_open_80_3.Visible = false;
                        pic_open_80_4.Visible = false;

                        pic_open_100_1.Visible = false;
                        pic_open_100_2.Visible = false;
                        pic_open_100_3.Visible = false;
                        pic_open_100_4.Visible = false;
                                                
                    }

                    //

                    if (clo2 > 79 && clo2 < 100)
                    {
                        pic_close_80_1.SetBounds(3655, 1323, 6, 700+30);
                        pic_close_80_2.SetBounds(3655, 1323, 67, 6);
                        pic_close_80_3.SetBounds(3721, 1323, 6, 700+30);
                        pic_close_80_4.SetBounds(3654 + 1, 2024 - 4 + 30, 71, 6);


                        pic_close_80_1.Visible = true;
                        pic_close_80_2.Visible = true;
                        pic_close_80_3.Visible = true;
                        pic_close_80_4.Visible = true;


                        pic_close_80_1.BringToFront();
                        pic_close_80_2.BringToFront();
                        pic_close_80_3.BringToFront();
                        pic_close_80_4.BringToFront();

                        pic_close_100_1.Visible = false;
                        pic_close_100_2.Visible = false;
                        pic_close_100_3.Visible = false;
                        pic_close_100_4.Visible = false;


                        pic_open_80_1.Visible = false;
                        pic_open_80_2.Visible = false;
                        pic_open_80_3.Visible = false;
                        pic_open_80_4.Visible = false;

                        pic_open_100_1.Visible = false;
                        pic_open_100_2.Visible = false;
                        pic_open_100_3.Visible = false;
                        pic_open_100_4.Visible = false;


                    }
                    else if (clo2 == 100)
                    {
                        pic_close_100_1.SetBounds(3655, 1323, 6, 700+30);
                        pic_close_100_2.SetBounds(3655, 1323, 67, 6);
                        pic_close_100_3.SetBounds(3721, 1323, 6, 700+30);
                        pic_close_100_4.SetBounds(3654 + 1, 2024 - 4 + 30, 71, 6);


                        pic_close_80_1.Visible = false;
                        pic_close_80_2.Visible = false;
                        pic_close_80_3.Visible = false;
                        pic_close_80_4.Visible = false;

                        pic_close_100_1.Visible = true;
                        pic_close_100_2.Visible = true;
                        pic_close_100_3.Visible = true;
                        pic_close_100_4.Visible = true;

                        pic_close_100_1.BringToFront();
                        pic_close_100_2.BringToFront();
                        pic_close_100_3.BringToFront();
                        pic_close_100_4.BringToFront();


                        pic_open_80_1.Visible = false;
                        pic_open_80_2.Visible = false;
                        pic_open_80_3.Visible = false;
                        pic_open_80_4.Visible = false;

                        pic_open_100_1.Visible = false;
                        pic_open_100_2.Visible = false;
                        pic_open_100_3.Visible = false;
                        pic_open_100_4.Visible = false;
                    }
                    else
                    {
                      

                        pic_close_80_1.Visible = false;
                        pic_close_80_2.Visible = false;
                        pic_close_80_3.Visible = false;
                        pic_close_80_4.Visible = false;

                        pic_close_100_1.Visible = false;
                        pic_close_100_2.Visible = false;
                        pic_close_100_3.Visible = false;
                        pic_close_100_4.Visible = false;
                    }










                    s_opPrPer.Points.AddXY(3, op_3);
                    s_cloPrPer.Points.AddXY(4, clo3);

                    

                    chart_AI_opPer.Series.Add(s_opPrPer);
                    chart_AI_cloPer.Series.Add(s_cloPrPer);
            
                }
                
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            });
        }

        int fix_X = 0;

        

        private void tm_get_damInfo_Tick(object sender, EventArgs e)
        {
            chart_DataSetting_repeat();
            //Init_chartDataSetting();
            //chart_DataSetting_repeat();

        }

        private void tm_get_AIinfo_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("TICK");
            //chartDataSettingAI();
        }


        // 차트 랜덤값
        Random r = new Random();

        public void testValue()
        {
            list_inflow.Clear();
            list_outflow.Clear();
            list_overD.Clear();
            list_prLowLv.Clear();
            try
            {
                string nowDt = string.Empty;
                nowDt = DateTime.Now.ToString("yyyyMMddHHmmss");
                string h_nowDt = string.Empty;
                h_nowDt = nowDt.Substring(8, 2);
                int int_nowDt = Convert.ToInt32(h_nowDt);

                //하부댐 수위/개방-폐쇄확률
                
                int i = 0;
                while (i < 3)
                {
                    int prLowLv = 0;
                    prLowLv = r.Next(80, 135);
                    list_prLowLv.Add(prLowLv.ToString());
                    i++;
                    //Console.WriteLine("@@"+prLowLv.ToString());
                    int opP = 0;
                    int clP = 0;
                    if (prLowLv > 120)
                    {
                        //int lowLvPer = 0;
                        opP = r.Next(85, 100);
                        list_prLowPer.Add(opP + "");
                        clP = opP - 100;
                        list_prLowPer.Add(clP + "");
                    }
                    else if (prLowLv < 100)
                    {
                        opP = 0;
                        opP = r.Next(0, 13);
                        list_prLowPer.Add(opP + "");
                        clP = opP + 87;
                        list_prLowPer.Add(clP + "");
                    }
                    else
                    {
                        opP = r.Next(14, 84);
                        list_prLowPer.Add(opP + "");
                        clP = Math.Abs(opP - 50);
                        list_prLowPer.Add(clP + "");
                    }
                    //Console.WriteLine("@@ " + opP + "\n@@ " + clP);

                }
                //Console.WriteLine("@ "+ list_prLowLv.Count);
                //..
                for (int ii = 0; ii < int_nowDt+1; ii++)
                {
                    if(int_nowDt == 0)
                    {
                        int ovD1 = r.Next(-100, 200);
                        list_overD.Add(ovD1 + "");
                        list_overD.Add(ovD1 + "");

                        int inFlow1 = r.Next(-35, 50);
                        list_inflow.Add(inFlow1 + "");
                        list_inflow.Add(inFlow1 + "");

                        int outF1 = r.Next(1, 60);
                        list_outflow.Add(outF1 + "");
                        list_outflow.Add(outF1 + "");
                    }
                    else
                    {
                        int ovD = r.Next(-100, 200);
                        list_overD.Add(ovD + "");

                        int inFlow = r.Next(-35, 50);
                        list_inflow.Add(inFlow + "");

                        int outF = r.Next(1, 60);
                        list_outflow.Add(outF + "");
                    }
                    
                    
                }

                /*Console.WriteLine(list_overD.Count)  ;
                Console.WriteLine(list_inflow.Count) ;
                Console.WriteLine(list_outflow.Count);*/
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
        }



        //=== 차트 끝 ======================================================================================================


        //날씨, 주야, 계절별 산 이미지 변경
        int dayStart = 0;         //주간 시작시간
        int dayEnd = 0;           //주간 종료시간 
        int nightStart = 0;       //야간 시작시간
        int nightEnd = 0;         //야간 종료시간

        int springStart = 0;      //봄 시작 월
        int springEnd = 0;        //봄 종료 월
        int summerStart = 0;      //여름 시작 월
        int summerEnd = 0;        //여름 종료 월
        int autumnStart = 0;      //가을 시작 월
        int autumnEnd = 0;        //가을 종료 월
        int winterStart = 0;      //겨울 시작 월
        int winterEnd = 0;        //겨울 종료 월

        string sunCloud = null;         //하늘상태(1 맑음, 2 구름많음, 4 흐림) SKY
        string rainSnow = null;         //강수형태(0 없음, 1 비, 2 비 또는 눈, 3 눈, 4 소나기) POP
        string lowestTemp = null;       //일 최저기온 TMN
        string highestTemp = null;      //일 최고기온 TMP
        string rainfall = null;         //1시간 강수량 PCP


        private void timer_get_value_07_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.listBoxViewData07.Items.Count <= 0) { }
                else
                {
                    dayStart = int.Parse(listBoxViewData07.Items[1].ToString().Substring(1, 1));
                    dayEnd = int.Parse(listBoxViewData07.Items[2].ToString().Substring(0, 2));
                    nightStart = int.Parse(listBoxViewData07.Items[3].ToString().Substring(0, 2));
                    nightEnd = int.Parse(listBoxViewData07.Items[4].ToString().Substring(1, 1));

                    springStart = int.Parse(listBoxViewData07.Items[5].ToString());
                    springEnd = int.Parse(listBoxViewData07.Items[6].ToString());
                    summerStart = int.Parse(listBoxViewData07.Items[7].ToString());
                    summerEnd = int.Parse(listBoxViewData07.Items[8].ToString());
                    autumnStart = int.Parse(listBoxViewData07.Items[9].ToString());
                    autumnEnd = int.Parse(listBoxViewData07.Items[10].ToString());
                    winterStart = int.Parse(listBoxViewData07.Items[11].ToString());
                    winterEnd = int.Parse(listBoxViewData07.Items[12].ToString());

                    sunCloud = listBoxViewData07.Items[15].ToString();
                    rainSnow = listBoxViewData07.Items[16].ToString();
                    lowestTemp = listBoxViewData07.Items[17].ToString();
                    highestTemp = listBoxViewData07.Items[18].ToString();
                    rainfall = listBoxViewData07.Items[19].ToString();

                    ChangeWeather();
                    //ChangeDayNight();
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(dateTime + " ### 날씨 정보 db polling 종료");
                //timer_get_value_07.Enabled = false;
                //timer_get_value_04.Enabled = false;
                //timer_get_value_05.Enabled = false;

                //pic_weather.Image = Bitmap.FromFile("img\\v4_weather_sunny.png");
                //this.BackgroundImage = Image.FromFile("img\\autumn_day.png");
            }
        }

        //db: SHORT_FCST
        public void ChangeWeather()
        {
            try
            {
                //맑음 sky1
                if (sunCloud.Equals("1"))
                {
                    //pic_weather.Image = Bitmap.FromFile("img\\v4_weather_sunny.png");
                    pic_weather.Image = Properties.Resources.v4_weather_sunny;
                }

                //구름많음 sky3
                if (sunCloud.Equals("2"))
                {
                    //pic_weather.Image = Bitmap.FromFile("img\\v4_weather_little_cloudy.png");
                    pic_weather.Image = Properties.Resources.v4_weather_little_cloudy;
                }

                //흐림 sky4
                if (sunCloud.Equals("4"))
                {
                    //pic_weather.Image = Bitmap.FromFile("img\\v4_weather_cloudy.png");
                    pic_weather.Image = Properties.Resources.v4_weather_cloudy;
                }

                //비 pty1
                if (rainSnow.Equals("1") || rainSnow.Equals("4"))
                {
                    //pic_weather.Image = Bitmap.FromFile("img\\v4_weather_rain.png");
                    pic_weather.Image = Properties.Resources.v4_weather_rain;
                }

                //눈 pty3
                if (rainSnow.Equals("3"))
                {
                    //pic_weather.Image = Bitmap.FromFile("img\\v4_weather_snow.png");
                    pic_weather.Image = Properties.Resources.v4_weather_snow;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //pic_weather.Image = Bitmap.FromFile("img\\v4_weather_sunny.png");
                pic_weather.Image = Properties.Resources.v4_weather_sunny;
            }
        }


        int currentMonth = int.Parse(nowMonthandHour.Substring(0, 2));
        int currentHour = int.Parse(nowMonthandHour.Substring(2, 2));
        int currentMinute = int.Parse(nowMonthandHour.Substring(4, 2));

        //db: SETTING_TERM
        public void ChangeDayNight()
        {
            /*
            Console.WriteLine("========================");
            Console.WriteLine("#### 현재 월: " + currentMonth);
            Console.WriteLine("#### 현재 시간: " + currentHour);
            Console.WriteLine("주간 시작: " + dayStart);
            Console.WriteLine("주간 끝: " + dayEnd);
            Console.WriteLine("야간 시작: " + nightStart);
            Console.WriteLine("야간 끝: " + nightEnd);
            Console.WriteLine("========================");
            */

            try
            {
                //봄 낮밤
                if (currentMonth >= springStart && currentMonth <= springEnd)
                {
                    //Console.WriteLine("#### 봄");
                    if (currentHour >= dayStart && currentHour <= dayEnd)
                    {
                        //this.BackgroundImage = Image.FromFile("img\\spring_day.png");
                        this.BackgroundImage = Properties.Resources.spring_day;
                    }
                    else
                    {
                        //this.BackgroundImage = Image.FromFile("img\\spring_night.png");
                        this.BackgroundImage = Properties.Resources.spring_night;
                    }
                }

                //여름 낮밤
                if (currentMonth >= summerStart && currentMonth <= summerEnd)
                {
                    //Console.WriteLine("### 여름");
                    if (currentHour >= dayStart && currentHour <= dayEnd)
                    {
                        //this.BackgroundImage = Image.FromFile("img\\summer_day.png");
                        this.BackgroundImage = Properties.Resources.summer_day;
                    }
                    else
                    {
                        //this.BackgroundImage = Image.FromFile("img\\summer_night.png");
                        this.BackgroundImage = Properties.Resources.summer_night;
                    }
                }

                //가을 낮밤
                if (currentMonth >= autumnStart && currentMonth <= autumnEnd)
                {
                    //Console.WriteLine("### 가을");
                    if (currentHour >= dayStart && currentHour <= dayEnd)
                    {
                        //this.BackgroundImage = Image.FromFile("img\\autumn_day.png");
                        this.BackgroundImage = Properties.Resources.autumn_day;
                    }
                    else
                    {
                        //this.BackgroundImage = Image.FromFile("img\\autumn_night.png");
                        this.BackgroundImage = Properties.Resources.autumn_night;
                    }
                }

                //겨울 낮밤
                if (currentMonth >= winterStart && currentMonth <= winterEnd)
                {
                    //Console.WriteLine("### 겨울");
                    if (currentHour >= dayStart && currentHour <= dayEnd)
                    {
                        this.BackgroundImage = Properties.Resources.winter_day;
                        //this.BackgroundImage = Image.FromFile("img\\winter_day.png");
                    }
                    else
                    {
                        //this.BackgroundImage = Image.FromFile("img\\winter_night.png");
                        this.BackgroundImage = Properties.Resources.winter_night;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //this.BackgroundImage = Image.FromFile("img\\autumn_day.png");
                this.BackgroundImage = Properties.Resources.autumn_day;
            }
        }


        //4면: 상하부댐 현황
        //db: HYDRO_OPERATION (DCS)
        //pi: 4. 상부댐 및 하부댐, 6. 수계운영 -> 10분 태그들만 사용함
        double upperCurrentLevel = 0.0;     // 상부댐 수위 UR_SELECLVL_16AR (6번 시트)
        double upperRainfall10 = 0.0;       // 상부댐 10분 강수량 31KMH_RAINFALL_10MIN
        double upperTemp = 0.0;             // 상부댐 제어실 온도 31HVA_TEMP_017AR
        //double upperHumidity = 0.0;         // 상부댐 습도 31HVA_HUM_018AR

        double lowerCurrentLevel = 0.0;     // 하부댐 수위 41KMH_001LVL_16AR
        double lowerRainfall10 = 0.0;       // 하부댐 10분 강수량 41KMH_RAINFALL_10MIN
        double lowerTemp = 0.0;             // 하부댐 제어실 온도 41HVA_TEMP_017AR (추정)
        //double lowerHumidity = 0.0;         // 하부댐 습도 41HVA_HUM_018AR

        double lowerTotalInflow10 = 0.0;      // * 하부댐 10분 총 유입량 41HVA_10MIN_INFLOW (int)
        double lowerTotalOutflow10 = 0.0;   // 하부댐 10분 총 방류량(소수력+어도+여수로+농업용수) 41HVA_10MIN_OUTFLOW
        double lowerTotalInflow1Hour = 0.0;      // * 하부댐 1시간 총 유입량 41HVA_10HOUR_INFLOW (int)  //20230119 추가

        double lowerCurrentVolumn = 0.0;             // * 하부댐 저수량 41KMH_VOLUMN_15AR (int)
        double lowerCurrentSurplusVolumn = 0.0;      // * 하부댐 현재 초과저수량 SURPLUS_VOLUMN_15AR (int)

        int lowerCurrentVolumn_a = 0;
        int lowerCurrentSurplusVolumn_a = 0;
        //20221226_jh
        double upperCurrentVolumn = 0.0;        // 상부댐 저수량 수치값 추가

        private void timer_get_value_04_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.listBoxViewData04.Items.Count <= 0) { }
                else
                {
                    upperCurrentLevel = double.Parse(listBoxViewData04.Items[1].ToString());
                    upperRainfall10 = double.Parse(listBoxViewData04.Items[2].ToString());
                    upperTemp = double.Parse(listBoxViewData04.Items[3].ToString());
                    //upperHumidity = double.Parse(listBoxViewData04.Items[4].ToString());

                    lowerCurrentLevel = double.Parse(listBoxViewData04.Items[4].ToString());
                    lowerRainfall10 = double.Parse(listBoxViewData04.Items[5].ToString());
                    lowerTemp = double.Parse(listBoxViewData04.Items[6].ToString());
                    //lowerHumidity = double.Parse(listBoxViewData04.Items[8].ToString());

                    lowerTotalInflow10 = double.Parse(listBoxViewData04.Items[7].ToString());
                    lowerTotalOutflow10 = double.Parse(listBoxViewData04.Items[8].ToString());

                    lowerCurrentVolumn = double.Parse(listBoxViewData04.Items[9].ToString());
                    lowerCurrentSurplusVolumn = double.Parse(listBoxViewData04.Items[10].ToString());

                    //20221226_jh
                    upperCurrentVolumn = double.Parse(listBoxViewData04.Items[11].ToString());

                    //20230119 하부댐 1시간 유입량 추가
                    lowerTotalInflow1Hour = double.Parse(listBoxViewData04.Items[12].ToString());

                    SetControls04();
                }
                //LowerOverflowLevel();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine(dateTime + " ### 상하부댐 정보 db polling 종료");
                //timer_get_value_07.Enabled = false;
                //timer_get_value_04.Enabled = false;
                //timer_get_value_05.Enabled = false;

                //timer_random_dam.Interval = 1000;
                //Console.WriteLine(dateTime + " ### 상하부댐 정보 랜덤모드 시작");
                //timer_random_dam.Enabled = true;
            }
        }

        public void SetControls04()
        {
            lbl_upper_cur_level.Text = upperCurrentLevel.ToString("F2");

            //20221226_jh
            lbl_cur_upper_volumn.Text = (upperCurrentVolumn/10000).ToString("F1");
            //....

            lbl_upper_rainfall_10.Text = upperRainfall10.ToString("F1");
            lbl_upper_temp.Text = upperTemp.ToString("F1");
            //lbl_upper_humidity.Text = upperHumidity.ToString("F");

            lbl_lower_cur_level.Text = lowerCurrentLevel.ToString("F2");
            lbl_lower_rainfall.Text = lowerRainfall10.ToString("F1");
            lbl_lower_temp.Text = lowerTemp.ToString("F1");
            //lbl_lower_humidity.Text = lowerHumidity.ToString("F");

            lbl_lower_inflow_10.Text = lowerTotalInflow10.ToString("F1");
            lbl_lower_outflow_10.Text = lowerTotalOutflow10.ToString("F1");

            //lowerCurrentVolumn_a = Convert.ToInt32(lowerCurrentVolumn);
            //lowerCurrentSurplusVolumn_a = Convert.ToInt32(lowerCurrentSurplusVolumn);

            lbl_cur_lower_volumn.Text = (lowerCurrentVolumn / 10000).ToString("F1");
            lbl_lower_cur_surplus_volumn.Text = (lowerCurrentSurplusVolumn / 10000).ToString("F1");

            //20230119 하부댐 1시간 유입량 추가
            lbl_lower_inflow_1_hour.Text = lowerTotalInflow1Hour.ToString("F1");

            //잉여수량 막대그래프 표출 20221226    16:43 ..jh
            double d_makdae = 0.0;
            d_makdae = Convert.ToDouble(lbl_lower_cur_surplus_volumn.Text);
            makdae_overD(d_makdae);

            //lbl_cur_lower_volumn.Text = lowerCurrentVolumn.ToString("F");
            //lbl_lower_cur_surplus_volumn.Text = lowerCurrentSurplusVolumn.ToString("F");
        }

        //public void makdae_overD(double a)
        public void makdae_overD(double a)
        {
            
            int i_a = Convert.ToInt32(Math.Truncate(a));            
            if (i_a > 150)
            {
                pictureBox5.BackColor = Color.FromArgb(255, 91, 220);
            }
            else
            {
                pictureBox5.BackColor = Color.Aqua;
            }
            
            //최종디자인
            //pictureBox5.SetBounds(100, 130 + ((200 - i_a) * 2), 64, 590 - ((200 - i_a) * 2));
            pictureBox5.SetBounds(2356, 426 + ((205 - i_a) * 2), 64, 590 - ((205 - i_a) * 2));
            //임시
            //pictureBox5.SetBounds(93, 130 + ((200 - i_a) * 2), 64, 590 - ((200 - i_a) * 2));
        }

        //5면: 하부댐 여수로, 소수력, 어도
        //db: ALL_HYDRO_ROAD (DCS)
        //pi: 4. 상부댐 및 하부댐
        //1) 하부댐 여수로
        double gate01_opening = 0.0;        //1번 개도 41HVA_301VN_011AR2
        double gate01_outflow = 0.0;        //1번 방류량 41HVA_301VN_OUTFLOW
        double gate02_opening = 0.0;        //2번 개도 41HVA_302VN_011AR2
        double gate02_outflow = 0.0;        //2번 방류량 41HVA_302VN_OUTFLOW
        double gate03_opening = 0.0;        //3번 개도 41HVA_303VN_011AR2
        double gate03_outflow = 0.0;        //3번 방류량 41HVA_303VN_OUTFLOW
        double gate04_opening = 0.0;        //4번 개도 41HVA_304VN_011AR2
        double gate04_outflow = 0.0;        //4번 방류량 41HVA_304VN_OUTFLOW

        //2)어도
        //double fishLevel = 0.0;             //어도 수위 402HVA_F101_016AR
        double fish101_open = 0.0;          //101VN 개도 42HVA_ZIT_101VN
        double fish101_outflow = 0.0;       //101VN 방류량 42HVA_FQIT101_SEC
        //double fish201_open = 0.0;          //201VN 개도 42HVA_ZIT_201VN
        //double fish201_outflow = 0.0;       //201VN 방류량 42HVA_FQIT201_SEC
        //double fish301_open = 0.0;          //301VN 개도 42HVA_ZIT_301VN
        //double fish301_outflow = 0.0;       //301VN 방류량 42HVA_FQIT301_SEC
        double fish401_open = 0.0;          //401VN 개도 42HVA_ZIT_401VN
        double fish401_outflow = 0.0;       //401VN 방류량 42HVA_FQIT401_SEC
        double fish501_open = 0.0;          //501VN 개도 42HVA_ZIT_501VN
        double fish501_outflow = 0.0;       //501VN 방류량 42HVA_FQIT501_SEC
        //int fish601_fullOpen = 0;           //601VN FULL OPEN 42HVA_601VN_160DR (full open일 때 1, 아닐 때 0)
        //int fish601_fullClose = 0;          //601VN FULL CLOSE 42HVA_601VN_021DR (full close일 때 1, 아닐 때 0)

        //3) 소수력
        //1호기
        double smallHydro01_kw = 0.0;         //출력 41GTA_GCP1_AP_05AR
        double smallHydro01_outflow = 0.0;    //방류량
        //double smallHydro01_kv = 0.0;       //전압 41GTA_GCP1_V_R_04AR
        //double smallHydro01_a = 0.0;        //전류 41GTA_GCP1_C_R_03AR
        //double smallHydro01_cos = 0.0;      //역률 41GTA_GCP1_PF_01AR

        //2호기
        double smallHydro02_kw = 0.0;         //출력 42GTA_GCP1_AP_05AR
        double smallHydro02_outflow = 0.0;    //방류량
        //double smallHydro02_kv = 0.0;       //전압 42GTA_GCP1_V_R_04AR
        //double smallHydro02_a = 0.0;        //전류 42GTA_GCP1_C_R_03AR
        //double smallHydro02_cos = 0.0;      //역률 42GTA_GCP1_PF_01AR

        //3호기
        double smallHydro03_kw = 0.0;         //출력 43GTA_GCP1_AP_05AR
        double smallHydro03_outflow = 0.0;    //방류량
        //double smallHydro03_kv = 0.0;       //전압 43GTA_GCP1_V_R_04AR
        //double smallHydro03_a = 0.0;        //전류 43GTA_GCP1_C_R_03AR
        //double smallHydro03_cos = 0.0;      //역률 43GTA_GCP1_PF_01AR


        private void timer_get_value_05_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.listBoxViewData05.Items.Count <= 0) { }
                else
                {
                    //하부댐 여수로 
                    gate01_opening = double.Parse(listBoxViewData05.Items[1].ToString());
                    gate01_outflow = double.Parse(listBoxViewData05.Items[2].ToString());
                    gate02_opening = double.Parse(listBoxViewData05.Items[3].ToString());
                    gate02_outflow = double.Parse(listBoxViewData05.Items[4].ToString());
                    gate03_opening = double.Parse(listBoxViewData05.Items[5].ToString());
                    gate03_outflow = double.Parse(listBoxViewData05.Items[6].ToString());
                    gate04_opening = double.Parse(listBoxViewData05.Items[7].ToString());
                    gate04_outflow = double.Parse(listBoxViewData05.Items[8].ToString());

                    //소수력
                    smallHydro01_kw = double.Parse(listBoxViewData05.Items[9].ToString());
                    //Console.WriteLine("소수력1호기 출력 " + smallHydro01_kw);
                    smallHydro01_outflow = double.Parse(listBoxViewData05.Items[10].ToString());
                    //Console.WriteLine("소수력1호기 방류량 " + smallHydro01_outflow);
                    //smallHydro01_kv = double.Parse(listBoxViewData05.Items[22].ToString());
                    //smallHydro01_a = double.Parse(listBoxViewData05.Items[23].ToString());
                    //smallHydro01_cos = double.Parse(listBoxViewData05.Items[25].ToString());


                    smallHydro02_kw = double.Parse(listBoxViewData05.Items[20].ToString());
                    //Console.WriteLine("소수력2호기 출력 " + smallHydro02_kw);
                    smallHydro02_outflow = double.Parse(listBoxViewData05.Items[11].ToString());
                    //Console.WriteLine("소수력2호기 방류량" + smallHydro02_outflow);
                    //smallHydro02_kv = double.Parse(listBoxViewData05.Items[26].ToString());
                    //smallHydro02_a = double.Parse(listBoxViewData05.Items[27].ToString());
                    //smallHydro02_cos = double.Parse(listBoxViewData05.Items[29].ToString());

                    smallHydro03_kw = double.Parse(listBoxViewData05.Items[12].ToString());
                    //Console.WriteLine("소수력3호기 출력 " + smallHydro03_kw);
                    smallHydro03_outflow = double.Parse(listBoxViewData05.Items[13].ToString());
                    //Console.WriteLine("소수력3호기 방류량 " + smallHydro03_outflow);
                    //smallHydro03_kv = double.Parse(listBoxViewData05.Items[30].ToString());
                    //smallHydro03_a = double.Parse(listBoxViewData05.Items[31].ToString());
                    //smallHydro03_cos = double.Parse(listBoxViewData05.Items[33].ToString());

                    //어도
                    fish101_open = double.Parse(listBoxViewData05.Items[14].ToString());
                    fish101_outflow = double.Parse(listBoxViewData05.Items[15].ToString());
                    fish401_open = double.Parse(listBoxViewData05.Items[16].ToString());
                    fish401_outflow = double.Parse(listBoxViewData05.Items[17].ToString());
                    fish501_open = double.Parse(listBoxViewData05.Items[18].ToString());
                    fish501_outflow = double.Parse(listBoxViewData05.Items[19].ToString());
                    //fishLevel = double.Parse(listBoxViewData05.Items[9].ToString());
                    //fish201_open = double.Parse(listBoxViewData05.Items[12].ToString());
                    //fish201_outflow = double.Parse(listBoxViewData05.Items[13].ToString());
                    //fish301_open = double.Parse(listBoxViewData05.Items[14].ToString());
                    //fish301_outflow = double.Parse(listBoxViewData05.Items[15].ToString());
                    //fish601_fullOpen = int.Parse(listBoxViewData05.Items[20].ToString());
                    //fish601_fullClose = int.Parse(listBoxViewData05.Items[21].ToString());

                    SetControls05();
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(dateTime + " ### 여수로, 소수력, 어도 정보 db polling 종료");
                //timer_get_value_07.Enabled = false;
                //timer_get_value_04.Enabled = false;
                //timer_get_value_05.Enabled = false;

                //timer_ramdom_gate_fish_small.Interval = 1000;
                //Console.WriteLine(dateTime + " ### 여수로, 소수력, 어도 정보 랜덤모드 시작");
                //timer_ramdom_gate_fish_small.Enabled = true;
            }
        }

        //수위예측 chart에 현재 수문이 열린상태인지 아닌지 체크  ..jh 2023 01 11
        int openCheck = 0;
        
        public void SetControls05()
        {
            //하부댐 여수로
            //소수점 둘째자리까지 반올림
            //여수로(댐 수문) 개도 정도(0~12m)
            lbl_01_opening.Text = gate01_opening.ToString("F2");
            lbl_02_opening.Text = gate02_opening.ToString("F2");
            lbl_03_opening.Text = gate03_opening.ToString("F2");
            lbl_04_opening.Text = gate04_opening.ToString("F2");


            //20230119 test

            openCheck = 0;

            if (gate01_opening <= 0)
            {
                pic_dam_opening1.Hide();
            }
            else
            {
                //openCheck++;
                pic_dam_opening1.Show();
            }

            if (gate02_opening <= 0)
            {
                pic_dam_opening2.Hide();
            }
            else
            {
                //openCheck++;
                pic_dam_opening2.Show();

            }

            if (gate03_opening <= 0)
            {
                pic_dam_opening3.Hide();
            }
            else
            {
                //openCheck++;
                pic_dam_opening3.Show();
            }
            
            if (gate04_opening <= 0)
            {
                pic_dam_opening4.Hide();
            }
            else
            {
                //openCheck++;
                pic_dam_opening4.Show();
            }


            //2023 01 11 jh
           /* if (openCheck != 0)
            {
                lb_opening_inCht.Visible = true;
                lb_closing_inCht.Visible = false;
            }
            else
            {
                lb_opening_inCht.Visible = false;
                lb_closing_inCht.Visible = true;
            }*/




            //방류량(0~100m3/s)
            lbl_01_outflow.Text = gate01_outflow.ToString("F2");
            lbl_02_outflow.Text = gate02_outflow.ToString("F2");
            lbl_03_outflow.Text = gate03_outflow.ToString("F2");
            lbl_04_outflow.Text = gate04_outflow.ToString("F2");

            //어도
            //txt_fish_level.Text = fishLevel.ToString("#.#0");
            txt_fish_101vn_open.Text = fish101_open.ToString("F1");
            txt_fish_101vn_outflow.Text = fish101_outflow.ToString("F1");
            /*txt_fish_201vn_open.Text = fish201_open.ToString("#.0");
            txt_fish_201vn_outflow.Text = fish201_outflow.ToString("#.#0");
            txt_fish_301vn_open.Text = fish301_open.ToString("#.0");
            txt_fish_301vn_outflow.Text = fish301_outflow.ToString("#.#0");*/
            txt_fish_401vn_open.Text = fish401_open.ToString("F1");
            txt_fish_401vn_outflow.Text = fish401_outflow.ToString("F1");
            txt_fish_501vn_open.Text = fish501_open.ToString("F1");
            txt_fish_501vn_outflow.Text = fish501_outflow.ToString("F1");
            /*txt_fish_601vn_full_open.Text = fish601_fullOpen.ToString();
            txt_fish_601vn_full_close.Text = fish601_fullClose.ToString();*/

            //소수력
            txt_small_hydro_01_kw.Text = smallHydro01_kw.ToString("F1");
            txt_small_hydro_01_outflow.Text = smallHydro01_outflow.ToString("F1");
            //txt_small_hydro_01_kv.Text = smallHydro01_kv.ToString("#.0");
            //txt_small_hydro_01_a.Text = smallHydro01_a.ToString("#.0");
            //txt_small_hydro_01_cos.Text = smallHydro01_cos.ToString("#.0");

            txt_small_hydro_02_kw.Text = smallHydro02_kw.ToString("F1");
            txt_small_hydro_02_outflow.Text = smallHydro02_outflow.ToString("F1");
            //txt_small_hydro_02_kv.Text = smallHydro02_kv.ToString("#.0");
            //txt_small_hydro_02_a.Text = smallHydro02_a.ToString("#.0");
            //txt_small_hydro_02_cos.Text = smallHydro02_cos.ToString("#.0");

            txt_small_hydro_03_kw.Text = smallHydro03_kw.ToString("F1");
            txt_small_hydro_03_outflow.Text = smallHydro03_outflow.ToString("F1");
            //txt_small_hydro_03_kv.Text = smallHydro03_kv.ToString("#.0");
            //txt_small_hydro_03_a.Text = smallHydro03_a.ToString("#.0");
            //txt_small_hydro_03_cos.Text = smallHydro03_cos.ToString("#.0");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    //=== 랜덤 시작 ======================================================================================================================

        Random random = new Random();

        //상하부댐 현황
        int ran_upperCurrentLevel = 0;
        int ran_upperRainfall10 = 0;
        int ran_upperTemp = 0;
        int ran_upperHumidity = 0;

        int ran_lowerCurrentLevel = 0;
        int ran_lowerRainfall10 = 0;
        int ran_lowerTemp = 0;
        int ran_lowerHumidity = 0;

        int ran_lowerTotalInflow10 = 0;
        int ran_lowerTotalOutflow10 = 0;
        int ran_lowerCurrentVolumn = 0;
        int ran_lowerCurrentSurplusVolumn = 0;

        //하부댐 여수로 개도, 방류량
        int ran_gate01_opening = 0;
        int ran_gate01_outflow = 0;
        int ran_gate02_opening = 0;
        int ran_gate02_outflow = 0;
        int ran_gate03_opening = 0;
        int ran_gate03_outflow = 0;
        int ran_gate04_opening = 0;
        int ran_gate04_outflow = 0;

        //어도
        int ran_fishLevel = 0;
        int ran_fish101_open = 0;
        int ran_fish101_outflow = 0;
        int ran_fish201_open = 0;
        int ran_fish201_outflow = 0;
        int ran_fish301_open = 0;
        int ran_fish301_outflow = 0;
        int ran_fish401_open = 0;
        int ran_fish401_outflow = 0;
        int ran_fish501_open = 0;
        int ran_fish501_outflow = 0;
        int ran_fish601_fullOpen = 1;
        int ran_fish601_fullClose = 0;

        //소수력
        int ran_smallHydro01_kv = 0;
        int ran_smallHydro01_a = 0;
        int ran_smallHydro01_kw = 0;
        int ran_smallHydro01_cos = 0;

        int ran_smallHydro02_kv = 0;
        int ran_smallHydro02_a = 0;
        int ran_smallHydro02_kw = 0;
        int ran_smallHydro02_cos = 0;

        int ran_smallHydro03_kv = 0;
        int ran_smallHydro03_a = 0;
        int ran_smallHydro03_kw = 0;
        int ran_smallHydro03_cos = 0;


        private void timer_random_dam_Tick(object sender, EventArgs e)
        {
            RandomUpperDam();
            RandomLowerDam();
        }

        public void RandomUpperDam()
        {
            ran_upperCurrentLevel = random.Next(890, 935);
            lbl_upper_cur_level.Text = ran_upperCurrentLevel.ToString("#.#0");

            ran_upperRainfall10 = random.Next(10, 100);
            lbl_upper_rainfall_10.Text = ran_upperRainfall10.ToString("#.#0");

            ran_upperTemp = random.Next(10, 35);
            lbl_upper_temp.Text = ran_upperTemp.ToString("#.#0");

            ran_upperHumidity = random.Next(10, 80);
            //lbl_upper_humidity.Text = ran_upperHumidity.ToString("#.#0");
        }

        public void RandomLowerDam()
        {
            ran_lowerCurrentLevel = random.Next(114,128);
            lbl_lower_cur_level.Text = ran_lowerCurrentLevel.ToString("#.#0");

            ran_lowerRainfall10 = random.Next(10, 100);
            lbl_lower_rainfall.Text = ran_lowerRainfall10.ToString("#.#0");

            ran_lowerTemp = random.Next(2, 38);
            lbl_lower_temp.Text = ran_lowerTemp.ToString("#.#0");

            ran_lowerHumidity = random.Next(10, 80);
            //lbl_lower_humidity.Text = ran_lowerHumidity.ToString("#.#0");

            ran_lowerTotalInflow10 = random.Next(10, 70);
            lbl_lower_inflow_10.Text = ran_lowerTotalInflow10.ToString("#.#0");

            ran_lowerTotalOutflow10 = random.Next(10, 30);
            lbl_lower_outflow_10.Text = ran_lowerTotalOutflow10.ToString("#.#0");

            ran_lowerCurrentVolumn = random.Next(114,128);
            lbl_cur_lower_volumn.Text = ran_lowerCurrentVolumn.ToString("#.#0");


            ran_lowerCurrentVolumn = random.Next(114, 128);
            lbl_cur_upper_volumn.Text = ran_lowerCurrentVolumn.ToString("#.#0");


            ran_lowerCurrentSurplusVolumn = random.Next(20, 300);
            lbl_lower_cur_surplus_volumn.Text = ran_lowerCurrentSurplusVolumn.ToString("#.#0");
        }
        

        private void timer_ramdom_gate_fish_small_Tick(object sender, EventArgs e)
        {
            RamdomDamGate();
            RandomFish();
            RandomSmall();
        }

        public void RamdomDamGate()
        {
            ran_gate01_opening = random.Next(3, 12);
            lbl_01_opening.Text = ran_gate01_opening.ToString("#.#0");

            ran_gate02_opening = random.Next(4, 12);
            lbl_02_opening.Text = ran_gate02_opening.ToString("#.#0");

            ran_gate03_opening = random.Next(5, 12);
            lbl_03_opening.Text = ran_gate03_opening.ToString("#.#0");

            ran_gate04_opening = random.Next(1, 12);
            lbl_04_opening.Text = ran_gate04_opening.ToString("#.#0");

            ran_gate01_outflow = random.Next(40, 100);
            lbl_01_outflow.Text = ran_gate01_outflow.ToString("#.#0");

            ran_gate02_outflow = random.Next(10, 100);
            lbl_02_outflow.Text = ran_gate02_outflow.ToString("#.#0");

            ran_gate03_outflow = random.Next(20, 100);
            lbl_03_outflow.Text = ran_gate03_outflow.ToString("#.#0");

            ran_gate04_outflow = random.Next(30, 100);
            lbl_04_outflow.Text = ran_gate04_outflow.ToString("#.#0");
        }

        public void RandomFish()
        {
            ran_fishLevel = random.Next(110, 130);
            //txt_fish_level.Text = ran_fishLevel.ToString("#.#0");

            ran_fish101_open = random.Next(30, 100);
            txt_fish_101vn_open.Text = ran_fish101_open.ToString("#.0");

            ran_fish101_outflow = random.Next(20, 100);
            txt_fish_101vn_outflow.Text = ran_fish101_outflow.ToString("#.#0");

            ran_fish201_open = random.Next(30, 100);
            //txt_fish_201vn_open.Text = ran_fish201_open.ToString("#.0");

            ran_fish201_outflow = random.Next(10, 100);
            //txt_fish_201vn_outflow.Text = ran_fish201_outflow.ToString("#.#0");

            ran_fish301_open = random.Next(20, 100);
            //txt_fish_301vn_open.Text = ran_fish301_open.ToString("#.0");

            ran_fish301_outflow = random.Next(40, 100);
            //txt_fish_301vn_outflow.Text = ran_fish301_outflow.ToString("#.#0");

            ran_fish401_open = random.Next(20, 100);
            txt_fish_401vn_open.Text = ran_fish401_open.ToString("#.0");

            ran_fish401_outflow = random.Next(30, 100);
            txt_fish_401vn_outflow.Text = ran_fish401_outflow.ToString("#.#0");

            ran_fish501_open = random.Next(10, 100);
            txt_fish_501vn_open.Text = ran_fish501_open.ToString("#.0");

            ran_fish501_outflow = random.Next(10, 100);
            txt_fish_501vn_outflow.Text = ran_fish501_outflow.ToString("#.#0");

            //ran_fish601_fullOpen = random.Next(0, 1);
            //txt_fish_601vn_full_open.Text = ran_fish601_fullOpen.ToString();

            //ran_fish601_fullClose = random.Next(0, 1);
            //txt_fish_601vn_full_close.Text = ran_fish601_fullClose.ToString();
        }

        public void RandomSmall()
        {
            ran_smallHydro01_kv = random.Next(10, 900);
            txt_small_hydro_01_kv.Text = ran_smallHydro01_kv.ToString("#.0");

            ran_smallHydro01_a = random.Next(10, 900);
            txt_small_hydro_01_a.Text = ran_smallHydro01_a.ToString("#.0");

            ran_smallHydro01_kw = random.Next(10, 900);
            txt_small_hydro_01_kw.Text = ran_smallHydro01_kw.ToString("#.0");

            ran_smallHydro01_cos = random.Next(10, 100);
            txt_small_hydro_01_cos.Text = ran_smallHydro01_cos.ToString("#.0");

            //2호기
            ran_smallHydro02_kv = random.Next(10, 900);
            txt_small_hydro_02_kv.Text = ran_smallHydro02_kv.ToString("#.0");

            ran_smallHydro02_a = random.Next(10, 900);
            txt_small_hydro_02_a.Text = ran_smallHydro02_a.ToString("#.0");

            ran_smallHydro02_kw = random.Next(10, 900);
            txt_small_hydro_02_kw.Text = ran_smallHydro02_kw.ToString("#.0");

            ran_smallHydro02_cos = random.Next(10, 100);
            txt_small_hydro_02_cos.Text = ran_smallHydro02_cos.ToString("#.0");

            //3호기
            ran_smallHydro03_kv = random.Next(10, 900);
            txt_small_hydro_03_kv.Text = ran_smallHydro03_kv.ToString("#.0");

            ran_smallHydro03_a = random.Next(10, 900);
            txt_small_hydro_03_a.Text = ran_smallHydro03_a.ToString("#.0");

            ran_smallHydro03_kw = random.Next(10, 900);
            txt_small_hydro_03_kw.Text = ran_smallHydro03_kw.ToString("#.0");

            ran_smallHydro03_cos = random.Next(10, 100);
            txt_small_hydro_03_cos.Text = ran_smallHydro03_cos.ToString("#.0");

            
            
            //방류량
            int hydd01_outF = 0;
            int hydd02_outF = 0;
            int hydd03_outF = 0;
            hydd01_outF = random.Next(20, 100);
            hydd02_outF = random.Next(20, 100);
            hydd03_outF = random.Next(20, 100);

            txt_small_hydro_01_outflow.Text = hydd01_outF.ToString("#.#0");
            txt_small_hydro_02_outflow.Text = hydd02_outF.ToString("#.#0");
            txt_small_hydro_03_outflow.Text = hydd03_outF.ToString("#.#0");

        }

    //=== 랜덤 끝 ======================================================================================================================

        public void btn_spring_day_Click(object sender, EventArgs e)
        {
            //this.BackgroundImage = null;
            if (this.BackgroundImage != null) { this.BackgroundImage.Dispose(); }
            this.BackgroundImage = Properties.Resources.spring_day;
            //this.BackgroundImage = Image.FromFile("img\\spring_day.png");
        }

        public void btn_summer_day_Click(object sender, EventArgs e)
        {
            //this.BackgroundImage = null;
            if (this.BackgroundImage != null) { this.BackgroundImage.Dispose(); }
            this.BackgroundImage = Properties.Resources.summer_day;
            //this.BackgroundImage = Image.FromFile("img\\summer_day.png");
        }

        public void btn_autumn_day_Click(object sender, EventArgs e)
        {
            //this.BackgroundImage = null;
            if (this.BackgroundImage != null) { this.BackgroundImage.Dispose(); }
            this.BackgroundImage = Properties.Resources.autumn_day;
            //this.BackgroundImage = Image.FromFile("img\\autumn_day.png");
        }

        public void btn_winter_day_Click(object sender, EventArgs e)
        {
            //this.BackgroundImage = null;
            if (this.BackgroundImage != null) { this.BackgroundImage.Dispose(); }
            this.BackgroundImage = Properties.Resources.winter_day;
            //this.BackgroundImage = Image.FromFile("img\\winter_day.png");
        }

        public void btn_spring_night_Click(object sender, EventArgs e)
        {
            //this.BackgroundImage = null;
            if (this.BackgroundImage != null) { this.BackgroundImage.Dispose(); }
            this.BackgroundImage = Properties.Resources.spring_night;
            //this.BackgroundImage = Image.FromFile("img\\spring_night.png");
        }

        public void btn_summer_night_Click(object sender, EventArgs e)
        {
            //this.BackgroundImage = null;
            if (this.BackgroundImage != null) { this.BackgroundImage.Dispose(); }
            this.BackgroundImage = Properties.Resources.summer_night;
            //this.BackgroundImage = Image.FromFile("img\\summer_night.png");
        }

        public void btn_autumn_night_Click(object sender, EventArgs e)
        {
            //this.BackgroundImage = null;
            if (this.BackgroundImage != null) { this.BackgroundImage.Dispose(); }
            this.BackgroundImage = Properties.Resources.autumn_night;
            //this.BackgroundImage = Image.FromFile("img\\autumn_night.png");
        }

        public void btn_winter_night_Click(object sender, EventArgs e)
        {
            //this.BackgroundImage = null;
            if (this.BackgroundImage != null) { this.BackgroundImage.Dispose(); }
            this.BackgroundImage = Properties.Resources.winter_night;
            //this.BackgroundImage = Image.FromFile("img\\winter_night.png");
        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            //this.BackgroundImage = Image.FromFile("img\\winter_day.png");
            this.BackgroundImage = Properties.Resources.winter_day;

            this.Opacity += 0.1;
            if (this.Opacity == 1)
            {
                timer1.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void tm_graphB_Tick(object sender, EventArgs e)
        {

        }

        private void tm_test_Tick(object sender, EventArgs e)
        {
            //testValue();
        }

        private void tm_get_damInfo_Tick_1(object sender, EventArgs e)
        {

        }

        //물줄기 show
        private void button1_Click(object sender, EventArgs e)
        {
            pic_dam_opening1.Visible = true;
            pic_dam_opening2.Visible = true;
            pic_dam_opening3.Visible = true;
            pic_dam_opening4.Visible = true;
        }

        //물줄기 hide
        private void button2_Click(object sender, EventArgs e)
        {
            pic_dam_opening1.Visible = false;
            pic_dam_opening2.Visible = false;
            pic_dam_opening3.Visible = false;
            pic_dam_opening4.Visible = false;
        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }
    }
}
