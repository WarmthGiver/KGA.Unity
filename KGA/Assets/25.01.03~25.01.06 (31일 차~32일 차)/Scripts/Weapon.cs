using UnityEngine;

namespace KGA.Day31
{
    [DisallowMultipleComponent]

    public sealed class Weapon : MonoBehaviour
    {
        public Projectile bulletPrefab = null;

        private void Update()
        {
            if (Stage1Scene.IsGameOver == true)
            {
                return;
            }

            if (Input.GetKey(KeyCode.Space))
            {
                Instantiate(bulletPrefab, transform.position, transform.rotation);
            }
        }
    }
}