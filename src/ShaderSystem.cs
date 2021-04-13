using System;
using System.Collections.Generic;
using System.Text;
using Jurassic;
using Jurassic.Library;

namespace Disaster
{
    public static class ShaderSystem
    {
        static Dictionary<string, Shader> Shaders = new Dictionary<string, Shader>();

        private static Shader FallbackShader;

        public static void Init()
        {
            FallbackShader = new Shader("Fallback", "shaders/fallback.vert", "shaders/fallback.frag");
        }
        public static void RegisterBasicShader(string Name, string VertexShaderPath, string PixelShaderPath)
        {
            Shader newShader = new Shader(Name, VertexShaderPath, PixelShaderPath);

            newShader.Compile();

            Shaders.Add(Name, newShader);
        }
    }
}
