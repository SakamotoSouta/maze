using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	// Use this for initialization
	void Start () {
		InvokeRepeating("RandomColor", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {

		// ボールが動かなくなる問題の解決処理
		rigidbody.WakeUp ();
	}

	void RandomColor()
	{
		renderer.material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
	}
}
