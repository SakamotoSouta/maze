using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Color ballColor;
	private int frameCount = 0;
	// Use this for initialization
	void Start () {
		ballColor = renderer.material.color;

		InvokeRepeating("RandomColor", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		// 60フレームカウント
		frameCount++;
		if(frameCount > 60){
			frameCount = 0;
			// 色の変更
			//renderer.material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
		}
		// ボールが動かなくなる問題の解決処理
		rigidbody.WakeUp ();
	}

	void RandomColor()
	{
		Debug.Log ("hoge");
		renderer.material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
	}
}
