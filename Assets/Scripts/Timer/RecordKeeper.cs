using System;
using System.Collections.Generic;
using UnityEngine;


    public class RecordKeeper : MonoBehaviour
    {
        public static RecordKeeper Instance;
        private void Awake()
        {
            Instance = this;
        }

    [SerializeField] List<Result> results;

    public void AddResults(string testName,float initTime, float avgUpdTime)
    {
        Result newResult = new Result() {
            name= testName,
            initilizationTime =initTime,
            avarageUpdate = avgUpdTime
        };
        results.Add(newResult);
      

    }

    }

[Serializable]
public struct Result
{
    public string name;
    public float initilizationTime;
    public float avarageUpdate;
}
