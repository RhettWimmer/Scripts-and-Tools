using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkNoise : MonoBehaviour {

	public AudioSource walkSound;
	void Update () {
		if(Input.GetKeyDown(KeyCode.W)){
			walkSound.Play();
		}
	}
}
