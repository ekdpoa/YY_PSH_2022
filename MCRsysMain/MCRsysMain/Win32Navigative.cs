using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MCRsysMain
{
	internal static class Win32RegNative
	{
		/// <summary>
		/// INI 파일에 섹션과 키로 검색하여 값을 저장합니다.
		/// </summary>
		/// <param name="lpAppname">섹션명입니다.</param>
		/// <param name="lpKeyName">키값명입니다.</param>
		/// <param name="lpString">저장 할 문자열입니다.</param>
		/// <param name="lpFileName">파일 이름입니다.</param>
		/// <returns>값을 얻은 성공 여부입니다.</returns>
		[DllImport("kernel32.dll")]
		public static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);
		/// <summary>
		/// INI 파일에 섹션을 저장합니다.
		/// </summary>
		/// <param name="lpAppname">섹션명입니다.</param>
		/// <param name="lpString">키=값으로 되어 있는 문자열 데이터입니다.</param>
		/// <param name="lpFileName">파일 이름입니다.</param>
		/// <returns></returns>
		[DllImport("kernel32.dll")]
		public static extern uint WritePrivateProfileSection(string lpAppName, string lpString, string lpFileName);
		/// <summary>
		/// INI 파일에 섹션과 키로 검색하여 값을 Integer형으로 읽어 옵니다.
		/// </summary>
		/// <param name="lpAppname">섹션명입니다.</param>
		/// <param name="lpKeyName">키값명입니다.</param>
		/// <param name="nDefalut">기본값입니다.</param>
		/// <param name="lpFileName">파일 이름입니다.</param>
		/// <returns>입력된 값입니다. 만약 해당 키로 검색 실패시 기본 값으로 대체 됩니다.</returns>
		[DllImport("kernel32.dll")]
		public static extern uint GetPrivateProfileInt(string lpAppName, string lpKeyName, int nDefalut, string lpFileName);
		/// <summary>
		/// INI 파일에 섹션과 키로 검색하여 값을 문자열형으로 읽어 옵니다.
		/// </summary>
		/// <param name="lpAppname">섹션명입니다.</param>
		/// <param name="lpKeyName">키값명입니다.</param>
		/// <param name="lpDefault">기본 문자열입니다.</param>
		/// <param name="lpReturnedString">가져온 문자열입니다.</param>
		/// <param name="nSize">문자열 버퍼의 크기입니다.</param>
		/// <param name="lpFileName">파일 이름입니다.</param>
		/// <returns>가져온 문자열 크기입니다.</returns>
		[DllImport("kernel32.dll")]
		public static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, uint nSize, string lpFileName);
		/// <summary>
		/// INI 파일에 섹션으로 검색하여 키와 값을 Pair형태로 가져옵니다.
		/// </summary>
		/// <param name="lpAppName">섹션명입니다.</param>
		/// <param name="lpPairVaules">Pair한 키와 값을 담을 배열입니다.</param>
		/// <param name="nSize">배열의 크기입니다.</param>
		/// <param name="lpFileName">파일 이름입니다.</param>
		/// <returns>읽어온 바이트 수 입니다.</returns>
		[DllImport("kernel32.dll")]
		public static extern uint GetPrivateProfileSection(string lpAppName, byte[] lpPairVaules, uint nSize, string lpFileName);
		/// <summary>
		/// INI 파일의 섹션을 가져옵니다.
		/// </summary>
		/// <param name="lpSections">섹션의 리스트를 직렬화하여 담을 배열입니다.</param>
		/// <param name="nSize">배열의 크기입니다.</param>
		/// <param name="lpFileName">파일 이름입니다.</param>
		/// <returns>읽어온 바이트 수 입니다.</returns>
		[DllImport("kernel32.dll")]
		public static extern uint GetPrivateProfileSectionNames(byte[] lpSections, uint nSize, string lpFileName);
	}
}
