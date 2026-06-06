using UnityEngine;
using UnityEngine.AI;

public class EnemyCube : MonoBehaviour
{
    NavMeshAgent agent;
    Transform target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = FindAnyObjectByType<MovementScript>().transform;
    }


    void Update()
    {
        agent.destination = target.position;
    }
}
