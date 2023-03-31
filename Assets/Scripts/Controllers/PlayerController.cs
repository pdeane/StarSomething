using StarSomething.ScriptableObjects;
using UnityEngine;
using UnityEngine.InputSystem;

namespace StarSomething.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Controls")]
        [SerializeField] private InputActionReference _movement;
        [SerializeField] private InputActionReference _action1;
        [SerializeField] private InputActionReference _action2;
        [SerializeField] private InputActionReference _special;

        [Header("Attributes")]
        [SerializeField] private Ship _ship;

        private Vector2 MoveVector { get; set; }

        private void Action1_Performed(InputAction.CallbackContext context)
        {
            Debug.Log("Action 1");
            _ship.Ability1.Use();
        }

        private void Action2_Performed(InputAction.CallbackContext context)
        {
            Debug.Log("Action 2");
        }

        private void Movement_Canceled(InputAction.CallbackContext context)
        {
            MoveVector = context.ReadValue<Vector2>();
            Debug.Log($"Movement Canceled - {MoveVector}");
        }

        private void Movement_Performed(InputAction.CallbackContext context)
        {
            MoveVector = context.ReadValue<Vector2>();
            Debug.Log($"Movement Performed - {MoveVector}");
        }

        private void Special_Performed(InputAction.CallbackContext context)
        {
            Debug.Log("Special");
        }

        #region Unity
        private void Awake()
        {
            _ship = _ship.Create(transform);
        }

        private void OnDisable()
        {
            _action1.action.performed -= Action1_Performed;
            _action2.action.performed -= Action2_Performed;
            _special.action.performed -= Special_Performed;
            _movement.action.canceled -= Movement_Canceled;
            _movement.action.performed -= Movement_Performed;
        }

        private void OnEnable()
        {
            _action1.action.performed += Action1_Performed;
            _action2.action.performed += Action2_Performed;
            _special.action.performed += Special_Performed;
            _movement.action.canceled += Movement_Canceled;
            _movement.action.performed += Movement_Performed;
        }
        #endregion Unity
    }
}
