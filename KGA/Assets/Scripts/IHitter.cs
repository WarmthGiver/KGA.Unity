using UnityEngine;

namespace ZL
{
    public interface IHitter
    {
        public LayerMask HittableLayers { get; }

        public void Hit(IHittable hittable);
    }
}