using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Novel;

public class sceneriboD : MonoBehaviour {

	public static int drinkflag;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if(GameManeger.round  == 1){
			if (GameManeger.power >= GameManeger.maxpower) {

				GameManeger.maxpower = 40;
				GameManeger.power = 0;
				GameManeger.round++;

				Debug.Log ("round : " + GameManeger.round);

				GameManeger.SaveData ();

				Debug.Log (GameManeger.round);
				NovelSingleton.StatusManager.callJoker ("tall/riboD1", "");


			}
		}


		if (GameManeger.round == 2) {
			if (GameManeger.power >= GameManeger.maxpower) {

				NovelSingleton.StatusManager.callJoker ("tall/riboD2", "");
				GameManeger.power = 0;

			}
		}

	
	}

	public void ButtonPush(){

		NovelSingleton.StatusManager.callJoker("tall/title","");

	}
}
