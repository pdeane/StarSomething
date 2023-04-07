using UnityEngine;

namespace StarSomething.ScriptableObjects.Abilities
{
    public abstract class Ability : ScriptableObject
    {
        [Header("Default Attributes")]
        [SerializeField] private int _cooldown;

        public abstract void Use();
    }
}
