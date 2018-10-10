using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfDamage : MonoBehaviour {
	public int damage;

	void OnCollisionEnter(Collision other){
		print("Wolf is attacking");
		var hit = other.gameObject;
		var health = hit.GetComponent<PlayerHeath>();

		other.gameObject.GetComponent<PlayerHeath>();

		if(health != null){
			health.TakeDamage(damage);
		}		
	}
}
