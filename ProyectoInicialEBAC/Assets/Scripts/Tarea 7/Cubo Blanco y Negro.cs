using System;
using UnityEngine;

public class CuboBlancoyNegro : MonoBehaviour
{
    GameObject CubodesdeCero;
    Vector3[] vertices =
    {
        new Vector3 (0, 0, 0),
        new Vector3 (1, 0, 0),
        new Vector3 (1, 1, 0),
        new Vector3 (0, 1, 0),
        new Vector3 (0, 1, 1),
        new Vector3 (1, 1, 1),
        new Vector3 (1, 0, 1),
        new Vector3 (0, 0, 1),
    };

    int[] triangulos =
    {
        0, 2, 1,
        0, 3, 2,
        2, 3, 4,
        2, 4, 5,
        1, 2, 5,
        1, 5, 6,
        0, 7, 4,
        0, 4, 3,
        5, 4, 7,
        5, 7, 6,
        0, 6, 7,
        0, 1, 6
    };
    // Update is called once per frame
    void Start()
    {
        CubodesdeCero = new GameObject("Nuestro Primer Cubo");
        CubodesdeCero.AddComponent<MeshFilter>();
        var meshFilter = CubodesdeCero.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        CubodesdeCero.AddComponent<BoxCollider>();
        var boxCollider = CubodesdeCero.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        CubodesdeCero.AddComponent<MeshRenderer>();
        var meshRendererMaterial = CubodesdeCero.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = Color.white;
        CubodesdeCero.transform.position = Vector3.one;
    }
}
