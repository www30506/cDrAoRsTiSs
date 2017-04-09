using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController {

	public static void ChangeScene(SceneType p_targetScene){
		SceneManager.LoadSceneAsync (p_targetScene.ToString ());
	}
}
