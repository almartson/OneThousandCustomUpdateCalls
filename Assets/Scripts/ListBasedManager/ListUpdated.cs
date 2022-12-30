using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListManager
{ 
    public class ListUpdated : MonoBehaviour
    {
        [SerializeField] UpdateManager manager;
        public int numberOfInvokes;
        public void MyUpdate()
        {
            numberOfInvokes++;
        }

        private void Start()
        {
            manager.AddUpdateItem(this);
        }
    }
}