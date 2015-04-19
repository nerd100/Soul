using UnityEngine;
using System.Collections;

public class cocomover : MonoBehaviour {

	// Use this for initialization
	private float posx;
	private float posy;

	private Vector3 enemy;
	public Animator coani;
	public GameObject ga;
	
	// Use this for initialization
	void Start () {

		coani = GetComponent<Animator>();
	}

	void Update() {
		enemy = ga.GetComponent<Transform>().transform.position;
		posx = enemy.x;
		posy = enemy.y;


		if (posx >= 0 && posy >= 0) {
			coani.SetBool ("right", true);
		} else {
			coani.SetBool ("right", false);
		}

		if (posx >= 0 && posy < 0) {
			coani.SetBool("bot",true);
		}else {
			coani.SetBool ("bot", false);
		}

		if (posx <= 0 && posy > 0) {
			coani.SetBool("up",true);	
		}else {
			coani.SetBool ("up", false);
		}

		if (posx < 0 && posy <= 0) {
			coani.SetBool("left",true);	
		}else {
			coani.SetBool ("left", false);
		}


	}

}
