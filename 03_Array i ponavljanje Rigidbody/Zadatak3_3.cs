using UnityEngine;

public class Zadatak3_3 : MonoBehaviour
{
    int counter;

    private void OnTriggerEnter(Collider other)
    {
        counter++;
        Debug.Log(counter);

       // other.enabled = false;
        //other.GetComponent<Rigidbody>().useGravity = false;
        //other.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        Destroy(other.gameObject);
    }
}
