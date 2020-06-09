using UnityEngine;

//註解：用來說明、紀錄等…，只會在此腳本內看到
//摘要 summary:描述此內容，會在其他腳本內看到-提高維護性與擴充性
//新增的C#放在專案內為藍圖
//放在場景物件上為實體物件

/// <summary>
/// 定義汽車物件
/// </summary>
public class car : MonoBehaviour

{
    //認識第一個成員: 欄位field - 儲存物件資料
    //排氣量CC - 2000 -整數int
    //重量 - 100.9 -浮點數float
    //品牌 - BMW - 字串string
    //剎車 - 是否開啟 - 布林值bool

    //定義欄位語法:
    //修飾值 資料類型 欄位名稱;
    //公開 public:允許其他類別存取、顯示在屬性面板(Inspector)上
    //私人 private(預設):不允許其他類別存取、不顯示在屬性面板(Inspector)上
    
    //預設值：
    //int、float為0
    //string為""
    //bool為false
    //欄位屬性 Attribute:Unity 提供用於輔助欄位的功能
    // 語法:[屬性名稱(值)]
    // 標題[Header("字串")]
    //範圍[Range(最小值、最大值)]
    /// <summary>
    /// 汽車CC數
    /// </summary>
    [Header("汽車的CC數"),Range(500,5000)]
    public int cc = 2000;
    /// <summary>
    /// 重量
    /// </summary>
    [Tooltip("這個欄位是重量")]
    public float weight = 100.90f;
    /// <summary>
    /// 品牌
    /// </summary>
    [Header("品牌")]
    [Tooltip("車子的品牌")]
    public string brand = "BMW";
    [Header("剎車"),Tooltip("目前剎車狀態")]
    public bool brake = false;
    
}
