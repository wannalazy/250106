using UnityEngine;
using WRX.Tools;

namespace WRX.Class_15
{
    /// <summary>
    /// 介面物件 : 實作介面的物件
    /// </summary>
    public class Class_15_interfaceObject : MonoBehaviour
    {

    }

    // 介面的使用步驟
    // 1. 定義介面與介面成員
    // 2. 類別實作介面
    // 3. 實作介面的成員

    // 步驟1.
    // 帶有「使用」功能的介面，遊戲內可被使用的物品
    public interface IUse
    { 
        // 不用宣告方法主體，不用寫大括號
        public void Use();
    }

    public interface IDestroy
    {
        // 不用宣告方法主體，不用寫大括號
        public void Destroy();
    }

    // 步驟2.
    // C# 單一繼承，多重實作介面
    public class Weapon : IUse
    {
        // 步驟3.
        public void Use()
        {
            LogSystem.LogWithColor("使用武器，施展武器技能", "#fa3");
        }
    }

    public class Potion : IUse,IDestroy
    {
        public void Destroy()
        {
            LogSystem.LogWithColor("藥水使用完畢，刪除", "#f11");
        }

        public void Use()
        {
            LogSystem.LogWithColor("使用藥水，恢復血量", "#fa3");
        }
    }

    public class Chest : IUse, IDestroy
    {
        public void Destroy()
        {
            LogSystem.LogWithColor("寶箱使用完畢，刪除", "#f11");
        }

        public void Use()
        {
            LogSystem.LogWithColor("使用寶箱，獲得道具", "#fa3");
        }
    }
}

