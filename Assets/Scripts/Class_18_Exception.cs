using System;
using UnityEngine;
using WRX.Tools;

namespace WRX.Class_18
{
    /// <summary>
    /// 例外處理
    /// </summary>
    public class Class_18 : MonoBehaviour
    {
        private void Awake()
        {
            LogSystem.LogWithColor($"{Division(8, 4)}", "#f33");
            LogSystem.LogWithColor($"{Division(3, 9)}", "#f33");
            LogSystem.LogWithColor($"{Division(7, 0)}", "#f33");

            LogSystem.LogWithColor($"{GetScores(0)}", "#3f3");
            LogSystem.LogWithColor($"{GetScores(4)}", "#3f3");
            LogSystem.LogWithColor($"{GetScores(9)}", "#3f3");

            SetEnemy();
        }

        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="numberA">分母</param>
        /// <param name="numberB">分子</param>
        /// <returns></returns>
        /// int? 允許傳回空值
        private int? Division(int numberA, int numberB)
        {
            // 可能發生例外的區域
            try
            {
                return numberA / numberB;   // 發生例外
            }
            // 捕捉到例外為「除以零」時會執行此區域
            catch (DivideByZeroException e)
            {
                // Message 官方的例外訊息
                LogSystem.LogWithColor($"分子不能為零 | {e.Message}", "#f99");
                return null;
            }
            // 最後區域
            finally
            {
                LogSystem.LogWithColor("例外處理完畢", "#f73");
            }
        }

        private int[] scores = { 70, 91, 94, 33, 88 };

        private int? GetScores(int index)
        {
            try
            {
                return scores[index];
            }
            catch (DivideByZeroException)
            {
                // Message 官方的例外訊息
                LogSystem.LogWithColor("發生例外", "#f11");
                return null;
            }
            catch (IndexOutOfRangeException e)
            {
                // Message 官方的例外訊息
                LogSystem.LogWithColor($"發生例外 | {e.Message}", "#f11");
                return null;
            }

        }

        [SerializeField]
        private GameObject enemy;

        private void SetEnemy()
        {
            try
            {
                enemy.SetActive(true);      // 顯示敵人物件
            }
            catch (Exception e)             // Exception 處理所有例外
            {
                LogSystem.LogWithColor($"發生例外 | {e.Message}", "#f39");
            }
        }
    }
}

