using UnityEngine;

namespace KGA.Day31
{
    [DisallowMultipleComponent]

    public abstract class SceneObject : MonoBehaviour
    {
        public float speed = 1f;

        protected virtual void Update()
        {
            if (Stage1Scene.IsGameOver == true)
            {
                return;
            }

            Movement();
        }

        public virtual void Initialize(SceneObjectInfo info)
        {
            speed = info.speed;
        }

        protected abstract void Movement();

        protected abstract void Dead();
    }

    public abstract class SceneObjectInfo
    {
        public float speed = 1f;
    }
}