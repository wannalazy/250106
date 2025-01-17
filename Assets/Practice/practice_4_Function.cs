using UnityEngine;

public class practice_4_Function : MonoBehaviour
{
    private void Awake()
    {
        int atk = 50000, speed = 90;
        Debug.Log($"<Color=#a18>atk是否大於speed? 解答 : {atk > speed}<color>");
        Debug.Log($"<Color=#a18>atk是否等於speed? 解答 : {atk == speed}<color>");
    }
}
