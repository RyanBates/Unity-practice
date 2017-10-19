using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehaviour : Camera_Movement
{

    public GameObject bullet;


    int mag = 7;

    bool shoot = false;

	// Use this for initialization
	void Start ()
    {


	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (mag >= 1)
            {
                GameObject.FindWithTag("bullet");

                shoot = true;

                Instantiate(bullet);

                //bullet.transform * ;

                mag -= 1;
            }
            
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            mag = 7;
        }
    }
}
