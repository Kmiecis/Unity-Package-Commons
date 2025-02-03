using UnityEngine;
using UnityEngine.Animations;

namespace Common.Extensions
{
    public static class ConstraintExtensions
    {
        public static int AddSource(this IConstraint self, Transform source, float weight = 1.0f)
        {
            return self.AddSource(new ConstraintSource { sourceTransform = source, weight = weight });
        }

        public static void EnsureSource(this IConstraint self, Transform source, float weight = 1.0f)
        {
            self.EnsureSource(new ConstraintSource { sourceTransform = source, weight = weight });
        }

        public static void EnsureSource(this IConstraint self, ConstraintSource source)
        {
            if (self.sourceCount == 0)
            {
                self.AddSource(source);
            }
            else
            {
                self.SetSource(0, source);
            }
        }

        public static void RemoveSource(this IConstraint self, Transform source)
        {
            var count = self.sourceCount;
            for (int i = count - 1; i > -1; --i)
            {
                var constraint = self.GetSource(i);
                if (constraint.sourceTransform == source)
                {
                    self.RemoveSource(i);
                }
            }
        }

        public static void ClearSources(this IConstraint self)
        {
            var count = self.sourceCount;
            for (int i = count - 1; i > -1; --i)
            {
                self.RemoveSource(i);
            }
        }

        public static void RemoveLastSource(this IConstraint self)
        {
            self.RemoveSource(self.sourceCount - 1);
        }
    }
}