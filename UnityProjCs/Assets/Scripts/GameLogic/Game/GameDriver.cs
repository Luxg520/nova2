using UnityEngine;
using System.Collections;
//using Swift;

public class GameDriver : MonoBehaviour
{
    public const int MaxFrameRate = 40;
    public const int MinFrameRate = 30;

    void Awake()
    {
        //设置目标帧率
        UnityEngine.Application.targetFrameRate = MinFrameRate;

#if UNITY_ANDROID
		Screen.SetResolution((int)(Screen.width * 0.8f), (int)(Screen.height * 0.8f), true);
#endif
        // NOVA-1740
        // Disable screen dimming
        //Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    void Start()
    {
        GameCore.Instance.Init();
    }

    void FixedUpdate()
    {
        //int te = (int)(Time.fixedDeltaTime * 1000);
        //GameCore.Instance.OnTimeElapsed(te);
    }
}
