using UnityEngine;

public class Zadatak6 : MonoBehaviour
{
    public float x;
    public int y;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (x + y > 20)
        {
            transform.localScale += new Vector3(20, 20, 20);
        }
        else if (x + y <= 20)
        {
            transform.localScale -= new Vector3(x + y, x + y, x + y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
