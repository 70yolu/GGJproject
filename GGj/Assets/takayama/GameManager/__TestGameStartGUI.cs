using UnityEngine;
using System.Collections;

public class __TestGameStartGUI : MonoBehaviour
{

	private GameTimer mGameTimer;

	public void Start ()
	{
		mGameTimer = FindObjectOfType<GameTimer>();
	}

	public void OnGUI ()
	{
		if (!mGameTimer.GameStarted)
		{
			if (GUI.Button(new Rect(Screen.width/2 - 200, Screen.height/2 - 20, 400, 40), "Game Start"))
			{
				mGameTimer.GameStart();
			}
		}
	}

}
