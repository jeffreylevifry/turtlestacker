using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularTurtle : MonoBehaviour {
	Drag dScript;
	Rigidbody2D rb2d;
	CameraController camScript;
	GameManager gm;

	void Start(){
		 dScript = gameObject.GetComponent<Drag>();
		rb2d = gameObject.GetComponent<Rigidbody2D> ();
		camScript = FindObjectOfType<CameraController>();
		gm = FindObjectOfType<GameManager>();
		CheckForAccelerate ();
	}

	void Update(){

		if (transform.position.y <= -6) {
			GameObject.Find ("GameManager").SendMessage("TurtleThrough");
			camScript.AddToBelowBounds ();
			Debug.Log ("turtle below Y-6");
			Invoke("Destroy",0);

		}
	}
		
	void OnCollisionEnter2D(Collision2D col){

		//adding landed turtles to ground layer
		if (col.gameObject.layer == 10) {
			dScript.TurtleLock ();
			gameObject.layer = 10;
			camScript.checkForHighestTurt (gameObject.transform.position.y);
			gm.AddPoints (1);
		}
	
	}

	void OnTriggerEnter2D(Collider2D col){
		///turtle falling out of camera view
		if (col.gameObject.layer == 12) {
			if (gameObject.layer == 9) {
				gm.TurtleThrough ();
				camScript.AddToBelowBounds ();
				Debug.Log ("turtle out of camera view");
				Destroy ();
			}
		}
	
	
	}
	void OnTriggerStay2D(Collider2D col){
		if (col.gameObject.layer == 11) {
			if (gameObject.layer == 10) {
				Invoke ("HeavenTouch",2);
			}


		}

	}



	public void LevelEnd(){
		gameObject.SetActive (false);
	}

	void HeavenTouch(){
		GameObject.Find ("GameManager").SendMessage("HeavenReached");
		Invoke ("LevelEnd", 0);
	}


	void Destroy(){


		Destroy(gameObject);
	}
	void CheckForAccelerate(){
		float highestTurt = camScript.getHighestTurt ();

		if (highestTurt > 10) {
			rb2d.gravityScale = 0.3f;

		}

		if (highestTurt > 17) {
			rb2d.gravityScale = 0.4f;

		}
		if (highestTurt > 25) {
			rb2d.gravityScale = 0.5f;

		}

	}

}
