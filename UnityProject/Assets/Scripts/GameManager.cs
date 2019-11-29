
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("分數")]
    public int score = 0;
    [Header("最高分數")]
    public int max_score ;

    [Header("水管群組")]
    public GameObject Pipe;    //GameObject  可以存場景上的物件也可以存專案內的預置物

    [Header("結束遊戲")]
    public GameObject goFinal;




    /// <summary>
    /// 要添加的分數，預設值為1
    /// </summary>
    public void AddScore(int add=1)
    {
        print("加分");
    }

    /// <summary>
    /// 設定最佳分數
    /// </summary>
    private void SetHeightScore()
    {

    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void GameOver()
    {
        goFinal.SetActive(true);

        CancelInvoke("SpawnPipe");//取消調用("方法名稱")
    }

    /// <summary>
    /// 生成水管
    /// </summary>
    private void SpawnPipe()
    {
        //三維向量=new  三維向量(x,y,z);

        Vector3 pos = new Vector3(6, Random.Range(-1.5f, 1f), 0);

        //Quaternion.identity  零角度
        //實俐化-生成(物件)
        Instantiate(Pipe, pos, Quaternion.identity);



        //Object.Instantiate(Pipe);  //實俐化-生成(物件)
    }

    private void Start()
    {
        //SpawnPipe();
        //延遲調用("方法名稱，延遲時間")
        //Invoke("SpawnPipe",1.5f);


        InvokeRepeating("SpawnPipe",0,1.5f);
        //延遲重複調用("方法名稱",延遲時間,重複頻率)

        



    }
}
