using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ClearAllChildren : MonoBehaviour
{
    public void DestroyAllChildren()
    {
        if (transform.childCount > 0)
        {
            var objectToDestroy = transform.GetChild(0).gameObject;
            if (objectToDestroy != null)
            {
                Destroy(objectToDestroy);
            }
        }
        /*
        var childern = GetComponentsInChildren<Transform>().ToList();

        childern.Remove(this.transform);
        foreach (var child in childern)
        {
                Destroy(child.gameObject);
        }
        */
    }
}
