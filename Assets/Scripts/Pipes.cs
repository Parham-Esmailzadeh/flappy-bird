using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;
    
    void Update(){
        transform.position += Vector3.left * speed * Time.deltaTime;

        if(transform.position.x < -3.6){
            Destroy(this.gameObject);
        }
    }
}
