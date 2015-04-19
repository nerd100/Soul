using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int health;
	private SpriteRenderer healthbar1;
	private SpriteRenderer healthbar2;
	private float hitTime;
	public Material Default;
	public Material Hit;
	public int dmg;



	void Start () {
		healthbar1 = GameObject.Find("heart1").GetComponent<SpriteRenderer>();
		healthbar2 = GameObject.Find("heart2").GetComponent<SpriteRenderer>();

	}
	

	void Update () {
		dmg = 0;

		if (hitTime + 0.1f < Time.time) {

			GetComponent<SpriteRenderer>().material = Default;
		}
	}

	void OnCollisionEnter2D ( Collision2D Enemyhit){
		if (Enemyhit.gameObject.tag == "Coco") {
			dmg = 1;
			if(hitTime + 0.5f < Time.time){
			hitTime = Time.time;
			health -= dmg;

			Enemyhit.gameObject.GetComponent<AI1>().makeDamage(1);
			//Debug.Log (s.healthpoints);
			GetComponent<SpriteRenderer>().material = Hit;

			float verticalPush = Enemyhit.gameObject.transform.position.y - transform.position.y;
			float horizontalPush = Enemyhit.gameObject.transform.position.x - transform.position.x;

			GetComponent<Rigidbody2D>().AddForce( new Vector2 (-horizontalPush,-verticalPush)*1000);
			}
		}
		if (Enemyhit.gameObject.tag == "Planti") {
				dmg = 1;
			if(hitTime + 0.5f < Time.time){
				hitTime = Time.time;
				health -= dmg;
				dmg += 1;
				
				Enemyhit.gameObject.GetComponent<AI1>().makeDamage(1);
				//Debug.Log (s.healthpoints);
				GetComponent<SpriteRenderer>().material = Hit;
				
				float verticalPush = Enemyhit.gameObject.transform.position.y - transform.position.y;
				float horizontalPush = Enemyhit.gameObject.transform.position.x - transform.position.x;
				
				GetComponent<Rigidbody2D>().AddForce( new Vector2 (-horizontalPush,-verticalPush)*1000);
			}
		}
		if (Enemyhit.gameObject.tag == "Golem") {
				dmg = 2;
			if(hitTime + 0.5f < Time.time){
				hitTime = Time.time;
				health -= dmg;

				
				Enemyhit.gameObject.GetComponent<AI1>().makeDamage(1);
				//Debug.Log (s.healthpoints);
				GetComponent<SpriteRenderer>().material = Hit;
				
				float verticalPush = Enemyhit.gameObject.transform.position.y - transform.position.y;
				float horizontalPush = Enemyhit.gameObject.transform.position.x - transform.position.x;
				
				GetComponent<Rigidbody2D>().AddForce( new Vector2 (-horizontalPush,-verticalPush)*1000);
			}
		}
		if (health <= 0) {
			Destroy(healthbar2);
			Destroy(healthbar1);

		}
		if (health == 1) {
			Destroy(healthbar2);
		}
	}

}
