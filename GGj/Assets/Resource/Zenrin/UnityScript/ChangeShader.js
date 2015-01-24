#pragma strict

@script ExecuteInEditMode()


function OnGUI () {
	//GUI.Label(Rect(10, 10, 100, 30), "test");
	
	//Displey Button to Geme View
	if( GUI.Button(Rect(10, 10, 100, 30), "ChangeShader") )
	{
		ShaderSetting();
	}

}

//指定文字列
private static var TransMatTag = "_TransP";	
//透過用Shader名
private static var TransparentShaderName = "Transparent/Diffuse";

/**
 * マテリアルのShaderを切り替え
 * #名前に指定文字列 "_TransP" が含まれる場合は
 * #Transparent/Diffuseを使用するよう設定する
 */
public function ShaderSetting (){
	
	//開始
	Debug.Log("Shader切替処理を開始しました。" + System.DateTime.Now.ToString("HH:mm:ss"));

	//var diffuse : Shader = null;
	//if(diffuse == null)
	//{
	//	diffuse = Shader.Find("Diffuse");
	//}

	//Shader取得
	var transShader : Shader = null;
	//if(transDiffuse == null)
	{
		transShader = Shader.Find(TransparentShaderName);
	}

	//すべてのGemeObject取得
	var gameObjs : GameObject[] = null;
	gameObjs = GameObject.FindObjectsOfType(GameObject);

	for(var i : int = 0; i < gameObjs.Length; i++)
	{
		var gameObj : GameObject = null;
		gameObj = gameObjs[i];	
		
		if(gameObj.renderer == null)
		{
			continue;
		}
		
		var num : int = 0;
		num = gameObj.renderer.sharedMaterials.Length;
		for(var j : int = 0; j < num; j++)
		{
			//マテリアル取得
			var mat : Material = null;
			mat = gameObj.renderer.sharedMaterials[j];
			if(mat == null)
			{
				continue;
			}
			//名前チェック
			if(!mat.name.Contains(TransMatTag))
			{
				//Shader変更
				continue;
			}
			
			//change
			if(mat.shader != transShader)
			{
				Debug.Log("Shaderの変更 : [" + mat.name + "]  " + mat.shader.name + " -> " + transShader.name);
				mat.shader = transShader;
			}			
		}// for j		
		
	}// for i

	//終了
	Debug.Log("Shader切替処理が完了しました。" + System.DateTime.Now.ToString("HH:mm:ss"));

}
