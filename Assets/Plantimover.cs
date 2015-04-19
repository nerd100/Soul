using UnityEngine;
using System.Collections;

public class Plantimover : MonoBehaviour {

	
	// Use this for initialization
	private float posx;
	private float posy;
	private float playerx;
	private float playery;
	private Vector3 enemy;
	public Animator plani;
	public GameObject ga;
	public Transform player;
	
	// Use this for initialization
	void Start () {
		
		plani = GetComponent<Animator>();
	}
	
	void Update() {
		enemy = ga.GetComponent<Transform>().transform.position;
		posx = enemy.x;
		posy = enemy.y;
		playerx= player.transform.position.x;
		playery = player.transform.position.y;
		
		
		if (posx >= playerx && posy >= playery) {
			plani.SetBool ("left", true);
		} else {
			plani.SetBool ("left", false);
		}
		
		if (posx >= playerx && posy <= playery) {
			plani.SetBool("up",true);
		}else {
			plani.SetBool ("up", false);
		}
		
		if (posx <= playerx && posy >= playery) {
			plani.SetBool("bot",true);	
		}else {
			plani.SetBool ("bot", false);
		}
		
		if (posx <= playerx && posy <= playery) {
			plani.SetBool("right",true);	
		}else {
			plani.SetBool ("right", false);
		}
		
		
	}

}
