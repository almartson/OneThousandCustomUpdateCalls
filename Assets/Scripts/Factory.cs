using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

namespace ObserverManager
{
    public class Factory : MonoBehaviour, ICreate
    {
        [SerializeField] TestCase ObjectToInstanciate;
        [SerializeField] int numberOfInstances;
        [SerializeField] Transform tragetTransform;
        FPSTimer timer;
        
        public void SpawnAmount(int amountToSpawn)
        {
            numberOfInstances = amountToSpawn;
            StatDisplay.Instance.ShowInitializingText();
            StartCoroutine(CreateInstances(ObjectToInstanciate, numberOfInstances));
        }
        IEnumerator CreateInstances(TestCase go, int amount)
        {
            yield return null;
            timer= new FPSTimer();
            var gobj = new GameObject("Parent");
            gobj.transform.parent = tragetTransform;
            timer.StartTimer();
            for (int i = 0; i < amount; i++)
            {
                var newGO = Instantiate(go, gobj.transform);
                newGO.Setup();
            }
            timer.Update();
            timer.StopTimer();
            var initTime = timer.GetLastFramesLenghtInMS();
            StatDisplay.Instance.SetInitializationTime(initTime.ToString());
            StatDisplay.Instance.ShowRunningText();
        }
    }
    public interface ICreate
    {
        void SpawnAmount(int amountToSpawn);
    }
}
