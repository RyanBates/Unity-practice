using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;

    public int bulletDamage = 10;
    public float bulletSpeed = 100;

    void OnContact()
    {

        if (GetComponent<Rigidbody>() == Player.GetComponent<Rigidbody>())
        {
            Player.GetComponent<Character>().health -= bulletDamage;
            Destroy(GetComponent<GunBehaviour>().bullet);
        }

        if (GetComponent<Rigidbody>() == Enemy.GetComponent<Rigidbody>())
        {
            Player.GetComponent<Character>().health -= bulletDamage;
            Destroy(GetComponent<GunBehaviour>().bullet);
        }
        
    }

	// Use this for initialization
	void Start ()
    { 
        
    }
	
	// Update is called once per frame
	void Update ()
    {
    }
}
