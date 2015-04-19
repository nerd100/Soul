using UnityEngine;
using System.Collections;

public class AI1 : MonoBehaviour {

	private Vector3 Player;
	private Vector3 Enemy;
	private Vector2 Playerdirection;
	private float Xdif;
	private float Ydif;
	public float speed;
	private int Wall;
	private float instance;
	private float distance;

	void Start (){

		Wall = 1 << 8;

	}


	void Update () {

		Player = GameObject.Find ("Player").transform.position;
		Enemy = GameObject.Find ("Coco").transform.position;
		distance = Vector2.Distance (Player, Enemy);

		if (distance < 3) {
			Xdif = Player.x - transform.position .x;
			Ydif = Player.y - transform.position.y;

			Playerdirection = new Vector2 (Xdif, Ydif);

			if (!Physics2D.Raycast (transform.position, Playerdirection, 3, Wall))
				GetComponent<Rigidbody2D> ().AddForce (Playerdirection.normalized * speed);

		}
	}
}
