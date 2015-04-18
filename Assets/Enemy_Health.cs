using UnityEngine;
using System.Collections;

public class Enemy_Health : MonoBehaviour {

	
	public int health;
	private SpriteRenderer Enemy;

	void Start () {
		Enemy = GameObject.Find("Coco").GetComponent<SpriteRenderer>();
	}

	
	
	void Update () {

		if (health == 0) {
			Destroy(Enemy);
		}
	}

}
