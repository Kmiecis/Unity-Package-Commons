using System.Collections.Generic;
using UnityEngine;

namespace Common.Mathematics
{
    public static class Geometry
    {
        public static IEnumerable<Vector2Int> GetPositions(Vector2Int position, Vector2Int direction, int size)
        {
            foreach (var offset in GetOffsets(direction, size))
            {
                yield return position + offset;
            }
        }

        public static IEnumerable<Vector2Int> GetOffsets(Vector2Int direction, int size)
        {
            var offset = Vector2Int.zero;

            if (direction.x < 0)
                offset.x += size - 1;

            if (direction.y < 0)
                offset.y += size - 1;

            if (direction.x != 0 && direction.y != 0)
            {
                var ylimit = (size + 0) * direction.y;
                for (int dy = 0; dy != ylimit; dy += direction.y)
                {
                    yield return new Vector2Int(offset.x + size * direction.x, offset.y + dy);
                }

                var xlimit = (size + 1) * direction.x;
                for (int dx = 0; dx != xlimit; dx += direction.x)
                {
                    yield return new Vector2Int(offset.x + dx, offset.y + size * direction.y);
                }
            }
            else
            {
                var ylimit = size * direction.x * direction.x;
                for (int dy = 0; dy < ylimit; ++dy)
                {
                    yield return new Vector2Int(offset.x + size * direction.x, offset.y + dy);
                }

                var xlimit = size * direction.y * direction.y;
                for (int dx = 0; dx < xlimit; ++dx)
                {
                    yield return new Vector2Int(offset.x + dx, offset.y + size * direction.y);
                }
            }
        }

        public static IEnumerable<Vector2Int> GetThickLine(Vector2Int a, Vector2Int b)
        {
            int dx = Mathf.Abs(b.x - a.x);
            int dy = Mathf.Abs(b.y - a.y);
            int x = a.x;
            int y = a.y;
            int n = 1 + dx + dy;
            int xinc = (b.x > a.x) ? 1 : -1;
            int yinc = (b.y > a.y) ? 1 : -1;
            int error = dx - dy;
            dx *= 2;
            dy *= 2;

            for (; n > 0; --n)
            {
                yield return new Vector2Int(x, y);

                // Prioritize vertical movement
                if (error > 0)
                {
                    x += xinc;
                    error -= dy;
                }
                else
                {
                    y += yinc;
                    error += dx;
                }
            }
        }

        public static IEnumerable<Vector2Int> GetThinLine(Vector2Int a, Vector2Int b)
        {
            int x = a.x;
            int y = a.y;

            int dx = b.x - a.x;
            int dy = b.y - a.y;

            int abs_dx = Mathf.Abs(dx);
            int abs_dy = Mathf.Abs(dy);

            int min = Mathf.Min(abs_dx, abs_dy);
            int max = Mathf.Max(abs_dx, abs_dy);

            var step = Vector2Int.zero;
            var acc_step = Vector2Int.zero;

            if (abs_dy > abs_dx)
            {
                step.y = Mathx.Sign(dy);
                acc_step.x = Mathx.Sign(dx);
            }
            else
            {
                step.x = Mathx.Sign(dx);
                acc_step.y = Mathx.Sign(dy);
            }

            int acc = max / 2;

            for (int i = 0; i < max; i++)
            {
                yield return new Vector2Int(x, y);

                x += step.x;
                y += step.y;

                acc += min;
                if (acc >= max)
                {
                    x += acc_step.x;
                    y += acc_step.y;

                    acc -= max;
                }
            }

            yield return b;
        }
    }
}