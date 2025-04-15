using System;
namespace GDraw.Utils;
public static class Math
{
    public static float Clamp(float a, float b, float t)
    {
        return a + (b - a) * t;
    }
   
}
