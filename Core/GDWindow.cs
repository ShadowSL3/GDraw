using System;
using Raylib_cs; 

namespace GDraw.Core {
	public class GDWindow
	{
		public static class Time
		{
			public static float Delta { get; private set; }
			private static float lastFrame;
			
			public static void Update()
			{
				float currentFrame = Raylib.GetFPS() / 1000.0f;
				Delta = currentFrame - lastFrame;
				lastFrame = currentFrame;
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
