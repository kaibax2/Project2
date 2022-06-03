using UnityEngine;
using System.Collections;

public class RadarIconPlayer : MonoBehaviour {
	public GameObject Player;
	
	private Vector3 Pos;
	
	private float RotationY;
	
	// Use this for initialization
	void Start () {
		Pos.y = transform.position.y;
		
	}
	
	// Update is called once per frame
	void Update () {
		Pos.x = Player.transform.position.x;
		Pos.z = Player.transform.position.z;

		transform.forward = Player.transform.forward;
		transform.position = Pos;
		
		
		
	}
}
