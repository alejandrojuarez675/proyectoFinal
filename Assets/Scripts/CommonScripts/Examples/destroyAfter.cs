using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class destroyAfter : MonoBehaviour {
 
     float lifetime = 3.0f;

	void Start () {
		DestroyExplosion();
	}
 
     public void DestroyExplosion ()
     { Destroy (gameObject, lifetime); }
 }
