using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class LevelScreenScript : MonoBehaviour {


	public GameObject gm;
	public GameObject LevelScreenObj;
	public Text t_points;
	bool ClickActive = false;

	void Start(){


	}



	public void SetPoints(){
		int points = gm.GetComponent<GameManager>().GetPoints ();
		t_points.text =  "Score: " + points.ToString ();
		StartCoroutine ("ActivateClick");

	}


	public void DismissOnClick()
	{
		if (ClickActive == true) {
			StartCoroutine ("HideScreen");
			ClickActive = false;
			gm.GetComponent<GameManager> ().startLevelThru ();
		}


	}

	IEnumerator HideScreen ()
	{
		yield return new WaitForSeconds (0.15f);
		LevelScreenObj.SetActive (false);
		
	}
	IEnumerator ActivateClick ()
	{
		yield return new WaitForSeconds (1.0f);
		ClickActive = true;

	}
}
