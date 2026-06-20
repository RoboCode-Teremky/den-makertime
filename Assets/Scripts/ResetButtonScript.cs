using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ResetButtonScript : MonoBehaviour
{
    void Start()
    {
        var btn = GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.AddListener(OnButtonClick);
        }
        else
        {
            Debug.LogWarning("not work");
        }
    }

    void Update()
    {
        
    }

    public void OnButtonClick()
    {        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
