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

    public void AddResults(string testName,float initTime, float avgFPS, float AvgUpdateLenght)
    {
        Result newResult = new Result() {
            name = testName,
            initilizationTime = initTime,
            avarageFPS = avgFPS,
            avarageUpdateLenght = AvgUpdateLenght
        };
        results.Add(newResult);
      

    }

    }

[Serializable]
public struct Result
{
    public string name;
    public float initilizationTime;
    public float avarageFPS;
    public float avarageUpdateLenght;
}
