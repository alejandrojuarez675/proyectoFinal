using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crecerPaaArriba : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float limiteTamanio = 15f;
        if (transform.localScale.y <= limiteTamanio)
        {
            transform.localScale += new Vector3(0f, .1f, 0f);
        }
    }
}
