using System;
using UnityEngine;

namespace Common
{
    public class StandardInput : AbstractInput
    {
        private const string HORIZONTAL = "Horizontal";
        private const string VERTICAL = "Vertical";

        private const string EXCEPTION = "Unable to set input on non-mobile platform in StandardInput";

        public override float GetAxisHorizontal()
        {
            return Input.GetAxis(HORIZONTAL);
        }

        public override void SetAxisHorizontal(float value)
        {
            throw new Exception(EXCEPTION);
        }

        public override float GetAxisRawHorizontal()
        {
            return Input.GetAxisRaw(HORIZONTAL);
        }

        public override void SetAxisRawHorizontal(float value)
        {
            throw new Exception(EXCEPTION);
        }

        public override float GetAxisVertical()
        {
            return Input.GetAxis(VERTICAL);
        }

        public override void SetAxisVertical(float value)
        {
            throw new Exception(EXCEPTION);
        }
        
        public override float GetAxisRawVertical()
        {
            return Input.GetAxisRaw(VERTICAL);
        }

        public override void SetAxisRawVertical(float value)
        {
            throw new Exception(EXCEPTION);
        }

        public override bool GetKey(KeyCode key)
        {
            return Input.GetKey(key);
        }

        public override bool GetKeyDown(KeyCode key)
        {
            return Input.GetKeyDown(key);
        }

        public override void SetKeyDown(KeyCode key)
        {
            throw new Exception(EXCEPTION);
        }

        public override bool GetKeyUp(KeyCode key)
        {
            return Input.GetKeyUp(key);
        }

        public override void SetKeyUp(KeyCode key)
        {
            throw new Exception(EXCEPTION);
        }

        public override bool GetButton(string buttonName)
        {
            return Input.GetButton(buttonName);
        }

        public override bool GetButtonDown(string buttonName)
        {
            return Input.GetButtonDown(buttonName);
        }

        public override void SetButtonDown(string buttonName)
        {
            throw new Exception(EXCEPTION);
        }

        public override bool GetButtonUp(string buttonName)
        {
            return Input.GetButtonUp(buttonName);
        }

        public override void SetButtonUp(string buttonName)
        {
            throw new Exception(EXCEPTION);
        }

        public override Vector3 GetMousePosition()
        {
            return Input.mousePosition;
        }
        
        public override void SetMousePosition(Vector3 position)
        {
            throw new Exception(EXCEPTION);
        }
    }
}