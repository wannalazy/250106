using UnityEngine;

/// <summary>
/// 練習 : 函式
/// </summary>
public class practice_4_Function : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log($"<color=#3f3>布林值 True : {ReturneTrue()}<color>");
        Debug.Log($"<color=#3f3>布林值 False : {ReturneFalse()}<color>");
    }

    /// <summary>
    /// 布林值 True
    /// </summary>
    /// <returns>True</returns>
    private bool ReturneTrue() 
    {
        return true;
    }

    /// <summary>
    /// 布林值 False
    /// </summary>
    /// <returns>True</returns>
    private bool ReturneFalse()
    {  
        return false;
    }
}
