using System.Collections.Generic;
using UnityEngine;

namespace Common
{
    public class CustomInput
    {
        private const string HORIZONTAL = "Horizontal";
        private const string VERTICAL = "Vertical";
        private const int HORIZONTAL_ID = 0;
        private const int VERTICAL_ID = 1;

        private Dictionary<KeyCode, VirtualButton> m_Keys = new Dictionary<KeyCode, VirtualButton>();
        private Dictionary<string, VirtualButton> m_Buttons = new Dictionary<string, VirtualButton>();

        private Vector2 m_Axes;
        private Vector3 m_MousePosition;

        public float GetAxisHorizontal()
        {
            if (m_Axes[HORIZONTAL_ID] != 0.0f)
                return m_Axes[HORIZONTAL_ID];
            return Input.GetAxis(HORIZONTAL);
        }

        public void SetAxisHorizontal(float value)
        {
            m_Axes[HORIZONTAL_ID] = value;
        }

        public float GetAxisRawHorizontal()
        {
            if (m_Axes[HORIZONTAL_ID] != 0.0f)
                return m_Axes[HORIZONTAL_ID];
            return Input.GetAxisRaw(HORIZONTAL);
        }

        public void SetAxisRawHorizontal(float value)
        {
            m_Axes[HORIZONTAL_ID] = value;
        }

        public float GetAxisVertical()
        {
            if (m_Axes[VERTICAL_ID] != 0.0f)
                return m_Axes[VERTICAL_ID];
            return Input.GetAxis(VERTICAL);
        }

        public void SetAxisVertical(float value)
        {
            m_Axes[VERTICAL_ID] = value;
        }

        public float GetAxisRawVertical()
        {
            if (m_Axes[VERTICAL_ID] != 0.0f)
                return m_Axes[VERTICAL_ID];
            return Input.GetAxisRaw(VERTICAL);
        }

        public void SetAxisRawVertical(float value)
        {
            m_Axes[VERTICAL_ID] = value;
        }

        public bool GetKey(KeyCode key)
        {
            if (m_Keys.TryGetValue(key, out VirtualButton virtualKey))
                return virtualKey.IsPressed;
            return Input.GetKey(key);
        }

        public bool GetKeyDown(KeyCode key)
        {
            if (m_Keys.TryGetValue(key, out VirtualButton virtualKey))
                return virtualKey.IsDown;
            return Input.GetKeyDown(key);
        }

        public void SetKeyDown(KeyCode key)
        {
            GetEnsuredKey(key).Pressed();
        }

        public bool GetKeyUp(KeyCode key)
        {
            if (m_Keys.TryGetValue(key, out VirtualButton virtualKey))
                return virtualKey.IsUp;
            return Input.GetKeyUp(key);
        }

        public void SetKeyUp(KeyCode key)
        {
            GetEnsuredKey(key).Released();
        }

        public void RemoveKey(KeyCode key)
        {
            m_Keys.Remove(key);
        }

        public bool GetButton(string buttonName)
        {
            if (m_Buttons.TryGetValue(buttonName, out VirtualButton virtualKey))
                return virtualKey.IsPressed;
            return Input.GetKey(buttonName);
        }

        public bool GetButtonDown(string buttonName)
        {
            if (m_Buttons.TryGetValue(buttonName, out VirtualButton virtualKey))
                return virtualKey.IsDown;
            return Input.GetKeyDown(buttonName);
        }

        public void SetButtonDown(string buttonName)
        {
            GetEnsuredButton(buttonName).Pressed();
        }

        public bool GetButtonUp(string buttonName)
        {
            if (m_Buttons.TryGetValue(buttonName, out VirtualButton virtualKey))
                return virtualKey.IsUp;
            return Input.GetKeyUp(buttonName);
        }

        public void SetButtonUp(string buttonName)
        {
            GetEnsuredButton(buttonName).Released();
        }

        public void RemoveButton(string buttonName)
        {
            m_Buttons.Remove(buttonName);
        }

        public Vector3 GetMousePosition()
        {
            if (!Mathx.IsZero(m_MousePosition))
                return m_MousePosition;
            return Input.mousePosition;
        }

        public void SetMousePosition(Vector3 position)
        {
            m_MousePosition = position;
        }

        private VirtualButton GetEnsuredKey(KeyCode key)
        {
            if (m_Keys.TryGetValue(key, out VirtualButton result))
                return result;
            result = new VirtualButton();
            m_Keys[key] = result;
            return result;
        }

        private VirtualButton GetEnsuredButton(string buttonName)
        {
            if (m_Buttons.TryGetValue(buttonName, out VirtualButton result))
                return result;
            result = new VirtualButton();
            m_Buttons[buttonName] = result;
            return result;
        }
    }
}
