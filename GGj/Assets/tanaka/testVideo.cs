using UnityEngine;
using System.Collections;

public class testVideo : MonoBehaviour {

	private static float angleY = 0.0f;
	private bool  angleY_Flag = false;

	// Use this for initialization
	void Start () {
		Debug.Log("test");
		Application.ExternalCall("alertUnityObject", " L9 testVido.cs");
		//Application.ExternalCall("showVideo", "R7ttn0eVhQg,58,66,560,315,400,200,0");
		StartCoroutine(playVideo("R7ttn0eVhQg,58,66,720,415,300,170,0,0.5", 10.0f));
		//StartCoroutine(playVideo("PM4xY8y1Jk0,1,8,720,415,300,170,0", 5.0f));

	}
	
	void FixedUpdate ()
	{
		if( Input.GetKeyDown(KeyCode.X) ){
			if(angleY_Flag){	
			//	angleY = 0.0f;
				TweenRY.Add(this.gameObject, 0.0f, angleY);
				angleY_Flag = false;
			}
			Application.ExternalEval("killVideo()");

		}

		if( Input.GetKeyDown(KeyCode.Z) ){
			//Application.ExternalCall("showVideo", "R7ttn0eVhQg,58,66,560,315,400,200,1");
			if(!angleY_Flag){
				angleY = this.gameObject.transform.localEulerAngles.y;
				Debug.Log("L28 angleY:" + angleY);
				TweenRY.Add(this.gameObject, 0.3f, -30.0f);
				angleY_Flag = true;
			}
			StartCoroutine(playVideo("R7ttn0eVhQg,58,66,660,415,500,170,1,0.5", 10.0f));
		}

		if( Input.GetKeyDown(KeyCode.A) ){
			Application.ExternalCall("showVideo", "R7ttn0eVhQg,0,0,800,400,400,200,1,0.5");
		}

		if( Input.GetKeyDown(KeyCode.S) ){
			Application.ExternalCall("showVideo", "R7ttn0eVhQg,0,0,1080,680,120,50,0,0.8");
		}
	}

	IEnumerator playVideo (string param, float time) {
		Application.ExternalCall("showVideo", param);
		yield return new WaitForSeconds(time);
		Application.ExternalEval("killVideo()");
	}

}
