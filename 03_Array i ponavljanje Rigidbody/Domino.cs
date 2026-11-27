using UnityEngine;
using UnityEngine.InputSystem;

public class Domino : MonoBehaviour
{

    public GameObject plocica;
    public float snaga;

    GameObject prva;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PostaviPlocice();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[Key.S].wasPressedThisFrame)
        {
            //Gurnuti prvu plocicu
            prva.GetComponent<Rigidbody>().AddForce(Vector3.right *  snaga);
        }

        if (Keyboard.current[Key.R].wasPressedThisFrame)
        {
            PostaviPlocice();
        }
    }

    void PostaviPlocice()
    {
        for (int i = 0; i < 15; i++)
        {
            Vector3 pozicija = new Vector3(i *1, 1, 0);
            GameObject tempPlocica = Instantiate(
                plocica, pozicija, Quaternion.identity);

            if(i == 0)
            {
                prva = tempPlocica;
            }
        }
    }
}
