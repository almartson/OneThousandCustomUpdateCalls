using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildDeactivator : MonoBehaviour
{
    public void DeactivateAllChildren()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            var child = transform.GetChild(i);
            child.gameObject.SetActive(false);
        }
    }
}
