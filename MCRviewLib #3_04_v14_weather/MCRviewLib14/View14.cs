using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using CefSharp;
using CefSharp.WinForms;

namespace MCRviewLib14
{
    public partial class View14 : Form
    {

        public ChromiumWebBrowser browser = null;
        string dateTime = System.DateTime.Now.ToString("yyyy.MM.dd tt hh:mm:ss");

        public View14()
        {
            InitializeComponent();
            InitializeCefSharp();
        }

        private void InitializeCefSharp()
        {
            /*
            //쿠키 사용
            CefSettings settings = new CefSettings();
            settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEF";
            Cef.Initialize(settings);
            */

            //1209 날씨예보 웹
            browser = new ChromiumWebBrowser("http://192.168.10.2:8095");

            //한국어 설정
            browser.BrowserSettings.AcceptLanguageList = "ko-KR";
            //Main Form에 CefSharp컨트롤 추가 
            this.Controls.Add(browser);
            //Main Form의 전체 영역에 크롬 브라우저 붙이기
            browser.Dock = DockStyle.Fill;
        }

        private void View13_Load(object sender, EventArgs e)
        {
            lbl_clock.Text = dateTime;

            timer_clock.Interval = 1000;
            timer_clock.Start();

            //timer_RefreshWeb.Interval = 60 * 60 * 1000;     //1시간
            //timer_RefreshWeb.Interval = 1000;
            //timer_RefreshWeb.Start();
        }

        public void btn_close_Click(object sender, EventArgs e)
        {
            //Cef.Shutdown();
            browser.Dispose();
            //Close();

            btn_reload.Enabled = false;
            Console.WriteLine("크롬 브라우저 닫기");
            //Console.WriteLine("브라우저: " + browser.IsDisposed);
        }

        public void btn_reload_Click(object sender, EventArgs e)
        {
            browser.Reload();
            //browser.Refresh();
            Console.WriteLine("페이지 새로고침");
        }

        public void btn_restart_Click(object sender, EventArgs e)
        {
            //Application.Restart();

            try
            {
                browser.Reload();
                //browser.Refresh();
            }
            catch (Exception ex)
            {
                InitializeCefSharp();
                Console.WriteLine(dateTime + ex.Message + "\n" + " 크롬 브라우저 재시작");
            }
        }

        public void timer_RefreshWeb_Tick(object sender, EventArgs e)
        {
            //20221021dy timer_RefreshWeb_Tick에서 NullReferenceException발생
            try
            {
                browser.Reload();
                //browser.Refresh();
            }
            catch (Exception ex)
            {
                InitializeCefSharp();
                Console.WriteLine(dateTime + ex.Message + "\n" + " 크롬 브라우저 재시작");
            }
        }


        public void MemoryCheck()
        {
            Console.WriteLine("\r" + "Memory Refresh....");

            Process[] all2 = Process.GetProcessesByName("MCRsysMain");
            //Process[] all2 = Process.GetProcessesByName("MCRviewLib14");
            foreach (Process thisProc in all2.OrderBy(x => x.ProcessName))
            {
                Console.WriteLine("=====================================================");
                string Name = thisProc.ProcessName;
                DateTime dt = DateTime.Now;
                string currentTime = dt.ToString("yyyy-MM-dd HH:mm:ss");

                Console.WriteLine("시간: " + currentTime);
                Console.WriteLine("프로세스 이름: " + Name);
                Console.WriteLine("권한 있는 프로세서 시간: " + thisProc.PrivilegedProcessorTime);
                Console.WriteLine("총 프로세서 시간: " + thisProc.TotalProcessorTime);
                Console.WriteLine("사용자 프로세서 시간: " + thisProc.UserProcessorTime);

                Console.WriteLine("페이징 메모리: " + thisProc.PagedMemorySize64);
                Console.WriteLine("프로세스에 할당된 전용 메모리: " + thisProc.PrivateMemorySize64);
                Console.WriteLine("실제 메모리 사용량: " + thisProc.WorkingSet64); // 작업관리자에서 보이는 메모리 사용량
                Console.WriteLine("=====================================================");
            }
                /*
                Console.WriteLine("비페이징 시스템 메모리: " + thisProc.NonpagedSystemMemorySize64);
                Console.WriteLine("페이징할 수 있는 시스템 메모리: " + thisProc.PagedSystemMemorySize64);
                Console.WriteLine("가상 메모리 페이징 파일의 최대 메모리: " + thisProc.PeakPagedMemorySize64);
                Console.WriteLine("가상 메모리의 최대 양: " + thisProc.PeakVirtualMemorySize64);
                Console.WriteLine("실제 메모리의 최대 양: " + thisProc.PeakWorkingSet64);
                Console.WriteLine("스레드의 실행을 예약할 수 있는 프로세서: " + thisProc.ProcessorAffinity);
                Console.WriteLine("가상 메모리: " + thisProc.VirtualMemorySize64);
                */

                /*
                webView21.Reload();

                Process[] all1 = Process.GetProcessesByName("MCRviewLib14");
                foreach (Process thisProc in all1.OrderBy(x => x.ProcessName))
                {
                    Console.WriteLine("=====================================================");
                    string Name = thisProc.ProcessName;
                    Console.WriteLine("프로세스 이름: " + Name);
                    Console.WriteLine("비페이징 시스템 메모리: " + thisProc.NonpagedSystemMemorySize64);
                    Console.WriteLine("페이징 메모리: " + thisProc.PagedMemorySize64);
                    Console.WriteLine("페이징할 수 있는 시스템 메모리: " + thisProc.PagedSystemMemorySize64);
                    Console.WriteLine("가상 메모리 페이징 파일의 최대 메모리: " + thisProc.PeakPagedMemorySize64);
                    Console.WriteLine("가상 메모리의 최대 양: " + thisProc.PeakVirtualMemorySize64);
                    Console.WriteLine("실제 메모리의 최대 양: " + thisProc.PeakWorkingSet64);
                    Console.WriteLine("프로세스에 할당된 전용 메모리: " + thisProc.PrivateMemorySize64);
                    Console.WriteLine("권한 있는 프로세서 시간: " + thisProc.PrivilegedProcessorTime);
                    Console.WriteLine("스레드의 실행을 예약할 수 있는 프로세서: " + thisProc.ProcessorAffinity);
                    Console.WriteLine("총 프로세서 시간: " + thisProc.TotalProcessorTime);
                    Console.WriteLine("사용자 프로세서 시간: " + thisProc.UserProcessorTime);
                    Console.WriteLine("가상 메모리: " + thisProc.VirtualMemorySize64);
                    Console.WriteLine("실제 메모리 사용량: " + thisProc.WorkingSet64); // 작업관리자에서 보이는 메모리 사용량
                    Console.WriteLine("=====================================================");
                }
            */
        }

        private void timer_clock_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = System.DateTime.Now.ToString("yyyy.MM.dd tt hh:mm:ss");
        }
    }
}
