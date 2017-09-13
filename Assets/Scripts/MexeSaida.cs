using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MexeSaida : MonoBehaviour {
	public float speed;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mexesaida ();
	}

	void mexesaida(){
		if (transform.position.y <= 6.462787f) {
			transform.Translate (Vector2.left * speed * Time.deltaTime);
		}	
	}
}
