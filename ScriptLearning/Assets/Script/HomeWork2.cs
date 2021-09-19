using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeWork2 : MonoBehaviour
{   /// <summary>
   /// 1
   /// </summary>
    int Year = 5;


    /// <summary>
    /// 2
    /// </summary>
    int Sec = 50;
    int Min;
    int Hour;
    bool  EndRoop = true;


    private void Start()
    {
        SetTime();
        YearToMin();
    }


    void YearToMin()
    {


        Year = Year * 365 * 24 * 60 * 60;
        Debug.Log("Q1‚Í"+ Year + "•b‚È‚è‚Ü‚·");
    }

    void SetTime()
    {


        while (EndRoop)
        {

            if(Sec > 60)
            {
                Min++;
                Sec = Sec - 60;
                
            }
            if (Min >= 60)
            {
                Hour++;
                Min = Min - 60;
            }

            if (Hour >= 24)
            {
                Hour = Hour - 24;
            }
            if(Sec < 60)
            {
                EndRoop = false;
            }
            
       
        
        }
        Debug.Log("Q2‚Í"+ Hour + ":" + Min + ":" + Sec);
        

    }

    
}
