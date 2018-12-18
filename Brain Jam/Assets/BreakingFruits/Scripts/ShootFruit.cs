using UnityEngine;
using System.Collections;

public class ShootFruit : MonoBehaviour {
    public void OnMouseEnter()
	{
        if(Input.GetMouseButton(0))
            GetComponent<BreakFruit>().Run();
	}
}
