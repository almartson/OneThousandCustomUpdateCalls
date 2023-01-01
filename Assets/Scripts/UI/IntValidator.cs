using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class IntValidator : MonoBehaviour
{
    public void CheckInputForInt(TMP_InputField inputField)
    {
        
        if(!int.TryParse(inputField.text, out int value))
        {
            inputField.text = string.Empty;
        }
    }
}
