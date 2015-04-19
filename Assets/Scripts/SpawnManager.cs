using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnManager : MonoBehaviour {

	public GameObject enemy;
	public float spawnTime = 3f;
	public int maxEnemies;
	public Transform[] spawnPoints;
	private List<GameObject> enemiesList;
	private int currentEnemies;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
		enemiesList = new List<GameObject> ();
	}

	void Spawn () {
		if (maxEnemies > currentEnemies) {
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);
			this.enemiesList.Add((GameObject)Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation));
			Debug.Log("Coco Nr. "+this.currentEnemies+" spawned somewhere!");
			this.currentEnemies++;
		}
	}

	void Update () {
		//foreach(GameObject ga in this.currentEnemies)
		//	ga.GetComponents<Scri
	}
}
