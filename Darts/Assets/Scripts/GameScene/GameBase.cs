using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBase : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

	public void Back(){
		SceneController.ChangeScene (SceneType.MainScene);
	}
}
