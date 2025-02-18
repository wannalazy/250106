using WRX.Tools;
using UnityEngine;
// 資料的型別
//    型別     | 參考型別 | 實值型別
// 記憶體位置   | Heap堆  | Stack棧
//    資料     |    類別  |結構
// 資料傳遞方式 |  傳址    |  傳值


namespace WRX 
{
    /// <summary>
    /// 類別與結構的差異
    /// </summary>
    public class Class_8_3_ClassAndStruct : MonoBehaviour
    {
        private void Awake()
        {
            // 3.空值 : 類別可以空值，結構不行
            Class_8_3_Class class1 = new Class_8_3_Class();     // 有實例化
            Class_8_3_Class class2 = null;                      // 空值，null就是空值的意思

            Class_8_3_struct struct1 = new Class_8_3_struct();  // 有實例化
           // Class_8_3_struct struct2 = null;                 // 空值，會有錯誤

            LogSystem.LogWithColor(class1.ToString(), "#f96");
            // LogSystem.LogWithColor(class2.ToString(),"#f96");
            LogSystem.LogWithColor(struct1.ToString(), "#f96");
            // LogSystem.LogWithColor(struct2.ToString(),"#f96");
        }

        private void Start()
        {
            // var 不指定類型，可以儲存所有資料
            var textClass = new Class_8_4_Class("我是類別");
            var textstruct = new Class_8_4_Struct("我是結構");

            var textClass2 = new Class_8_4_Class("我是類別2");
            var textstruct2 = new Class_8_4_Struct("我是結構2");

            LogSystem.LogWithColor(textClass.name, "#79f");
            LogSystem.LogWithColor(textClass2.name, "#79f");
            LogSystem.LogWithColor(textstruct.name, "#79f");
            LogSystem.LogWithColor(textstruct2.name, "#79f");

            textClass2 = textClass;   // 傳址 : 這時候的 class 與 class2 指向同一個地址
            textstruct2 = textstruct; // 傳值 : 這時候的 struct 與 struct2 指向同一個值

            // 修改 class 或 class2 資料都會同步
            textClass.name = "類別";
            LogSystem.LogWithColor(textClass.name, "#f79");
            LogSystem.LogWithColor(textClass2.name, "#f79");
            // 修改 struct 或 struct2 資料不會同步
            textstruct.name = "結構";
            LogSystem.LogWithColor(textstruct.name, "#f79");
            LogSystem.LogWithColor(textstruct2.name, "#f79");
        }

    }

    // 類別 : 
    // 1. 繼承 : 允許繼承
    // 2. 建構子 : 可以有多個建構子
    public class Class_8_3_Class : MonoBehaviour
    {
        public Class_8_3_Class()
        { 

        }

        public Class_8_3_Class(int test)
        {

        }
    }

    // 結構 : 
    // 1. 結構 : 不允許繼承
    // 2. 建構子 : 不能有無參數建構子
    public struct Class_8_3_struct
    {
        // public Class_8_3_struct()
        // {

        // }

        public Class_8_3_struct(int test) 
        { 

        }
    }
}

