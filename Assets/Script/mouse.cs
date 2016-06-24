using UnityEngine;
using System.Collections;

public class mouse : MonoBehaviour {

	private Vector3 screenPoint;
	private Vector3 offset;
	GameManeger script;


	// Use this for initialization
	void Start () {

		script = GetComponent<GameManeger> ();
		//script.power;
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown() {
		this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
		this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		//ポジションとクリックした場所のズレを計算
	}

	void OnMouseDrag() {
		Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + this.offset; //ズレをたす
		transform.position = currentPosition;
	}

//	void OnCollisionStay2D(Collision2D coll){
//		if (coll.gameObject.tag == "drink") {
//
//			power = GetComponent<GameManeger> ();
//			power += 1 * Time.deltaTime;
//
//		}
//
//	}

}
