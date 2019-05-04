using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionForce : MonoBehaviour
{

    public string objeto;
    public int forceX = 0;
    public int forceY = 0;
    public int forceZ = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == this.objeto)
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(this.forceX, this.forceY, this.forceZ);
        }
    }

}
