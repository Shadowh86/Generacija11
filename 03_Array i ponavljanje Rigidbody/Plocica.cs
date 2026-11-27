using UnityEngine;
using UnityEngine.InputSystem;

public class Plocica : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[Key.R].wasPressedThisFrame)
        {
            Destroy(gameObject);
        }
    }
}
