using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace GameDevAssistPack.Ani
{
	public class AniManager
	{
		List<AniFrameMode> modes;
		List<AniObj> objs;
		int speed = 100;

		public AniManager()
		{
			Register.ThrowException(Project.Animation);
			modes = new List<AniFrameMode>();
			objs = new List<AniObj>();
		}

		public AniFrameMode this[string name]
		{
			get 
			{
				foreach (AniFrameMode mode in modes)
				{
					if (mode.Name == name)
						return mode;
				}

				return null;
			}
			set
			{
				for (int i = 0; i < modes.Count;i++)
				{
					if (modes[i].Name == name)
						modes[i] = value;
				}	
			}
		}

		public List<AniFrameMode> FrameMode
		{
			get { return modes; }
			set { modes = value; }
		}

		public List<AniObj> Object
		{
			get { return objs; }
			set { objs = value; }
		}

		public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}
	}
}