using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
	public Rigidbody projectile; //this adds rigidbody, which is gravity
	public Transform shootPoint; //movement
	public int shootSpeed; //fire speed

	void Update () {
		if(Input.GetButtonDown("Fire1")){

			Rigidbody clone;
			clone = (Rigidbody)Instantiate(projectile, shootPoint.position, projectile.rotation); //instantiate creates a game object
			clone.velocity = shootPoint.TransformDirection (Vector3.forward*shootSpeed*Time.deltaTime); 
			// ^^^ this allows differences in directions between things
		}
	}
}
