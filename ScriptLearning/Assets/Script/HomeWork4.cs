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
            Debug.Log("�c��" + ShowHp.ToString("P"));
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

            Debug.Log(B + "��" + A + "�ɂȂ�܂�" + (A - B));

            if (A > C)
            {

                Debug.Log(C + "��" + A + "�ɂȂ�܂�" + (A - C));
            }

        }
        if (B > A)
        {

            Debug.Log(A + "��" + B + "�ɂȂ�܂�" + (B - A));
            if (B > C)
            {

                Debug.Log(C + "��" + B + "�ɂȂ�܂�" + (B - C));
            }

        }
        if (C > A)
        {

            Debug.Log(A + "��" + C + "�ɂȂ�܂�" + (C - A));
            if (C > B)
            {

                Debug.Log(B + "��" + C + "�ɂȂ�܂�" + (C - B));
            }
        }

        if (A == B)
        {
            Debug.Log(A + "��" + B + "�͓���");
            if (A > C)
            {

                Debug.Log(C + "�͓���" + A + "�ɂȂ�܂�" + (A - C));
            }
            else
            {

                Debug.Log(A + "�����" + C + "�ɂȂ�܂�" + (C - A));
            }
        }
        if (A == C)
        {
            Debug.Log(A + "��" + C + "�͓���");
            if (A > B)
            {

                Debug.Log(C + "�͓���" + A + "�ɂȂ�܂�" + (A - B));
            }
            else
            {

                Debug.Log(A + "�����" + B + "�ɂȂ�܂�" + (B - A));
            }
        }
        if (C == B)
        {
            Debug.Log(C + "��" + B + "�͓���");
            if (C > A)
            {

                Debug.Log(A + "�͓���" + C + "�ɂȂ�܂�" + (C - A));
            }
            else
            {
                
                Debug.Log(C + "�����" + A + "�ɂȂ�܂�" + (A - C));
            }
        }



    }
}
