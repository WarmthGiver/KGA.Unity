using UnityEngine;

using ZL;

namespace KGA.Day31
{
    public abstract class Projectile : SceneObject, IHitter
    {
        public float lifeTime = 1f;

        public int penetration = 1;

        public int damage = 1;

        

        [SerializeField]

        private LayerMask hittableLayers;

        public LayerMask HittableLayers => hittableLayers;

        [SerializeField]

        private HitBox2D hitbox2D;

        private IHitter hitter;

        private void OnEnable()
        {
            Invoke(nameofDead, lifeTime);
        }

        private void OnDisable()
        {
            CancelInvoke(nameofDead);
        }

        public void Initialize(IHitter hitter)
        {
            this.hitter = hitter;

            hitbox2D.Initialize(this);
        }

        public void Hit(IHittable hittable)
        {
            hitter.Hit(hittable);

            if (--penetration == 0)
            {
                Dead();
            }
        }

        private static readonly string nameofDead = nameof(Dead);

        protected override void Dead()
        {
            Destroy(gameObject);
        }
    }
}