using UnityEngine;

public class practice_4_Function : MonoBehaviour
{
    private void Awake()
    {
        int atk = 50000, speed = 90;
        Debug.Log($"<Color=#a18>atk�O�_�j��speed? �ѵ� : {atk > speed}<color>");
        Debug.Log($"<Color=#a18>atk�O�_����speed? �ѵ� : {atk == speed}<color>");
    }
}
