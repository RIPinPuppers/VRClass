using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Lobby_Player : NetworkLobbyPlayer {

    public GameObject LobbyParent;

    public Button joinButton;
    public Text PlayerNameText;
    public Text ButtonText;

    public void SetReady()
    {
        SendReadyToBeginMessage();
    }

    public override void OnClientEnterLobby()
    {
        base.OnClientEnterLobby();
        LobbyParent = GameObject.FindGameObjectWithTag("LobbyParent");
        transform.SetParent(LobbyParent.transform);
    }

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();
        if (isLocalPlayer)
            Setup();
        else
            SetupOtherPlayer();
    }

    private void Setup()
    {
        PlayerNameText.text = "You";
        joinButton.enabled = true;
        ButtonText.text = "Join";
    }

    private void SetupOtherPlayer()
    {
        PlayerNameText.text = "not you";
        joinButton.enabled = false;
        ButtonText.text = "...";
    }

}
