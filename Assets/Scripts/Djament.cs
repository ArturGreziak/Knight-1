using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Djament : MonoBehaviour
{
    int points = 0;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("points")){
            points += 1;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("frog"))
        {
            Destroy(other.gameObject);
        }
    }
    
}
