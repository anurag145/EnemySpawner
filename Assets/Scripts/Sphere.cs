using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

	private const float SPEED =5f;

	private bool moveState; 

	private Vector3 TargetPosition; 
	private List<Vector3> list;

	void Start () {
		list=new List<Vector3>();
		moveState = true;

		/*if (list.Count != 0)
			moveState = true;
			*/
	}

	void Update () {

		if (moveState) {
			transform.position = Vector3.MoveTowards (transform.position, TargetPosition, SPEED * Time.deltaTime);
			if (transform.position == TargetPosition) {
				list.Remove (TargetPosition);
				if (list.Count == 0) {
					Destroy (this.gameObject);
				} else {
					TargetPosition = list [0];
				}					
			}
		}
	}

	public void initializePositionList(List<Vector3> list)
	{   
		/*	Debug.Log ("hello");

		list.Add (new Vector3(-4.0f,0.5f,6.0f));
		list.Add (new Vector3(4.0f,0.5f,-6.0f));
		list.Add (new Vector3(4.0f,0.5f,6.0f));

		list.Add (new Vector3(-4.0f,0.5f,-6.0f));
*/
		this.list=list;
		TargetPosition = list [0];
	}

	public void initializePositionList(Vector3 pos)
	{
		list [0] = pos;
		TargetPosition = list[0];
	}

	public void stopMovement()
	{
		moveState = false;
	}

	public void resumeMovement()
	{
		moveState = true;
	}
}