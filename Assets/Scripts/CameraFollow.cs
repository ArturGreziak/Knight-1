using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;

    Vector3 offset = new Vector3(4f, 2f, -10f);

    private void FixedUpdate() {
        // transform.position = target.position + offset;
        MoveXOnly();
    }

    void MoveXOnly(){
        transform.position = new Vector3(target.position.x + offset.x, transform.position.y, transform.position.z);
    }
}
