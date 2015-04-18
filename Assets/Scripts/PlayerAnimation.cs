using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.A)) {
						anim.SetBool ("Left", true);
						anim.SetBool ("Down", false);
						anim.SetBool ("Up", false);
						anim.SetBool ("Right", false);
				} else {
			anim.SetBool ("Left", false);
				}

		if (Input.GetKey (KeyCode.D)) {
						anim.SetBool ("Right", true);
						anim.SetBool ("Left", false);
						anim.SetBool ("Down", false);
						anim.SetBool ("Up", false);
				}
		else {
			anim.SetBool ("Right", false);
		}
		if (Input.GetKey (KeyCode.W)) {
						anim.SetBool ("Up", true);
						anim.SetBool ("Left", false);
						anim.SetBool ("Right", false);
						anim.SetBool ("Down", false);
		}else {
			anim.SetBool ("Up", false);
		}

			if (Input.GetKey (KeyCode.S)) {
						anim.SetBool ("Down", true);
						anim.SetBool ("Left", false);
						anim.SetBool ("Right", false);
						anim.SetBool ("Up", false);
		} else {
			anim.SetBool ("Down", false);
		}

	}


}
