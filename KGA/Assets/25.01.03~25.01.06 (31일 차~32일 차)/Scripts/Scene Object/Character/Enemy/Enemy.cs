using UnityEngine;

namespace KGA.Day31
{
    [DisallowMultipleComponent]

    public abstract class Enemy : Character
    {
        public int collisionDamage = 1;

        public LayerMask collisionableLayers;

        private void Start()
        {
            Initialize();
        }

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

        private void Initialize()
        {
            transform.position = new Vector2(Random.Range(-2f, 2f), 6);

            speed = Random.Range(0.01f, 0.1f);
        }

        protected override void Dead()
        {
            Destroy(gameObject);
        }
    }
}