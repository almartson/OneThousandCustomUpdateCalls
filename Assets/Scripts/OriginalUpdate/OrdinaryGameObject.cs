using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OrdinaryGameObject : TestCase
{
    public int numberOfInvokes;

    public override void Setup()
    {
    }

    void Update()
    {
        numberOfInvokes++;
    }
}
