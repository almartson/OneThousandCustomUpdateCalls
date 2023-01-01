using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListManager
{ 
    public class ListUpdated : TestCase
    {
        [SerializeField] UpdateManager manager;
        public int numberOfInvokes;
        public void MyUpdate()
        {
            numberOfInvokes++;
        }
        public override void Setup()
        {
            manager.AddUpdateItem(this);
        }
    }
}