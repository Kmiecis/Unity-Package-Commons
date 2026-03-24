using Common;
using System;
using System.Linq;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace CommonEditor
{
    public abstract class ASearchComponentDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var target = (Component)property.serializedObject.targetObject;

            var chain = property.GetValueChain().ToArray();
            var parent = chain[^2];

            var type = fieldInfo.FieldType;
            if (type.IsArray)
            {
                var array = (Array)fieldInfo.GetValue(parent);
                if (array.Length == 1)
                {
                    var current = (Object)array.GetValue(0);
                    if (current == null)
                    {
                        type = type.GetElementType();
                        if (typeof(Component).IsAssignableFrom(type))
                        {
                            var components = GetComponents(target, type);
                            if (components.Length > 0)
                            {
                                var instances = Array.CreateInstance(type, components.Length);
                                Array.Copy(components, instances, instances.Length);

                                fieldInfo.SetValue(parent, instances);

                                EditorUtility.SetDirty(target);
                            }
                        }
                    }
                }
            }
            else
            {
                if (typeof(Component).IsAssignableFrom(type))
                {
                    var current = (Object)fieldInfo.GetValue(parent);
                    if (current == null)
                    {
                        var component = GetComponent(target, type);
                        if (component != null)
                        {
                            fieldInfo.SetValue(parent, component);

                            EditorUtility.SetDirty(target);
                        }
                    }
                }
            }
            
            EditorGUI.PropertyField(position, property, label, true);
        }

        protected abstract Component GetComponent(Component target, Type type);

        protected abstract Component[] GetComponents(Component target, Type type);
    }

    [CustomPropertyDrawer(typeof(SearchComponentAttribute))]
    public class SearchComponentDrawer : ASearchComponentDrawer
    {
        protected override Component GetComponent(Component target, Type type)
        {
            return target.GetComponent(type);
        }

        protected override Component[] GetComponents(Component target, Type type)
        {
            return target.GetComponents(type);
        }
    }

    [CustomPropertyDrawer(typeof(SearchComponentInChildrenAttribute))]
    public class SearchComponentInChildrenDrawer : ASearchComponentDrawer
    {
        protected new SearchComponentInChildrenAttribute attribute
            => (SearchComponentInChildrenAttribute)base.attribute;

        protected override Component GetComponent(Component target, Type type)
        {
            return target.GetComponentInChildren(type, attribute.includeInactive);
        }

        protected override Component[] GetComponents(Component target, Type type)
        {
            return target.GetComponentsInChildren(type, attribute.includeInactive);
        }
    }

    [CustomPropertyDrawer(typeof(SearchComponentInParentAttribute))]
    public class SearchComponentInParentDrawer : ASearchComponentDrawer
    {
        protected new SearchComponentInParentAttribute attribute
            => (SearchComponentInParentAttribute)base.attribute;

        protected override Component GetComponent(Component target, Type type)
        {
            return target.GetComponentInParent(type, attribute.includeInactive);
        }

        protected override Component[] GetComponents(Component target, Type type)
        {
            return target.GetComponentsInParent(type, attribute.includeInactive);
        }
    }
}
