using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentHealthAndName : MonoBehaviour
{
    public int Health = 3;
    public string Name;
    public bool Selected = false;
    public UIManagerScript UIMS;
    List<string> NamesList = new List<string>() { "James", "Napoleon", "Gaby", "Victoria", "Johny" };
    bool DamageWasTaken = false;
    void Start()
    {
        Name = NamesList[(int)Random.Range(0.0f, 5.0f)];//select name 
        UIMS = FindObjectOfType<UIManagerScript>();//get UIManagerScript from scene
    }

    void Update()
    {
        if (Selected == true && UIMS.NewWasSelected == true)// if this agent is selected and new was selected, then set selected and UIMS.NewWasSelected to false
        {
            Selected = false;
            UIMS.NewWasSelected = false;
        }
    }
    void TakeDamage()//function for taking damage and destroying object
    {
        if (Health > 0)
        {
            Health -= 1;
        }
        if (Health == 0) 
        {
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerEnter(Collider other)// when collision with other agent, deliver damage
    {
        if(other.CompareTag("Agent") == true && DamageWasTaken == false)
        {
            TakeDamage();
            DamageWasTaken = true;//to avoid dealing to much damage
        }
    }
    private void OnTriggerExit(Collider other)//when colision is over, set DamageWasTaken to false
    {
        if (other.CompareTag("Agent") == true && DamageWasTaken == true)
        {
            DamageWasTaken = false;
        }
    }

}
