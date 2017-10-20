using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    bool alive = false;

    public int health = 100;
    
	// Use this for initialization
	void Start ()
    {
        if (health >= 0)
            alive = true;

        else
        {
            alive = false;
            Destroy(gameObject);
        }

        if(alive == false)
             GetComponent<GunBehaviour>().shoot = false;

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
