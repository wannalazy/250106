using TMPro.EditorUtilities;
using UnityEngine;

// 三條斜線是摘要 (XML 語言) 用來做簡短說明，可加在類別與變數上方
/// <summary>
/// 認識 C# 資料類型
/// </summary>
public class Class_2_Da : MonoBehaviour
{
    // 變數語法 :
    // 修飾詞 資料類型 變數名稱 指定 預設值;
    // 四大常用資料類型
    // 整  數 int : 儲存沒有小數點的數值  
    // 浮點數 float : 儲存有小數點的數值 
    // 字  串 string : 儲存文字，必須用雙引號
    // 布林值 bool : 儲存正與反，只有兩種值 true 與 false
    public int count = 7;
    public float moveSpeed = 3.5f;   // 浮點數字尾必須添加 f 後綴詞
    public float turnSpeed = 30.7F;  // 大小 f 皆可 
    public string charactor = "蓋倫";
    public bool isDead = false;      // 是否死亡 : 否 
    public bool gameover = true;     // 是否結束 : 是
}
