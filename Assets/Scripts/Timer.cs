using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] GameObject TimeText;
    Text uiText;
    TextMeshProUGUI tmpText;
    float elapsed = 0f;

    void Start()
    {
        if (TimeText == null)
        {
            TimeText = GameObject.Find("AliveFor");
        }

        if (TimeText != null)
        {
            uiText = TimeText.GetComponent<Text>();
            tmpText = TimeText.GetComponent<TextMeshProUGUI>();
        }

        elapsed = 0f;
        UpdateDisplay();
    }

    void Update()
    {
        elapsed += Time.deltaTime;
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        int seconds = Mathf.FloorToInt(elapsed);
        string text = "Alive for: " + seconds + "s";

        if (tmpText != null)
        {
            tmpText.text = text;
            return;
        }

        if (uiText != null)
        {
            uiText.text = text;
            return;
        }

        if (TimeText != null)
        {
            var tryTmp = TimeText.GetComponent<TextMeshProUGUI>();
            if (tryTmp != null)
            {
                tryTmp.text = text;
                return;
            }

            var tryUi = TimeText.GetComponent<Text>();
            if (tryUi != null)
            {
                tryUi.text = text;
                return;

            }
        }
    }
}
