using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class checkActive : MonoBehaviour
{
    public string str;
    public string FirstRoom;
    public void onCheckActive()
    {
        str = GameObject.Find("InputField").GetComponent<InputField>().text;
        if (str.Length > 0)
        {
            this.GetComponent<Button>().interactable = true;
        }
        else
        {
            this.GetComponent<Button>().interactable = false;
        }
    }

    public void joinRoom()
    {
        if (NetworkClient.localPlayer == null)
        {
            NetworkClient.AddPlayer();
        }
        GameObject localP = NetworkClient.localPlayer.gameObject;
        localP.GetComponent<player_script>().Name = str;
        Debug.Log(localP.GetComponent<player_script>().Name = str);
        SceneManager.LoadScene(FirstRoom);
    }
}
