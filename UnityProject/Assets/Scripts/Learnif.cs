
using UnityEngine;

public class Learnif : MonoBehaviour
{

    public bool run;
    public int Combo;
    



    private void Start()
    {
        if (true)
        {
            print("HI~");
        }



        //布林值為 true 才會執行 if
        if (run)
        {
            print("跑步");
        }
        //布林值為 false 才會執行 else {}
        else
        {
            print("走路");
        }

        if (Combo>=150) 
        {
            print("攻擊x10");
        }
        else if (  Combo >= 100) 
        {
            print("攻擊x5");
        }
        else if( Combo>=50 )
        {
            print("攻擊x2");
        }


    }
}
