using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.LowLevelPhysics;
using UnityEngine.UIElements;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class C�psula : MonoBehaviour
{
    public GameObject C�psuladeColor;
    public List<GameObject> listaDeC�psulas;
    public float factorDeEscalamiento;
    public int numC�psulas = 0;

    void Start()
    {
       listaDeC�psulas = new List<GameObject>();
    }
    // Update is called once per frame
    void LateUpdate()
    {
        var meshRendererMaterial = C�psuladeColor.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = new Color(Random.value, Random.value, Random.value);
    }
}
