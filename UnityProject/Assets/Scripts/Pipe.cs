




public class Pipe : Floor   //繼承  類別，可以享有地板所擁有的程式
{



    //掛腳本的物件要有Mesh Renderer
    //在所有攝影機看不到時執行一次
    //OB
    private void OnBecameInvisible()
    {
        Destroy(gameObject, 3f);
    }

    private void Start()
    {
        speed = 5f;
    }

    //在所有攝影機看到時執行一次
    //OBV
    private void OnBecameVisible()
    {
        
    }

}
