using UnityEngine;
using UnityEngine.InputSystem;

public class Top : MonoBehaviour
{
    public GameObject kugla;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[Key.Space].wasPressedThisFrame)
        {
           Instantiate(kugla, transform.position, transform.rotation);
           
        } 
    }
}
