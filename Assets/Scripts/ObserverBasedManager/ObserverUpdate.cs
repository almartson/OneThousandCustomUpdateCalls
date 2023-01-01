using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverManager
{
    public class ObserverUpdate : TestCase
    {
        [SerializeField] UpdateManager manager;

        int numberOfUpdatesInvoked = 0;
        
        private void MyUpdate()
        {
            numberOfUpdatesInvoked++;
        }

        public override void Setup()
        {
            manager.OnUpdate += MyUpdate;
        }
        private void OnDestroy()
        {
            manager.OnUpdate-= MyUpdate;
        }
    }
}
