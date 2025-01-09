using UnityEngine;

namespace KGA.Day34
{
    [DisallowMultipleComponent]

    [RequireComponent(typeof(Rigidbody2D))]

    public sealed class Player : MonoBehaviour
    {
        [SerializeField]

        private float speed = 10f;

        [SerializeField]

        private float jumpPower = 5f;

        [SerializeField]

        private new Rigidbody2D rigidbody2D = null;

        [SerializeField]

        private SpriteRenderer spriteRenderer = null;

        [SerializeField]

        private Animator animator = null;

        private void Reset()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();

            spriteRenderer = GetComponentInChildren<SpriteRenderer>();

            animator = GetComponentInChildren<Animator>();
        }

        private void Update()
        {
            float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

            if (horizontal > 0f)
            {
                spriteRenderer.flipX = false;
            }

            else if (horizontal < 0f)
            {
                spriteRenderer.flipX = true;
            }

            animator.SetBool("IsWalking", horizontal != 0f);

            if (Input.GetKeyDown(KeyCode.W) == true)
            {
                rigidbody2D.AddForce(jumpPower * Vector2.up, ForceMode2D.Impulse);
            }

            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                animator.SetTrigger("IsShooting");
            }

            transform.Translate(horizontal, 0f, 0f);
        }
    }
}