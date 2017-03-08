﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	private int count;
	void start(){
		count = 0;
	}
	
	void FixedUpdate(){
		float moveHorizontal=Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement=new Vector3(moveHorizontal,0.0f,moveVertical);
		Rigidbody rb;
		rb = GetComponent<Rigidbody>();
		rb.AddForce(movement*speed*Time.deltaTime);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "PickUp"){
			other.gameObject.SetActive(false);
			count=count+1;
		}
	}
}