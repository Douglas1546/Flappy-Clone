using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    [SerializeField] float velocidade = -2;
    [SerializeField] float temp_destruct = 5;
    void Start()
    {
        Destroy(gameObject, temp_destruct);
    }

    void Update()
    {
        transform.position += new Vector3(velocidade * Time.deltaTime, 0, 0);
    }
}
