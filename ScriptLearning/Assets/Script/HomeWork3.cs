using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class HomeWork3 : MonoBehaviour
{
    public List<int> juhuku = new List<int>();


    /// //////

    public List<int> Dices = new List<int>();

    int[] DicesProbability;
    void Start()
    {

        TyohukuHante();
        Dice();
        List<int> juhuku = new List<int>(10);
        List<int> Dices = new List<int>(10);
    }


    public void TyohukuHante()
    {
        int Count1 = 0;
        int Count2 = 0;
        int Count3 = 0;
        int Count4 = 0;
        int Count5 = 0;
        int Count6 = 0;
        int Count7 = 0;
        int Count8 = 0;
        int Count9 = 0;
        int Count10 = 0;
        for (int j = 0; j < 10; j++)
        {
            juhuku.Insert(j, Random.Range(1, 10));


            if (juhuku[j] == 1)
            {
                Count1++;
            }

            if (juhuku[j] == 2)
            {
                Count2++;
            }

            if (juhuku[j] == 3)
            {
                Count3++;
            }

            if (juhuku[j] == 4)
            {
                Count4++;
            }

            if (juhuku[j] == 5)
            {
                Count5++;
            }

            if (juhuku[j] == 6)
            {
                Count6++;
            }

            if (juhuku[j] == 7)
            {
                Count7++;
            }

            if (juhuku[j] == 8)
            {
                Count8++;
            }
            if (juhuku[j] == 9)
            {
                Count9++;
            }
            if (juhuku[j] == 10)
            {
                Count10++;
            }

        }
        for (int i = 0; i < 10; i++)
        {

        }
        Debug.Log(1 + "の数字は" + Count1 + "回でた");
        Debug.Log(2 + "の数字は" + Count2 + "回でた");
        Debug.Log(3 + "の数字は" + Count3 + "回でた");
        Debug.Log(4 + "の数字は" + Count4 + "回でた");
        Debug.Log(5 + "の数字は" + Count5 + "回でた");
        Debug.Log(6 + "の数字は" + Count6 + "回でた");
        Debug.Log(7 + "の数字は" + Count7 + "回でた");
        Debug.Log(8 + "の数字は" + Count8 + "回でた");
        Debug.Log(9 + "の数字は" + Count9 + "回でた");
        Debug.Log(10 + "の数字は" + Count10 + "回でた");


    }

    public void Dice()
    {
        int OneCount = 0;
        int TwoCount = 0;
        int ThreeCount = 0;
        int FourCount = 0;
        int FiveCount = 0;
        int SixCount = 0;
        for (int i = 0; i < 10; i++)
        {
            Dices.Insert(i, Random.Range(1, 6));
            if (Dices[i] == 1)
            {
                OneCount++;
            }
            if (Dices[i] == 2)
            {
                TwoCount++;
            }
            if (Dices[i] == 3)
            {
                ThreeCount++;
            }
            if (Dices[i] == 4)
            {
                FourCount++;
            }
            if (Dices[i] == 5)
            {
                FiveCount++;
            }
            if (Dices[i] == 6)
            {
                SixCount++;
            }
            
        }
        
        TwoCount = TwoCount / 10;
        ThreeCount = ThreeCount / 10;
        FourCount = FourCount / 10;
        FiveCount = FiveCount / 10;
        SixCount = SixCount / 10;

        Debug.Log("1の目は" + OneCount / 10);
        Debug.Log("2の目は" + TwoCount);
        Debug.Log("3の目は" + ThreeCount);
        Debug.Log("4の目は" + FourCount);
        Debug.Log("5の目は" + FiveCount);
        Debug.Log("6の目は" + SixCount);



    }
    void Notuse()
    {
        int[] array = new int[10];

        int NumCount = 0;

        for (int i = 0; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                if (array[i] == array[j])
                {
                    NumCount++;
                    Debug.Log(NumCount);
                }
            }
        }
    }
}
