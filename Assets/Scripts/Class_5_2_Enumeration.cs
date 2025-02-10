﻿using UnityEngine;

namespace WRX
{
    /// <summary>
    /// 列舉 : enumeration，C# 內關鍵字為簡寫 enum
    /// </summary>
    public class Class_5_2_Enumeration : MonoBehaviour
    {
        #region 認識列舉基本用法
        // 列舉 : 定義下拉選單的選項 (通常都是單選)
        // 語法 :
        // 修飾詞 關鍵字 enum 列舉名稱 { 列舉選項 }
        // 定義一個列舉，名稱叫做季節
        // 列舉都是數值，預設從 0 開始
        private enum Season
        {
            // 定義列舉選項
            Spring, Summer, Autumn, Winter
        }

        // 宣告變數，類型為季節列舉，預設為夏天
        [SerializeField, Header("季節")]
        private Season season = Season.Summer;

        private void Awake()
        {
            // 取得 列舉值 (Get) 抓出值
            Debug.Log(season);
            // 取得列舉值的整數值
            Debug.Log((int)season);

            // 設定 列舉值 (Set) 修改值
            season = Season.Winter;
            Debug.Log(season);
            // 透過數值設定列舉
            season = (Season)2;
            Debug.Log(season);
        }
        #endregion

        // 定義列舉數值
        /// <summary>
        /// 道具
        /// </summary>
        private enum Item
        {
            None = 0, Coin = 1, Redwater = 10, Bluewater = 15, Chicken = 20
        }

        [SerializeField, Header("道具")]
        private Item item = Item.Chicken;

        // 執行順序 : Awake > Start > Update
        // 開始事件 : 在喚醒事件後執行一次 (初始化)
        private void Start()
        {
            Debug.Log((int)item);

            // 列舉與判斷式 switch
            // switch +Tab * 2 > 修改 switch_on 為列舉 > Enter *2 快速完成
            switch (item)
            {
                case Item.None:
                    Debug.Log("沒有道具");
                    break;
                case Item.Coin:
                    Debug.Log("金幣");
                    break;
                case Item.Redwater:
                case Item.Bluewater:
                    Debug.Log("藥水道具");
                    break;
                case Item.Chicken:
                    Debug.Log("炸雞");
                    break;
                default:
                    Debug.Log("這不是道具");
                    break;
            }
        }
    }
}

