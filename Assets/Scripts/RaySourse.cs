using UnityEngine;
using UnityEngine.InputSystem;

public class RaySourse : MonoBehaviour
{
    [SerializeField] private float shotCooldown = 0.2f;
    private float lastShotTime;
    [SerializeField] private AudioClip shotClip;
    [SerializeField] [Range(0f,1f)] private float shotVolume = 1f;
    private AudioSource audioSource;

    void Start()
    {
        lastShotTime = -shotCooldown;
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();
    }


    void Update()
    {
        
    }

    public void OnClick(InputAction.CallbackContext callbackContext)
    {
        if (!callbackContext.started)
            return;

        if (Time.time < lastShotTime + shotCooldown)
            return;

        lastShotTime = Time.time;

        {
            Ray ray = new Ray(transform.position, transform.forward);
            Debug.DrawRay(ray.origin, ray.direction * 100, new Color(1f, 0.6f, 0f, 1f), 1f);
            if (shotClip != null && audioSource != null)
                audioSource.PlayOneShot(shotClip, shotVolume);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                Debug.Log(hitInfo.collider.name);
                if (hitInfo.collider.TryGetComponent<TestCube>(out TestCube testCube))
                {
                    testCube.Action();
                }
            }
        }
    }
}