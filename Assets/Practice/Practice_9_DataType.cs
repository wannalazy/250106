using UnityEngine;
using WRX.Tools;

namespace WRX 
{
    /// <summary>
    /// 資料類型轉換
    /// </summary>
    public class Practice_9_DataType : MonoBehaviour
    {
        private void Awake()
        {
            float number = -999.321f;
            sbyte byteNumber = (sbyte)number;
            LogSystem.LogWithColor(byteNumber, "#6f6");
        }
    }
}

