
using UnityEngine;

public class LearnMethod : MonoBehaviour
{
   //宣告方法
   //修飾詞 傳回類型 方法名稱(){陳述法、演算法}
   //private 只有此類別能使用此方法
   //public
   //void 無傳回
   //自訂方法：不會執行，需要呼叫

    private void Test()
    {
        print("測試方法");


    }

    private int Ten()
    {
        return 10;
    }

    private string Hi()

    {
        return ("嗨");
    }

    private void Drivemet(int sonic)
    {
        print("引擎聲音");
        print("排氣特效");
        print("開車，時數"+ sonic);
    }



    private void Shoot(int count , string property , string direction="前方")  
        //direction給他預設前方當作預設值  參數欄位只要有預設值的疑慮方在參數的最後尾
    {
        print("射箭數量:" + count );
        print("弓箭屬性:" + property );
        print("弓箭方向:" + direction );
    }

   private void Start()
    {
        Test();
        int a = Ten();
        print("有傳回方法:" + a);
        print("有傳回方法2:" + Ten());
        print("有傳回字串方法:" + Hi());

        Drivemet(99);
        Drivemet(288);

        Shoot(10, "冰凍");
        Shoot(10, "流彈","後排");//雖然預設值為前方但只要在傳回這有寫程式優先度>預設值
    }

    
}
