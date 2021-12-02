using System.IO;
using UnityEngine;

namespace Common.Extensions
{
    public static class BinaryReaderExtensions
    {
        public static Vector2 ReadVector2(this BinaryReader self)
        {
            return new Vector2(
                self.ReadSingle(),
                self.ReadSingle()
            );
        }

        public static Vector3 ReadVector3(this BinaryReader self)
        {
            return new Vector3(
                self.ReadSingle(),
                self.ReadSingle(),
                self.ReadSingle()
            );
        }

        public static Vector4 ReadVector4(this BinaryReader self)
        {
            return new Vector4(
                self.ReadSingle(),
                self.ReadSingle(),
                self.ReadSingle(),
                self.ReadSingle()
            );
        }

        public static Vector2Int ReadVector2Int(this BinaryReader self)
        {
            return new Vector2Int(
                self.ReadInt32(),
                self.ReadInt32()
            );
        }

        public static Vector3Int ReadVector3Int(this BinaryReader self)
        {
            return new Vector3Int(
                self.ReadInt32(),
                self.ReadInt32(),
                self.ReadInt32()
            );
        }

        public static Color ReadColor(this BinaryReader self)
        {
            return new Color(
                self.ReadSingle(),
                self.ReadSingle(),
                self.ReadSingle(),
                self.ReadSingle()
            );
        }

        public static Color32 ReadColor32(this BinaryReader self)
        {
            return new Color32(
                self.ReadByte(),
                self.ReadByte(),
                self.ReadByte(),
                self.ReadByte()
            );
        }

        public static Quaternion ReadQuaternion(this BinaryReader self)
        {
            return new Quaternion(
                self.ReadSingle(),
                self.ReadSingle(),
                self.ReadSingle(),
                self.ReadSingle()
            );
        }
    }
}
