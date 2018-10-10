using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavWander : MonoBehaviour {

	public float wanderRadius;
	public float wanderTimer;

	public Transform target;
	private UnityEngine.AI.NavMeshAgent agent;
	private float timer;

	public Transform chickenPen;

	public int  points; 
	public bool isWandering = true;
	public float moveSpeed;

	// public float timeOnScreen = 5;

	//  public GameObject rock;

	 public Text catWarn;

	void Start(){
		catWarn.GetComponent<Text>().enabled = false;
	}
	void OnEnable(){
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> () ;
		timer = wanderTimer;
	}

	void Update () {
		timer += Time.deltaTime;

		if (timer >= wanderTimer){
			Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
			agent.SetDestination(newPos);
			timer = 0;
		}
	}
	public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask){
		Vector3 randDirection = Random.insideUnitSphere * dist;

		randDirection += origin;

		UnityEngine.AI.NavMeshHit navHit;

		UnityEngine.AI.NavMesh.SamplePosition (randDirection, out navHit, dist, layermask);

		return navHit.position;
	}
		//Chicken Interaction
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
			// transform.position = chickenPen.position;
			// transform.rotation =chickenPen.rotation;
			Destroy(gameObject);
			Debug.Log("You've caught a cat");
		}

		if(other.gameObject.name == "Bullet 1 1(Clone)"){
		catWarn.GetComponent<Text>().enabled = true;
		Debug.Log("DO NOT SHOOT CAT");
		}		
	}

	// IEnumerator deleteText(){
	// 	yield return new WaitForSeconds(timeOnScreen); 
	// 	Destroy(catWarn);	
	// }
}
