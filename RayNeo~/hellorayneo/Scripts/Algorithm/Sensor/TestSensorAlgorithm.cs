using RayNeo;
using RayNeo.Native;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestSensorAlgorithm : MonoBehaviour
{

    #region 数据定义

    [SerializeField]
    private Transform CompassRoot;
    [SerializeField]
    private Text      AzimuthTxt;

    #endregion

    #region 生命周期
   
    private void Update()
    {
        GetAzimuth();
    }

    #endregion

    #region 业务逻辑


    /// <summary>
    /// 偏航角变化
    /// </summary>
    private void GetAzimuth()
    {
        CompassRoot.localRotation = Quaternion.Euler(new Vector3(0, 0, FfalconApi.GetAzimuth()));
        //float Azimuth = InterfaceMgr.Instance.SensorRecMgr.GetAzimuth();
        //Debug.Log("[MercuryX2]:|" + Azimuth);
        //CompassRoot.localRotation = Quaternion.Euler(new Vector3(0, 0, -Azimuth));
        //AzimuthTxt.text = Azimuth.ToString();
    }

    #endregion
}
