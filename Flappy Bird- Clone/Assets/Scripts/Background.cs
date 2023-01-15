using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    MeshRenderer mr;
    [SerializeField] float velocity = 2;
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        mr.material.mainTextureOffset += new Vector2(velocity * Time.deltaTime, 0);
    }
}
