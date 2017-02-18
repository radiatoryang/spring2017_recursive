using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// put this script on the thing to be looked at
// do not put on the player or camera!!
public class GazeRaycast : MonoBehaviour {

	float timeLookedAt = 0f; // number of seconds we looked at this thing
	
	void Update () {
		// 1. calculate the Raycast origin and direction
		Ray ray = new Ray( Camera.main.transform.position, Camera.main.transform.forward );

		// 2. setup our RaycastHit variable, reserve memory for it
		RaycastHit myRayHit = new RaycastHit();

		Debug.DrawRay( ray.origin, ray.direction * 50f );

		// 3. test our Raycast
		if ( Physics.Raycast( ray, out myRayHit, 50f ) ) {
			// 4. did the Raycast hit this object?
			if ( myRayHit.collider == GetComponent<Collider>() ) {
				// this is up to you... what should we do if we look at it?
				Debug.Log("raycast hit on " + gameObject.name );
				timeLookedAt += Time.deltaTime; // "deltaTime" is how long the frame was, after 1 sec it will = 1
				if ( timeLookedAt >= 1f ) { // did we look for 1+ seconds?
					timeLookedAt = 0f;
					// now do something? play a sound, play animation, explode, etc....
					Destroy( gameObject ); // delete this after 1 second
				}
			} else {
				timeLookedAt = 0f; // reset to 0 if we look at a different collider
			}
		} else {
			timeLookedAt = 0f; // reset to 0 if we look at NO colliders at all
		}
	}

}
