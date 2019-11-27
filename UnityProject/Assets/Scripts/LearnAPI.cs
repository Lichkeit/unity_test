
using UnityEngine;

public class LearnAPI : MonoBehaviour
{

    private void Update()
    {

        //新增按鍵功能
        print(Input.GetKeyDown("mouse 0"));            //字串取得按鍵
        print(Input.GetKeyDown(KeyCode.Mouse1));       //列舉取的按鍵  比較推薦用這個

    }
}
