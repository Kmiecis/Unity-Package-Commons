using System;
using System.Collections.Generic;
using System.Reflection;

namespace Common.Extensions
{
    public static class TypeExtensions
    {
        public static object GetDefaultValue(this Type type)
        {
            if (type.IsValueType)
            {
                return Activator.CreateInstance(type);
            }
            return null;
        }

        public static bool TryGetCustomAttribute(this Type self, Type type, bool inherit, out Attribute attribute)
        {
            attribute = self.GetCustomAttribute(type, inherit);
            return attribute != null;
        }

        public static bool TryGetCustomAttribute(this Type self, Type type, out Attribute attribute)
        {
            return self.TryGetCustomAttribute(type, false, out attribute);
        }

        public static bool TryGetCustomAttribute<T>(this Type self, bool inherit, out T attribute)
            where T : Attribute
        {
            attribute = self.GetCustomAttribute<T>(inherit);
            return attribute != null;
        }

        public static bool TryGetCustomAttribute<T>(this Type self, out T attribute)
            where T : Attribute
        {
            return self.TryGetCustomAttribute<T>(false, out attribute);
        }

        public static bool HasCustomAttribute(this Type self, Type type, bool inherit = false)
        {
            var attribute = self.GetCustomAttribute(type, inherit);
            return attribute != null;
        }

        public static bool HasCustomAttribute<T>(this Type self, bool inherit = false)
            where T : Attribute
        {
            var attribute = self.GetCustomAttribute<T>(inherit);
            return attribute != null;
        }

        public static bool HasInterface(this Type self, Type type)
        {
            var interfaces = self.GetInterfaces();
            foreach (var item in interfaces)
            {
                if (Equals(item, type))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool HasInterface<T>(this Type self)
        {
            return self.HasInterface(typeof(T));
        }

        public static bool IsGenericTypeOf(this Type self, Type type)
        {
            while (self != null)
            {
                if (self.IsGenericType &&
                    self.GetGenericTypeDefinition() == type)
                {
                    return true;
                }

                self = self.BaseType;
            }
            return false;
        }

        public static bool IsGenericTypeOf<T>(this Type self)
        {
            return self.IsGenericTypeOf(typeof(T));
        }

        public static IEnumerable<FieldInfo> GetAllFields(this Type self, BindingFlags bindingAttr)
        {
            while (self != null)
            {
                var fields = self.GetFields(bindingAttr);
                for (int i = 0; i < fields.Length; ++i)
                {
                    yield return fields[i];
                }

                self = self.BaseType;
            }
        }

        public static IEnumerable<PropertyInfo> GetAllProperties(this Type self, BindingFlags bindingAttr)
        {
            while (self != null)
            {
                var properties = self.GetProperties(bindingAttr);
                for (int i = 0; i < properties.Length; ++i)
                {
                    yield return properties[i];
                }

                self = self.BaseType;
            }
        }

        public static FieldInfo FindField(this Type self, string name)
        {
            const BindingFlags Flags = BindingFlags.FlattenHierarchy | UBinding.AnyInstance;
            
            return self.FindField(name, Flags);
        }

        public static FieldInfo FindField(this Type self, string name, BindingFlags bindingAttr)
        {
            while (self != null)
            {
                var field = self.GetField(name, bindingAttr);
                if (field != null)
                {
                    return field;
                }

                self = self.BaseType;
            }
            return null;
        }

        public static PropertyInfo FindProperty(this Type self, string name)
        {
            const BindingFlags Flags = BindingFlags.FlattenHierarchy | BindingFlags.IgnoreCase | UBinding.AnyInstance;
            
            return self.FindProperty(name, Flags);
        }

        public static PropertyInfo FindProperty(this Type self, string name, BindingFlags bindingAttr)
        {
            while (self != null)
            {
                var property = self.GetProperty(name, bindingAttr);
                if (property != null)
                {
                    return property;
                }

                self = self.BaseType;
            }
            return null;
        }
    }
}
