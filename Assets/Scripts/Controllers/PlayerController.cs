using StarSomething.Managers;
using UnityEngine;

namespace StarSomething.Controllers
{
    public class PlayerController : PlayerControllerBase
    {
        [SerializeField] private InputManager _inputManager;

        #region Events
        private void InputManager_Action1Performed()
        {
        }

        private void InputManager_Action2Performed()
        {
        }

        private void InputManager_SpecialPerformed()
        {
        }

        private void InputManager_MovementPerformed(Vector2 direction)
        {
        }
        #endregion Events

        #region Unity
        private void OnDestroy()
        {
            _inputManager.MovementPerformed -= InputManager_MovementPerformed;
            _inputManager.Action1Performed -= InputManager_Action1Performed;
            _inputManager.Action2Performed -= InputManager_Action1Performed;
            _inputManager.SpecialPerformed -= InputManager_Action1Performed;
        }

        private void Start()
        {
            _inputManager.MovementPerformed += InputManager_MovementPerformed;
            _inputManager.Action1Performed += InputManager_Action1Performed;
            _inputManager.Action2Performed += InputManager_Action1Performed;
            _inputManager.SpecialPerformed += InputManager_Action1Performed;
        }
        #endregion Unity
    }
}
