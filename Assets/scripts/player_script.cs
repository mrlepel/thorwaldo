using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : NetworkBehaviour
{
    [SyncVar]
    public string Name = "";
    [SyncVar]
    public string Role = "";
    
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
