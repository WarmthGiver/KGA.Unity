using UnityEngine;

namespace KGA.Day30
{
    [DisallowMultipleComponent]

    public sealed class MoveForward : MonoBehaviour
    {
        private void Start()
        {

        }

        private void Update()
        {
            transform.Translate(Vector3.forward);
        }
    }
}