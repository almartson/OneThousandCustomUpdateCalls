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

    public void AddResults(string testName,string initTime, float avgFPS, string AvgUpdateLenght)
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
    public string initilizationTime;
    public float avarageFPS;
    public string avarageUpdateLenght;
}
