using UnityEngine;
using System.Collections;

public class radarCamera : MonoBehaviour {

	public GameObject Player;
	private Vector3 Pos;
	
	// Use this for initialization
	void Start () {
		Pos.y = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		Pos.x = Player.transform.position.x;
		Pos.z = Player.transform.position.z;
		
		transform.position = Pos;
	}
}
