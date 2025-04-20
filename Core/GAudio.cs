using System;
using Raylib_cs;
namespace GDraw{
    
    public static class GAudio
    {
        public static void InitAudio()
        {
            Raylib.InitAudioDevice();
        }
        public static Sound LoadSound(string filepath)
        {
            return Raylib.LoadSound(filepath);
        }
        public static void Play(Sound sound)
        {
            Raylib.PlaySound(sound);
        }
        public static void Stop(Sound sound)
        {
            Raylib.StopSound(sound);
        }
        public static void CloseAudio()
        {
            Raylib.CloseAudioDevice();
        }
    }
}
