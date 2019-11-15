
using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度")]
    [Range(0.1f, 10f)]
    public float  jumpUp= 0.5f ;


    [Header("墜落速度")]
    [Range(-0.001f, -0.1f)]
    public float down = -0.01f;

    [Header("是否死亡")]
    public bool dead ;

    public Transform bird;


    private void Start()
    {
        
    }


    private void Update()
    {
        bird.Translate(0, down  , 0);
        
    }


    /// <summary>
    /// 小雞跳躍功能
    /// </summary>
    private void Jump()
    {

    }

    /// <summary>
    /// 小雞死亡功能
    /// </summary>
    private void Dead()
    {

    }
    
    /// <summary>
    /// 通過水管
    /// </summary>
    private void Passpipe()
    {

    }
}
