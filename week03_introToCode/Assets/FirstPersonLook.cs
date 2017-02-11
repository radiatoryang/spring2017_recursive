using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonLook : MonoBehaviour {
	
	void Update () {
		// for Mouse X: -1 if moving left, 0 if not moving, +1 if move right
		float mouseHorizontal = Input.GetAxis("Mouse X");
		float mouseVertical = Input.GetAxis("Mouse Y");

		// rotate the object (maybe the Main Camera?) based on mouse movement
		transform.Rotate( -mouseVertical, mouseHorizontal, 0f );

		// un-roll the camera
		transform.eulerAngles = new Vector3( transform.eulerAngles.x, transform.eulerAngles.y, 0f );
		// transform.eulerAngles.z = 0f; // THIS WILL NOT WORK, YOU CANNOT CHANGE X Y Z DIRECTLY

		// if you hold down LEFT MOUSE BUTTON, you move forward
		if ( Input.GetMouseButton(0) == true ) { // "0" = left-click, "1" = right-click
			transform.Translate( 0f, 0f, 0.1f ); // move forward based on my rotation
			Cursor.lockState = CursorLockMode.Locked; // lock the cursor in middle of screen
			Cursor.visible = false; // hide the cursor 
		}

	}
}
