using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    //public Transform Enemy;

    public float lifetime = 2.0f;
    
    // Use this for initialization
    void Awake()
    {
        Destroy(gameObject, lifetime);
    }

   
    void OnCollisionEnter(Collision collision)
    {
        print("hit");
        if (collision.gameObject.tag == "Enemy")
        {
            print("Enemy");
            Destroy(collision.gameObject); // Destroying enemy
            Destroy(gameObject); // Destroying self 
            Score.Instance.AddScore(1);
        }
    }
}
