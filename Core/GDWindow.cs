using System;
using Raylib_cs; 

namespace GDraw.Core {
	public class GDWindow
	{
		public static void Init(int width, int height, string title)
		{
			Raylib.InitWindow(width, height, title);
			Raylib.SetTargetFPS(60);
		}
		public static bool ShouldClose() => Raylib.WindowShouldClose();
		public static void Close() => Raylib.CloseWindow();
	}
}
