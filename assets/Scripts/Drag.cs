using UnityEngine;
using System.Collections;

[RequireComponent (typeof(BoxCollider2D))]

public class Drag : MonoBehaviour
{
	private Vector3 screenPoint;
	private Vector3 offset;
	bool turtleLock = false;


	void OnMouseDown ()
	{

		if (turtleLock == false) {
			offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		}
	}

	void OnMouseDrag ()
	{
		if (turtleLock == false) {
			Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
			Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
			transform.position = curPosition;
		}
	}


	public void TurtleLock ()
	{
		turtleLock = true;
	}



}