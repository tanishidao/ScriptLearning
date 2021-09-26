using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeWork4 : MonoBehaviour
{
    private float HitPoint = 100f;
    private float MaxHp = 100f;
   private float Damage ;
    private float HpBox;
    Image image;
    void Start()
    {
        image = gameObject.GetComponent<Image>();
        Damage = Random.Range(1f, 10f);

      
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown("space"))
        {
            if (HitPoint > 0)
            {
                HitPoint = HitPoint - Damage;
                HpBox = HitPoint;
            }

            float ShowHp = HitPoint / MaxHp;
            Debug.Log("Žc‚è"+ ShowHp.ToString("P"));
        }
        image.fillAmount = HpBox /MaxHp;
    }
}
