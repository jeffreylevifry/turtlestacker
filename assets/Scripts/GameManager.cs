using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	int totalTurtles;
	float camYUni;
	float camCurrentOrtho;
	int score = 0;
	int points = 0;
	public Text t_lives;
	public Text t_points;
	public ObjectPoolScript pool_mapturtle;
	public ObjectPoolScript pool_painted;
	CameraController camera_controller;
	Camera mainCam;
	TurtleMaker tmaker;
	LevelManager level_manager;
	bool heavenReached = false;
	public GameObject ground;
	public GameObject GameOverText;
	private DataController dataController;
	public GameObject LevelScreenObject;
	LevelScreenScript LvlScreenScript;


	// Use this for initialization
	void Start ()
	{

		PlayerPrefs.DeleteAll ();

		mainCam = Camera.main;
		camera_controller = FindObjectOfType<CameraController> ();
		tmaker = gameObject.GetComponent<TurtleMaker> ();
		level_manager = gameObject.GetComponent<LevelManager> ();
		dataController = FindObjectOfType<DataController>();
		LvlScreenScript =LevelScreenObject.GetComponent<LevelScreenScript>();


		level_manager.startLevel ();

	}
	
	// Update is called once per frame
	void Update ()
	{

		camYUni = Camera.main.transform.position.y;
		camCurrentOrtho = Camera.main.orthographicSize;


	}


	void HeavenReached ()
	{
		if (heavenReached == false) {
			CancelInvoke ();
			LevelScreenObject.SetActive (true);
			camera_controller.ResetCamera ();
			LvlScreenScript.SetPoints ();
			level_manager.setupNextLevel ();
			heavenReached = true;
		}

	}

	public void AddPoints(int amount){
		points = points + 1;
		t_points.text = "" + points.ToString ();
		dataController.SubmitNewPlayerScore (points);

	
	}
	public void ResetPoints(){
		points = 0;
		t_points.text = "" + points.ToString ();

	}
	public void GameOver ()
	{
		GameOverText.SetActive (true);
	}

	public void Restart ()
	{
		level_manager.setupRestart ();
		startLevelThru ();
		StartCoroutine ("RestartMenuCoroutine");

	
	}

	IEnumerator RestartMenuCoroutine ()
	{
		yield return new WaitForSeconds (0.25f);

		GameOverText.SetActive (false);

	}

	public void TurtleThrough ()
	{
		tmaker.SubtractTurtle (1);
	
	}


	public void addTurtles (int amount)
	{
		totalTurtles = totalTurtles + amount;
	
	}

	public void subtractTurtles (int amount)
	{
		totalTurtles = totalTurtles - amount;
	}

	public void zeroTurtles ()
	{
		totalTurtles = 0;
	
	}




	public void startLevelThru ()
	{
		

		level_manager.startLevel ();
		heavenReached = false;
		camera_controller.ResetCamera ();
		float highTurt = camera_controller.getHighestTurt ();
	

	
	}

	public int GetPoints(){
	
		return points;
	}

	public int GetTotalTurtles(){
		return totalTurtles;
	
	}

}
