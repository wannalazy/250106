using UnityEngine;

namespace WRX
{
    /// <summary>
    /// 反覆運算陳述式 : 迴圈
    /// for、foreach、do、while
    /// </summary>
    public class Class_6_1_Iteration : MonoBehaviour
    {
        private void Awake()
        {
            // 迴圈請在一次性事件內使用 Awake、Start
            // while 迴圈 : 當布林值為 true 時會持續執行
            // while (布林值) { 程式區塊 }
            // 無限迴圈 : 布林值一值是 true
            // 宣告區域變數 i 為 0
            int i = 0;
            i = 10;                 // 測試 while 與 do 的差異
            // 當 i < 5 就執行 {}
            while (i < 10) 
            {
                Debug.Log($"<color=#f33>while 迴圈，i : {i}<color>");
                // i 遞增 ( i + 1 )
                i++;
            }

            // do 迴圈 :
            // do { 程式區塊 } While (布林值)
            int j = 0;
            j = 10;                 // 測試 while 與 do 的差異
            do
            {
                Debug.Log($"<color=#f79>do 迴圈，j : {j}<color>");
                j++;
            }
            while (j < 10);

            // for 迴圈
            // for (初始值 ; 布林值 ; 迭代器 ) { 程式區塊 }
            for (int k = 0; k < 5; k++)
            {
                Debug.Log($"<color=#f78f>for 迴圈，k : {k}<color>");
            }
        }
    }
}


