using System.Collections.Generic;
using UnityEngine;

namespace Common
{
    public class UniformInput : AbstractInput
    {
        private const string HORIZONTAL = "Horizontal";
        private const string VERTICAL = "Vertical";
        private const int HORIZONTAL_ID = 0;
        private const int VERTICAL_ID = 1;

        private Dictionary<KeyCode, VirtualButton> m_Keys = new Dictionary<KeyCode, VirtualButton>();
        private Dictionary<string, VirtualButton> m_Buttons = new Dictionary<string, VirtualButton>();

        private Vector2 m_Axes;
        private Vector3 m_MousePosition;

        public override float GetAxisHorizontal()
        {
            if (m_Axes[HORIZONTAL_ID] != 0.0f)
                return m_Axes[HORIZONTAL_ID];
            return Input.GetAxis(HORIZONTAL);
        }

        public override void SetAxisHorizontal(float value)
        {
            m_Axes[HORIZONTAL_ID] = value;
        }

        public override float GetAxisRawHorizontal()
        {
            if (m_Axes[HORIZONTAL_ID] != 0.0f)
                return m_Axes[HORIZONTAL_ID];
            return Input.GetAxisRaw(HORIZONTAL);
        }

        public override void SetAxisRawHorizontal(float value)
        {
            m_Axes[HORIZONTAL_ID] = value;
        }

        public override float GetAxisVertical()
        {
            if (m_Axes[VERTICAL_ID] != 0.0f)
                return m_Axes[VERTICAL_ID];
            return Input.GetAxis(VERTICAL);
        }

        public override void SetAxisVertical(float value)
        {
            m_Axes[VERTICAL_ID] = value;
        }

        public override float GetAxisRawVertical()
        {
            if (m_Axes[VERTICAL_ID] != 0.0f)
                return m_Axes[VERTICAL_ID];
            return Input.GetAxisRaw(VERTICAL);
        }

        public override void SetAxisRawVertical(float value)
        {
            m_Axes[VERTICAL_ID] = value;
        }

        public override bool GetKey(KeyCode key)
        {
            if (TryGetVerifiedKey(key, out VirtualButton virtualKey))
                return virtualKey.IsPressed;
            return Input.GetKey(key);
        }

        public override bool GetKeyDown(KeyCode key)
        {
            if (TryGetVerifiedKey(key, out VirtualButton virtualKey))
                return virtualKey.IsDown;
            return Input.GetKeyDown(key);
        }

        public override void SetKeyDown(KeyCode key)
        {
            GetEnsuredKey(key).Pressed();
        }

        public override bool GetKeyUp(KeyCode key)
        {
            if (TryGetVerifiedKey(key, out VirtualButton virtualKey))
                return virtualKey.IsUp;
            return Input.GetKeyUp(key);
        }

        public override void SetKeyUp(KeyCode key)
        {
            GetEnsuredKey(key).Released();
        }

        public override bool GetButton(string buttonName)
        {
            if (TryGetVerifiedButton(buttonName, out VirtualButton virtualKey))
                return virtualKey.IsPressed;
            return Input.GetKey(buttonName);
        }

        public override bool GetButtonDown(string buttonName)
        {
            if (TryGetVerifiedButton(buttonName, out VirtualButton virtualKey))
                return virtualKey.IsDown;
            return Input.GetKeyDown(buttonName);
        }

        public override void SetButtonDown(string buttonName)
        {
            GetEnsuredButton(buttonName).Pressed();
        }

        public override bool GetButtonUp(string buttonName)
        {
            if (TryGetVerifiedButton(buttonName, out VirtualButton virtualKey))
                return virtualKey.IsUp;
            return Input.GetKeyUp(buttonName);
        }

        public override void SetButtonUp(string buttonName)
        {
            GetEnsuredButton(buttonName).Released();
        }

        public override Vector3 GetMousePosition()
        {
            if (!Mathx.IsZero(m_MousePosition))
                return m_MousePosition;
            return Input.mousePosition;
        }

        public override void SetMousePosition(Vector3 position)
        {
            m_MousePosition = position;
        }

        private bool TryGetVerifiedKey(KeyCode key, out VirtualButton virtualKey)
        {
            if (m_Keys.TryGetValue(key, out virtualKey))
            {
                if (virtualKey.IsValid)
                    return true;
                else
                    m_Keys.Remove(key);
            }
            virtualKey = null;
            return false;
        }

        private VirtualButton GetEnsuredKey(KeyCode key)
        {
            if (m_Keys.TryGetValue(key, out VirtualButton result))
                return result;
            result = new VirtualButton();
            m_Keys[key] = result;
            return result;
        }

        private bool TryGetVerifiedButton(string buttonName, out VirtualButton virtualButton)
        {
            if (m_Buttons.TryGetValue(buttonName, out virtualButton))
            {
                if (virtualButton.IsValid)
                    return true;
                else
                    m_Buttons.Remove(buttonName);
            }
            virtualButton = null;
            return false;
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