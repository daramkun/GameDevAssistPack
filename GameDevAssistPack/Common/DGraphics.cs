using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace GameDevAssistPack.Common
{
	public class DGraphics
	{
		List<DLayer> layers = new List<DLayer>();
		int focusedLayer = 0;

		Color color = Color.Black;
		Font font = new Font("맑은 고딕", 8);

		Size size;

		public DGraphics(int width, int height)
		{
			Register.ThrowException(null);

			size = new Size(width, height);
			layers.Add(new DLayer(width, height));
		}

		public Size Size
		{
			get { return size; }
			set
			{
				size = value;
				foreach(DLayer layer in layers)
				{
					layer.SetSize(size);
				}
			}
		}

		public int LayerCount
		{
			get { return layers.Count; }
		}

		public int FocusedLayer
		{
			get { return focusedLayer; }
			set { focusedLayer = value; }
		}

		public Font Font
		{
			get { return font; }
			set { font = value; }
		}

		public void Clear(bool isAllClear, Color color)
		{
			if (isAllClear)
			{
				foreach (DLayer layer in layers)
					layer.Graphics.Clear(color);
			}
			else
				layers[focusedLayer].Graphics.Clear(color);
		}

		public void AddLayer()
		{
			layers.Add(new DLayer(size.Width, size.Height));
		}

		public void RemoveLayer(int index)
		{
			if (layers.Count == 1) return;
			layers.RemoveAt(index);
		}

		public void DrawString(string str, int X, int Y)
		{
			layers[focusedLayer].Graphics.DrawString(str, font, new SolidBrush(color), new Point(X, Y));
		}

		public void DrawLine(int X, int Y, int X2, int Y2)
		{
			layers[focusedLayer].Graphics.DrawLine(new Pen(color), new Point(X, Y), new Point(X2, Y2));
		}

		public Region Clip
		{
			get { return layers[focusedLayer].Graphics.Clip; }
			set { layers[focusedLayer].Graphics.Clip = value; }
		}

		public void DrawImage(Image image, int X, int Y)
		{
			layers[focusedLayer].Graphics.DrawImage(image, new Point(X, Y));		
		}

		public void DrawImage(Image image, int X, int Y, int Width, int Height)
		{
			layers[focusedLayer].Graphics.DrawImage(image, new Rectangle(X, Y, Width, Height));
		}

		public void DrawImage(Image image, int X, int Y, int Width, int Height, Color transColor)
		{
			ImageAttributes imageAttr = new ImageAttributes();
			ColorMap[] cmap = { new ColorMap() };
			cmap[0].OldColor = transColor;
			cmap[0].NewColor = Color.Transparent;
			imageAttr.SetRemapTable(cmap);
			layers[focusedLayer].Graphics.DrawImage(image, new Rectangle(X, Y, Width, Height),
				0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttr);
		}

		public void DrawImage(Image image, int X, int Y, Color transColor)
		{
			ImageAttributes imageAttr = new ImageAttributes();
			ColorMap[] cmap = { new ColorMap() };
			cmap[0].OldColor = transColor;
			cmap[0].NewColor = Color.Transparent;
			imageAttr.SetRemapTable(cmap);
			layers[focusedLayer].Graphics.DrawImage(image, new Rectangle(X, Y, image.Width, image.Height),
				0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttr);
		}

		public void Present(Graphics graphics, int X, int Y, int Width, int Height)
		{
			foreach (DLayer layer in layers)
			{
				graphics.DrawImage(layer.Layer, new Rectangle(X, Y, Width, Height));
			}
		}
	}

	internal class DLayer
	{
		Bitmap bmp;

		public DLayer(int width, int height)
		{
			bmp = new Bitmap(width, height);
		}

		public Bitmap Layer
		{
			get { return bmp; }
			set { bmp = value; }
		}

		public Graphics Graphics
		{
			get { return Graphics.FromImage(bmp); }
		}

		public void SetSize(Size size)
		{
			Bitmap temp = new Bitmap(size.Width, size.Height);
			Graphics.FromImage(temp).DrawImage(bmp, new Point(0, 0));
			bmp = temp;
		}
	}
}