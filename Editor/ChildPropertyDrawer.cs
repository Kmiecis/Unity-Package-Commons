using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
	public abstract class ChildPropertyDrawer : PropertyDrawer
	{
		private const float HORIZONTAL_SPACING = 4.0f;
		private const float VERTICAL_SPACING = 2.0f;

		public abstract string[] Children { get; }

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			label = EditorGUI.BeginProperty(position, label, property);
			position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

			var count = Children.Length;
			var labels = new GUIContent[count];
			var properties = new SerializedProperty[count];

			for (int i = 0; i < count; i++)
			{
				var child = Children[i];
				var childProperty = property.FindPropertyRelative(child);

				labels[i] = new GUIContent(childProperty.displayName);
				properties[i] = childProperty;
			}

			DrawPropertyFields(position, labels, properties, count);

			EditorGUI.EndProperty();
		}

		private static void DrawPropertyFields(Rect position, GUIContent[] labels, SerializedProperty[] properties, int count)
		{
			var indentLevel = EditorGUI.indentLevel;
			var labelWidth = EditorGUIUtility.labelWidth;

			var width = (position.width - (count - 1) * HORIZONTAL_SPACING) / count;
			var contentPosition = new Rect(position.x, position.y, width, position.height);

			EditorGUI.indentLevel = 0;
			for (int i = 0; i < count; i++)
			{
				EditorGUIUtility.labelWidth = EditorStyles.label.CalcSize(labels[i]).x;
				EditorGUI.PropertyField(contentPosition, properties[i], labels[i]);
				contentPosition.x += width + HORIZONTAL_SPACING;
			}

			EditorGUIUtility.labelWidth = labelWidth;
			EditorGUI.indentLevel = indentLevel;
		}
	}
}