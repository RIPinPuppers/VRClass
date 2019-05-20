using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Match;

public class ServerList : MonoBehaviour {

    LobbyManager lobbyManager;

    public GameObject ServerObject;
    public GameObject ServerListParent;
	// Use this for initialization
	void Start () {
        lobbyManager = GameObject.FindGameObjectWithTag("NetworkManager").GetComponent<LobbyManager>();
	}

    public void Refresh()
    {
        if(lobbyManager != null)
        {
            if(lobbyManager.matchMaker == null)
            {
                lobbyManager.StartMatchMaker();
            }

            lobbyManager.matchMaker.ListMatches(0, 20, "", true, 0, 0, onMatchList);

        }
    }

    private void onMatchList(bool success, string extendedInfo, List<MatchInfoSnapshot> matchList)
    {
        if (!success)
        {
            print("please Refresh");
        } else
        {
            foreach(MatchInfoSnapshot match in matchList)
            {
                GameObject Server = (GameObject)Instantiate(ServerObject);
                Server.transform.SetParent(ServerListParent.transform);
            }
        }
    }
}
