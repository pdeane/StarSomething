using StarSomething.ScriptableObjects.Abilities;
using UnityEngine;

namespace StarSomething.ScriptableObjects
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Ship", order = 1)]
    public class Ship : ScriptableObject
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private string _name;

        [Header("Attributes")]
        [SerializeField] private uint _acceleration;
        [SerializeField] private uint _speed;
        [SerializeField] private uint _mass;

        [Space]
        [SerializeField] private uint _energy;
        [SerializeField] private uint _energyRegen;
        [SerializeField] private uint _hull;
        [SerializeField] private uint _shield;
        [SerializeField] private uint _shieldRegen;

        [Header("Abilities")]
        [SerializeField] private Ability _ability1;
        [SerializeField] private Ability _ability2;
        [SerializeField] private Ability _special;

        public Ability Ability1 => _ability1;
        public Ability Ability2 => _ability2;
        public Ability Special => _special;
        public GameObject ShipObject { get; private set; }

        public Ship Create(Transform parent)
        {
            Ship ship = Instantiate(this);
            ship.ShipObject = Instantiate(_prefab, parent);

            return ship;
        }
    }
}
