using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GamePage : Page_Base {

	void Start () {
		
	}

	void Update () {
		
	}

	public void OnSetGameType(string p_gameName){
		print ("<color=blue><size=25>" + "設定遊戲類型" + "</size></color>");
		Game.Type = (GameType)Enum.Parse(typeof(GameType), p_gameName);
		print (Game.Type);
		PageManerger.ChangePage (PageType.GameSettingPage);
	}
}
