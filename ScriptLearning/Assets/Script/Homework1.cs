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

    public void CheckOddOrEven()//���������
    {
        Number = Random.Range(1, 100);

        if (Number % 2 == 1)//�]�肪�����
        {
            Debug.Log(Number + "���̐����͊�ł�");

        }
        if (Number % 2 == 0)//�]��Ȃ�
        {
            Debug.Log(Number + "���̐����͋����ł�");
        }


    }
    public void CheckUruuYears()//���邤�N���ʃ��\�b�h
    {
        Years = Random.Range(1873, 2021);//���{�ł�1873�N����̃X�^�[�g
        if (Years != 1900)//100�Ŋ���؂�āA�����400�Ŋ���؂�Ȃ��N�͕��N�Ȃ̂ŁA1900�N�͕��N
        {
            if (Years % 4 == 0)//��{�I�ɂS�N�Ɉ��̃X�p��
            {

                Debug.Log(Years + "�N�͂��邤�N");

            }

        }
        else
        {
            Debug.Log(Years + "�N�͂��邤�N�ł͂Ȃ�");
        }
    }

}
