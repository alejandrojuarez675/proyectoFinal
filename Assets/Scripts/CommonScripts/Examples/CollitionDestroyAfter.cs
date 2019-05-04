using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionDestroyAfter : MonoBehaviour {

	public  int delay = 0;

	private void OnCollisionEnter(Collision other) {
		
		if (other.gameObject.name == "Cube")
		{
			Destroy(other.gameObject, delay);
		}

	}
}
