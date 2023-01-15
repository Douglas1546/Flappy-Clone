using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public Transform pipe;
    void Start()
    {
        InvokeRepeating("Spawn", 0, 2);
    }

    void Update()
    {
        
    }
    void Spawn(){
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(3,-3), 0), Quaternion.identity);
    }
}
