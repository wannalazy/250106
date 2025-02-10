using UnityEngine;

public class Practice_5_1_Selection : MonoBehaviour
{
    [SerializeField, Header("血量"), Range(1, 100)]
    private float hp = 100;

    private void Update()
    {
        switch (hp) 
        {
            case >= 80:
                Debug.Log("<color=#68f>血量安全</color>");
                break;
            case >= 60:
                Debug.Log("<color=#68f>健康狀況有問題</color>");
                break;
            case >= 40:
                Debug.Log("<color=#68f>警告，快喝水</color>");
                break;
            case >= 10:
                Debug.Log("<color=#68f>快死掉了</color>");
                break;
            case >= 0:
                Debug.Log("<color=#68f>已經死了</color>");
                break;
        }
    }
}
