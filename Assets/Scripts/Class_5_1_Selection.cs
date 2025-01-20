using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

// 命名空間 : 
// 將類別分類，類似倉庫的概念，不同倉庫可以有相同名稱類別。
// 語法 : namespace 命名空間名稱 { 內容 } // Tab兩下
namespace WRX
{
    /// <summary>
    /// 選取陳述式 Selection Statement
    /// 1. if 判斷式
    /// 2. Switch 判斷式
    /// </summary>
    public class Class_5_1_Selection : MonoBehaviour
    {
        [SerializeField, Header("是否移動")]
        private bool isMove;
        [SerializeField, Header("通關門檻"),Range(0,50000)]
        private int score = 50000;

        private void Awake()
        {
            // if 判斷式
            // if (布林值) { 陳述式 }
            if (true)
            {
                Debug.Log("當布林值為 True，會執行這裡。");
            }

            // 快速完成 : 輸入 if 選取 if 陳述式按 Enter 或 Tab
            if (false)
            {
                Debug.Log("當布林值為 False，不會執行這裡而且會有綠蚯蚓。");
            }
        }

        // 更新事件 : 一秒鐘執行約 60 次 (60FPS) Frame Per Second
        private void Update()
        {
            Debug.Log("<color=#79f>60FPS更新中</color>");

            // 如果 isMove 布林值等於 True ，就顯示持續移動
            if (isMove)
            {
                Debug.Log("<color=#f93>持續移動</color>");
            }
            // 否則 isMove 布林值等於 False ，就顯示停止持動
            else
            {
                Debug.Log("<color=#f33>停止移動</color>");
            }

            // 比較運算子、邏輯運算子結果為布林值
            if (score >= 30000)
            {
                Debug.Log("<color=#3f3>關卡通關</color>");
            }
            else
            {
                Debug.Log("<color=#f33>關卡失敗</color>");
            }
        }
    }
}

