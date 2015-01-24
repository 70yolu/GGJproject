using UnityEngine;
using System.Collections;

public class UnityChanController : MonoBehaviour {

	private enum EState
	{
		STATE_START = 0,
		STATE_WAIT,
		STATE_SHOT
	};

	private		EState				m_State = EState.STATE_START;				// 状態

	public bool m_Shot = false;									// ショットフラグ.
	public bool m_Repeat = false;
	public		bool				m_Fire = false;									// ショットフラグ.
	public		float				m_BulletSpeed = 10000.0f;			// 弾のスピード.
	public		float				m_BulletClickZ = 100.0f;			// 弾のスピード.
	public		Animator			m_Animator{ get; private set; }			// アニメータ.
	public		GameObject			m_Bullet;								// 弾.

	// Use this for initialization
	void Start () {
		m_Animator = GetComponent<Animator>();
		m_State	= EState.STATE_START;
	}
	
	// Update is called once per frame
	void Update () {

		AnimatorStateInfo animInfo = m_Animator.GetCurrentAnimatorStateInfo(0);

		float animSpeed = 1.0f;

		// 発射ボタン.
		bool oldFire = m_Fire;
		if (Input.GetButton("Fire1"))
		{
			m_Fire = true;
		}
		else
		{
			m_Fire = false;
		}
		m_Repeat = false;

		switch (m_State) 
		{
            // 構えまでのモーション.
			case EState.STATE_START:
			{
				if (!animInfo.IsName ("Start")) 
				{
    				m_State = EState.STATE_WAIT;
				};
			}
			break;

			// 構え.
            case EState.STATE_WAIT:
			{
				if (animInfo.IsName("Shot"))
				{
					animSpeed = 3.0f;
					break;
				}

				if( (m_Fire && !oldFire) || m_Shot)
				{
					ShotBullet();
				}
            }
            break;

			// 発射.
			case EState.STATE_SHOT:
			{
				animSpeed = 3.0f;
				m_Shot = false;

				if( m_Fire && !oldFire)
				{
					m_Shot = true;
					m_Repeat = true;
					m_State = EState.STATE_WAIT;
				}

				if (animInfo.IsName ("Wait"))
				{
					m_State = EState.STATE_WAIT;
				}
			}
			break;

		};

		// アニメーターにパラメータをセット.
		m_Animator.SetBool ("shot", m_Shot);
		m_Animator.SetBool("repeat", m_Repeat);
		m_Animator.speed = animSpeed;
	}
	
	// 弾発射.
	void
	ShotBullet()
	{
		Vector3 firePos = transform.position;

		//				GameObject LeftHand = GameObject.Find("Character1_LeftHand");
		GameObject LeftHand = GameObject.Find("littleF_L3");

		if (LeftHand)
		{
			firePos = LeftHand.transform.position;
		}

		GameObject bullet = Instantiate(m_Bullet, firePos, transform.rotation) as GameObject;

		Vector3 clickPosition = Input.mousePosition;
		clickPosition.z = m_BulletClickZ;

		Vector3 bulletVec = Camera.main.ScreenToWorldPoint(clickPosition) - firePos;
		bulletVec.Normalize();

		Rigidbody rigid = bullet.GetComponent<Rigidbody>();
		rigid.AddForce(bulletVec * m_BulletSpeed);

		m_Shot = true;
		m_State = EState.STATE_SHOT;
	}
}