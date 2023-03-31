using UnityEngine;

namespace StarSomething.Controllers.Abilities
{
    public class HomingMissileController : MonoBehaviour
    {
        public float MissileSpeed { get; set; }

        #region Unity
        private void FixedUpdate()
        {
            transform.position = transform.position + Vector3.right * MissileSpeed * Time.deltaTime;
        }
        #endregion Unity
    }
}
