using UnityEngine;
using System.Collections;

public class EnemyTV_FootMove2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Up ();


	}
	
	// Update is called once per frame
	void Update () {
	}

	void Up () {
		TweenY.Add(transform.gameObject, 1.0f, 1).Delay(1.0f).Then(Down);

	}

	void Down () {
		TweenY.Add(transform.gameObject, 1.0f, 0).Delay(1.0f).Then(Up);
	}


}



