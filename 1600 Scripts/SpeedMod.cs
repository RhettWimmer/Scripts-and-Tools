using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedMod : MonoBehaviour {
	public float moveSpeed;

	
	void Update () {
		 var speed = Input.GetAxis("Fast")*Time.deltaTime * moveSpeed;

		 transform.Translate(0,0,speed);

	}
}
