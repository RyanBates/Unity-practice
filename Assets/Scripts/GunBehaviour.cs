using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehaviour : MonoBehaviour
{

    public GameObject bullet;

    public GameObject gun;

    int mag = 7;

    [HideInInspector]
    public Vector3 bPos, gPos;

    [HideInInspector]
   public bool shoot = false;

	// Use this for initialization
	void Start ()
    {
        bullet.transform.position = gun.transform.position;

        bPos = bullet.transform.position;
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

                mag -= 1;

                bPos.z += (bullet.transform.position.z / bullet.transform.position.z) + GetComponent<BulletBehaviour>().bulletSpeed;


            }
            
            
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            mag = 7;
        }
    }
}
