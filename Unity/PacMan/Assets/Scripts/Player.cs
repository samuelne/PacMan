using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	[SerializeField]
	float speed = 1;

	// Use this for initialization
	void Start ()
	{


		
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		MoveKeyboard ();

	}


	void MoveKeyboard ()
	{

		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		Rigidbody2D rigi2d = GetComponent<Rigidbody2D> ();
		Animator anim = GetComponent<Animator> ();



		// A NAVE NÃO FICA SEGUINDO CONSTANTEMENTE EM UMA DIREÇÃO ELE SERVE COMO UM PESO SOBRE A NAVE APÓS A MOVIMENTAÇÃO.
		rigi2d.drag = 800;


		if (horizontal > 0) {

			// COM MOVIMENTAÇÃO NA VERTICAL.
			rigi2d.velocity = new Vector2 (horizontal * speed, vertical * speed);

			anim.SetFloat ("DirX", 0.1f);


		} else {

			anim.SetFloat ("DirX", 0f);

		}

		if (horizontal < 0) {

			// COM MOVIMENTAÇÃO NA VERTICAL.
			rigi2d.velocity = new Vector2 (horizontal * speed, vertical * speed);

			anim.SetFloat ("DirX", -0.1f);

		} else {

			anim.SetFloat ("DirX", 0f);

		}


		if (vertical > 0) {

			// COM MOVIMENTAÇÃO NA VERTICAL.
			rigi2d.velocity = new Vector2 (horizontal * speed, vertical * speed);

			anim.SetFloat ("DirY", 0.1f);

		} else {


			anim.SetFloat ("DirY", 0f);

		}

		if (vertical < 0) {

			// COM MOVIMENTAÇÃO NA VERTICAL.
			rigi2d.velocity = new Vector2 (horizontal * speed, vertical * speed);

			anim.SetFloat ("DirY", -0.1f);

		} else {


			anim.SetFloat ("DirY", 0f);

		}

	}
}
