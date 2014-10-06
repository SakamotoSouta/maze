using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	private int ballCount;		// ボールの総数
	private int counter;		// ゴールに触れているボールのカウンター
	private bool cleared;		//　クリアした
	public GUIStyle labelStyle;		// フォント
	public GameObject labelPrefab;
	private GameObject label;
	private GameObject parent;

	// Use this for initialization
	void Start () {
		parent = GameObject.Find ("Panel");
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
				// クリアした時
				if (cleared) {
					// ラベルオブジェクトの生成
					label = NGUITools.AddChild(parent, labelPrefab);
					label.transform.localScale = new Vector3(50f, 50f, 0);
					UIAnchor pos = label.GetComponent("UIAnchor") as UIAnchor;
					pos.side = UIAnchor.Side.Center;
					pos.pixelOffset = new Vector3(0f, 50f, 0f);
					UILabel str = label.GetComponent("UILabel") as UILabel;
					str.text = "CLEAR!!";
				}// if
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

}
