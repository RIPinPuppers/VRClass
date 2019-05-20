using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace Valve.VR.InteractionSystem {
    public class NetworkPlayer : NetworkBehaviour {

        [Header("Local Player Settings:")]

        public GameObject[] LocalPlayerGameObjs;
        public Behaviour[] LocalPlayerScripts;
        public Camera LocalPlayerVRCam;

        [Header("Synced Parts:")]

        public Transform Head;
        public Transform FollowHead;

        public Transform LeftCube;
        public Transform LeftHand;

        public Transform RightCube;
        public Transform RightHand;

        [Header("Input")]

        public SteamVR_Input_Sources RightHandInput;
        public GameObject SpawnCube;


        private void Start()
        {
            if (!isLocalPlayer)
            {
                //assign client player layer
                gameObject.layer = LayerMask.NameToLayer("Client Player");

                //rename the player object
                gameObject.name = "ClientPlayer " + netId;

                //disable all LocalPlayerGameObjs
                for (int i = 0; i < LocalPlayerGameObjs.Length; i++)
                {
                    LocalPlayerGameObjs[i].SetActive(false);
                }

                //disable all LocalPlayerScripts
                for (int i = 0; i < LocalPlayerScripts.Length; i++)
                {
                    LocalPlayerScripts[i].enabled = false;
                }

                //disable the LocalPlayerCam;
                LocalPlayerVRCam.enabled = false;

                //color the clients hand cubes red
                RightCube.GetComponent<MeshRenderer>().material.color = Color.red;
                LeftCube.GetComponent<MeshRenderer>().material.color = Color.red;

                return;
            }



        
            //assign local player layer
            gameObject.layer = LayerMask.NameToLayer("Local Player");

            //rename the player object
            gameObject.name = "LocalPlayer";

            //get all cameras in the scene
            Camera[] OffCam = FindObjectsOfType<Camera>();
            //get the offline cam and disable it
            for (int i = 0; i < OffCam.Length; i++)
            {
                if (OffCam[i].CompareTag("Offline"))
                {
                    OffCam[i].gameObject.SetActive(false);
                }
            
            }

            //disable the localplayers handcubes
            RightCube.gameObject.SetActive(false);
            LeftCube.gameObject.SetActive(false);
        

        }

        //gets called when a Client connects
        public override void OnStartClient()
        {
            Debug.Log("OnStartClient called");
        }


        public override void OnStartLocalPlayer()
        {
            Debug.Log("OnStartLocalPlayer called");
        }

   
        private void Update()
        {
            if (!isLocalPlayer)
                return;

            //set the position of the networked objects to the position of their counterparts
            Head.position = FollowHead.position;
            LeftCube.position = LeftHand.position;
            RightCube.position = RightHand.position;

            //set the rotation
            Head.rotation = FollowHead.rotation;
            LeftCube.rotation = LeftHand.rotation;
            RightCube.rotation = RightHand.rotation;

            if (SteamVR_Input._default.inActions.GrabPinch.GetStateDown(RightHandInput))
            {
                CmdSpawnCube();
                Debug.Log("yo");
            }
        }

        [Command]
        public void CmdSpawnCube()
        {
            // Create the cube from the cube Prefab
            var cube = (GameObject)Instantiate(SpawnCube, RightCube.position, RightCube.rotation);

            // Add velocity to the bullet
            cube.GetComponent<Rigidbody>().velocity = cube.transform.forward * 6;

            // Spawn the bullet on the Clients
            NetworkServer.Spawn(cube);
            Debug.Log("SpawningCube");

            // Destroy after a few seconds
            Destroy(cube, 5);
            
        }
    }
}