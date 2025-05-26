using NUnit.Framework.Internal.Filters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAwake : MonoBehaviour
{
    public GameObject CuboColorRandom;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Instantiate(CuboColorRandom);
        Color c = new Color(Random.value, Random.value, Random.value);
        
        GetComponent<MeshRenderer>().material.color = c;
        transform.position = Random.insideUnitSphere;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
