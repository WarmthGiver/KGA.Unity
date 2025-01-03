using UnityEngine;

using TMPro;

namespace KGA.Day30
{
    [DisallowMultipleComponent]

    public sealed class GameManager : MonoBehaviour
    {
        private static GameManager instance = null;

        public static GameManager Instance => instance;

        private static bool isGameOver = false;

        public static bool IsGameOver => isGameOver;

        public TMP_Text gameOverText = null;

        private void Awake()
        {
            instance = this;
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        }

        public static void GameOver()
        {
            isGameOver = true;

            instance.gameOverText.gameObject.SetActive(true);
        }
    }
}