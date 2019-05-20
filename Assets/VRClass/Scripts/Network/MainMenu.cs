using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public InputField MatchNameInput;
    public LobbyManager lobbyManager;
    public GameObject ServerListObject;
    ServerList serverList;

    public void Host()
    {
        lobbyManager.StartMatchMaker();
        lobbyManager.matchMaker.CreateMatch(MatchNameInput.text, (uint)lobbyManager.maxPlayers, true, "" /*Password string*/, "", "", 0, 0, lobbyManager.OnMatchCreate);
    }
	
    public void Join()
    {
        lobbyManager.StartMatchMaker();
        serverList = ServerListObject.GetComponent<ServerList>();
        serverList.Refresh();
    }

}
