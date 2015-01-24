#pragma strict

var explosionPrefab : GameObject; //爆発エフェクト

private var damaged : boolean; //ダメージを受けた判定
private var killTimer : float; //消滅までの時間

function Start () {
}

function ApplyDamage(){
	if(!damaged){
		damaged = true;
		killTimer = 0.4;
		}

}

function Update () {
	if(!damaged){
		damaged = true;
		killTimer -= Time.deltaTime;
		if(killTimer <= 0.0) {
			//エフェクトを出しつつ、自身のゲームオブジェクトを破壊
			Instantiate(explosionPrefab, transform.position, transform.rotation);
			Destroy(GameObject);
		}
	}
}


	

