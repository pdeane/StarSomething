using System;
using StarSomething.ScriptableObjects;
using UnityEngine;

namespace StarSomething.Core.Models
{
    public class Player
    {
        public event Action TransformChanged;

        public Ship Ship { get; set; }
        public Quaternion Rotation { get; set; }
        public Vector3 Position { get; set; }

        public Player(Ship ship,
                      Quaternion rotation,
                      Vector3 position)
        {
            Ship = ship;
            Rotation = rotation;
            Position = position;
        }

        public void OnTransformChanged()
        {
            TransformChanged?.Invoke();
        }
    }
}
