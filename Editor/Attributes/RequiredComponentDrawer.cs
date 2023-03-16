using Common;
using Common.Extensions;
using CommonEditor.Extensions;
using System;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public abstract class ARequiredComponentDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.propertyType == SerializedPropertyType.ObjectReference &&
                property.objectReferenceValue == null)
            {
                var target = (Component)property.GetTarget();
                var type = fieldInfo.FieldType;

                if (!TryGetComponent(target, type, out var value))
                {
                    value = target.gameObject.AddComponent(type);
                }
                property.objectReferenceValue = value;
            }

            EditorGUI.PropertyField(position, property, label, true);
        }

        protected abstract bool TryGetComponent(Component target, Type type, out Component component);
    }

    [CustomPropertyDrawer(typeof(RequiredComponentAttribute))]
    public class RequiredComponentDrawer : ARequiredComponentDrawer
    {
        protected override bool TryGetComponent(Component target, Type type, out Component component)
        {
            return target.TryGetComponent(type, out component);
        }
    }

    [CustomPropertyDrawer(typeof(RequiredComponentFromChildrenAttribute))]
    public class RequiredComponentFromChildrenDrawer : ARequiredComponentDrawer
    {
        protected override bool TryGetComponent(Component target, Type type, out Component component)
        {
            return target.TryGetComponentInChildren(type, out component);
        }
    }

    [CustomPropertyDrawer(typeof(RequiredComponentFromParentAttribute))]
    public class RequiredComponentFromParentDrawer : ARequiredComponentDrawer
    {
        protected override bool TryGetComponent(Component target, Type type, out Component component)
        {
            return target.TryGetComponentInParent(type, out component);
        }
    }
}
