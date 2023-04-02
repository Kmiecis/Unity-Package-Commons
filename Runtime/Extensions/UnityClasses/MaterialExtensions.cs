using UnityEngine;

namespace Common.Extensions
{
    public static class MaterialExtensions
    {
        public static bool TryGetColor(this Material self, int nameID, out Color value)
        {
            if (self.HasColor(nameID))
                return self.GetColor(nameID).OutWithTrue(out value);
            return default(Color).OutWithFalse(out value);
        }

        public static bool TryGetColor(this Material self, string name, out Color value)
        {
            return self.TryGetColor(Shader.PropertyToID(name), out value);
        }

        public static bool TryGetFloat(this Material self, int nameID, out float value)
        {
            if (self.HasFloat(nameID))
                return self.GetFloat(nameID).OutWithTrue(out value);
            return default(float).OutWithFalse(out value);
        }

        public static bool TryGetFloat(this Material self, string name, out float value)
        {
            return self.TryGetFloat(Shader.PropertyToID(name), out value);
        }

        public static bool TryGetInteger(this Material self, int nameID, out int value)
        {
            if (self.HasInteger(nameID))
                return self.GetInteger(nameID).OutWithTrue(out value);
            return default(int).OutWithFalse(out value);
        }

        public static bool TryGetInteger(this Material self, string name, out int value)
        {
            return self.TryGetInteger(Shader.PropertyToID(name), out value);
        }

        public static bool TryGetMatrix(this Material self, int nameID, out Matrix4x4 value)
        {
            if (self.HasMatrix(nameID))
                return self.GetMatrix(nameID).OutWithTrue(out value);
            return default(Matrix4x4).OutWithFalse(out value);
        }

        public static bool TryGetMatrix(this Material self, string name, out Matrix4x4 value)
        {
            return self.TryGetMatrix(Shader.PropertyToID(name), out value);
        }

        public static bool TryGetTexture(this Material self, int nameID, out Texture value)
        {
            if (self.HasTexture(nameID))
                return self.GetTexture(nameID).OutWithTrue(out value);
            return default(Texture).OutWithFalse(out value);
        }

        public static bool TryGetTexture(this Material self, string name, out Texture value)
        {
            return self.TryGetTexture(Shader.PropertyToID(name), out value);
        }

        public static bool TryGetVector(this Material self, int nameID, out Vector4 value)
        {
            if (self.HasVector(nameID))
                return self.GetVector(nameID).OutWithTrue(out value);
            return default(Vector4).OutWithFalse(out value);
        }

        public static bool TryGetVector(this Material self, string name, out Vector4 value)
        {
            return self.TryGetVector(Shader.PropertyToID(name), out value);
        }
    }
}
