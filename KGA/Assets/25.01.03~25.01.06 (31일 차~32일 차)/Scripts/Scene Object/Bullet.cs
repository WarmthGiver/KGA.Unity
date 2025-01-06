using UnityEngine;

namespace KGA.Day31
{
    [DisallowMultipleComponent]

    public sealed class Bullet : Projectile
    {
        protected override void Movement()
        {
            transform.Translate(Vector2.up * speed);
        }

        protected override void Dead()
        {
            Destroy(gameObject);
        }
    }
}