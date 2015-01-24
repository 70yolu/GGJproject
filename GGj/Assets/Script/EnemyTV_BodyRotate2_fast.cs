using UnityEngine;
using System.Collections;

public class EnemyTV_BodyRotate2_fast : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Up ();
		
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void Up () {
		TweenRY.Add(transform.gameObject, 0.2f, 9.0f).Delay(0.1f).Then(Down);
		
		//		TweenRY.Add (g:,do,float TweenRY) - CFX2_AutoRotate TweenY to value TweenRY.
		
	}
	
	void Down () {
		TweenRY.Add(transform.gameObject, 0.2f, 0.0f).Delay(0.1f).Then(Up);
	}
	
	
}



