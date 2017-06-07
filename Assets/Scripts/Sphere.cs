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
		initializePositionList ();

		TargetPosition = list [Random.Range (0, list.Count)];
	}

	void Update () {

		if (moveState) 
			transform.position = Vector3.MoveTowards (transform.position, TargetPosition, SPEED * Time.deltaTime);
							
					
			}

	public void initializePositionList()//List<Vector3> list)
	{   
		

		list.Add (new Vector3(-4.0f,0.5f,6.0f));
		list.Add (new Vector3(4.0f,0.5f,-6.0f));
		list.Add (new Vector3(4.0f,0.5f,6.0f));

		list.Add (new Vector3(-4.0f,0.5f,-6.0f));
		/*
		this.list=list;
		TargetPosition = list [0];
*/               

}
	void OnCollisionEnter(Collision other)
	{ 	Vector3 vector = list [Random.Range (0, list.Count )];
			while(vector==TargetPosition)
			{
				vector = list [Random.Range (0, list.Count)];
			}

			TargetPosition = vector;

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