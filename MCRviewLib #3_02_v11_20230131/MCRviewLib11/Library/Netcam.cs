using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing; //외부라이브러리 관련

//namespace VMS_CS
namespace MCRviewLib11
{
    public static class Netcam
    {
//         #define FLG_UI_EXT 				(1 << 0)
//         #define FLG_UI_MOTION 			(1 << 1)
//         #define FLG_UI_RECORD 			(1 << 2)
// 
//         #define FLG_UI_AVI 				(1 << 3) // depreciated
//         #define FLG_UI_NO_AUTHORIZATION	(1 << 3) // added by jmpark, 2013/12/10
// 
//         #define FLG_UI_JPG 					(1 << 4) // depreciated
//         #define FLG_UI_CANNOT_CONNECT		(1 << 4) // added by jmpark, 2013/12/10
// 
//         #define FLG_UI_NDAS 			(1 << 5)
//         #define FLG_UI_NDAS_FAIL		(1 << 6)
//         #define FLG_UI_VIDEO_LOSS		(1 << 7)
// 
//         #define FLG_UI_EXT_START		(1 << 8)
//         #define FLG_UI_MOTION_START	(1 << 9)
//         #define FLG_UI_NDAS_START		(1 << 10)
// 
//         #define FLG_UI_NDAS_SMART_BAD		(1 << 11)
//         #define FLG_UI_NDAS_EXT_FAIL	(1<<12)

        public const int FLG_UI_EXT = 0x1;
        public const int FLG_UI_MOTION = 0x2;
        public const int FLG_UI_ALARM = 0x3;
        public const int FLG_UI_RECORD = 0x4;
        public const int FLG_UI_AVI = 0x8;
        public const int FLG_UI_JPG = 0x10;
        public const int FLG_UI_NDAS = 0x20;
        public const int FLG_UI_NDAS_FAIL = 0x40;

        public const int FLG_UI_NDAS_SMART_BAD = 0x800; //S.M.A.R.T API


        public struct VideoInfo
        {
	        public int width;
	        public int height;
        } 

        public struct AudioInfo
        {
	        public int sample_rate;
	        public string bits;
	        public string channels;
        }

        public struct FrameHeader                           
        {                                                       
	        public Int16 Version;//(2) - 1						memcpy (&frameHeader->Version,				&data[0], 2);
	        public int I_frame_count;	//(4)					memcpy (&frameHeader->I_frame_count,		&data[2], 4);
            public Int16 Non_I_frame_count;	//(2)				memcpy (&frameHeader->Non_I_frame_count,	&data[6], 2);
	        public int Frame_size;	//(4)						memcpy (&frameHeader->Frame_size,			&data[8], 4);
            public Int16 Motion_sensor;	//(2)					memcpy (&frameHeader->Motion_sensor,		&data[12], 2);
            public Int16 Channel_info;	//(2)               	memcpy (&frameHeader->Channel_info,			&data[14], 2);
            public Int16 Year;	//(2)                       	memcpy (&frameHeader->Year,					&data[16], 2);
            public Int16 Month;	//(2)                       	memcpy (&frameHeader->Month,				&data[18], 2);
            public Int16 Day;	//(2)                       	    memcpy (&frameHeader->Day,					&data[20], 2);
            public Int16 Hour;	//(2)                       	memcpy (&frameHeader->Hour,					&data[22], 2);
            public Int16 Minute;	//(2)                       	memcpy (&frameHeader->Minute,				&data[24], 2);
            public Int16 Second;	//(2)                       	memcpy (&frameHeader->Second,				&data[26], 2);
            public Int16 Milli_second;	//(2)               	memcpy (&frameHeader->Milli_second,			&data[28], 2);
	        public string Video_loss_info;	//(1)           	memcpy (&frameHeader->Video_loss_info,		&data[30], 1);
	        public string fps;	//	(1)                     	memcpy (&frameHeader->fps,					&data[31], 1);
	        public string video_audio;   //(1)                  memcpy (&frameHeader->video_audio,			&data[32], 1);
	        public string codec;	// (1)						memcpy (&frameHeader->video_audio,			&data[33], 1);

