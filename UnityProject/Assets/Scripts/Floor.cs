
using UnityEngine;

public class Floor : MonoBehaviour
{
    //地板的速度

    [Header("地板移動速度")]
    [Range(0,9999f)]
    public float speed = 0.1f;

}
