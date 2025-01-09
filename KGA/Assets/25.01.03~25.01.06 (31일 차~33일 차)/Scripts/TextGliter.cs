using UnityEngine;

using TMPro;

namespace KGA.Day31
{
    [DisallowMultipleComponent]

    public sealed class TextGliter : MonoBehaviour
    {
        public TMP_Text text;

        public float speed = 0.01f;

        private Color color;

        private float time = 0f;

        private void Start()
        {
            color = text.color;
        }

        private void Update()
        {
            time += speed;

            color.a = Mathf.PingPong(time, 1f);

            text.color = color;
        }
    }
}