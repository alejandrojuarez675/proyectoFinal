using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverse : MonoBehaviour
{
    public float speedX = 0f;
    public float speedY = 0f;
    public float speedZ = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(speedX,speedY,speedZ) * Time.deltaTime);
    }
}
