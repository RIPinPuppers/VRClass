using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{

    public class Sonnensystem_grosserKleiner : MonoBehaviour
    {
        public GameObject RHand;
        public GameObject LHand;
        public SteamVR_Input_Sources RHandInput;
        public SteamVR_Input_Sources LHandInput;
        public SteamVR_Input_Sources AnyHand;
        public float Faktor = 1;
        public float ScaleFaktor = 1;
        public float dis = 1;
        public Vector3 clickedScale;
        public float clickedDistance;
        public float currentDistance;
        private Vector3 minScale = new Vector3(0.01f, 0.01f, 0.01f);
        private Vector3 maxScale = new Vector3(0.6f, 0.6f, 0.6f);




        void Update()
        {




            if (SteamVR_Input._default.inActions.VergroessernR.GetStateDown(RHandInput))
            {

                clickedDistance = Vector3.Distance(RHand.transform.position, LHand.transform.position);
                
               

            }

            if (SteamVR_Input._default.inActions.VergroessernR.GetState(RHandInput) && SteamVR_Input._default.inActions.VergroessernL.GetState(LHandInput))
            {

                currentDistance = Vector3.Distance(RHand.transform.position, LHand.transform.position);
                Vector3 currentScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);


                if (currentDistance > clickedDistance)
                {
                    if(currentScale.x < maxScale.x) {
                        Debug.Log("bigger");
                        transform.localScale += new Vector3(0.01f, 0.01f, 0.01f); //rescaling Object
                    }
                    else if (currentScale.x >= maxScale.x)
                    {
                        transform.localScale = maxScale;
                    }

                }


                if (currentDistance < clickedDistance) {

                    if(currentScale.x > minScale.x) { 
                    Debug.Log("smaller");
                    transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f); //rescaling Object
                    }
                    else if (currentScale.x <= minScale.x)
                {
                        transform.localScale = minScale;
                    }
                  
                }


            }






        }



        /*void changeSize()
        {
            transform.localScale = new Vector3(dis * Faktor, dis * Faktor, dis * Faktor);

        }
        */
    }
}
