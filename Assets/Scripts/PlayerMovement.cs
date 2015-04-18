using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	 private float speed = 0.03f;


	void FixedUpdate () {
	
		if (Input.GetKey (KeyCode.D))
			transform.Translate (Vector2.right * speed);
		if (Input.GetKey (KeyCode.A))
			transform.Translate (-Vector2.right * speed);
		if (Input.GetKey (KeyCode.W))
			transform.Translate (Vector2.up * speed);
		if (Input.GetKey (KeyCode.S))
			transform.Translate (-Vector2.up * speed);
		}
}
