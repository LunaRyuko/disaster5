using OpenGL;
using Jurassic;
using Jurassic.Library;
using System.Numerics;
namespace DisasterAPI
{
    
    public class Draw : ObjectInstance{

        public Draw(ScriptEngine engine) : base(engine) {
            this.PopulateFunctions();
        }

        [JSFunction(Name = "loadFont")]
        public static void LoadFont(string fontPath) {
            Disaster.Draw.LoadFont(Disaster.Assets.LoadPath(fontPath));
        }

        [JSFunction(Name = "clear")]
        public static void Clear() {
            Disaster.Draw.Clear();
        }

        //public static void StrokeRect(int x, int y, int width, int height, ObjectInstance color) {

        //    Disaster.Draw.DrawRect(x, y, width, height, Disaster.TypeInterface.Color32(color));
        //}

        //public static void FillRect(int x, int y, int width, int height, Color32 color) {
        //    Disaster.Draw.FillRect(x, y, width, height, color);
        //}

        [JSFunction(Name ="line")]
        public static void Line(int x1, int y1, int x2, int y2, ObjectInstance color)
        {
            Disaster.Draw.Line(x1, y1, x2, y2, Disaster.TypeInterface.Color32(color));
        }

        //public static void Pixel(int x, int y, Color32 color) {
        //    Disaster.Draw.Pixel(x, y, color);
        //}

        [JSFunction(Name = "text")]
        public static void Text(int x, int y, string text, ObjectInstance color)
        {
            Disaster.Draw.Text(x, y, Disaster.TypeInterface.Color32(color), text);
        }

        [JSFunction(Name = "model")]
        public static void Model(ObjectInstance position, ObjectInstance rotation, string modelPath, string texturePath)
        {
            var rot = Disaster.TypeInterface.Vector3(rotation);
            var pos = Disaster.TypeInterface.Vector3(position);
            Matrix4x4 mat = Matrix4x4.CreateFromYawPitchRoll(rot.Y, rot.X, rot.Z) * Matrix4x4.CreateTranslation(pos);
            Matrix4 matrix = new Matrix4(new float[] { mat.M11, mat.M12, mat.M13, mat.M14, mat.M21, mat.M22, mat.M23, mat.M24, mat.M31, mat.M32, mat.M33, mat.M34, mat.M41, mat.M42, mat.M43, mat.M44 });
            var texture = Disaster.Assets.Texture(texturePath);
            var model = Disaster.Assets.ObjModel(modelPath);
            Disaster.ObjRenderer.EnqueueRender(model, Disaster.Assets.defaultShader, texture, matrix);
        }

        //public void TexturePart() {}
        // [JSFunction(Name = "reset")] public void Reset() {}
        // [JSFunction(Name = "fogColor")] public void FogColor(double r, double g, double b) {}


    }
}