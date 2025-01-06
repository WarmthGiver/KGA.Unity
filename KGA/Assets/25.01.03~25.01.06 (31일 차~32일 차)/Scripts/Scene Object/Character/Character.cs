using UnityEngine;

namespace KGA.Day31
{
    public interface IDamageable
    {
        public void TakeDamage(int value);
    }

    [DisallowMultipleComponent]

    public abstract class Character : SceneObject, IDamageable
    {
        public int hp = 1;

        public void TakeDamage(int value)
        {
            hp -= value;

            if (hp <= 0)
            {
                hp = 0;

                Dead();
            }
        }
    }

    [DisallowMultipleComponent]

    public abstract class SceneObject : MonoBehaviour
    {
        public float speed = 0f;

        protected virtual void Update()
        {
            if (Stage1Scene.IsGameOver == true)
            {
                return;
            }

            Movement();
        }

        protected abstract void Movement();

        protected abstract void Dead();
    }
}