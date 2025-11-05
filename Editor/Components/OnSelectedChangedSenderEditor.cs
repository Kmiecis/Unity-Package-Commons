using Common;
using UnityEditor;
using UnityEngine;

namespace CommonEditor
{
    [CustomEditor(typeof(OnSelectedChangedSender))]
    public class OnSelectedChangedSenderEditor : Editor
    {
        private const string SelectedMethodName = "OnSelected";
        private const string DeselectedMethodName = "OnDeselected";

        private void SendSelected()
        {
            if (target is Component component)
            {
                SendChangedMessage(component, SelectedMethodName);
            }
        }

        private void SendDeselected()
        {
            if (target is Component component && component != null)
            {
                SendChangedMessage(component, DeselectedMethodName);
            }
        }

        private static void SendChangedMessage(Component target, string methodName)
        {
            var components = target.GetComponents<Component>();
            foreach (var component in components)
            {
                var method = component.GetType().GetMethod(methodName, UBinding.AnyInstance);
                if (method != null)
                {
                    method.Invoke(component, null);
                }
            }
        }

        private void OnEnable()
        {
            SendSelected();
        }

        private void OnDisable()
        {
            SendDeselected();
        }
    }
}