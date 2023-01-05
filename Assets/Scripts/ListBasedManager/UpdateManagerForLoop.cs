using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListManager
{


    public class UpdateManagerForLoop : MonoBehaviour
    {
        List<ListUpdatedForLoop> listToUpdate = new List<ListUpdatedForLoop>();

        private void Awake()
        {
            UpdateTimer.OnAnyTestCompleted += delegate { listToUpdate = new List<ListUpdatedForLoop>(); };
        }

        public void AddUpdateItem(ListUpdatedForLoop listUpdated)
        {
            listToUpdate.Add(listUpdated);
        }
        
        void Update()
        {
            for(int i = 0; i < listToUpdate.Count; i++)
            {
                listToUpdate[i].MyUpdate();
            }
        }
    }
}