using System;
using System.Reflection;

namespace CommonEditor
{
    public static class UEditorUtility
    {
        public static Type GetFieldType(FieldInfo fieldInfo)
        {
            var fieldType = fieldInfo.FieldType;
            return fieldType.IsArray ? fieldType.GetElementType() : fieldType;
        }

        public static string ConvertToSystemTypeName(string managedReferenceTypename)
        {
            var split = managedReferenceTypename.Split(' ');
            if (split.Length != 2)
                return null;
            return (split[1] + ", " + split[0]);
        }

        public static string GetFullTypeName(string managedReferenceTypename)
        {
            var split = managedReferenceTypename.Split(' ');
            if (split.Length != 2)
                return null;
            return split[1];
        }

        public static string GetTypeName(string managedReferenceTypename)
        {
            var fullTypename = GetFullTypeName(managedReferenceTypename);
            if (fullTypename == null)
                return null;
            var split = fullTypename.Split('.');
            if (split.Length == 0)
                return null;
            return split[split.Length - 1];
        }

        public static string GetAssemblyName(string managedReferenceTypename)
        {
            var split = managedReferenceTypename.Split(' ');
            if (split.Length != 2)
                return null;
            return split[0];
        }
    }
}