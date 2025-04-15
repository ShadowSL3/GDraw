using System;
using Raylib_cs;
public static class GDRenderer
{
	public static void Begin()
	{
		Raylib.BeginDrawing();
	}
	public static void End()
	{
		Raylib.EndDrawing();
	}
	public static void Clear(Color color)
	{
		Raylib.ClearBackground(color);
	}
	public static void DrawRectangle(int x, int y, int width, int height, Color color)
	{
		Raylib.DrawRectangle(x, y, width, height, color);
	}
	public static void DrawText(string text, int x, int y, int size, Color color)
	{
		Raylib.DrawText(text, x, y, size, color);
	}
}
