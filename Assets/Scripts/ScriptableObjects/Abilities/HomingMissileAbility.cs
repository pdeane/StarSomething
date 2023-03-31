using StarSomething.Controllers.Abilities;
using UnityEngine;

namespace StarSomething.ScriptableObjects.Abilities
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Ability/Homing Missile", order = 1)]
    public class HomingMissileAbility : Ability
    {
        [SerializeField] private GameObject _prefab;

        [Header("Attributes")]
        [SerializeField] private float _missileSpeed;

        private HomingMissileController HomingMissileController { get; set; }

        public override void Use()
        {
            Debug.Log($"Used Ability {nameof(HomingMissileAbility)}");
            GameObject missileObject = Instantiate(_prefab);
            HomingMissileController = missileObject.AddComponent<HomingMissileController>();
            HomingMissileController.MissileSpeed = _missileSpeed;
        }
    }
}
