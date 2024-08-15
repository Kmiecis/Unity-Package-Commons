using System;

namespace Common
{
    [Flags]
    public enum EMeshBuildingOptions : byte
    {
        ALL = RECALCULATE_BOUNDS | RECALCULATE_NORMALS | RECALCULATE_TANGENTS,
        RECALCULATE_TANGENTS = 4,
        RECALCULATE_NORMALS = 2,
        RECALCULATE_BOUNDS = 1,
        NONE = 0
    }
}
