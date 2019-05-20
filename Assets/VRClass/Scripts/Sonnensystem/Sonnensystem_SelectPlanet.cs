using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem {

    public class Sonnensystem_SelectPlanet : MonoBehaviour {

        public SteamVR_Input_Sources RHandInput;
        public SteamVR_Input_Sources LHandInput;
        public SteamVR_Input_Sources AnyHand;
        public Transform PositionReference;
        public Behaviour[] SonnensystemScripts;
        private bool DetailScreenActive = false;

        void Start() {

        }

        void Update() {

            if (DetailScreenActive)
            {
                if (SteamVR_Input._default.inActions.Back.GetStateDown(RHandInput))
                {
                    foreach (var item in SonnensystemScripts)
                    {
                        item.enabled = true;
                    }
                    DetailScreenActive = false;
                }
            }

        }

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("planet"))
            {
                
                if (SteamVR_Input._default.inActions.SelectPlanetR.GetStateDown(RHandInput)) {
                    foreach (var item in SonnensystemScripts)
                    {
                        item.enabled = false;
                    }
                    DetailScreenActive = true;
                    other.gameObject.transform.position = Vector3.Lerp(other.gameObject.transform.position, PositionReference.transform.position,2F);
                    
                }
            }
        }
     
    }
        }
