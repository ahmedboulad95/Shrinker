using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	float moveSpeed;				//Speed the sprite moves on player input
	public Text hp;

	void Update () 
	{
		HandleMovement ();
	}

	void HandleMovement()
	{
		//Get player input and move player
		float x = Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime;
		float y = Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime;

		if ((transform.position.x <= -2.542 && x < 0) || (transform.position.x >= 2.542 && x > 0))
			x = 0.0f;

		if ((transform.position.y <= -4.52 && y < 0) || (transform.position.y >= 4.52 && y > 0))
			y = 0.0f;

		transform.Translate (new Vector3 (x, y, 0));
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		//On collision with an obstacle
		if (col.gameObject.tag == "Obstacle") 
		{
			//Remove the object from the game and shrink the player by the value on the obstacle
			Destroy (col.gameObject);
			float s = (col.gameObject.GetComponent<ObstacleController> ().value / 100f) * transform.localScale.x;
			transform.localScale -= new Vector3 (s, s, 0);
			hp.text = (int.Parse(hp.text) - col.gameObject.GetComponent<ObstacleController> ().value).ToString();
		}
	}
}
