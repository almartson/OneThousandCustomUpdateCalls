using UnityEngine;
using System.Diagnostics;
using System.Collections;

public class Counter : MonoBehaviour
{
    public float StartTime = 1f;

    private Stopwatch sp;
    private long total;
    private long num;
    private long last;
    private bool isRunning = false;

    private void Awake()
    {
        sp = new Stopwatch();
        StartCoroutine(log());
    }
    public void StartTimer()
    {
        isRunning= true;
        last = 0;
        total = 0;
        num = 0;
        ResetStopWatch();
    }
    public void StopTimer()
    {
        isRunning = false;
        sp.Stop();
    }

    public void Tick()
    {
        if (Time.time < StartTime && isRunning)
        {
            return;
        }

        RecordFrameStats();
        ResetStopWatch();
    }

    private void RecordFrameStats()
    {
        if (sp.IsRunning)
        {
            sp.Stop();
            num++;
            last = sp.ElapsedTicks;
            total += last;

        }
    }

    private void ResetStopWatch()
    {
        sp.Reset();
        sp.Start();
    }

    private IEnumerator log()
    {
        var delay = new WaitForSeconds(1f);
        while (true)
        {
            yield return delay;
            if (num > 0)
            {
                UnityEngine.Debug.Log(
                    "Last time: " + (float)last / Stopwatch.Frequency * 1000f + "ms. " +
                    "Average time: " + (float)(total / num) / Stopwatch.Frequency * 1000f + "ms.");
            }
        }
    }

}
