using UnityEngine;

public class Kugla : MonoBehaviour
{

    public float snaga = 2000;
    Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.AddForce(transform.forward * snaga);
    }

   
}
