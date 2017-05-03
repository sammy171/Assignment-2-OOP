using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bill : Enemy
{
    public float range = 5f;
    
    
    public GameObject bullet;

    public float fireRate = 1f;
    public float fireCountdown = 0f;
    public Transform firePoint;

    

    // Update is called once per frame
    void Update()
    {
        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }
    }

    void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }

    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.right);
        Debug.DrawLine(transform.position, transform.position + fwd * 10f);
        if (Physics.Raycast(transform.position, fwd, 10))
            print("There is something in front of the object!");
    }


}
