using UnityEngine;
using UnityEngine.InputSystem;

public class Zadatak3_2 : MonoBehaviour
{
    /*
     * Napravi prefab sfere s rigidbody-em. na tipku 
     * S instanciraj 10 sfera na nasumicnim pozicijama iznad poda, 
     * sfere neka padnu na pod (napraviti plane s colliderom)
     */

    public GameObject prefabNeki;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[Key.S].wasPressedThisFrame)
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(
                    prefabNeki, 
                    new Vector3(
                        Random.Range(0, 10), 
                        Random.Range(0, 10), 
                        Random.Range(0, 10)), 
                    Quaternion.identity);
            }
        }
    }

}
