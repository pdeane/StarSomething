using UnityEngine;

namespace StarSomething.Controllers.Abilities
{
    public class HomingMissileController : MonoBehaviour
    {
        public Transform Target { get; set; }
        public float MissileSpeed { get; set; }

        #region Unity
        private void FixedUpdate()
        {
            Vector3 direction = Target.position - transform.position;
            transform.position += MissileSpeed * Time.deltaTime * direction.normalized;
        }
        #endregion Unity
    }
}