            public struct frame_info
            {
                VideoInfo video_info;
                AudioInfo audio_info;
                string Reserved;
            }
        }



        public struct tm {
            public int tm_sec;     /* seconds after the minute - [0,59] */
            public int tm_min;     /* minutes after the hour - [0,59] */
            public int tm_hour;    /* hours since midnight - [0,23] */
            public int tm_mday;    /* day of the month - [1,31] */
            public int tm_mon;     /* months since January - [0,11] */
            public int tm_year;    /* years since 1900 */
            public int tm_wday;    /* days since Sunday - [0,6] */
            public int tm_yday;    /* days since January 1 - [0,365] */
            public int tm_isdst;   /* daylight savings time flag */
        };



        [DllImport("netcam.dll")]
        extern public static int initialize_netcam();                           //NETCAM 초기화
        [DllImport("netcam.dll")]
        extern public static int process_count();                               //현재 프로세스의 수

        //------------------------------------------Live 영상재생에 관련된 API--------------------------------------
        [DllImport("netcam.dll")]
        extern public static IntPtr netcam_create(
            IntPtr hWnd,
            string ip,
            string video_port,
            string control_port,
            string ndas_id,
            string write_key,
            int disk_no,
            string member_name,
            int ndas_config,
            string exp1_ndas_id, string exp1_write_key, int exp1_disk_no,
            string exp2_ndas_id, string exp2_write_key, int exp2_disk_no,
            string exp3_ndas_id, string exp3_write_key, int exp3_disk_no,
            string exp4_ndas_id, string exp4_write_key, int exp4_disk_no,
            int ch_id,
            string codec_name,
            int audio_enable,
            int netcam_search_type,
            int blink_enable,
            int search_arca,
            string userid,
            string password
            );                                                                  //연결 만들기

///////////////////////////////////////////////////////////////////////////////////////////////
        public const int PLAY_MODE_NORMAL = 0;
        public const int PLAY_MODE_BACK = 1;
        public const int PLAY_MODE_LAST = 2;
        public const int PLAY_MODE_SNAP = 3;
        public const int PLAY_MODE_SEARCH = 10;

        public const int ACTION_FORWARD = 0x01;
        public const int ACTION_BACKWARD = 0x02;
        public const int ACTION_DIRECT_FORWARD = 0x03;
        public const int ACTION_DIRECT_BACKWARD = 0x04;
        public const int ACTION_SNAP_FORWARD = 0x05;
        public const int ACTION_SNAP_BACKWARD = 0x06;
        public const int ACTION_EVENT_FORWARD = 0x07;
        public const int ACTION_EVENT_BACKWARD = 0x08;
        public const int ACTION_DIRECT_EVENT_FORWARD = 0x09;
        public const int ACTION_DIRECT_EVENT_BACKWARD = 0x10;

        public const int CHECKTIME_DELAY = 10;

        public const int EVT_FLAG_NONE = 0x00;
        public const int EVT_FLAG_START = 0x01;
        public const int EVT_FLAG_MOTION = 0x02;
        public const int EVT_FLAG_VIDEO_LOSS = 0x04;
        public const int EVT_FLAG_ALARM = 0x08;

        public const int  PTZ_CMD_LEFTUP = 0x01;
        public const int  PTZ_CMD_UP	= 0x02;
        public const int  PTZ_CMD_RIGHTUP	= 0x03;
        public const int  PTZ_CMD_LEFT	= 0x04;
        public const int  PTZ_CMD_STOP	= 0x05;
        public const int  PTZ_CMD_RIGHT		= 0x06;
        public const int  PTZ_CMD_LEFTDOWN	= 0x07;
        public const int  PTZ_CMD_DOWN		= 0x08;
        public const int  PTZ_CMD_RIGHTDOWN= 0x09;
        public const int  PTZ_CMD_SPEED		= 0x10;
        public const int  PTZ_CMD_ZOOMIN	= 0x11;
        public const int  PTZ_CMD_ZOOMOUT	= 0x12;
        public const int  PTZ_CMD_FOCUSFAR	= 0x13;
        public const int PTZ_CMD_FOCUSNEAR = 0x14;

