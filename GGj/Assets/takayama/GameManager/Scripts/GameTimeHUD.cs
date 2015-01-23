using UnityEngine;
using System.Collections;

public class GameTimeHUD : MonoBehaviour
{

	private GameTimer mGameTimer;

	public void Start ()
	{
		mGameTimer = FindObjectOfType<GameTimer>();
	}

	public void OnGUI ()
	{
		if (mGameTimer != null)
		{
			GUI.TextField(
				new Rect(Screen.width - 210, 10, 200, 20),
				string.Format("Game Time {0}", mGameTimer.GameTime)
			);
		}
	}

}
