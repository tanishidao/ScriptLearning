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
            Dices[10] = Random.Range(1, 6);
         
        }
        DicesProbability = new int[6];

        DicesProbability[0] = Dices.Length / 10; //if Dices no 5 nokazu / 6
        DicesProbability[1] = Dices.Length; //if Dices no 5 nokazu / 6
        DicesProbability[2] = Dices.Length / 10; //if Dices no 5 nokazu / 6
        DicesProbability[3] = Dices.Length / 10; //if Dices no 5 nokazu / 6
        DicesProbability[4] = Dices.Length / 10; //if Dices no 5 nokazu / 6
        DicesProbability[5] = Dices.Length / 10; //if Dices no 5 nokazu / 6
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
