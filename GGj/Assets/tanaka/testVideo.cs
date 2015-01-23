using UnityEngine;
using System.Collections;

public class testVideo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("test");
		Application.ExternalCall("alertUnityObject", " L9 testVido.cs");
		Application.ExternalCall("showVideo", "R7ttn0eVhQg");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
