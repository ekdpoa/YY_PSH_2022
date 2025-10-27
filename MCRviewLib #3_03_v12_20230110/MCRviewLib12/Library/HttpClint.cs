using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices; //외부라이브러리 관련

namespace MCRviewLib12

{
    static class HttpClint
    {

        public const int SEARCH_TYPE_LXX = 0x00;
        public const int SEARCH_TYPE_ARCA = 0x01;
        public const int  MAX_CMD_SIZE = 2048;
        public const int  MAX_REPLY_SIZE = 8192;
        public const int  GETSTATUS_DELAY = 3000;
 
        public const int  MAX_TIMEOUT = 5000;

        public const int MAX_PLAY_SPEED = 32;

        [DllImport("HttpClnt.dll")]
        extern public static int GetRequest(string lpszHost, int nPort, string lpszURL, string lpszUser, string lpszPasswd);
        [DllImport("HttpClnt.dll")]
        extern public static void WinHttpClose(int pGetRequest);
        [DllImport("HttpClnt.dll")]
        extern public static bool WinHttpAuthSample(int pGetRequest);
        [DllImport("HttpClnt.dll")]
        extern public static void LXXSendCommand(int pGetRequest, string lpszURL, StringBuilder lpszOutBuffer, long OutBufferLen);
        [DllImport("HttpClnt.dll")]
        extern public static void LXXSendCommandDoNotWinHttpReceiveResponse(int pGetRequest, string lpszURL, StringBuilder lpszOutBuffer, long OutBufferLen);
    }
}
