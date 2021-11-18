using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
 [SerializeField] float distance = 5f;
 [SerializeField] float speed = 1f;
 Rigidbody2D rb;
 float dir;
 void Start(){
 rb = GetComponent<Rigidbody2D>();
 }
 void FixedUpdate(){
 rb.velocity = new Vector2(Mathf.Sin(Time.time * speed), 0f) * distance;
 if(rb.velocity.x <= 0){
 if(dir != 1f){
 dir = 1f;
 gameObject.transform.localScale = new Vector3(dir,1f,1f);

 }
 }else{
 if(dir != -1f){
 dir = -1f;
 gameObject.transform.localScale = new Vector3(dir,1f,1f);
 }
 }
 }
}
