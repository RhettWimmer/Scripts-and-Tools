using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour {
	// public float moveSpeed;
	// public float turnSpeed;
	// public float jumpHeight;

	/* public float transX;
	public float transY;
	public float transZ;

	public float rotX;
	public float rotY;
	public float rotZ; */

		public Vector3 move;
		public Vector3 rotate;
		public float moveSpeed;
		

/*
	public int number = 10;
	private float percent = 0.25f;
	private double cheeseBurger = 0.5;
	public string firstName;
*/

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	 void Update () {
		//  var j = Input.GetAxis("Jump")*Time.deltaTime * jumpHeight;
		//  var y = Input.GetAxis("Horizontal")*Time.deltaTime * turnSpeed;
		//  var z = Input.GetAxis("Vertical")*Time.deltaTime * moveSpeed;

		//  transform.Rotate(0,y,0);
		//  transform.Translate(0,0,z);
		//  transform.Translate(0,j,0);


		 if(Input.GetKey(KeyCode.W)){
			 transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		 }

		 if(Input.GetKey(KeyCode.S)){
			 transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
		 }
		if(Input.GetKey(KeyCode.A)){
			 transform.Translate(Vector3.left*moveSpeed*Time.deltaTime);
		 }

		 if(Input.GetKey(KeyCode.D)){
			 transform.Translate(Vector3.right*moveSpeed*Time.deltaTime);
		 }

		 


		/*transform.Translate(transX, transY, transZ);
		transform.Rotate(rotX, rotY, transZ); */

	// transform.Translate(move * Time.deltaTime);
	// transform.Rotate(rotate * Time.deltaTime);
	}
}
