using Common;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(SelectableReferenceAttribute))]
    public class SelectableReferenceDrawer : BasePropertyDrawer<SelectableReferenceAttribute>
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (IsDrawerValid(property))
            {
                DrawDropdown(position, property, label);

                base.OnGUI(position, property, GUIContent.none);
            }
            else
            {
                base.OnGUI(position, property, label);
            }
        }

        private void DrawDropdown(Rect position, SerializedProperty property, GUIContent label)
        {
            var labelName = GetLabelTypeName(property);
            label.text += $" ({labelName})";

            position.height = EditorGUIUtility.singleLineHeight;

            if (EditorGUI.DropdownButton(position, label, FocusType.Keyboard))
            {
                var fieldTypeName = UEditorUtility.ConvertToSystemTypeName(property.managedReferenceFieldTypename);
                var fieldType = Type.GetType(fieldTypeName);

                var menu = new GenericMenu();

                foreach (var subtype in GetSubTypes(fieldType))
                {
                    var path = GetTypePath(subtype);

                    menu.AddItem(new GUIContent(path), false, OnMenuAdd, subtype);
                }

                menu.ShowAsContext();
            }

            void OnMenuAdd(object type)
            {
                var instance = Activator.CreateInstance((Type)type);
                property.serializedObject.Update();
                property.managedReferenceValue = instance;
                property.serializedObject.ApplyModifiedProperties();
            }
        }

        private bool IsDrawerValid(SerializedProperty property)
        {
            var fieldType = UEditorUtility.GetFieldType(fieldInfo);
            if (fieldType.IsValueType)
            {
                Debug.LogWarning(this.Format("Requires reference type field"));
                return false;
            }

            var attribute = Attribute.GetCustomAttribute(fieldInfo, typeof(SerializeReference));
            if (attribute == null)
            {
                Debug.LogWarning(this.Format($"Requires {nameof(SerializeReference)} attribute"));
                return false;
            }

            return true;
        }

        private static IEnumerable<Type> GetSubTypes(Type fieldType)
        {
            var result = new List<Type>();

            var subtypes = TypeCache.GetTypesDerivedFrom(fieldType);
            foreach (var subtype in subtypes)
            {
                if (IsTypeValid(subtype))
                {
                    result.Add(subtype);
                }
            }

            result.Sort((l, r) => string.Compare(GetTypeName(l), GetTypeName(r)));

            return result;
        }

        private static bool IsTypeValid(Type type)
        {
            return (
                !type.IsInterface &&
                !type.IsAbstract &&
                !type.HasCustomAttribute<ObsoleteAttribute>()
            );
        }

        private static string GetLabelTypeName(SerializedProperty property)
        {
            var systemTypeName = UEditorUtility.ConvertToSystemTypeName(property.managedReferenceFullTypename);
            if (systemTypeName != null)
            {
                var type = Type.GetType(systemTypeName);
                return GetTypeName(type);
            }
            return "null";
        }

        private static string GetTypeName(Type type)
        {
            if (type.TryGetCustomAttribute<NamedReferenceAttribute>(out var attribute))
            {
                return attribute.name;
            }
            return type.Name;
        }

        private static string GetTypePath(Type type)
        {
            if (type.TryGetCustomAttribute<NamedReferenceAttribute>(out var attribute))
            {
                if (attribute.path != null)
                {
                    return attribute.path + '/' + attribute.name;
                }
                return attribute.name;
            }
            return type.Name;
        }
    }
}