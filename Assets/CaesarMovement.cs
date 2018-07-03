using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaesarMovement : MonoBehaviour {
	float speed = 0.02f;
	bool isLeftMoving = true;

	void Start(){
		
	}

	void Update(){
		if (isLeftMoving != false && transform.position.x < -1) {
			isLeftMoving = false;
			flipRight ();
		}

		if (isLeftMoving != true && transform.position.x > 1) {
			isLeftMoving = true;
			flipLeft ();
		}

		if (isLeftMoving) {
			moveLeft ();
		} else {
			moveRight ();
		}
	}

	void flipLeft() {
		transform.localScale = new Vector3 (1, 1, 1);
		transform.Translate (1.5f, 0, 0);
	}

	void flipRight() {
		transform.localScale = new Vector3 (-1, 1, 1);
		transform.Translate (-1.5f, 0, 0);
	}

	void moveRight() {

		transform.Translate (speed, 0, 0);
	}

	void moveLeft() {
		transform.Translate (-1 * speed, 0, 0);
	}

}
	