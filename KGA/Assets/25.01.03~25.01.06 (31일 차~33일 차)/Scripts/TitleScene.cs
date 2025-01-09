using UnityEngine;

using UnityEngine.SceneManagement;

namespace KGA.Day31
{
    [DisallowMultipleComponent]

    public sealed class TitleScene : MonoBehaviour
    {
        private void Update()
        {
            if (Input.anyKeyDown == true)
            {
                SceneManager.LoadScene("Stage 1 Scene");
            }
        }
    }
}