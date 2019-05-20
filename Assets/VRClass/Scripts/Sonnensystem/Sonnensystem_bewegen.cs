using System.Collections;
using System.Collections.Generic;
using UnityEngine;




namespace Valve.VR.InteractionSystem
{
    public class Sonnensystem_bewegen : MonoBehaviour
    {
        public GameObject RHand;
        public GameObject LHand;
        public SteamVR_Input_Sources RHandInput;
        public SteamVR_Input_Sources LHandInput;
        public SteamVR_Input_Sources AnyHand;

        private Vector3 currentPos;
        private Vector3 clickedPos;
        private Vector3 lastPos;

        void Update()
        {

            #region oldcode
            /*if (SteamVR_Input._default.inActions.BewegenR.GetState(RHandInput) == true & SteamVR_Input._default.inActions.BewegenL.GetState(LHandInput) ==false)
            {
                transform.position = new Vector3(transform.position.x, 0, transform.position.z);
                transform.eulerAngles = new Vector3(0, transform.rotation.y, 0);
                Sonnensystem.transform.parent = RHand.transform;

            }
            else if (SteamVR_Input._default.inActions.BewegenR.GetState(RHandInput) == false & SteamVR_Input._default.inActions.BewegenL.GetState(LHandInput) == true)
            {

                Sonnensystem.transform.parent = LHand.transform;
                transform.position = new Vector3(transform.position.x, 0, transform.position.z);
                transform.eulerAngles = new Vector3(0, transform.rotation.y, 0);

            }
            else
            {
                Sonnensystem.transform.parent = null;
            }
            */
            #endregion

           

            if (currentPos == lastPos)
            {
               // Debug.Log("stop moviong");
            }

            //check position when clicked
            if (SteamVR_Input._default.inActions.VergroessernR.GetState(RHandInput) != SteamVR_Input._default.inActions.VergroessernL.GetState(LHandInput)) {
                
            if (SteamVR_Input._default.inActions.BewegenR.GetStateDown(RHandInput))
            {
                clickedPos = RHand.transform.position;

            }

            if (SteamVR_Input._default.inActions.BewegenR.GetState(RHandInput))
            {

                currentPos = RHand.transform.position;
                float difX = clickedPos.x - currentPos.x;
                float difZ = clickedPos.z - currentPos.z;

                transform.position -= new Vector3(difX, 0, difZ);


            }

            #region ForLHand
                if (SteamVR_Input._default.inActions.BewegenL.GetStateDown(LHandInput))
                {
                    clickedPos = LHand.transform.position;

                }

                if (SteamVR_Input._default.inActions.BewegenL.GetState(LHandInput))
                {

                    currentPos = LHand.transform.position;
                    float difX = clickedPos.x - currentPos.x;
                    float difZ = clickedPos.z - currentPos.z;

                    transform.position -= new Vector3(difX, 0, difZ);


                }
                #endregion




            }
            lastPos = currentPos;
          
            currentPos = RHand.transform.position;
            
        }
           

             


            
          



        


    }
}
