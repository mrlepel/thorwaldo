using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmButtonScriptTor : MonoBehaviour
{
    public Color disabledSureColor;
    public Color disabledUnsureColor;
    public Color disabledFieldColor;
    public Color newTextColor;
    public Color newTextColorOld;
    public Button sureButton;
    public Button unsureButton;
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
            ChangeSureButton();
            ChangeUnsureButton();
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
}
