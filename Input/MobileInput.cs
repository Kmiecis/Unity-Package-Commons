using System.Collections.Generic;
using UnityEngine;

namespace Common
{
    public class MobileInput : AbstractInput
    {
        private const int HORIZONTAL = 0;
        private const int VERTICAL = 1;

        private Dictionary<KeyCode, VirtualButton> m_Keys = new Dictionary<KeyCode, VirtualButton>();
        private Dictionary<string, VirtualButton> m_Buttons = new Dictionary<string, VirtualButton>();

        private Vector2 m_Axes;
        private Vector3 m_MousePosition;

        public override float GetAxisHorizontal()
        {
            return m_Axes[HORIZONTAL];
        }

        public override void SetAxisHorizontal(float value)
        {
            m_Axes[HORIZONTAL] = value;
        }

        public override float GetAxisRawHorizontal()
        {
            return m_Axes[HORIZONTAL];
        }

        public override void SetAxisRawHorizontal(float value)
        {
            m_Axes[HORIZONTAL] = value;
        }

        public override float GetAxisVertical()
        {
            return m_Axes[VERTICAL];
        }

        public override void SetAxisVertical(float value)
        {
            m_Axes[VERTICAL] = value;
        }

        public override float GetAxisRawVertical()
        {
            return m_Axes[VERTICAL];
        }

        public override void SetAxisRawVertical(float value)
        {
            m_Axes[VERTICAL] = value;
        }
        
        public override bool GetKey(KeyCode key)
        {
            return EnsureKey(key).IsPressed;
        }

        public override bool GetKeyDown(KeyCode key)
        {
            return EnsureKey(key).IsDown;
        }

        public override void SetKeyDown(KeyCode key)
        {
            EnsureKey(key).Pressed();
        }

        public override bool GetKeyUp(KeyCode key)
        {
            return EnsureKey(key).IsUp;
        }

        public override void SetKeyUp(KeyCode key)
        {
            EnsureKey(key).Released();
        }

        public override bool GetButton(string buttonName)
        {
            return EnsureButton(buttonName).IsPressed;
        }

        public override bool GetButtonDown(string buttonName)
        {
            return EnsureButton(buttonName).IsDown;
        }

        public override void SetButtonDown(string buttonName)
        {
            EnsureButton(buttonName).Pressed();
        }

        public override bool GetButtonUp(string buttonName)
        {
            return EnsureButton(buttonName).IsUp;
        }

        public override void SetButtonUp(string buttonName)
        {
            EnsureButton(buttonName).Released();
        }

        public override Vector3 GetMousePosition()
        {
            return m_MousePosition;
        }
        
        public override void SetMousePosition(Vector3 position)
        {
            m_MousePosition = position;
        }

        private VirtualButton EnsureKey(KeyCode key)
        {
            if (m_Keys.TryGetValue(key, out VirtualButton result))
                return result;
            result = new VirtualButton();
            m_Keys[key] = result;
            return result;
        }

        private VirtualButton EnsureButton(string buttonName)
        {
            if (m_Buttons.TryGetValue(buttonName, out VirtualButton result))
                return result;
            result = new VirtualButton();
            m_Buttons[buttonName] = result;
            return result;
        }
    }
}