using System.Collections;
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
		//seriously this isn't the best way but will do for now
		if (collision.gameObject.tag == "Player"){
		Destroy(collision.gameObject);
		}
	}
}
