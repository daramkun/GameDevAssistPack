using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace GameDevAssistPack.Common
{
	public static class Library
	{
		public static string GetFileName(string path)
		{
			Register.ThrowException(null);

			string[] temp = path.Split('\\');
			return temp[temp.Length - 1];
		}

		public static string GetTrueFileName(string path)
		{
			string[] temp2 = GetFileName(path).Split('.');
			string temp3 = "";

			for (int i = 0; i < temp2.Length - 1; i++)
			{ 
				temp3 += temp2[i];
				if (i != temp2.Length - 1 - 1)
					temp3 += ".";
			}

			return temp3;
		}

		public static string GetTitle(string name, Project? prj)
		{
			Register.ThrowException(prj);

			if (name == null)
				name = "Untitled";

			switch (prj)
			{ 
				case Project.CoordinateVisualizer:
					return name + " - BitDiary Coordinate Visualizer";
				case Project.FilesLinker:
					return name + " - BitDiary F-Linker";
				case Project.GanttChart:
					return name + " - BitDiary Gantt Chart Editor";
				case Project.Animation:
					return name + " - BitDiary Animator";
				default:
					return name;
			}
		}

		public static bool IsCrashedRect(Rectangle rect1, Rectangle rect2)
		{
			Register.ThrowException(null);

			if (rect1.X <= rect2.X + rect2.Width && rect2.X <= rect1.X + rect1.Width &&
				rect1.Y <= rect2.Y + rect2.Height && rect2.Y <= rect1.Y + rect1.Height)
				return true;
			else
				return false;
		}
	}
}