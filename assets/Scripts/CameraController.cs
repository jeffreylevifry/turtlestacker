using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
	Camera mainCam;
	public GameObject cam;
	public GameObject camBounds;
	Vector3 moveUp;
	public bool threeTurtlesInPlay = false;
	float topCamBound;
	float bottomCamBound;
	float bottomCamBoundOffset;
	float highestGroundTurt;
	int zoomRotation;
	bool camJustMoved = false;
	int totalTurtles;
	GameManager gm;
	int belowCameraCounter;
	public Text OutOfBoundsCounter;

	void Start ()
	{
		mainCam = Camera.main;
		gm = FindObjectOfType<GameManager>();


	}

	void Update ()
	{
		topCamBound = mainCam.orthographicSize + mainCam.transform.position.y;
		bottomCamBound = mainCam.transform.position.y - (mainCam.orthographicSize/2);
		bottomCamBoundOffset = bottomCamBound - mainCam.orthographicSize + 2;
		camBounds.transform.position = new Vector3 (0, bottomCamBoundOffset, -1);
	}

	public void AddToBelowBounds(){
		belowCameraCounter = belowCameraCounter + 1;
		UpdateOutOfBoundsText (belowCameraCounter);
		CheckForGameOver ();
	
	}

	public void moveCamera (float plusY, float time)
	{
		
		float camX = mainCam.transform.position.x;
		float camZ = mainCam.transform.position.z;
		float camYPlus = mainCam.transform.position.y + plusY;

		Vector3 moveUp = new Vector3 (camX, camYPlus, camZ);
		iTween.MoveTo (cam, moveUp, time);

	}

	public void zoomCameraOut (float zoomOutAmount, float zoomOutTime)
	{int zoomAllowed = totalZoomAllowed ();
		float totalZoom = Camera.main.orthographicSize + zoomOutAmount;
		if(totalZoom <zoomAllowed){
		iTween.ValueTo (Camera.main.gameObject, iTween.Hash ("from", Camera.main.orthographicSize,
			"to", (Camera.main.orthographicSize + zoomOutAmount),
			"time", zoomOutTime,
			"easetype", iTween.EaseType.linear,
			"onupdate", "UpdateOrthographicCameraSize",
			"onupdatetarget", Camera.main.gameObject));
	}
	}

	public void checkForHighestTurt(float incomingY){
		zoomRotation++;
	
		Debug.Log ("incomingY="+incomingY);
		if (incomingY > bottomCamBoundOffset) {
			if (belowCameraCounter > 0) {
				belowCameraCounter = belowCameraCounter - 1;

			}
		}
		if(incomingY>highestGroundTurt){
			gm.AddPoints (2);
			if (belowCameraCounter > 0) {
				belowCameraCounter = belowCameraCounter - 1;
				if (belowCameraCounter > 0) {
					belowCameraCounter = belowCameraCounter - 1;
				}
			}
			highestGroundTurt = incomingY;

			if (zoomRotation > 2) {
				zoomCameraOut (1, 2);
				zoomRotation = 0;

			} 
		if(highestGroundTurt>mainCam.transform.position.y-1&&camJustMoved==false) {
				float moveAmount = 2+highestGroundTurt - mainCam.transform.position.y;
				moveCamera (moveAmount, 2);


				camJustMoved = true;
				StartCoroutine ("cameraMoved");
			
			} 
		}

		UpdateOutOfBoundsText (belowCameraCounter);
	}
		

	IEnumerator cameraMoved() {
		yield return new WaitForSeconds(2f);
		camJustMoved = false;

	}	

	public float getHighestTurt(){
		return highestGroundTurt;
	}

	void UpdateOrthographicCameraSize (float size)
	{
		Camera.main.orthographicSize = size;
	}

	public void ResetCamera(){
		Vector3 reset = new Vector3 (0, 0, -10);
		iTween.MoveTo (cam, reset, 0);
		mainCam.orthographicSize = 5;
		highestGroundTurt = 0;
		belowCameraCounter = 0;
		UpdateOutOfBoundsText (belowCameraCounter);
	}

	void UpdateOutOfBoundsText(int amount){
		OutOfBoundsCounter.text = "" + amount.ToString ();
	
	}

	void CheckForGameOver(){
		if ( belowCameraCounter > turtlesAllowedBelowCamCounter()) {

			belowCameraCounter = 0;
			gm.GameOver ();

		}
	
	}

	int turtlesAllowedBelowCamCounter(){
		int currentLevel = PlayerPrefs.GetInt ("currentLevel");
		if (currentLevel == 1) {
			return 4;
		}
		int earlyLevel = Mathf.RoundToInt((currentLevel * 3) * 0.6f);

		if (earlyLevel < 15) {
			return earlyLevel;
		} else {
			return 15;
		
		}
	
	}

	int totalZoomAllowed(){
		int totalTurtles = gm.GetTotalTurtles ();

		if (totalTurtles >=3&&totalTurtles<=7){
			return 7;
		}
		if (totalTurtles >=7&&totalTurtles<=11){
			return 8;
		}else {
			return 6;
			}

	
	}


}
