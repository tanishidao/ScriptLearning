using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeWork4 : MonoBehaviour
{
    ///Q1
    int A;
    int B;
    int C;

    ///Q2
    private float HitPoint = 100f;
    private float MaxHp = 100f;
    private float Damage;
    private float HpBox;
    Image image;
    void Start()
    {

        ABC();
        ////Q2
        image = gameObject.GetComponent<Image>();
        Damage = Random.Range(1f, 10f);


    }

    // Update is called once per frame
    void Update()
    {


        /////Q2
        if (Input.GetKeyDown("space"))
        {
            if (HitPoint > 0)
            {
                HitPoint = HitPoint - Damage;
                HpBox = HitPoint;
            }

            float ShowHp = HitPoint / MaxHp;
            Debug.Log("残り" + ShowHp.ToString("P"));
        }
        image.fillAmount = HpBox / MaxHp;
    }

    void ABC()
    {
        int A = Random.Range(1, 10);
        int B = Random.Range(1, 10);
        int C = Random.Range(1, 10);
        if (A > B)
        {

            Debug.Log(B + "は" + A + "になるまで" + (A - B));

            if (A > C)
            {

                Debug.Log(C + "は" + A + "になるまで" + (A - C));
            }

        }
        if (B > A)
        {

            Debug.Log(A + "は" + B + "になるまで" + (B - A));
            if (B > C)
            {

                Debug.Log(C + "は" + B + "になるまで" + (B - C));
            }

        }
        if (C > A)
        {

            Debug.Log(A + "は" + C + "になるまで" + (C - A));
            if (C > B)
            {

                Debug.Log(B + "は" + C + "になるまで" + (C - B));
            }
        }

        if (A == B)
        {
            Debug.Log(A + "と" + B + "は同一");
            if (A > C)
            {

                Debug.Log(C + "は同一" + A + "になるまで" + (A - C));
            }
            else
            {

                Debug.Log(A + "同一は" + C + "になるまで" + (C - A));
            }
        }
        if (A == C)
        {
            Debug.Log(A + "と" + C + "は同一");
            if (A > B)
            {

                Debug.Log(C + "は同一" + A + "になるまで" + (A - B));
            }
            else
            {

                Debug.Log(A + "同一は" + B + "になるまで" + (B - A));
            }
        }
        if (C == B)
        {
            Debug.Log(C + "と" + B + "は同一");
            if (C > A)
            {

                Debug.Log(A + "は同一" + C + "になるまで" + (C - A));
            }
            else
            {
                
                Debug.Log(C + "同一は" + A + "になるまで" + (A - C));
            }
        }



    }
}
