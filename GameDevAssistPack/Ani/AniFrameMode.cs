using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace GameDevAssistPack.Ani
{
	public class AniFrameMode : IEnumerable<AniFrame>
	{
		List<AniFrame> frms = new List<AniFrame>();
		Size aniSize;
		string name;

		public AniFrameMode(string name, Size size)
		{
			this.name = name;
			this.Size = size;
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public void AddFrame()
		{
			frms.Add(new AniFrame());
		}

		public void RemoveFrame(int index)
		{
			frms.RemoveAt(index);
		}

		public void ClearFrame()
		{
			frms.Clear();
		}

		public AniFrame this[int index]
		{
			get { return frms[index]; }
			set { frms[index] = value; }
		}

		public int Count
		{
			get { return frms.Count; }
		}

		public Size Size
		{
			get { return aniSize; }
			set { aniSize = value; }
		}

		#region IEnumerable<AniFrameMode> 멤버

		public IEnumerator<AniFrame> GetEnumerator()
		{
			return frms.GetEnumerator();
		}

		#endregion

		#region IEnumerable 멤버

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return frms.GetEnumerator();
		}

		#endregion
	}
}
