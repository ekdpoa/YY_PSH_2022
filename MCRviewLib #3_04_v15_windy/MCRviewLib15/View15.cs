using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CefSharp;
using CefSharp.WinForms;

namespace MCRviewLib15
{
    public partial class View15 : Form
    {

        string dateTime = DateTime.Now.ToString("yyyy.MM.dd tt hh:mm:ss");
        private ChromiumWebBrowser browser_v6 = null;

        public View15()
        {
            InitializeComponent();
            InitializeCefSharp();
        }

        private void View06_Load(object sender, EventArgs e)
        {
            lbl_clock.Text = dateTime;

            //timer_clock.Interval = 1000;
            //timer_clock.Start();

            //timer_reload_v6.Interval = 1000*60*15;
            //timer_reload_v6.Enabled = true;
        }

        private void InitializeCefSharp()
        {
            /*
            //쿠키 데이터 사용하는 방법
            CefSettings settings = new CefSettings();
            settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEF";
            Cef.Initialize(settings);
            */

            //웹 사이트 이동
            //단기예보 웹페이지
            //browser_v6 = new ChromiumWebBrowser("http://192.168.10.2:8093/");
            //1209 윈디
            //browser_v6 = new ChromiumWebBrowser("https://embed.windy.com/embed2.html?lat=35.199&lon=129.534&detailLat=35.199&detailLon=129.534&width=650&height=450&zoom=7&level=surface&overlay=rain&product=ecmwf&menu=&message=&marker=&calendar=now&pressure=&type=map&location=coordinates&detail=&metricWind=default&metricTemp=default&radarRange=-1");
            //1226 윈디 웹서버
            browser_v6 = new ChromiumWebBrowser("http://192.168.10.2:8093/windy.jsp");


            //한국어 설정
            browser_v6.BrowserSettings.AcceptLanguageList = "ko-KR";
            //Main Form에 CefSharp컨트롤 추가
            this.Controls.Add(browser_v6);
            //Main Form 전체 영역에 붙이기
            browser_v6.Dock = DockStyle.Fill;
        }

        /*
        //새로고침
        public void btn_reload_Click(object sender, EventArgs e)
        {
            //browser_v6.Refresh();
            browser_v6.Reload();
            Console.WriteLine(dateTime + " v6 페이지 새로고침");
        }
        */

        //로딩 멈춤
        public void btn_stop_Click(object sender, EventArgs e)
        {
            //Cef.Shutdown();
            //this.Close();

            //browser_v6.Dispose();

            browser_v6.Stop();
            //browser_v6.GetBrowser().Reload(true);
            Controls.Remove(browser_v6);
            //Controls.Clear();
            
            browser_v6.Delete();
            browser_v6 = null;
            //Cef.GetGlobalCookieManager().DeleteCookies("", "");


            //Console.WriteLine(browser_v6.IsDisposed);
            //btn_restart.Enabled = false;

            Console.WriteLine(dateTime + " v6 브라우저 중지");
        }
        
        //재시작
        public void btn_restart_Click(object sender, EventArgs e)
        {
            //Application.Restart();

            InitializeCefSharp();

            /*
            try
            {
                //browser_v6.Refresh();
                //Controls.Add(browser_v6);
                browser_v6.Reload();
                Console.WriteLine(dateTime + " v6 페이지 새로고침");
            }
            catch (Exception ex)
            {
                Console.WriteLine("v6 오류메세지: " + ex.ToString());
                InitializeCefSharp();
                Console.WriteLine(dateTime + " v6 크롬 브라우저 재시작");
            }
            */
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void timer_reload_v6_Tick(object sender, EventArgs e)
        {
            btn_restart_Click(sender, e);
        }

        private void timer_clock_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToString("yyyy.MM.dd tt hh:mm:ss");
        }

    }
}
