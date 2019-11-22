
using UnityEngine;

public class LearnOperation : MonoBehaviour
{

    private int a = 10, b = 3;
    private int coin;
    private int supercoin;


    private void Start()
    {
        //數學運算運算
        #region
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);


        a = a + 1;   //=指定符號,右邊先運算
        print(a);

        print(a++);  //先輸出a在執行遞增   a+1=11     =  A
        print(++a);  //先執行遞增在輸出    (A+1)+1=13    =  B

        a = a + 10;                              //B+10=  23     =  C
        a += 10;       //  +=  -=  *=  /=        //C+10=  33
        print(a);
        #endregion



        //邏輯運算
        //需要兩個布林值
        #region

        //並且 &&
        // 只要有一個 false 結果為 false

        print(true && true);    // t
        print(true && false);   // f
        print(false && true);   // f
        print(false && false);  // f



        // 或者 ||
        //只要有一個 true 結果為 true


        print(true || true);    // t
        print(true || false);   // t
        print(false || true);   // t
        print(false || false);  // f



        #endregion



        //過關需要5個硬幣或3個超級硬幣
        print(coin >= 5 || supercoin >= 3);

        //過關需要5個硬幣跟3個超級硬幣
        print(coin >= 5 && supercoin >= 3);

    }

}
