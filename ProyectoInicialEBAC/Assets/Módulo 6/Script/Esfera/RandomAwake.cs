using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.LowLevelPhysics;
using UnityEngine.UIElements;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Esfera : MonoBehaviour
{
    public GameObject EsferadeColor;
    public List<GameObject> listaDeEsferas;
    public float factorDeEscalamiento;
    public int numEsferas = 0;

    private void Awake()
    {
        var meshRendererMaterial = EsferadeColor.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = new Color(Random.value, Random.value, Random.value);
    }
    void Start()
    {
       listaDeEsferas = new List<GameObject>();
    }
    // Update is called once per frame
    void Update()
    {
  
    }
}
