using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLevel : MonoBehaviour {
  public Color color;
	private static int levelnumber;
public void select(int a){


gameObject.GetComponent<Renderer>().material.color = color;

levelnumber = a;


}


public int getLevelnumber(){


	return levelnumber;
}



}
