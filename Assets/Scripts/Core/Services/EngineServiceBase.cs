using System.Collections.Generic;
using StarSomething.Core.Models;
using UnityEngine;

namespace StarSomething.Core.Services
{
    public abstract class EngineServiceBase : MonoBehaviour
    {
        protected Dictionary<string, Player> Players { get; private set; }

        public void AddPlayer(string playerId, Player player)
        {
            Players.Add(playerId, player);
        }

        public abstract void SetMovement(string playerId, Vector2 direction);

        #region Unity
        protected virtual void Awake()
        {
            Players = new Dictionary<string, Player>();
        }
        #endregion Unity
    }
}
