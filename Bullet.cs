﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {

	}

	private void OnCollisionEnter(Collision collision){
		if (collision.gameObject.name == "PlayerBall"){
		Destroy(collision.gameObject);
		}
	}
}
