using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {
	public float moveSpeed;
	public Transform target;
	public Transform chickenPen;
	public int points;


	void OnTriggerStay(Collider other){
		if(other.gameObject.name == "Player"){
			Debug.Log("Player has entered chickens trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
		}
		
	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.name == "Player"){
			scoreManager.AddPoints(points);
			transform.position = chickenPen.position;
			transform.rotation =chickenPen.rotation;
		}
	}
}
