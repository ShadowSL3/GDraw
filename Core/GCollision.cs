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
        public static bool CheckCollisionBoxes(BoundingBox box1, BoundingBox box2)
        {
            return Raylib.CheckCollisionBoxes(box1, box2); 
           
        }

        public static bool BoxContainsPoint(BoundingBox box, Vector3 point)
        {
            return (point.X >= box.Min.X && point.X <= box.Max.X) && (point.Y >= box.Min.Y && point.Y <= box.Max.Y) &&
                (point.Z >= box.Min.Z && point.Z <= box.Max.Z);
        }
        
    }
}