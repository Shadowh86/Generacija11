using UnityEngine;
using UnityEngine.InputSystem;

public class Zadatak2_2 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float runSpeed = 10f;
    public Key left = Key.A;
    public Key right = Key.D;
    public Key forward = Key.W;
    public Key back = Key.S;
    public Key run = Key.LeftShift;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[run].isPressed)
        {
            runSpeed = 2f;
        }
        if (Keyboard.current[run].wasReleasedThisFrame)
        {
            runSpeed = 1;
        }
       

        if (Keyboard.current[left].isPressed)
        {
            transform.Translate(Vector3.left * (moveSpeed * Time.deltaTime));
        }

        if (Keyboard.current[right].isPressed)
        {
            transform.Translate(Vector3.right * (moveSpeed * Time.deltaTime));
        }

        if (Keyboard.current[forward].isPressed)
        {
            transform.Translate(Vector3.forward * (moveSpeed * runSpeed * Time.deltaTime));
        }

        if (Keyboard.current[back].isPressed)
        {
            transform.Translate(Vector3.back * (moveSpeed * Time.deltaTime));
        }
    }
}
