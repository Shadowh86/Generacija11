using UnityEngine;

public class Zadatak_Instanciranje : MonoBehaviour
{
    public GameObject[] prefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < prefab.Length; i++)
        {
          GameObject tempObject = Instantiate(prefab[i], 
                                         Vector3.left * (i + 2), 
                                         Quaternion.identity);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
