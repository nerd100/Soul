using UnityEngine;
using System.Collections;

public class cocomover : MonoBehaviour {

	// Use this for initialization
	private float posx;
	private float posy;
	private float playerx;
	private float playery;
	private Vector3 enemy;
	public Animator coani;
	public GameObject ga;
	public Transform player;
	
	// Use this for initialization
	void Start () {

		coani = GetComponent<Animator>();
	}

	void Update() {
		enemy = ga.GetComponent<Transform>().transform.position;
		posx = enemy.x;
		posy = enemy.y;
		playerx= player.transform.position.x;
		playery = player.transform.position.y;


		if (posx >= playerx && posy >= playery) {
			coani.SetBool ("left", true);
		} else {
			coani.SetBool ("left", false);
		}

		if (posx >= playerx && posy <= playery) {
			coani.SetBool("up",true);
		}else {
			coani.SetBool ("up", false);
		}

		if (posx <= playerx && posy >= playery) {
			coani.SetBool("bot",true);	
		}else {
			coani.SetBool ("bot", false);
		}

		if (posx <= playerx && posy <= playery) {
			coani.SetBool("right",true);	
		}else {
			coani.SetBool ("right", false);
		}


	}

}
