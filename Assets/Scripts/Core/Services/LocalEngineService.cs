using System.Collections.Generic;
using UnityEngine;

namespace StarSomething.Core.Services
{
    public class LocalEngineService : EngineServiceBase
    {
        private Dictionary<string, Vector2> MovementDirections { get; set; }

        public override void SetMovement(string playerId, Vector2 direction)
        {
            MovementDirections[playerId] = direction;
        }

        #region Unity
        protected override void Awake()
        {
            MovementDirections = new Dictionary<string, Vector2>();
            base.Awake();
        }

        private void FixedUpdate()
        {
        }
        #endregion Unity
    }
}
