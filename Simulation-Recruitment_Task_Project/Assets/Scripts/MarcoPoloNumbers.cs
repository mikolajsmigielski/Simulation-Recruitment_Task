using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarcoPoloNumbers : MonoBehaviour
{
    
    public void NumbersAndMarcoDisplay()
    {
        for (int i = 1;i<= 100; i++)
        {
            Debug.Log(i);
            
            if (i % 3 == 0 && i % 5 != 0)
            {
                Debug.Log("Marco");
            }
            if (i % 3 != 0 && i % 5 == 0)
            {
                Debug.Log("Polo");
            }
            if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("Marco Polo");
            }
            
        }
    }
}
