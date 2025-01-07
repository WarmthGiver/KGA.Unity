using UnityEngine;

using ZL;

namespace KGA.Day31
{
    public abstract class Enemy : Character, IHitter
    {
        public int collisionDamage = 1;

        public LayerMask hittableLayers;

        public LayerMask HittableLayers => hittableLayers;

        private void Start()
        {
            Initialize();
        }

        private void Initialize()
        {
            transform.position = new Vector2(Random.Range(-2f, 2f), 6);

            speed = Random.Range(0.01f, 0.1f);
        }

        public void Hit(IHittable hittable)
        {

        }

        protected override void Dead()
        {
            Destroy(gameObject);
        }
    }
}