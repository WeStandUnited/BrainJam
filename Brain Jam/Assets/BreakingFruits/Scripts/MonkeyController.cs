using UnityEngine;
using System.Collections;

public class MonkeyController : MonoBehaviour {
    public Transform target;
    public Animator animator;	//animations
	float time;     //time wait
    bool stop = true; //stand or act
	
	public GameObject[] fruits; 	//fruits
	public GameObject[] fruits_m;   //fake fruits
    public Animator fruitAnimator;  //the inclusion of the fruit at the right time
    public Transform fruit; //place instantiate fruit
	bool fruitStart = false; //the readiness of the fruit for the launch
    float timec = 0;    //time throw fruit
	int n_fruit;    //index of the fruit from set

    /*
		Rebind - rewind the animation at the beginning
		Play - start the animation
		
		by the time the player will fit to the monkey
        it will take time Time.time
		to make monkey faces at the appearance of
		time = Time.time
	*/

    void OnEnable()
	{
		stop = true;
		fruitStart = false;

        target = Camera.main.transform;
	}

	
	void LateUpdate () {
		if(target) LookAtPlayer(); //to aim at the player

        //wait some time to throw fruit
        if (fruitStart)
            if (Time.time > timec)
            {
                RespawnFruit();    //throw fruit

                fruits_m[n_fruit].SetActive(false);
                fruitStart = false;
            }

                //time to execute the code between animations
                if (Time.time > time)
		{
			time = Time.time + Random.Range(1.5f,2);
			stop = false;
		}

        //throw the fruit or to tease the player
        if (!stop)
		{
			int n = Random.Range(0,8);
			switch(n)
			{
				case 0:	Hit(); break;   //tease 1
                case 1:	Tease(); break; //tease 2
                case 2: Throw(); break;    //to throw in the other cases
                case 3: Throw(); break;
                case 4: Throw(); break;
                default: Wite(); break;
            }	
		}	
	}

    //to aim at the player
    void LookAtPlayer()
    {
        transform.LookAt(target);
        Vector3 tr = new Vector3(0, transform.eulerAngles.y - 185);
        transform.eulerAngles = tr;
    }


    //teases waves paws	
    void Hit()	
	{
		animator.Play("Hit", 0, 0f);
        if (GetComponent<AudioSource>())
        {
            GetComponent<AudioSource>().pitch += Random.value*0.24f;
            GetComponent<AudioSource>().Play();
        }
        fruitStart = false;
		stop = true;
	}

    //teasing tongues
    void Tease()	
	{
		animator.Play("Tease", 0, 0f);
		fruitStart = false;
		stop = true; 
	}

    //raises the fruit and throws forward
    void Throw()
	{
		animator.Play("Throw", 0, 0f);
        timec = Time.time + 1.45f;
		fruitStart = true;
		stop = true;

        //show the fruit, which raises monkey
		fruitAnimator.Play("FruitAnim", 0, 0f);
		n_fruit = Random.Range(0,fruits.Length);
		fruits_m[n_fruit].SetActive(true);
	}

    //throw fruit
    void RespawnFruit()
	{	
        GameObject Fruit = (GameObject)Instantiate(fruits[n_fruit], fruit.position, transform.rotation);
        if (Fruit.GetComponent<Rigidbody>())
        {
            Fruit.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 2, -25));
            Fruit.GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50)));
        }

        float size = Random.value;
        Fruit.transform.localScale += new Vector3(size, size, size);

        Destroy(Fruit, 5);
        time = Time.time + Random.Range(0, 3);  
	}

    void Wite()
    {
        //animator.Rebind();
        animator.Play("Wite");
        fruitStart = false;
        stop = true;
    }
}
