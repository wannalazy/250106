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
        [SerializeField, Header("通關門檻"), Range(0, 50000)]
        private int score = 50000;

        [SerializeField, Header("武器")]
        private string weapon;

        [SerializeField, Header("血量"),Range(1,100)]
        private int hp = 100;



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
            // 常用快捷鍵
            // 1. 格式化 (排版) Ctrl + K D
            // 2. 程式碼片段 Ctrl + K S
            #region 判斷式 if
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
            // if 會在最上方、else 在最下方，中間可以有多個 else if
            // 如果 分數 >= 30000 就通關
            if (score >= 30000)
            {
                Debug.Log("<color=#3f3>關卡通關</color>");
            }
            // 否則 如果 分數 >= 25000 可以重新挑戰
            if (score >= 25000)
            {
                Debug.Log("<color=#f96>可重新挑戰</color>");
            }
            // 否則 如果 分數 >= 20000 可以重新挑戰，但要看廣告
            if (score >= 20000)
            {
                Debug.Log("<color=#f9a>看廣告後即可重新挑戰</color>");
            }
            // 否則 失敗
            else
            {
                Debug.Log("<color=#f33>關卡失敗</color>");
            }
            #endregion

            // switch 判斷式
            // switch (要判斷的值) { 陳述式 }
            // 快速完成 : switch + Tab * 2
            #region 判斷式 switch
            switch (weapon)
            {
                // case 值 :
                // 當判斷的值等於值時會執行這裡
                // break; 跳出判斷式
                // 如果武器等於小刀，攻擊力等於20
                // 卜拉哈跟蕾吉娜攻擊力一樣
                case "卜拉哈":
                case "蕾吉娜":
                    Debug.Log("<color=#ff3>攻擊力 : 10000</color>");
                    break;
                case "歐爾納":
                    Debug.Log("<color=#ff3>攻擊力 : 15000</color>");
                    break;
                case "兀恩雅":
                    Debug.Log("<color=#ff3>攻擊力 : 25000</color>");
                    break;

                default:
                    Debug.Log("<color=#f9a>武器錯誤</color>");
                    break;
            }
            #endregion

            #region 課堂練習判斷式
            // 題目 :
            // 如果 血量 >= 10 快死掉了
            // 如果 血量 >= 40 警告，快喝水
            // 如果 血量 >= 60 健康狀態有裝況
            // 如果 血量 >= 80 血量安全
            // 如果 血量 >= 0 你已經死了
            // 判斷式都算同一個判斷式，只會執行一個陳述式(結果)，並且由上往下
            // 所以當第一個陳述式條件達成，就不會往下執行

            // 錯誤寫法
            if (hp >= 10)
            {
                Debug.Log("<color=#f33>快死掉了</color>");
            }
            else if (hp >= 40)
            {
                Debug.Log("<color=#f33>警告，快喝水</color>");
            }
            else if (hp >= 60)
            {
                Debug.Log("<color=#f33>健康狀態有裝況</color>");
            }
            if (hp >= 80)
            {
                Debug.Log("<color=#f33>血量安全</color>");
            }
            else if (hp >= 0)
            {
                Debug.Log("<color=#f33>你已經死了</color>");
            }

            // 正確寫法一(由最先接觸條件寫)
            if (hp >= 80)
            {
                Debug.Log("<color=#f33>血量安全</color>");
            }
            else if (hp >= 60)
            {
                Debug.Log("<color=#f33>健康狀態有裝況</color>");
            }
            else if (hp >= 40)
            {
                Debug.Log("<color=#f33>警告，快喝水</color>");
            }
            else if (hp >= 10)
            {
                Debug.Log("<color=#f33>快死掉了</color>");
            }
            else if (hp >= 0)
            {
                Debug.Log("<color=#f33>你已經死了</color>");
            }

            // 正確寫法二(加上並且條件)
            if (hp >= 10 && hp < 40)
            {
                Debug.Log("<color=#f33>快死掉了</color>");
            }
            else if (hp >= 40 && hp < 60)
            {
                Debug.Log("<color=#f33>警告，快喝水</color>");
            }
            else if (hp >= 60 && hp < 80)
            {
                Debug.Log("<color=#f33>健康狀態有裝況</color>");
            }
            if (hp >= 80)
            {
                Debug.Log("<color=#f33>血量安全</color>");
            }
            else if (hp >= 0)
            {
                Debug.Log("<color=#f33>你已經死了</color>");
            } 
            #endregion
        }
    }
}

