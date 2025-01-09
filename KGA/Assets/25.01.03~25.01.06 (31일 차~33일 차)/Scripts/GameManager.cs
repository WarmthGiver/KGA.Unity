using UnityEngine;

namespace KGA.Day31
{
    [DisallowMultipleComponent]

    public sealed class GameManager : MonoBehaviour
    {
        // �̱��� ����(Singleton Pattern)
        // ����Ʈ���� ������ ���� �� �ϳ�.
        // Ŭ������ �ν��Ͻ�(Instance)�� �� �ϳ��� �����ǵ��� ����.
        public static GameManager Instance { get; private set; } = null;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;

                DontDestroyOnLoad(gameObject);
            }

            else
            {
                Destroy(gameObject);
            }
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
}