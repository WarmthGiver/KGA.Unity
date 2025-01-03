using UnityEngine;

namespace KGA.Day30
{
    [DisallowMultipleComponent]

    public sealed class Player : MonoBehaviour
    {
        // Rigidbody
        // 게임 오브젝트에 물리를 부여하는 컴포넌트.
        private Rigidbody2D rigidbody2D;

        private float speed = 1f;

        private void Start()
        {
            // GetComponent<T>()
            // GameObject에 부착된 다른 컴포넌트를 가져오는 함수.
            rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            // 만약 게임이 끝났다면,
            if (GameManager.IsGameOver == true)
            {
                // 가속도를 0으로 하고,
                rigidbody2D.velocity = Vector3.zero;

                // 함수를 탈출한다.
                return;
            }

            // 만약 A키가 눌렸다면,
            if (Input.GetKey(KeyCode.A))
            {
                // 왼쪽으로 물리적 힘을 준다.
                rigidbody2D.AddForce(Vector2.left * speed);
            }

            // 만약 D키가 눌렸다면,
            if (Input.GetKey(KeyCode.D))
            {
                // 오른쪽으로 물리적 힘을 준다.
                rigidbody2D.AddForce(Vector2.right * speed);
            }
        }

        // OnTriggerEnter2D()
        // Collider가 Trigger 일 때 충돌이 일어나면 한 번 호출되는 함수.
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("충돌 감지");

            GameManager.GameOver();
        }

        // OnTriggerStay2D()
        // Collider가 Trigger 일 때 충돌이 일어나는 동안 매 프레임마다 호출되는 함수.
        private void OnTriggerStay2D(Collider2D collision)
        {
            Debug.Log("충돌 중");
        }

        // OnTriggerExit2D()
        // Collider가 Trigger 일 때 충돌에서 벗어나면 한 번 호출되는 함수.
        private void OnTriggerExit2D(Collider2D collision)
        {
            Debug.Log("충돌 해제");
        }
    }
}