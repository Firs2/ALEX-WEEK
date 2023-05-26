 

using FIRS.Attributes;
using FIRS.CoreModules.InputSystem;
using UnityEngine;

namespace FIRS.SystemModules
{
    [HideScriptField]
    [AddComponentMenu("FIRS/System Modules/Hardware/Cursor/Cursor Handler")]
    [DisallowMultipleComponent]
    public sealed class CursorHandler : MonoBehaviour
    {
        private enum Action
        {
            Show,
            Hide
        }

        [SerializeField]
        private Action action = Action.Show;

        /// <summary>
        /// Called when the script instance is being loaded.
        /// </summary>
        private void Awake()
        {
            switch (action)
            {
                case Action.Show:
                    InputReceiver.HardwareCursor(true);
                    break;
                case Action.Hide:
                    InputReceiver.HardwareCursor(false);
                    break;
            }
        }
    }
}