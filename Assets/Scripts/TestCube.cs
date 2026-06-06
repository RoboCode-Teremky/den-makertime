using UnityEngine;
using UnityEngine.AI;

public class TestCube : MonoBehaviour
{
    MeshRenderer meshRenderer;
    private NavMeshAgent navMeshAgent;
    [SerializeField] int hp = 3;
    void Start()
    { 
        navMeshAgent = GetComponent<NavMeshAgent>();
        meshRenderer = GetComponent<MeshRenderer>();
    }


    void Update()
    {
        
    }

    public void Action()
    {
        meshRenderer.material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 0.0f), Random.Range(0.0f, 0.0f));
        hp--;
        if (hp <= 0)
        {
            navMeshAgent.enabled = false;
            Destroy(gameObject, 2.5f);
        }
    }
}
