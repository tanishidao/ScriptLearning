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
        List<int> juhuku = new List<int>(10);
        List<int> Dices = new List<int>(10);
        TyohukuHante();
        Dice();

    }
    private void Update()
    {

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
        float OneCount = 0;
        float TwoCount = 0;
        float ThreeCount = 0;
        float FourCount = 0;
        float FiveCount = 0;
        float SixCount = 0;
        for (int i = 0; i < 10; i++)
        {
            Dices.Insert(i, Random.Range(1, 6));
            if (Dices[i] == 1)
            {
                OneCount += 0.1f;
            }
            if (Dices[i] == 2)
            {
                TwoCount+= 0.1f;
            }
            if (Dices[i] == 3)
            {
                ThreeCount+= 0.1f;
            }
            if (Dices[i] == 4)
            {
                FourCount+= 0.1f;
            }
            if (Dices[i] == 5)
            {
                FiveCount += 0.1f;
            }
            if (Dices[i] == 6)
            {
                SixCount += 0.1f;
            }
            if (i >= 9)
            {
                
            }
        }


        Debug.Log("1�̖ڂ�" + OneCount.ToString("P"));
        Debug.Log("2�̖ڂ�" + TwoCount.ToString("P"));
        Debug.Log("3�̖ڂ�" + ThreeCount.ToString("P"));
        Debug.Log("4�̖ڂ�" + FourCount.ToString("P"));
        Debug.Log("5�̖ڂ�" + FiveCount.ToString("P"));
        Debug.Log("6�̖ڂ�" + SixCount.ToString("P"));



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
