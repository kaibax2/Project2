using UnityEngine;
using System.Collections;

public class AtariEffect : MonoBehaviour {
	public int cnt;

	private GameObject obj;

	public GameObject HP;

	// Use this for initialization
	void Start () {
		cnt = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void  OnParticleCollision (GameObject other)
	{
		obj = other.gameObject;
		Debug.Log ("ok");

		if (obj.tag == "Player") {
			cnt++;
			HP.SendMessage("HPDown");
			Debug.Log ("AttackHIT to player down HP"+cnt);
		}
		/*ParticleSystem shuriken = other.GetComponent<ParticleSystem>();
		ParticleSystem.CollisionEvent[] ces = new ParticleSystem.CollisionEvent[shuriken.safeCollisionEventSize];
		int count = shuriken.GetCollisionEvents (gameObject, ces);
		foreach(ParticleSystem.CollisionEvent item in ces) {
			// action
			Debug.Log (item.collider);
			if(item.collider == "player")Debug.Log("WRYYYYYYYYYYYYYYYYYYYYYYYYYYYYY");
			//Destroy (effect, 100.0f);
		}*/


	}
}
