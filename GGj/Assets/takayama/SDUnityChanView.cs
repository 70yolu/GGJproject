using UnityEngine;
using System.Collections;

public class SDUnityChanView : MonoBehaviour
{

	public bool ikActive = true;

	public GameObject Humanoid;

	public Transform LeftHandPosition;

	private Animator mAnimator;

	public void Awake ()
	{
		mAnimator = Humanoid.GetComponent<Animator>();
	}

	public void Update ()
	{
		if (ikActive)
		{
			mAnimator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1.0f);
			mAnimator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1.0f);
			mAnimator.SetIKPosition(AvatarIKGoal.LeftHand, LeftHandPosition.position);
			mAnimator.SetIKRotation(AvatarIKGoal.LeftHand, LeftHandPosition.rotation);
		}
		else
		{
			mAnimator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 0);
			mAnimator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 0);
		}
	}

}
