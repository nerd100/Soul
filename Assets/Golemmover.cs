using UnityEngine;
using System.Collections;

public class Golemmover : MonoBehaviour {

	// Use this for initialization
	private float posx;
	private float posy;
	private float playerx;
	private float playery;
	private Vector3 enemy;
	public Animator goli;
	public GameObject ga;
	public Transform player;
	
	// Use this for initialization
	void Start () {
		
		goli = GetComponent<Animator>();
	}
	
	void Update() {
		enemy = ga.GetComponent<Transform>().transform.position;
		posx = enemy.x;
		posy = enemy.y;
		playerx= player.transform.position.x;
		playery = player.transform.position.y;
		
		
		if (posx >= playerx && posy >= playery) {
			goli.SetBool ("left", true);
		} else {
			goli.SetBool ("left", false);
		}
		
		if (posx >= playerx && posy <= playery) {
			goli.SetBool("up",true);
		}else {
			goli.SetBool ("up", false);
		}
		
		if (posx <= playerx && posy >= playery) {
			goli.SetBool("bot",true);	
		}else {
			goli.SetBool ("bot", false);
		}
		
		if (posx <= playerx && posy <= playery) {
			goli.SetBool("right",true);	
		}else {
			goli.SetBool ("right", false);
		}
		
		
	}
}
