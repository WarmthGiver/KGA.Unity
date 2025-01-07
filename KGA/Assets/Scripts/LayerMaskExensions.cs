using UnityEngine;

namespace ZL
{
    public static partial class LayerMaskExensions
    {
        public static bool Belong(this LayerMask instance, Component component)
        {
            return Belong(instance, component.gameObject);
        }

        public static bool Belong(this LayerMask instance, GameObject gameObject)
        {
            return Belong(instance, gameObject.layer);
        }

        public static bool Belong(this LayerMask instance, int layer)
        {
            return (instance.value & (1 << layer)) > 0;
        }
    }
}