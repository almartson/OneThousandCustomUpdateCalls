using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearAllChildren : MonoBehaviour
{
    public void DestroyAllChildren()
    {
        while(transform.childCount > 0)
        {
            Destroy(transform.GetChild(0));
        }
    }
}
