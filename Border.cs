using System;
namespace BorderInConsole
{
	public class Border
	{
		public int X;
		public int Y;
		public int Width;
		public int Height;
		public ConsoleColor Color;
		public char Char;

		public Border(int x,int y,int width,int height,ConsoleColor color,char c)
		{
			X = x;
			Y = y;
			Width = width;
			Height = height;
			Color = color;
			Char = c;
		}

		public void Draw()
		{
			Console.ForegroundColor = Color;
			for (int i = 0; i < Width; i++)
			{
				Console.SetCursorPosition(X + i, Y);
				Console.Write(Char);
			}

			for (int i = 0; i < Width; i++)
			{
				Console.SetCursorPosition(X + i, Y + Height - 1);
				Console.Write(Char);
			}

			for (int i = 0; i < Height; i++)
			{
				Console.SetCursorPosition(X, Y + i);
				Console.Write(Char);
			}

			for (int i = 0; i < Height; i++)
			{
				Console.SetCursorPosition(X + Width - 1, Y + i);
				Console.Write(Char);
			}
		}
	}
}
