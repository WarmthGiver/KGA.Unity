using UnityEngine;

using UnityEngine.SceneManagement;

namespace KGA.DevelRocket
{
    [DisallowMultipleComponent]

    public sealed class TitleScene : MonoBehaviour
    {
        private void Update()
        {
            if (Input.anyKeyDown == true)
            {
                SceneManager.LoadScene("Main Scene");
            }
        }
    }
}