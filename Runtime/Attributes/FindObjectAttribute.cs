using UnityEngine;

namespace Common
{
    public class FindObjectAttribute : PropertyAttribute
    {
    }

    public class FindObjectWithNameAttribute : PropertyAttribute
    {
        public readonly string name;

        public FindObjectWithNameAttribute(string name)
        {
            this.name = name;
        }
    }

    public class FindObjectWithTagAttribute : PropertyAttribute
    {
        public readonly string tag;

        public FindObjectWithTagAttribute(string tag)
        {
            this.tag = tag;
        }
    }
}
