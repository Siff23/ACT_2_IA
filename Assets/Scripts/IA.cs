using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IA : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent nmAgent;
    void Start()
    {
        nmAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (nmAgent)
        nmAgent.SetDestination(target.transform.position);
    }
}
