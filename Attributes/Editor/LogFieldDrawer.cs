using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
	[CustomPropertyDrawer(typeof(LogFieldAttribute))]
	public class LogFieldDrawer : PropertyDrawer
	{
		const float ARROW_WIDTH = 20.0f;

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			if (property.propertyType == SerializedPropertyType.Float)
			{
				EditorGUI.PropertyField(position.CopyAndSet(width: position.width - 2 * ARROW_WIDTH), property);
				if (GUI.Button(position.CopyAndSet(x: position.x + position.width - 2 * ARROW_WIDTH, width: ARROW_WIDTH), "<"))
					property.floatValue = LogShiftLeft(property.floatValue);
				if (GUI.Button(position.CopyAndSet(x: position.x + position.width - ARROW_WIDTH, width: ARROW_WIDTH), ">"))
					property.floatValue = LogShiftRight(property.floatValue);
			}
			else if (property.propertyType == SerializedPropertyType.Integer)
			{
				EditorGUI.PropertyField(position.CopyAndSet(width: position.width - 2 * ARROW_WIDTH), property);
				if (GUI.Button(position.CopyAndSet(x: position.x + position.width - 2 * ARROW_WIDTH, width: ARROW_WIDTH), "<"))
					property.intValue = LogShiftLeft(property.intValue);
				if (GUI.Button(position.CopyAndSet(x: position.x + position.width - ARROW_WIDTH, width: ARROW_WIDTH), ">"))
					property.intValue = LogShiftRight(property.intValue);
			}
			else
			{
				EditorGUI.LabelField(position, label.text, "Use LogField with float or int.");
			}
		}

		public static int LogShiftLeft(int v)
		{
			if (v > 0)
				return v / 10;
			else if (v < 0)
				return v * 10;
			return -1;
		}

		public static int LogShiftRight(int v)
		{
			if (v > 0)
				return v * 10;
			else if (v < 0)
				return v / 10;
			return 1;
		}

		public static float LogShiftLeft(float v)
		{
			if (v > 0)
				return v / 10;
			else if (v < 0)
				return v * 10;
			return -1;
		}

		public static float LogShiftRight(float v)
		{
			if (v > 0)
				return v * 10;
			else if (v < 0)
				return v / 10;
			return 1;
		}
	}
}