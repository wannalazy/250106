using UnityEngine;

/// <summary>
/// 課程 3 : 運算子
/// 補充 : Unity 欄位屬性、Unity 事件
/// </summary>
public class Class_3_Operator : MonoBehaviour
{
    // C# 變數 = 欄位 Field
    // 欄位屬性 Field Attrite
    // [標題(標題文字)]
    [Header("等級")]
    public int lv = 1;
    // [提示(提示文字)] : 在屬性面板滑鼠停留在變數上時顯示
    [Tooltip("這是角色的移動速度，不建議超過 100 。")]
    public float movespeed = 2.5f;
    // [範圍(最小，最大)] : 幫數值類型添加範圍 (面板上改為滑桿)
    [Range(0, 10)]
    public byte count = 10;
    // 範圍不能使用在非數值蕾型上，會顯示 "Use Range With..."
    [Range(0, 10)]
    public string weapon = "匕首";
    // [文字範圍(最小行，最大行)] : 使用在字串上，設定面板的文字框範圍
    [TextArea(2, 5)]
    public string itemDescription = "這裡是道具說明，這裡是道具說明，這裡是道具說明，";
}
