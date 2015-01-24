#pragma strict
var UpDown;

function Start () {
	UpDown=false;
}
	
function Update () {

// オブジェクトの上下運動
	
	if(UpDown==false)
		{
//		    transform.position.Set(new Vector3(0.0, 10.0, 0.0) * Time.deltaTime);
		    
		    transform.localPosition.y = Mathf.Sin(Time.time) * 0.01;
		    
		}
	else
		{
//		    transform.position.Set(new Vector3(0.0, -10.0, 0.0) * Time.deltaTime);

		    transform.localPosition.y = Mathf.Sin(Time.time) * -0.01;
		
						}

	if(transform.position.y==10)
		{
			UpDown=true;
		}

	if(transform.position.y==-10)		
		{
			UpDown=false;
		}
}