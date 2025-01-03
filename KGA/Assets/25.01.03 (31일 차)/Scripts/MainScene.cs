using TMPro;

using UnityEngine;

using UnityEngine.SceneManagement;

namespace KGA.DevelRocket
{
    [DisallowMultipleComponent]

    public sealed class MainScene : MonoBehaviour
    {
        private static MainScene instance;

        public static bool IsGameOver { get; private set; }

        public TMP_Text gameOverText = null;

        private void Awake()
        {
            instance = this;

            IsGameOver = false;
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }

            if (IsGameOver == true)
            {
                if (Input.anyKeyDown == true)
                {
                    SceneManager.LoadScene("Title Scene");
                }
            }
        }

        public static void GameOver()
        {
            IsGameOver = true;

            instance.gameOverText.gameObject.SetActive(true);
        }
    }
}