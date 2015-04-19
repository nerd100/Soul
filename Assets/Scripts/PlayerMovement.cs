using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	 private float speed = 70f;


	void FixedUpdate () {
	
		if (Input.GetKey (KeyCode.D))
			GetComponent<Rigidbody2D> ().AddForce (Vector2.right * speed);
		if (Input.GetKey (KeyCode.A))
			GetComponent<Rigidbody2D> ().AddForce (-Vector2.right * speed);
		if (Input.GetKey (KeyCode.W))
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * speed);
		if (Input.GetKey (KeyCode.S))
			GetComponent<Rigidbody2D> ().AddForce (-Vector2.up * speed);
			
		}
}
