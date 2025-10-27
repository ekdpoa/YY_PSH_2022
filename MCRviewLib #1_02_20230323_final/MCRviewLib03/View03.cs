using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCRviewLib03
{
    public partial class View03 : Form
    {
        string dateTime = DateTime.Now.ToString("yyyy.MM.dd tt hh:mm:ss");

        public View03()
        {
            InitializeComponent();
        }

        private void View03_Load(object sender, EventArgs e)
        {
            /*
            //345kv case
            pic_345_case1.SetBounds(372, 143, 598, 246);
            pic_345_case2.SetBounds(372, 389, 4, 361);
            pic_345_case3.SetBounds(372, 750, 598, 250);
            pic_345_case4.SetBounds(970, 143, 4, 250);
            pic_345_case5.SetBounds(970, 393, 4, 357);
            pic_345_case6.SetBounds(970, 750, 4, 250);
            pic_345_case7.SetBounds(974, 143, 405, 250);
            pic_345_case8.SetBounds(1375, 393, 4, 357);
            pic_345_case9.SetBounds(974, 750, 405, 250);
            pic_345_case10.SetBounds(242, 343, 130, 50);
            pic_345_case11.SetBounds(1379, 348, 275, 45);
            pic_345_case12.SetBounds(242, 750, 130, 330);
            pic_345_case13.SetBounds(1379, 750, 230, 330);
            pic_345_case14.SetBounds(756, 389, 213, 607);
            pic_345_case14_1.SetBounds(756, 999, 4, 20);
            pic_345_case14_2.SetBounds(756, 1052, 4, 29);
            pic_345_case15.SetBounds(974, 750, 208, 246);
            pic_345_case15_1.SetBounds(1178, 998, 4, 20);
            pic_345_case15_2.SetBounds(1178, 1051, 4, 29);
            */

            /*
            //18kv case
            pic_18_case1.SetBounds(224, 1080, 40, 121);
            pic_18_case2.SetBounds(738, 1080, 40, 121);
            pic_18_case3.SetBounds(1160, 1080, 40, 121);
            pic_18_case4.SetBounds(1587, 1080, 40, 121);


            pic_18_case5_1.SetBounds(242, 1201, 130, 144);
            pic_18_case5_2.SetBounds(370, 1218, 1446, 8);
            pic_18_case5_3.SetBounds(1788, 1225, 44, 710);

            pic_18_case6_1.SetBounds(604, 1201, 156, 144);
            //pic_18_case6_2.SetBounds(604, 1080+121, 1227, 734);
            //pic_18_case6_3.SetBounds(604, 1080+121, 1227, 734);

            pic_18_case7_1.SetBounds(1178, 1225, 146, 133);
            pic_18_case7_2.SetBounds(1323, 1257, 435, 8);
            pic_18_case7_3.SetBounds(1734, 1263, 41, 360);

            pic_18_case8_1.SetBounds(1464, 1201, 145, 157);

            pic_18_case9.SetBounds(139, 1080+120, 107, 761);

            pic_18_case10_1.SetBounds(754, 1204, 8, 278);
            pic_18_case10_2.SetBounds(602, 1477, 157, 143);
            pic_18_case10_3.SetBounds(755, 1614, 8, 228);

            pic_18_case11_1.SetBounds(1178, 1201, 4, 277);
            pic_18_case11_2.SetBounds(1072, 1478, 110, 140);
            pic_18_case11_3.SetBounds(1177, 1618, 5, 225);
            
            pic_18_case12_1.SetBounds(1603, 1200, 6, 278);
            pic_18_case12_2.SetBounds(1462, 1477, 147, 141);
            pic_18_case12_3.SetBounds(1603, 1618, 8, 225);

            pic_18_case13_1.SetBounds(242, 1202, 8, 278);
            pic_18_case13_2.SetBounds(245, 1477, 108, 141);
            pic_18_case13_3.SetBounds(241, 1618, 6, 228);

            pic_18_case14_1.SetBounds(755, 1200, 6, 278);
            pic_18_case14_2.SetBounds(758, 1478, 58, 141);
            pic_18_case14_3.SetBounds(755, 1614, 6, 229);

            pic_18_case15_1.SetBounds(1178, 1201, 6, 278);
            pic_18_case15_2.SetBounds(1178, 1477, 108, 143);
            pic_18_case15_3.SetBounds(1178, 1618, 6, 220);

            pic_18_case16_1.SetBounds(1605, 1200, 6, 278);
            pic_18_case16_2.SetBounds(1605, 1478, 73, 143);
            pic_18_case16_3.SetBounds(1603, 1618, 6, 225);

            */

            //HideAll345Case();
            //HideAll18Case();


            timer_get_value_03.Interval = 1000;
            timer_get_value_03.Enabled = true;

            timer_get_value_09.Interval = 1000;
            timer_get_value_09.Enabled = true;
        }
        /*
        public void HideAll345Case()
        {
            pic_345_case1.Visible = false;
            pic_345_case2.Visible = false;
            pic_345_case3.Visible = false;
            pic_345_case4.Visible = false;
            pic_345_case5.Visible = false;
            pic_345_case6.Visible = false;
            pic_345_case7.Visible = false;
            pic_345_case8.Visible = false;
            pic_345_case9.Visible = false;
            pic_345_case10.Visible = false;
            pic_345_case11.Visible = false;
            pic_345_case12.Visible = false;
            pic_345_case13.Visible = false;
            pic_345_case14.Visible = false;
            pic_345_case14_1.Visible = false;
            pic_345_case14_2.Visible = false;
            pic_345_case15.Visible = false;
            pic_345_case15_1.Visible = false;
            pic_345_case15_2.Visible = false;
        }
        */

        /*
        public void HideAll18Case()
        {
            //pic_18_case1.Visible = true;
            //pic_18_case2.Visible = true;
            //pic_18_case3.Visible = true;
            //pic_18_case4.Visible = true;

            pic_18_case5_1.Visible = false;
            pic_18_case5_2.Visible = false;
            pic_18_case5_3.Visible = false;

            pic_18_case6_1.Visible = false;
            pic_18_case6_2.Visible = false;
            pic_18_case6_3.Visible = false;

            pic_18_case7_1.Visible = false;
            pic_18_case7_2.Visible = false;
            pic_18_case7_3.Visible = false;

            pic_18_case8_1.Visible = false;
            pic_18_case8_2.Visible = false;
            pic_18_case8_3.Visible = false;

            pic_18_case9.Visible = false;

            pic_18_case10_1.Visible = false;
            pic_18_case10_2.Visible = false;
            pic_18_case10_3.Visible = false;

            pic_18_case11_1.Visible = false;
            pic_18_case11_2.Visible = false;
            pic_18_case11_3.Visible = false;

            pic_18_case12_1.Visible = false;
            pic_18_case12_2.Visible = false;
            pic_18_case12_3.Visible = false;

            pic_18_case13_1.Visible = false;
            pic_18_case13_2.Visible = false;
            pic_18_case13_3.Visible = false;

            pic_18_case14_1.Visible = false;
            pic_18_case14_2.Visible = false;
            pic_18_case14_3.Visible = false;

            pic_18_case15_1.Visible = false;
            pic_18_case15_2.Visible = false;
            pic_18_case15_3.Visible = false;

            pic_18_case16_1.Visible = false;
            pic_18_case16_2.Visible = false;
            pic_18_case16_3.Visible = false;

            pic_18_case17_1.Visible = false;
            pic_18_case17_2.Visible = false;
            pic_18_case17_3.Visible = false;
            pic_18_case17_4.Visible = false;
            pic_18_case17_5.Visible = false;
            pic_18_case17_6.Visible = false;
            pic_18_case17_7.Visible = false;
            pic_18_case17_8.Visible = false;

            pic_18_case18_1.Visible = false;
            pic_18_case18_2.Visible = false;
            pic_18_case18_3.Visible = false;
            pic_18_case18_4.Visible = false;
            pic_18_case18_5.Visible = false;
            pic_18_case18_6.Visible = false;
            pic_18_case18_7.Visible = false;
            pic_18_case18_8.Visible = false;

            pic_18_case19_1.Visible = false;
            pic_18_case19_2.Visible = false;
            pic_18_case19_3.Visible = false;
            pic_18_case19_4.Visible = false;
            pic_18_case19_5.Visible = false;
            pic_18_case19_6.Visible = false;
            pic_18_case19_7.Visible = false;
            pic_18_case19_8.Visible = false;

            pic_18_case20_1.Visible = false;
            pic_18_case20_2.Visible = false;
            pic_18_case20_3.Visible = false;
            pic_18_case20_4.Visible = false;
            pic_18_case20_5.Visible = false;
            pic_18_case20_6.Visible = false;
            pic_18_case20_7.Visible = false;
            pic_18_case20_8.Visible = false;
            pic_18_case20_9.Visible = false;

            pic_18_case21_1.Visible = false;
            pic_18_case21_2.Visible = false;
            pic_18_case21_3.Visible = false;
            pic_18_case21_4.Visible = false;
            pic_18_case21_5.Visible = false;
            pic_18_case21_6.Visible = false;
            pic_18_case21_7.Visible = false;
            pic_18_case21_8.Visible = false;
            pic_18_case21_9.Visible = false;

            pic_18_case22_1.Visible = false;
            pic_18_case22_2.Visible = false;
            pic_18_case22_3.Visible = false;
            pic_18_case22_4.Visible = false;
            pic_18_case22_5.Visible = false;
            pic_18_case22_6.Visible = false;
            pic_18_case22_7.Visible = false;
            pic_18_case22_8.Visible = false;
            pic_18_case22_9.Visible = false;

            pic_18_case23_1.Visible = false;
            pic_18_case23_2.Visible = false;
            pic_18_case23_3.Visible = false;
            pic_18_case23_4.Visible = false;
            pic_18_case23_5.Visible = false;
            pic_18_case23_6.Visible = false;
            pic_18_case23_7.Visible = false;
            pic_18_case23_8.Visible = false;
            pic_18_case23_9.Visible = false;

            pic_18_case24_1.Visible = false;
            pic_18_case24_2.Visible = false;
            pic_18_case24_3.Visible = false;
            pic_18_case24_4.Visible = false;
            pic_18_case24_5.Visible = false;
            pic_18_case24_6.Visible = false;
            pic_18_case24_7.Visible = false;
            pic_18_case24_8.Visible = false;

            pic_18_case25_1.Visible = false;
            pic_18_case25_2.Visible = false;
            pic_18_case25_3.Visible = false;
            pic_18_case25_4.Visible = false;
            pic_18_case25_5.Visible = false;
            pic_18_case25_7.Visible = false;
            pic_18_case25_8.Visible = false;

            pic_18_case26_1.Visible = false;
            pic_18_case26_2.Visible = false;
            pic_18_case26_3.Visible = false;
            pic_18_case26_4.Visible = false;
            pic_18_case26_5.Visible = false;
            pic_18_case26_6.Visible = false;
            pic_18_case26_7.Visible = false;

            pic_18_case27_1.Visible = false;
            pic_18_case27_2.Visible = false;
            pic_18_case27_3.Visible = false;
            pic_18_case27_4.Visible = false;
            pic_18_case27_5.Visible = false;
            pic_18_case27_6.Visible = false;
            pic_18_case27_7.Visible = false;

            pic_18_case28_1.Visible = false;
            pic_18_case28_2.Visible = false;
            pic_18_case28_3.Visible = false;
            pic_18_case28_4.Visible = false;
            pic_18_case28_5.Visible = false;
            pic_18_case28_6.Visible = false;
            pic_18_case28_7.Visible = false;
            pic_18_case28_8.Visible = false;
            pic_18_case28_9.Visible = false;

            pic_18_case29_1.Visible = false;
            pic_18_case29_2.Visible = false;
            pic_18_case29_3.Visible = false;
            pic_18_case29_4.Visible = false;
            pic_18_case29_5.Visible = false;
            pic_18_case29_6.Visible = false;
            pic_18_case29_7.Visible = false;
            pic_18_case29_8.Visible = false;
            pic_18_case29_9.Visible = false;

            pic_18_case30_1.Visible = false;
            pic_18_case30_2.Visible = false;
            pic_18_case30_3.Visible = false;
            pic_18_case30_4.Visible = false;
            pic_18_case30_5.Visible = false;
            pic_18_case30_6.Visible = false;
            pic_18_case30_7.Visible = false;
            pic_18_case30_8.Visible = false;

            pic_18_case31_1.Visible = false;
            pic_18_case31_2.Visible = false;
            pic_18_case31_3.Visible = false;
            pic_18_case31_4.Visible = false;
            pic_18_case31_5.Visible = false;
            pic_18_case31_6.Visible = false;
            pic_18_case31_7.Visible = false;
            pic_18_case31_8.Visible = false;

            pic_18_case32_1.Visible = false;
            pic_18_case32_2.Visible = false;
            pic_18_case32_3.Visible = false;
            pic_18_case32_4.Visible = false;
            pic_18_case32_5.Visible = false;
            pic_18_case32_6.Visible = false;
        }
        */
        

        //3면: 345kV
        //db: CB_345KV (DCS)
        //pi: 2. 345kv 차단기류

        //61LRL
        //es7191
        int es7191_open =  0;            //open 61LRL_010JS_160DI
        int es7191_close = 0;           //close 61LRL_010JS_021DI

        //ds7121
        int ds7121_open =  0;            //open 61LRL_003JS_160DI
        int ds7121_close = 0;           //close 61LRL_003JS_021DI

        //ds7151
        int ds7151_open =  0;            //open 61LRL_002JS_160DI
        int ds7151_close = 0;           //close 61LRL_002JS_021DI

        //cb7171
        int cb7171_open =  0;            //open 61LRL_001JD_160DI
        int cb7171_close = 0;           //close 61LRL_001JD_021DI

        //ds7161
        int ds7161_open =  0;            //open 61LRL_001JS_160DI
        int ds7161_close = 0;           //close 61LRL_001JS_021DI

        //es7109-1
        int es7109_1_open =  0;          //open 61LRL_012JS_160DI
        int es7109_1_close = 0;         //close 61LRL_012JS_021DI

        //es7109-2
        int es7109_2_open =  0;          //open 61LRL_011JS_160DI
        int es7109_2_close = 0;         //close 61LRL_011JS_021DI

        //es7109-3
        int es7109_3_open =  0;          //open 61LRL_013JS_160DI
        int es7109_3_close = 0;         //close 61LRL_013JS_021DI


        //60RLC
        //es7091
        int es7091_open =  0;            //open 60LRC_021JS_160DI
        int es7091_close = 0;           //close 60LRC_021JS_021DI

        //62LRT
        //es7291
        int es7291_open =  0;            //open 62LRT_010JS_160DI
        int es7291_close = 0;           //close 62LRT_010JS_021DI

        //ds7221
        int ds7221_open =  0;            //open 62LRT_003JS_160DI
        int ds7221_close = 0;           //close 62LRT_003JS_021DI

        //ds7251 
        int ds7251_open =  0;            //open 62LRT_002JS_160DI
        int ds7251_close = 0;           //close 62LRT_002JS_021DI

        //cb7271
        int cb7271_open =  0;            //open 62LRT_001JD_160DI
        int cb7271_close = 0;           //close 62LRT_001JD_021DI

        //ds7261
        int ds7261_open =  0;            //open 62LRT_001JS_160DI
        int ds7261_close = 0;           //close 62LRT_001JS_021DI

        //es7209-1
        int es7209_1_open =  0;          //open 62LRT_012JS_160DI
        int es7209_1_close = 0;         //close 62LRT_012JS_021DI

        //es7209-2
        int es7209_2_open =  0;          //open 62LRT_011JS_160DI
        int es7209_2_close = 0;         //close 62LRT_011JS_021DI

        //es7209-3
        int es7209_3_open =  0;          //open 62LRT_013JS_160DI
        int es7209_3_close = 0;         //close 62LRT_013JS_021DI

        //62LRL
        //es7309-1
        int es7309_1_open =  0;          //open 62LRL_012JS_160DI
        int es7309_1_close = 0;         //close 62LRL_012JS_021DI

        //es7309-2
        int es7309_2_open =  0;          //open 62LRL_011JS_160DI
        int es7309_2_close = 0;         //close 62LRL_011JS_021DI

        //es7309-3
        int es7309_3_open =  0;          //open 62LRL_013JS_160DI
        int es7309_3_close = 0;         //close 62LRL_013JS_021DI

        //ds7351
        int ds7351_open =  0;            //open 62LRL_002JS_160DI
        int ds7351_close = 0;           //close 62LRL_002JS_021DI

        //cb7371
        int cb7371_open =  0;            //open 62LRL_001JD_160DI
        int cb7371_close = 0;           //close 62LRL_001JD_021DI

        //ds7361
        int ds7361_open =  0;            //open 62LRL_001JS_160DI
        int ds7361_close = 0;           //close 62LRL_001JS_021DI

        //ds7321
        int ds7321_open =  0;            //open 62LRL_003JS_160DI
        int ds7321_close = 0;           //close 62LRL_003JS_021DI

        //es7391
        int es7391_open =  0;            //open 62LRL_010JS_160DI
        int es7391_close = 0;           //close 62LRL_010JS_021DI

        //60LRL
        //ds7101
        int ds7101_open =  0;            //open 60LRL_001JS_160DI
        int ds7101_close = 0;           //close 60LRL_001JS_021DI

        //cb7100
        int cb7100_open =  0;            //open 60LRL_001JD_160DI
        int cb7100_close = 0;           //close 60LRL_001JD_021DI

        //ds7102
        int ds7102_open =  0;            //open 60LRL_002JS_160DI
        int ds7102_close = 0;           //close 60LRL_002JS_021DI

        //es7109-4
        int es7109_4_open =  0;          //open 60LRL_011JS_160DI
        int es7109_4_close = 0;         //close 60LRL_011JS_021DI

        //es7109-5
        int es7109_5_open =  0;          //open 60LRL_012JS_160DI
        int es7109_5_close = 0;         //close 60LRL_012JS_021DI

        //60LRC?
        //ds7201
        int ds7201_open =  0;            //open 60LRC_003JS_160DI
        int ds7201_close = 0;           //close 60LRC_003JS_021DI

        //cb7200
        int cb7200_open =  0;            //open 60LRC_002JD_160DI
        int cb7200_close = 0;           //close 60LRC_002JD_021DI

        //ds7202
        int ds7202_open =  0;            //open 60LRC_004JS_160DI
        int ds7202_close = 0;           //close 60LRC_004JS_021DI

        //es7209-4
        int es7209_4_open =  0;          //open 60LRC_013JS_160DI
        int es7209_4_close = 0;         //close 60LRC_013JS_021DI

        //es7209-5
        int es7209_5_open =  0;          //open 60LRC_014JS_160DI
        int es7209_5_close = 0;         //close 60LRC_014JS_021DI

        //ds7301
        int ds7301_open =  0;            //open 60LRC_005JS_160DI
        int ds7301_close = 0;           //close 60LRC_005JS_021DI

        //cb7300
        int cb7300_open =  0;            //open 60LRC_003JD_160DI
        int cb7300_close = 0;           //close 60LRC_003JD_021DI

        //ds7302
        int ds7302_open =  0;            //open 60LRC_006JS_160DI
        int ds7302_close = 0;           //close 60LRC_006JS_021DI

        //es7309-4
        int es7309_4_open =  0;          //open 60LRC_015JS_160DI
        int es7309_4_close = 0;         //close 60LRC_015JS_021DI

        //es7309-5
        int es7309_5_open =  0;          //open 60LRC_016JS_160DI
        int es7309_5_close = 0;         //close 60LRC_016JS_021DI

        //61LRT
        //es7192
        int es7192_open =  0;            //open 61LRT_010JS_160DI
        int es7192_close = 0;           //close 61LRT_010JS_021DI

        //ds7122
        int ds7122_open =  0;            //open 61LRT_003JS_160DI
        int ds7122_close = 0;           //close 61LRT_003JS_021DI

        //ds7162
        int ds7162_open =  0;            //open 61LRT_001JS_160DI
        int ds7162_close = 0;           //close 61LRT_001JS_021DI

        //cb7172
        int cb7172_open =  0;            //open 61LRT_001JD_160DI
        int cb7172_close = 0;           //close 61LRT_001JD_021DI

        //ds7152
        int ds7152_open =  0;            //open 61LRT_002JS_160DI
        int ds7152_close = 0;           //close 61LRT_002JS_021DI

        //es7109-6
        int es7109_6_open =  0;          //open 61LRT_013JS_160DI
        int es7109_6_close = 0;         //close 61LRT_013JS_021DI

        //es7109-7
        int es7109_7_open =  0;          //open 61LRT_011JS_160DI
        int es7109_7_close = 0;         //close 61LRT_011JS_021DI

        //es7109-8
        int es7109_8_open =  0;          //open 61LRT_012JS_160DI
        int es7109_8_close = 0;         //close 61LRT_012JS_021DI

        //63LRT
        //es7292: 그림상으로는 60LRC, 022JS
        int es7292_open =  0;            //open 63LRT_010JS_160DI
        int es7292_close = 0;           //close 63LRT_010JS_021DI
        
        //es7209-6
        int es7209_6_open =  0;          //open 63LRT_013JS_160DI
        int es7209_6_close = 0;         //close 63LRT_013JS_021DI

        //ds7262
        int ds7262_open =  0;            //open 63LRT_001JS_160DI
        int ds7262_close = 0;           //close 63LRT_001JS_021DI

        //cb7272
        int cb7272_open =  0;            //open 63LRT_001JD_160DI
        int cb7272_close = 0;           //close 63LRT_001JD_021DI

        //ds7252
        int ds7252_open =  0;            //open 63LRT_002JS_160DI
        int ds7252_close = 0;           //close 63LRT_002JS_021DI

        //ds7222
        int ds7222_open =  0;            //open 63LRT_003JS_160DI
        int ds7222_close = 0;           //close 63LRT_003JS_021DI

        //es7209-7
        int es7209_7_open =  0;          //open 63LRT_011JS_160DI
        int es7209_7_close = 0;         //close 63LRT_011JS_021DI

        //es7209-8
        int es7209_8_open =  0;          //open 63LRT_012JS_160DI
        int es7209_8_close = 0;         //close 63LRT_012JS_021DI

        //20230118 ds7292 -> es7092
        int es7092_open =  0;
        int es7092_close = 0;

        //64LRT
        //es7309-6
        int es7309_6_open =  0;          //open 64LRT_013JS_160DI
        int es7309_6_close = 0;         //close 64LRT_013JS_021DI

        //ds7362
        int ds7362_open =  0;            //open 64LRT_001JS_160DI
        int ds7362_close = 0;           //close 64LRT_001JS_021DI

        //cb7372
        int cb7372_open =  0;            //open 64LRT_001JD_160DI
        int cb7372_close = 0;           //close 64LRT_001JD_021DI

        //ds7352
        int ds7352_open =  0;            //open 64LRT_002JS_160DI
        int ds7352_close = 0;           //close 64LRT_002JS_021DI

        //ds7322
        int ds7322_open =  0;            //open 64LRT_003JS_160DI
        int ds7322_close = 0;           //close 64LRT_003JS_021DI

        //es7309-7
        int es7309_7_open =  0;          //open 64LRT_011JS_160DI
        int es7309_7_close = 0;         //close 64LRT_011JS_021DI

        //es7309-8
        int es7309_8_open =  0;          //open 64LRT_012JS_160DI
        int es7309_8_close = 0;         //close 64LRT_012JS_021DI

        //es7392
        int es7392_open =  0;            //open 64LRT_010JS_160DI
        int es7392_close = 0;           //close 64LRT_010JS_021DI


        private void timer_get_value_03_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.listBoxViewData03.Items.Count <= 0) { }
                else
                {
                    //61LRL
                    es7191_open = int.Parse(listBoxViewData03.Items[15].ToString());
                    es7191_close = int.Parse(listBoxViewData03.Items[16].ToString());

                    ds7121_open = int.Parse(listBoxViewData03.Items[13].ToString());
                    ds7121_close = int.Parse(listBoxViewData03.Items[14].ToString());

                    ds7151_open = int.Parse(listBoxViewData03.Items[1].ToString());
                    ds7151_close = int.Parse(listBoxViewData03.Items[2].ToString());

                    cb7171_open = int.Parse(listBoxViewData03.Items[5].ToString());
                    cb7171_close = int.Parse(listBoxViewData03.Items[6].ToString());

                    ds7161_open = int.Parse(listBoxViewData03.Items[9].ToString());
                    ds7161_close = int.Parse(listBoxViewData03.Items[10].ToString());

                    es7109_1_open = int.Parse(listBoxViewData03.Items[3].ToString());
                    es7109_1_close = int.Parse(listBoxViewData03.Items[4].ToString());

                    es7109_2_open = int.Parse(listBoxViewData03.Items[7].ToString());
                    es7109_2_close = int.Parse(listBoxViewData03.Items[8].ToString());

                    es7109_3_open = int.Parse(listBoxViewData03.Items[11].ToString());
                    es7109_3_close = int.Parse(listBoxViewData03.Items[12].ToString());

                    //60RLC
                    es7091_open = int.Parse(listBoxViewData03.Items[43].ToString());
                    es7091_close = int.Parse(listBoxViewData03.Items[44].ToString());

                    //62LRT
                    es7291_open = int.Parse(listBoxViewData03.Items[61].ToString());
                    es7291_close = int.Parse(listBoxViewData03.Items[62].ToString());

                    ds7221_open = int.Parse(listBoxViewData03.Items[59].ToString());
                    ds7221_close = int.Parse(listBoxViewData03.Items[60].ToString());

                    ds7251_open = int.Parse(listBoxViewData03.Items[47].ToString());
                    ds7251_close = int.Parse(listBoxViewData03.Items[48].ToString());

                    cb7271_open = int.Parse(listBoxViewData03.Items[51].ToString());
                    cb7271_close = int.Parse(listBoxViewData03.Items[52].ToString());

                    ds7261_open = int.Parse(listBoxViewData03.Items[55].ToString());
                    ds7261_close = int.Parse(listBoxViewData03.Items[56].ToString());

                    es7209_1_open = int.Parse(listBoxViewData03.Items[49].ToString());
                    es7209_1_close = int.Parse(listBoxViewData03.Items[50].ToString());

                    es7209_2_open = int.Parse(listBoxViewData03.Items[53].ToString());
                    es7209_2_close = int.Parse(listBoxViewData03.Items[54].ToString());

                    es7209_3_open = int.Parse(listBoxViewData03.Items[57].ToString());
                    es7209_3_close = int.Parse(listBoxViewData03.Items[58].ToString());

                    //62LRL
                    es7309_1_open = int.Parse(listBoxViewData03.Items[91].ToString());
                    es7309_1_close = int.Parse(listBoxViewData03.Items[92].ToString());

                    es7309_2_open = int.Parse(listBoxViewData03.Items[95].ToString());
                    es7309_2_close = int.Parse(listBoxViewData03.Items[96].ToString());

                    es7309_3_open = int.Parse(listBoxViewData03.Items[99].ToString());
                    es7309_3_close = int.Parse(listBoxViewData03.Items[100].ToString());

                    ds7351_open = int.Parse(listBoxViewData03.Items[89].ToString());
                    ds7351_close = int.Parse(listBoxViewData03.Items[90].ToString());

                    cb7371_open = int.Parse(listBoxViewData03.Items[93].ToString());
                    cb7371_close = int.Parse(listBoxViewData03.Items[94].ToString());

                    ds7361_open = int.Parse(listBoxViewData03.Items[97].ToString());
                    ds7361_close = int.Parse(listBoxViewData03.Items[98].ToString());

                    ds7321_open = int.Parse(listBoxViewData03.Items[101].ToString());
                    ds7321_close = int.Parse(listBoxViewData03.Items[102].ToString());

                    es7391_open = int.Parse(listBoxViewData03.Items[103].ToString());
                    es7391_close = int.Parse(listBoxViewData03.Items[104].ToString());

                    //그림: 60LRC, 태그명: 60LRL
                    ds7101_open = int.Parse(listBoxViewData03.Items[17].ToString());
                    ds7101_close = int.Parse(listBoxViewData03.Items[18].ToString());

                    cb7100_open = int.Parse(listBoxViewData03.Items[21].ToString());
                    cb7100_close = int.Parse(listBoxViewData03.Items[22].ToString());

                    ds7102_open = int.Parse(listBoxViewData03.Items[25].ToString());
                    ds7102_close = int.Parse(listBoxViewData03.Items[26].ToString());

                    es7109_4_open = int.Parse(listBoxViewData03.Items[19].ToString());
                    es7109_4_close = int.Parse(listBoxViewData03.Items[20].ToString());

                    es7109_5_open = int.Parse(listBoxViewData03.Items[23].ToString());
                    es7109_5_close = int.Parse(listBoxViewData03.Items[24].ToString());

                    //60LRC?
                    ds7201_open = int.Parse(listBoxViewData03.Items[63].ToString());
                    ds7201_close = int.Parse(listBoxViewData03.Items[64].ToString());

                    cb7200_open = int.Parse(listBoxViewData03.Items[67].ToString());
                    cb7200_close = int.Parse(listBoxViewData03.Items[68].ToString());

                    ds7202_open = int.Parse(listBoxViewData03.Items[71].ToString());
                    ds7202_close = int.Parse(listBoxViewData03.Items[72].ToString());

                    es7209_4_open = int.Parse(listBoxViewData03.Items[65].ToString());
                    es7209_4_close = int.Parse(listBoxViewData03.Items[66].ToString());

                    es7209_5_open = int.Parse(listBoxViewData03.Items[69].ToString());
                    es7209_5_close = int.Parse(listBoxViewData03.Items[70].ToString());

                    ds7301_open = int.Parse(listBoxViewData03.Items[105].ToString());
                    ds7301_close = int.Parse(listBoxViewData03.Items[106].ToString());

                    cb7300_open = int.Parse(listBoxViewData03.Items[109].ToString());
                    cb7300_close = int.Parse(listBoxViewData03.Items[110].ToString());

                    ds7302_open = int.Parse(listBoxViewData03.Items[113].ToString());
                    ds7302_close = int.Parse(listBoxViewData03.Items[114].ToString());

                    es7309_4_open = int.Parse(listBoxViewData03.Items[107].ToString());
                    es7309_4_close = int.Parse(listBoxViewData03.Items[108].ToString());

                    es7309_5_open = int.Parse(listBoxViewData03.Items[111].ToString());
                    es7309_5_close = int.Parse(listBoxViewData03.Items[112].ToString());

                    //61LRT
                    es7192_open = int.Parse(listBoxViewData03.Items[29].ToString());
                    es7192_close = int.Parse(listBoxViewData03.Items[30].ToString());

                    ds7122_open = int.Parse(listBoxViewData03.Items[27].ToString());
                    ds7122_close = int.Parse(listBoxViewData03.Items[28].ToString());

                    ds7162_open = int.Parse(listBoxViewData03.Items[33].ToString());
                    ds7162_close = int.Parse(listBoxViewData03.Items[34].ToString());

                    cb7172_open = int.Parse(listBoxViewData03.Items[37].ToString());
                    cb7172_close = int.Parse(listBoxViewData03.Items[38].ToString());

                    ds7152_open = int.Parse(listBoxViewData03.Items[41].ToString());
                    ds7152_close = int.Parse(listBoxViewData03.Items[42].ToString());

                    es7109_6_open = int.Parse(listBoxViewData03.Items[31].ToString());
                    es7109_6_close = int.Parse(listBoxViewData03.Items[32].ToString());

                    es7109_7_open = int.Parse(listBoxViewData03.Items[35].ToString());
                    es7109_7_close = int.Parse(listBoxViewData03.Items[36].ToString());

                    es7109_8_open = int.Parse(listBoxViewData03.Items[39].ToString());
                    es7109_8_close = int.Parse(listBoxViewData03.Items[40].ToString());

                    //63LRT
                    es7292_open = int.Parse(listBoxViewData03.Items[87].ToString());
                    es7292_close = int.Parse(listBoxViewData03.Items[88].ToString());

                    es7209_6_open = int.Parse(listBoxViewData03.Items[73].ToString());
                    es7209_6_close = int.Parse(listBoxViewData03.Items[74].ToString());

                    ds7262_open = int.Parse(listBoxViewData03.Items[77].ToString());
                    ds7262_close = int.Parse(listBoxViewData03.Items[78].ToString());

                    cb7272_open = int.Parse(listBoxViewData03.Items[81].ToString());
                    cb7272_close = int.Parse(listBoxViewData03.Items[82].ToString());

                    ds7252_open = int.Parse(listBoxViewData03.Items[85].ToString());
                    ds7252_close = int.Parse(listBoxViewData03.Items[86].ToString());

                    ds7222_open = int.Parse(listBoxViewData03.Items[75].ToString());
                    ds7222_close = int.Parse(listBoxViewData03.Items[76].ToString());

                    es7209_7_open = int.Parse(listBoxViewData03.Items[79].ToString());
                    es7209_7_close = int.Parse(listBoxViewData03.Items[80].ToString());

                    es7209_8_open = int.Parse(listBoxViewData03.Items[83].ToString());
                    es7209_8_close = int.Parse(listBoxViewData03.Items[84].ToString());

                    //ds7292 태그 없음
                    es7092_open = int.Parse(listBoxViewData03.Items[45].ToString());
                    es7092_close = int.Parse(listBoxViewData03.Items[46].ToString());

                    //64LRT
                    es7309_6_open = int.Parse(listBoxViewData03.Items[115].ToString());
                    es7309_6_close = int.Parse(listBoxViewData03.Items[116].ToString());

                    ds7362_open = int.Parse(listBoxViewData03.Items[121].ToString());
                    ds7362_close = int.Parse(listBoxViewData03.Items[122].ToString());

                    cb7372_open = int.Parse(listBoxViewData03.Items[125].ToString());
                    cb7372_close = int.Parse(listBoxViewData03.Items[126].ToString());

                    ds7352_open = int.Parse(listBoxViewData03.Items[129].ToString());
                    ds7352_close = int.Parse(listBoxViewData03.Items[130].ToString());

                    ds7322_open = int.Parse(listBoxViewData03.Items[117].ToString());
                    ds7322_close = int.Parse(listBoxViewData03.Items[118].ToString());

                    es7309_7_open = int.Parse(listBoxViewData03.Items[123].ToString());
                    es7309_7_close = int.Parse(listBoxViewData03.Items[124].ToString());

                    es7309_8_open = int.Parse(listBoxViewData03.Items[127].ToString());
                    es7309_8_close = int.Parse(listBoxViewData03.Items[128].ToString());

                    es7392_open = int.Parse(listBoxViewData03.Items[119].ToString());
                    es7392_close = int.Parse(listBoxViewData03.Items[120].ToString());
                }
                ChangeImage61LRL();
                ChangeImage60LRC();
                ChangeImage62LRT();
                ChangeImage62LRL();
                ChangeImage60LRL();
                ChangeImage61LRT();
                ChangeImage63LRT();
                ChangeImage64LRT();
                //Case345kV();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //0이면 닫힘(노랑), 1이면 열림(빨강)
        public void ChangeImage61LRL()
        {
            //ES7191 
            if (es7191_open == 0) { pic_es7191.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7191.Image = Properties.Resources.opened_horizontal; }

            //DS7121
            if (ds7121_open == 0) { pic_ds7121.Image = Properties.Resources.closed_horizontal; }
            else { pic_ds7121.Image = Properties.Resources.opened_horizontal; }

            //DS7151
            if (ds7151_open == 0) { pic_ds7151.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7151.Image = Properties.Resources.opened_vertical; }

            //CB7171
            if (cb7171_open == 0) { pic_cb7171.Image = Properties.Resources.closed_vertical; }
            else { pic_cb7171.Image = Properties.Resources.opened_vertical; }

            //DS7161
            if (ds7161_open == 0) { pic_ds7161.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7161.Image = Properties.Resources.opened_vertical; }

            //ES7109-1
            if (es7109_1_open == 0) { pic_es7109_1.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7109_1.Image = Properties.Resources.opened_horizontal; }

            //ES7109-2
            if (es7109_2_open == 0) { pic_es7109_2.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7109_2.Image = Properties.Resources.opened_horizontal; }

            //ES7109-3
            if (es7109_3_open == 0) { pic_es7109_3.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7109_3.Image = Properties.Resources.opened_horizontal; }
        }

        //0이면 닫힘(노랑), 1이면 열림(빨강)
        public void ChangeImage60LRC()
        {
            //ES7091
            if (es7091_open == 0) { pic_es7091.Image = Properties.Resources.closed_vertical; }
            else { pic_es7091.Image = Properties.Resources.opened_vertical; }
        }

        //0이면 닫힘(노랑), 1이면 열림(빨강)
        public void ChangeImage62LRT()
        {
            //ES7291
            if (es7291_open == 0) { pic_es7291.Image = Properties.Resources.closed_vertical; }
            else { pic_es7291.Image = Properties.Resources.opened_vertical; }

            //DS7221
            if (ds7221_open == 0) { pic_ds7221.Image = Properties.Resources.closed_horizontal; }
            else { pic_ds7221.Image = Properties.Resources.opened_horizontal; }

            //DS7251
            if (ds7251_open == 0) { pic_ds7251.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7251.Image = Properties.Resources.opened_vertical; }
            
            //CB7271
            if (cb7271_open == 0) { pic_cb7271.Image = Properties.Resources.closed_vertical; }
            else { pic_cb7271.Image = Properties.Resources.opened_vertical; }

            //DS7261
            if (ds7261_open == 0) { pic_ds7261.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7261.Image = Properties.Resources.opened_vertical; }

            //ES7209-1
            if (es7209_1_open == 0) { pic_es7209_1.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7209_1.Image = Properties.Resources.opened_horizontal; }

            //ES7209-2
            if (es7209_2_open == 0) { pic_es7209_2.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7209_2.Image = Properties.Resources.opened_horizontal; }

            //ES7209-3
            if (es7209_3_open == 0) { pic_es7209_3.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7209_3.Image = Properties.Resources.opened_horizontal; }
        }

        //0이면 닫힘(노랑), 1이면 열림(빨강)
        public void ChangeImage62LRL()
        {
            //ES7309-1
            if (es7309_1_open == 0) { pic_es7309_1.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7309_1.Image = Properties.Resources.opened_horizontal; }

            //ES7309-2
            if (es7309_2_open == 0) { pic_es7309_2.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7309_2.Image = Properties.Resources.opened_horizontal; }

            //ES7309-3
            if (es7309_3_open == 0) { pic_es7309_3.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7309_3.Image = Properties.Resources.opened_horizontal; }

            //DS7351
            if (ds7351_open == 0) { pic_ds7351.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7351.Image = Properties.Resources.opened_vertical; }

            //CB7371
            if (cb7371_open == 0) { pic_cb7371.Image = Properties.Resources.closed_vertical; }
            else { pic_cb7371.Image = Properties.Resources.opened_vertical; }

            //DS7361
            if (ds7361_open == 0) { pic_ds7361.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7361.Image = Properties.Resources.opened_vertical; }

            //DS7321
            if (ds7321_open == 0) { pic_ds7321.Image = Properties.Resources.closed_horizontal; }
            else { pic_ds7321.Image = Properties.Resources.opened_horizontal; }

            //ES7391
            if (es7391_open == 0) { pic_es7391.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7391.Image = Properties.Resources.opened_horizontal; }
        }

        //0이면 닫힘(노랑), 1이면 열림(빨강)
        public void ChangeImage60LRL()
        {
            //ds7101
            if (ds7101_open == 0) { pic_ds7101.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7101.Image = Properties.Resources.opened_vertical; }

            //cb7100
            if (cb7100_open == 0) { pic_cb7100.Image = Properties.Resources.closed_vertical; }
            else { pic_cb7100.Image = Properties.Resources.opened_vertical; }

            //ds7102
            if (ds7102_open == 0) { pic_ds7102.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7102.Image = Properties.Resources.opened_vertical; }

            //es7109-4
            if (es7109_4_open == 0) { pic_es7109_4.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7109_4.Image = Properties.Resources.opened_horizontal; }

            //es7109-5
            if (es7109_5_open == 0) { pic_es7109_5.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7109_5.Image = Properties.Resources.opened_horizontal; }

            //ds7201
            if (ds7201_open == 0) { pic_ds7201.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7201.Image = Properties.Resources.opened_vertical; }

            //cb7200
            if (cb7200_open == 0) { pic_cb7200.Image = Properties.Resources.closed_vertical; }
            else { pic_cb7200.Image = Properties.Resources.opened_vertical; }

            //ds7202
            if (ds7202_open == 0) { pic_ds7202.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7202.Image = Properties.Resources.opened_vertical; }

            //es7209-4
            if (es7209_4_open == 0) { pic_es7209_4.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7209_4.Image = Properties.Resources.opened_horizontal; }

            //es7209-5
            if (es7209_5_open == 0) { pic_es7209_5.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7209_5.Image = Properties.Resources.opened_horizontal; }

            //ds7301
            if (ds7301_open == 0) { pic_ds7301.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7301.Image = Properties.Resources.opened_vertical; }

            //cb7300
            if (cb7300_open == 0) { pic_cb7300.Image = Properties.Resources.closed_vertical; }
            else { pic_cb7300.Image = Properties.Resources.opened_vertical; }

            //ds7302
            if (ds7302_open == 0) { pic_ds7302.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7302.Image = Properties.Resources.opened_vertical; }

            //es7309-4
            if (es7309_4_open == 0) { pic_es7309_4.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7309_4.Image = Properties.Resources.opened_horizontal; }

            //es7309-5
            if (es7309_5_open == 0) { pic_es7309_5.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7309_5.Image = Properties.Resources.opened_horizontal; }
        }

        //0이면 닫힘(노랑), 1이면 열림(빨강)
        public void ChangeImage61LRT()
        {
            //es7192
            if (es7192_open == 0) { pic_es7192.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7192.Image = Properties.Resources.opened_horizontal; }

            //ds7122
            if (ds7122_open == 0) { pic_ds7122.Image = Properties.Resources.closed_horizontal; }
            else { pic_ds7122.Image = Properties.Resources.opened_horizontal; }

            //ds7162
            if (ds7162_open == 0) { pic_ds7162.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7162.Image = Properties.Resources.opened_vertical; }

            //cb7172
            if (cb7172_open == 0) { pic_cb7172.Image = Properties.Resources.closed_vertical; }
            else { pic_cb7172.Image = Properties.Resources.opened_vertical; }

            //ds7152
            if (ds7152_open == 0) { pic_ds7152.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7152.Image = Properties.Resources.opened_vertical; }

            //es7109-6
            if (es7109_6_open == 0) { pic_es7109_6.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7109_6.Image = Properties.Resources.opened_horizontal; }

            //es7109-7
            if (es7109_7_open == 0) { pic_es7109_7.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7109_7.Image = Properties.Resources.opened_horizontal; }

            //es7109-8
            if (es7109_8_open == 0) { pic_es7109_8.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7109_8.Image = Properties.Resources.opened_horizontal; }
        }

        //0이면 닫힘(노랑), 1이면 열림(빨강)
        public void ChangeImage63LRT()
        {
            //es7292: 그림상으로는 60LRC, 022JS
            if (es7292_open == 0) { pic_es7292.Image = Properties.Resources.closed_vertical; }
            else { pic_es7292.Image = Properties.Resources.opened_vertical; }

            //es7209-6
            if (es7209_6_open == 0) { pic_es7209_6.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7209_6.Image = Properties.Resources.opened_horizontal; }

            //ds7262
            if (ds7262_open == 0) { pic_ds7262.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7262.Image = Properties.Resources.opened_vertical; }

            //cb7272
            if (cb7272_open == 0) { pic_cb7272.Image = Properties.Resources.closed_vertical; }
            else { pic_cb7272.Image = Properties.Resources.opened_vertical; }

            //ds7252
            if (ds7252_open == 0) { pic_ds7252.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7252.Image = Properties.Resources.opened_vertical; }

            //ds7222
            if (ds7222_open == 0) { pic_ds7222.Image = Properties.Resources.closed_horizontal; }
            else { pic_ds7222.Image = Properties.Resources.opened_horizontal; }

            //es7209-7
            if (es7209_7_open == 0) { pic_es7209_7.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7209_7.Image = Properties.Resources.opened_horizontal; }

            //es7209-8
            if (es7209_8_open == 0) { pic_es7209_8.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7209_8.Image = Properties.Resources.opened_horizontal; }

            //20230118 ds7292 -> es7092
            if (es7092_open == 0) { pic_es7092.Image = Properties.Resources.closed_vertical; }
            else { pic_es7092.Image = Properties.Resources.opened_vertical; }
        }

        //0이면 닫힘(노랑), 1이면 열림(빨강)
        public void ChangeImage64LRT()
        {
            //es7309-6
            if (es7309_6_open == 0) { pic_es7309_6.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7309_6.Image = Properties.Resources.opened_horizontal; }

            //ds7362
            if (ds7362_open == 0) { pic_ds7362.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7362.Image = Properties.Resources.opened_vertical; }

            //cb7372
            if (cb7372_open == 0) { pic_cb7372.Image = Properties.Resources.closed_vertical; }
            else { pic_cb7372.Image = Properties.Resources.opened_vertical; }

            //ds7352
            if (ds7352_open == 0) { pic_ds7352.Image = Properties.Resources.closed_vertical; }
            else { pic_ds7352.Image = Properties.Resources.opened_vertical; }

            //ds7322
            if (ds7322_open == 0) { pic_ds7322.Image = Properties.Resources.closed_horizontal; }
            else { pic_ds7322.Image = Properties.Resources.opened_horizontal; }

            //es7309-7
            if (es7309_7_open == 0) { pic_es7309_7.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7309_7.Image = Properties.Resources.opened_horizontal; }

            //es7309-8
            if (es7309_8_open == 0) { pic_es7309_8.Image = Properties.Resources.closed_horizontal; }
            else { pic_es7309_8.Image = Properties.Resources.opened_horizontal; }

            //es7392
            if (es7392_open == 0) { pic_es7392.Image = Properties.Resources.closed_vertical; }
            else { pic_es7392.Image = Properties.Resources.opened_vertical; }
        }

        /*
        //0이면 닫힘(노랑), 1이면 열림(빨강)
        public void Case345kV()
        {
            //1. CB7171, DS7161, DS7151
            if (cb7171_open == 0 && ds7161_open == 0 && ds7151_open == 0)
            {
                pic_345_case1.Visible = true;
            }
            else
            {
                pic_345_case1.Visible = false;
            }

            //2. CB7100, DS7101, DS7102
            if (cb7100_open == 0 && ds7101_open == 0 && ds7102_open == 0)
            {
                pic_345_case2.Visible = true;
            }
            else
            {
                pic_345_case2.Visible = false;
            }

            //3. CB7172, DS7162, DS7152
            if (cb7172_open == 0 && ds7162_open == 0 && ds7152_open == 0)
            {
                pic_345_case3.Visible = true;
            }
            else
            {
                pic_345_case3.Visible = false;
            }

            //4. CB7271, DS7261, DS7251
            if (cb7271_open == 0 && ds7261_open == 0 && ds7251_open == 0)
            {
                pic_345_case4.Visible = true;
            }
            else
            {
                pic_345_case4.Visible = false;
            }

            //5. CB7200, DS7201, DS7202
            if (cb7200_open == 0 && ds7201_open == 0 && ds7202_open == 0)
            {
                pic_345_case5.Visible = true;
            }
            else
            {
                pic_345_case5.Visible = false;
            }

            //6. CB7272, DS7262, DS7252
            if (cb7272_open == 0 && ds7262_open == 0 && ds7252_open == 0)
            {
                pic_345_case6.Visible = true;
            }
            else
            {
                pic_345_case6.Visible = false;
            }

            //7. CB7371, DS7361, DS7351
            if (cb7371_open == 0 && ds7361_open == 0 && ds7351_open == 0)
            {
                pic_345_case7.Visible = true;
            }
            else
            {
                pic_345_case7.Visible = false;
            }

            //8. CB7300, DS7301, DS7302
            if (cb7300_open == 0 && ds7301_open == 0 && ds7302_open == 0)
            {
                pic_345_case8.Visible = true;
            }
            else
            {
                pic_345_case8.Visible = false;
            }

            //9. CB7372, DS7362, DS7352
            if (cb7372_open == 0 && ds7362_open == 0 && ds7352_open == 0)
            {
                pic_345_case9.Visible = true;
            }
            else
            {
                pic_345_case9.Visible = false;
            }

            //10. DS7121
            if (ds7121_open == 0)
            {
                pic_345_case10.Visible = true;
            }
            else
            {
                pic_345_case10.Visible = false;
            }

            //11. DS7321
            if (ds7321_open == 0)
            {
                pic_345_case11.Visible = true;
            }
            else
            {
                pic_345_case11.Visible = false;
            }

            //12. DS7122
            if (ds7122_open == 0)
            {
                pic_345_case12.Visible = true;
                pic_18_case1.Visible = true;
                lbl_ctl01.ForeColor = Color.Yellow;
            }
            else
            {
                lbl_ctl01.ForeColor = Color.White;
                pic_345_case12.Visible = false;
                pic_18_case1.Visible = false;
            }

            //13. DS7322
            if (ds7322_open == 0)
            {
                pic_345_case13.Visible = true;
                pic_18_case4.Visible = true;
                lbl_ctl04.ForeColor = Color.Yellow;
            }
            else
            {
                pic_345_case13.Visible = false;
                pic_18_case4.Visible = false;
                lbl_ctl04.ForeColor = Color.White;
            }

            //14. DS7221
            if (ds7221_open == 0)
            {
                pic_345_case14.Visible = true;
                pic_345_case14_1.Visible = true;
                pic_345_case14_2.Visible = true;
                pic_18_case2.Visible = false;
                lbl_ctl02.ForeColor = Color.Yellow;
            }
            else
            {
                pic_345_case14.Visible = false;
                pic_345_case14_1.Visible = false;
                pic_345_case14_2.Visible = false;
                pic_18_case2.Visible = true;
                lbl_ctl02.ForeColor = Color.White;
            }

            //15. DS7222
            if (ds7222_open == 0)
            {
                pic_345_case15.Visible = true;
                pic_345_case15_1.Visible = true;
                pic_345_case15_2.Visible = true;
                pic_18_case3.Visible = false;
                lbl_ctl03.ForeColor = Color.Yellow;
            }
            else
            {
                pic_345_case15.Visible = false;
                pic_345_case15_1.Visible = false;
                pic_345_case15_2.Visible = false;
                pic_18_case3.Visible = true;
                lbl_ctl03.ForeColor = Color.White;
            }
        }
        */



        //9면: 18kV
        
        //ds3121
        int ds3121_open = 0;        //01GTA_005JS_160DI
        int ds3121_close = 0;       //01GTA_005JS_021DI

        //ds3221
        int ds3221_open = 0;        //02GTA_005JS_160DI
        int ds3221_close = 0;       //02GTA_005JS_021DI

        //ds3321
        int ds3321_open = 0;        //03GTA_005JS_160DI
        int ds3321_close = 0;       //03GTA_005JS_021DI

        //ds3421
        int ds3421_open = 0;        //04GTA_005JS_160DI
        int ds3421_close = 0;       //04GTA_005JS_021DI

        //cb3183
        int cb3183_open = 0;        //11GTA_001JD_160DI
        int cb3183_close = 0;       //11GTA_001JD_021DI

        //cb3283
        int cb3283_open = 0;        //12GTA_001JD_160DI
        int cb3283_close = 0;       //12GTA_001JD_021DI

        //sw01-01b
        int _01sw01_01b_incoming_open = 0;      //20LGA_1SW01B_160DI
        int _01sw01_01b_incoming_close = 0;     //20LGA_1SW01B_021DI
        int _02sw01_01b_incoming_open = 0;      //20LGA_2SW01B_160DI
        int _02sw01_01b_incoming_close = 0;     //20LGA_2SW01B_021DI

        //006js
        int gta01_rds_gen_close = 0;       //1호기 006js 01GTA_006JS_021DI
        int gta02_rds_gen_close = 0;       //2호기 006js 02GTA_006JS_021DI
        int gta03_rds_gen_close = 0;       //3호기 006js 03GTA_006JS_021DI
        int gta04_rds_gen_close = 0;       //4호기 006js 04GTA_006JS_021DI

        //007js
        int gta01_rds_pump_close = 0;        //1호기 007js 01GTA_007JS_021DI
        int gta02_rds_pump_close = 0;        //2호기 007js 02GTA_007JS_021DI
        int gta03_rds_pump_close = 0;        //3호기 007js 03GTA_007JS_021DI
        int gta04_rds_pump_close = 0;        //4호기 007js 04GTA_007JS_021DI
        
        //cb3114
        int cb3114_open = 0;
        int cb3114_close = 0;

        //cb3214
        int cb3214_open = 0;
        int cb3214_close = 0;
        
        //cb3314
        int cb3314_open = 0;
        int cb3314_close = 0;
        
        //cb3414
        int cb3414_open = 0;
        int cb3414_close = 0;

        //ds3122
        int ds3122_open = 0;        //01GTA_005JS_160DI
        int ds3122_close = 0;       //01GTA_005JS_021DI

        //ds3222
        int ds3222_open = 0;        //02GTA_004JS_160DI
        int ds3222_close = 0;       //02GTA_004JS_021DI

        //ds3322
        int ds3322_open = 0;        //03GTA_004JS_160DI
        int ds3322_close = 0;       //03GTA_004JS_021DI

        //ds3422
        int ds3422_open = 0;        //04GTA_004JS_160DI
        int ds3422_close = 0;       //04GTA_004JS_021DI

        //ds3128-2
        int ds3128_2_open = 0;      //01GTA_002JS_160DI
        int ds3128_2_close = 0;     //01GTA_002JS_021DI

        //ds3228-2
        int ds3228_2_open = 0;      //02GTA_002JS_160DI
        int ds3228_2_close = 0;     //02GTA_002JS_021DI

        //ds3328-2
        int ds3328_2_open = 0;      //03GTA_002JS_160DI
        int ds3328_2_close = 0;     //03GTA_002JS_021DI

        //ds3428-2
        int ds3428_2_open = 0;      //04GTA_002JS_160DI
        int ds3428_2_close = 0;     //04GTA_002JS_021DI

        //cb31
        int cb31_open = 0;          //20GTA_001JD_160DI
        int cb31_close = 0;         //20GTA_001JD_021DI

        //cb32
        int cb32_open = 0;          //20SFC_002JD_160DI
        int cb32_close = 0;         //20SFC_002JD_021DI

        //11gta 001js
        int ds3001_open = 0;        //11GTA_001JS_160DI
        int ds3001_close = 0;       //11GTA_001JS_021DI

        //12gta 001js
        int ds3002_open = 0;        //12GTA_001JS_160DI
        int ds3002_close = 0;       //12GTA_001JS_021DI

        //ds3128-1
        int ds3128_1_open = 0;      //01GTA_003JS_160DI
        int ds3128_1_close = 0;     //01GTA_003JS_021DI

        //ds3228-1
        int ds3228_1_open = 0;      //02GTA_003JS_160DI
        int ds3228_1_close = 0;     //02GTA_003JS_021DI

        //ds3328-1
        int ds3328_1_open = 0;      //03GTA_003JS_160DI
        int ds3328_1_close = 0;     //03GTA_003JS_021DI

        //ds3428-1
        int ds3428_1_open = 0;      //04GTA_003JS_160DI
        int ds3428_1_close = 0;     //04GTA_003JS_021DI

        //호기별 정격출력
        double gta01 = 0.0;
        double gta02 = 0.0;
        double gta03 = 0.0;
        double gta04 = 0.0;

        //호기별 정비상태
        string gta01Maint = "";
        string gta02Maint = "";
        string gta03Maint = "";
        string gta04Maint = "";


        private void timer_get_value_09_Tick(object sender, EventArgs e)
        {
            try
            {
                if (listBoxViewData09.Items.Count <= 0) 
                {
                    /*
                    //test
                    ds3121_open = 0;
                    ds3221_open = 0;
                    ds3321_open = 0;
                    ds3421_open = 0;
                    cb3183_open = 0;
                    cb3283_open = 0;
                    _01sw01_01b_incoming_open = 0;
                    _02sw01_01b_incoming_open = 0;

                    gta01_rds_gen_close = 1;
                    gta02_rds_gen_close = 1;
                    gta03_rds_gen_close = 1;
                    gta04_rds_gen_close = 1;

                    gta01_rds_pump_close = 1;
                    gta02_rds_pump_close = 1;
                    gta03_rds_pump_close = 1;
                    gta04_rds_pump_close = 1;

                    cb3114_open = 0;
                    cb3214_open = 0;
                    cb3314_open = 0;
                    cb3414_open = 0;
                    ds3122_open = 0;
                    ds3222_open = 0;
                    ds3322_open = 0;
                    ds3422_open = 0;
                    ds3128_2_open = 0;
                    ds3228_2_open = 0;
                    ds3328_2_open = 0;
                    ds3428_2_open = 0;
                    cb31_open = 0;
                    cb32_open = 0;
                    ds3001_open = 0;
                    ds3002_open = 0;
                    ds3128_1_open = 0;
                    ds3228_1_open = 0;
                    ds3328_1_open = 0;
                    ds3428_1_open = 0;
                    */
                }
                else
                {
                    //ds3121 01GTA_005JS_160DI
                    ds3121_open = int.Parse(listBoxViewData09.Items[9].ToString());
                    ds3121_close = int.Parse(listBoxViewData09.Items[10].ToString());

                    //ds3221 02GTA_005JS_160DI
                    ds3221_open = int.Parse(listBoxViewData09.Items[11].ToString());
                    ds3221_close = int.Parse(listBoxViewData09.Items[12].ToString());

                    //ds3321 03GTA_005JS_160DI
                    ds3321_open = int.Parse(listBoxViewData09.Items[13].ToString());
                    ds3321_close = int.Parse(listBoxViewData09.Items[14].ToString());

                    //ds3421 04GTA_005JS_160DI
                    ds3421_open = int.Parse(listBoxViewData09.Items[15].ToString());
                    ds3421_close = int.Parse(listBoxViewData09.Items[16].ToString());

                    //cb3183 11GTA_001JD_160DI
                    cb3183_open = int.Parse(listBoxViewData09.Items[17].ToString());
                    cb3183_close = int.Parse(listBoxViewData09.Items[18].ToString());

                    //cb3283 12GTA_001JD_160DI
                    cb3283_open = int.Parse(listBoxViewData09.Items[19].ToString());
                    cb3283_close = int.Parse(listBoxViewData09.Items[20].ToString());

                    //1sw01-01b 20LGA_1SW01B_160DI
                    _01sw01_01b_incoming_open = int.Parse(listBoxViewData09.Items[21].ToString());
                    _01sw01_01b_incoming_close = int.Parse(listBoxViewData09.Items[22].ToString());

                    //2sw01-01b 20LGA_2SW01B_160DI
                    _02sw01_01b_incoming_open = int.Parse(listBoxViewData09.Items[23].ToString());
                    _02sw01_01b_incoming_close = int.Parse(listBoxViewData09.Items[24].ToString());

                    //006js
                    gta01_rds_gen_close = int.Parse(listBoxViewData09.Items[25].ToString());
                    gta02_rds_gen_close = int.Parse(listBoxViewData09.Items[26].ToString());
                    gta03_rds_gen_close = int.Parse(listBoxViewData09.Items[27].ToString());
                    gta04_rds_gen_close = int.Parse(listBoxViewData09.Items[28].ToString());

                    //007js
                    gta01_rds_pump_close = int.Parse(listBoxViewData09.Items[29].ToString());
                    gta02_rds_pump_close = int.Parse(listBoxViewData09.Items[30].ToString());
                    gta03_rds_pump_close = int.Parse(listBoxViewData09.Items[31].ToString());
                    gta04_rds_pump_close = int.Parse(listBoxViewData09.Items[32].ToString());

                    //cb3114
                    cb3114_open = int.Parse(listBoxViewData09.Items[1].ToString());
                    cb3114_close = int.Parse(listBoxViewData09.Items[2].ToString());

                    //cb3214
                    cb3214_open = int.Parse(listBoxViewData09.Items[3].ToString());
                    cb3214_close = int.Parse(listBoxViewData09.Items[4].ToString());

                    //cb3314
                    cb3314_open = int.Parse(listBoxViewData09.Items[5].ToString());
                    cb3314_close = int.Parse(listBoxViewData09.Items[6].ToString());

                    //cb3414
                    cb3414_open = int.Parse(listBoxViewData09.Items[7].ToString());
                    cb3414_close = int.Parse(listBoxViewData09.Items[8].ToString());

                    //ds3122 01GTA_005JS_160DI
                    ds3122_open = int.Parse(listBoxViewData09.Items[33].ToString());
                    ds3122_close = int.Parse(listBoxViewData09.Items[34].ToString());

                    //ds3222 02GTA_004JS_160DI
                    ds3222_open = int.Parse(listBoxViewData09.Items[35].ToString());
                    ds3222_close = int.Parse(listBoxViewData09.Items[36].ToString());

                    //ds3322 03GTA_004JS_160DI
                    ds3322_open = int.Parse(listBoxViewData09.Items[37].ToString());
                    ds3322_close = int.Parse(listBoxViewData09.Items[38].ToString());

                    //ds3422 04GTA_004JS_160DI
                    ds3422_open = int.Parse(listBoxViewData09.Items[39].ToString());
                    ds3422_close = int.Parse(listBoxViewData09.Items[40].ToString());

                    //ds3128-2 01GTA_002JS_160DI
                    ds3128_2_open = int.Parse(listBoxViewData09.Items[49].ToString());
                    ds3128_2_close = int.Parse(listBoxViewData09.Items[50].ToString());

                    //ds3228-2 02GTA_002JS_160DI
                    ds3228_2_open = int.Parse(listBoxViewData09.Items[51].ToString());
                    ds3228_2_close = int.Parse(listBoxViewData09.Items[52].ToString());

                    //ds3328-2 03GTA_002JS_160DI
                    ds3328_2_open = int.Parse(listBoxViewData09.Items[53].ToString());
                    ds3328_2_close = int.Parse(listBoxViewData09.Items[54].ToString());

                    //ds3428-2 04GTA_002JS_160DI
                    ds3428_2_open = int.Parse(listBoxViewData09.Items[55].ToString());
                    ds3428_2_close = int.Parse(listBoxViewData09.Items[56].ToString());

                    //cb31 20GTA_001JD_160DI
                    cb31_open = int.Parse(listBoxViewData09.Items[57].ToString());
                    cb31_close = int.Parse(listBoxViewData09.Items[58].ToString());

                    //cb32 20SFC_002JD_160DI
                    cb32_open = int.Parse(listBoxViewData09.Items[59].ToString());
                    cb32_close = int.Parse(listBoxViewData09.Items[60].ToString());

                    //11gta 001js 11GTA_001JS_160DI
                    ds3001_open = int.Parse(listBoxViewData09.Items[61].ToString());
                    ds3001_close = int.Parse(listBoxViewData09.Items[62].ToString());

                    //12gta 001js 12GTA_001JS_160DI
                    ds3002_open = int.Parse(listBoxViewData09.Items[63].ToString());
                    ds3002_close = int.Parse(listBoxViewData09.Items[64].ToString());

                    //ds3128-1 01GTA_003JS_160DI
                    ds3128_1_open = int.Parse(listBoxViewData09.Items[41].ToString());
                    ds3128_1_close = int.Parse(listBoxViewData09.Items[42].ToString());

                    //ds3228-1 02GTA_003JS_160DI
                    ds3228_1_open = int.Parse(listBoxViewData09.Items[43].ToString());
                    ds3228_1_close = int.Parse(listBoxViewData09.Items[44].ToString());

                    //ds3328-1 03GTA_003JS_160DI
                    ds3328_1_open = int.Parse(listBoxViewData09.Items[45].ToString());
                    ds3328_1_close = int.Parse(listBoxViewData09.Items[46].ToString());

                    //ds3428-1 04GTA_003JS_160DI
                    ds3428_1_open = int.Parse(listBoxViewData09.Items[47].ToString());
                    ds3428_1_close = int.Parse(listBoxViewData09.Items[48].ToString());

                    /*
                    //20230320
                    gta01 = 0.0;
                    gta02 = 0.0;
                    gta03 = 0.0;
                    gta04 = 0.0;

                    gta01 = double.Parse(listBoxViewData09.Items[66].ToString());
                    gta02 = double.Parse(listBoxViewData09.Items[67].ToString());
                    gta03 = double.Parse(listBoxViewData09.Items[68].ToString());
                    gta04 = double.Parse(listBoxViewData09.Items[69].ToString());

                    gta01Maint = "";
                    gta02Maint = "";
                    gta03Maint = "";
                    gta04Maint = "";

                    gta01Maint = listBoxViewData09.Items[70].ToString();
                    gta02Maint = listBoxViewData09.Items[71].ToString();
                    gta03Maint = listBoxViewData09.Items[72].ToString();
                    gta04Maint = listBoxViewData09.Items[73].ToString();
                    */
                }

                ChangeImage18kv();
                //Case18kV();
                ChangeEngine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //0면 닫힘(노랑), 1이면 열림(빨강)
        public void ChangeImage18kv()
        {
            //ds3121
            if (ds3121_open == 0) { pic_ds3121.Image = Properties.Resources.closed_vertical; }
            else { pic_ds3121.Image = Properties.Resources.opened_vertical; }

            //ds3221
            if (ds3221_open == 0) { pic_ds3221.Image = Properties.Resources.closed_vertical; }
            else { pic_ds3221.Image = Properties.Resources.opened_vertical; }

            //ds3321
            if (ds3321_open == 0) { pic_ds3321.Image = Properties.Resources.closed_vertical; }
            else { pic_ds3321.Image = Properties.Resources.opened_vertical; }

            //ds3421
            if (ds3421_open == 0) { pic_ds3421.Image = Properties.Resources.closed_vertical; }
            else { pic_ds3421.Image = Properties.Resources.opened_vertical; }

            //ds3122
            if (ds3122_open == 0) { pic_ds3122.Image = Properties.Resources.closed_vertical; }
            else { pic_ds3122.Image = Properties.Resources.opened_vertical; }

            //ds3222
            if (ds3222_open == 0) { pic_ds3222.Image = Properties.Resources.closed_vertical; }
            else { pic_ds3222.Image = Properties.Resources.opened_vertical; }

            //ds3322
            if (ds3322_open == 0) { pic_ds3322.Image = Properties.Resources.closed_vertical; }
            else { pic_ds3322.Image = Properties.Resources.opened_vertical; }

            //ds3422
            if (ds3422_open == 0) { pic_ds3422.Image = Properties.Resources.closed_vertical; }
            else { pic_ds3422.Image = Properties.Resources.opened_vertical; }

            //cb31
            if (cb31_open == 0) { pic_cb31.Image = Properties.Resources.closed_vertical; }
            else { pic_cb31.Image = Properties.Resources.opened_vertical; }

            //cb32
            if (cb32_open == 0) { pic_cb32.Image = Properties.Resources.closed_vertical; }
            else { pic_cb32.Image = Properties.Resources.opened_vertical; }

            //cb3114
            if (cb3114_open == 0) { pic_cb3114.Image = Properties.Resources.closed_vertical; }
            else { pic_cb3114.Image = Properties.Resources.opened_vertical; }

            //cb3214
            if (cb3214_open == 0) { pic_cb3214.Image = Properties.Resources.closed_vertical; }
            else { pic_cb3214.Image = Properties.Resources.opened_vertical; }

            //cb3314
            if (cb3314_open == 0) { pic_cb3314.Image = Properties.Resources.closed_vertical; }
            else { pic_cb3314.Image = Properties.Resources.opened_vertical; }

            //cb3414
            if (cb3414_open == 0) { pic_cb3414.Image = Properties.Resources.closed_vertical; }
            else { pic_cb3414.Image = Properties.Resources.opened_vertical; }

            //ds3128-1
            if (ds3128_1_open == 0) { pic_ds3128_1.Image = Properties.Resources.closed_horizontal; }
            else { pic_ds3128_1.Image = Properties.Resources.opened_horizontal; }

            //ds3228-1
            if (ds3228_1_open == 0) { pic_ds3228_1.Image = Properties.Resources.closed_horizontal; }
            else { pic_ds3228_1.Image = Properties.Resources.opened_horizontal; }

            //ds3328-1
            if (ds3328_1_open == 0) { pic_ds3328_1.Image = Properties.Resources.closed_horizontal; }
            else { pic_ds3328_1.Image = Properties.Resources.opened_horizontal; }

            //ds3428-1
            if (ds3428_1_open == 0) { pic_ds3428_1.Image = Properties.Resources.closed_horizontal; }
            else { pic_ds3428_1.Image = Properties.Resources.opened_horizontal; }

            //ds3128-2
            if (ds3128_2_open == 0) { pic_ds3128_2.Image = Properties.Resources.closed_horizontal; }
            else { pic_ds3128_2.Image = Properties.Resources.opened_horizontal; }

            //ds3228-2
            if (ds3228_2_open == 0) { pic_ds3228_2.Image = Properties.Resources.closed_horizontal; }
            else { pic_ds3228_2.Image = Properties.Resources.opened_horizontal; }

            //ds3328-2
            if (ds3328_2_open == 0) { pic_ds3328_2.Image = Properties.Resources.closed_horizontal; }
            else { pic_ds3328_2.Image = Properties.Resources.opened_horizontal; }

            //ds3428-2
            if (ds3428_2_open == 0) { pic_ds3428_2.Image = Properties.Resources.closed_horizontal; }
            else { pic_ds3428_2.Image = Properties.Resources.opened_horizontal; }

            //cb3183
            if (cb3183_open == 0) { pic_cb3183.Image = Properties.Resources.closed_vertical; }
            else { pic_cb3183.Image = Properties.Resources.opened_vertical; }

            //cb3283
            if (cb3283_open == 0) { pic_cb3283.Image = Properties.Resources.closed_vertical; }
            else { pic_cb3283.Image = Properties.Resources.opened_vertical; }

            //sw01-01b
            if (_01sw01_01b_incoming_open == 0) { pic_01sw01_01b.Image = Properties.Resources.closed_vertical; }
            else { pic_01sw01_01b.Image = Properties.Resources.opened_vertical; }

            //sw02-01b
            if (_02sw01_01b_incoming_open == 0) { pic_02sw01_01b.Image = Properties.Resources.closed_vertical; }
            else { pic_02sw01_01b.Image = Properties.Resources.opened_vertical; }

            //11gta 001js
            if (ds3001_open == 0) { pic_ds3001.Image = Properties.Resources.closed_horizontal; }
            else { pic_ds3001.Image = Properties.Resources.opened_horizontal; }

            //12gta 001js
            if (ds3002_open == 0) { pic_ds3002.Image = Properties.Resources.closed_horizontal; }
            else { pic_ds3002.Image = Properties.Resources.opened_horizontal; }

            //gta01_rds_pump_close
            if (gta01_rds_pump_close == 0) { pic_gta01_007js_p.Image = Properties.Resources.opened_vertical; }
            else { pic_gta01_007js_p.Image = Properties.Resources.closed_vertical; }

            //gta02_rds_pump_close
            if (gta02_rds_pump_close == 0) { pic_gta02_007js_p.Image = Properties.Resources.opened_vertical; }
            else { pic_gta02_007js_p.Image = Properties.Resources.closed_vertical; }

            //gta03_rds_pump_close
            if (gta03_rds_pump_close == 0) { pic_gta03_007js_p.Image = Properties.Resources.opened_vertical; }
            else { pic_gta03_007js_p.Image = Properties.Resources.closed_vertical; }

            //gta04_rds_pump_close
            if (gta04_rds_pump_close == 0) { pic_gta04_007js_p.Image = Properties.Resources.opened_vertical; }
            else { pic_gta04_007js_p.Image = Properties.Resources.closed_vertical; }

            //gta01_rds_gen_close
            if (gta01_rds_gen_close == 0) { pic_gta01_006js_g.Image = Properties.Resources.opened_vertical; }
            else { pic_gta01_006js_g.Image = Properties.Resources.closed_vertical; }

            //gta02_rds_gen_close
            if (gta02_rds_gen_close == 0) { pic_gta02_006js_g.Image = Properties.Resources.opened_vertical; }
            else { pic_gta02_006js_g.Image = Properties.Resources.closed_vertical; }

            //gta03_rds_gen_close
            if (gta03_rds_gen_close == 0) { pic_gta03_006js_g.Image = Properties.Resources.opened_vertical; }
            else { pic_gta03_006js_g.Image = Properties.Resources.closed_vertical; }

            //gta04_rds_gen_close
            if (gta04_rds_gen_close == 0) { pic_gta04_006js_g.Image = Properties.Resources.opened_vertical; }
            else { pic_gta04_006js_g.Image = Properties.Resources.closed_vertical; }
        }



        //발전기 그림 변경
        public void ChangeEngine()
        {
            /*
            Console.WriteLine("1호기 정격출력: " + gta01);
            Console.WriteLine("2호기 정격출력: " + gta02);
            Console.WriteLine("3호기 정격출력: " + gta03);
            Console.WriteLine("4호기 정격출력: " + gta04);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1호기 정비상태: " + gta01Maint);
            Console.WriteLine("2호기 정비상태: " + gta02Maint);
            Console.WriteLine("3호기 정비상태: " + gta03Maint);
            Console.WriteLine("4호기 정비상태: " + gta04Maint);
            Console.WriteLine("----------------------------------");
            */

            //1호기
            if (gta01_rds_gen_close == 0 && gta01_rds_pump_close == 0)
            {
                pic_cb3114.Image = Properties.Resources.opened_vertical;
                pic_engine_1.SetBounds(197, 1840, 93, 146);
                pic_engine_1.Image = Properties.Resources.off_engine;
            }
            if (gta01_rds_gen_close == 1 || gta01_rds_pump_close == 1)
            {
                pic_cb3114.Image = Properties.Resources.closed_vertical;
                pic_engine_1.SetBounds(180, 1820, 128, 183);
                pic_engine_1.Image = Properties.Resources.on_engine;
            }

            //2호기
            if (gta02_rds_gen_close == 0 && gta02_rds_pump_close == 0)
            {
                pic_cb3214.Image = Properties.Resources.opened_vertical;
                pic_engine_2.SetBounds(711, 1840, 93, 146);
                pic_engine_2.Image = Properties.Resources.off_engine;
            }
            if (gta02_rds_gen_close == 1 || gta02_rds_pump_close == 1)
            {
                pic_cb3214.Image = Properties.Resources.closed_vertical;
                pic_engine_2.SetBounds(694, 1820, 128, 183);
                pic_engine_2.Image = Properties.Resources.on_engine;
            }

            //3호기
            if (gta03_rds_gen_close == 0 && gta03_rds_pump_close == 0)
            {
                pic_cb3314.Image = Properties.Resources.opened_vertical;
                pic_engine_3.SetBounds(1133, 1840, 93, 146);
                pic_engine_3.Image = Properties.Resources.off_engine;
            }
            if (gta03_rds_gen_close == 1 || gta03_rds_pump_close == 1)
            {
                pic_cb3314.Image = Properties.Resources.closed_vertical;
                pic_engine_3.SetBounds(1116, 1820, 128, 183);
                pic_engine_3.Image = Properties.Resources.on_engine;
            }

            //4호기
            if (gta04_rds_gen_close == 0 && gta04_rds_pump_close == 0)
            {
                pic_cb3414.Image = Properties.Resources.opened_vertical;
                pic_engine_4.SetBounds(1560, 1840, 93, 146);
                pic_engine_4.Image = Properties.Resources.off_engine;
            }
            if (gta04_rds_gen_close == 1 || gta04_rds_pump_close == 1)
            {
                pic_cb3414.Image = Properties.Resources.closed_vertical;
                pic_engine_4.SetBounds(1543, 1820, 128, 183);
                pic_engine_4.Image = Properties.Resources.on_engine;
            }
        }

        /*
         * 20230321
         * 
            //1호기 정지 또는 정비상태일 때
            if (gta01 == 0 || gta01Maint.Equals("True")) 
            {
                pic_engine_1.SetBounds(197, 1840, 93, 146);
                pic_engine_1.Image = Properties.Resources.off_engine;

                pic_gta01_006js_g.Image = Properties.Resources.opened_vertical;
                pic_gta01_007js_p.Image = Properties.Resources.opened_vertical;
                pic_cb3114.Image = Properties.Resources.opened_vertical;
                //Console.WriteLine("$$$ 1호기 정지 또는 정비");
            }
            //1호기 발전
            if (gta01 > 0 && gta01Maint.Equals("False"))
            {
                pic_engine_1.SetBounds(180, 1820, 128, 183);
                pic_engine_1.Image = Properties.Resources.on_engine;

                pic_gta01_006js_g.Image = Properties.Resources.closed_vertical;
                pic_gta01_007js_p.Image = Properties.Resources.opened_vertical;
                pic_cb3114.Image = Properties.Resources.closed_vertical;
                //Console.WriteLine("$$$ 1호기 발전");
            }
            //1호기 양수
            if (gta01 < 0 && gta01Maint.Equals("False"))
            {
                pic_engine_1.SetBounds(180, 1820, 128, 183);
                pic_engine_1.Image = Properties.Resources.on_engine;

                pic_gta01_006js_g.Image = Properties.Resources.opened_vertical;
                pic_gta01_007js_p.Image = Properties.Resources.closed_vertical;
                pic_cb3114.Image = Properties.Resources.closed_vertical;
                //Console.WriteLine("$$$ 1호기 양수");
            }

            //2호기 정지 또는 정비상태일 때
            if (gta02 == 0 || gta02Maint.Equals("True"))
            {
                pic_engine_2.SetBounds(711, 1840, 93, 146);
                pic_engine_2.Image = Properties.Resources.off_engine;

                pic_gta02_006js_g.Image = Properties.Resources.opened_vertical;
                pic_gta02_007js_p.Image = Properties.Resources.opened_vertical;
                pic_cb3214.Image = Properties.Resources.opened_vertical;
                //Console.WriteLine("$$$ 2호기 정지 또는 정비");
            }
            //2호기 발전
            if (gta02 > 0 && gta02Maint.Equals("False"))
            {
                pic_engine_2.SetBounds(694, 1820, 128, 183);
                pic_engine_2.Image = Properties.Resources.on_engine;

                pic_gta02_006js_g.Image = Properties.Resources.closed_vertical;
                pic_gta02_007js_p.Image = Properties.Resources.opened_vertical;
                pic_cb3214.Image = Properties.Resources.closed_vertical;
                //Console.WriteLine("$$$ 2호기 발전");
            }
            //2호기 양수
            if (gta02 < 0 && gta02Maint.Equals("False"))
            {
                pic_engine_2.SetBounds(694, 1820, 128, 183);
                pic_engine_2.Image = Properties.Resources.on_engine;

                pic_gta02_006js_g.Image = Properties.Resources.opened_vertical;
                pic_gta02_007js_p.Image = Properties.Resources.closed_vertical;
                pic_cb3214.Image = Properties.Resources.closed_vertical;
                //Console.WriteLine("$$$ 2호기 양수");
            }

            //3호기 정지 또는 정비상태일 때
            if (gta03 == 0 || gta03Maint.Equals("True"))
            {
                pic_engine_3.SetBounds(1133, 1840, 93, 146);
                pic_engine_3.Image = Properties.Resources.off_engine;

                pic_gta03_006js_g.Image = Properties.Resources.opened_vertical;
                pic_gta03_007js_p.Image = Properties.Resources.opened_vertical;
                pic_cb3314.Image = Properties.Resources.opened_vertical;
                //Console.WriteLine("$$$ 3호기 정지 또는 정비");
            }
            //3호기 발전
            if (gta03 > 0 && gta03Maint.Equals("False"))
            {
                pic_engine_3.SetBounds(1116, 1820, 128, 183);
                pic_engine_3.Image = Properties.Resources.on_engine;

                pic_gta03_006js_g.Image = Properties.Resources.closed_vertical;
                pic_gta03_007js_p.Image = Properties.Resources.opened_vertical;
                pic_cb3314.Image = Properties.Resources.closed_vertical;
                //Console.WriteLine("$$$ 3호기 발전");
            }
            //3호기 양수
            if (gta03 < 0 && gta03Maint.Equals("False"))
            {
                pic_engine_3.SetBounds(1116, 1820, 128, 183);
                pic_engine_3.Image = Properties.Resources.on_engine;

                pic_gta03_006js_g.Image = Properties.Resources.opened_vertical;
                pic_gta03_007js_p.Image = Properties.Resources.closed_vertical;
                pic_cb3314.Image = Properties.Resources.closed_vertical;
                //Console.WriteLine("$$$ 3호기 양수");
            }

            //4호기 정지 또는 정비상태일 때
            if (gta04 == 0 || gta04Maint.Equals("True"))
            {
                pic_engine_4.SetBounds(1560, 1840, 93, 146);
                pic_engine_4.Image = Properties.Resources.off_engine;

                pic_gta04_006js_g.Image = Properties.Resources.opened_vertical;
                pic_gta04_007js_p.Image = Properties.Resources.opened_vertical;
                pic_cb3414.Image = Properties.Resources.opened_vertical;
                //Console.WriteLine("$$$ 4호기 정지 또는 정비");
            }
            //4호기 발전
            if (gta04 > 0 && gta04Maint.Equals("False"))
            {
                pic_engine_4.SetBounds(1543, 1820, 128, 183);
                pic_engine_4.Image = Properties.Resources.on_engine;

                pic_gta04_006js_g.Image = Properties.Resources.closed_vertical;
                pic_gta04_007js_p.Image = Properties.Resources.opened_vertical;
                pic_cb3414.Image = Properties.Resources.closed_vertical;
                //Console.WriteLine("$$$ 4호기 발전");
            }
            //4호기 양수
            if (gta04 < 0 && gta04Maint.Equals("False"))
            {
                pic_engine_4.SetBounds(1543, 1820, 128, 183);
                pic_engine_4.Image = Properties.Resources.on_engine;

                pic_gta04_006js_g.Image = Properties.Resources.opened_vertical;
                pic_gta04_007js_p.Image = Properties.Resources.closed_vertical;
                pic_cb3414.Image = Properties.Resources.closed_vertical;
                //Console.WriteLine("$$$ 4호기 양수");
            }
         */

        /*
         * 20230308 
         * 
        //1. cb가 open일 때 발전기 off 이미지
        //2. cb가 close일 때 006js, 007js 둘 다 open이면 발전기 off 이미지
        //3. cb가 close일 때 006js, 007js 둘 중 하나라도 close면 발전기 on 이미지

        //cb3xxx_open = 0           close
        //pump_close = 0 (006js)    open
        //gen_close = 0 (007js)     open

        //cb3114
        if (cb3114_open == 1)   //열림
        {
            pic_engine_1.SetBounds(197, 1840, 93, 146);
            pic_engine_1.Image = Properties.Resources.off_engine;
            Console.WriteLine("1호기 cb열림");
        }

        if (cb3114_open == 0)   //닫힘
        {
            if (gta01_rds_pump_close == 0 && gta01_rds_gen_close == 0)  //열림 && 열림 -> 둘 다 열렸을 때
            {
                pic_engine_1.SetBounds(197, 1840, 93, 146);
                pic_engine_1.Image = Properties.Resources.off_engine;
                Console.WriteLine("1호기 cb열림, 발전/양수 둘다 열림");
            }
            else
            {
                pic_engine_1.SetBounds(180, 1820, 128, 183);
                pic_engine_1.Image = Properties.Resources.on_engine;
                Console.WriteLine("1호기 cb열림, 발전/양수 둘중 하나 닫힘");
            }
        }

        //cb3214
        if (cb3214_open == 1)   //열림
        {
            pic_engine_2.SetBounds(711, 1840, 93, 146);
            pic_engine_2.Image = Properties.Resources.off_engine;
            Console.WriteLine("2호기 cb열림");
        }

        if (cb3214_open == 0)   //닫힘
        {
            if (gta02_rds_pump_close == 0 && gta02_rds_gen_close == 0)  //열림 && 열림 -> 둘 다 열렸을 때
            {
                pic_engine_2.SetBounds(711, 1840, 93, 146);
                pic_engine_2.Image = Properties.Resources.off_engine;
                Console.WriteLine("2호기 cb열림, 발전/양수 둘다 열림");
            }      
            else
            {
                pic_engine_2.SetBounds(694, 1820, 128, 183);
                pic_engine_2.Image = Properties.Resources.on_engine;
                Console.WriteLine("2호기 cb열림, 발전/양수 둘중 하나 닫힘");
            }
        }

        //cb3314
        if (cb3314_open == 1)   //열림
        {
            pic_engine_3.SetBounds(1133, 1840, 93, 146);
            pic_engine_3.Image = Properties.Resources.off_engine;
            Console.WriteLine("3호기 cb열림");
        }

        if (cb3314_open == 0)   //닫힘
        {
            if (gta03_rds_pump_close == 0 && gta03_rds_gen_close == 0)  //둘 다 열렸을 때
            {
                pic_engine_3.SetBounds(1133, 1840, 93, 146);
                pic_engine_3.Image = Properties.Resources.off_engine;
                Console.WriteLine("3호기 cb열림, 발전/양수 둘다 열림");
            }
            else
            {
                pic_engine_3.SetBounds(1116, 1820, 128, 183);
                pic_engine_3.Image = Properties.Resources.on_engine;
                Console.WriteLine("3호기 cb열림, 발전/양수 둘중 하나 닫힘");
            }
        } 

        //cb3414
        if (cb3414_open == 1)
        {
            pic_engine_4.SetBounds(1560, 1840, 93, 146);
            pic_engine_4.Image = Properties.Resources.off_engine;
            Console.WriteLine("4호기 cb열림");
        }

        if (cb3414_open == 0)   //닫힘
        {
            if (gta04_rds_pump_close == 0 && gta04_rds_gen_close == 0)  //둘 다 열렸을 때
            {
                pic_engine_4.SetBounds(1560, 1840, 93, 146);
                pic_engine_4.Image = Properties.Resources.off_engine;
                Console.WriteLine("4호기 cb열림, 발전/양수 둘다 열림");
            }
            else
            {
                pic_engine_4.SetBounds(1543, 1820, 128, 183);
                pic_engine_4.Image = Properties.Resources.on_engine;
                Console.WriteLine("4호기 cb열림, 발전/양수 둘중 하나 닫힘");
            }
        }
        */

        /*
         * 20230104
         *
        //cb3114
        if (cb3114_open == 0)
        {
            pic_cb3114.Image = Properties.Resources.closed_vertical;
            pic_engine_1.SetBounds(180, 1820, 128, 183);
            pic_engine_1.Image = Properties.Resources.on_engine;
        }
        else
        {
            pic_cb3114.Image = Properties.Resources.opened_vertical;
            pic_engine_1.SetBounds(197, 1840, 93, 146);
            pic_engine_1.Image = Properties.Resources.off_engine;
        }
        //cb3214
        if (cb3214_open == 0)
        {
            pic_cb3214.Image = Properties.Resources.closed_vertical;
            pic_engine_2.SetBounds(694, 1820, 128, 183);
            pic_engine_2.Image = Properties.Resources.on_engine;
        }
        else
        {
            pic_cb3214.Image = Properties.Resources.opened_vertical;
            pic_engine_2.SetBounds(711, 1840, 93, 146);
            pic_engine_2.Image = Properties.Resources.off_engine;
        }
        //cb3314
        if (cb3314_open == 0)
        {
            pic_cb3314.Image = Properties.Resources.closed_vertical;
            pic_engine_3.SetBounds(1116, 1820, 128, 183);
            pic_engine_3.Image = Properties.Resources.on_engine;
        }
        else
        {
            pic_cb3314.Image = Properties.Resources.opened_vertical;
            pic_engine_3.SetBounds(1133, 1840, 93, 146);
            pic_engine_3.Image = Properties.Resources.off_engine;
        }
        //cb3414
        if (cb3414_open == 0)
        {
            pic_cb3414.Image = Properties.Resources.closed_vertical;
            pic_engine_4.SetBounds(1543, 1820, 128, 183);
            pic_engine_4.Image = Properties.Resources.on_engine;
        }
        else
        {
            pic_cb3414.Image = Properties.Resources.opened_vertical;
            pic_engine_4.SetBounds(1560, 1840, 93, 146);
            pic_engine_4.Image = Properties.Resources.off_engine;
        }
        */




        /*
        //0이면 닫힘(노랑), 1이면 열림(빨강)
        public void Case18kV()
        {
            //1. 소내 변압기 수전 관련
            // 5) 소내변압기 1호기 빨강, ds3121 close, cb3183 close, 01sw01-01b close
            if (pic_18_case1.Visible.ToString().Equals("True") && ds3121_open == 0 
                && cb3183_open == 0 && _01sw01_01b_incoming_open == 0)
            {
                pic_18_case5_1.Visible = true;
                pic_18_case5_2.Visible = true;
                pic_18_case5_3.Visible = true;
            }
            else
            {
                pic_18_case5_1.Visible = false;
                pic_18_case5_2.Visible = false;
                pic_18_case5_3.Visible = false;
            }

            // 6) 소내변압기 2호기 빨강, ds3221 close, cb3183 close, 01sw01-01b close
            if (pic_18_case2.Visible.ToString().Equals("False") && ds3221_open == 0 
                && cb3183_open == 0 && _01sw01_01b_incoming_open == 0)
            {
                pic_18_case6_1.Visible = true;
                pic_18_case6_2.Visible = true;
                pic_18_case6_3.Visible = true;
            }
            else
            {
                pic_18_case6_1.Visible = false;
                pic_18_case6_2.Visible = false;
                pic_18_case6_3.Visible = false;
            }

            // 7) 소내변압기 3호기 빨강, ds3321 close, cb3283 close, 02sw01-01b close
            if (pic_18_case3.Visible.ToString().Equals("False") && ds3321_open == 0 
                && cb3283_open == 0 && _02sw01_01b_incoming_open == 0)
            {
                pic_18_case7_1.Visible = true;
                pic_18_case7_2.Visible = true;
                pic_18_case7_3.Visible = true;
            }
            else
            {
                pic_18_case7_1.Visible = false;
                pic_18_case7_2.Visible = false;
                pic_18_case7_3.Visible = false;
            }

            // 8) 소내변압기 4호기 빨강, ds3421 close, cb3283 close, 02sw01-01b close
            if (pic_18_case4.Visible.ToString().Equals("True") && ds3421_open == 0 
                && cb3283_open == 0 && _02sw01_01b_incoming_open == 0)
            {
                pic_18_case8_1.Visible = true;
                pic_18_case8_2.Visible = true;
                pic_18_case8_3.Visible = true;
            }
            else
            {
                pic_18_case8_1.Visible = false;
                pic_18_case8_2.Visible = false;
                pic_18_case8_3.Visible = false;
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////

            //2. 호기별 발전모드 관련
            // 9) 소내변압기 1호기 빨강, 1호기 006js close, 1호기 cb3114 close
            if (pic_18_case1.Visible.ToString().Equals("True") && gta01_rds_pump_close == 0 && cb3114_open == 0)
            {
                pic_18_case9.Visible = true;
            }
            else
            {
                pic_18_case9.Visible = false;
            }

            // 10) 소내변압기 2호기 빨강, 2호기 006js close, 2호기 cb3214 close
            if (pic_18_case2.Visible.ToString().Equals("False") && gta02_rds_pump_close == 0 && cb3214_open == 0)
            {
                pic_18_case10_1.Visible = true;
                pic_18_case10_2.Visible = true;
                pic_18_case10_3.Visible = true;
            }
            else
            {
                pic_18_case10_1.Visible = false;
                pic_18_case10_2.Visible = false;
                pic_18_case10_3.Visible = false;
            }

            // 11) 소내변압기 3호기 빨강, 3호기 006js close, 3호기 cb3314 close
            if (pic_18_case3.Visible.ToString().Equals("False") && gta03_rds_pump_close == 0 && cb3314_open == 0)
            {
                pic_18_case11_1.Visible = true;
                pic_18_case11_2.Visible = true;
                pic_18_case11_3.Visible = true;
            }
            else
            {
                pic_18_case11_1.Visible = false;
                pic_18_case11_2.Visible = false;
                pic_18_case11_3.Visible = false;
            }

            // 12) 소내변압기 4호기 빨강, 4호기 006js close, 4호기 cb3414 close
            if (pic_18_case4.Visible.ToString().Equals("True") && gta04_rds_pump_close == 0 && cb3414_open == 0)
            {
                pic_18_case12_1.Visible = true;
                pic_18_case12_2.Visible = true;
                pic_18_case12_3.Visible = true;
            }
            else
            {
                pic_18_case12_1.Visible = false;
                pic_18_case12_2.Visible = false;
                pic_18_case12_3.Visible = false;
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////

            //3. 호기별 양수모드 관련
            // 13) 소내변압기 1호기 빨강, 1호기 007js close, 1호기 cb3114 close
            if (pic_18_case1.Visible.ToString().Equals("True") && gta01_rds_gen_close == 0 && cb3114_open == 0)
            {
                pic_18_case13_1.Visible = true;
                pic_18_case13_2.Visible = true;
                pic_18_case13_3.Visible = true;
            }
            else
            {
                pic_18_case13_1.Visible = false;
                pic_18_case13_2.Visible = false;
                pic_18_case13_3.Visible = false;
            }

            // 14) 소내변압기 2호기 빨강, 2호기 007js close, 2호기 cb3214 close
            if (pic_18_case2.Visible.ToString().Equals("False") && gta02_rds_gen_close == 0 && cb3214_open == 0)
            {
                pic_18_case14_1.Visible = true;
                pic_18_case14_2.Visible = true;
                pic_18_case14_3.Visible = true;
            }
            else
            {
                pic_18_case14_1.Visible = false;
                pic_18_case14_2.Visible = false;
                pic_18_case14_3.Visible = false;
            }

            // 15) 소내변압기 3호기 빨강, 3호기 007js close, 3호기 cb3314 close
            if (pic_18_case3.Visible.ToString().Equals("False") && gta03_rds_gen_close == 0 && cb3314_open == 0)
            {
                pic_18_case15_1.Visible = true;
                pic_18_case15_2.Visible = true;
                pic_18_case15_3.Visible = true;
            }
            else
            {
                pic_18_case15_1.Visible = false;
                pic_18_case15_2.Visible = false;
                pic_18_case15_3.Visible = false;
            }

            // 16) 소내변압기 4호기 빨강, 4호기 007js close, 4호기 cb3414 close
            if (pic_18_case4.Visible.ToString().Equals("True") && gta04_rds_gen_close == 0 && cb3414_open == 0)
            {
                pic_18_case16_1.Visible = true;
                pic_18_case16_2.Visible = true;
                pic_18_case16_3.Visible = true;
            }
            else
            {
                pic_18_case16_1.Visible = false;
                pic_18_case16_2.Visible = false;
                pic_18_case16_3.Visible = false;
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //4. 호기별 PC모드 & 회생제동
            // 17) 소내변압기 1호기 빨강, ds3122 close, cb31 close, cb32 close, 11gta 001js close, ds3128-2 close
            if (pic_18_case1.Visible.ToString().Equals("True") && ds3122_open == 0 && cb31_open == 0 
                && cb32_open == 0 && ds3001_open == 0 && ds3128_2_open == 0)
            {
                pic_18_case17_1.Visible = true;
                pic_18_case17_2.Visible = true;
                pic_18_case17_3.Visible = true;
                pic_18_case17_4.Visible = true;
                pic_18_case17_5.Visible = true;
                pic_18_case17_6.Visible = true;
                pic_18_case17_7.Visible = true;
                pic_18_case17_8.Visible = true;
            }
            else
            {
                pic_18_case17_1.Visible = false;
                pic_18_case17_2.Visible = false;
                pic_18_case17_3.Visible = false;
                pic_18_case17_4.Visible = false;
                pic_18_case17_5.Visible = false;
                pic_18_case17_6.Visible = false;
                pic_18_case17_7.Visible = false;
                pic_18_case17_8.Visible = false;
            }

            // 18) 소내변압기 2호기 빨강, ds3222 close, cb31 close, cb32 close, 11gta 001js close, ds3228-2 close
            if (pic_18_case2.Visible.ToString().Equals("False") && ds3222_open == 0 && cb31_open == 0 
                && cb32_open == 0 && ds3001_open == 0 && ds3228_2_open == 0)
            {
                pic_18_case18_1.Visible = true;
                pic_18_case18_2.Visible = true;
                pic_18_case18_3.Visible = true;
                pic_18_case18_4.Visible = true;
                pic_18_case18_5.Visible = true;
                pic_18_case18_6.Visible = true;
                pic_18_case18_7.Visible = true;
                pic_18_case18_8.Visible = true;
            }
            else
            {
                pic_18_case18_1.Visible = false;
                pic_18_case18_2.Visible = false;
                pic_18_case18_3.Visible = false;
                pic_18_case18_4.Visible = false;
                pic_18_case18_5.Visible = false;
                pic_18_case18_6.Visible = false;
                pic_18_case18_7.Visible = false;
                pic_18_case18_8.Visible = false;
            }

            // 19) 소내변압기 3호기 빨강, ds3322 close, cb31 close, cb32 close, 12gta 001js close, ds3328-2 close
            if (pic_18_case3.Visible.ToString().Equals("False") && ds3322_open == 0 && cb31_open == 0 
                && cb32_open == 0 && ds3002_open == 0 && ds3328_2_open == 0)
            {
                pic_18_case19_1.Visible = true;
                pic_18_case19_2.Visible = true;
                pic_18_case19_3.Visible = true;
                pic_18_case19_4.Visible = true;
                pic_18_case19_5.Visible = true;
                pic_18_case19_6.Visible = true;
                pic_18_case19_7.Visible = true;
                pic_18_case19_8.Visible = true;
            }
            else
            {
                pic_18_case19_1.Visible = false;
                pic_18_case19_2.Visible = false;
                pic_18_case19_3.Visible = false;
                pic_18_case19_4.Visible = false;
                pic_18_case19_5.Visible = false;
                pic_18_case19_6.Visible = false;
                pic_18_case19_7.Visible = false;
                pic_18_case19_8.Visible = false;
            }

            // 20) 소내변압기 4호기 빨강, ds3422 close, cb31 close, cb32 close, 12gta 001js close, ds3428-2 close
            if (pic_18_case4.Visible.ToString().Equals("True") && ds3422_open == 0 && cb31_open == 0 
                && cb32_open == 0 && ds3002_open == 0 && ds3428_2_open == 0)
            {
                pic_18_case20_1.Visible = true;
                pic_18_case20_2.Visible = true;
                pic_18_case20_3.Visible = true;
                pic_18_case20_4.Visible = true;
                pic_18_case20_5.Visible = true;
                pic_18_case20_6.Visible = true;
                pic_18_case20_7.Visible = true;
                pic_18_case20_8.Visible = true;
                pic_18_case20_9.Visible = true;
            }
            else
            {
                pic_18_case20_1.Visible = false;
                pic_18_case20_2.Visible = false;
                pic_18_case20_3.Visible = false;
                pic_18_case20_4.Visible = false;
                pic_18_case20_5.Visible = false;
                pic_18_case20_6.Visible = false;
                pic_18_case20_7.Visible = false;
                pic_18_case20_8.Visible = false;
                pic_18_case20_9.Visible = false;
            }

            //5. back to back: 1호기 런처, 234호기 런치드
            // 21) 1호기 런처, 2호기 런치드: cb3114 close, ds3128-1 close, ds3228-2 close
            if (cb3114_open == 0 && ds3128_1_open == 0 && ds3228_2_open == 0)
            {
                pic_18_case21_1.Visible = true;
                pic_18_case21_2.Visible = true;
                pic_18_case21_3.Visible = true;
                pic_18_case21_4.Visible = true;
                pic_18_case21_5.Visible = true;
                pic_18_case21_6.Visible = true;
                pic_18_case21_7.Visible = true;
                pic_18_case21_8.Visible = true;
                pic_18_case21_9.Visible = true;
            }
            else
            {
                pic_18_case21_1.Visible = false;
                pic_18_case21_2.Visible = false;
                pic_18_case21_3.Visible = false;
                pic_18_case21_4.Visible = false;
                pic_18_case21_5.Visible = false;
                pic_18_case21_6.Visible = false;
                pic_18_case21_7.Visible = false;
                pic_18_case21_8.Visible = false;
                pic_18_case21_9.Visible = false;
            }

            // 22) 1호기 런처, 3호기 런치드: cb3114 close, ds3128-1 close, 11gta 001js close, 12gta 001js close, ds3328-2 close
            if (cb3114_open == 0 && ds3128_1_open == 0 && ds3001_open == 0 && ds3002_open == 0 && ds3328_2_open == 0)
            {
                pic_18_case22_1.Visible = true;
                pic_18_case22_2.Visible = true;
                pic_18_case22_3.Visible = true;
                pic_18_case22_4.Visible = true;
                pic_18_case22_5.Visible = true;
                pic_18_case22_6.Visible = true;
                pic_18_case22_7.Visible = true;
                pic_18_case22_8.Visible = true;
                pic_18_case22_9.Visible = true;
            }
            else
            {
                pic_18_case22_1.Visible = false;
                pic_18_case22_2.Visible = false;
                pic_18_case22_3.Visible = false;
                pic_18_case22_4.Visible = false;
                pic_18_case22_5.Visible = false;
                pic_18_case22_6.Visible = false;
                pic_18_case22_7.Visible = false;
                pic_18_case22_8.Visible = false;
                pic_18_case22_9.Visible = false;
            }

            // 23) 1호기 런처, 4호기 런치드: cb3114 close, ds3128-1 close, 11gta 001js close, 12gta 001js close, ds3428-2 close
            if (cb3114_open == 0 && ds3128_1_open == 0 && ds3001_open == 0 && ds3002_open == 0 && ds3428_2_open == 0)
            {
                pic_18_case23_1.Visible = true;
                pic_18_case23_2.Visible = true;
                pic_18_case23_3.Visible = true;
                pic_18_case23_4.Visible = true;
                pic_18_case23_5.Visible = true;
                pic_18_case23_6.Visible = true;
                pic_18_case23_7.Visible = true;
                pic_18_case23_8.Visible = true;
                pic_18_case23_9.Visible = true;
            }
            else
            {
                pic_18_case23_1.Visible = false;
                pic_18_case23_2.Visible = false;
                pic_18_case23_3.Visible = false;
                pic_18_case23_4.Visible = false;
                pic_18_case23_5.Visible = false;
                pic_18_case23_6.Visible = false;
                pic_18_case23_7.Visible = false;
                pic_18_case23_8.Visible = false;
                pic_18_case23_9.Visible = false;
            }

            //6. back to back: 2호기 런처, 134호기 런치드
            // 24) 2호기 런처, 1호기 런치드: cb3214 close, ds3228-1 close, ds3128-2 close
            if (cb3214_open == 0 && ds3228_1_open == 0 && ds3128_2_open == 0)
            {
                pic_18_case24_1.Visible = true;
                pic_18_case24_2.Visible = true;
                pic_18_case24_3.Visible = true;
                pic_18_case24_4.Visible = true;
                pic_18_case24_5.Visible = true;
                pic_18_case24_6.Visible = true;
                pic_18_case24_7.Visible = true;
                pic_18_case24_8.Visible = true;
            }
            else
            {
                pic_18_case24_1.Visible = false;
                pic_18_case24_2.Visible = false;
                pic_18_case24_3.Visible = false;
                pic_18_case24_4.Visible = false;
                pic_18_case24_5.Visible = false;
                pic_18_case24_6.Visible = false;
                pic_18_case24_7.Visible = false;
                pic_18_case24_8.Visible = false;
            }

            // 25) 2호기 런처, 3호기 런치드: cb3214 close, ds3228-1 close, 11gta 001js close, 12gta 001js close, ds3328-2 close
            if (cb3214_open == 0 && ds3228_1_open == 0 && ds3001_open == 0 && ds3002_open == 0 && ds3328_2_open == 0)
            {
                pic_18_case25_1.Visible = true;
                pic_18_case25_2.Visible = true;
                pic_18_case25_3.Visible = true;
                pic_18_case25_4.Visible = true;
                pic_18_case25_5.Visible = true;
                pic_18_case25_7.Visible = true;
                pic_18_case25_8.Visible = true;
            }
            else
            {
                pic_18_case25_1.Visible = false;
                pic_18_case25_2.Visible = false;
                pic_18_case25_3.Visible = false;
                pic_18_case25_4.Visible = false;
                pic_18_case25_5.Visible = false;
                pic_18_case25_7.Visible = false;
                pic_18_case25_8.Visible = false;
            }

            // 26) 2호기 런처, 4호기 런치드: cb3214 close, ds3228-1 close, 11gta 001js close, 12gta 001js close, ds3428-2 close
            if (cb3214_open == 0 && ds3228_1_open == 0 && ds3001_open == 0 && ds3002_open == 0 && ds3428_2_open == 0)
            {
                pic_18_case26_1.Visible = true;
                pic_18_case26_2.Visible = true;
                pic_18_case26_3.Visible = true;
                pic_18_case26_4.Visible = true;
                pic_18_case26_5.Visible = true;
                pic_18_case26_6.Visible = true;
                pic_18_case26_7.Visible = true;
            }
            else
            {
                pic_18_case26_1.Visible = false;
                pic_18_case26_2.Visible = false;
                pic_18_case26_3.Visible = false;
                pic_18_case26_4.Visible = false;
                pic_18_case26_5.Visible = false;
                pic_18_case26_6.Visible = false;
                pic_18_case26_7.Visible = false;
            }

            //7. back to back: 3호기 런처, 124호기 런치드
            // 27) 3호기 런처, 1호기 런치드: cb3314 close, ds3328-1 close, 12gta 001js close, 11gta 001js close, ds3128-2 close
            if (cb3314_open == 0 && ds3328_1_open == 0 && ds3002_open == 0 && ds3001_open == 0 && ds3128_2_open == 0)
            {
                pic_18_case27_1.Visible = true;
                pic_18_case27_2.Visible = true;
                pic_18_case27_3.Visible = true;
                pic_18_case27_4.Visible = true;
                pic_18_case27_5.Visible = true;
                pic_18_case27_6.Visible = true;
                pic_18_case27_7.Visible = true;
            }
            else
            {
                pic_18_case27_1.Visible = false;
                pic_18_case27_2.Visible = false;
                pic_18_case27_3.Visible = false;
                pic_18_case27_4.Visible = false;
                pic_18_case27_5.Visible = false;
                pic_18_case27_6.Visible = false;
                pic_18_case27_7.Visible = false;
            }

            // 28) 3호기 런처, 2호기 런치드: cb3314 close, ds3328-1 close, 12gta 001js close, 11gta 001js close, ds3228-2 close
            if (cb3314_open == 0 && ds3328_1_open == 0 && ds3002_open == 0 && ds3001_open == 0 && ds3228_2_open == 0)
            {
                pic_18_case28_1.Visible = true;
                pic_18_case28_2.Visible = true;
                pic_18_case28_3.Visible = true;
                pic_18_case28_4.Visible = true;
                pic_18_case28_5.Visible = true;
                pic_18_case28_6.Visible = true;
                pic_18_case28_7.Visible = true;
                pic_18_case28_8.Visible = true;
                pic_18_case28_9.Visible = true;
            }
            else
            {
                pic_18_case28_1.Visible = false;
                pic_18_case28_2.Visible = false;
                pic_18_case28_3.Visible = false;
                pic_18_case28_4.Visible = false;
                pic_18_case28_5.Visible = false;
                pic_18_case28_6.Visible = false;
                pic_18_case28_7.Visible = false;
                pic_18_case28_8.Visible = false;
                pic_18_case28_9.Visible = false;
            }

            // 29) 3호기 런처, 4호기 런치드: cb3314 close, ds3328-1 close, ds3428-2 close
            if (cb3314_open == 0 && ds3328_1_open == 0 && ds3428_2_open == 0)
            {
                pic_18_case29_1.Visible = true;
                pic_18_case29_2.Visible = true;
                pic_18_case29_3.Visible = true;
                pic_18_case29_4.Visible = true;
                pic_18_case29_5.Visible = true;
                pic_18_case29_6.Visible = true;
                pic_18_case29_7.Visible = true;
                pic_18_case29_8.Visible = true;
                pic_18_case29_9.Visible = true;
            }
            else
            {
                pic_18_case29_1.Visible = false;
                pic_18_case29_2.Visible = false;
                pic_18_case29_3.Visible = false;
                pic_18_case29_4.Visible = false;
                pic_18_case29_5.Visible = false;
                pic_18_case29_6.Visible = false;
                pic_18_case29_7.Visible = false;
                pic_18_case29_8.Visible = false;
                pic_18_case29_9.Visible = false;
            }

            //8. back to back: 4호기 런처, 123호기 런치드
            // 30) 4호기 런처, 1호기 런치드: cb3414 close, ds3428-1 close, 12gta 001js close, 11gta 001js close, ds3128-2 close
            if (cb3414_open == 0 && ds3428_1_open == 0 && ds3002_open == 0 && ds3001_open == 0 && ds3128_2_open == 0)
            {
                pic_18_case30_1.Visible = true;
                pic_18_case30_2.Visible = true;
                pic_18_case30_3.Visible = true;
                pic_18_case30_4.Visible = true;
                pic_18_case30_5.Visible = true;
                pic_18_case30_6.Visible = true;
                pic_18_case30_7.Visible = true;
                pic_18_case30_8.Visible = true;
            }
            else
            {
                pic_18_case30_1.Visible = false;
                pic_18_case30_2.Visible = false;
                pic_18_case30_3.Visible = false;
                pic_18_case30_4.Visible = false;
                pic_18_case30_5.Visible = false;
                pic_18_case30_6.Visible = false;
                pic_18_case30_7.Visible = false;
                pic_18_case30_8.Visible = false;
            }

            // 31) 4호기 런처, 2호기 런치드: cb3414 close, ds3428-1 close, 12gta 001js close, 11gta 001js close, ds3228-2 close
            if (cb3414_open == 0 && ds3428_1_open == 0 && ds3002_open == 0 && ds3001_open == 0 && ds3228_2_open == 0)
            {
                pic_18_case31_1.Visible = true;
                pic_18_case31_2.Visible = true;
                pic_18_case31_3.Visible = true;
                pic_18_case31_4.Visible = true;
                pic_18_case31_5.Visible = true;
                pic_18_case31_6.Visible = true;
                pic_18_case31_7.Visible = true;
                pic_18_case31_8.Visible = true;
            }
            else
            {
                pic_18_case31_1.Visible = false;
                pic_18_case31_2.Visible = false;
                pic_18_case31_3.Visible = false;
                pic_18_case31_4.Visible = false;
                pic_18_case31_5.Visible = false;
                pic_18_case31_6.Visible = false;
                pic_18_case31_7.Visible = false;
                pic_18_case31_8.Visible = false;
            }

            // 32) 4호기 런처, 3호기 런치드: cb3414 close, ds3428-1 close, ds3328-2 close
            if (cb3414_open == 0 && ds3428_1_open == 0 && ds3328_2_open == 0)
            {
                pic_18_case32_1.Visible = true;
                pic_18_case32_2.Visible = true;
                pic_18_case32_3.Visible = true;
                pic_18_case32_4.Visible = true;
                pic_18_case32_5.Visible = true;
                pic_18_case32_6.Visible = true;
            }
            else
            {
                pic_18_case32_1.Visible = false;
                pic_18_case32_2.Visible = false;
                pic_18_case32_3.Visible = false;
                pic_18_case32_4.Visible = false;
                pic_18_case32_5.Visible = false;
                pic_18_case32_6.Visible = false;
            }

        }
        */








        public void SetLocation()
        {
            //set1 회로도 가로컨트롤
            int x1 = 0;
            int y1 = 0;
            int w1 = 65;
            int h1 = 30;
            //set2 회로도 세로컨트롤
            int x2 = 0;
            int y2 = 0;
            int w2 = 30;
            int h2 = 65;
            // set3 차단기 open/close
            int w3 = 22;
            int h3 = 22;

            //61LRL
            pic_es7191.SetBounds(86, 375, w1, h1);
            pic_ds7121.SetBounds(244, 375, w1, h1);
            pic_ds7151.SetBounds(358, 154, w2, h2);
            pic_cb7171.SetBounds(358, 237, w2, h2);
            //pic_cb7171_open.SetBounds(238, 256, w3, h3);    //cb7171-open
            //pic_cb7171_close.SetBounds(288, 256, w3, h3);   //cb7171-close
            pic_ds7161.SetBounds(358, 319, w2, h2);
            pic_es7109_1.SetBounds(441, 212, w1, h1);
            pic_es7109_2.SetBounds(441, 293, w1, h1);
            pic_es7109_3.SetBounds(441, 375, w1, h1);

            //60LRC
            pic_es7091.SetBounds(642, 166, w2, h2);

            //62LRT
            pic_es7291.SetBounds(742, 298, w2, h2);
            pic_ds7221.SetBounds(836, 375, w1, h1);
            pic_ds7251.SetBounds(956, 154, w2, h2);
            pic_cb7271.SetBounds(956, 237, w2, h2);
            //pic_cb7271_open.SetBounds(836, 256, w3, h3);    //cb7271-open
            //pic_cb7271_close.SetBounds(886, 256, w3, h3);   //cb7271-close
            pic_ds7261.SetBounds(956, 319, w2, h2);
            pic_es7209_1.SetBounds(1022, 211, w1, h1);
            pic_es7209_2.SetBounds(1022, 293, w1, h1);
            pic_es7209_3.SetBounds(1022, 375, w1, h1);

            //62LRL
            pic_es7309_1.SetBounds(1363, 211, w1, h1);
            pic_es7309_2.SetBounds(1363, 293, w1, h1);
            pic_es7309_3.SetBounds(1363, 375, w1, h1);
            pic_ds7351.SetBounds(1451, 154, w2, h2);
            pic_cb7371.SetBounds(1451, 237, w2, h2);        //cb7371 누락
            //pic_cb7371_open.SetBounds(1441, 256, w3, h3);   //cb7371-open
            //pic_cb7371_close.SetBounds(1441, 256, w3, h3);  //cb7371-close
            pic_ds7361.SetBounds(1451, 319, w2, h2);
            pic_ds7321.SetBounds(1566, 375, w1, h1);
            pic_es7391.SetBounds(1773, 375, w1, h1);

            //그림: 60LRC, 태그명: 60LRL
            pic_ds7101.SetBounds(358, 457, w2, h2);
            pic_cb7100.SetBounds(358, 545, w2, h2);
            //pic_cb7100_open.SetBounds(238, 566, w3, h3);    //cb7100-open
            //pic_cb7100_close.SetBounds(288, 566, w3, h3);   //cb7100-close
            pic_ds7102.SetBounds(358, 632, w2, h2);
            pic_es7109_4.SetBounds(441, 517, w1, h1);
            pic_es7109_5.SetBounds(441, 605, w1, h1);

            //60LRC
            pic_ds7201.SetBounds(956, 457, w2, h2);
            pic_cb7200.SetBounds(956, 545, w2, h2);
            //pic_cb7200_open.SetBounds(836, 566, w3, h3);    //cb7200-open
            //pic_cb7200_close.SetBounds(886, 566, w3, h3);   //cb7200-close
            pic_ds7202.SetBounds(956, 632, w2, h2);
            pic_es7209_4.SetBounds(1022, 517, w1, h1);
            pic_es7209_5.SetBounds(1022, 605, w1, h1);

            //60LRC
            pic_ds7301.SetBounds(1451, 457, w2, h2);
            pic_cb7300.SetBounds(1451, 545, w2, h2);
            //pic_cb7300_open.SetBounds(1332, 566, w3, h3);   //cb7300-open
            //pic_cb7300_close.SetBounds(1382, 566, w3, h3);  //cb7300-close
            pic_ds7302.SetBounds(1451, 632, w2, h2);
            pic_es7309_4.SetBounds(1512, 517, w1, h1);
            pic_es7309_5.SetBounds(1512, 605, w1, h1);

            //61LRT
            pic_es7192.SetBounds(86, 736, w1, h1);
            pic_ds7122.SetBounds(244, 736, w1, h1);
            pic_ds7162.SetBounds(358, 764, w2, h2);
            pic_cb7172.SetBounds(358, 845, w2, h2);
            //pic_cb7172_open.SetBounds(238, 864, w3, h3);   //cb7172-open
            //pic_cb7172_close.SetBounds(288, 864, w3, h3);   //cb7172-close
            pic_ds7152.SetBounds(358, 926, w2, h2);
            pic_es7109_6.SetBounds(441, 736, w1, h1);
            pic_es7109_7.SetBounds(441, 818, w1, h1);
            pic_es7109_8.SetBounds(441, 900, w1, h1);

            //60LRC
            pic_es7292.SetBounds(642, 921, w2, h2);

            //63LRT
            pic_es7209_6.SetBounds(836, 736, w1, h1);
            pic_ds7262.SetBounds(956, 764, w2, h2);
            pic_cb7272.SetBounds(956, 845, w2, h2);
            //pic_cb7272_open.SetBounds(836, 864, w3, h3);    //cb7272-open
            //pic_cb7272_close.SetBounds(886, 864, w3, h3);   //cb7272-close
            pic_ds7252.SetBounds(956, 926, w2, h2);
            pic_ds7222.SetBounds(1022, 736, w1, h1);
            pic_es7209_7.SetBounds(1022, 818, w1, h1);
            pic_es7209_8.SetBounds(1022, 900, w1, h1);
            pic_es7092.SetBounds(1209, 774, w2, h2);

            //64LRT
            pic_es7309_6.SetBounds(1310, 736, w1, h1);      //es7309-6 누락
            pic_ds7362.SetBounds(1451, 764, w2, h2);
            pic_cb7372.SetBounds(1451, 845, w2, h2);
            //pic_cb7372_open.SetBounds(1332, 864, w3, h3);   //cb7372-open
            //pic_cb7372_close.SetBounds(1382, 864, w3, h3);  //cb7372-close
            pic_ds7352.SetBounds(1454, 926, w2, h2);
            pic_ds7322.SetBounds(1512, 736, w1, h1);
            pic_es7309_7.SetBounds(1512, 818, w1, h1);
            pic_es7309_8.SetBounds(1512, 900, w1, h1);
            pic_es7392.SetBounds(1809, 774, w2, h2);
        }

        private void Timer_DCS_DATA_UPDATE(object sender, EventArgs e)
        {
            //ChangeImage61LRL();
            //ChangeImage60LRC();
            //ChangeImage62LRT();
            //ChangeImage62LRL();
            //ChangeImage60LRL();
            //ChangeImage61LRT();
            //ChangeImage63LRT();
            //ChangeImage64LRT();

            //Case345kV();
            //Case18kV();

            //ChangeImage18kv();
        }

        private void timer_clock_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToString("yyyy.MM.dd tt hh:mm:ss");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
