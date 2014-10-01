using UnityEngine;
using System.Collections;

public class Trap : MonoBehaviour {
	
	// 触れた瞬間
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Ball") {
			GameObject respawn = GameObject.FindWithTag("Respawn");
			other.gameObject.transform.position = respawn.transform.position;
		}
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
}
