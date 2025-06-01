using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IntroTextDisplay : MonoBehaviour
{
    public Text introText;
    public float displayTime = 3f;
    public string message = "Collect all the pickups!";

    void Start()
    {
        if (introText != null)
        {
            introText.text = message;
            StartCoroutine(HideTextAfterDelay());
        }
    }

    IEnumerator HideTextAfterDelay()
    {
        yield return new WaitForSeconds(displayTime);
        introText.gameObject.SetActive(false);
    }
}
