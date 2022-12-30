using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverManager
{
    public class Factory : MonoBehaviour
    {
        [SerializeField] GameObject ObjectToInstanciate;
        [SerializeField] int numberOfInstances;
        void Awake()
        {
            CreateInstances(ObjectToInstanciate,numberOfInstances);
        }

        public void CreateInstances(GameObject go, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Instantiate(go);
            }
        }
    }
}