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
            Debug.Log("Žc‚è" + ShowHp.ToString("P"));
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

            Debug.Log(B + "‚Í" + A + "‚É‚È‚é‚Ü‚Å" + (A - B));

            if (A > C)
            {

                Debug.Log(C + "‚Í" + A + "‚É‚È‚é‚Ü‚Å" + (A - C));
            }

        }
        if (B > A)
        {

            Debug.Log(A + "‚Í" + B + "‚É‚È‚é‚Ü‚Å" + (B - A));
            if (B > C)
            {

                Debug.Log(C + "‚Í" + B + "‚É‚È‚é‚Ü‚Å" + (B - C));
            }

        }
        if (C > A)
        {

            Debug.Log(A + "‚Í" + C + "‚É‚È‚é‚Ü‚Å" + (C - A));
            if (C > B)
            {

                Debug.Log(B + "‚Í" + C + "‚É‚È‚é‚Ü‚Å" + (C - B));
            }
        }

        if (A == B)
        {
            Debug.Log(A + "‚Æ" + B + "‚Í“¯ˆê");
            if (A > C)
            {

                Debug.Log(C + "‚Í“¯ˆê" + A + "‚É‚È‚é‚Ü‚Å" + (A - C));
            }
            else
            {

                Debug.Log(A + "“¯ˆê‚Í" + C + "‚É‚È‚é‚Ü‚Å" + (C - A));
            }
        }
        if (A == C)
        {
            Debug.Log(A + "‚Æ" + C + "‚Í“¯ˆê");
            if (A > B)
            {

                Debug.Log(C + "‚Í“¯ˆê" + A + "‚É‚È‚é‚Ü‚Å" + (A - B));
            }
            else
            {

                Debug.Log(A + "“¯ˆê‚Í" + B + "‚É‚È‚é‚Ü‚Å" + (B - A));
            }
        }
        if (C == B)
        {
            Debug.Log(C + "‚Æ" + B + "‚Í“¯ˆê");
            if (C > A)
            {

                Debug.Log(A + "‚Í“¯ˆê" + C + "‚É‚È‚é‚Ü‚Å" + (C - A));
            }
            else
            {
                
                Debug.Log(C + "“¯ˆê‚Í" + A + "‚É‚È‚é‚Ü‚Å" + (A - C));
            }
        }



    }
}
