﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfHealth : MonoBehaviour {
	public int currentHealth;
	public int maxHealth = 3;
	public Transform spawnPoint;
	//public int points;

	void Start () {
		currentHealth = maxHealth;		
	}

	public void TakeDamage(int amount) {
		currentHealth -= amount;
		if(currentHealth <= 0){
			currentHealth = 0;
			print("Bear is Dead!");
			//scoreManager.AddPoints(points);
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;
			currentHealth = maxHealth;
		}
	}
}
