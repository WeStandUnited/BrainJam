using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class RayCaster : MonoBehaviour {

        public GameObject camera;
        public GameObject BeforeHit;
        public GameObject AfterHit;
 
        // Update is called once per frame
        void Update () {
       
            RaycastHit hit;
            float theDistance = 1.0f;

            //Debug Raycast shows line 

            Vector3 forward = camera.transform.TransformDirection(Vector3.forward) * 10;

            Debug.DrawRay(camera.transform.position, forward,Color.green);


        if (Physics.Raycast(camera.transform.position, (forward), out hit))
        {
            if (hit.transform.tag.Equals("CanBeLookedAt"))
            {

                print(theDistance + " " + hit.collider.gameObject.name);// prints for debugging reasons
                var firstdvaraible = BeforeHit.transform.position;
                var secondvaraible = BeforeHit.transform.rotation;
                // create Vector to store old GameObject Scale

             
                Destroy(BeforeHit);// Destroys OldObject
                // Create new object
                GameObject replacement = (GameObject) Instantiate(AfterHit, firstdvaraible, secondvaraible); // look up this in API
                replacement.transform.localScale = new Vector3(0.2F, 0.2F, 0.2F);




            }
            else
            {


            }
        }

    }
    }
