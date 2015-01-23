#pragma strict

function Start () {
}

function Update () {

// オブジェクトのローカル座標系でX軸に毎秒90度回転する
    transform.Rotate(new Vector3(0, 60, 0) * Time.deltaTime);



}