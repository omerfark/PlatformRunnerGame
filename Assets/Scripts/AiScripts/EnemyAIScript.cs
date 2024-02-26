using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyAIScript : MonoBehaviour
{
    public Transform target; // Hedef noktası
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        SetDestination();
    }

    void SetDestination()
    {
        if (target != null)
        {
            navMeshAgent.SetDestination(target.position);
        }
    }
}