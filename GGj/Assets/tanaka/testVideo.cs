using UnityEngine;
using System.Collections;

public class testVideo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("test");
		Application.ExternalCall("alertUnityObject", " L9 testVido.cs");
		Application.ExternalCall("showVideo", "R7ttn0eVhQg,30,40,200,400");
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
			Application.ExternalCall("showVideo", "R7ttn0eVhQg,10,15,200,400");
		}
		if( Input.GetKeyDown(KeyCode.A) ){
			Application.ExternalCall("showVideo", "R7ttn0eVhQg,0,0,200,400");
		}

	}
}
