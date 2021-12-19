using System.Collections.Generic;
using UnityEngine;
using Common.Extensions;

namespace Common
{
    public static class CustomInput
    {
        private const string HORIZONTAL = "Horizontal";
        private const string VERTICAL = "Vertical";
        private const int HORIZONTAL_ID = 0;
        private const int VERTICAL_ID = 1;

        private static readonly Dictionary<KeyCode, VirtualButton> m_Keys = new Dictionary<KeyCode, VirtualButton>();
        private static readonly Dictionary<string, VirtualButton> m_Buttons = new Dictionary<string, VirtualButton>();

        private static Vector2 m_Axes;
        private static Vector3 m_MousePosition;

        public static float GetAxisHorizontal()
        {
            if (m_Axes[HORIZONTAL_ID] != 0.0f)
                return m_Axes[HORIZONTAL_ID];
            return Input.GetAxis(HORIZONTAL);
        }

        public static void SetAxisHorizontal(float value)
        {
            m_Axes[HORIZONTAL_ID] = value;
        }

        public static float GetAxisRawHorizontal()
        {
            if (m_Axes[HORIZONTAL_ID] != 0.0f)
                return m_Axes[HORIZONTAL_ID];
            return Input.GetAxisRaw(HORIZONTAL);
        }

        public static void SetAxisRawHorizontal(float value)
        {
            m_Axes[HORIZONTAL_ID] = value;
        }

        public static float GetAxisVertical()
        {
            if (m_Axes[VERTICAL_ID] != 0.0f)
                return m_Axes[VERTICAL_ID];
            return Input.GetAxis(VERTICAL);
        }

        public static void SetAxisVertical(float value)
        {
            m_Axes[VERTICAL_ID] = value;
        }

        public static float GetAxisRawVertical()
        {
            if (m_Axes[VERTICAL_ID] != 0.0f)
                return m_Axes[VERTICAL_ID];
            return Input.GetAxisRaw(VERTICAL);
        }

        public static void SetAxisRawVertical(float value)
        {
            m_Axes[VERTICAL_ID] = value;
        }

        public static bool GetKey(KeyCode key)
        {
            if (TryGetCheckedKey(key, out VirtualButton virtualKey))
                return virtualKey.IsPressed;
            return Input.GetKey(key);
        }

        public static bool GetKeyDown(KeyCode key)
        {
            if (TryGetCheckedKey(key, out VirtualButton virtualKey))
                return virtualKey.IsDown;
            return Input.GetKeyDown(key);
        }

        public static void SetKeyDown(KeyCode key)
        {
            GetEnsuredKey(key).IsPressed = true;
        }

        public static bool GetKeyUp(KeyCode key)
        {
            if (TryGetCheckedKey(key, out VirtualButton virtualKey))
                return virtualKey.IsUp;
            return Input.GetKeyUp(key);
        }

        public static void SetKeyUp(KeyCode key)
        {
            GetEnsuredKey(key).IsPressed = false;
        }

        public static void RemoveKey(KeyCode key)
        {
            m_Keys.Remove(key);
        }

        public static bool GetButton(string buttonName)
        {
            if (TryGetCheckedButton(buttonName, out VirtualButton virtualKey))
                return virtualKey.IsPressed;
            return Input.GetKey(buttonName);
        }

        public static bool GetButtonDown(string buttonName)
        {
            if (TryGetCheckedButton(buttonName, out VirtualButton virtualKey))
                return virtualKey.IsDown;
            return Input.GetKeyDown(buttonName);
        }

        public static void SetButtonDown(string buttonName)
        {
            GetEnsuredButton(buttonName).IsPressed = true;
        }

        public static bool GetButtonUp(string buttonName)
        {
            if (TryGetCheckedButton(buttonName, out VirtualButton virtualKey))
                return virtualKey.IsUp;
            return Input.GetKeyUp(buttonName);
        }

        public static void SetButtonUp(string buttonName)
        {
            GetEnsuredButton(buttonName).IsPressed = false;
        }

        public static void RemoveButton(string buttonName)
        {
            m_Buttons.Remove(buttonName);
        }

        public static Vector3 GetMousePosition()
        {
            if (!Mathx.IsZero(m_MousePosition))
                return m_MousePosition;
            return Input.mousePosition;
        }

        public static void SetMousePosition(Vector3 position)
        {
            m_MousePosition = position;
        }

        private static VirtualButton GetEnsuredFrom<TKey>(Dictionary<TKey, VirtualButton> dictionary, TKey key)
        {
            return dictionary.GetOrCompute(key, () => new VirtualButton());
        }

        private static VirtualButton GetEnsuredKey(KeyCode key)
        {
            return GetEnsuredFrom(m_Keys, key);
        }

        private static VirtualButton GetEnsuredButton(string buttonName)
        {
            return GetEnsuredFrom(m_Buttons, buttonName);
        }

        private static bool TryGetCheckedFrom<TKey>(Dictionary<TKey, VirtualButton> dictionary, TKey key, out VirtualButton button)
        {
            button = default;
            if (dictionary.TryGetValue(key, out button))
            {
                if (!button.IsPressed && !button.IsUp)
                {
                    dictionary.Remove(key);
                    button = default;
                }
            }
            return button != default;
        }

        private static bool TryGetCheckedKey(KeyCode key, out VirtualButton button)
        {
            return TryGetCheckedFrom(m_Keys, key, out button);
        }

        private static bool TryGetCheckedButton(string buttonName, out VirtualButton button)
        {
            return TryGetCheckedFrom(m_Buttons, buttonName, out button);
        }
    }
}
