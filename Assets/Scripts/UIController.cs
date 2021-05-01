using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIController : MonoBehaviour
{
    [SerializeField] private Button[] buttons;
    [SerializeField] private Conversation convText;
    [SerializeField] private TMP_Text mainUIText;
    [SerializeField] AudioClip[] buttonSounds;
    [SerializeField] AudioSource audioSource;
    [SerializeField] private Text promptText;

    private TMP_Text[] textFields;
    // Start is called before the first frame update
    void Awake()
    {
        textFields = new TMP_Text[buttons.Length];
        for (int x = 0; x < buttons.Length; x++)
        {
            textFields[x] = buttons[x].GetComponentInChildren<TMP_Text>();
        }
    }

    private void PrintToButton(int butNum, string text)
    {
        if (butNum < textFields.Length)
        {
            textFields[butNum].text = text;
        }
        else
        {
            Debug.Log("Inputed number exceeds textfields array length");
        }
    }

    public void SetScreen(string mainText, string[] subOptions)
    {
        mainUIText.text = mainText;
        for (int x = 0; x < 6; x++)
        {
            if (x < subOptions.Length)
            {
                buttons[x].gameObject.SetActive(true);
                PrintToButton(x, subOptions[x]);
            }
            else
            {
                buttons[x].gameObject.SetActive(false);
            }
        }
        //determine how many buttons should be turned on
        //set the text of those buttons
        //set main text
    }

    public void ButtonPressed(int butNum)
    {
        if(audioSource)
        {
            audioSource.clip = buttonSounds[butNum - 1];
            audioSource.Play();
        }
        convText.ButtonPressed(butNum-1);
    }
    public void ShowPrompt()
    {
        promptText.enabled = true;
    }
    public void HidePrompt()
    {
        promptText.enabled = false;
    }

}
