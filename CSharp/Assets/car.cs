using UnityEngine;

//註解：用來說明、紀錄等…，只會在此腳本內看到
//摘要 summary:描述此內容，會在其他腳本內看到-提高維護性與擴充性
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
    //資料類型 欄位名稱;
   
    //預設值
    //int、float為0
    //string為""
    //bool為false
    int cc = 2000;
    float weight = 100.9f;
    string brand = "BMW";
    bool brake = false;

}
