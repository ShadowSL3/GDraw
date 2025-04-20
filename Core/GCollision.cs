using Raylib_cs;
using System.Numerics; 
namespace GDraw
{
    public class GCollision
    {
        public static void GBox()
        {
            BoundingBox box = new BoundingBox
            {
                Min = new Vector3(0.3f, 0.0f, 0.0f),
                Max = new Vector3(1.0f, 1.0f, 1.0f)
            };
        }
    }
}
