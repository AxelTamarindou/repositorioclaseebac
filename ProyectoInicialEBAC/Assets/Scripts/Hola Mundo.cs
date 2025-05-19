using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("algo paso");
        Debug.LogWarning("Algo salió medianamente mal");
        Debug.LogError("Algo salio muy mal");
        Debug.Log("Algo paso");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
