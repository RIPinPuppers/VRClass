using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{
    public class DTSRotation : MonoBehaviour
    {

        [HideInInspector] public GameObject planet;
        public SteamVR_Input_Sources RHandInput;
        public SteamVR_Input_Sources LHandInput;
        public SteamVR_Input_Sources AnyHand;
        private Vector2 TrackPadVector;
        [SerializeField] private float rotSpeed = 1;

        // Use this for initialization
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            // get trackpad value and assign it to a var
            TrackPadVector = SteamVR_Input._default.inActions.TrackpadPosL.GetAxis(AnyHand);

            // rotate up 
            if (TrackPadVector.y > 0)
            {
                planet.transform.localEulerAngles += new Vector3(0, 0, 1 * rotSpeed);
            }

            // rotate down
            if (TrackPadVector.y < 0)
            {
                planet.transform.localEulerAngles += new Vector3(0, 0, -1 * rotSpeed);
            }

            // rotate right 
            if (TrackPadVector.x > 0)
            {
                planet.transform.localEulerAngles += new Vector3(1 * rotSpeed, 0, 0);
            }

            // rotate left
            if (TrackPadVector.x < 0)
            {
                planet.transform.localEulerAngles += new Vector3(-1 * rotSpeed, 0, 0);
            }
        }
    }
}
