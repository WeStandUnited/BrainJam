using UnityEngine;
using System.Collections;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject MainGameObject;
    public GameObject ActionGameObject;

    // private YetAnotherScript yetAnotherScript;
    // private BoxCollider boxCol;


    void Awake()
    {
        
       // yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
      //  boxCol = otherGameObject.GetComponent<BoxCollider>();
    }


    void Start()
    {
       // boxCol.size = new Vector3(3, 3, 3);//pay attantion to this , its speaks of how objects imported from drag drop how to modify objects that are imported to it
        
    }
}
