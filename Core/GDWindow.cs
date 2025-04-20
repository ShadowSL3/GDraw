using System;
using System.Numerics;
using Raylib_cs; 

namespace GDraw {
	public class GDWindow
	{
		public static class Time
		{
			public static float Delta { get; private set; }
			private static float lastFrame;
			
			public static void Update()
			{
			    double currentFrame = Raylib.GetTime();

			
			}

		}
		
		public static void Init(int width, int height, string title)
		{
			Raylib.InitWindow(width, height, title);
			Raylib.SetTargetFPS(60);
		}
		public static bool ShouldClose() => Raylib.WindowShouldClose();
		public static void Close() => Raylib.CloseWindow();
	}
}
