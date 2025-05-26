using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.LowLevelPhysics;
using UnityEngine.UIElements;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Cubo : MonoBehaviour
{
    public GameObject  CubodeColor;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numCubos = 0;

    void Start()
    {
       listaDeCubos = new List<GameObject>();
    }
    // Update is called once per frame
    void Update()
    {
        var meshRendererMaterial = CubodeColor.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = new Color(Random.value, Random.value, Random.value);
    }
}
