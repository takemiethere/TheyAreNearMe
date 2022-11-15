 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class E1controller : MonoBehaviour
{
    private NavMeshAgent agent = null;
    [SerializeField] Transform target;
    [SerializeField] private float stoppingDistance = 2;

    // Start is called before the first frame update
    void Start()
    {
        GetRefs();
        
    }
    
    private void MovetoTarget()
    {
        agent.SetDestination(target.position);

        float distanceToTarget = Vector3.Distance(transform.position, target.position);
        if (distanceToTarget <= stoppingDistance)
        {
            RotateToTarget();
        }
    }

    private void RotateToTarget()
    {
        //transform.LookAt(target);

        Vector3 direction = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = rotation;
    }

    private void GetRefs()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (FieldOfView.canSeePlayer==true)
        {
            MovetoTarget();  
        }
    }
}
