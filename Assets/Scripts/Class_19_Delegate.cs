using UnityEngine;
using WRX.Tools;

namespace WRX.Class_19
{
    /// <summary>
    /// 委派
    /// </summary>
    public class Class_19_Delegate : MonoBehaviour
    {
        #region 複習可當參數的變數與元組
        private void Awake()
        {
            Cure(10);
            Card(("史萊姆", 7));
        }

        // 將 float 當作參數
        private void Cure(float cure)
        {
            LogSystem.LogWithColor($"治療的值 : {cure}", "#3f3");
        }

        // 將 元組 當作參數
        private void Card((string name, int index) card)
        {
            LogSystem.LogWithColor($"卡片 : {card.name} | {card.index}", "#3f3");
        }
        #endregion

        // 1. 宣告委派 : 簽章 (傳回與參數)
        // 宣告一個無傳回與無參數的委派
        private delegate void DelegateMethod();

        // 2. 目標方法 : 簽章必須與委派相同
        private void Test()
        {
            LogSystem.LogWithColor("測試", "#f3f");
        }

        private void Talk()
        {
            LogSystem.LogWithColor("嘿嘿嘿", "#f39");
        }

        private void MagicCard()
        {
            LogSystem.LogWithColor("反射傷害", "#3f3");
        }

        // 3. 宣告變數存放方法 (預設為空值)
        private DelegateMethod deledateMethod;

        // 4. 呼叫委派
        private void Start()
        {
            deledateMethod = Test;      // 將方法 Test 存放到變數 delegateMethod 內
            deledateMethod += Talk;     // 多種委派 : 一個委派存放多個方法，必須相同簽章
            deledateMethod += MagicCard;// 可添加多個方法
            deledateMethod -= Test;     // 也可刪除方法

            deledateMethod();           // 呼叫委派
        }
        // 委派 : 將方法當作參數
    }
}

