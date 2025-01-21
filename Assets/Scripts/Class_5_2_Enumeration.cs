using UnityEngine;

namespace WRX
{
    /// <summary>
    /// �C�| : enumeration�AC# ������r��²�g enum
    /// </summary>
    public class Class_5_2_Enumeration : MonoBehaviour
    {
        #region �{�ѦC�|�򥻥Ϊk
        // �C�| : �w�q�U�Կ�檺�ﶵ (�q�`���O���)
        // �y�k :
        // �׹��� ����r enum �C�|�W�� { �C�|�ﶵ }
        // �w�q�@�ӦC�|�A�W�٥s���u�`
        // �C�|���O�ƭȡA�w�]�q 0 �}�l
        private enum Season
        {
            // �w�q�C�|�ﶵ
            Spring, Summer, Autumn, Winter
        }

        // �ŧi�ܼơA�������u�`�C�|�A�w�]���L��
        [SerializeField, Header("�u�`")]
        private Season season = Season.Summer;

        private void Awake()
        {
            // ���o �C�|�� (Get) ��X��
            Debug.Log(season);
            // ���o�C�|�Ȫ���ƭ�
            Debug.Log((int)season);

            // �]�w �C�|�� (Set) �ק��
            season = Season.Winter;
            Debug.Log(season);
            // �z�L�ƭȳ]�w�C�|
            season = (Season)2;
            Debug.Log(season);
        }
        #endregion

        // �w�q�C�|�ƭ�
        /// <summary>
        /// �D��
        /// </summary>
        private enum Item
        {
            None = 0, Coin = 1, Redwater = 10, Bluewater = 10, Chicken = 20
        }

        [SerializeField, Header("�D��")]
        private Item item = Item.Chicken;

        // ���涶�� : Awake > Start > Update
        // �}�l�ƥ� : �b����ƥ�����@�� (��l��)
        private void Start()
        {
            Debug.Log((int)item);
        }
    }
}

