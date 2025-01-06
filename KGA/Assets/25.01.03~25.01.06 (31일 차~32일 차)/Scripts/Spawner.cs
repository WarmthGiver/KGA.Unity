using System.Collections.Generic;

using UnityEngine;

namespace KGA.Day31
{
    [DisallowMultipleComponent]

    public sealed class Spawner<T> : MonoBehaviour

        where T : MonoBehaviour
    {
        public T[] prefabs;

        private static Dictionary<string, T> prefabDictionary = new();

        private void Awake()
        {
            foreach (T prefab in prefabs)
            {
                prefabDictionary.Add(prefab.name, prefab);
            }
        }

        public static T Spawn(string name, Vector3 position)
        {
            return Spawn(name, position, Quaternion.identity);
        }

        public static T Spawn(string name, Vector3 position, Vector3 angle)
        {
            return Spawn(name, position, Quaternion.Euler(angle));
        }

        public static T Spawn(string name, Vector3 position, Quaternion rotation)
        {
            return Instantiate(prefabDictionary[name], position, rotation);
        }
    }
}