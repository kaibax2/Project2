using UnityEngine;
using System.Collections;

public class testDamage : MonoBehaviour {

	private int M4A1Damage;
	private int RedHawkDamage;
	private int P90Damage;

	public int HP;

	public Vector3 localEnemyPos;

	public GameObject Exprosion;

	public GameObject HitEffect;

	public int expFlag = 0;

	// Use this for initialization
	void Start () {
		HP = 300;
		M4A1Damage = 10;
		RedHawkDamage = 50;
		P90Damage = 5;

	}
	
	void OnCollisionEnter(Collision collision){

		switch(collision.transform.tag){
		case "bullet":
						for (int aIndex = 0; aIndex < collision.contacts.Length; ++ aIndex) {
								Debug.Log (collision.contacts [aIndex].point);
								GameObject hit = (GameObject)Instantiate (HitEffect,
				                                          collision.contacts [aIndex].point, 
				                                          				  transform.rotation);
				
								Destroy (hit, 2.0f);
						}

			HP -= M4A1Damage;
				break;

		case "RedHawkBullet":
			for (int aIndex = 0; aIndex < collision.contacts.Length; ++ aIndex) {
				Debug.Log (collision.contacts [aIndex].point);
				GameObject hit = (GameObject)Instantiate (HitEffect,
				                                          collision.contacts [aIndex].point, 
				                                          transform.rotation);
				
				Destroy (hit, 2.0f);
			}

			HP -= RedHawkDamage;
			break;
			
		case "P90Bullet":
			for (int aIndex = 0; aIndex < collision.contacts.Length; ++ aIndex) {
				Debug.Log (collision.contacts [aIndex].point);
				GameObject hit = (GameObject)Instantiate (HitEffect,
				                                          collision.contacts [aIndex].point, 
				                                          transform.rotation);
				
				Destroy (hit, 2.0f);
			}

			HP -= P90Damage;
			break;
		}
	}
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Destroy");
		if (HP <= 0) {
			Debug.Log ("Destroy");

			audio.Play();
			GameObject obj = (GameObject)Instantiate(Exprosion, transform.position, transform.rotation);

			Destroy(obj, 2.0f);
			Destroy(gameObject);
			GameOverClear.GOCflag += 1;


				}
	}

	void HitEffectPlay(){
		GameObject hit = (GameObject)Instantiate (HitEffect, transform.position, transform.rotation);

		Destroy (hit, 2.0f);
	}
}
