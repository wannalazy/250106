using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

/// <summary>
/// ��k
/// ���� : ��k�B�禡�B��ơB�\��
/// �^�� : function�Bmethod (Unity)
/// </summary>
public class Class_4_Function : MonoBehaviour
{
    public void Awake()
    {
        // �I�s��k : ��k�S���I�s���|����
        // ��k�W��();
        FirstFunction();
        FirstFunction();
        // �I�s���Ѽƪ���k : �p�A�����n��J�޼�
        // UseSkill(); //���~ : �֤F�޼�
        UseSkill("���y�N");
        UseSkill("�B�@");
    }

    // ��k :
    // �]�t�@�t�C�{���϶�
    // ��k�P�y�k : 
    // �׹��� �Ǧ^������� ��k�W�� (�Ѽ�1�A�Ѽ�.....�A�Ѽ�n) { �{���϶� }
    // ��k�R�W�ߺD : Unity �ߺD�ϥΤj�g�}�Y�R�W��k
    // void �L�Ǧ^ : �ϥΦ���k���|���Ǧ^���
    private void FirstFunction()
    {
        Debug.Log("�Ĥ@�Ӥ�k");
    }

    // �Ѽƻy�k : �P�ϰ��ܼƬۦP ������� �ѼƦW�� (�ߺD�Τp�g�Ϊ̥[���u�}�Y)
    private void UseSkill(string skill) 
    {
        Debug.Log($"<color=#f93>�I��ޯ� : {skill}<color>");
    }
}
