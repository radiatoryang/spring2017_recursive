using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorRaycast : MonoBehaviour {

	public Transform sphere; // when I make it "public", I can define it in Unity Editor
	
	// Update is called once per frame
	void Update () {
		// 1. generate Ray
		// what we did before: Ray ray = new Ray ( Camera.main.transform.position, Camera.main.transform.forward );
		Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );

		// 2. visualize Ray in Unity Editor view
		Debug.DrawRay( ray.origin, ray.direction * 50f, Color.red );

		// 3. declare RaycastHit
		RaycastHit rayHit = new RaycastHit();

		// 4. shoot the Raycast
		if ( Physics.Raycast( ray, out rayHit, 20f ) ) {
			// 5. draw the actual raycast
			Debug.DrawRay( ray.origin, ray.direction * rayHit.distance, Color.yellow );

			// 6. move sphere to where the raycast hit
			sphere.position = rayHit.point;

			// 7. make a copy of the sphere
			Instantiate( sphere, rayHit.point, Quaternion.Euler(0f, 0f, 0f) );
		}
	}


}




