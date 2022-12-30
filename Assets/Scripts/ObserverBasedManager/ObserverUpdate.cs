using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverManager
{
    public class ObserverUpdate : MonoBehaviour
    {
        [SerializeField] UpdateManager manager;

        int numberOfUpdatesInvoked = 0;
        private void Start()
        {
            manager.OnUpdate += MyUpdate;
        }

        private void MyUpdate()
        {
            numberOfUpdatesInvoked++;
        }
    }
}