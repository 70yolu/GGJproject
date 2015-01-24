using UnityEngine;
using System.Collections;

public class EnemyTV_BodyRotate2 : MonoBehaviour {
	
	float rotationStart = 0;


	// Use this for initialization
	void Start () {
				
		rotationStart = transform.localEulerAngles.y;

		Up ();
		
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void Up () {
		
		TweenRY.Add(transform.gameObject, 1.0f, rotationStart+9.0f).Delay(0.1f).Then(Down);

//		TweenRY.Add(transform.gameObject, 1.0f, 7.0f).Delay(0.1f).Then(Down);

//		TweenRY.Add (g:,do,float TweenRY) - CFX2_AutoRotate TweenY to value TweenRY.

	}
	
	void Down () {
		
		TweenRY.Add(transform.gameObject, 1.0f, rotationStart+0.0f).Delay(0.1f).Then(Up);

//		TweenRY.Add(transform.gameObject, 1.0f, 0.0f).Delay(0.1f).Then(Up);
	}
	
	
}



