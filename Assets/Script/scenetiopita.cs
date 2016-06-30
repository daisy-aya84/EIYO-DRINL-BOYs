using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Novel;

public class scenetiopita : MonoBehaviour {

	public static int drinkflag;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


		if (GameManeger2.round == 1) {
			if (GameManeger2.power >= GameManeger2.maxpower) {

				GameManeger2.maxpower = 40;
				GameManeger2.power = 0;
				GameManeger2.round++;

				Debug.Log ("round : " + GameManeger2.round);

				GameManeger2.SaveData ();

				Debug.Log (GameManeger2.round);
				NovelSingleton.StatusManager.callJoker ("tall/tiopita1", "");

			}
		}

		if (GameManeger2.round == 2) {
			if (GameManeger2.power >= GameManeger2.maxpower) {

				NovelSingleton.StatusManager.callJoker ("tall/tiopita2", "");
				GameManeger2.power = 0;

			}
		}

	}

	public void ButtonPush(){

		NovelSingleton.StatusManager.callJoker("tall/title","");

	}
}
