using UnityEngine;

namespace ZL
{
    public interface IHittable
    {
        public int HP { get; }

        public LayerMask HitterLayers { get; }

        public void TakeHit(int value);
    }
}