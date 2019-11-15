
using UnityEngine;

public class APITwo : MonoBehaviour
{

    public Bird Chicken;   //Bird的C#   Chicken命名

    private void Start()
    {



        //取得Bird的C# 類別欄位
        //設定其他欄位
        //設定
        Chicken.jumpUp = 9527;


        //取得
        print("小雞的跳躍欄位:" + Chicken.jumpUp);
    }



}
