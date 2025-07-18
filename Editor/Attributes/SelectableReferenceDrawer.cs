using Common;
using System;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(SelectableReferenceAttribute))]
    public class SelectableReferenceDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (IsDrawerValid())
            {
                DrawDropdown(position, property, label);
                DrawProperty(position, property, GUIContent.none);
            }
            else
            {
                DrawProperty(position, property, label);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }

        private void DrawDropdown(Rect position, SerializedProperty property, GUIContent label)
        {
            var systemTypeName = UEditorUtility.ConvertToSystemTypeName(property.managedReferenceFullTypename);
            if (systemTypeName != null)
            {
                var type = Type.GetType(systemTypeName);
                var name = GetTypeName(type);

                label.text += $" ({name})";
            }
            
            position.height = EditorGUIUtility.singleLineHeight;

            if (EditorGUI.DropdownButton(position, label, FocusType.Keyboard))
            {
                var fieldTypeName = UEditorUtility.ConvertToSystemTypeName(property.managedReferenceFieldTypename);
                var fieldType = Type.GetType(fieldTypeName);

                var menu = new GenericMenu();

                var subtypes = TypeCache.GetTypesDerivedFrom(fieldType);
                foreach (var subtype in subtypes)
                {
                    if (IsTypeValid(subtype))
                    {
                        var path = GetTypePath(subtype);

                        menu.AddItem(new GUIContent(path), false, OnMenuAdd, subtype);
                    }
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

        private void DrawProperty(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.PropertyField(position, property, label, true);
        }

        private bool IsTypeValid(Type type)
        {
            return (
                !type.IsInterface &&
                !type.IsAbstract &&
                !type.HasCustomAttribute<ObsoleteAttribute>()
            );
        }

        private string GetTypeName(Type type)
        {
            if (type.TryGetCustomAttribute<NamedReferenceAttribute>(out var attribute))
            {
                return attribute.name;
            }
            return type.Name;
        }

        private string GetTypePath(Type type)
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

        private bool IsDrawerValid()
        {
            var fieldType = UEditorUtility.GetFieldType(fieldInfo);
            if (fieldType.IsValueType)
                return false;

            var attribute = Attribute.GetCustomAttribute(fieldInfo, typeof(SerializeReference));
            if (attribute == null)
                return false;

            return true;
        }
    }
}