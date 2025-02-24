﻿using UnityEngine;
using WRX.Tools;

namespace WRX
{
    /// <summary>
    /// 抽象
    /// </summary>
    public class Class_11_Abstract : MonoBehaviour
    {
        private void Awake()
        {
            // 抽象類別 : 
            // 1. 必須使用關鍵字 abstract
            // 2. 不能被實例化 (new)
            // 3. 如果有抽象方法成員，不需要主體 (大括號)
            // 4. 抽象成員必須被子類別實作 (override)
            var flyDragon = new FlyDragon();
            var threeHornDragon = new ThreeHornDragon();

            // var monster = new Monster();         // 錯誤  : 無法實例化

            flyDragon.Attack();
            threeHornDragon.Attack();

            // 向上轉型 Upcasting : 實例化後存放到父類別
            // 向上轉型可以使用多型
            Monster fly = new FlyDragon();
            fly.Track();

            FlyDragon fly2 = new FlyDragon();
            fly2.Track();
            fly2.Track(100);
            
            var fly3 = new FlyDragon();
            fly3.Track();
            fly3.Track(150);
        }
    }

    // abstract 抽象類別
    public abstract class Monster
    {
        public float hp;
        public float movespeed;

        // 抽象方法不需要主體 (大括號{})
        public abstract void Attack();

        public void Track()
        {
            LogSystem.LogWithColor("追蹤", "#f93");
        }
    }

    public class FlyDragon : Monster
    {
        public override void Attack()
        {
            LogSystem.LogWithColor("龍息", "#f77");
        }

        public void Track(int speed)
        {
            LogSystem.LogWithColor($"追蹤，速度 : {speed}", "#f93");
        }
    }

    public class ThreeHornDragon : Monster
    {
        public override void Attack()
        {
            LogSystem.LogWithColor("衝撞", "#7f7");
        }
    }
}

