using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManeger2 : MonoBehaviour {

	public Image gauge;
	public static float power;
	public static int round=1;
	public static float maxpower;
	public Text power_wariai;
	public Text Round;

	// Use this for initialization
	void Start () {

		power = 0;

		SaveData ();
		LoadData ();

		Debug.Log ("Round" + round);

		//round=1の時maxpower=20;
		if (round == 1) {
			maxpower = 20;
		}



	}

	// Update is called once per frame
	void Update () {

		//gauge.fillAmount = (現在の元気パワー）/ (MAXの元気パワー);と書く
		gauge.fillAmount = power / maxpower;
		//Debug.Log (power);

		//(現在の元気パワー）/ (MAXの元気パワー);を表示する
		power_wariai.text = Mathf.FloorToInt (power) + " / " + maxpower.ToString ();

		Round.text = round.ToString ();

	}


	public static void SaveData() {


		if (round != 1) {
			string testDate = "TestData";
			PlayerPrefs.SetInt (testDate, round);

			Debug.Log ("data was saved" + round);
		} else if(round == 1){
			string testDate = "TestData";
			PlayerPrefs.SetInt (testDate, 1);
		}
	}

	public static void LoadData() {

		string testDate = "TestData";
		round = PlayerPrefs.GetInt (testDate);
		Debug.Log ("data was loaded" + round);
	}

}
