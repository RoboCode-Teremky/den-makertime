using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class MovementScript : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] float gravity = -9.81f;

    Vector2 direction;
    CharacterController characterController;
    Vector3 velocity;

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
        if (characterController.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        Vector3 move = transform.forward * direction.y + transform.right * direction.x;
        characterController.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }
}
