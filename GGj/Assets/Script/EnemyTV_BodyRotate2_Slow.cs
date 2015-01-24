using UnityEngine;
using System.Collections;

public class EnemyTV_BodyRotate2_Slow : MonoBehaviour {

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

		TweenRY.Add(transform.gameObject, 2.0f, rotationStart+7.0f).Delay(1.2f).Then(Down);

//		TweenRY.Add(transform.gameObject, 2.0f, 7.0f).Delay(1.2f).Then(Down);
		
		//		TweenRY.Add (g:,do,float TweenRY) - CFX2_AutoRotate TweenY to value TweenRY.
		
	}
	
	void Down () {
		TweenRY.Add(transform.gameObject, 2.0f, rotationStart+0.0f).Delay(1.2f).Then(Up);
	}
	
	
}



