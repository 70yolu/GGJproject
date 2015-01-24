using UnityEngine;
using System.Collections;

public class TextureChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Start");
		
	}
	
	// Update is called once per frame
	const float TIME_INTERVAL = 3.0f;
	private float timer = TIME_INTERVAL;
	void Update () {
		timer -= Time.deltaTime;
		if( 0.0f >= timer ){
			// タイマーが終わった時の処理
			// 必要があればタイマー再びセット
			timer = TIME_INTERVAL;
			
			Debug.Log ("Timmer!");
		}
	}
}
