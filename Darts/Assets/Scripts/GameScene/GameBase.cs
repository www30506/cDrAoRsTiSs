using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBase : MonoBehaviour {
	[Header("遊戲數值")]
	[SerializeField]protected int nowRound;

	void Start () {
		
	}

	void Update () {
		if (IsThrowDart ()) {
		
		}

	}

	protected bool IsThrowDart(){
		return false;
	}

	protected void DoThrowDart(){

	}

	protected virtual void OnChangePlayer(){
	}

	protected virtual void OnChangeRound(){
	}

	protected virtual void OnHit(){
	}

	protected virtual void OnGameOver(){
	}

	public void Back(){
		SceneController.ChangeScene (SceneType.MainScene);
	}
}
