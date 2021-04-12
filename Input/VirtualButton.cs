using UnityEngine;

namespace Common
{
    public class VirtualButton
    {
        private bool m_Pressed;
        private int m_PressedFrame = -1;
        private int m_ReleasedFrame = -1;

        public void Pressed()
        {
            m_Pressed = true;
            m_PressedFrame = Time.frameCount;
        }

        public void Released()
        {
            m_Pressed = false;
            m_ReleasedFrame = Time.frameCount;
        }

        public bool IsPressed => m_Pressed;
        public bool IsDown => m_PressedFrame == Time.frameCount - 1;
        public bool IsUp => m_ReleasedFrame == Time.frameCount - 1;
        public bool IsValid => m_Pressed || m_ReleasedFrame >= Time.frameCount - 1;
    }
}