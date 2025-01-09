using UnityEngine;

using ZL;

namespace KGA.Day31
{
    [DisallowMultipleComponent]

    public sealed class Weapon : MonoBehaviour, IHitter
    {
        public Projectile bulletPrefab = null;

        [SerializeField]

        private LayerMask hittableLayers;

        public LayerMask HittableLayers => hittableLayers;

        private void Update()
        {
            if (Stage1Scene.IsGameOver == true)
            {
                return;
            }

            if (Input.GetKey(KeyCode.Space))
            {
                var projectile = Instantiate(bulletPrefab, transform.position, transform.rotation);

                projectile.Initialize(this);
            }
        }

        public void Hit(IHittable hittable)
        {

        }
    }
}