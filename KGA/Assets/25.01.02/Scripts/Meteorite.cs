using UnityEngine;

namespace KGA
{
    [DisallowMultipleComponent]

    public sealed class Meteorite : MonoBehaviour
    {
        private Vector2 startPoint = new(0f, 6f);

        private Vector2 direction = new(0f, -1f);

        public float speed = 0.1f;

        private void Start()
        {
            startPoint.x = Random.Range(-2.5f, 2.5f);

            transform.position = startPoint;
        }

        private void Update()
        {
            transform.Translate(direction * speed);

            if (transform.position.y <= -6f)
            {
                startPoint.x = Random.Range(-2.5f, 2.5f);

                transform.position = startPoint;
            }
        }
    }
}