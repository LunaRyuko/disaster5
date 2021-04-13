using System;
using System.Collections.Generic;
using System.Text;
using Jurassic;
using Jurassic.Library;

namespace DisasterAPI
{
    public class ShaderSystem : ObjectInstance 
    {
        public ShaderSystem(ScriptEngine engine)
            : base(engine)
        {
            this.PopulateFunctions();
        }

        [JSFunction(Name = "RegisterShader")]
        public static void RegisterShaderJS(string Name, FunctionInstance InitFunc, FunctionInstance FallbackFunc, FunctionInstance DrawFunc)
        {
            throw new NotImplementedException();
            //Disaster.ShaderSystem.RegisterShaderJS(Name, InitFunc, FallbackFunc, DrawFunc);
        }

        [JSFunction(Name = "RegisterBasicShader")]
        public static void RegisterBasicShaderJS(string Name, string VertexShaderPath, string PixelShaderPath)
        {
            Disaster.ShaderSystem.RegisterBasicShader(Name, VertexShaderPath, PixelShaderPath);
        }
    }
}
