using Common;
using Common.Mathematics;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
	[CustomPropertyDrawer(typeof(ShiftFieldAttribute))]
	public class ShiftFieldDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			if (property.propertyType == SerializedPropertyType.Integer)
			{
				const float ARROW_WIDTH = 20.0f;
				EditorGUI.PropertyField(position.CopyAndSet(width: position.width - 2 * ARROW_WIDTH), property);
				if (GUI.Button(position.CopyAndSet(x: position.x + position.width - 2 * ARROW_WIDTH, width: ARROW_WIDTH), "<"))
					property.intValue = mathx.shift_left(property.intValue);
				if (GUI.Button(position.CopyAndSet(x: position.x + position.width - ARROW_WIDTH, width: ARROW_WIDTH), ">"))
					property.intValue = mathx.shift_right(property.intValue);
			}
			else
			{
				EditorGUI.LabelField(position, label.text, "Use ShiftField with int.");
			}
		}
	}
}