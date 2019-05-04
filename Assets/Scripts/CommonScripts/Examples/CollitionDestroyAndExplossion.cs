using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionDestroyAndExplossion : MonoBehaviour
{

	public GameObject explosion;
    public string tagObjetoQueToco;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == this.tagObjetoQueToco)
        {
			this.gameObject.GetComponent<Rigidbody>().AddForce(0,500,0);
			Destroy(other.gameObject);

			GameObject explosion = Instantiate(this.explosion, transform.position, Quaternion.identity);
			Destroy(explosion,1);
        }
    }

}
