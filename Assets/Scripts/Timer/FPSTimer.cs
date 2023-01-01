using UnityEngine;
using System.Diagnostics;
using System.Collections;

public class FPSTimer
{
    private Stopwatch stopWatch;
    private long TicksSinceStart;
    private long numberOfUpdates;
    private long lastFrameTicks;
    private bool isRunning;
    private float startTime;

    public bool IsRunning => isRunning;

    public FPSTimer()
    {
        stopWatch = new Stopwatch();
        TicksSinceStart= 0;
        numberOfUpdates = 0;
        lastFrameTicks = 0;
        isRunning = false;
    }
    public void StartTimer()
    {
        isRunning = true;
        stopWatch.Start();
    }
    public void ResetTimer()
    {
        lastFrameTicks = 0;
        TicksSinceStart = 0;
        numberOfUpdates = 0;
        stopWatch.Reset();
        
    }
    public void StopTimer()
    {
        isRunning = false;
        stopWatch.Stop();
    }

    public void Update()
    {
        RecordFrameStats();
    }

    private void RecordFrameStats()
    {
        if (stopWatch.IsRunning)
        {
            stopWatch.Stop();
            numberOfUpdates++;
            lastFrameTicks = stopWatch.ElapsedTicks;
            TicksSinceStart += lastFrameTicks;
            stopWatch.Reset();
            stopWatch.Start();
        }
    }

    public float GetLastFramesLenghtInMS()
    {
        return (float)lastFrameTicks / Stopwatch.Frequency * 1000f;
    }
    public float GetAvarageFrameLenghtInMS()
    {
        return (float)(TicksSinceStart / numberOfUpdates) / Stopwatch.Frequency * 1000f;
    }
    public float GetLastFramePerSecond()
    {
        return 1.0f / GetLastFramesLenghtInMS();
    }
    public float GetAvarageFramePerSecond()
    {
        return 1.0f / (GetAvarageFrameLenghtInMS()*0.001f);
    }
}
