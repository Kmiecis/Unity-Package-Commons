using System;

namespace Common
{
    [Flags]
    public enum EMeshBuildingOptions : byte
    {
        ALL = BOUNDS | NORMALS | TANGENTS,
        TANGENTS = 4,
        NORMALS = 2,
        BOUNDS = 1,
        NONE = 0
    }
}
