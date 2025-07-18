using System.IO;
using UnityEngine;

namespace Common
{
    public static class BinaryWriterExtensions
    {
        public static void Write(this BinaryWriter self, Vector2 value)
        {
            self.Write(value.x);
            self.Write(value.y);
        }

        public static void Write(this BinaryWriter self, Vector3 value)
        {
            self.Write(value.x);
            self.Write(value.y);
            self.Write(value.z);
        }

        public static void Write(this BinaryWriter self, Vector4 value)
        {
            self.Write(value.x);
            self.Write(value.y);
            self.Write(value.z);
            self.Write(value.w);
        }

        public static void Write(this BinaryWriter self, Vector2Int value)
        {
            self.Write(value.x);
            self.Write(value.y);
        }

        public static void Write(this BinaryWriter self, Vector3Int value)
        {
            self.Write(value.x);
            self.Write(value.y);
            self.Write(value.z);
        }

        public static void Write(this BinaryWriter self, Color value)
        {
            self.Write(value.r);
            self.Write(value.g);
            self.Write(value.b);
            self.Write(value.a);
        }

        public static void Write(this BinaryWriter self, Color32 value)
        {
            self.Write(value.r);
            self.Write(value.g);
            self.Write(value.b);
            self.Write(value.a);
        }

        public static void Write(this BinaryWriter self, Quaternion value)
        {
            self.Write(value.x);
            self.Write(value.y);
            self.Write(value.z);
            self.Write(value.w);
        }
    }
}
