using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SDUnityChanView : MonoBehaviour
{

	public float Health = 50f;

	public float HeadbandsSpeed = 3f;

	private float mLastHealth;

	private Animator mProgrammingUnityChanAnimator;

	public void Awake ()
	{
		mLastHealth = Health;
		SDUnityChanController mSDUnityChanController = GetComponentInChildren<SDUnityChanController>();
		mProgrammingUnityChanAnimator = mSDUnityChanController.GetComponent<Animator>();
	}

	public void Update ()
	{
		if (mProgrammingUnityChanAnimator != null)
		{
			// on changed Health value
			if (Health != mLastHealth)
			{
				mProgrammingUnityChanAnimator.SetFloat("Health", Health);
			}
		}
		else
		{
			Debug.LogError("SDUnityChanControllerが見つかりませんでした");
		}
		mLastHealth = Health;
	}

}
