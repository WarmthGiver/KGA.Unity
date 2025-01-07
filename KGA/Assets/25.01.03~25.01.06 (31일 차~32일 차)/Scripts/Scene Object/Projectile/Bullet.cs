using UnityEngine;

namespace KGA.Day31
{
    public sealed class Bullet : Projectile
    {
        protected override void Movement()
        {
            transform.Translate(speed * Time.deltaTime * Vector2.up);
        }
    }
}