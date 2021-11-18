using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        
    }
    void Update()
    {
       
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Hp>())
        {
            other.gameObject.GetComponent<Hp>().TakeDamage(1);
        }
    }
}
