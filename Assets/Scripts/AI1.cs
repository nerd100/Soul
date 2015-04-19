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

	public int healthpoints;

	void Start (){
		speed = 1;
		stuntime = 0;
		stun = false;
		Wall = 1 << 8;

	}

	public void makeDamage(int damageVal) {
		this.healthpoints -= damageVal;
		if (this.healthpoints <= 0)
			Destroy (gameObject);
	}

	void Update () {

		Player = GameObject.Find ("Player").transform.position;
		Enemy = gameObject.GetComponent<Transform>().transform.position;
		distance = Vector2.Distance (Player, Enemy);


		if (stuntime > 0) {
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;// (Playerdirection.normalized * speed);
			stuntime -= Time.deltaTime;
		} else {
			speed = 1;
			stun = false;
		}

		if (distance < 3 && !stun) {
			Xdif = Player.x - transform.position.x;
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
			healthpoints -= 20;
		}

	}
}
