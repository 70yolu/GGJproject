using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public float m_Speed = 10.0f;
	public float m_LifeTime = 1.0f;

	// Use this for initialization
	void Start () {
//		rigidbody.AddForce (Vector3.forward * m_Speed);
		Destroy (gameObject, m_LifeTime);		
	}
	
	// Update is called once per frame
	void Update () {
	}

	
	//------------------------------------------------------------
	// ヒット検出
	void OnCollisionEnter(Collision	collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "EnemyTV") 
		{
			collisionInfo.gameObject.SendMessage("ApplyDamage");
		}
//		Destroy (gameObject);
	}
}
