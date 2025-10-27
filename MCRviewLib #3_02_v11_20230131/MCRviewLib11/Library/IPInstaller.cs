using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices; //외부라이브러리 관련

namespace MCRviewLib11

{
    static class IPInstaller
    {
        public struct DATASTRUCT
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string cmd;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
            public string mac_addr;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 22)]
            public string reserved;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string user_name;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string encrypted_user_name;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string model_name;
            public int enable_dhcp;
            public int ip_type;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string ip_addr;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string subnet_mask;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string gateway;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string url;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string firmware;
            public int http_port;
            public int rtsp_port;
            public int video_port;
            public int audio_port;
            public int channels;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 928)]
            public string raw;
        }

        [DllImport("ws2_32.dll")]
        extern public static int ntohl(int netLong); 

        [DllImport("IPinstaller.dll")]
        extern public static int IP_Search();
        [DllImport("IPinstaller.dll")]
        extern public static int Get_IP_Result(int sleep_time);
        [DllImport("IPinstaller.dll")]
        extern public static int Get_IP_address(int ip_count_index, out int addr1, out int addr2, out int addr3, out int addr4);
        [DllImport("IPinstaller.dll")]
        extern public static int IP_Search_End();
        [DllImport("IPinstaller.dll")]
        extern public static int Get_IP_Info(int IP_index, out DATASTRUCT dataStructs);
    }
}
