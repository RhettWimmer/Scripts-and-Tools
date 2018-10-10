using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatHitWarn : MonoBehaviour {

	public GameObject rock;
	public GameObject catNav;
	void Update(){
		rock.GetComponent<Bullet>();
		catNav.GetComponent<NavWander>();
	}

	void OnCollisionEnter(Collision other){
		if(rock == catNav){
			Debug.Log("cat has been hit");
		}		
	}
}
