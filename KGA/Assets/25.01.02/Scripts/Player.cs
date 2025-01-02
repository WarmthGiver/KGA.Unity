using UnityEngine;

namespace KGA
{
    [DisallowMultipleComponent]

    public sealed class Player : MonoBehaviour
    {
        private Vector2 position;

        private void Start()
        {
            position = transform.position;
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.A))
            {
                position.x -= 0.1f;
            }

            if (Input.GetKey(KeyCode.D))
            {
                position.x += 0.1f;
            }

            transform.position = position;
        }
    }
}