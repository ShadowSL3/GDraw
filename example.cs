using System;
using GDraw;
using System.Diagnostics;
using Raylib_cs;
public class Example
{
    static void Main()
    {
        GDWindow.Init(300, 400, "GDraw Examples");
        GAudio.InitAudio();
        Sound laugh = GAudio.LoadSound(GPaths.soundDir + "253527__nanakisan__evil-laugh-1.wav");
        while (!GDWindow.ShouldClose())
        {
            if (Raylib.IsKeyPressed(KeyboardKey.Space))
            {
                GAudio.Play(laugh);
            }
            GDRenderer.Begin();
            GDRenderer.Clear(GColor.Background);
            GDRenderer.DrawText("Welcome on GDraw", 20, 20, 30, GColor.Primary);
            GDRenderer.DrawRectangle(50, 100, 200, 300, GColor.Accent);
            GDRenderer.End();
        }
        GAudio.CloseAudio();
        GDWindow.Close();
    }
  
}
