using UnityEngine;

namespace ZL
{
    [DisallowMultipleComponent]

    public sealed class HitBox2D : MonoBehaviour
    {
        [SerializeField]

        private Collider2D collider2D;

        private IHitter hitter;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out HurtBox2D hurtbox) == true)
            {
                hitter.Hit(hurtbox.Hittable);
            }
        }

        public void Initialize(IHitter hitter)
        {
            this.hitter = hitter;

            collider2D.includeLayers = hitter.HittableLayers;
        }
    }
}