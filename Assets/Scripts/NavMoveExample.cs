using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMoveExample : MonoBehaviour
{
    private NavMeshAgent agent = null;

    [SerializeField] private Transform targetPosition = null;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(targetPosition != null)
            {
                agent.SetDestination(targetPosition.position);
            }
        }
    }
}
