using UnityEngine;
using System.Collections;

public class titlescreen : MonoBehaviour {

	GameObject ga;

	void Start() {

	}

	public void onClickStartGame() {
		Application.LoadLevel ("Level1");
	}

	public void onClickExitGame() {
		Application.Quit ();
	}

	public void onClickControls() {
		//todo
	}
}
