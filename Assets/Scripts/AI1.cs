using UnityEngine;
using System.Collections;

public class AI1 : MonoBehaviour {

	private Vector3 Player;
	private Vector3 Enemy;
	private Vector2 Playerdirection;
	private float Xdif;
	private float Ydif;
	private float speed;
	private int Wall;
	private float distance;
	private bool stun;
	private float stuntime;

	void Start (){
		speed = 2;
		stuntime = 0;
		stun = false;
		Wall = 1 << 8;

	}

	void Update () {

		Player = GameObject.Find ("Player").transform.position;
		Enemy = GameObject.Find ("Coco").transform.position;
		distance = Vector2.Distance (Player, Enemy);


		if (stuntime > 0) {
			GetComponent<Rigidbody2D> ().velocity = Vector2.zero;// (Playerdirection.normalized * speed);
			stuntime -= Time.deltaTime;
		} else {
			speed = 3;
			stun = false;
		}

		if (distance < 2.5 && !stun) {
			Xdif = Player.x - transform.position .x;
			Ydif = Player.y - transform.position.y;

			Playerdirection = new Vector2 (Xdif, Ydif);

			if (!Physics2D.Raycast (transform.position, Playerdirection, 3, Wall)){
				GetComponent<Rigidbody2D> ().AddForce (Playerdirection.normalized * speed);
		}
		}
	}
	void OnCollisionEnter2D (Collision2D Playerhit){

		if (Playerhit.gameObject.tag == "Player") {
			speed = 0;
			stun = true;
			stuntime = 1;

		}

	}
}
