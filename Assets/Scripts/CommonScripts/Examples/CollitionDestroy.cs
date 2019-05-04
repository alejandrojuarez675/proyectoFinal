using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionDestroy : MonoBehaviour {

	public string NombreObjetoQueToco;

	private void OnCollisionEnter(Collision other) {
		
		if (other.gameObject.tag == this.NombreObjetoQueToco)
		{
			Destroy(other.gameObject);
		}

	}
}
