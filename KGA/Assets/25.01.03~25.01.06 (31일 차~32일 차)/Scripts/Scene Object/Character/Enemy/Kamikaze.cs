using UnityEngine;

namespace KGA.Day31
{
    [DisallowMultipleComponent]

    public sealed class Kamikaze : Enemy
    {
        public Vector2 direction = new(0f, 1f);

        private void Start()
        {
            Initialize();
        }

        private void Initialize()
        {
            transform.position = new Vector2(Random.Range(-2f, 2f), 6);

            speed = Random.Range(0.01f, 0.1f);
        }

        protected override void Movement()
        {
            transform.Translate(direction * speed);

            if (transform.position.y <= -6f)
            {
                Initialize();
            }
        }
    }
}