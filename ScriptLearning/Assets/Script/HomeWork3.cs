using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class HomeWork3 : MonoBehaviour
{
    List<int> juhuku = new List<int>();
    int[] Dices;
    int[] DicesProbability;
    void Start()
    {

        TyohukuHante();
        Dice();
    }

    // Update is called once per frame
    void Update()
    {



    }
    public void TyohukuHante()
    {
        List<int> juhuku = new List<int>(Random.Range(1, 10));

        juhuku.Distinct().ToList(); //îÌÇ¡ÇΩÇÁè¡Ç∑

        Debug.Log(juhuku);
        Debug.Log(juhuku.Distinct().ToList()); //è¡ÇµÇΩÇÁï\é¶
    }

    public void Dice()
    {
        Dices = new int[10];
        DicesProbability = new int[6];
        int OneCount = 0;
        int TwoCount = 0;
        int ThreeCount = 0;
        int FourCount = 0;
        int FiveCount = 0;
        int SixCount = 0;
        for (int i = 0; i < 10; i++)
        {
            Dices[0] = Random.Range(1, 6);
            Dices[1] = Random.Range(1, 6);
            Dices[2] = Random.Range(1, 6);
            Dices[3] = Random.Range(1, 6);
            Dices[4] = Random.Range(1, 6);
            Dices[5] = Random.Range(1, 6);
            Dices[6] = Random.Range(1, 6);
            Dices[7] = Random.Range(1, 6);
            Dices[8] = Random.Range(1, 6);
            Dices[9] = Random.Range(1, 6);
           
         
        }
       

       
        if (Dices.Length == 1)
        {
            
            OneCount++;
        }
        if (Dices.Length == 2)
        {
            
            TwoCount++;
        }
        if (Dices.Length == 3)
        {
            
            ThreeCount++;
        }
        if (Dices.Length == 4)
        {
            
            FourCount++;
        }
        if (Dices.Length == 5)
        {
            
            FiveCount++;
        } if (Dices.Length == 6)
        {
            
            SixCount++;
        }
        DicesProbability[0] = OneCount / 10; //if Dices no 5 nokazu / 6
        DicesProbability[1] = TwoCount / 10;
        DicesProbability[2] = ThreeCount / 10;
        DicesProbability[3] = FourCount / 10;
        DicesProbability[4] = FiveCount / 10;
        DicesProbability[5] = SixCount / 10;
        Debug.Log(DicesProbability[0]);
        Debug.Log(DicesProbability[1]);
        Debug.Log(DicesProbability[2]);
        Debug.Log(DicesProbability[3]);
        Debug.Log(DicesProbability[4]);
        Debug.Log(DicesProbability[5]);

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
