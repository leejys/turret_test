using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//modified from this tutorial: https://www.youtube.com/watch?v=FD9HZB0Jn1w
//note that this iwll need to fire on its own, not be triggered by a space. modify later.
//also could probably just have inherited, but whatever
public class AutoFire : MonoBehaviour
{
    //Drag in the Bullet Emitter from the Component Inspector.
    public GameObject Barrel;

    //Drag in the Bullet Prefab from the Component Inspector.
    public GameObject Bullet;

    //Enter the Speed of the Bullet from the Component Inspector.
    public float Bullet_Forward_Force;

		private bool FireFlag;

	// Use this for initialization
	void Start ()
    {
	}
  //experimenting with ontriggerstay, ontriggerenter
  //what we want is ontriggerstay (just spams bullets while the playerball is in the zone)
	void OnTriggerStay(Collider other){
		//Destroy(other.gameObject)
    //The Bullet instantiation happens here.
    if (other.gameObject.tag == "Player"){
			//Fire();
      Invoke("Fire", 0.3f);
          }
	}

	void Fire(){
		GameObject Temporary_Bullet_Handler;
		Temporary_Bullet_Handler = Instantiate(Bullet,Barrel.transform.position,Barrel.transform.rotation) as GameObject;

		//Sometimes bullets may appear rotated incorrectly due to the way its pivot was set from the original modeling package.
		//This is EASILY corrected here, you might have to rotate it from a different axis and or angle based on your particular mesh.
		//don't change this or the bullets will fly up/to the side
		Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 0);

		//Retrieve the Rigidbody component from the instantiated Bullet and control it.
		Rigidbody Temporary_RigidBody;
		Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

		//Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force.
		Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);
		//don't correct this
		//Temporary_RigidBody.AddForce(transform.up * Bullet_Forward_Force);﻿

		//Basic Clean Up, set the Bullets to self destruct after 10 Seconds, I am being VERY generous here, normally 3 seconds is plenty.
		Destroy(Temporary_Bullet_Handler, 2.0f);

  //  yield WaitForSeconds(5);
	}
	// Update is called once per frame

	void Update ()
    {
      //do something or whatever
      }
}
