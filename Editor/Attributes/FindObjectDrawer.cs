using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    public abstract class AFindObjectDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.propertyType == SerializedPropertyType.ObjectReference &&
                property.objectReferenceValue == null)
            {
                var value = FindObject();
                property.objectReferenceValue = value;
            }

            EditorGUI.PropertyField(position, property, label, true);
        }

        protected abstract Object FindObject();
    }

    [CustomPropertyDrawer(typeof(FindObjectAttribute))]
    public class FindObjectDrawer : AFindObjectDrawer
    {
        protected override Object FindObject()
        {
            var type = fieldInfo.FieldType;
            return Object.FindObjectOfType(type);
        }
    }

    [CustomPropertyDrawer(typeof(FindObjectWithNameAttribute))]
    public class FindObjectWithNameDrawer : AFindObjectDrawer
    {
        protected override Object FindObject()
        {
            var attribute = (FindObjectWithNameAttribute)this.attribute;
            return GameObject.Find(attribute.name);
        }
    }

    [CustomPropertyDrawer(typeof(FindObjectWithTagAttribute))]
    public class FindObjectWithTagDrawer : AFindObjectDrawer
    {
        protected override Object FindObject()
        {
            var attribute = (FindObjectWithTagAttribute)this.attribute;
            return GameObject.FindWithTag(attribute.tag);
        }
    }
}
