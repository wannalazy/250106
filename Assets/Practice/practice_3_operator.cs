using System.Runtime.CompilerServices;
using UnityEngine;

public class practice_3_operator : MonoBehaviour
{
    private void Awake()
    {
        // 6 �� 2 (1 + 2)
        // �D�ذ��D
        // �����g�Ÿ�
        // �Υ����ٲ�
        // 1 �� 9
        int answer = 6 / 2 * (1 + 2);
        Debug.Log($"<color=#f33>6 / 2 * (1 + 2) = {answer}<color>");
    }
}
