using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float movementSpeed = 0.0f;  //How fast we follow
    public Transform target;            //Object we want to follow

    

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            // enemy locks-on with player
            transform.position = Vector3.MoveTowards(transform.position, target.position, movementSpeed);
        }
    }
    
}
