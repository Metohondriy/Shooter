using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class Move : MonoBehaviour
{
    public float WalkRadius = 10f;
    private NavMeshAgent Agent;
    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        MoveToNextPoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Agent.pathPending && Agent.remainingDistance <= Agent.stoppingDistance)
        {
            MoveToNextPoint();
        }
    }      

    void MoveToNextPoint()
    {
        Vector3 RandomPoint = GetRandomPointOnNavMesh(transform.position, WalkRadius);
        Agent.SetDestination(RandomPoint);
    }
    Vector3 GetRandomPointOnNavMesh(Vector3 position, float radius)
    {
        Vector3 RandomPos = position + Random.insideUnitSphere * radius;
        
        if (NavMesh.SamplePosition(RandomPos, out NavMeshHit hit, radius, NavMesh.AllAreas))
        {
            return hit.position;


        }
        return transform.position;
    }

}
