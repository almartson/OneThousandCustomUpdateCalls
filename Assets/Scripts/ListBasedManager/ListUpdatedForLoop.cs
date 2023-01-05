using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListManager
{ 
    public class ListUpdatedForLoop : TestCase
    {
        [SerializeField] UpdateManagerForLoop manager;
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