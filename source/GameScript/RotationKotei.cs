using UnityEngine;
using System.Collections;

public class RotationKotei : MonoBehaviour {

	public GameObject Enemy;

	private float rotateX = 0.0f;
	// Use this for initialization
	void Start () {
		Enemy.GetComponent<EnemyAI> ();
	}
	
	// Update is called once per frame
	void Update () {
		Enemy.transform.Rotate(rotateX, 0.0f, 0.0f);
	}
}
