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
        Debug.Log(1 + "�̐�����" + Count1 + "��ł�");
        Debug.Log(2 + "�̐�����" + Count2 + "��ł�");
        Debug.Log(3 + "�̐�����" + Count3 + "��ł�");
        Debug.Log(4 + "�̐�����" + Count4 + "��ł�");
        Debug.Log(5 + "�̐�����" + Count5 + "��ł�");
        Debug.Log(6 + "�̐�����" + Count6 + "��ł�");
        Debug.Log(7 + "�̐�����" + Count7 + "��ł�");
        Debug.Log(8 + "�̐�����" + Count8 + "��ł�");
        Debug.Log(9 + "�̐�����" + Count9 + "��ł�");
        Debug.Log(10 + "�̐�����" + Count10 + "��ł�");


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

        Debug.Log("1�̖ڂ�" + OneCount / 10);
        Debug.Log("2�̖ڂ�" + TwoCount);
        Debug.Log("3�̖ڂ�" + ThreeCount);
        Debug.Log("4�̖ڂ�" + FourCount);
        Debug.Log("5�̖ڂ�" + FiveCount);
        Debug.Log("6�̖ڂ�" + SixCount);



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
