using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GameDevAssistPack;

namespace CoordinateVisualizer
{
	static class Program
	{
		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Register.Registering("GLJS_COOR_V_REG_STR");
			Application.Run(new frmMain());
		}
	}
}
