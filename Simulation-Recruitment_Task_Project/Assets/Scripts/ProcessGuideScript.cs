using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessGuideScript : MonoBehaviour
{
    public List<GameObject> AgentsList;
    public float TimeToSpawn = 5.0f;
    public GameObject AgentTemplate;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        time = TimeToSpawn;
        AgentsList.Add(Instantiate(AgentTemplate, transform));
        time -= Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
