using UnityEngine;
using System.Collections;

public class RadarMapArea : MonoBehaviour {
	public GameObject Player;
	private Vector3 Pos;
	
	// Use this for initialization
	void Start () {
		Pos.x = transform.position.x;
		Pos.z = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		Pos.y = Player.transform.position.y;
				
		transform.position = Pos;
	}
}
