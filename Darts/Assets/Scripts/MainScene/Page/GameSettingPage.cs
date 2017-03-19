using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettingPage : Page_Base {
	[SerializeField]private Text gameTitle;
	[SerializeField]private GameObject[] legsObjs;
	[SerializeField]private GameObject[] playersObjs;

	void Start () {
		
	}
	
	void Update () {
		
	}

	public override IEnumerator IE_OnOpen(){
		OnSetTotalLegsBtn (1);
		OnSetMaxPlayerCountBtn (1);
		gameTitle.text = Game.Type.ToString ();
		yield return null;
	}

	public void OnSetTotalLegsBtn(int p_legs){
		print ("<color=blue><size=25>" + "設定回合" + "</size></color>");
		Game.TotalLegs = p_legs;
		UnselectALLLegs ();
		SelectLegs (p_legs);
	}

	private void SelectLegs(int p_selectLegs){
		print ("選取" + p_selectLegs + "回合");
		legsObjs [p_selectLegs/2].GetComponent<Image> ().color = Color.red;
	}

	private void UnselectALLLegs(){
		print ("取消選取全部回合");
		for(int i=0; i< legsObjs.Length; i++){
			legsObjs [i].GetComponent<Image> ().color = Color.white;
		}
	}

	public void OnSetMaxPlayerCountBtn(int p_playerCount){
		print ("<color=blue><size=25>" + "設定玩家人數" + "</size></color>");
		Game.MaxPlayer = p_playerCount;
		UnselectAllPlayerCount ();
		SelcePlayerCount (p_playerCount);
	}

	private void SelcePlayerCount(int p_playersCount){
		print ("選取" + p_playersCount + "個玩家");
		playersObjs [p_playersCount-1].GetComponent<Image> ().color = Color.red;
	}

	private void UnselectAllPlayerCount(){
		print ("取消選取全部玩家人數");
		for (int i = 0; i < playersObjs.Length; i++) {
			playersObjs[i].GetComponent<Image> ().color = Color.white;
		}
	}

	public void OnStartGameBtn(){
		print ("<color=blue><size=25>" + "開始遊戲" + "</size></color>");
		Game.NowLegs = 0;

	}
}
