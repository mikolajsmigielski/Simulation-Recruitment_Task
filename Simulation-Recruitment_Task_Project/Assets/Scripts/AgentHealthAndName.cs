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
        Name = NamesList[(int)Random.Range(0.0f, 5.0f)];
        UIMS = FindObjectOfType<UIManagerScript>();
    }

    void Update()
    {
        if (Selected == true && UIMS.NewWasSelected == true)
        {
            Selected = false;
            UIMS.NewWasSelected = false;
        }
    }
    void TakeDamage()
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Agent") == true && DamageWasTaken == false)
        {
            TakeDamage();
            DamageWasTaken = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Agent") == true && DamageWasTaken == true)
        {
            DamageWasTaken = false;
        }
    }

}
