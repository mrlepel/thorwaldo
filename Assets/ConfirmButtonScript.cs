using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmButtonScript : MonoBehaviour
{
    public Color disabledSureColor;
    public Color disabledUnsureColor;
    public Button sureButton;
    public Button unsureButton;

   public void ShowConfirm(GameObject obj)
   {
       obj.SetActive(true);
   }

   public void HideConfirm(GameObject obj)
   {
       obj.SetActive(false);
   }

   public void ChangeSureButton()
   {
       sureButton.GetComponent<Image>().color = disabledSureColor;

   }

    public void ChangeUnsureButton()
   {
       unsureButton.GetComponent<Image>().color = disabledUnsureColor;
   }
}
