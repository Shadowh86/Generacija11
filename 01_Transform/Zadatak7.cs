using UnityEngine;

public class Zadatak7 : MonoBehaviour
{
    Vector3 nekako;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nekako = -transform.localScale;
        transform.localScale = nekako;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
