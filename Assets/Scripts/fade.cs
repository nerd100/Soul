using UnityEngine;
using System.Collections;

public class fade : MonoBehaviour {

	public GameObject ga;
	public string nextScene;
	AudioSource wizz;
	float fademax = 1f;
	float fademin = 0f;
	bool played = false;

	float fadeduration = 2f;
	private float starttime; 

	// Use this for initialization
	void Start () {
		this.starttime = Time.time;
		this.wizz = ga.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		var t = (Time.time - this.starttime) / this.fadeduration;
		SpriteRenderer sr = ga.GetComponent<SpriteRenderer>();
		sr.color = new Color (1f, 1f, 1f, Mathf.SmoothStep(this.fademin,this.fademax, t));
		if (sr.color.a == 1f && !played) {
			this.wizz.Play ();
			played = true;
			this.fademax = 0f;
			this.fademin = 1f;
			this.starttime = Time.time;
			this.fadeduration = 7f;
		}
		if (played && sr.color.a == 0f)
			Application.LoadLevel(nextScene);
	}
}
