using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reticle2 : MonoBehaviour
{

    public GameObject camera;

    public List<GameObject> BeforeHit = new List<GameObject>();
    public List<GameObject> AfterHit = new List<GameObject>();
    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        float theDistance = 1.0f;



        Vector3 forward = camera.transform.TransformDirection(Vector3.forward) * 10;

        Debug.DrawRay(camera.transform.position, forward, Color.green);//Debug Raycast shows line

        //TODO: not make objects both split at same time
        if (Physics.Raycast(camera.transform.position, (forward), out hit))//what is this statment?
        {
           
                for (int i = 0; i < BeforeHit.Capacity; i++)// maybe while loops would work better here
                {

                if (hit.transform.tag.Equals("CanBeLookedAt"))// i think its here, find new way to paint object for raycast to hit
                {

                    var firstdvaraible = BeforeHit[i].transform.position;
                    var secondvaraible = BeforeHit[i].transform.rotation;
                    Vector3 tempvar = BeforeHit[i].transform.localScale;// create Vector to store old GameObject Scale



                    Destroy(BeforeHit[i]);// Destroys OldObject

                    GameObject replacement = (GameObject)Instantiate(AfterHit[i], firstdvaraible, secondvaraible); //https://docs.unity3d.com/ScriptReference/Object.Instantiate.html
                    replacement.transform.localScale = tempvar;



                }
                else
                {
                    break;
                }
            }
            
        }


    }

}






