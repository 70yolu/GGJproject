using UnityEngine;
using System.Collections;

public class testVideo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("test");
		Application.ExternalCall("alertUnityObject", " L9 testVido.cs");
		Application.ExternalCall("showVideo", "R7ttn0eVhQg,30,40,560,315,200,400,0");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate ()
	{
		if( Input.GetKeyDown(KeyCode.X) ){
			Application.ExternalEval("killVideo()");
		}
		if( Input.GetKeyDown(KeyCode.Z) ){
			Application.ExternalCall("showVideo", "R7ttn0eVhQg,10,15,560,315,200,400,1");
		}
		if( Input.GetKeyDown(KeyCode.A) ){
			Application.ExternalCall("showVideo", "R7ttn0eVhQg,0,0,800,400,200,400,1");
		}

		if( Input.GetKeyDown(KeyCode.S) ){
			Application.ExternalCall("showVideo", "R7ttn0eVhQg,0,0,1280,720,0,0,0");
		}
	}
}
