using UnityEngine;
using System.Collections;

public class Transformation : MonoBehaviour {

	public Transform posplayer;
	public Transform possword;
	int roty = 0;
	public Animator ani;


	//Vector3 rotplayer=new Vector3(0,0,0);
	// Use this for initialization
	void Start () {
		ani = GetComponent<Animator>();
	}


	void Update(){

		if (Input.GetKey (KeyCode.G)) {
			ani.SetBool ("combat", true);
		} else {
			ani.SetBool ("combat", false);
		}
	}
	void FixedUpdate(){
		Vector3 transplayer=new Vector3(0,0,0);
		Vector3 transsword=new Vector3(0,0,0);
		
		transplayer = posplayer.transform.position;
		transsword = possword.transform.position;
		
	




		//rotplayer = posplayer.rotation.eulerAngles;
		//		Debug.Log (transplayer + "_" + rotplayer);
		if (Input.GetKey (KeyCode.D)) {
			transsword.x = transplayer.x + 0.137f;
			transsword.y = transplayer.y;
			roty = 180;
		}
		if (Input.GetKey (KeyCode.A)) {
			transsword.x = transplayer.x - 0.116f;
			transsword.y = transplayer.y;
			roty = 0;
		}
		if (Input.GetKey (KeyCode.W)) {
			transsword.x = transplayer.x + 0.115f;
			transsword.y = transplayer.y;
			roty = 180;
		}
		if (Input.GetKey (KeyCode.S)) {
			transsword.x = transplayer.x - 0.129f;
			transsword.y = transplayer.y;
			roty = 0;
		}
		
		
	
		possword.transform.position=transsword;
		possword.transform.rotation = new Quaternion(transform.rotation.x,roty,transform.rotation.z,transform.rotation.w);
	}

}


