using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverManager
{
    public class UpdateManager : MonoBehaviour
    {
        public Action OnUpdate = delegate { };

        private void Update()
        {
            OnUpdate.Invoke();
        }
    }
}
