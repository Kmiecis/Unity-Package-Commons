using UnityEngine;
using UnityEngine.Animations;

namespace Common.Extensions
{
    public static class ParentConstraintExtensions
    {
        public static void AddSource(this ParentConstraint self, Transform source, float weight = 1.0f)
        {
            self.AddSource(new ConstraintSource { sourceTransform = source, weight = weight });
        }

        public static void EnsureSource(this ParentConstraint self, Transform source, float weight = 1.0f)
        {
            self.EnsureSource(new ConstraintSource { sourceTransform = source, weight = weight });
        }

        public static void EnsureSource(this ParentConstraint self, ConstraintSource source)
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

        public static void RemoveSource(this ParentConstraint self, Transform source)
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

        public static void ClearSources(this ParentConstraint self)
        {
            var count = self.sourceCount;
            for (int i = count - 1; i > -1; --i)
            {
                self.RemoveSource(i);
            }
        }

        public static void RemoveLastSource(this ParentConstraint self)
        {
            self.RemoveSource(self.sourceCount - 1);
        }
    }
}