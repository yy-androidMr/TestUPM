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
//        mRecordInfo.mRecorder = new MP4Recorder(1920, 1080, 60);//����¼��
//        mRecordInfo.mCameraInput = new CameraInput(mRecordInfo.mRecorder, mRecordInfo.mClock, Camera.main);//������������

//        RefreshRecordState();
//        //inRecordIns = this;
//        //DontDestroyOnLoad(this);
//        //if (m_recordMicrophone)
//        //{//�Ƿ�¼����˷�

//        //    m_audioInput = new AudioInput(m_recorder, m_clock, m_microphoneSource, true);//������������
//        //    m_microphoneSource.mute = false;
//        //    StartCoroutine(StartMicrophone());

//        //    //m_microphoneSource.Play();//������Դ
//        //}


//    }
//    public async void StopRecord()
//    {
//        //if (m_recordMicrophone)
//        //{//�Ƿ�¼����˷�
//        //    m_microphoneSource.mute = true;
//        //    m_microphoneSource.Stop();//ֹͣ��Դ
//        //    m_audioInput.Dispose();//��������ֹͣ
//        //}

//        mRecordInfo.mCameraInput.Dispose();//��������ֹͣ
//        string m_resultPath = await mRecordInfo.mRecorder.FinishWriting();//¼�����д�벢����
//        Debug.Log($"Saved recording to: {m_resultPath}");
//        mRecordInfo = null;
//        RefreshRecordState();
//        //Handheld.PlayFullScreenMovie($"file://{m_resultPath}");//�ط�
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
//    //    m_microphoneSource.clip = Microphone.Start(null, true, 10, AudioSettings.outputSampleRate);//������˷�
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
//    //    // �ȴ���һ���Ŀ�������С�ɸ���ʵ����Ҫ������  
//    //    Texture2D screenShot = new Texture2D((int)rect.width, (int)rect.height, TextureFormat.RGB24, false);

//    //    // ��ȡ��Ļ������Ϣ���洢Ϊ�������ݣ�  
//    //    screenShot.ReadPixels(rect, 0, 0);
//    //    screenShot.Apply();

//    //    // Ȼ����Щ�������ݣ���һ��pngͼƬ�ļ�  
//    //    byte[] bytes = screenShot.EncodeToPNG();
//    //    string filename = Application.dataPath + "/Screenshot.png";
//    //    System.IO.File.WriteAllBytes(filename, bytes);
//    //    Debug.Log(string.Format("������һ��ͼƬ: {0}", filename));

//    //    // ����ҷ������Texture2d������������ֱ�ӣ��������ͼͼʾ����Ϸ�У���Ȼ��������Լ�������ġ�  
//    //    return screenShot;
//    //}
//}
