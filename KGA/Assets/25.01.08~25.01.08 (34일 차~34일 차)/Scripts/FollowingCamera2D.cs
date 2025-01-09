using UnityEngine;

namespace KGA.Day34
{
    [DisallowMultipleComponent]

    [RequireComponent(typeof(Camera))]

    public sealed class FollowingCamera2D : MonoBehaviour
    {
        [Space]

        [SerializeField]

        private Transform target = null;

        private void LateUpdate()
        {
            transform.position = (Vector2)target.position;
        }
    }
}