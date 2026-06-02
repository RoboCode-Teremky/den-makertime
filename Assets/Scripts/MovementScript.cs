using UnityEngine;
using UnityEngine.InputSystem;

public class MovementScript : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    Vector2 direction;
    CharacterController characterController;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void OnMove(InputAction.CallbackContext callbackContext)
    {
        direction = callbackContext.ReadValue<Vector2>();
    }

    void Update()
    {
        Vector3 move = transform.forward*direction.y + transform.right*direction.x;
        characterController.Move(move*speed*Time.deltaTime);
    }
}
