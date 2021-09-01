using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework1 : MonoBehaviour
{
    public int Number;

    public int Years;

    
    // Start is called before the first frame update
    void Start()
    {
        CheckOddOrEven();
        CheckUruuYears();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void CheckOddOrEven()//奇数か偶数か
    {
        Number = Random.Range(1, 100);

        if (Number % 2 == 1)//余りがあると
        {
            Debug.Log(Number + "この数字は奇数です");

        }
        if (Number % 2 == 0)//余りなし
        {
            Debug.Log(Number + "この数字は偶数です");
        }


    }
    public void CheckUruuYears()//うるう年判別メソッド
    {
        Years = Random.Range(1873, 2021);//日本では1873年からのスタート
        if (Years != 1900)//100で割り切れて、さらに400で割り切れない年は平年なので、1900年は平年
        {
            if (Years % 4 == 0)//基本的に４年に一回のスパン
            {

                Debug.Log(Years + "年はうるう年");

            }

        }
        else
        {
            Debug.Log(Years + "年はうるう年ではない");
        }
    }

}