        public const int KILL_STATUS_NONE = 0x00;			
        public const int KILL_STATUS_JUST_CREATED = 0x01;	
        public const int KILL_STATUS_PLAY	 = 0x02;		
        public const int KILL_STATUS_DISCONNECTED = 0x03;	
        public const int KILL_STATUS_FAILED		 = 0x04;	
        public const int KILL_STATUS_CONNECTED	 = 0x05;

        public const int DOWNLOAD_YEARCONST = 1900;
        public const int DOWNLOAD_MONTHCONST = 1;

        public const int MAX_TIMEOUT = 5000;
        public const int MAX_CMD_SIZE = 2048;
        public const int MAX_REPLY_SIZE	= 8192;
        public const int GETSTATUS_DELAY = 3000;
        public const int MAX_PLAY_SPEED = 32;

 
        public struct nbiofat_track_info_t
        {
            public tm start_time;       // track start time
            public int start_tm_gmtoff; // dummy
            public int start_tm_zone; // dummy
            public tm end_time;      // track end time
            public int end_tm_gmtoff; // dummy
            public int end_tm_zone; // dummy
            public int pos;             // track position
            public int Flags;
        };

        public struct nbiofat_index_info_t
        {
            public int pos;          // frame position
            public int key_size;     // frame key size
            public int Flags;         // frame flags
            public tm ctime;       // index time
            public int start_tm_gmtoff;   // dummy
            public int start_tm_zone;  // dummy
        };
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct time_table
        {
            public int file_index;
            public IntPtr track_info;       //nbiofat_track_info_t*
            public int track_info_count;
            public IntPtr index_list;       //nbiofat_index_info_t*
            public int index_count;
            public int start_index;
            public int end_index;
            public int hour;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct nbiofat_file_time_info_t
        {
            public tm create_time;
            public int create_tm_gmtoff;// dummy
            public int create_tm_zone;// dummy
            public tm end_time;
            public int end_tm_gmtoff;// dummy
            public int end_tm_zone;// dummy
            public int file_index;
            public int flags;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ndas_handle_t
        {
            public int fat;
            public int member;
            public int file;
            public int play_mode;
            public int started;
            public int buffer;
            public int buffer_len;
            public int max_buffer_len;
            public int channel;
            public int pre_size;
            public tm search_time;
            public int search_index;
            public IntPtr search_info;//     time_table *
            public int search_info_count;
            public int key_size;
            public int duration;
            public IntPtr file_time_info;//    nbiofat_file_time_info_t*
            public int file_time_info_count;
            public int TickCount;
            public int ReadyTime;
            public int bufferRemain;
            public int bufferRemainSize;
            public int diff_frame_count;
            public int old_frame_count;
            public int curr_info_index;
            public int curr_track_index;
            public int curr_index_index;
            public int tcp;
            public int cs;
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        [DllImport("netcam.dll")]
        extern public static int netcam_destroy(IntPtr h_ncam);                    //해제

        [DllImport("netcam.dll")]
        extern public static int ndassock_connect(IntPtr h_ncam);                  //영상 연결

        [DllImport("netcam.dll")]
        extern public static int ndassock_setdisplay(IntPtr h_ncam, IntPtr hWnd);     //영상 디스플레이

        [DllImport("netcam.dll")]
        extern public static int ndassock_play(IntPtr h_ncam);                     //영상 재생
        
        [DllImport("netcam.dll")]
        extern public static int ndassock_stop(IntPtr h_ncam);                     //영상 멈춤   

        [DllImport("netcam.dll")]
        extern public static int ndassock_disconnect(IntPtr h_ncam);               //영상 연결 해제

        [DllImport("netcam.dll")]
        extern public static int ndassock_iskilled(IntPtr h_ncam);                 //영상 상태 체크

        [DllImport("netcam.dll")]
        extern public static int ndassock_update_Screen(IntPtr h_ncam);            //영상 Redraw

        [DllImport("netcam.dll")]
        extern public static int ndassock_iframe_play_Enable(bool flag);       //영상 iframe play

        [DllImport("netcam.dll")]
        extern public static int ndassock_buffering_enable(int buf_enable, int buf_level);


        //------------------------------------------영상 information에 관련된 API--------------------------------------
        [DllImport("netcam.dll")]
        extern public static int netcam_video_resolution(IntPtr h_ncam, out int width, out int height);

        [DllImport("netcam.dll")]
        extern public static int netcam_video_bitrate(IntPtr h_ncam, out int bitrate);

        [DllImport("netcam.dll")]
        extern public static int netcam_video_fps(IntPtr h_ncam, out int fps);

        [DllImport("netcam.dll")]
        extern public static void netcam_codec_name(IntPtr h_ncam,  StringBuilder name);

        [DllImport("netcam.dll")]
        extern public static int ndassock_get_cur_frame_header(IntPtr h_ncam, out FrameHeader pFrameHeader);

        [DllImport("netcam.dll")]
        extern public static int nbiofats_get_cur_frame_header(IntPtr h_ncam, out FrameHeader pFrameHeader);


        //------------------------------------------영상 다운로드 API--------------------------------------------------
        [DllImport("netcam.dll")]
        extern public static int nbiofats_download_start(IntPtr h_ncam, string dir, string hostname, ref tm start_time, int duration);

        [DllImport("netcam.dll")]
        extern public static int nbiofats_download_start2(IntPtr h_ncam, string filename, ref tm start_time, int duration);

        [DllImport("netcam.dll")]
        extern public static int nbiofats_download_status(IntPtr h_ncam, int duration);
        
        [DllImport("netcam.dll")]
        extern public static int nbiofats_download_stop(IntPtr h_ncam);

        [DllImport("netcam.dll")]
        extern public static int nbiofats_download_status(IntPtr h_ncam, out int duration);
        
        //------------------------------------------녹화 영상 API-----------------------------------------------------
        [DllImport("netcam.dll")]
        extern public static int nbiofats_iskilled(IntPtr h_ncam);
        
        [DllImport("netcam.dll")]
        extern public static int nbiofats_connect(IntPtr h_ncam);

        [DllImport("netcam.dll")]
        extern public static int nbiofats_play(IntPtr h_ncam);

        [DllImport("netcam.dll")]
        extern public static int nbiofats_rewind(IntPtr h_ncam);

        [DllImport("netcam.dll")]
        extern public static int nbiofats_stop(IntPtr h_ncam);

        [DllImport("netcam.dll")]
        extern public static int nbiofats_stop_redraw(IntPtr h_ncam);        

        [DllImport("netcam.dll")]
        extern public static int nbiofats_set_x(IntPtr h_ncam, int x_speed);

        [DllImport("netcam.dll")]
        extern public static int nbiofats_disconnect(IntPtr h_ncam);
       
        [DllImport("netcam.dll")]
        extern public static int nbiofats_get_connection_handle(IntPtr h_ncam, out IntPtr h_ndas);

        [DllImport("netcam.dll")]
        extern public static int netcam_set_default(IntPtr h_ncam);

        [DllImport("netcam.dll")]
        extern public static int nbiofats_setdisplay(IntPtr h_ncam, IntPtr hWnd);

        [DllImport("netcam.dll")]
        extern public static int nbiofats_seek(IntPtr h_ncam, int action, int year, int mon, int mday, int hour, int min, int sec, int flags);


    //////////////////////////////////////////////////////////////////////////
        [DllImport("netcam.dll")]
        extern public static int netcam_audio_enable(IntPtr h_ncam, out int audio_enable);

        [DllImport("netcam.dll")]
        extern public static int ndassock_setvolume(IntPtr h_ncam, int volume);

        [DllImport("netcam.dll")]
        extern public static int ndassock_set_mic_enable(IntPtr h_ncam, int mic_enable);

        [DllImport("netcam.dll")]
        extern public static int ndassock_setmute(IntPtr h_ncam, int mute);

        [DllImport("netcam.dll")]
        extern public static int nbiofats_setvolume(IntPtr h_ncam, int volume);

        [DllImport("netcam.dll")]
        extern public static int nbiofats_setmute(IntPtr h_ncam, int mute);

        [DllImport("netcam.dll")]
        extern public static int nbiofats_capture_file(IntPtr h_ncam, string dir, string hostname, ref tm start_time);

        [DllImport("netcam.dll")]
        extern public static int ndassock_avi_open_output_file(IntPtr h_ncam, string dir, string hostname, ref tm start_time, ref tm end_time);

        [DllImport("netcam.dll")]
        extern public static int ndassock_avi_close(IntPtr h_ncam);

        [DllImport("netcam.dll")]
        extern public static int ndassock_avi_open_output_file2(IntPtr h_ncam, string dir , ref tm start_time, ref tm end_time);

        [DllImport("netcam.dll")]
        extern public static int ndassock_capture_file(IntPtr h_ncam, string dir, string hostname, ref tm start_time);

        [DllImport("netcam.dll")]
        extern public static int netcam_set_notify_message(IntPtr h_ncam, out int message_id);

        [DllImport("netcam.dll")]
        extern public static int nbiofats_get_search_time(IntPtr h_ncam, ref tm start_time);


        ///////////////////////////////////////////////
        [DllImport("netcam.dll")]
        extern public static int netcam_set_zoom(IntPtr h_ncam, int position_x, int position_y, int dx, int dy);

        [DllImport("netcam.dll")]
        extern public static int netcam_set_move(IntPtr h_ncam, int position_x, int position_y);


        //////////////////////////////////////////////////////////////////////////
//         [DllImport("netcam.dll")]
//         extern public static int ndiskutil_get_disk_count(string ndas_id, string write_key, out int disk_count);
//         //ARCA에 직접 접근하여 disk의 개수를 얻어온다. 현재 같은 switch 상에 ARCA가 있어야 한다.

        [DllImport("netcam.dll")]
        extern public static int ndiskutil_get_disk_info(string ndas_id, string write_key, int disk_no, out int ro, out int rw, out double capacity);
        //ARCA에 직접 접근하여 disk의 information을 개수를 얻어온다. 현재 같은 switch 상에 ARCA가 있어야 한다.

        [DllImport("netcam.dll")]
        extern public static int ndiskutil_open_member_list(string ndas_id, string write_key, int disk_no, out int pmem_info_list, out int  pcount);
        //해당 member(MAC_CHx)을 open한다.

        [DllImport("netcam.dll")]
        extern public static int netcam_ndas_config(IntPtr h_ncam, out int ndas_config);

        [DllImport("netcam.dll")]
        extern public static int nbiosfat_set_slow_set(IntPtr h_ncam, int slow_mode);    
    

        ////////////////////////////////////////////////////////
        //Download 옵션 private masking
        [DllImport("netcam.dll")]
        extern public static void nbiofat_set_private_masking(IntPtr h_ncam, int private_masking_flag);

        [DllImport("netcam.dll")]
        extern public static void nbiofat_set_private_masking_point(IntPtr h_ncam, Point[,] p, int[] c, int count);

        [DllImport("netcam.dll")]
        extern public static void nbiofat_set_draw_rectengle(IntPtr h_ncam, int enable);

        [DllImport("netcam.dll")]
        extern public static void nbiofat_set_draw_rectengle_point(IntPtr h_ncam, Point start_point, Point end_point);

        [DllImport("netcam.dll")]
        extern public static void ndassock_set_draw_rectengle(IntPtr h_ncam, int enable);

        [DllImport("netcam.dll")]
        extern public static void ndassock_set_draw_rectengle_point(IntPtr h_ncam, Point start_point, Point end_point);

        //////////////////////////////////////////////////////////
        //Filtering option
        [DllImport("netcam.dll")]
        extern public static void ndassock_sharp_filter_enable(IntPtr h_ncam, int enable);
    }
}
