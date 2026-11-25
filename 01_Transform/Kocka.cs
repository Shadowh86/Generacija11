using UnityEngine;

public class Kocka : MonoBehaviour
{
    public Transform sfera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(4, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        sfera.position += new Vector3(0.01f, 0, 0);
    }
}
