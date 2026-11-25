using UnityEngine;
using UnityEngine.InputSystem;

public class Zadatak2_1 : MonoBehaviour
{
    public GameObject djuro;
    bool isActive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[Key.D].wasPressedThisFrame)
        {
            isActive = !isActive;
            //djuro.SetActive(isActive);
            Destroy(djuro, 5);
        }
        /*
        if (isActive)
        {
            djuro.SetActive(false);
            isActive = false;
        }
        else
        {
            djuro.SetActive(true);
            isActive = true;
        }
        */
        Debug.Log(isActive);
    }
}
