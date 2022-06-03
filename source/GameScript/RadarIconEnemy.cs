using UnityEngine;
using System.Collections;

public class RadarIconEnemy : MonoBehaviour {
	public GameObject Enemy;

	private Vector3 Pos;

	private float RotationY;

	// Use this for initialization
	void Start () {
		Pos.y = transform.position.y;

	}
	
	// Update is called once per frame
	void Update () {
		Pos.x = Enemy.transform.position.x;
		Pos.z = Enemy.transform.position.z;

		transform.forward = Enemy.transform.forward;
		transform.position = Pos;



	}
}
