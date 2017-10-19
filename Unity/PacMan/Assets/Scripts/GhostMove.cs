using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMove : MonoBehaviour {

	public Transform [] destino;
	public float speed = 0.3f;
	int controle = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	void FixedUpdate() {

		if (transform.position != destino [controle].position) {
			

			Vector2 p = Vector2.MoveTowards (transform.position, destino [controle].position, speed);

			GetComponent<Rigidbody2D> ().MovePosition (p);

		} else {

			controle = (controle + 1) % destino.Length;

		}



		Vector2 dir = destino[controle].position - transform.position;



		GetComponent<Animator> ().SetFloat ("DirX", dir.x);
		GetComponent<Animator> ().SetFloat ("DirY", dir.y);



	}


	void OnTriggerEnter2D (Collider2D co) {

		if (co.name == "pacman")
			Destroy (co.gameObject);


	}
}
