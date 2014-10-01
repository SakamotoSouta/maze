using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// ボールが動かなくなる問題の解決処理
		rigidbody.WakeUp ();
	}
}
