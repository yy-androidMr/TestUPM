using FFalcon.XR.Runtime;
using UnityEngine;
//此处放置较为零碎的API
namespace RayNeo
{

    /// <summary>
    /// 获取当前Activity
    /// </summary>
    public static class AndroidActivity
    {
        private static AndroidJavaObject m_curAct;

        /// <summary>
        /// 获取当前运行的activity
        /// </summary>
        public static AndroidJavaObject CurActivity
        {
            get
            {
                if (m_curAct == null)
                {
                    AndroidJavaClass unityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                    m_curAct = unityClass.GetStatic<AndroidJavaObject>("currentActivity");
                }

                return m_curAct;
            }
        }
        /// <summary>
        /// 获取当前ApplicationContext
        /// </summary>

        public static AndroidJavaObject ApplicationContext
        {
            get
            {
                return CurActivity.Call<AndroidJavaObject>("getApplicationContext");
            }
        }


        public static void OpenSystemMonitoring(long value)
        {
            CurActivity.Call("openSystemMonitoring", value);
        }

        public static void CloseSystemMonitoring()
        {
            CurActivity.Call("openSystemMonitoring", -1);

        }


        /// <summary>
        /// 系统监控信息开启的枚举
        /// </summary>
        public class SystemMonitoringInfoType
        {

            //显示全部.
            public const long FULL = 0;

            //电流
            public const long ELECTRIC = 1 << 0;
            //平均电流
            public const long AVERAGE_ELECTRIC = 1 << 1;
            //当前电量
            public const long BATTERY_CAPACTIY = 1 << 2;

            //CPU热量
            public const long CPU_TEMPERATURE = 1 << 3;

            //CPU使用率
            public const long CPU_USAGE = 1 << 4;

            //内存使用
            public const long MEM_USAGE = 1 << 5;

            //当前顶层应用CPU使用
            public const long CUR_TOP_USAGE = 1 << 6;
        }
    }

    /// <summary>
    /// slam相关API
    /// </summary>
    public class SlamApi
    {
        /// <summary>
        /// 打开slam
        /// </summary>
        public static void EnableSlamHeadTracker()
        {
            Api.EnableSlamHeadTracker();
        }

        public static void DisableSlamHeadTracker()
        {
            Api.DisableSlamHeadTracker();
        }

        public static SlamState GetSlamStatus()
        {
            return (SlamState)Api.GetHeadTrackerStatus();
        }
        /// <summary>
        /// slam当前状态.
        /// </summary>
        public enum SlamState
        {
            //正在初始化
            FFVINS_INITIALIZING = 0,
            //初始化成功
            FFVINS_TRACKING_SUCCESS = 1,
            //失败
            FFVINS_TRACKING_FAIL = 2,
        }
    }

    public class FfalconApi
    {
        private const string MercuryDeviceName4010 = "QUALCOMM kona for arm64";
        private const string MercuryDeviceName4020_Proto2_2 = "QUALCOMM ARGT78";
        private static bool m_curAndroidDeviceInited = false;
        private static bool m_curAndroidDeviceIsMecury = false;
        private static float[] m_nineAxisNoientation = new float[4];
        /// <summary>
        /// 获取当前设备是否眼镜。
        /// </summary>
        /// <returns></returns>
        public static bool CurrentIsMecury()
        {
            if (m_curAndroidDeviceInited)
            {
                return m_curAndroidDeviceIsMecury;
            }
            m_curAndroidDeviceInited = true;
            if (SystemInfo.deviceModel.Equals(MercuryDeviceName4010) || SystemInfo.deviceModel.Equals(MercuryDeviceName4020_Proto2_2))
            {
                m_curAndroidDeviceIsMecury = true;
            }
            else if (SystemInfo.deviceModel.Contains("RayNeo"))
            {
                m_curAndroidDeviceIsMecury = true;
            }
            else
            {
                m_curAndroidDeviceIsMecury = false;
            }
            return m_curAndroidDeviceIsMecury;
        }

        /// <summary>
        /// 获取偏航角
        /// </summary>
        /// <returns></returns>
        public static float GetAzimuth()
        {
            return Api.FXRUnity_NineAxisAzimuth();
            //Api.GetNineAxisOrientation(m_nineAxisNoientation);
            //return new Quaternion(m_nineAxisNoientation[0], m_nineAxisNoientation[1], m_nineAxisNoientation[2], m_nineAxisNoientation[3]).eulerAngles.z;
        }
    }
}
