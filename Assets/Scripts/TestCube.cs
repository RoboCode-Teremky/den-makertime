using UnityEngine;
using UnityEngine.AI;

public class TestCube : MonoBehaviour
{

    BoxCollider boxCollider;
    MeshRenderer meshRenderer;
    private NavMeshAgent navMeshAgent;
    [SerializeField] int hp = 3;
    void Start()
    { 
        boxCollider = GetComponent<BoxCollider>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        meshRenderer = GetComponent<MeshRenderer>();
    }


    void Update()
    {
        
    }

    public void Action()
    {
        Color currentColor = meshRenderer.material.color;
        currentColor.r = Mathf.Clamp01(currentColor.r + 0.2f);
        currentColor.g = Mathf.Clamp01(currentColor.g - 0.2f);
        currentColor.b = Mathf.Clamp01(currentColor.b - 0.1f);
        meshRenderer.material.color = currentColor;
        hp--;
        if (hp <= 0)
        {
            boxCollider.enabled = false;
            navMeshAgent.enabled = false;
            Destroy(gameObject, 2.5f);
        }
    }
}
