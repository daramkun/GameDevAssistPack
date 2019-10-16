using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace GameDevAssistPack.Ani
{
	public class AniObj
	{
		string name;
		string path;
		byte[] data;
		Color transColor = Color.Magenta;
		ObjType type = ObjType.Image;

		public AniObj(string path, byte[] data, ObjType type)
		{
			this.path = path;
			this.data = data;
			this.type = type;
		}

		public AniObj(string name, string path, byte[] data, Color tColor, ObjType type)
		{
			this.name = name;
			this.path = path;
			this.data = data;
			transColor = tColor;
			this.type = type;
		}

		public AniObj(string path, ObjType type)
		{
			this.path = path;
			name = Common.Library.GetFileName(path);
			data = File.ReadAllBytes(path);
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Path
		{
			get { return path; }
			set { path = value; }
		}

		public byte[] Data
		{
			get { return data; }
			set { data = value; }
		}

		public Color TransparentColor
		{
			get { return transColor; }
			set { transColor = value; }
		}

		public ObjType ObjectType
		{
			get { return type; }
			set { type = value; }
		}
	}

	public enum ObjType
	{ 
		Image = 0,
		Sound = 1,
		DamagePoint = 2,
		AssultPoint = 3,
		Etc = 4,
	}
}
