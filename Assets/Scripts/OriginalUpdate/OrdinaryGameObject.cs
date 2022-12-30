using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OrdinaryGameObject : MonoBehaviour
{
    public int numberOfInvokes;
    void Update()
    {
        numberOfInvokes++;
    }
}
