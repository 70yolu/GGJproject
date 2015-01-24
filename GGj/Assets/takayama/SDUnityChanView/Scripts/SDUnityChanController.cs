using UnityEngine;
using System.Collections;

public class SDUnityChanController : MonoBehaviour
{

	public GameObject Humanoid;

	public Transform LookAtPosition;
	public Transform RightHandPos;
	public Transform LeftHandPos;
	public Transform RightFootPos;
	public Transform LeftFootPos;

	private SDUnityChanView mSDUnityChanView;
	private Animator mAnimator;
	private Vector3 mLookAtPositionBase;

	public void Awake ()
	{
		mSDUnityChanView = FindObjectOfType<SDUnityChanView>();
		mAnimator = Humanoid.GetComponent<Animator>();
		mLookAtPositionBase = LookAtPosition.localPosition;
	}

	public void Update ()
	{
		float t = (Mathf.Sin(Time.time * mSDUnityChanView.HeadbandsSpeed) + 1) / 2;
		LookAtPosition.localPosition = mLookAtPositionBase + Vector3.Lerp(Vector3.zero, Vector3.up, t) * 0.1f;
	}

	public void OnAnimatorIK ()
	{
		mAnimator.SetLookAtWeight(1.0f);
		mAnimator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1.0f);
		mAnimator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1.0f);
		mAnimator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1.0f);
		mAnimator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1.0f);
		mAnimator.SetIKPositionWeight(AvatarIKGoal.RightFoot, 1.0f);
		mAnimator.SetIKRotationWeight(AvatarIKGoal.RightFoot, 1.0f);
		mAnimator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 1.0f);
		mAnimator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, 1.0f);
		mAnimator.SetLookAtPosition(LookAtPosition.position);
		mAnimator.SetIKPosition(AvatarIKGoal.RightHand, RightHandPos.position);
		mAnimator.SetIKRotation(AvatarIKGoal.RightHand, RightHandPos.rotation);
		mAnimator.SetIKPosition(AvatarIKGoal.LeftHand, LeftHandPos.position);
		mAnimator.SetIKRotation(AvatarIKGoal.LeftHand, LeftHandPos.rotation);
		mAnimator.SetIKPosition(AvatarIKGoal.RightFoot, RightFootPos.position);
		mAnimator.SetIKRotation(AvatarIKGoal.RightFoot, RightFootPos.rotation);
		mAnimator.SetIKPosition(AvatarIKGoal.LeftFoot, LeftFootPos.position);
		mAnimator.SetIKRotation(AvatarIKGoal.LeftFoot, LeftFootPos.rotation);
	}

}
