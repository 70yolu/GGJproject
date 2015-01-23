#pragma strict

function Start () {
}

function Update () {

// オブジェクトのローカル座標系でX軸に毎秒90度回転する
    transform.Rotate(new Vector3(360, 0, 0) * Time.deltaTime);



}