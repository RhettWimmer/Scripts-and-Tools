using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavWanderTest : MonoBehaviour {

	public float wanderRadius;
	public float wanderTimer;

	public Transform target;
	private UnityEngine.AI.NavMeshAgent agent;
	private float timer;

	public Transform chickenPen;

	public bool isWandering = true;
	public float moveSpeed;

	public int damage; 

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
	//spliced
	void OnTriggerStay(Collider other){
		if(other.gameObject.name == "Player"){
			Debug.Log("The Bear is attacking!");
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
	}


	void OnCollisionEnter(Collision other){
	var hit = other.gameObject;
	var health = hit.GetComponent<PlayerHeath>();

	other.gameObject.GetComponent<PlayerHeath>();

	if(health != null){
		health.TakeDamage(damage);
		}
	}	






}
