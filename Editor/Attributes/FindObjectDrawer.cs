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

    [CustomPropertyDrawer(typeof(FindObjectOfTypeAttribute))]
    public class FindObjectOfTypeDrawer : AFindObjectDrawer
    {
        protected override Object FindObject()
        {
            var attribute = (FindObjectOfTypeAttribute)this.attribute;
            var type = attribute.type ?? fieldInfo.FieldType;
            return Object.FindObjectOfType(type);
        }
    }

    [CustomPropertyDrawer(typeof(FindObjectWithNameAttribute))]
    public class FindObjectWithNameDrawer : AFindObjectDrawer
    {
        protected override Object FindObject()
        {
            var attribute = (FindObjectWithNameAttribute)this.attribute;
            var name = attribute.name ?? fieldInfo.Name;
            return GameObject.Find(name);
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
