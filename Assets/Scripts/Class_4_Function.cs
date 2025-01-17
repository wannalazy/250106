﻿using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

/// <summary>
/// 方法
/// 中文 : 方法、函式、函數、功能
/// 英文 : function、method (Unity)
/// </summary>
public class Class_4_Function : MonoBehaviour
{
    public void Awake()
    {
        #region 方法基本語法語參數呼叫
        // 呼叫方法 : 方法沒有呼叫不會執行
        // 方法名稱();
        FirstFunction();
        FirstFunction();
        // 呼叫有參數的方法 : 小括號內要放入引數
        // UseSkill(); //錯誤 : 少了引數
        UseSkill("迴天", 30);
        UseSkill("精準射擊", 50);
        // 呼叫有預設值參數的方法 : 可以不用填 (選填式參數)
        SpawnEnemy();
        SpawnEnemy("巴羅爾");
        Fire(700);
        Fire(800, "保齡球");
        // 有多格選擇性參數時的呼叫
        // 買紅水，50個
        BuyItem();
        // 買紅水，30個
        // BuyItem(30);  錯誤 : 30 會直接帶入到 item 參數導致資料類型不符合
        BuyItem(count: 30);
        // 買藍水，50個
        BuyItem("特級生命藥水");
        // 買藍水，30個
        BuyItem("藍水", 100);
        #endregion

        // 呼叫有傳回方法
        // 第一種 : 把結果放到區域變數內 
        int number9 = Square(9);
        Debug.Log($"<Color=#a33>9 的平方 {number9}<color>");
        // 第二種 : 把傳回方法當作該傳回類型使用
        Debug.Log($"<Color=#a33>7 的平方 {Square(7)}<color>");
        // 課堂練習(BMI)
        Debug.Log($"<Color=#a39>BMI {Bmi(60,1.6f)}<color>");
        Move();
        Move(50.5f);
    }

    // 框選要整理的程式 > Ctrl + K S > #region 快速完成程式碼片段
    #region 方法基本語法與參數
    // 方法 :
    // 包含一系列程式區塊
    // 方法與語法 : 
    // 修飾詞 傳回資料類型 方法名稱 (參數1，參數.....，參數n) { 程式區塊 }
    // 方法命名習慣 : Unity 習慣使用大寫開頭命名方法
    // void 無傳回 : 使用此方法不會有傳回資料
    private void FirstFunction()
    {
        Debug.Log("第一個方法");
    }

    // 參數語法 : 與區域變數相同 資料類型 參數名稱 (習慣用小寫或者加底線開頭)
    private void UseSkill(string skill, float cost)
    {
        Debug.Log($"<color=#f93>施放技能 : {skill}<color>");
        Debug.Log($"<color=#f93>技能消耗 : {cost}<color>");
    }

    private void SpawnEnemy(string enemy = "白鬼")
    {
        Debug.Log($"<color=#f33>生成敵人 : {enemy}<color>");
    }

    /// 沒有預設值稱為 : 必要參數，有預設值稱為選擇性參數
    /// 選擇性參數要寫在右邊
    ///private void Fire(string fire = "子彈", int speed)
    ///{
    ///   Debug.Log($"<color=#66f>發射物件 : {fire}，速度 : {speed}<color>");
    ///}

    /// <summary>
    /// 發射物件方法
    /// </summary>
    /// <param name="fire">發射物件</param
    /// <param name="speed">發射速度</param>
    private void Fire(int speed, string fire = "子彈")
    {
        Debug.Log($"<color=#66f>發射物件 : {fire}，速度 : {speed}<color>");
    }

    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="item">道具名稱</param
    /// <param name="count">道具數量</param>
    private void BuyItem(string item = "紅水", int count = 50)
    {
        Debug.Log($"<color=#3f3>購買商品 : {item}，數量 : {count}<color>");
    }
    #endregion

    #region 傳回
    // 傳回方法 : 傳回類型不是 void ， 呼叫該方法會獲得結果
    // 傳回方法必須在 {} 內使用 return 關鍵字將結果傳回
    /// <summary>
    /// 平方
    /// </summary>
    /// <param name="number">要平方的數字</param>
    /// <retrun>數字的平方</param>
    private int Square(int number)
    {
        return number * number;
    }

    /// <summary>
    /// BMI計算
    /// </summary>
    /// <param name="weight">體重</param>
    /// <param name="height">身高</param>
    private float Bmi(int weight, float height)
    {
        return weight / (height * height);
    } 
    #endregion

    // 名稱不能重複，類別、變數與方法
    private void Test() { }
    // private void Test() { }  // 名稱重複的錯誤

    // 方法多載 function overload
    // 參數的類型貨數量不同
    // 零個參數
    /// <summary>
    /// 移動
    /// </summary>
    private void Move() 
    {
        Debug.Log("<color=#19f>移動中</color>");
    }
    // 一個參數
    /// <summary>
    /// 移動方法並指定速度
    /// </summary>
    /// <param name="speed">移動速度</param>
    private void Move(float speed)
    {
        Debug.Log($"<color=#19f>移動中，速度 : {speed}</color>");
    }
}
