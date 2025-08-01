using UnityEngine;

namespace Common.Inputs
{
    [AddComponentMenu(nameof(Common) + "/" + nameof(Inputs) + "/Input Mouse System")]
    public class InputMouseSystem : MouseSystem
    {
        protected override Vector2 GetMousePosition()
        {
            return Input.mousePosition;
        }

        protected override bool IsHeld(int button)
        {
            return Input.GetMouseButton(button);
        }

        protected override bool IsReleased(int button)
        {
            return Input.GetMouseButtonUp(button);
        }
    }
}