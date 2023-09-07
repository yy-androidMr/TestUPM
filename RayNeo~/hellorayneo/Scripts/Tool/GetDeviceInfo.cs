using UnityEngine;

/// <summary>
/// ��ȡ�豸��Ϣ
/// </summary>
public class GetDeviceInfo : MonoBehaviour
{

    private void Start()
    {
        GetDeviceInformation();
    }

    private void GetDeviceInformation()
    {
       Debug.Log("[MercuryX2]:��ȡ�豸����ϸ��Ϣ");
       Debug.Log("[MercuryX2]:�豸ģ��:" + SystemInfo.deviceModel);
       Debug.Log("[MercuryX2]:�豸����:" + SystemInfo.deviceName);
       Debug.Log("[MercuryX2]:�豸����:" + SystemInfo.deviceType.ToString());
       Debug.Log("[MercuryX2]:�豸Ψһ��ʶ��:" + SystemInfo.deviceUniqueIdentifier);
       Debug.Log("[MercuryX2]:�Ƿ�֧��������:" + SystemInfo.copyTextureSupport.ToString());
       Debug.Log("[MercuryX2]:�Կ�ID:" + SystemInfo.graphicsDeviceID.ToString());
       Debug.Log("[MercuryX2]:�Կ�����:" + SystemInfo.graphicsDeviceName);
       Debug.Log("[MercuryX2]:�Կ�����:" + SystemInfo.graphicsDeviceType.ToString());
       Debug.Log("[MercuryX2]:�Կ���Ӧ��:" + SystemInfo.graphicsDeviceVendor);
       Debug.Log("[MercuryX2]:�Կ���Ӧ��ID:" + SystemInfo.graphicsDeviceVendorID.ToString());
       Debug.Log("[MercuryX2]:�Կ��汾��:" + SystemInfo.graphicsDeviceVersion);
       Debug.Log("[MercuryX2]:�Դ��С����λ��MB��:" + SystemInfo.graphicsMemorySize);
       Debug.Log("[MercuryX2]:�Կ��Ƿ�֧�ֶ��߳���Ⱦ:" + SystemInfo.graphicsMultiThreaded.ToString());
       Debug.Log("[MercuryX2]:֧�ֵ���ȾĿ������:" + SystemInfo.supportedRenderTargetCount.ToString());
       Debug.Log("[MercuryX2]:ϵͳ�ڴ��С(��λ��MB):" + SystemInfo.systemMemorySize.ToString());
       Debug.Log("[MercuryX2]:����ϵͳ:" + SystemInfo.operatingSystem);
    }

    private void OnGUI()
    {
        GUILayout.Space(10);
        GUILayout.Label("�豸����ϸ��Ϣ");
        GUILayout.Label("�豸ģ��:" + SystemInfo.deviceModel);
        GUILayout.Label("�豸����:" + SystemInfo.deviceName);
        GUILayout.Label("�豸����:" + SystemInfo.deviceType.ToString());
        GUILayout.Label("�豸Ψһ��ʶ��:" + SystemInfo.deviceUniqueIdentifier);
        GUILayout.Label("�Ƿ�֧��������:" + SystemInfo.copyTextureSupport.ToString());
        GUILayout.Label("�Կ�ID:" + SystemInfo.graphicsDeviceID.ToString());
        GUILayout.Label("�Կ�����:" + SystemInfo.graphicsDeviceName);
        GUILayout.Label("�Կ�����:" + SystemInfo.graphicsDeviceType.ToString());
        GUILayout.Label("�Կ���Ӧ��:" + SystemInfo.graphicsDeviceVendor);
        GUILayout.Label("�Կ���Ӧ��ID:" + SystemInfo.graphicsDeviceVendorID.ToString());
        GUILayout.Label("�Կ��汾��:" + SystemInfo.graphicsDeviceVersion);
        GUILayout.Label("�Դ��С����λ��MB��:" + SystemInfo.graphicsMemorySize);
        GUILayout.Label("�Կ��Ƿ�֧�ֶ��߳���Ⱦ:" + SystemInfo.graphicsMultiThreaded.ToString());
        GUILayout.Label("֧�ֵ���ȾĿ������:" + SystemInfo.supportedRenderTargetCount.ToString());
        GUILayout.Label("ϵͳ�ڴ��С(��λ��MB):" + SystemInfo.systemMemorySize.ToString());
        GUILayout.Label("����ϵͳ:" + SystemInfo.operatingSystem);
    }


}
