using System;
using StarSomething.ScriptableObjects;
using UnityEngine;

namespace StarSomething.Controllers
{
    public class PlayerControllerBase : MonoBehaviour
    {
        [Header("Default")]
        [SerializeField] private string _playerId;
        [SerializeField] private Ship _ship;

        protected string PlayerId { get => _playerId; private set => _playerId = value; }
        protected Ship Ship { get => _ship; private set => _ship = value; }

        #region Unity
        protected virtual void Awake()
        {
            PlayerId = Guid.NewGuid().ToString();
            Ship = Ship.Create(transform);
        }
        #endregion Unity
    }
}
