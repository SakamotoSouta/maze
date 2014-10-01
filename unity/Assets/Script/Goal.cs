using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	private int ballCount;		// ボールの総数
	private int counter;		// ゴールに触れているボールのカウンター
	private bool cleared;		//　クリアした
	public GUIStyle labelStyle;		// フォント

	// Use this for initialization
	void Start () {
		ballCount = GameObject.FindGameObjectsWithTag("Ball").Length;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// トリガーにゲームオブジェクトが進入した時の処理
	IEnumerator OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Ball") {
			counter++;
			if(cleared == false && counter == ballCount){
				// クリア判定成立
				cleared = true;
				yield return new WaitForSeconds(2);
				Application.LoadLevel("Title");
			}
		}
	}

	// トリガーからゲームオブジェクトが退出した時の処理
	void OnTriggerExit(Collider other){
		// タグからボールを判別しカウントを減らす
		if(other.gameObject.tag =="Ball" ){
			counter--;
		}
	}

	// GUI
	void OnGUI(){
		if (cleared) {
			int sw = Screen.width;
			int sh = Screen.height;
			GUI.Label(new Rect(sw / 6, sh / 3 , sw * 2 / 3, sh / 3), "CLEARED!!", labelStyle);
		}
	}
}
