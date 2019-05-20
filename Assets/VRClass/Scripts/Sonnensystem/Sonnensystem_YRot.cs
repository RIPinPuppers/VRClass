using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{

    public class Sonnensystem_YRot : MonoBehaviour
    {
        public SteamVR_Input_Sources RHandInput;
        public SteamVR_Input_Sources LHandInput;
        public SteamVR_Input_Sources AnyHand;
        private Vector2 TrackpadVec;
        private Vector2 TouchStart;
        private bool rotateObjectRight;
        private bool rotateObjectLeft;
        private float ObjectRotation;
        private Vector3 CurrentRotation;
        // Use this for initialization

        void Start ()
        {
            CurrentRotation = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        }
	
	// Update is called once per frame
	void Update ()
        {

            ObjectRotation = CurrentRotation.y;

            //transform trackpad vector to a variable
            TrackpadVec= SteamVR_Input._default.inActions.TrackpadPosR.GetAxis(AnyHand);
            TrackpadVec= SteamVR_Input._default.inActions.TrackpadPosL.GetAxis(AnyHand);



            //Debug.Log("TrackpadVec is "+TrackpadVec);
            //Debug.Log("Vector3 of wheel_: " + WheelVec3);
            //TouchStart.x < TrackpadVec.y

            //get start pos rightHand
            if (SteamVR_Input._default.inActions.TrackpadTouchR.GetStateDown(AnyHand))
            {
                Debug.Log("Touchstart");
                TouchStart = SteamVR_Input._default.inActions.TrackpadPosR.GetAxis(AnyHand);
            }
            //get start pos leftHand
            if (SteamVR_Input._default.inActions.TrackpadTouchL.GetStateDown(AnyHand))
            {
                TouchStart = SteamVR_Input._default.inActions.TrackpadPosL.GetAxis(AnyHand);
            }


            if (SteamVR_Input._default.inActions.TrackpadTouchR.GetState(AnyHand))
            {
                if (TrackpadVec.x > TouchStart.x)
                {
                    //transform.position = Vector3.MoveTowards(transform.position, WheelVec3.position, 5);
                    ObjectRotation--;
                    Debug.Log("Rotate right");

                    transform.eulerAngles += new Vector3(transform.rotation.x, ObjectRotation, transform.rotation.z);


                }
                else if(TrackpadVec.x < TouchStart.x)
                {
                    ObjectRotation++;
                    Debug.Log("Rotate left");

                    transform.eulerAngles += new Vector3(transform.rotation.x, ObjectRotation, transform.rotation.z);
                }
                else
                { 
                    Debug.Log("Rotate none");
                }
            }
            #region same for left hand
            if (SteamVR_Input._default.inActions.TrackpadTouchL.GetState(AnyHand))
            {
                if (TrackpadVec.x > TouchStart.x)
                {
                    //transform.position = Vector3.MoveTowards(transform.position, WheelVec3.position, 5);
                    ObjectRotation--;
                    Debug.Log("Rotate right");

                    transform.eulerAngles += new Vector3(transform.rotation.x, ObjectRotation, transform.rotation.z);


                }
                else if (TrackpadVec.x < TouchStart.x)
                {
                    ObjectRotation++;
                    Debug.Log("Rotate left");

                    transform.eulerAngles += new Vector3(transform.rotation.x, ObjectRotation, transform.rotation.z);
                }
                else
                {
                    Debug.Log("Rotate none");
                }
            }
            #endregion




        }
    }
}
