using System;
using System.Collections.Generic;
using System.Text;

namespace GameDevAssistPack.FLink
{
	public class LinkManager
	{
		List<LinkObj> objects;

		public LinkManager()
		{
			Register.ThrowException(Project.FilesLinker);
			objects = new List<LinkObj>();
		}

		public void Clear()
		{
			Register.ThrowException(Project.FilesLinker);
			objects.Clear();
		}

		public LinkObj this[int index]
		{
			get
			{
				Register.ThrowException(Project.FilesLinker);
				return objects[index];
			}
			set
			{
				Register.ThrowException(Project.FilesLinker);
				objects[index] = value;
			}
		}

		public int Count
		{
			get { return objects.Count; }
		}

		public void AddFile(string file)
		{
			Register.ThrowException(Project.FilesLinker);
			objects.Add(new LinkObj(file));
		}

		public void AddFile(string name, byte[] data)
		{
			Register.ThrowException(Project.FilesLinker);
			objects.Add(new LinkObj(name, data));
		}

		public void RemoveFile(int index)
		{
			Register.ThrowException(Project.FilesLinker);
			objects.RemoveAt(index);
		}

		public int GetIndexFromFileName(string file)
		{
			Register.ThrowException(Project.FilesLinker);

			int count = 0;

			foreach (LinkObj obj in objects)
			{
				if (obj.FileName == file)
					return count;

				count++;
			}

			return -1;
		}
	}
}
