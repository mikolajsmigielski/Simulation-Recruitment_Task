using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarcoPoloNumbers : MonoBehaviour
{
    
    public void NumbersAndMarcoDisplay()
    {
        for (int i = 1;i<= 100; i++)//create numbers from 1 to 100
        {
            Debug.Log(i);// display actual i number
            
            if (i % 3 == 0 && i % 5 != 0)
            {
                Debug.Log("Marco");//dsiplay "Marco" when the number is divisible by 3
            }
            if (i % 3 != 0 && i % 5 == 0)
            {
                Debug.Log("Polo");//dsiplay "Polo" when the number is divisible by 5
            }
            if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("Marco Polo");//dsiplay "Marco Polo" when the number is divisible by 3 and 5
            }
            
        }
    }
}
