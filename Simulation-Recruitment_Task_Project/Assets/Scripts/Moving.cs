using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Moving : MonoBehaviour
{
    Vector3 NewPosition = new Vector3(0.0f, 1.0f, 0.0f);
    Vector3 CurrentPosition = new Vector3();
    public NavMeshAgent NavigationAgent;
    
    void Start()
    {
        CurrentPosition = transform.position;//get object current position
        NavigationAgent.SetDestination(NewPosition);//Set object destination
    }

    
    void Update()
    {
        // if current position is very close to new position (destination) then
        if (CurrentPosition.x >= NewPosition.x - 0.2f && CurrentPosition.x <= NewPosition.x + 0.2f && CurrentPosition.z >= NewPosition.z - 0.2f && CurrentPosition.z <= NewPosition.z + 0.2f)
        {
            NewPosition = new Vector3(Random.Range(-9.0f, 9.0f), 1.0f, Random.Range(-9.0f, 9.0f));// select new new position
            NavigationAgent.SetDestination(NewPosition);//set destination
        }
        CurrentPosition = transform.position;// get object current position
    }
}
