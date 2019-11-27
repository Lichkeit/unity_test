
using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度")]
    [Range(50, 1000)]
    public int  jumpUp= 200 ;




    [Header("選轉角度")]
    [Range(1, 360)]
    public int angle = 10;

    [Header("是否死亡")]
    public bool isdead ;

    public Transform bird;


    public GameObject goScore, goGM;  //可以用，來區隔

    //2D鋼體
    public Rigidbody2D rg2D;


    //碰撞事件
    //Enter  碰到物件時觸發事件
    //Exit   離開物間時觸發事件
    //Stay   站在物件時每秒觸發60次
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //print(collision.gameObject.name);
        //碰撞,遊戲物件,碰撞的名稱

        Dead();
    }

    //觸發事件
    //物件觸發開始執行-針對有勾選Trigger的物件
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Dead();
    }

    private void Start()
    {
       
    }


    private void Update()
    {
        Jump();//每60偵測玩家是否按了Jump的按鍵
       
    }


    /// <summary>
    /// 小雞跳躍功能
    /// </summary>
    private void Jump()
    {

        if (isdead) return;
        

        if (Input.GetKeyDown(KeyCode.Mouse0)) //當滑鼠按下左鍵時啟動
        {
            goScore.SetActive(true);//  打開/關閉  MOD
            goGM.SetActive(true);

            //重設所有物理資料  PS要放在最前面不然會一直reast
            rg2D.Sleep();
            
            
            //2D鋼體地心引力
            rg2D.gravityScale = 1;
            
            //2D鋼體.推力(二維向量)
            rg2D.AddForce(new Vector2(0,jumpUp ));

            

            
        }

        //選轉的角度
        //rg2D.SetRotation(30);
        
        //進階選轉角度+前滾動
        rg2D.SetRotation(angle*rg2D.velocity.y);//只要y不要x
    }

    /// <summary>
    /// 小雞死亡功能
    /// </summary>
    private void Dead()
    {
        isdead = true;
    }
    
    /// <summary>
    /// 通過水管
    /// </summary>
    private void Passpipe()
    {

    }
}
