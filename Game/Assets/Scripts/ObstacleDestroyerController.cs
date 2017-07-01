using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyerController : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col)
	{
		Destroy (col.transform.parent.gameObject);
	}
}
