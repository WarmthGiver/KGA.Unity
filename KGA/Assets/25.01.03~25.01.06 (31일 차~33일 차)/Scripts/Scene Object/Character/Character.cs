using UnityEngine;

using ZL;

namespace KGA.Day31
{
    public abstract class Character : SceneObject, IHittable
    {
        [SerializeField]

        private int hp = 0;

        public int HP => hp;

        [SerializeField]

        private LayerMask hitterLayers;

        public LayerMask HitterLayers => hitterLayers;

        public virtual void TakeHit(int value)
        {
            hp -= value;

            if (hp <= 0)
            {
                hp = 0;

                Dead();
            }
        }
    }
}