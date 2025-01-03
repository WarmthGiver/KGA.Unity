using UnityEngine;

namespace KGA.Day30
{
    [DisallowMultipleComponent]

    public sealed class Background : MonoBehaviour
    {
        public float height;

        public float speed = 0.1f;

        private Vector3 originalPosition;

        private void Awake()
        {
            originalPosition = transform.position;
        }

        private void Update()
        {
            if (GameManager.IsGameOver == true)
            {
                return;
            }

            transform.Translate(Vector2.down * speed);

            if (transform.position.y <= height)
            {
                transform.position = originalPosition;
            }
        }
    }
}