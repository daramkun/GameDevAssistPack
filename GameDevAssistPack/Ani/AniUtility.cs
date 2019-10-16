using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GameDevAssistPack.Ani
{
	public static class AniUtility
	{
		public static void RefreshObjList(ref ListView lstObj, AniManager manager)
		{
			lstObj.Items.Clear();
			foreach (AniObj obj in manager.Object)
			{
				lstObj.Items.Add(obj.Name);
			}
		}

		public static void RefreshFmList(ref ListView lstFrameMode, AniManager manager)
		{
			lstFrameMode.Items.Clear();
			foreach (AniFrameMode fm in manager.FrameMode)
			{
				lstFrameMode.Items.Add(fm.Name);
			}
		}

		public static void RefreshFrameList(ref ListView lstFrame, AniManager manager, int selFrameMode)
		{
			lstFrame.Items.Clear();
			int count = 1;
			foreach (AniFrame frm in manager.FrameMode[selFrameMode])
			{
				lstFrame.Items.Add(String.Format("{0:0000}", count));
				count++;
			}
		}

		public static void RefreshUsageObjList(ref ListView lstUsageObj, AniManager manager, int selFrameMode, int selFrame)
		{
			lstUsageObj.Items.Clear();
			foreach (AniFrmObj obj in manager.FrameMode[selFrameMode][selFrame])
			{
				lstUsageObj.Items.Add(manager.Object[obj.Index].Name);
			}
		}
	}
}
