using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingPage : Page_Base {
	[SerializeField]private GameObject[] languageObjs;

	void Start () {
		
	}
	
	void Update () {
		
	}

	public override IEnumerator IE_OnOpen(){
		print ("<color=green><size=25>" + "設定頁面開啟" + "</size></color>");

		string _nowLanguage = I2.Loc.LocalizationManager.CurrentLanguage;
		UnselectAllLanguage ();
		SelectLanguage (_nowLanguage);
		yield return null;
	}

	public void OnSetLanguageBtn(string p_language){
		print ("<color=blue><size=25>" + "設定語言"+ p_language+ "</size></color>");
		I2.Loc.LocalizationManager.CurrentLanguage = p_language;
		UnselectAllLanguage ();
		SelectLanguage (p_language);
	}

	private void SelectLanguage(string p_language){
		print ("選取" + p_language + "個玩家");
		if (p_language == "English") {
			languageObjs [0].GetComponent<Image> ().color = Color.red;
		} 
		else if (p_language == "Chinese") {
			languageObjs [1].GetComponent<Image> ().color = Color.red;
		}
		else if (p_language == "Cha") {
			languageObjs [2].GetComponent<Image> ().color = Color.red;
		}
	}

	private void UnselectAllLanguage(){
		print ("取消選取全部玩家人數");
		for (int i = 0; i < languageObjs.Length; i++) {
			languageObjs[i].GetComponent<Image> ().color = Color.white;
		}
	}
}
