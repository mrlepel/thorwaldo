using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmButtonScript : MonoBehaviour
{
    public Color disabledSureColor;
    public Color disabledUnsureColor;
    public Color disabledFieldColor;
    public Color newTextColor;
    public Color newTextColorOld;
    public Button sureButton;
    public Button unsureButton;
    public InputField questionField;
    public Text newText;
    public GameObject sureText;
    public GameObject confetti;
    public AudioSource[] confettiAudio = { };

    public void ShowConfirm(GameObject obj)
    {
        obj.SetActive(true);
    }

    public void HideConfirm(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void pressSureButton()
    {
        if (string.IsNullOrEmpty(questionField.text))
        {
            newText.text = "You need to enter something!";
            newText.color = newTextColor;
        }
        else if (questionField.text.Length < 15)
        {
            newText.text = "You need to enter more than 15 characters!";
            newText.color = newTextColor;
        }
        else if (questionField.text.Length > 150)
        {
            newText.text = "Your text cannot exceed 150 characters!";
            newText.color = newTextColor;
        }
        else
        {
            ChangeSureButton();
            ChangeUnsureButton();
        }
    }
    public void ChangeSureButton()
    {
        
            sureButton.GetComponent<Image>().color = disabledSureColor;
            int randomInt = Random.Range(0, confettiAudio.Length);
            AudioSource playedAudio = confettiAudio[randomInt];
            playedAudio.Play();
            sureButton.enabled = false;
            unsureButton.enabled = false;
            sureText.SetActive(false);
            confetti.SetActive(true);
            ChangeInputField();
    }

    public void pressUnsureButton()
    {
        newText.text = "Are you sure?";
        newText.color = newTextColorOld;
    }
    public void ChangeUnsureButton()
    {
        unsureButton.GetComponent<Image>().color = disabledUnsureColor;
    }

    public void ChangeInputField()
    {
        questionField.GetComponent<Image>().color = disabledFieldColor;
        questionField.enabled = false;
    }
}
