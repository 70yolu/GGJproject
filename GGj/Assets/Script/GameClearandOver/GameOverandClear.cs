using UnityEngine;
using System.Collections;

public class GameOverandClear : MonoBehaviour {

	public void OnRetryBtn(){
		Application.LoadLevel ("GameMain");
	}
	public void OnTitleBtn(){
		Application.LoadLevel ("Title");
	}
}
