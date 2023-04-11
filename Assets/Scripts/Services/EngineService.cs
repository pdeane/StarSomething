using StarSomething.Core.Interfaces.Services;
using StarSomething.Core.Services;
using UnityEngine;

namespace StarSomething.Services
{
    public class EngineService : MonoBehaviour
    {
        private IEngineServerService EngineServerService { get; set; }

        #region Unity
        private void Awake()
        {
            EngineServerService = new EngineServerService();
        }
        #endregion Unity
    }
}
