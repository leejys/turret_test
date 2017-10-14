using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
//code adapted from ball rolling tutorial on unity
	//create public gameobject for the player
	public GameObject player;
	//create a private vector for the offset, because we set this with the script
private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
		}

	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
