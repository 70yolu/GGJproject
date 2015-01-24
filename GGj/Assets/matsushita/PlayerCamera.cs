using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour {

	public float m_Dist = 5.0f;				// ターゲットからの距離
	public Vector3 m_TarOfs = Vector3.zero;	// ターゲットのオフセット
	public Vector3 m_PosOfs = Vector3.zero;	// カメラ位置のオフセット
	public float m_Smooth = 1.0f;			// カメラのスムース

	public GameObject m_Target;					// ターゲット
	public Vector3 m_TarToCamVec;				// ターゲットからカメラへのベクトル
	private Vector3 m_TarPos;					// 現在ターゲットにしている位置
	
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
//		Vector3 playerBack = transform.back;
/*
		Vector3 camPos = transform.position + transform.forward * m_TarToCamVec;
		Vector3 tarPos = transform.position;

		Camera.main.transform.position = camPos;
		Camera.main.transform.LookAt(tarPos);*/
	}
}
