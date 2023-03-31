using UnityEngine;

namespace StarSomething.ScriptableObjects.Abilities
{
    public abstract class Ability : ScriptableObject
    {
        public abstract void Use();

        public virtual Ability Create()
        {
            Ability ability = Instantiate(this);
            return ability;
        }
    }
}
