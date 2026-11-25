using UnityEngine;

public class Zadatak2_6 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 5; i++) 
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            string name = cube.name = $"Cube{i}";
            cube.AddComponent<Zadatak2_2>();
            Debug.Log(name);    
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
