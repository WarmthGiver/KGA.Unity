using UnityEngine;

namespace KGA.Day31
{
    public sealed class Player : Character
    {
        private Vector2 position;

        protected override void Movement()
        {
            position = Vector2.zero;

            if (Input.GetKey(KeyCode.UpArrow))
            {
                position.y += 1f;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                position.y -= 1f;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                position.x -= 1f;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                position.x += 1f;
            }

            position = speed * Time.deltaTime * position.normalized;

            transform.Translate(position);
        }

        protected override void Dead()
        {
            Stage1Scene.GameOver();
        }
    }
}