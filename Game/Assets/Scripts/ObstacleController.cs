using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour {

	public int value;
	public GameObject text;
	Color[] colors = { Color.green, Color.yellow, Color.red };

	void Start () 
	{
		//Set value on object to a random number between 1 and 50
		value = Random.Range (1, 30);
		text.GetComponent<TextMesh> ().text = value.ToString ();

		//Set random color for obstacle
		int colorIndex;
		if (value <= 10)
			colorIndex = 0;
		else if (value > 10 && value <= 20)
			colorIndex = 1;
		else
			colorIndex = 2;

		GetComponent<SpriteRenderer> ().color = colors [colorIndex];
	}
}
