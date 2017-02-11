using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Hello World"); // print to Console
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Bonjour Monde");

		// transform.position += new Vector3( Random.Range(-0.1f, 0.1f), 0.1f, 0f );

		// move forward (based on way we're looking)
		transform.Translate( 0f, 0f, 0.1f ); 

		// rotate randomly on Y axis (green)
		transform.Rotate( 0f, Random.Range(-45f, 45f), 0f );

	}

}
