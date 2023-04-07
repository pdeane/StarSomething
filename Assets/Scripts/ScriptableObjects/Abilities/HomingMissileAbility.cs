using StarSomething.Controllers.Abilities;
using UnityEngine;

namespace StarSomething.ScriptableObjects.Abilities
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Ability/Homing Missile", order = 1)]
    public class HomingMissileAbility : Ability
    {
        [Header("Attributes")]
        [SerializeField] private GameObject _prefab;
        [SerializeField] private float _missileSpeed;
        [SerializeField] private float _missileSelfDestruct;

        private HomingMissileController HomingMissileController { get; set; }
        private Transform Target { get; set; }

        public override void Use()
        {
            Debug.Log($"Used Ability {nameof(HomingMissileAbility)}");
            //GameObject missileObject = Instantiate(_prefab, Parent);
            //HomingMissileController = missileObject.AddComponent<HomingMissileController>();
            HomingMissileController.MissileSpeed = _missileSpeed;
            HomingMissileController.Target = Target;
        }
    }
}
