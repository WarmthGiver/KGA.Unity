using UnityEngine;

namespace KGA.Day30
{
    [DisallowMultipleComponent]

    public sealed class Meteorite : MonoBehaviour
    {
        // Vector2
        // x와 y값을 저장하는 구조체.
        private Vector2 startPoint = new(0f, 6f);

        private Vector2 direction = new(0f, -1f);

        public float speed = 0.1f;

        private void Start()
        {
            // UnityEngine.Random
            // 
            startPoint.x = Random.Range(-2.5f, 2.5f);

            startPoint.y = Random.Range(6f, 8f);

            transform.position = startPoint;
        }

        private void Update()
        {
            if (GameManager.IsGameOver == true)
            {
                return;
            }

            transform.Translate(direction * speed);

            if (transform.position.y <= -6f)
            {
                startPoint.x = Random.Range(-8.5f, 8.5f);

                startPoint.y = Random.Range(6f, 8f);

                transform.position = startPoint;
            }
        }
    }
}