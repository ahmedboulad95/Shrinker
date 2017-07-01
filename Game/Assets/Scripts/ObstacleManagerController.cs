using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManagerController : MonoBehaviour {

	const int NUM_SPAWN_POINTS = 4;
	public GameObject[] spawnPoints = new GameObject[4];
	public GameObject obstacle;

	float delayTime = 1.5f;
	float timer;

	void Start () 
	{
		timer = delayTime;
		for (int i = 0; i < NUM_SPAWN_POINTS; i++) 
		{
			spawnPoints [i] = GameObject.Find ("SpawnPoint" + (i+1));
		}
	}

	void Update () 
	{
		timer -= Time.deltaTime;

		if (timer <= 0) 
		{
			GameObject newObstacle = new GameObject ();
			newObstacle.transform.position = new Vector3 (0, 7, 0);
			newObstacle.AddComponent<ObstacleContainer> ();

			foreach (GameObject sp in spawnPoints) 
			{
				int spawn = Random.Range (0, 3);
				if (spawn > 0) 
				{
					Instantiate (obstacle, sp.transform.position, transform.rotation, newObstacle.transform);
				}
			}
			timer = delayTime;
		}
	}
}


