using UnityEngine;

namespace ZL
{
    [DisallowMultipleComponent]

    public sealed class HurtBox2D : MonoBehaviour
    {
        [SerializeField]

        private Collider2D collider2D;

        private IHittable hittable;

        public IHittable Hittable => hittable;

        private void Awake()
        {
            collider2D = GetComponent<Collider2D>();
        }

        public void Initialize(IHittable hittable)
        {
            this.hittable = hittable;

            collider2D.includeLayers = hittable.HitterLayers;
        }
    }
}