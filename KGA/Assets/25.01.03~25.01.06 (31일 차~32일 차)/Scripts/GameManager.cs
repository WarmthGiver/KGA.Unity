using UnityEngine;

namespace KGA.Day31
{
    [DisallowMultipleComponent]

    public sealed class GameManager : MonoBehaviour
    {
        // 싱글톤 패턴(Singleton Pattern)
        // 소프트웨어 디자인 패턴 중 하나.
        // 클래스의 인스턴스(Instance)가 단 하나만 생성되도록 보장.
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