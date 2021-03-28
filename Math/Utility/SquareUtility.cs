using UnityEngine;

namespace Common
{
    public static class SquareUtility
    {
        public const float SIDE_LENGTH = 1.0f;
        public const float CENTER_TO_SIDE = SIDE_LENGTH * 0.5f;
        public const float CENTER_TO_VERTEX = Mathx.ROOT_2 * CENTER_TO_SIDE;

        /*_ __ __ __
        1           2
        |           |
        |           |
        |           |
        0__ __ __ __3
        */

        public static readonly Vector2[] Vertices = new Vector2[]
        {
            new Vector2(-CENTER_TO_SIDE, -CENTER_TO_SIDE),
            new Vector2(-CENTER_TO_SIDE, +CENTER_TO_SIDE),
            new Vector2(+CENTER_TO_SIDE, +CENTER_TO_SIDE),
            new Vector2(+CENTER_TO_SIDE, -CENTER_TO_SIDE)
        };
    }
}