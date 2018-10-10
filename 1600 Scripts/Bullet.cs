using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bullet : MonoBehaviour {
	public int damage = 1; //how much damage it does
	public int time = 5; //how long it lives before leaving;

	// public Text catWarn;
	
	// public Text noShootCat;

	void Start () {
		StartCoroutine(DestroyBullet());
		// catWarn.GetComponent<Text>().enabled = false;
	}
	
	 void OnCollisionEnter(Collision other){
		var hit = other.gameObject;
		var health = hit.GetComponent<wolfHealth>();

		if(health != null){
			health.TakeDamage(damage);
		}

		if(other.gameObject.name == "McGee"){
			// catWarn.GetComponent<Text>().enabled = true;
			Debug.Log("DONOTHITMCCGEE");
		}
	}
		
		IEnumerator DestroyBullet(){
			yield return new WaitForSeconds(time); 
			Destroy(gameObject);	
	}
}
