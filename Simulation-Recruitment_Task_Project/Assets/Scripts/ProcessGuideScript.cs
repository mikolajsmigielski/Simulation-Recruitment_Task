using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessGuideScript : MonoBehaviour
{
    public List<GameObject> AgentsList;
    public float TimeToSpawn;
    public GameObject AgentTemplate;
    float time;

    
    void Start()
    {
        //check and set time to numbers from range 2 to 10
        if (TimeToSpawn > 2 && TimeToSpawn < 10)
        {
            time = TimeToSpawn;
        }
        else
        {
            if (TimeToSpawn < 2)
            {
                TimeToSpawn = 2;
            }
            else if (TimeToSpawn > 10)
            {
                TimeToSpawn = 10;
            }
        }
    }

    
    void Update()
    {
        //check and set time to numbers from range 2 to 10
        if (TimeToSpawn > 2 && TimeToSpawn < 10)
        {
            time = TimeToSpawn;
        }
        else
        {
            if (TimeToSpawn < 2)
            {
                TimeToSpawn = 2;
            }
            else if (TimeToSpawn > 10)
            {
                TimeToSpawn = 10;
            }
        }
        //Count down time
        if (time > 0)
        {
            time -= Time.deltaTime;
        }

        // if time is equal or less then 0, spawn agent, and add agent to list
        if (time <= 0)
        {
            time = TimeToSpawn;
            if (AgentsList.Count < 30)
            {
                AgentsList.Add(Instantiate(AgentTemplate, transform));
            }
        }
        //Check for empty spaces in the list
        for (int i = 0; i < AgentsList.Count; i++)
        {
            if (AgentsList[i] == null)
            {
                AgentsList.RemoveAt(i);
            }
        }
    }
}
