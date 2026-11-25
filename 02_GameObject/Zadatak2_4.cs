using UnityEngine;

public class Zadatak2_4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 5; i++)
        { 
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = Vector3.left * i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
