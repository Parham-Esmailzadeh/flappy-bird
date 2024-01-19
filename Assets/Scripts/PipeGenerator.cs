using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject pipes;
    private float min = -2f;
    private float max = 2f;
    public float timer = 0;
    public float pipe_speed;

    void Update(){
        timer += 1 * Time.deltaTime;
        if(timer > 1){
            timer = 0;

            GameObject P = Instantiate(pipes, new Vector3(9, Random.Range(min, max),-1), Quaternion.identity);
        }
    }
}
