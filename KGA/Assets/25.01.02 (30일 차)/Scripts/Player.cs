using UnityEngine;

namespace KGA.Day30
{
    [DisallowMultipleComponent]

    public sealed class Player : MonoBehaviour
    {
        // Rigidbody
        // ���� ������Ʈ�� ������ �ο��ϴ� ������Ʈ.
        private Rigidbody2D rigidbody2D;

        private float speed = 1f;

        private void Start()
        {
            // GetComponent<T>()
            // GameObject�� ������ �ٸ� ������Ʈ�� �������� �Լ�.
            rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            // ���� ������ �����ٸ�,
            if (GameManager.IsGameOver == true)
            {
                // ���ӵ��� 0���� �ϰ�,
                rigidbody2D.velocity = Vector3.zero;

                // �Լ��� Ż���Ѵ�.
                return;
            }

            // ���� AŰ�� ���ȴٸ�,
            if (Input.GetKey(KeyCode.A))
            {
                // �������� ������ ���� �ش�.
                rigidbody2D.AddForce(Vector2.left * speed);
            }

            // ���� DŰ�� ���ȴٸ�,
            if (Input.GetKey(KeyCode.D))
            {
                // ���������� ������ ���� �ش�.
                rigidbody2D.AddForce(Vector2.right * speed);
            }
        }

        // OnTriggerEnter2D()
        // Collider�� Trigger �� �� �浹�� �Ͼ�� �� �� ȣ��Ǵ� �Լ�.
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("�浹 ����");

            GameManager.GameOver();
        }

        // OnTriggerStay2D()
        // Collider�� Trigger �� �� �浹�� �Ͼ�� ���� �� �����Ӹ��� ȣ��Ǵ� �Լ�.
        private void OnTriggerStay2D(Collider2D collision)
        {
            Debug.Log("�浹 ��");
        }

        // OnTriggerExit2D()
        // Collider�� Trigger �� �� �浹���� ����� �� �� ȣ��Ǵ� �Լ�.
        private void OnTriggerExit2D(Collider2D collision)
        {
            Debug.Log("�浹 ����");
        }
    }
}