using UnityEngine;

namespace KGA.DevelRocket
{
    [DisallowMultipleComponent]

    public sealed class Enemy : MonoBehaviour
    {
        private float speed;

        private Vector2 direction = new(0f, -1f);

        private void Start()
        {
            Initialize();
        }

        private void Update()
        {
            if (MainScene.IsGameOver == true)
            {
                return;
            }

            transform.Translate(direction * speed);

            if (transform.position.y <= -6f)
            {
                Initialize();
            }
        }

        private void Initialize()
        {
            transform.position = new Vector2(Random.Range(-2f, 2f), 6);

            speed = Random.Range(0.01f, 0.1f);
        }
    }
}