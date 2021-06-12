using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessGuideScript : MonoBehaviour
{
    public List<GameObject> AgentsList;
    public float TimeToSpawn;
    public GameObject AgentTemplate;
    float time;

    // Start is called before the first frame update
    void Start()
    {
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
        AgentsList.Add(Instantiate(AgentTemplate, transform));
        time -= Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
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
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        if (time <= 0)
        {
            time = TimeToSpawn;
            if (AgentsList.Count < 30)
            {
                AgentsList.Add(Instantiate(AgentTemplate, transform));
            }
        }
    }
}
