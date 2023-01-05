using System;
using TMPro;
using UnityEngine;

namespace ArrayBasedManager
{
    public class UpdateManager : MonoBehaviour
    {
        ArrayUpdated[] UpdateList;
        [SerializeField] TMP_InputField amountInputField;
        [SerializeField] BoolValue ready;
        int currentIndex = 0;
        
        
        private void OnEnable()
        {
            UpdateList= new ArrayUpdated[int.Parse(amountInputField.text)];
            ready.value = true;
        }
        private void OnDisable()
        {
            ready.value = false;
            currentIndex= 0;
        }

        public void AddToUpdateArray(ArrayUpdated arrayUpdated)
        {
            UpdateList[currentIndex] = arrayUpdated;
            currentIndex++;
        }


        private void Update()
        {
            for (int i = 0; i < currentIndex-1; i++)
            {
                UpdateList[i].MyUpdate();
            }
        }
    }
}
