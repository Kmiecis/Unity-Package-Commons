﻿using System;
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

        public static bool TryGetCustomAttribute<T>(this Type self, out T attribute)
            where T : Attribute
        {
            attribute = self.GetCustomAttribute<T>();
            return attribute != null;
        }

        public static bool HasCustomAttribute<T>(this Type self)
            where T : Attribute
        {
            var attribute = self.GetCustomAttribute<T>();
            return attribute != null;
        }

        public static bool HasInterface(this Type self, Type target)
        {
            var interfaces = self.GetInterfaces();
            foreach (var item in interfaces)
            {
                if (Equals(item, target))
                {
                    return true;
                }
            }
            return false;
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
            const BindingFlags Flags = BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            
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
            const BindingFlags Flags = BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.IgnoreCase;
            
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
