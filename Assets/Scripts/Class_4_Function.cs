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
        #region ��k�򥻻y�k�y�ѼƩI�s
        // �I�s��k : ��k�S���I�s���|����
        // ��k�W��();
        FirstFunction();
        FirstFunction();
        // �I�s���Ѽƪ���k : �p�A�����n��J�޼�
        // UseSkill(); //���~ : �֤F�޼�
        UseSkill("�j��", 30);
        UseSkill("��Ǯg��", 50);
        // �I�s���w�]�ȰѼƪ���k : �i�H���ζ� (��񦡰Ѽ�)
        SpawnEnemy();
        SpawnEnemy("��ù��");
        Fire(700);
        Fire(800, "�O�ֲy");
        // ���h���ܩʰѼƮɪ��I�s
        // �R�����A50��
        BuyItem();
        // �R�����A30��
        // BuyItem(30);  ���~ : 30 �|�����a�J�� item �ѼƾɭP����������ŦX
        BuyItem(count: 30);
        // �R�Ť��A50��
        BuyItem("�S�ťͩR�Ĥ�");
        // �R�Ť��A30��
        BuyItem("�Ť�", 100);
        #endregion

        // �I�s���Ǧ^��k
        // �Ĥ@�� : �⵲�G���ϰ��ܼƤ� 
        int number9 = Square(9);
        Debug.Log($"<Color=#a33>9 ������ {number9}<color>");
        // �ĤG�� : ��Ǧ^��k��@�ӶǦ^�����ϥ�
        Debug.Log($"<Color=#a33>7 ������ {Square(7)}<color>");
        // �Ұ�m��(BMI)
        Debug.Log($"<Color=#a39>BMI {Bmi(60,1.6f)}<color>");
        Move();
        Move(50.5f);
    }

    // �ؿ�n��z���{�� > Ctrl + K S > #region �ֳt�����{���X���q
    #region ��k�򥻻y�k�P�Ѽ�
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
    private void UseSkill(string skill, float cost)
    {
        Debug.Log($"<color=#f93>�I��ޯ� : {skill}<color>");
        Debug.Log($"<color=#f93>�ޯ���� : {cost}<color>");
    }

    private void SpawnEnemy(string enemy = "�հ�")
    {
        Debug.Log($"<color=#f33>�ͦ��ĤH : {enemy}<color>");
    }

    /// �S���w�]�Ⱥ٬� : ���n�ѼơA���w�]�Ⱥ٬���ܩʰѼ�
    /// ��ܩʰѼƭn�g�b�k��
    ///private void Fire(string fire = "�l�u", int speed)
    ///{
    ///   Debug.Log($"<color=#66f>�o�g���� : {fire}�A�t�� : {speed}<color>");
    ///}

    /// <summary>
    /// �o�g�����k
    /// </summary>
    /// <param name="fire">�o�g����</param
    /// <param name="speed">�o�g�t��</param>
    private void Fire(int speed, string fire = "�l�u")
    {
        Debug.Log($"<color=#66f>�o�g���� : {fire}�A�t�� : {speed}<color>");
    }

    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="item">�D��W��</param
    /// <param name="count">�D��ƶq</param>
    private void BuyItem(string item = "����", int count = 50)
    {
        Debug.Log($"<color=#3f3>�ʶR�ӫ~ : {item}�A�ƶq : {count}<color>");
    }
    #endregion

    #region �Ǧ^
    // �Ǧ^��k : �Ǧ^�������O void �A �I�s�Ӥ�k�|��o���G
    // �Ǧ^��k�����b {} ���ϥ� return ����r�N���G�Ǧ^
    /// <summary>
    /// ����
    /// </summary>
    /// <param name="number">�n���誺�Ʀr</param>
    /// <retrun>�Ʀr������</param>
    private int Square(int number)
    {
        return number * number;
    }

    /// <summary>
    /// BMI�p��
    /// </summary>
    /// <param name="weight">�魫</param>
    /// <param name="height">����</param>
    private float Bmi(int weight, float height)
    {
        return weight / (height * height);
    } 
    #endregion

    // �W�٤��୫�ơA���O�B�ܼƻP��k
    private void Test() { }
    // private void Test() { }  // �W�٭��ƪ����~

    // ��k�h�� function overload
    // �Ѽƪ������f�ƶq���P
    // �s�ӰѼ�
    /// <summary>
    /// ����
    /// </summary>
    private void Move() 
    {
        Debug.Log("<color=#19f>���ʤ�</color>");
    }
    // �@�ӰѼ�
    /// <summary>
    /// ���ʤ�k�ë��w�t��
    /// </summary>
    /// <param name="speed">���ʳt��</param>
    private void Move(float speed)
    {
        Debug.Log($"<color=#19f>���ʤ��A�t�� : {speed}</color>");
    }
}
