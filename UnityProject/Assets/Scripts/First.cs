
using UnityEngine;

public class First : MonoBehaviour
{
    //程式內容  
    //宣告變數-定義欄位Field
    //欄位類型 欄位名稱 結束
    //私人   private
    //公開   public

    [Header("金幣")]
    [Range(0,99)]
    public int coin = 0;        //整數       錢

    [Header("速度")]
    [Range(0.1f, 2000f)]
    public float speed = 1.5f;    //浮點數     走路速度

    [Tooltip("小雞的顏色")]
    public string prop = "黃色";    //字串       文字


    public bool dead = true;      //布林值     是否死亡


    private void Start()
    {
        print("Hello~World");
    }

    private void Update()
    {
        print("HI~");
    }
}
