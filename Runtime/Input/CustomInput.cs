using System.Collections.Generic;
using UnityEngine;
using Common.Extensions;
using Common.Mathematics;

namespace Common.Inputs
{
    public static class CustomInput
    {
        private static readonly Dictionary<KeyCode, VirtualButton> _keys = new Dictionary<KeyCode, VirtualButton>();
        private static readonly Dictionary<string, VirtualButton> _buttons = new Dictionary<string, VirtualButton>();
        private static readonly Dictionary<string, float> _axes = new Dictionary<string, float>();

        private static Vector3 _mousePosition = UVector3.NaN;

        public static bool GetKey(KeyCode key)
        {
            if (TryGetCheckedKey(key, out var virtualKey))
                return virtualKey.IsPressed;
            return Input.GetKey(key);
        }

        public static bool GetKeyDown(KeyCode key)
        {
            if (TryGetCheckedKey(key, out var virtualKey))
                return virtualKey.IsDown;
            return Input.GetKeyDown(key);
        }

        public static bool GetKeyUp(KeyCode key)
        {
            if (TryGetCheckedKey(key, out var virtualKey))
                return virtualKey.IsUp;
            return Input.GetKeyUp(key);
        }

        public static void SetKey(KeyCode key, bool pressed)
        {
            GetEnsuredKey(key).IsPressed = pressed;
        }

        public static void SetKeyDown(KeyCode key)
        {
            SetKey(key, true);
        }

        public static void SetKeyUp(KeyCode key)
        {
            SetKey(key, false);
        }

        public static bool RemoveKey(KeyCode key)
        {
            return _keys.Remove(key);
        }

        public static bool GetButton(string buttonName)
        {
            if (TryGetCheckedButton(buttonName, out var virtualKey))
                return virtualKey.IsPressed;
            return Input.GetKey(buttonName);
        }

        public static bool GetButtonDown(string buttonName)
        {
            if (TryGetCheckedButton(buttonName, out var virtualKey))
                return virtualKey.IsDown;
            return Input.GetKeyDown(buttonName);
        }

        public static bool GetButtonUp(string buttonName)
        {
            if (TryGetCheckedButton(buttonName, out var virtualKey))
                return virtualKey.IsUp;
            return Input.GetKeyUp(buttonName);
        }

        public static void SetButton(string buttonName, bool pressed)
        {
            GetEnsuredButton(buttonName).IsPressed = pressed;
        }

        public static void SetButtonDown(string buttonName)
        {
            SetButton(buttonName, true);
        }

        public static void SetButtonUp(string buttonName)
        {
            SetButton(buttonName, false);
        }

        public static bool RemoveButton(string buttonName)
        {
            return _buttons.Remove(buttonName);
        }

        public static float GetAxis(string axisName)
        {
            if (_axes.TryGetValue(axisName, out var result))
                return result;
            return Input.GetAxis(axisName);
        }

        public static void SetAxis(string axisName, float value)
        {
            _axes[axisName] = value;
        }

        public static bool RemoveAxis(string axisName)
        {
            return _axes.Remove(axisName);
        }

        public static Vector3 GetMousePosition()
        {
            if (!Mathx.IsNaN(_mousePosition))
                return _mousePosition;
            return Input.mousePosition;
        }

        public static void SetMousePosition(Vector3 position)
        {
            _mousePosition = position;
        }

        public static void RemoveMousePosition()
        {
            _mousePosition = UVector3.NaN;
        }

        private static VirtualButton GetEnsuredFrom<TKey>(Dictionary<TKey, VirtualButton> dictionary, TKey key)
        {
            return dictionary.GetOrCompute(key, () => new VirtualButton());
        }

        private static VirtualButton GetEnsuredKey(KeyCode key)
        {
            return GetEnsuredFrom(_keys, key);
        }

        private static VirtualButton GetEnsuredButton(string buttonName)
        {
            return GetEnsuredFrom(_buttons, buttonName);
        }

        private static bool TryGetCheckedFrom<TKey>(Dictionary<TKey, VirtualButton> dictionary, TKey key, out VirtualButton button)
        {
            if (dictionary.TryGetValue(key, out button))
            {
                if (!button.IsPressed && !button.IsUp)
                {
                    dictionary.Remove(key);
                    button = null;
                }
            }
            return button != null;
        }

        private static bool TryGetCheckedKey(KeyCode key, out VirtualButton button)
        {
            return TryGetCheckedFrom(_keys, key, out button);
        }

        private static bool TryGetCheckedButton(string buttonName, out VirtualButton button)
        {
            return TryGetCheckedFrom(_buttons, buttonName, out button);
        }
    }
}
