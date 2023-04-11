using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace StarSomething.Managers
{
    public class InputManager : MonoBehaviour
    {
        public event Action<Vector2> MovementPerformed;
        public event Action Action1Performed;
        public event Action Action2Performed;
        public event Action SpecialPerformed;

        #region Unity
        public void OnMovement(InputAction.CallbackContext context)
        {
            if (context.phase is InputActionPhase.Canceled or InputActionPhase.Performed)
            {
                Vector2 direction = context.ReadValue<Vector2>();
                Debug.Log($"Movement Performed - {direction}");
                MovementPerformed?.Invoke(direction);
            }
        }

        public void OnAction1(InputAction.CallbackContext context)
        {
            Debug.Log("Action 1");
            Action1Performed?.Invoke();
        }

        public void OnAction2(InputAction.CallbackContext context)
        {
            Debug.Log("Action 2");
            Action2Performed?.Invoke();
        }

        public void OnSpecial(InputAction.CallbackContext context)
        {
            Debug.Log("Special");
            SpecialPerformed?.Invoke();
        }
        #endregion Unity
    }
}
