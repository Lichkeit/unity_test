
using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度")]
    [Range(0, 9999)]
    public int jump ;

    [Header("是否死亡")]
    public bool dead ;
}
