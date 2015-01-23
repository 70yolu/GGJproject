using UnityEngine;
using System.Collections;

public class GameTimer : MonoBehaviour
{

	public float GameTime = 3 * 60; // 3 minutes;

	public bool GameStarted {
		get { return mGameStarted; }
	}

	private bool mGameStarted = false;

	public void GameStart ()
	{
		StartCoroutine(CountTimeRoutine());
		mGameStarted = true;
	}

	public IEnumerator CountTimeRoutine ()
	{
		while(GameTime > 0)
		{
			yield return null;
			GameTime -= Time.deltaTime;
		}
		GameTime = 0f;
		Debug.Log("GameTime Over");
	}

}
