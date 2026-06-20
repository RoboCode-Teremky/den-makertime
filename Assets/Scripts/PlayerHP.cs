using UnityEngine;

public class PlayerHP : MonoBehaviour
{


    [SerializeField] GameObject Menu;
    [SerializeField] GameObject HPbar;
    [SerializeField] float playerHP = 200.0f;

    void Start()
    {
        Menu.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            playerHP -= 20.0f;
        }
        if (other.gameObject.CompareTag("BigZomb"))
        {
            playerHP -= 40.0f;
        }
    }

    void Update()
    {
        HPbar.transform.localScale = new Vector3(playerHP / 200.0f, HPbar.transform.localScale.y, HPbar.transform.localScale.z);
        if (playerHP <= 0.0f)
        {
            Menu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
