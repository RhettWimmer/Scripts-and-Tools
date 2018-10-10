using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavWolfAI : MonoBehaviour {

	public Transform player;
	public float speed;
	public int damage;
	//Wander
	public float wanderRadius;
	public float wanderTimer;
	//Detection
	public float alertDist;
	public float attackDist;
	//Private
	private Animator state;
	private Vector3 direction;
	private Transform target;
	private UnityEngine.AI.NavMeshAgent agent;
	private float timer;
	private float distance;

	void OnEnable () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		timer = wanderTimer;
	}
	void Start () {
		state = GetComponent<Animator>();
		distance = Vector3.Distance(player.position, transform.position);
	}

    void Update(){
		distance = Vector3.Distance(player.position, transform.position);
		//Alert
		if(distance < alertDist && distance > attackDist){
		print("Bear sees player");
			state.SetBool("IsFollowing",true);
			state.SetBool("IsWandering",false);
			state.SetBool("IsAttacking",false);
			speed = speed + 2;
			transform.LookAt(player);
			transform.Translate(Vector3.forward*speed*Time.deltaTime);
		}
		//Attacking
		else if(distance <= alertDist){
		print("Following");
			direction = player.position - transform.position;
			direction.y = 0;

			//transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction),0.09f*Time.deltaTime);
			//transform.Translate(Vector3.forward*speed*Time.deltaTime);

			state.SetBool("isFollowing",false);
			state.SetBool("isAttacking",true);
			state.SetBool("isWandering",false);

			speed = speed - 10;

			transform.LookAt(player);
			transform.Translate(Vector3.forward*speed*Time.deltaTime);

			if(direction.magnitude <= attackDist){
				print("Bear is Attacking!");
				state.SetBool("isFollowing",false);
				state.SetBool("isAttacking",true);
				state.SetBool("isWandering",false);
				var hit = player.gameObject;
				var health = hit.GetComponent<PlayerHeath>();

				if(health != null){
					health.TakeDamage(damage);
				}
			}
		}
	//wandering
	else if(distance > alertDist){
	print("Wander");
		timer += Time.deltaTime;

			state.SetBool("isFollowing",false);
			state.SetBool("isAttacking",false);
			state.SetBool("isWandering",true);

		if (timer >= wanderTimer){
		Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
		agent.SetDestination(newPos);
		timer = 0;
			}
		}
	}
	public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask){
		Vector3 randDirection = Random.insideUnitSphere * dist;
		
		randDirection += origin;
		
		UnityEngine.AI.NavMeshHit navHit;

		UnityEngine.AI.NavMesh.SamplePosition (randDirection, out navHit, dist, layermask);
		
		return navHit.position;
	}
}
