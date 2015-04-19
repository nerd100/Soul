using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	public GameObject enemy;
	public float spawnTime = 3f;
	public int maxEnemies;
	public Transform[] spawnPoints;
	private int currentEnemies;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Spawn () {
		if (maxEnemies > currentEnemies) {
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);
			Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
			Debug.Log("Coco Nr. "+this.currentEnemies+" spawned somewhere!");
			this.currentEnemies++;
		}
	}
}
