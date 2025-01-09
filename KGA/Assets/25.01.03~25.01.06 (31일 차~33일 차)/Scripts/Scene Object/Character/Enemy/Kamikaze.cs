using UnityEngine;

namespace KGA.Day31
{
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

            speed = Random.Range(1f, 10f);
        }

        protected override void Movement()
        {
            transform.Translate(speed * Time.deltaTime * direction);

            if (transform.position.y <= -6f)
            {
                Initialize();
            }
        }
    }
}