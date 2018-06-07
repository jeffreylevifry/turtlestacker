using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
	TurtleMaker tmaker;
	RegularTurtle rTurtScript;
	GameManager gm;
	Camera mainCam;
	public GameObject Heaven;

	public GameObject lscreen;
	public GameObject lvl1Graphics;
	public GameObject lvl2Graphics;
	public GameObject lvl3Graphics;
	public GameObject lvl4Graphics;
	public GameObject lvl5Graphics;
	public GameObject lvl6Graphics;
	public GameObject lvl7Graphics;
	public GameObject lvl8Graphics;
	public GameObject lvl9Graphics;
	public GameObject lvl10Graphics;
	public GameObject lvl11Graphics;
	public GameObject lvl12Graphics;
	public GameObject lvl13Graphics;
	public GameObject lvl14Graphics;
	public GameObject lvl15Graphics;
	public GameObject lvl16Graphics;
	public GameObject lvl17Graphics;
	public GameObject lvl18Graphics;
	public GameObject lvl19Graphics;
	public GameObject lvl20Graphics;
	/*
	public GameObject lvl21Graphics;
	public GameObject lvl22Graphics;
	public GameObject lvl23Graphics;
	public GameObject lvl24Graphics;
	public GameObject lvl25Graphics;
	public GameObject lvl26Graphics;
	public GameObject lvl27Graphics;
	public GameObject lvl28Graphics;
	*/

	int currentLevel;

	// Use this for initialization
	void Start ()
	{

		mainCam = Camera.main;
		tmaker = gameObject.GetComponent<TurtleMaker> ();
		gm = gameObject.GetComponent<GameManager> ();
	}

	public void startLevel ()
	{

		currentLevel = PlayerPrefs.GetInt ("currentLevel", 1);
		PlayerPrefs.SetInt ("currentLevel", currentLevel);	
		string coroutine = "Level" + (currentLevel.ToString ());
		StartCoroutine (coroutine);
	
	}



	IEnumerator Level1 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator Level2 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "painted", "spotted");
			yield return new WaitForSeconds (1.8f);
		}
	}

	IEnumerator Level3 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "painted", "bog");
			yield return new WaitForSeconds (1.7f);
		}
	}

	IEnumerator Level4 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.DualTurtle (1, "spotted", "bog");

			yield return new WaitForSeconds (1.6f);
		}
	}

	IEnumerator Level5 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "softshell", "spotted");
			yield return new WaitForSeconds (1.5f);
		}
	}

	IEnumerator Level6 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "softshell", "spotted");
			yield return new WaitForSeconds (1.4f);
		}
	}

	IEnumerator Level7 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.DualTurtle (1, "softshell", "spotted");

			yield return new WaitForSeconds (1.4f);
		}
	}

	IEnumerator Level8 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "softshell", "spotted");
			yield return new WaitForSeconds (1.3f);
		}
	}

	IEnumerator Level9 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "softshell", "spotted");
			yield return new WaitForSeconds (1.2f);
		}
	}

	IEnumerator Level10 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (1.2f);
		}
	}

	IEnumerator Level11 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (1.2f);
		}
	}

	IEnumerator Level12 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "softshell", "spotted");
			yield return new WaitForSeconds (1f);
		}
	}

	IEnumerator Level13 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "bog", "wood");
			yield return new WaitForSeconds (1f);
		}
	}

	IEnumerator Level14 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (1f);
		}
	}

	IEnumerator Level15 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "softshell", "spotted");
			yield return new WaitForSeconds (0.9f);
		}
	}

	IEnumerator Level16 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "bog", "wood");
			yield return new WaitForSeconds (0.9f);
		}
	}

	IEnumerator Level17 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (0.9f);
		}
	}

	IEnumerator Level18 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "softshell", "spotted");
			yield return new WaitForSeconds (0.9f);
		}
	}

	IEnumerator Level19 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "bog", "wood");
			yield return new WaitForSeconds (0.9f);
		}
	}

	IEnumerator Level20 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (0.8f);
		}
	}

	IEnumerator Level21 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (0.8f);
		}
	}

	IEnumerator Level22 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "softshell", "spotted");
			yield return new WaitForSeconds (1.1f);
		}
	}

	IEnumerator Level23 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "bog", "wood");
			yield return new WaitForSeconds (1.1f);
		}
	}

	IEnumerator Level24 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (1.1f);
		}
	}

	IEnumerator Level25 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "softshell", "spotted");
			yield return new WaitForSeconds (1f);
		}
	}

	IEnumerator Level26 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "bog", "wood");
			yield return new WaitForSeconds (1f);
		}
	}

	IEnumerator Level27 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator Level28 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "softshell", "spotted");
			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator Level29 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "bog", "wood");
			yield return new WaitForSeconds (1f);
		}
	}

	IEnumerator Level30 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator Level31 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator Level32 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "softshell", "spotted");
			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator Level33 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "bog", "wood");
			yield return new WaitForSeconds (1f);
		}
	}

	IEnumerator Level34 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator Level35 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "softshell", "spotted");
			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator Level36 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "bog", "wood");
			yield return new WaitForSeconds (1f);
		}
	}

	IEnumerator Level37 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator Level38 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "softshell", "spotted");
			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator Level39 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "bog", "wood");
			yield return new WaitForSeconds (1f);
		}
	}

	IEnumerator Level40 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator Level41 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator Level42 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "softshell", "spotted");
			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator Level43 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "bog", "wood");
			yield return new WaitForSeconds (1f);
		}
	}

	IEnumerator Level44 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator Level45 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "softshell", "spotted");
			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator Level46 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "bog", "wood");
			yield return new WaitForSeconds (1f);
		}
	}

	IEnumerator Level47 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator Level48 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "softshell", "spotted");
			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator Level49 ()
	{
		yield return new WaitForSeconds (1f);

		while (true) {
			tmaker.DualTurtle (1, "bog", "wood");
			yield return new WaitForSeconds (1f);
		}
	}

	IEnumerator Level50 ()
	{
		yield return new WaitForSeconds (0.7f);

		while (true) {
			tmaker.randomPositions (1, "painted");

			yield return new WaitForSeconds (2f);
		}
	}

	void MoveHeaven ()
	{
		float HeavenMoveY = Heaven.transform.position.y + 5;
		float HeavenMoveX = Heaven.transform.position.x;
		float HeavenMoveZ = Heaven.transform.position.z;
		Vector3 moveHeaven = new Vector3 (HeavenMoveX, HeavenMoveY, HeavenMoveZ);
		Heaven.transform.position = moveHeaven;
		
	}



	public void setupRestart ()
	{
		currentLevel = PlayerPrefs.GetInt ("currentLevel");
		string coroutine = "Level" + (currentLevel.ToString ());
		StopCoroutine (coroutine);
		PlayerPrefs.SetInt ("currentLevel", 1);
		tmaker.zeroTotalTurtles ();
		DestroyAllTurts ();
		DeactivateBackgroundGraphics ();
		gm.ResetPoints ();
		Vector3 heavenRestart = new Vector3 (-3, 7, 1);
		Heaven.transform.position = heavenRestart;

		lvl1Graphics.SetActive (true);
	}

	void DestroyAllTurts ()
	{

		GameObject[] Selected;

		Selected = GameObject.FindGameObjectsWithTag ("Turtle");

		for (var i = 0; i < Selected.Length; i++) {
			Destroy (Selected [i]);
		}

	}

	void DeactivateBackgroundGraphics ()
	{

		GameObject[] Selected;

		Selected = GameObject.FindGameObjectsWithTag ("Background");

		for (var i = 0; i < Selected.Length; i++) {
			(Selected [i]).SetActive(false);
		}

	}


	public void setupNextLevel ()
	{
		currentLevel = PlayerPrefs.GetInt ("currentLevel");
		string coroutine = "Level" + (currentLevel.ToString ());
		StopCoroutine (coroutine);

		int newLevel = PlayerPrefs.GetInt ("currentLevel") + 1;
		PlayerPrefs.SetInt ("currentLevel", newLevel);
		tmaker.zeroTotalTurtles ();
		DestroyAllTurts ();
		MoveHeaven ();

		if (newLevel == 2) {
			lvl1Graphics.SetActive (false);
			lvl2Graphics.SetActive (true);
		}
		if (newLevel == 3) {
			lvl2Graphics.SetActive (false);
			lvl3Graphics.SetActive (true);
		}
		if (newLevel == 4) {
			lvl3Graphics.SetActive (false);
			lvl4Graphics.SetActive (true);
		}
		if (newLevel == 5) {
			lvl4Graphics.SetActive (false);
			lvl5Graphics.SetActive (true);
		}
		if (newLevel == 6) {
			lvl5Graphics.SetActive (false);
			lvl6Graphics.SetActive (true);
		}
		if (newLevel == 7) {
			lvl6Graphics.SetActive (false);
			lvl7Graphics.SetActive (true);
		}
		if (newLevel == 8) {
			lvl7Graphics.SetActive (false);
			lvl8Graphics.SetActive (true);
		}
		if (newLevel == 9) {
			lvl8Graphics.SetActive (false);
			lvl9Graphics.SetActive (true);
		}
		if (newLevel == 10) {
			lvl9Graphics.SetActive (false);
			lvl10Graphics.SetActive (true);
		}
		if (newLevel == 11) {
			lvl10Graphics.SetActive (false);
			lvl11Graphics.SetActive (true);
		}
		if (newLevel == 12) {
			lvl11Graphics.SetActive (false);
			lvl12Graphics.SetActive (true);
		}
		if (newLevel == 13) {
			lvl12Graphics.SetActive (false);
			lvl13Graphics.SetActive (true);
		}
		if (newLevel == 14) {
			lvl13Graphics.SetActive (false);
			lvl14Graphics.SetActive (true);
		}
		if (newLevel == 15) {
			lvl14Graphics.SetActive (false);
			lvl15Graphics.SetActive (true);
		}
		if (newLevel == 16) {
			lvl15Graphics.SetActive (false);
			lvl16Graphics.SetActive (true);
		}
		if (newLevel == 17) {
			lvl16Graphics.SetActive (false);
			lvl17Graphics.SetActive (true);
		}
		if (newLevel == 18) {
			lvl17Graphics.SetActive (false);
			lvl18Graphics.SetActive (true);
		}
		if (newLevel == 19) {
			lvl18Graphics.SetActive (false);
			lvl19Graphics.SetActive (true);
		}
		if (newLevel == 20) {
			lvl19Graphics.SetActive (false);
			lvl20Graphics.SetActive (true);
		}
		if (newLevel == 21) {
			gm.GameOver ();
			//lvl20Graphics.SetActive (false);
			//lvl21Graphics.SetActive (true);
		}
		if (newLevel == 22) {
			lvl3Graphics.SetActive (false);
			lvl4Graphics.SetActive (true);
		}
		if (newLevel == 23) {
			lvl4Graphics.SetActive (false);
			lvl5Graphics.SetActive (true);
		}
		if (newLevel == 24) {
			lvl5Graphics.SetActive (false);
			lvl6Graphics.SetActive (true);
		}
		if (newLevel == 25) {
			lvl6Graphics.SetActive (false);
			lvl7Graphics.SetActive (true);
		}
		if (newLevel == 26) {
			lvl7Graphics.SetActive (false);
			lvl8Graphics.SetActive (true);
		}
		if (newLevel == 27) {
			lvl8Graphics.SetActive (false);
			lvl9Graphics.SetActive (true);
		}
		if (newLevel == 28) {
			lvl9Graphics.SetActive (false);
			lvl10Graphics.SetActive (true);
		}
		if (newLevel == 29) {
			lvl10Graphics.SetActive (false);
			lvl11Graphics.SetActive (true);
		}
		if (newLevel == 30) {
			lvl11Graphics.SetActive (false);
			lvl12Graphics.SetActive (true);
		}
		if (newLevel == 31) {
			lvl12Graphics.SetActive (false);
			lvl13Graphics.SetActive (true);
		}
		if (newLevel == 32) {
			lvl13Graphics.SetActive (false);
			lvl14Graphics.SetActive (true);
		}
		if (newLevel == 33) {
			lvl14Graphics.SetActive (false);
			lvl15Graphics.SetActive (true);
		}
		if (newLevel == 34) {
			lvl15Graphics.SetActive (false);
			lvl16Graphics.SetActive (true);
		}
		if (newLevel == 35) {
			lvl16Graphics.SetActive (false);
			lvl17Graphics.SetActive (true);
		}
		if (newLevel == 36) {
			lvl17Graphics.SetActive (false);
			lvl18Graphics.SetActive (true);
		}
		if (newLevel == 37) {
			lvl18Graphics.SetActive (false);
			lvl19Graphics.SetActive (true);
		}

	}
}

