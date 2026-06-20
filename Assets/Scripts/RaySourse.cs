using UnityEngine;
using UnityEngine.InputSystem;

public class RaySourse : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void OnClick(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started)
        {
            Ray ray = new Ray(transform.position, transform.forward);
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow, 0.5f);
            if(Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                Debug.Log(hitInfo.collider.name);
                if(hitInfo.collider.TryGetComponent<TestCube>(out TestCube testCube))
                {
                    testCube.Action();
                }
            }
        }
    }
}
