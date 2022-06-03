using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	private float speed = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0.0f, speed, 0.0f);
		Screen.showCursor = false;
	}
}
