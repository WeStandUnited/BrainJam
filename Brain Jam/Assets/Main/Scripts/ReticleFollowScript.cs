using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleFollowScript : MonoBehaviour {

    public Camera CameraFacing;
    private Vector3 originalScale;


	// Use this for initialization
	void Start () {
        originalScale = transform.localScale;

    }
	
	// Update is called once per frame
	void Update () {
       
        RaycastHit hit;
        float distance;
        if (Physics.Raycast (new Ray (CameraFacing.transform.position, CameraFacing.transform.rotation * Vector3.forward ),out hit))
        {

            distance = hit.distance;
           if (hit.distance >= 2.0f) // play with this number
            {
                distance = 2.0f;
            }
            
        }else
        {

            // distance = CameraFacing.farClipPlane ;
            distance = 2.0f;
        }
        transform.position = CameraFacing.transform.position + CameraFacing.transform.rotation * Vector3.forward * distance;

        transform.LookAt(CameraFacing.transform.position);

        transform.Rotate(0.0f, 180f, 0.0f);
        transform.localScale = originalScale * distance;
        
        //transform.localScale = Vector3.one * distance;
        //Vector 3.one is short hand for new Vector3 (1.0f,1.0f,1.0f)

    }
}
