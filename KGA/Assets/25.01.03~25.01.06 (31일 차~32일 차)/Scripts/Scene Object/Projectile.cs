using UnityEngine;

namespace KGA.Day31
{
    [DisallowMultipleComponent]

    public abstract class Projectile : SceneObject
    {
        public float lifeTime;

        public int collisionDamage = 1;

        public LayerMask collisionableLayers;

        private void OnTriggerStay(Collider other)
        {
            if (collisionableLayers.Belong(other) == true)
            {
                if (other is IDamageable damageable)
                {
                    damageable.TakeDamage(collisionDamage);
                }
            }
        }
    }
}