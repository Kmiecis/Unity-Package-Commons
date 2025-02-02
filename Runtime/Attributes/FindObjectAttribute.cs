using System;
using UnityEngine;

namespace Common
{
    public class FindObjectOfTypeAttribute : PropertyAttribute
    {
        public readonly Type type;

        public FindObjectOfTypeAttribute(Type type = null)
        {
            this.type = type;
        }
    }

    public class FindObjectWithNameAttribute : PropertyAttribute
    {
        public readonly string name;

        public FindObjectWithNameAttribute(string name = null)
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
