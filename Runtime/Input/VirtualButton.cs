using UnityEngine;

namespace Common.Inputs
{
    public class VirtualButton
    {
        private bool _isPressed;
        private int _pressedFrame = -1;
        private int _releasedFrame = -1;
        
        public bool IsPressed
        {
            get => _isPressed;
            set
            {
                _isPressed = value;
                if (value)
                {
                    _pressedFrame = Time.frameCount;
                }
                else
                {
                    _releasedFrame = Time.frameCount;
                }
            }
        }

        public bool IsDown
        {
            get => _pressedFrame == Time.frameCount - 1;
        }

        public bool IsUp
        {
            get => _releasedFrame == Time.frameCount - 1;
        }
    }
}
