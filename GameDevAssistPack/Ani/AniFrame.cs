using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace GameDevAssistPack.Ani
{
	public class AniFrame : IEnumerable<AniFrmObj>
	{
		List<AniFrmObj> objs = new List<AniFrmObj>();
		Point anchorPoint = new Point(0, 0);

		public void AddUseObject(int objindex, int Width, int Height)
		{
			objs.Add(new AniFrmObj(objindex, Width, Height));
		}

		public void RemoveUseObject(int index)
		{
			objs.RemoveAt(index);
		}

		public AniFrmObj this[int index]
		{
			get { return objs[index];}
			set { objs[index] = value; }
		}

		public int Count
		{
			get { return objs.Count; }
		}

		public Point AnchorPoint
		{
			get { return anchorPoint; }
			set { anchorPoint = value; }
		}

		#region IEnumerable<AniFrmObj> 멤버

		public IEnumerator<AniFrmObj> GetEnumerator()
		{
			return objs.GetEnumerator();
		}

		#endregion

		#region IEnumerable 멤버

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return objs.GetEnumerator();
		}

		#endregion
	}

	public class AniFrmObj
	{
		int index;
		Point location;
		Size size;
		float rotAngle;

		public AniFrmObj(int objIndex, int Width, int Height)
		{
			index = objIndex;
			location = new Point(0, 0);
			size = new Size(Width, Height);
			rotAngle = 0.0f;
		}

		public int Index
		{
			get { return index; }
			set { index = value; }
		}

		public Point Location
		{
			get { return location; }
			set { location = value; }
		}

		public Size Size
		{
			get { return size; }
			set { size = value; }
		}

		public float RotationAngle
		{
			get { return rotAngle; }
			set { rotAngle = value; }
		}
	}
}
