using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : Enemy
{


    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            print("Player");
            Destroy(collision.gameObject); // Destroying player 
            
        }
    }
}
