using Common;
using System;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public abstract class ASearchComponentDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.propertyType == SerializedPropertyType.ObjectReference &&
                property.objectReferenceValue == null)
            {
                var target = (Component)property.GetTargetObject();
                var type = fieldInfo.FieldType;

                var value = GetComponent(target, type);
                property.objectReferenceValue = value;
            }

            EditorGUI.PropertyField(position, property, label, true);
        }

        protected abstract Component GetComponent(Component target, Type type);
    }

    [CustomPropertyDrawer(typeof(SearchComponentAttribute))]
    public class SearchComponentDrawer : ASearchComponentDrawer
    {
        protected override Component GetComponent(Component target, Type type)
        {
            return target.GetComponent(type);
        }
    }

    [CustomPropertyDrawer(typeof(SearchComponentInChildrenAttribute))]
    public class SearchComponentInChildrenDrawer : ASearchComponentDrawer
    {
        protected override Component GetComponent(Component target, Type type)
        {
            return target.GetComponentInChildren(type);
        }
    }

    [CustomPropertyDrawer(typeof(SearchComponentInParentAttribute))]
    public class SearchComponentInParentDrawer : ASearchComponentDrawer
    {
        protected override Component GetComponent(Component target, Type type)
        {
            return target.GetComponentInParent(type);
        }
    }
}
