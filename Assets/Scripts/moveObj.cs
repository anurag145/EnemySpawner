using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObj : MonoBehaviour {
	 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	/*	if(transform.position.x>=3)
		{
			speed = -5;
		}else if(transform.position.x<=-3)
		{
			speed = 5;
		}
		transform.Translate (speed * Time.deltaTime, 0, 0);
		*/
}
	void OnCollisionEnter(Collision other)
	{
		Debug.Log (other.gameObject.name);
	}

}
