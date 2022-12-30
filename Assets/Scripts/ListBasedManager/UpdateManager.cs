using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListManager
{


    public class UpdateManager : MonoBehaviour
    {
        List<ListUpdated> listToUpdate;
        public void AddUpdateItem(ListUpdated listUpdated)
        {
            listToUpdate.Add(listUpdated);
        }
        private void Awake()
        {
            listToUpdate = new List<ListUpdated>();
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