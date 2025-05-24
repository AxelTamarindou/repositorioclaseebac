using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.LowLevelPhysics;
using UnityEngine.UIElements;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Cápsula : MonoBehaviour
{
    public GameObject CápsuladeColor;
    public List<GameObject> listaDeCápsulas;
    public float factorDeEscalamiento;
    public int numCápsulas = 0;

    void Start()
    {
       listaDeCápsulas = new List<GameObject>();
    }
    // Update is called once per frame
    void LateUpdate()
    {
        var meshRendererMaterial = CápsuladeColor.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = new Color(Random.value, Random.value, Random.value);
    }
}
