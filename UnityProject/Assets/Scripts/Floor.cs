
using UnityEngine;

public class Floor : MonoBehaviour
{
    //地板的速度

    [Header("地板移動速度")]
    [Range(0,10f)]
    public float speed = 0.1f;


    public Transform ground;   // Transform 為物件的方位.距離.SIZE   ground 宣告然為名稱(可以隨便打但不能打程式相關單字)


    private void Update()
    {
        Move();
    }

    /// <summary>
    /// 地板移動
    /// </summary>
    private void Move()
    {
        //time.deltatime 一個影格的時間(根據電腦效能不同)
        ground.Translate(-speed*Time.deltaTime ,0, 0);    // Translate代表位移 使用Transform API裡面的Translate來進行程式指令
        
    }

}
