using System;
using GDraw;
using System.Diagnostics;
public class Example
{
    static void Main()
    {
        GDWindow.Init(300, 400, "GDraw Examples");
        while (!GDWindow.ShouldClose())
        {
            GDRenderer.Begin();
            GDRenderer.Clear(GColor.Background);
            GDRenderer.DrawText("Welcome on GDraw", 20, 20, 30, GColor.Primary);
            GDRenderer.DrawRectangle(50, 100, 200, 300, GColor.Accent);
            GDRenderer.End();
        }
        GDWindow.Close();
    }
  
}
