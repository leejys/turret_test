using UnityEngine;
using System.Collections;

//from this tutorial
//http://unrealcoder.blogspot.co.uk/2015/07/unity-automated-turret-tutorial.html
public class Tracking : MonoBehaviour {
 public float speed = 13.0f;
 //set these to null before everything starts
 public GameObject m_target = null;
 Vector3 m_lastKnownPosition = Vector3.zero;
 Quaternion m_lookAtRotation;

 // Update is called once per frame
 void Update () {
  if(m_target){
    //basically if the target isn't locked on,
   if(m_lastKnownPosition != m_target.transform.position){
    m_lastKnownPosition = m_target.transform.position;
    m_lookAtRotation = Quaternion.LookRotation(m_lastKnownPosition - transform.position);
   }

   if(transform.rotation != m_lookAtRotation){
    transform.rotation = Quaternion.RotateTowards(transform.rotation, m_lookAtRotation, speed * Time.deltaTime);
   }
  }
 }

 bool SetTarget(GameObject target){
  if(!target){
   return false;
  }

  m_target = target;

  return true;
 }
}
