using Common;
using Common.Mathematics;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
	[CustomPropertyDrawer(typeof(LogFieldAttribute))]
	public class LogFieldDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			const float ARROW_WIDTH = 20.0f;
			if (property.propertyType == SerializedPropertyType.Float)
			{
				EditorGUI.PropertyField(position.CopyAndSet(width: position.width - 2 * ARROW_WIDTH), property);
				if (GUI.Button(position.CopyAndSet(x: position.x + position.width - 2 * ARROW_WIDTH, width: ARROW_WIDTH), "<"))
					property.floatValue = mathx.log_shift_left(property.floatValue);
				if (GUI.Button(position.CopyAndSet(x: position.x + position.width - ARROW_WIDTH, width: ARROW_WIDTH), ">"))
					property.floatValue = mathx.log_shift_right(property.floatValue);
			}
			else if (property.propertyType == SerializedPropertyType.Integer)
			{
				EditorGUI.PropertyField(position.CopyAndSet(width: position.width - 2 * ARROW_WIDTH), property);
				if (GUI.Button(position.CopyAndSet(x: position.x + position.width - 2 * ARROW_WIDTH, width: ARROW_WIDTH), "<"))
					property.intValue = mathx.log_shift_left(property.intValue);
				if (GUI.Button(position.CopyAndSet(x: position.x + position.width - ARROW_WIDTH, width: ARROW_WIDTH), ">"))
					property.intValue = mathx.log_shift_right(property.intValue);
			}
			else
			{
				EditorGUI.LabelField(position, label.text, "Use LogField with float or int.");
			}
		}
	}
}