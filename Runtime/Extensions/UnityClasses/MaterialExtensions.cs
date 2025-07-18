using UnityEngine;

namespace Common
{
    public static class MaterialExtensions
    {
        public static bool TryGetColor(this Material self, int nameID, out Color value)
        {
            if (self.HasColor(nameID))
            {
                value = self.GetColor(nameID);
                return true;
            }
            value = default;
            return false;
        }

        public static bool TryGetColor(this Material self, string name, out Color value)
        {
            return self.TryGetColor(Shader.PropertyToID(name), out value);
        }

        public static bool TryGetFloat(this Material self, int nameID, out float value)
        {
            if (self.HasFloat(nameID))
            {
                value = self.GetFloat(nameID);
                return true;
            }
            value = default;
            return false;
        }

        public static bool TryGetFloat(this Material self, string name, out float value)
        {
            return self.TryGetFloat(Shader.PropertyToID(name), out value);
        }

        public static bool TryGetInteger(this Material self, int nameID, out int value)
        {
            if (self.HasInteger(nameID))
            {
                value = self.GetInteger(nameID);
                return true;
            }
            value = default;
            return false;
        }

        public static bool TryGetInteger(this Material self, string name, out int value)
        {
            return self.TryGetInteger(Shader.PropertyToID(name), out value);
        }

        public static bool TryGetMatrix(this Material self, int nameID, out Matrix4x4 value)
        {
            if (self.HasMatrix(nameID))
            {
                value = self.GetMatrix(nameID);
                return true;
            }
            value = default;
            return false;
        }

        public static bool TryGetMatrix(this Material self, string name, out Matrix4x4 value)
        {
            return self.TryGetMatrix(Shader.PropertyToID(name), out value);
        }

        public static bool TryGetTexture(this Material self, int nameID, out Texture value)
        {
            if (self.HasTexture(nameID))
            {
                value = self.GetTexture(nameID);
                return true;
            }
            value = default;
            return false;
        }

        public static bool TryGetTexture(this Material self, string name, out Texture value)
        {
            return self.TryGetTexture(Shader.PropertyToID(name), out value);
        }

        public static bool TryGetTexture2D(this Material self, int nameID, out Texture2D value)
        {
            value = null;
            if (self.TryGetTexture(nameID, out var texture))
            {
                value = texture as Texture2D;
                return value != null;
            }
            return false;
        }

        public static bool TryGetTexture2D(this Material self, string name, out Texture2D value)
        {
            return self.TryGetTexture2D(Shader.PropertyToID(name), out value);
        }

        public static bool TryGetVector(this Material self, int nameID, out Vector4 value)
        {
            if (self.HasVector(nameID))
            {
                value = self.GetVector(nameID);
                return true;
            }
            value = default;
            return false;
        }

        public static bool TryGetVector(this Material self, string name, out Vector4 value)
        {
            return self.TryGetVector(Shader.PropertyToID(name), out value);
        }
    }
}
