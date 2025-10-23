using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDraw.Core
{
    public class GDRawShader : IDisposable
    {
        private Shader _shader;
        private Dictionary<string, int> _UniformLocations; 


        public GDRawShader(string vertexpath, string FragmentPath)
        {
            _shader = Raylib.LoadShader(vertexpath, FragmentPath);
            _UniformLocations = new Dictionary<string, int>();
        }
        public int GetUniformLocation(string name)
        {
            if (_UniformLocations.TryGetValue(name, out int loc))
            {
                return loc;
            }
            int location = Raylib.GetShaderLocation(_shader, name);
            _UniformLocations[name] = location;
            return location;
        }
        public void SetUniform(string name, float value)
        {
            int loc = GetUniformLocation(name);
            // Currently not implemented

        }
        public void Begin()
        {
            Raylib.BeginShaderMode(_shader);
        }
        public void End()
        {
            Raylib.EndShaderMode();
        }
        public void Dispose()
        {
            Raylib.UnloadShader(_shader);
        }
    }
}
