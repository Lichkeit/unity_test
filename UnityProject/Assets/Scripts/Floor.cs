
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
        ground.Translate(-speed,0, 0);    // Translate代表位移 使用Transform API裡面的Translate來進行程式指令
        
    }
    
}
