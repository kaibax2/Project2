using UnityEngine;
using System.Collections;

public class DeletBullet : MonoBehaviour {

	CharacterStatus charaStatus;

	void OnTriggerEnter(Collider other){
		
		switch (other.tag) {
		case "kabe":
			Debug.Log("ok");
			Destroy(gameObject);
			break;

		case "Enemy1":
			Debug.Log("Enemy1");
			Destroy(gameObject);
			break;

		case "Enemy2":
			Debug.Log("Enemy2");
			Destroy(gameObject);
			break;

		case "Enemy3":
			Debug.Log("Enemy3");
			Destroy(gameObject);
			break;

		case "Enemy4":
			Debug.Log("Enemy4");
			Destroy(gameObject);
			break;

		case "Enemy5":
			Debug.Log("Enemy5");
			Destroy(gameObject);
			break;

		case "Enemy6":
			Debug.Log("Enemy6");
			Destroy(gameObject);
			break;

		case "Enemy7":
			Debug.Log("Enemy7");
			Destroy(gameObject);
			break;

		case "Enemy8":
			Debug.Log("Enemy8");
			Destroy(gameObject);
			break;

				}
		/*if(other.tag=="kabe"){
			Destroy(gameObject);
			
		}*/
	}

}
