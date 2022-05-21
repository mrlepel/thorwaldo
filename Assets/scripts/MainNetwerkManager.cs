using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MainNetwerkManager : NetworkManager
{
    public override void OnStartServer()
    {
        Debug.Log("server has started");
    }

    public override void OnStopServer()
    {
        Debug.Log("server has stopped");
    }

    public override void OnClientConnect()
    {
        Debug.Log("client has connected");
    }
    public override void OnClientDisconnect()
    {
        Debug.Log("client has disconnected");
    }

    public override void OnServerSceneChanged(string sceneName)
    {
        NetworkClient.Ready();
    }
}
