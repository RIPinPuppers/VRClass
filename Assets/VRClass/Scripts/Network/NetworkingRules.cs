/*
The Network Manager can only spawn and synchronize GameObjects from registered Prefabs, 
so you must register the specific GameObject Prefabs with the Network Manager that you want to be able to spawn during your game.
The Network Manager will only accept GameObject Prefabs which have a Network Identity component attached, 
so you must make sure you add a Network Identity component to your Prefab
before trying to register it with the Network Manager.



    A NetworkIdentity
    must be on the root GameObject of a spawnable Prefab. Without this, the Network Manager can’t register the Prefab.

    NetworkBehaviour scripts
    must be on the same GameObject as the NetworkIdentity, not on child GameObjects



The Network Manager
adds a player every time a client connects to the server. In some situations though, 
you might want it not to add players until an input event happens - such as a user pressing a “start” button on the controller.
To disable automatic player creation, navigate to the Network Manager component’s Inspector
and untick the Auto Create Player checkbox. 





isServer - true if the GameObject is on a server (or host) and has been spawned.

isClient - true if the GameObject is on a client, and was created by the server.

isLocalPlayer - true if the GameObject is a player GameObject for this client.

hasAuthority - true if the GameObject is owned by the local process


    Commands - which are called from the client and run on the server;

        Mark Function with Cmd prefix and give the [Command] Attribute
        
        Starting with Unity release 5.2 it is possible to send commands from non-player objects that have client authority. 
        These objects must have been spawned with NetworkServer.
        SpawnWithClientAuthority or have authority set with NetworkIdentity.AssignClientAuthority.
        Commands sent from these object are run on the server instance of the object, not on the associated player object for the client.

    ClientRpc calls - which are called on the server and run on clients.
        
        add the [ClientRpc] custom attribute to it, and add the “Rpc” prefix.


*/