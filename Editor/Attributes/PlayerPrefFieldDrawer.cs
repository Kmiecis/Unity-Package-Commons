using Common;
using Common.Mathematics;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomPropertyDrawer(typeof(PlayerPrefFieldAttribute))]
    public class PlayerPrefFieldDrawer : BasePropertyDrawer<PlayerPrefFieldAttribute>
    {
        private static Dictionary<string, object> _values;

        static PlayerPrefFieldDrawer()
        {
            _values = new Dictionary<string, object>();
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var key = attribute.key ?? property.MakeKey();

            if (!_values.TryGetValue(key, out var previous))
            {
                previous = ReadValue(property, key);

                WriteValue(property, key, previous);

                _values[key] = previous;
            }

            var current = DrawValue(position, label, property, previous);

            if (!Equals(previous, current))
            {
                WriteValue(property, key, current);

                _values[key] = current;

                TriggerOnValidate(property);
            }
        }

        private void TriggerOnValidate(SerializedProperty property)
        {
            var values = property.GetValueChain().ToArray();
            var parent = values[^2];

            var method = parent.GetType().GetMethod("OnValidate", UBinding.AnyInstance);
            method?.Invoke(parent);
        }

        private object ReadValue(SerializedProperty property, string key)
        {
            switch (property.propertyType)
            {
                case SerializedPropertyType.Boolean:
                    return PlayerPrefs.GetInt(key, default) > 0;
                case SerializedPropertyType.Color:
                    return UPlayerPrefs.GetColor(key, Color.white);
                case SerializedPropertyType.Float:
                    return PlayerPrefs.GetFloat(key, default);
                case SerializedPropertyType.Integer:
                    return PlayerPrefs.GetInt(key, default);
                case SerializedPropertyType.Quaternion:
                    return UPlayerPrefs.GetQuaternion(key, Quaternion.identity);
                case SerializedPropertyType.Rect:
                    return UPlayerPrefs.GetRect(key, default);
                case SerializedPropertyType.RectInt:
                    return UPlayerPrefs.GetRectInt(key, default);
                case SerializedPropertyType.String:
                    return PlayerPrefs.GetString(key, string.Empty);
                case SerializedPropertyType.Vector2:
                    return UPlayerPrefs.GetVector2(key, default);
                case SerializedPropertyType.Vector2Int:
                    return UPlayerPrefs.GetVector2Int(key, default);
                case SerializedPropertyType.Vector3:
                    return UPlayerPrefs.GetVector3(key, default);
                case SerializedPropertyType.Vector3Int:
                    return UPlayerPrefs.GetVector3Int(key, default);
                case SerializedPropertyType.Vector4:
                    return UPlayerPrefs.GetVector4(key, default);
                default:
                    return null;
            }
        }

        private void WriteValue(SerializedProperty property, string key, object value)
        {
            switch (property.propertyType)
            {
                case SerializedPropertyType.Boolean:
                    PlayerPrefs.SetInt(key, (bool)value ? 1 : 0);
                    break;
                case SerializedPropertyType.Color:
                    UPlayerPrefs.SetColor(key, (Color)value);
                    break;
                case SerializedPropertyType.Float:
                    PlayerPrefs.SetFloat(key, (float)value);
                    break;
                case SerializedPropertyType.Integer:
                    PlayerPrefs.SetInt(key, (int)value);
                    break;
                case SerializedPropertyType.Quaternion:
                    UPlayerPrefs.SetQuaternion(key, (Quaternion)value);
                    break;
                case SerializedPropertyType.Rect:
                    UPlayerPrefs.SetRect(key, (Rect)value);
                    break;
                case SerializedPropertyType.RectInt:
                    UPlayerPrefs.SetRectInt(key, (RectInt)value);
                    break;
                case SerializedPropertyType.String:
                    PlayerPrefs.SetString(key, (string)value);
                    break;
                case SerializedPropertyType.Vector2:
                    UPlayerPrefs.SetVector2(key, (Vector2)value);
                    break;
                case SerializedPropertyType.Vector2Int:
                    UPlayerPrefs.SetVector2Int(key, (Vector2Int)value);
                    break;
                case SerializedPropertyType.Vector3:
                    UPlayerPrefs.SetVector3(key, (Vector3)value);
                    break;
                case SerializedPropertyType.Vector3Int:
                    UPlayerPrefs.SetVector3Int(key, (Vector3Int)value);
                    break;
                case SerializedPropertyType.Vector4:
                    UPlayerPrefs.SetVector4(key, (Vector4)value);
                    break;
            }

            property.SetValue(value);
        }

        private object DrawValue(Rect position, GUIContent label, SerializedProperty property, object value)
        {
            switch (property.propertyType)
            {
                case SerializedPropertyType.Boolean:
                    return EditorGUI.Toggle(position, label, (bool)value);
                case SerializedPropertyType.Color:
                    return EditorGUI.ColorField(position, label, (Color)value);
                case SerializedPropertyType.Float:
                    return EditorGUI.FloatField(position, label, (float)value);
                case SerializedPropertyType.Integer:
                    return EditorGUI.IntField(position, label, (int)value);
                case SerializedPropertyType.Quaternion:
                    return Quaternion.Euler(EditorGUI.Vector3Field(position, label, Mathx.Round(((Quaternion)value).eulerAngles, 3)));
                case SerializedPropertyType.Rect:
                    return EditorGUI.RectField(position, label, (Rect)value);
                case SerializedPropertyType.RectInt:
                    return EditorGUI.RectIntField(position, label, (RectInt)value);
                case SerializedPropertyType.String:
                    return EditorGUI.TextField(position, label, (string)value);
                case SerializedPropertyType.Vector2:
                    return EditorGUI.Vector2Field(position, label, (Vector2)value);
                case SerializedPropertyType.Vector2Int:
                    return EditorGUI.Vector2IntField(position, label, (Vector2Int)value);
                case SerializedPropertyType.Vector3:
                    return EditorGUI.Vector3Field(position, label, (Vector3)value);
                case SerializedPropertyType.Vector3Int:
                    return EditorGUI.Vector3IntField(position, label, (Vector3Int)value);
                case SerializedPropertyType.Vector4:
                    return EditorGUI.Vector4Field(position, label, (Vector4)value);
            }

            EditorGUI.PropertyField(position, property, label);
            return null;
        }
    }
}