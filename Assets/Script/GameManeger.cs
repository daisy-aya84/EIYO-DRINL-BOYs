using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManeger : MonoBehaviour {

	public Image gauge;
	public float power;
	public int round;
	public float maxpower;


	// Use this for initialization
	void Start () {
	
		power = 0;
		round = 1;

	}
	
	// Update is called once per frame
	void Update () {

		//Touch tch = Input.GetTouch(0);

		//round=1の時maxpower=20;
		if (round == 1) {
			maxpower = 20;
		}

		//"drink"というタグのスプライトを１秒撫でたら元気パワーが１上がる

		//if(Input.touchCount == 1){


	//}

		//Touchという関数を作る
//		Touches ();

		//とりあえず１秒たったら１上がる
		//power += 1 * Time.deltaTime;

		//gauge.fillAmount = (現在の元気パワー）/ (MAXの元気パワー);と書く
		gauge.fillAmount = power / maxpower;
		Debug.Log (power);
	
	}

//	void Touches(){
//		if(Input.GetMouseButton(0)){
//			if (Input.mousePosition == GameObject.FindWithTag ("drink").transform.position) {
//
//					power += 1 * Time.deltaTime;
//
//
//			}
//		}
//
//	
//	}

//	void OnCollisionStay2D(Collision2D coll){
//		if (coll.gameObject.tag == "drink") {
//			
//			power += 1 * Time.deltaTime;
//
//		}
//
//	}

		
}
