using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GameDevAssistPack;

namespace Animator
{
	static class Program
	{
		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(true);
			Register.Registering("POIU_A_N_I_REG_STR");

			if(args.Length >= 1)
				Application.Run(new frmMain(args[0]));
			else
				Application.Run(new frmMain());
		}
	}
}
