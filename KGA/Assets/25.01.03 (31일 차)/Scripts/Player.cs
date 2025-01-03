using UnityEngine;

namespace KGA.DevelRocket
{
    [DisallowMultipleComponent]

    public sealed class Player : MonoBehaviour
    {
        public float speed = 1f;

        private Rigidbody2D rigidbody2D;

        private void Start()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (MainScene.IsGameOver == true)
            {
                rigidbody2D.velocity = Vector3.zero;

                return;
            }

            if (Input.GetKey(KeyCode.W))
            {
                rigidbody2D.AddForce(Vector2.up * speed);
            }

            if (Input.GetKey(KeyCode.S))
            {
                rigidbody2D.AddForce(Vector2.down * speed);
            }

            if (Input.GetKey(KeyCode.A))
            {
                rigidbody2D.AddForce(Vector2.left * speed);
            }

            if (Input.GetKey(KeyCode.D))
            {
                rigidbody2D.AddForce(Vector2.right * speed);
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            MainScene.GameOver();
        }
    }
}