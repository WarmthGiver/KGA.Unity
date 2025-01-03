using UnityEngine;

namespace KGA.DevelRocket
{
    [DisallowMultipleComponent]

    public sealed class Background : MonoBehaviour
    {
        public float height = 0f;

        public float speed = 0f;

        private Vector3 originalPosition;

        private void Awake()
        {
            originalPosition = transform.position;
        }

        private void Update()
        {
            if (MainScene.IsGameOver == true)
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