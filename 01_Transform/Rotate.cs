using UnityEngine;

public class Rotate : MonoBehaviour
{
    /*
        Napravite skriptu gdje se kocka povećava ili smanjuje (do maksimalno 10 i
        minimalno 0.1) po sve 3 osi i rotora po sve 3 osi uz javne varijable.
        Pulsiranje do 10 i 0.1
     */
    public float rotx, roty, rotz;
    bool isRising;

    Vector3 nesto = new Vector3 (0, 0, 0);
    float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.position = new Vector3(0.5f, 2, 0);
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        
    }
    void Update()
    {
       if(isRising)
        { 
            if(transform.localScale.x <= 0.1f)
            {
                isRising = false;
            }
            transform.localScale -= Vector3.one * 1f * Time.deltaTime;
        }
             
       else if(!isRising)
        {
            if(transform.localScale.x >= 10f)
            {
                isRising = true;
            }

            transform.localScale += Vector3.one * 1f * Time.deltaTime;
        }
    }
}
