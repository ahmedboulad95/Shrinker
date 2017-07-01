using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleContainer : MonoBehaviour {

	[SerializeField]
	float moveSpeed = -3f;

	void Update () 
	{
		transform.Translate(new Vector3(0, moveSpeed * Time.deltaTime, 0));
	}
}
