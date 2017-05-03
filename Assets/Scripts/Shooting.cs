using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public AudioClip shootSound;
    

    private float bulletSpeed = 1500f;
    private AudioSource source;
    private float volLowRange = 0.5f;
    private float volHighRange = 1.5f;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.Space))// when space is pressed shoot
        {
            // Randomize frequency range and play sound
            float vol = Random.Range(volLowRange, volHighRange); 
            source.PlayOneShot(shootSound, vol); 

            // Fires the bullet prefab at speed
            GameObject shootThis = Instantiate(bullet, transform.position, transform.rotation) as GameObject; 
            shootThis.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, bulletSpeed)); 

            Destroy(bullet, 2.0f); // destroy the bullet
        }
    }

    

}
