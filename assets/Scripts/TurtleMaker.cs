using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleMaker : MonoBehaviour
{
	int totalTurtles = 0;

	public GameObject camera_controller;
	public CameraController camScript;
	public ObjectPoolScript pool_mapturtle;
	public ObjectPoolScript pool_blandings;
	public ObjectPoolScript pool_bog;
	public ObjectPoolScript pool_mud;
	public ObjectPoolScript pool_musk;
	public ObjectPoolScript pool_painted;
	public ObjectPoolScript pool_redbelly;
	public ObjectPoolScript pool_snapping;
	public ObjectPoolScript pool_softshell;
	public ObjectPoolScript pool_spotted;
	GameObject turtle;
	Camera mainCam;
	float camYUni;
	float camCurrentOrtho;
	GameManager gm;
	ObjectPoolScript turtlePool;


	// Use this for initialization
	void Start ()
	{

		mainCam = Camera.main;
		gm = gameObject.GetComponent<GameManager> ();
		camScript = FindObjectOfType<CameraController>();

	}

	// Update is called once per frame
	void Update ()
	{


		camYUni = mainCam.transform.position.y;
		camCurrentOrtho = mainCam.orthographicSize;
	}

	public void randomPositions (int turtles, string type)
	{

		float posX = Random.Range (-2f, 2f);
		//float posX = XPositionFinder();
		float startY = camCurrentOrtho + camYUni + 3;
		float scale = Random.Range (-0.15f, 0.15f);


		UltimateTurtleCreator (turtles, type, posX, startY,scale);
	}

	public void DualTurtle (int turtles, string type1, string type2)
	{

		float posX = Random.Range (-2f, 2f);
		//float posX = XPositionFinder();
		float startY = camCurrentOrtho + camYUni + 3;
		float scale = Random.Range (-0.1f, 0.1f);


		MultiTurtleCreator (turtles, type1, type2, posX, startY,scale);
	}


	public void straightLine (int turtles, string type)
	{

		float posX = 0;
		float startY = camCurrentOrtho + camYUni + 3;
		float scale = Random.Range (-0.1f, 0.1f);

		UltimateTurtleCreator (turtles, type, posX, startY,scale);

	}




	void UltimateTurtleCreator(int turtles, string type, float posX, float startY, float scale){
		
		for (int i = 0; i < turtles; i++) {


			turtlePool = TurtDecoder (type);
			turtle = turtlePool.GetPooledObject ();
			turtle.SetActive (true);
			turtle.transform.position = new Vector3 (posX, startY, -1);

			if (Random.value > 0.5f) {
				turtle.transform.Rotate(new Vector3(0,180,0));
				//turtle.transform.localScale += new Vector3 (-1, 0, 0);
			}

			turtle.transform.localScale += new Vector3 (scale,scale,0);
			AddTurtle (1);
		}
	}

	void MultiTurtleCreator(int turtles, string type1,string type2, float posX, float startY, float scale){

		for (int i = 0; i < turtles; i++) {

			if (Random.value > 0.5f) {
				turtlePool = TurtDecoder (type1);
			} else {
				turtlePool = TurtDecoder (type2);
			}
				
			turtle = turtlePool.GetPooledObject ();
			turtle.SetActive (true);
			turtle.transform.position = new Vector3 (posX, startY, -1);

			if (Random.value > 0.5f) {
				turtle.transform.Rotate(new Vector3(0,180,0));
				//turtle.transform.localScale += new Vector3 (-1, 0, 0);
			}


			turtle.transform.localScale += new Vector3 (scale,scale,0);

			AddTurtle (1);
		}
	}
	ObjectPoolScript TurtDecoder (string type)
	{
		if (type == "red") {
			return pool_redbelly;
		}
		if (type == "map") {
			return pool_mapturtle;
		}
		if (type == "blandings") {
			return pool_blandings;
		}
		if (type == "bog") {
			return pool_bog;
		}
		if (type == "mud") {
			return pool_mud;
		}
		if (type == "musk") {
			return pool_musk;
		}
		if (type == "painted") {
			return pool_painted;
		}

		if (type == "snapping") {
			return pool_snapping;
		}
		if (type == "softshell") {
			return pool_softshell;
		}
		if (type == "spotted") {
			return pool_spotted;
		} else {
			Debug.Log ("111111111111111111111TURTLE POOL STRING ERROR11111111111111111111111111");
			return pool_snapping;
		}
	
	
	}



	public int GetTotalTurtles(){
		return totalTurtles;
	}

	public void AddTurtle (int amount)
	{

		totalTurtles = totalTurtles + amount;
		gm.addTurtles (amount);
	
	}

	public void SubtractTurtle (int amount)
	{
		totalTurtles = totalTurtles - amount;
		gm.subtractTurtles (amount);
	}

	public void zeroTotalTurtles ()
	{
		totalTurtles = 0;
		camCurrentOrtho = 5;
		gm.zeroTurtles ();
	
	}


}
