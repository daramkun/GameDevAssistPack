using System;
using System.Collections.Generic;
using System.Text;

namespace GameDevAssistPack
{
	public static class Register
	{
		static bool registered = false;
		static Project prj = Project.Animation;

		public static void ThrowException(Project? prj)
		{
			if (prj == null)
			{
				if (!Register.IsRegistered)
					throw new RegisteredException();
			}
			else if (!Register.IsRegistered || Register.prj != prj)
			{
				throw new RegisteredException();
			}
		}

		public static bool IsRegistered
		{
			get { return registered; }
		}

		public static string IsRegisteredString
		{
			get 
			{
				if (IsRegistered)
					return "이 프로그램은 라이브러리 사용이 허가되었습니다.";
				else
					return "이 프로그램은 라이브러리 사용이 허가되지 않았습니다.";
			}
		}

		public static bool Registering(string registerCode)
		{
			switch (registerCode.ToUpper().Trim())
			{
				case "GLJS_COOR_V_REG_STR":
					prj = Project.CoordinateVisualizer;
					break;
				case "FDSA_F___L_REG_STR":
					prj = Project.FilesLinker;
					break;
				case "QWER_GANTT_REG_STR":
					prj = Project.GanttChart;
					break;
				case "POIU_A_N_I_REG_STR":
					prj = Project.Animation;
					break;
				case "ASDF_SX_REG_STR":
					prj = Project.SX;
					break;
				default:
					registered = false;
					return false;
			}

			registered = true;
			return true;
		}
	}

	public enum Project
	{
		CoordinateVisualizer,
		FilesLinker,
		GanttChart,
		Animation,
		SX,
	}
}