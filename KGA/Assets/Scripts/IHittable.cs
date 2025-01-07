using UnityEngine;

namespace ZL
{
    public interface IHittable
    {
        public LayerMask HitterLayers { get; }

        public void TakeHit(int value);
    }
}