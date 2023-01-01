using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListManager
{


    public class UpdateManager : MonoBehaviour
    {
       
        List<ListUpdated> listToUpdate = new List<ListUpdated>();

        private void Awake()
        {
            UpdateTimer.OnAnyTestCompleted += delegate { listToUpdate = new List<ListUpdated>(); };
        }

        public void AddUpdateItem(ListUpdated listUpdated)
        {
            listToUpdate.Add(listUpdated);
        }
        
        void Update()
        {
            foreach (var item in listToUpdate)
            {
                item.MyUpdate();
            }
        }
    }
}