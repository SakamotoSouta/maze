using UnityEngine;
using System.Collections;

public class TiltRig : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// キー入力があった場合傾きを適用させる処理
		transform.rotation = 
			Quaternion.AngleAxis (Input.GetAxis ("Horizontal") * 10.0f, Vector3.forward) *
			Quaternion.AngleAxis (Input.GetAxis ("Vertical") * -10.0f, Vector3.right);
	}
}
