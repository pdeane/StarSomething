using System;
using StarSomething.Core.Models;
using StarSomething.Core.Services;
using StarSomething.ScriptableObjects;
using UnityEngine;

namespace StarSomething.Controllers
{
    public class PlayerControllerBase : MonoBehaviour
    {
        [Header("Default attributes")]
        [SerializeField] private string _playerId;
        [SerializeField] private Ship _ship;

        protected Ship Ship { get => _ship; private set => _ship = value; }
        protected string PlayerId { get => _playerId; private set => _playerId = value; }

        protected Player Player { get; private set; }

        #region Events
        private void Player_TransformChanged()
        {
            transform.SetPositionAndRotation(Player.Position, Player.Rotation);
        }
        #endregion Events

        #region Unity
        protected virtual void Awake()
        {
            PlayerId = Guid.NewGuid().ToString();
            Ship = Ship.Create(transform);
            Player = new(Ship, transform.rotation, transform.position);
            Player.TransformChanged += Player_TransformChanged;
        }
        #endregion Unity
    }
}
