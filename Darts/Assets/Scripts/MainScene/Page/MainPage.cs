using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPage : Page_Base {

	void Start () {
		
	}

	void Update () {
		
	}

	public void OnToGameBtn(){
		print ("<color=blue><size=25>" + "去遊戲頁面" + "</size></color>");
		PageManerger.ChangePage (PageType.GamePage);
	}

	public void OnToSettingBtn(){
		print ("<color=blue><size=25>" + "去設定頁面" + "</size></color>");
		PageManerger.ChangePage (PageType.SettingPage);	
	}

	public void OnToShopBtn(){
		print ("<color=blue><size=25>" + "去商店頁面" + "</size></color>");
		PageManerger.ChangePage(PageType.ShopPage);
	}
}
