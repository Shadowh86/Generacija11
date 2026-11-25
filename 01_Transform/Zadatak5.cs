using UnityEngine;

public class Zadatak5 : MonoBehaviour
{
    public Vector3 position;
    public Vector3 rotation;
    public Vector3 scale;

    // Update is called once per frame
    void Update()
    {
        transform.position = position;
        transform.Rotate(rotation);
        transform.localScale = scale;
    }
}
