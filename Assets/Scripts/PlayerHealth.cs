using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int health;
	private SpriteRenderer healthbar1;
	private SpriteRenderer healthbar2;


	void Start () {
		healthbar1 = GameObject.Find("heart1").GetComponent<SpriteRenderer>();
		healthbar2 = GameObject.Find("heart2").GetComponent<SpriteRenderer>();

	}
	

	void Update () {
		if (health == 1) {
			Destroy(healthbar2);
		}
		if (health == 0) {
			Destroy(healthbar1);
		}
	}


}
