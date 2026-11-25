using UnityEngine;

public class Zadatak2_3 : MonoBehaviour
{
    GameObject primiteCube;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        primiteCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        primiteCube.AddComponent<Zadatak2_2>();
        primiteCube.SetActive(false);
        Destroy(primiteCube, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
