//using NatSuite.Recorders;
//using NatSuite.Recorders.Clocks;
//using NatSuite.Recorders.Inputs;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
////using VoxelBusters.ReplayKit;


//class RecordInfo {

//    public RealtimeClock mClock;
//    public MP4Recorder mRecorder;
//    public CameraInput mCameraInput;
//}


//public class Record : MonoBehaviour
//{
//    // Start is called before the first frame update

//    //public Camera camera;
//    //public AudioSource m_microphoneSource;

//    public GameObject mBeginRecord;
//    public GameObject mStopRecord;


//    //AudioInput mAudioInput;

//    private static RecordInfo mRecordInfo;


//    private int m_sampleRate;
//    private int m_channelCount;

//    //private bool m_recordMicrophone = false;
//    void Start()
//    {
//        RefreshRecordState();
//    }

//    private void RefreshRecordState()
//    {
//        if (mStopRecord != null && mBeginRecord != null)
//        {
//            mStopRecord.SetActive(mRecordInfo  != null);
//            mBeginRecord.SetActive(mRecordInfo == null);


//        }
//    }

//    public void StartRecord()
//    {
     
//        mRecordInfo = new RecordInfo();
//        mRecordInfo.mClock = new RealtimeClock();
//        mRecordInfo.mRecorder = new MP4Recorder(1920, 1080, 60);//创建录制
//        mRecordInfo.mCameraInput = new CameraInput(mRecordInfo.mRecorder, mRecordInfo.mClock, Camera.main);//创建画面输入

//        RefreshRecordState();
//        //inRecordIns = this;
//        //DontDestroyOnLoad(this);
//        //if (m_recordMicrophone)
//        //{//是否录制麦克风

//        //    m_audioInput = new AudioInput(m_recorder, m_clock, m_microphoneSource, true);//创建声音输入
//        //    m_microphoneSource.mute = false;
//        //    StartCoroutine(StartMicrophone());

//        //    //m_microphoneSource.Play();//播放音源
//        //}


//    }
//    public async void StopRecord()
//    {
//        //if (m_recordMicrophone)
//        //{//是否录制麦克风
//        //    m_microphoneSource.mute = true;
//        //    m_microphoneSource.Stop();//停止音源
//        //    m_audioInput.Dispose();//声音输入停止
//        //}

//        mRecordInfo.mCameraInput.Dispose();//画面输入停止
//        string m_resultPath = await mRecordInfo.mRecorder.FinishWriting();//录制完成写入并保存
//        Debug.Log($"Saved recording to: {m_resultPath}");
//        mRecordInfo = null;
//        RefreshRecordState();
//        //Handheld.PlayFullScreenMovie($"file://{m_resultPath}");//回放
//    }

//    public void SaveRecord()
//    {
//    }


//    private void OnDestroy()
//    {
//        StopRecord();
//    }
//    //private void SvePreViewCall(string error)
//    //{

//    //}

//    //public IEnumerator StartMicrophone()
//    //{
//    //    m_microphoneSource.mute = m_microphoneSource.loop = m_recordMicrophone = true;
//    //    m_microphoneSource.bypassEffects = m_microphoneSource.bypassListenerEffects = false;
//    //    m_sampleRate = AudioSettings.outputSampleRate;
//    //    m_channelCount = (int)AudioSettings.speakerMode;
//    //    m_microphoneSource.clip = Microphone.Start(null, true, 10, AudioSettings.outputSampleRate);//开启麦克风
//    //    yield return new WaitUntil(() => Microphone.GetPosition(null) > 0);
//    //    m_microphoneSource.Play();
//    //}




//    public void ScreenShot()
//    {
//        DateTime dt = DateTime.Now;
        
//        ScreenCapture.CaptureScreenshot("Screenshot_"+ dt.ToString("yyyy_MM_dd HH_mm_ss_fff") + ".png");
//        //Application.CaptureScreenshot("Screenshot.png", 0);
//        //CaptureScreenshot(new Rect(0, 0, 1920, 1080));
//    }

//    //Texture2D CaptureScreenshot(Rect rect)
//    //{
//    //    // 先创建一个的空纹理，大小可根据实现需要来设置  
//    //    Texture2D screenShot = new Texture2D((int)rect.width, (int)rect.height, TextureFormat.RGB24, false);

//    //    // 读取屏幕像素信息并存储为纹理数据，  
//    //    screenShot.ReadPixels(rect, 0, 0);
//    //    screenShot.Apply();

//    //    // 然后将这些纹理数据，成一个png图片文件  
//    //    byte[] bytes = screenShot.EncodeToPNG();
//    //    string filename = Application.dataPath + "/Screenshot.png";
//    //    System.IO.File.WriteAllBytes(filename, bytes);
//    //    Debug.Log(string.Format("截屏了一张图片: {0}", filename));

//    //    // 最后，我返回这个Texture2d对象，这样我们直接，所这个截图图示在游戏中，当然这个根据自己的需求的。  
//    //    return screenShot;
//    //}
//}
