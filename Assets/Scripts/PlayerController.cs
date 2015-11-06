using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int speed;
	bool powerup;

	// Use this for initialization
	void Start () {
		powerup = false;
	}
	
	// Update is called once per frame
	void Update () {
		playerMovement ();
	}

	void playerMovement() {

		// move left
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * speed * Time.deltaTime);
		}
		// move right
		else if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * speed * Time.deltaTime);
		}

		// move up
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.up * speed * Time.deltaTime);
		}
		// move down
		else if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.down * speed * Time.deltaTime);
		}
	}

	void shoot() {
		// shoot bullets
		if (Input.GetKey (KeyCode.Space)) {

		}
	}
}
