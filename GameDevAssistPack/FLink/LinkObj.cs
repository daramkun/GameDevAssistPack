using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GameDevAssistPack.FLink
{
	public class LinkObj
	{
		string fileName;
		byte[] data;

		public LinkObj(string file)
		{
			Register.ThrowException(Project.FilesLinker);
			fileName = file;
			data = File.ReadAllBytes(file);
		}

		public LinkObj(string name, byte[] data)
		{
			Register.ThrowException(Project.FilesLinker);
			fileName = name;
			this.data = data;
		}

		public string FileName
		{
			get { return fileName; }
			set { fileName = value; }
		}

		public byte[] Data
		{
			get { return data; }
			set { data = value; }
		}

		public int DataSize
		{
			get { if (data == null) return 0; else return data.Length; }
		}
	}
}
