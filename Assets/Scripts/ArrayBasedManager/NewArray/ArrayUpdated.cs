using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArrayBasedManager
{
    public class ArrayUpdated : TestCase
    {
        [SerializeField] UpdateManager manager;
        public int numberOfTicks;
        public override void Setup()
        {
            manager.AddToUpdateArray(this);
        }

        public void MyUpdate()
        {
            numberOfTicks++;
        }
    }
}