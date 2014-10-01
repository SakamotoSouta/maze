using UnityEngine;
using System.Collections;

public class FlickerEffect : MonoBehaviour {
	
	private Color originalColor;

	// Use this for initialization
	void Start () {
		originalColor = renderer.material.color;	
	}
	
	// Update is called once per frame
	void Update () {
		float lavel = Mathf.Abs (Mathf.Sin (Time.time * 5));
		renderer.material.color = originalColor * lavel;	
	}
}
