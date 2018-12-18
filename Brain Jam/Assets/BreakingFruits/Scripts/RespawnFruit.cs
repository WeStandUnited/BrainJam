using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnFruit : MonoBehaviour {
    public GameObject[] Fruits;
    private float time;

    public void Update()
    {
        if (Time.time > time)
        {
            GameObject Fruit = (GameObject)Instantiate(Fruits[Random.Range(0, Fruits.Length)], 
                                                        transform.position + new Vector3(Random.Range(-5, 5), 0, 0), 
                                                        new Quaternion(Random.value, Random.value, Random.value, Random.value));
            if (Fruit.GetComponent<Rigidbody>())
            {
                Fruit.GetComponent<Rigidbody>().velocity = new Vector3(0, 12, 0);
                Fruit.GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50)));
            }

            float size = Random.value;
            Fruit.transform.localScale += new Vector3(size, size, size); 

            Destroy(Fruit, 5);
            time = Time.time + Random.Range(0, 3);
        }
    }
}
